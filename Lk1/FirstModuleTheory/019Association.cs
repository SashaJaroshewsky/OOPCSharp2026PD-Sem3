namespace FirstModuleTheory
{
    // Асоціація — це найзагальніший зв'язок, за якого один клас знає про інший і використовує його,
    // але обидва об'єкти існують незалежно один від одного і жоден не є власником іншого.
    // У UML позначається суцільною лінією (зі стрілкою або без).
    // Викладач і студент знають один про одного, але жоден не володіє іншим.
    // Кожен з них існує сам по собі.
    public class Student
    {
        public string Name { get; }
        public Student(string name) => Name = name;
    }

    public class Teacher
    {
        public string Name { get; }
        public Teacher(string name) => Name = name;

        // Асоціація: викладач працює зі студентом, отриманим ззовні (через параметр).
        public void Consult(Student student) 
        {
            Console.WriteLine($"{Name} консультує {student.Name}");
        }
    }

    public class AssociationExample
    {
        public static void Run()
        {
            var teacher = new Teacher("Іваненко");
            var student = new Student("Олена");
            teacher.Consult(student);   // після консультації обидва продовжують існувати незалежно
        }
    }
}

