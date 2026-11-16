using System;
using System.Collections.Generic;

namespace SecondModuleTheory.QueueAndStack
{
    // ТЕРМІНИ:
    // Queue<T> - черга: колекція, що працює за принципом FIFO (First In, First Out - "першим прийшов, першим вийшов").
    //   Enqueue - додати в кінець черги; Dequeue - забрати з початку; Peek - подивитися на перший, не забираючи.
    // Stack<T> - стек: колекція за принципом LIFO (Last In, First Out - "останнім прийшов, першим вийшов").
    //   Push - покласти зверху; Pop - зняти верхній; Peek - подивитися на верхній, не знімаючи.

    // АНАЛОГІЯ:
    // Черга - це черга в касу: хто першим став, того першим і обслуговують. Нові стають у кінець.
    // Стек - це стопка тарілок: нову кладуть зверху і беруть теж зверху. Щоб дістати нижню, треба зняти всі верхні.

    // ПОЯСНЕННЯ:
    // - Доступу за індексом немає: працюємо лише з "краєм" колекції. Зате ці операції дуже швидкі.
    // - Dequeue / Pop / Peek на порожній колекції -> InvalidOperationException.
    //   Безпечні варіанти: TryDequeue, TryPop, TryPeek (повертають bool).
    // - Де застосовують чергу: обробка замовлень, черга друку, обмін повідомленнями між частинами програми.
    // - Де застосовують стек: кнопка "Назад" у браузері, скасування дій (Ctrl+Z), перевірка дужок, стек викликів методів.

    public static class BracketChecker
    {
        // Класична задача на стек: чи правильно розставлені дужки
        public static bool IsBalanced(string text)
        {
            Stack<char> open = new Stack<char>();
            foreach (char c in text)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    open.Push(c); // Відкривальну дужку кладемо в стек
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    // Закривальна дужка має відповідати ОСТАННІЙ відкритій
                    if (open.Count == 0)
                    {
                        return false;
                    }
                    char last = open.Pop();
                    if ((c == ')' && last != '(') || (c == ']' && last != '[') || (c == '}' && last != '{'))
                    {
                        return false;
                    }
                }
            }
            return open.Count == 0; // Усі відкриті дужки мають бути закриті
        }
    }

    internal static class Demo
    {
        public static void Run()
        {
            // ЧЕРГА: черга друку
            Queue<string> printQueue = new Queue<string>();
            printQueue.Enqueue("Звіт.docx");
            printQueue.Enqueue("Фото.jpg");
            printQueue.Enqueue("Квиток.pdf");

            Console.WriteLine($"Наступний на друк: {printQueue.Peek()}"); // Звіт.docx
            while (printQueue.Count > 0)
            {
                string document = printQueue.Dequeue();
                Console.WriteLine($"Друкую: {document}"); // Звіт, Фото, Квиток - у порядку надходження
            }

            // printQueue.Dequeue(); // InvalidOperationException - черга порожня
            if (!printQueue.TryDequeue(out _)) // _ - "відкидання": значення нам не потрібне
            {
                Console.WriteLine("Черга порожня");
            }

            // СТЕК: історія переглядів у браузері
            Stack<string> history = new Stack<string>();
            history.Push("google.com");
            history.Push("wikipedia.org");
            history.Push("github.com");

            Console.WriteLine($"Зараз відкрито: {history.Peek()}"); // github.com
            history.Pop();                                           // натиснули "Назад"
            Console.WriteLine($"Після \"Назад\": {history.Peek()}"); // wikipedia.org

            Console.WriteLine(BracketChecker.IsBalanced("(a[b]{c})")); // True
            Console.WriteLine(BracketChecker.IsBalanced("(a[b)]"));    // False
        }
    }
}
