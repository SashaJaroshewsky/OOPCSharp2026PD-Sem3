namespace FirstModuleTheory._011
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
        public override void MyMethod() // override - ключове слово, яке вказує, що метод перевизначає віртуальний метод базового класу.
        {
            base.MyMethod(); // Виклик базової реалізації методу MyMethod() з класу A
            Console.WriteLine("Метод MyMethod() з класу B");
        }
    }

}
