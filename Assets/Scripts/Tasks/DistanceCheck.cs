using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class DistanceCheck : ActionTask 
	{

		public BBParameter<NavMeshAgent> agent1;
		public BBParameter<NavMeshAgent> agent2;
		public BBParameter<float> detectionRange;

		public BBParameter<bool> boolTrigger;

		


		//Called once per frame while the action is active.
		protected override void OnUpdate() 
		{
			if (Vector3.Distance(agent1.value.transform.position, agent2.value.transform.position) <= detectionRange.value)
			{
				boolTrigger.value = true;
			}
		}

		//Called when the task is disabled.
		protected override void OnStop() 
		{
			
		}
	}
}