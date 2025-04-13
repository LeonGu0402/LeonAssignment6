using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class PounceTask : ActionTask 
	{
		public BBParameter<Vector3> pounceTargetLocation;
		public BBParameter<NavMeshAgent> navAgent;

        private float temp;

        protected override void OnExecute()
        {
            temp = navAgent.value.speed;
        }


        protected override void OnUpdate()
        {
            
            //start the pounce
            navAgent.value.speed = 100f;
            navAgent.value.SetDestination(pounceTargetLocation.value);


            //prevent it pouncing too much
            if (Vector3.Distance(navAgent.value.transform.position, pounceTargetLocation.value) <= 1)
            {
                
                EndAction(true);
            }
        }

        protected override void OnStop()
        {
            //reset enemy1 speed
            navAgent.value.speed = temp;
        }

    }
}