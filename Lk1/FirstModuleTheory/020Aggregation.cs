namespace FirstModuleTheory
{
    // Агрегація — це різновид асоціації типу "ціле — частина", за якого ціле містить частини, але не володіє їхнім життєвим циклом:
    // частини створюються поза цілим і можуть існувати без нього або належати кільком цілим одночасно.
    // У UML позначається лінією з порожнім ромбом (◇) біля цілого.
    // Кафедра складається з викладачів, але викладачі існують і без кафедри: їх створюють ззовні і передають у кафедру.
    public class Department // Ціле
    {
        private readonly List<Teacher> _teachers = new(); // Частини

        public string Name { get; }
        public Department(string name) => Name = name;

        // Частина приходить ззовні — кафедра лише зберігає посилання.
        public void AddTeacher(Teacher teacher) => _teachers.Add(teacher);
    }

    public class AggregationExample
    {
        public static void Run()
        {
            var teacher = new Teacher("Іваненко");
            var department = new Department("Програмної інженерії");
            department.AddTeacher(teacher);
            department = null;   // кафедру розформовано, але викладач teacher продовжує існувати
        }
    }
}
