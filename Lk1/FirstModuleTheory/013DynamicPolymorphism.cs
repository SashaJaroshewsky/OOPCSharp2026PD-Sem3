namespace FirstModuleTheory._013
{
    // Динамічний поліморфізм (dynamic polymorphism) — це здатність об'єктів різних класів реагувати на один і той же виклик методу по-різному,
    // залежно від їхнього фактичного типу під час виконання програми.

    public class A
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Метод MyMethod() з класу A");
        }
    }

    public class B : A
    {
        public override void MyMethod() // Поліморфізм досягається за допомогою ключових слів virtual (у базовому класі) та override (у похідному класі).
        {
            Console.WriteLine("Метод MyMethod() з класу B");
        }
    }

    public class C : A
    {
        public override void MyMethod()
        {
            Console.WriteLine("Метод MyMethod() з класу C");
        }
    }

    internal class Example
    {
        public void ExampleDynamicPolymorphism()
        {
            A objA = new A();
            A objB = new B(); // Поліморфізм: об'єкт класу B присвоюється змінній типу A
            A objC = new C(); // Поліморфізм: об'єкт класу C присвоюється змінній типу A
            objA.MyMethod(); // Викликається метод з класу A
            objB.MyMethod(); // Викликається метод з класу B (перевизначений)
            objC.MyMethod(); // Викликається метод з класу C (перевизначений)

            // Дія одна - поведінка різна,
            // залежно від фактичного типу об'єкта (A, B або C) під час виконання.
        }
    }
}
