using UnityEngine;

namespace _app.Scripts.Interfaces
{
    public interface IDamageable
    {
        // Not used but potentially helpful for objects that take damage
        void Damage(float damageAmount);

        void Die();
        
        float MaxHealth { get; set; }
        float CurrentHealth { get; set; }
    }
}