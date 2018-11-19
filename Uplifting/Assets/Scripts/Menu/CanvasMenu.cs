using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Uplifting
{
    public class CanvasMenu : MonoBehaviour
    {
        public void Play()
        {
            SceneManager.LoadScene("Game");
        }
        
        public void Quit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif

        }




    } 
}
