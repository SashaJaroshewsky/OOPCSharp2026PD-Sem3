using System;
using System.Collections.Generic;
using System.Text;

namespace Lk3
{
    internal class Health
    {
        private int _currentHealth;

        public int CurrentHealth => _currentHealth;

        public Health(int currentHealth)
        {
            _currentHealth = currentHealth;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                return;

            _currentHealth -= damage;

            if (_currentHealth < 0)
            {
                _currentHealth = 0;
            }
        }
    }
}
