using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

namespace PPA
{
    public class PlayerMovement : MonoBehaviour
    {
        public PlayerController r_controller;
        private InputDevice r_joystick;

        private void Awake() {
            r_joystick = InputManager.ActiveDevice;
        }

        // Update is called once per frame
        void Update() {
            
            

        }
    }
}