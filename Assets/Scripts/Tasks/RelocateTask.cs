using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class RelocateTask : ActionTask 
	{
		public BBParameter<NavMeshAgent> enemy2;
		public BBParameter<NavMeshAgent> player;
		

		protected override void OnUpdate() 
		{
			enemy2.value.SetDestination(player.value.transform.position);

		}

		//Called when the task is disabled.
		protected override void OnStop() 
		{
			
		}

		//Called when the task is paused.
		protected override void OnPause() 
		{
			
		}
	}
}