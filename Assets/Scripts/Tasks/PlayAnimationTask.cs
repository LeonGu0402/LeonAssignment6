using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class PlayAnimationTask : ActionTask 
	{
		public BBParameter<Animation> animation;

	

		//Called once per frame while the action is active.
		protected override void OnUpdate() 
		{
            animation.value.Play();
		}

		//Called when the task is disabled.
		protected override void OnStop() 
		{
            animation.value.Stop();
        }
	}
}