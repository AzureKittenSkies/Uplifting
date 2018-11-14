using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Uplifting
{
    public class ButterflyPickup : MonoBehaviour
    {
        #region Particle System
        public ParticleSystem particlesToPlayer;
        public ParticleSystem particlesDisappear;
        #endregion

        public Player playerScript;
        public GameObject playerObject;

        public MemoryDialogue memory;

        public string thisTag;

        private void Start()
        {
            thisTag = this.gameObject.tag;
        }


        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                playerObject = other.gameObject;
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    switch (thisTag)
                    {
                        case "Butterfly":
                            playerScript.collected++;
                            break;
                        //case "Memory":                                    
                        //  

                        default:
                            break;
                    }


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