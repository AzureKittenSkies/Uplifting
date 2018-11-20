using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Uplifting
{
    public class AnimalPickup : MonoBehaviour
    {
        #region Particle System
        public ParticleSystem particlesToPlayer;
        public ParticleSystem particlesDisappear;
        #endregion

        public Player playerScript;
        public GameObject playerObject;
        public GameObject animalObject;

        public MemoryDialogue memory;

        public string[] thisText;

        public string thisTag;

        public bool collected = false;





        private void Start()
        {
            thisTag = this.gameObject.tag;
        }


        private void OnTriggerEnter(Collider other)
        {
            memory.animalPickupScript = this;

            memory.text = new string[thisText.Length];
            memory.text = thisText;


        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player") && !collected)
            {
                playerObject = other.gameObject;
                if (Input.GetKeyDown(KeyCode.Mouse0) && collected)
                {

                    animalObject.SetActive(false);
                    Collected();
                    collected = true;
                }        
            }
        }

        private void Collected()
        {
            particlesToPlayer.transform.LookAt(playerObject.transform, transform.up);
            particlesToPlayer.Play();
            particlesDisappear.Play();

        }



    }

}