using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Conditions {

	public class PlayerDeathCheck : ConditionTask {

        public BBParameter<NavMeshAgent> enemy;
        public BBParameter<NavMeshAgent> player;

        public BBParameter<float> collideRange;
        public BBParameter<bool> playerDeath;


        private Vector3 enemy1Position;
        private Vector3 playerPosition;
        protected override bool OnCheck()
        {
            enemy1Position = enemy.value.transform.position;
            playerPosition = player.value.transform.position;

            if (Vector3.Distance(playerPosition, enemy1Position) < collideRange.value)
            {
                playerDeath.value = true;
            }
            else
            {
                playerDeath.value = false;
            }

            return (playerDeath.value);

        }

        protected override void OnDisable()
        {
            playerDeath.value = false;
        }
    }
}