namespace FirstModuleTheory._009
{
    // Клас BankAccount демонструє інкапсуляцію:
    // поле _balance приховане (private), а змінити його можна лише через методи,
    // які перевіряють коректність операцій.
    public class BankAccount
    {
        // Приватне поле — внутрішній стан об'єкта.
        // Ззовні класу до нього звернутися неможливо: account._balance = -1000; — помилка компіляції.
        private decimal _balance;

        // Властивість лише для читання ззовні: баланс можна дізнатися, але не змінити напряму.
        public decimal Balance => _balance;

        // Номер рахунку задається один раз у конструкторі і далі не змінюється.
        public string AccountNumber { get; }

        // Конструктор задає початковий стан об'єкта.
        public BankAccount(string accountNumber, decimal initialBalance = 0)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("Номер рахунку не може бути порожнім.", nameof(accountNumber));

            if (initialBalance < 0)
                throw new ArgumentOutOfRangeException(nameof(initialBalance), "Початковий баланс не може бути від'ємним.");

            AccountNumber = accountNumber;
            _balance = initialBalance;
        }

        // Публічний метод — контрольований спосіб поповнити рахунок.
        // Перевірка гарантує, що баланс не зміниться на некоректне значення.
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Сума поповнення має бути більшою за 0.");

            _balance += amount;
        }

        // Публічний метод — контрольований спосіб зняти кошти.
        // Повертає false, якщо коштів недостатньо, і баланс залишається без змін.
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Сума зняття має бути більшою за 0.");

            if (amount > _balance)
                return false;

            _balance -= amount;
            return true;
        }
    }

    // Клас Example демонструє використання інкапсуляції на прикладі BankAccount.
    internal class Example
    {
        public void ExampleEncapsulation()
        {
            var account = new BankAccount("UA001", 100m);

            account.Deposit(50m);                     // 150
            bool ok = account.Withdraw(500m);         // false — недостатньо коштів, баланс не змінився
            account.Withdraw(30m);                    // 120

            Console.WriteLine($"Рахунок {account.AccountNumber}: {account.Balance} грн, останнє зняття 500: {ok}");

            // account._balance = 1_000_000;  // Помилка: поле private, недоступне ззовні
            // account.Balance = 1_000_000;   // Помилка: у властивості немає сеттера
        }
    }


}
