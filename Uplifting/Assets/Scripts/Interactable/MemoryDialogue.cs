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

        public Text dialogueBox;
        public Button next;
        public Button exit;

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

        }


        public void Update()
        {
            if (showDlg)
            {
                dialogueBox.text = text[index];
                if ((index + 1 >= text.Length))
                {
                    next.gameObject.SetActive(false);
                    exit.gameObject.SetActive(true);
                }
            }
        }
    }
}