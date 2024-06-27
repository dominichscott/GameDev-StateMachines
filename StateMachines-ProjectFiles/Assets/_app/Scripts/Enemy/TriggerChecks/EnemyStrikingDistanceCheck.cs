using UnityEngine;

namespace _app.Scripts.Enemy.TriggerChecks
{
    public class EnemyStrikingDistanceCheck : MonoBehaviour
    {
        public GameObject PlayerTarget { get; set; }
        public Base.Enemy _enemy;

        private void Awake()
        {
            PlayerTarget = GameObject.FindGameObjectWithTag("Player");

            //_enemy = this.getComponentInParent<Base.Enemy>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject == PlayerTarget)
            {
                _enemy.SetStrikingDistanceBool(true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject == PlayerTarget)
            {
                _enemy.SetStrikingDistanceBool(false);
            }
        }
    }
}