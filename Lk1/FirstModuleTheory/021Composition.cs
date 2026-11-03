namespace FirstModuleTheory
{
    // Композиція — це сильна форма агрегації, за якої ціле володіє своїми частинами:
    // частини створюються всередині цілого, не можуть існувати без нього і знищуються разом з ним.
    // Частина належить лише одному цілому.
    // У UML позначається лінією із зафарбованим ромбом (◆) біля цілого.
    // Кімната не існує окремо від будинку: будинок сам створює свої кімнати
    // і нікому їх не віддає.
    public class Room
    {
        public string Name { get; }
        public Room(string name) => Name = name;
    }

    public class House
    {
        private readonly List<Room> _rooms = new();

        // Частини створюються всередині цілого — у конструкторі.
        public House()
        {
            _rooms.Add(new Room("Кухня"));
            _rooms.Add(new Room("Спальня"));
        }

        // Ззовні кімнати лише видно, але ними не можна володіти чи замінити їх.
        public IReadOnlyList<Room> Rooms => _rooms;
    }

    public class CompositionExample
    {
        public static void Run()
        {
            var house = new House();
            house = null;   // разом з будинком зникають і його кімнати

            // Ключова різниця: в агрегації частина передається ззовні(через параметр), у композиції — створюється всередині цілого(через new).
        }
    }
}
