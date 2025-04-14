using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class PounceTask : ActionTask 
	{
		public BBParameter<Vector3> pounceTargetLocation;
		public BBParameter<NavMeshAgent> enemy;

        public float pounceSpeed;
        public float pounceDistance;
        public float stopDistance;

        private float temp;
        private Vector3 direction;
        private Vector3 destination;

        protected override void OnExecute()
        {
            temp = enemy.value.speed;
            //get the direction
            direction = Vector3.Normalize(pounceTargetLocation.value - enemy.value.transform.position);
            //set the pounce distance
            destination = enemy.value.transform.position + direction * pounceDistance;

        }


        protected override void OnUpdate()
        { 
            //Debug.Log(destination);

            enemy.value.speed = pounceSpeed;
            enemy.value.SetDestination(destination);


            //prevent it pouncing too much
            if (Vector3.Distance(enemy.value.transform.position, destination) <= stopDistance)
            {
                
                EndAction(true);
            }
        }

        protected override void OnStop()
        {
            //reset enemy1 speed
            enemy.value.speed = temp;

            //reset pounce distance
            direction = enemy.value.transform.position;
        }
    }
}