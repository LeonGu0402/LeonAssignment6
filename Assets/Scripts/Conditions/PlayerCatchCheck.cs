using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Conditions {

	public class PlayerCatchCheck : ConditionTask {

		public BBParameter<NavMeshAgent> enemy1;
		public BBParameter<NavMeshAgent> player;

		public BBParameter<float> catchRange;
		public BBParameter<bool> isCatch;


		private Vector3 enemy1Position;
		private Vector3 playerPosition;
		protected override bool OnCheck() 
		{
			enemy1Position = enemy1.value.transform.position;
			playerPosition = player.value.transform.position;

			if (Vector3.Distance(playerPosition, enemy1Position) < catchRange.value)
			{
                isCatch.value = true;
			}
			else
			{
                isCatch.value = false;
			}

			return (isCatch.value);
			
		}

        protected override void OnDisable()
        {
            isCatch.value = false;
        }
    }
}