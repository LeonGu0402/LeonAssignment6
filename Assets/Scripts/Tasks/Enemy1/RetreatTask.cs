using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class RetreatTask : ActionTask 
	{
		public BBParameter<NavMeshAgent> enemy1;
		public BBParameter<NavMeshAgent> player;

		public float backoffDistance;

		private Vector3 direction;
        private Vector3 destination;


        protected override void OnUpdate()
        {
            //calculate direction
            direction = enemy1.value.transform.position - player.value.transform.position;
            direction.Normalize();

            // set destination
            destination = player.value.transform.position + direction * backoffDistance;


            enemy1.value.SetDestination(destination);

            float currentDistance = Vector3.Distance(enemy1.value.transform.position, player.value.transform.position);

            //stop enemy from move too far or too close
            if (currentDistance > backoffDistance)
            {
                enemy1.value.SetDestination(destination);
            }
            else if (currentDistance < backoffDistance)
            {
                enemy1.value.SetDestination(destination);
            }
            else
            {
                enemy1.value.ResetPath();
            }
        }

    }
}