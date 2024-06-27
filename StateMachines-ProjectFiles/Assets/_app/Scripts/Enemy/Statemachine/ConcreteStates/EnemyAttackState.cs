using UnityEngine;

namespace _app.Scripts.Enemy.Statemachine.ConcreteStates
{
    public class EnemyAttackState : EnemyState
    {
        public EnemyAttackState(Base.Enemy enemy, EnemyStateMachine enemyStateMachine) : base(enemy, enemyStateMachine)
        {
            
        }
        
        public override void EnterState()
        {
            base.EnterState();

            Debug.Log("Attack State Enter");
        }
        
        public override void ExitState()
        {
            base.ExitState();
        }

        public override void FrameUpdate()
        {
            base.FrameUpdate();

            enemy.MoveEnemy(Vector2.zero);

            if (enemy.IsAggroed && !enemy.IsWithinStrikingDistance)
            {
                enemy.StateMachine.ChangeState(enemy.ChaseState);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}
