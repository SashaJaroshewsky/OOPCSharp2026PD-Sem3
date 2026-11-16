using System.Collections; // Старі (неузагальнені) колекції, наприклад ArrayList

namespace SecondModuleTheory.ProblemWithoutGenerics
{
    // ТЕМА: Навіщо потрібні узагальнення (generics)? Проблема, яку вони вирішують.

    // АНАЛОГІЯ:
    // Уявіть склад, де всі товари складають в однакові непідписані коробки.
    // Покласти можна що завгодно, але щоб дізнатися, що всередині, коробку треба відкрити.
    // Чекали книжку - а там чашка. Помилку виявили лише тоді, коли вже відкрили коробку.

    // ПОЯСНЕННЯ:
    // Припустимо, нам потрібен клас "Коробка", що зберігає одне значення.
    // Без узагальнень є лише два шляхи, і обидва погані.

    // Шлях 1: окремий клас для кожного типу -> дублювання коду.
    // Логіка однакова, відрізняється лише тип. Для 10 типів - 10 майже однакових класів.
    public class IntBox
    {
        public int Value { get; set; }
        public IntBox(int value) { Value = value; }
    }

    public class StringBox
    {
        public string Value { get; set; }
        public StringBox(string value) { Value = value; }
    }

    // Шлях 2: зберігати все як object.
    // object - базовий тип для всіх типів у .NET, тому змінній типу object можна присвоїти що завгодно.
    // Один клас на всі випадки, але ми втрачаємо інформацію про тип.
    public class ObjectBox
    {
        public object Value { get; set; }
        public ObjectBox(object value) { Value = value; }
    }

    internal static class Demo
    {
        public static void Run()
        {
            ObjectBox box = new ObjectBox(42);

            // Проблема 1: потрібне явне приведення типу (cast) при кожному читанні.
            int number = (int)box.Value;

            // Проблема 2: немає типобезпеки.
            // Типобезпека (type safety) - гарантія компілятора, що зі значенням працюють лише відповідно до його типу.
            // Компілятор дозволяє покласти рядок туди, де ми чекали число:
            box.Value = "сорок два";
            // int broken = (int)box.Value; // Скомпілюється, але під час виконання - InvalidCastException!
            // Помилка, яку міг би знайти компілятор, "доживає" до запуску програми.

            // Проблема 3: упаковка та розпаковка (знижують продуктивність).
            // Упаковка (boxing) - перетворення значення значимого типу (int, double, struct) на object.
            //   Значення копіюється в новий об'єкт у купі (heap) - це додаткова пам'ять і робота для збирача сміття.
            // Розпаковка (unboxing) - зворотне перетворення object -> значимий тип через явне приведення.
            object boxed = number;      // boxing
            int unboxed = (int)boxed;   // unboxing

            // Ті самі проблеми у старій колекції ArrayList (зберігає елементи як object).
            ArrayList list = new ArrayList();
            list.Add(10);      // boxing
            list.Add(20);      // boxing
            list.Add("30");    // Компілятор не заперечує - це ж теж object

            int sum = 0;
            foreach (object item in list)
            {
                // sum += (int)item; // На елементі "30" програма впаде з InvalidCastException
                if (item is int value) // Доводиться перевіряти тип вручну
                {
                    sum += value;
                }
            }

            Console.WriteLine($"Сума: {sum}, розпаковане значення: {unboxed}");

            // ВИСНОВОК: потрібен спосіб написати код ОДИН раз, але так, щоб він працював з КОНКРЕТНИМ типом,
            // який компілятор знає і перевіряє. Це і є узагальнення (generics) - наступна тема.
        }
    }
}
