using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class PatrolTask : ActionTask 
	{
		public BBParameter<List<Transform>> patrolPoints;
		public BBParameter<NavMeshAgent> enemy2;

		public float stopDistance;

		private int index = 0;
		private Vector3 targetPosition;


		protected override string OnInit() 
		{
			return null;
		}

		
		protected override void OnUpdate() 
		{
			//update the list
			targetPosition = patrolPoints.value[index].position;

			//set destination
            enemy2.value.SetDestination(targetPosition);

			//stop check
			float distance = Vector3.Distance(enemy2.value.transform.position, targetPosition);
			if (distance < stopDistance)
			{
				//update index
				index = (index + 1) % patrolPoints.value.Count;
            }


		}

		//Called when the task is disabled.
		protected override void OnStop() 
		{
		}
	}
}