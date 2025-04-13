using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions 
{

	public class StickTask : ActionTask 
	{
		public BBParameter<NavMeshAgent> enemy1;
		public BBParameter<NavMeshAgent> player;

		public BBParameter<float> playerGluedSpeed;
		public BBParameter<float> playerGluedAugSpeed;
		public BBParameter<float> stopDistance;

		private float playerSpeedTemp;
		private float playerAugSpeedTemp;
		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() 
		{
			//store the player speed
			playerSpeedTemp = player.value.speed;
			playerAugSpeedTemp = player.value.angularSpeed;
			//decrease them
            player.value.speed = playerGluedSpeed.value;
			player.value.angularSpeed = playerGluedAugSpeed.value;
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() 
		{
			//move to player location
			enemy1.value.SetDestination(player.value.transform.position);

			if (Vector3.Distance(player.value.transform.position, enemy1.value.transform.position) <= stopDistance.value)
			{
                enemy1.value.ResetPath();
            }
        }

		//Called when the task is disabled.
		protected override void OnStop() 
		{
			enemy1.value.ResetPath();
			//reset player speed
			player.value.speed = playerSpeedTemp;
			player.value.angularSpeed = playerAugSpeedTemp;
        }
	}
}