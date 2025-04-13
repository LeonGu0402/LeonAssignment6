using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ResetColourTask : ActionTask 
	{
		public BBParameter<Material> enemy1;

		protected override void OnStop() 
		{
			enemy1.value.color = Color.green;
		}
	}
}