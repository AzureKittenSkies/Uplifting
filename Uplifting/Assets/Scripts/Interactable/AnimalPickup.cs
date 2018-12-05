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


        public bool collected = false;



        private void Update()
        {
            if (collected)
            {
                Collected();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            memory = other.GetComponent<MemoryDialogue>();
            memory.animalPickupScript = this;

            memory.text = new string[thisText.Length];
            memory.text = thisText;


        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player") && !collected)
            {
                playerObject = other.gameObject;
                playerScript = playerObject.GetComponent<Player>();
                if (Input.GetKeyDown(KeyCode.E))
                {
                    animalObject.SetActive(false);
                    collected = true;
                }        
            }
        }

        private void Collected()
        {
            particlesToPlayer.transform.LookAt(playerObject.transform, transform.up);
            particlesToPlayer.Play();
            particlesDisappear.Play();
            playerScript.collected++;
            
        }



    }

}