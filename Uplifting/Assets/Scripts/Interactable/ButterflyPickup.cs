using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Uplifting
{
    public class ButterflyPickup : MonoBehaviour
    {

        public GameObject playerObject;
        public GameObject butterflyObject;

        public ParticleSystem particlesDisappear;
        public ParticleSystem particlesToPlayer;

        public bool collected;

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player") && !collected)
            {
                playerObject = other.gameObject;

                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    butterflyObject.SetActive(false);
                    Collected();
                    playerObject.GetComponent<Player>().collected++;
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