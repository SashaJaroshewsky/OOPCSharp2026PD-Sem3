namespace FirstModuleTheory
{
    // Імплементація — це зв'язок, за якого клас зобов'язується виконати контракт, описаний в інтерфейсі,
    // тобто надати реалізацію всіх його членів.

    // Клас може реалізовувати кілька інтерфейсів одночасно.
    // У UML позначається пунктирною лінією з порожнім трикутником (▷), спрямованим на інтерфейс.

    // Інтерфейс описує, ЩО вміє об'єкт; клас вирішує, ЯК саме.
    public interface IPayable
    {
        decimal CalculatePayment();
    }

    public interface IPrintable
    {
        void Print();
    }

    // Клас реалізує два інтерфейси одночасно.
    public class Invoice : IPayable, IPrintable
    {
        public decimal Amount { get; init; }

        public decimal CalculatePayment() => Amount * 1.2m;   // з ПДВ
        public void Print() => Console.WriteLine($"Рахунок: {CalculatePayment()} грн");
    }
}
