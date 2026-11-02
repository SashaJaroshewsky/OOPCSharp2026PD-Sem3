namespace FirstModuleTheory._012
{
    public class A
    {
        public virtual void MyMethod()// virtual - ключове слово, яке вказує, що метод може бути перевизначений у похідних класах.
        {
            Console.WriteLine("Метод MyMethod() з класу A");
        }
    }

    public class B : A
    {
        // не поліморфізм, а приховування (hiding) методу базового класу (Пізніше дайте відповідь чому це не поліморфізм)
        public new void MyMethod() // new - ключове слово, яке вказує, що метод приховує метод базового класу.
        {
            base.MyMethod(); // Виклик базової реалізації методу MyMethod() з класу A
            Console.WriteLine("Метод MyMethod() з класу B");
        }
    }

}
