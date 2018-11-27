using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Uplifting
{
    public class Player : MonoBehaviour
    {

        #region Movement
        public float speed = 5f;
        public float jumpSpeed = 2.5f;
        private float gravity = 5f;
        public CharacterController controller;
        private Vector3 moveDirection = Vector3.zero;

        public bool holdPlayerMove;
        public MemoryDialogue memoryScript;

        public KeyCode jump = KeyCode.Space;

        #endregion

        #region Player models
        public GameObject[] playerModels;

        #endregion

        #region Jump and gravity




        #endregion

        #region Pickups

        public int collected;


        #endregion

        #region Camera
        public Transform cam;
        #endregion



        // Update is called once per frame
        void Update()
        {
            holdPlayerMove = memoryScript.showDlg;
            switch (collected)
            {
                case 0:
                    playerModels[0].SetActive(true);
                    playerModels[1].SetActive(false);
                    //playerModels[2].SetActive(false);
                    break;
                case 1:
                    playerModels[0].SetActive(false);
                    playerModels[1].SetActive(true);
                    //playerModels[2].SetActive(false);
                    break;
                case 2:
                    playerModels[0].SetActive(false);
                    playerModels[1].SetActive(false);
                    //playerModels[2].SetActive(true);
                    break;
                default:
                    break;
            }

            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            if (!holdPlayerMove)
            {
                moveDirection.x = inputH * speed;
                moveDirection.z = inputV * speed;
                moveDirection = transform.TransformDirection(moveDirection);

                if (inputH != 0 || inputV != 0)
                {
                    Vector3 euler = cam.transform.eulerAngles;
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.AngleAxis(euler.y, Vector3.up), Time.deltaTime * 2.5f);
                }

                if (Input.GetKeyDown(jump))
                {
                    moveDirection.y = jumpSpeed;
                }

                moveDirection.y -= gravity * Time.deltaTime;
                controller.Move(moveDirection * Time.deltaTime);
            }
        }

        


    }
}