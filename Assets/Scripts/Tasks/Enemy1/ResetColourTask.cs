using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ResetColourTask : ActionTask 
	{
		public BBParameter<Material> material;

		public Color resetColour;

		protected override void OnStop() 
		{
            material.value.color = resetColour;
		}
	}
}