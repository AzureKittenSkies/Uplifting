using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

namespace Uplifting
{
    public class HardcodeMenu : MonoBehaviour
    {

        public float scrH, scrW;

        public bool mainMenu, playSelect;
        public bool networkActive;

        public GameObject networkManagerObj;


        //public GUIStyle menuBackground;
        //public GUIStyle titleStyle;

        public GUIStyle buttonstyle;


        // Use this for initialization
        void Start()
        {
            mainMenu = true;
        }

        // Update is called once per frame
        void Update()
        {
            scrH = Screen.height / 9;
            scrW = Screen.width / 16;

            if (networkActive)
            {
                networkManagerObj.SetActive(true);
            }
            else if (!networkActive)
            {
                networkManagerObj.SetActive(false);
            }
        }

        private void OnGUI()
        {

            if (mainMenu)
            {
                //GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "", menuBackground);

                //GUI.Box(new Rect(scrW * 4f, scrH * 0.5f, scrW * 6f, scrH * 5f), "Uplifting", titleStyle);

                if (GUI.Button(new Rect(scrW * 5.5f, scrH * 4, scrW * 5, scrH * 1.25f), "Start", buttonstyle))
                {
                    mainMenu = false;
                    playSelect = true;
                }

                if (GUI.Button(new Rect(scrW * 5.5f, scrH * 6f, scrW * 5, scrH * 1.25f), "Exit", buttonstyle))
                {
#if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
                }

            }

            if (playSelect)
            {
                if (GUI.Button(new Rect(scrW * 5.5f, scrH * 3.5f, scrW * 5, scrH * 1.25f), "Play Solo", buttonstyle))
                {
                    SceneManager.LoadScene(1);
                }

                if (GUI.Button(new Rect(scrW * 5.5f, scrH * 5.25f, scrW * 5, scrH * 1.25f), "Multiplayer", buttonstyle))
                {
                    networkActive = true;
                }

                if (GUI.Button(new Rect(scrW * 5.5f, scrH * 7f, scrW * 5, scrH * 1.25f), "Back To Menu", buttonstyle))
                {
                    playSelect = false;
                    networkActive = false;
                    mainMenu = true;
                }

            }






        }
    }
}
