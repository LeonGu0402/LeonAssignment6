using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ColourChangingTask : ActionTask 
    {

        public BBParameter<Material> material;
        public BBParameter<float> countdownTime;
        public Color colour1;
        public Color colour2;
        public Color stopColor;


        private float timer;
        private float intensity;

        protected override void OnExecute()
        {
            timer = countdownTime.value;
        }

        protected override void OnUpdate()
        {
            timer -= Time.deltaTime;
            //smoothen it
            intensity = Mathf.Cos(timer * 2);

            material.value.color = Color.Lerp(colour1, colour2, intensity);


            if (timer <= 0)
            {
                EndAction(true);
                //material.value.color = colour2.value;
            }
        }

        protected override void OnStop()
        {
            //reset colour
            material.value.color = stopColor;
        }
    }
}