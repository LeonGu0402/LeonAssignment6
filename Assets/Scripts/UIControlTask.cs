using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class UIControlTask : ActionTask
	{
		public BBParameter<bool> isCatch;
		public BBParameter<bool> isAttack;
		public BBParameter<bool> isDeath;
        public BBParameter<bool> isWin;

		public BBParameter<GameObject> runUI;
		public BBParameter<GameObject> catchUI;
		public BBParameter<GameObject> attackUI;
		public BBParameter<GameObject> looseUI;
        public BBParameter<GameObject> winUI;

        public GameObject player;


        protected override void OnUpdate()
        {
			if (isCatch.value == true || isAttack.value == true || isDeath.value == true)
			{
				runUI.value.SetActive(false);
			}
			else
			{
				runUI.value.SetActive(true);
			}

            if (isCatch.value == true)
            {
                catchUI.value.SetActive(true);
            }
            else
            {
                catchUI.value.SetActive(false);
            }

            if (isAttack.value == true)
            {
                attackUI.value.SetActive(true);
            }
            else
            {
                attackUI.value.SetActive(false);
            }

            if (isDeath.value == true)
            {
                looseUI.value.SetActive(true);
                player.SetActive(false);
            }
            else
            {
                looseUI.value.SetActive(false);
            }

            if(isWin.value == true)
            {
                winUI.value.SetActive(true);
                player.SetActive(false);
            }
            else
            {
                winUI.value.SetActive(false);
            }
        }
    }
}