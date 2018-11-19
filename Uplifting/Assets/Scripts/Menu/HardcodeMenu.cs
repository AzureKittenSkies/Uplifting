using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Uplifting
{
    public class HardcodeMenu : MonoBehaviour
    {

        public float scrH, scrW;

        public bool mainMenu, playSelect;


        public GUIStyle menuBackground;
        public GUIStyle titleStyle;



        // Use this for initialization
        void Start()
        {
            mainMenu = true;
        }

        // Update is called once per frame
        void Update()
        {
            scrH = Screen.height / 16;
            scrW = Screen.width / 9;

        }

        private void OnGUI()
        {

            if (mainMenu)
            {
                GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "", menuBackground);

                GUI.Box(new Rect(scrW * 4f, scrH * 0.5f, scrW * 6f, scrH * 5f), "Uplifting", titleStyle);


            }





        }
    } 
}
