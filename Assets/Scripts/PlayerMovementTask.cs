using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

namespace NodeCanvas.Tasks.Actions {

	public class PlayerMovementTask : ActionTask 
	{
		public BBParameter<NavMeshAgent> navAgent;
        public BBParameter<float> speed; 
        public float offset;


        private float locationX;
		private float locationZ;
        private Vector3 movePosition;

        protected override string OnInit()
        {
            //locationX = navAgent.value.transform.position.x;
            //locationZ = navAgent.value.transform.position.z;
            navAgent.value.speed = speed.value;
            return base.OnInit();
        }

        protected override void OnUpdate()
        {
            //locationX = navAgent.value.transform.position.x;
            //locationZ = navAgent.value.transform.position.z;

            locationX = navAgent.value.transform.localPosition.x;
            locationZ = navAgent.value.transform.localPosition.z;

            if (Input.GetKey(KeyCode.W))
            {
                locationZ += offset;
            }
            if (Input.GetKey(KeyCode.D))
            {
                locationX += offset;
            }
            if (Input.GetKey(KeyCode.S))
            {
                locationZ -= offset;
            }
            
            if (Input.GetKey(KeyCode.A))
            {
                locationX -= offset;
            }

            movePosition = new Vector3(locationX, 0, locationZ);

            //Debug.Log(movePosition);

            navAgent.value.destination = movePosition;
        }




    }
}