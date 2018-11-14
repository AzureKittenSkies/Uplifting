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


        public GameObject playerObject;

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                playerObject = other.gameObject;
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    
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