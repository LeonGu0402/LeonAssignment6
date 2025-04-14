using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class PlayerWinCheck : ConditionTask {

        public Transform player;
        public Transform goal;

        public float distance;
        public BBParameter<bool> isWin;

        protected override bool OnCheck()
        {
            if (Vector3.Distance(player.position, goal.position) < distance)
            {
                isWin.value = true;
            }
            else
            {
                isWin.value = false;
            }

            return isWin.value;
        }
    }
}