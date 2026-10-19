
namespace Lk3
{
    internal class Player
    {
        private string _name;
        private Health _health;
        private int _weaponDamage;

        public Player(string name, int health, int weaponDamage)
        {
            _name = name;
            _health = new Health(health);
            _weaponDamage = weaponDamage;
        }

        public void TakeDamage(int damage)
        {
            _health.TakeDamage(damage);

            if(_health.CurrentHealth <= 0)
            {
                Die();
            }
        }

        public void Attack(Player target)
        {
            if (target == null)
                return;
            target.TakeDamage(_weaponDamage);
        }

        private void Die()
        {
            Console.WriteLine($"{_name} has died.");
        }

    }
}
