using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class TraceTask : ActionTask 
    {

        public BBParameter<NavMeshAgent> navAgent;
        public BBParameter<NavMeshAgent> playerAgent;
        public BBParameter<float> distance;

        
        public BBParameter<Vector3> lastKnownLocation;

        private Vector3 playerLocation;
        
        protected override void OnExecute()
        {
            //navAgent.isStopped = false;
        }

        protected override void OnUpdate()
        {
            //get player location and move
            playerLocation = playerAgent.value.transform.position;
            navAgent.value.destination = playerLocation;

            //end if player in range
            if (Vector3.Distance(playerLocation, navAgent.value.transform.position) <= distance.value)
            {
                //navAgent.isStopped = true;
                EndAction(true);
            }
        }

        protected override void OnStop()
        {
            //set lastknowlocation and stop the enemy
            navAgent.value.ResetPath();
            lastKnownLocation.value = playerLocation;
        }
    }
}