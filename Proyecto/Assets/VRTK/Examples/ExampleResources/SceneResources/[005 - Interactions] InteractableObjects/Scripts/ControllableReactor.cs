namespace VRTK.Examples
{ 
    using UnityEngine.Audio;
    using UnityEngine;
    using UnityEngine.UI;
    using VRTK.Controllables;
    using System;

    public class ControllableReactor : MonoBehaviour
    {
        public AudioSource audioSource;
        public VRTK_BaseControllable controllable;
        public Text displayText;
        public string outputOnMax = "Maximum Reached";
        public string outputOnMin = "Minimum Reached";

        protected virtual void OnEnable()
        {
            controllable = (controllable == null ? GetComponent<VRTK_BaseControllable>() : controllable);
            controllable.ValueChanged += ValueChanged;
            controllable.MaxLimitReached += MaxLimitReached;
            controllable.MinLimitReached += MinLimitReached;
        }

        private void OnCollisionEnter(Collision collision)
        {
       

        }
        protected virtual void ValueChanged(object sender, ControllableEventArgs e)
        {
            if (displayText != null)
            {
               
                displayText.text = e.value.ToString("F1");
            }
        }

        protected virtual void MaxLimitReached(object sender, ControllableEventArgs e)
        {
           
            FindObjectOfType<AudioManager>().Play(this.name);

            if (outputOnMax != "")
            {
                Debug.Log(outputOnMax);
            }
        }

        protected virtual void MinLimitReached(object sender, ControllableEventArgs e)
        {


            if (outputOnMin != "")
            {
                Debug.Log(outputOnMin);
            }
        }

        void Update()
        {
           
        }
    }
}