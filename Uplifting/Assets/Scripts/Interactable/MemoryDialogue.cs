using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Uplifting
{
    public class MemoryDialogue : MonoBehaviour
    {

        public string[] text;//Dialogue
        public int index;//this is where we are at in the dialogue
        public bool showDlg, canShowDlg = true;//shows our dialogue

        public Image dialogueBox;
        public Text dialogueText;
        public Button next;
        public Button exit;

        public Player playerScript;
        public AnimalPickup animalPickupScript;


        public void Next()
        {
            index++;
        }

        public void Exit()
        {
            canShowDlg = false;
            showDlg = false;
            animalPickupScript.collected = true;
            playerScript.collected++;

        }


        public void Update()
        {

            if (showDlg && animalPickupScript != null)
            {
                //dialogueText.text = text[index];
                dialogueBox.gameObject.SetActive(true);
                if ((index + 1 >= text.Length))
                {
                    next.gameObject.SetActive(false);
                    exit.gameObject.SetActive(true);
                }
            }
        }
    }
}