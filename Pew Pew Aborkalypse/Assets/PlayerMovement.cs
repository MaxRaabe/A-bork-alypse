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
        MyCharacterActions r_characterActions;

        private void Start() {
            r_joystick = InputManager.ActiveDevice;
            r_characterActions = new MyCharacterActions();

            r_characterActions.Left.AddDefaultBinding(InputControlType.LeftStickLeft);

            r_characterActions.Right.AddDefaultBinding(InputControlType.LeftStickRight);

            r_characterActions.Jump.AddDefaultBinding(InputControlType.Action1);

            r_characterActions.Shoot.AddDefaultBinding(InputControlType.RightTrigger);
            r_characterActions.Shoot.AddDefaultBinding(InputControlType.LeftTrigger);

            r_characterActions.Sword.AddDefaultBinding(InputControlType.Action3);

            r_characterActions.Dash.AddDefaultBinding(InputControlType.RightBumper);
            r_characterActions.Dash.AddDefaultBinding(InputControlType.LeftBumper);
        }

        // Update is called once per frame
        void Update() {
            if(r_characterActions.Left.IsPressed)
                MoveLeft();
            
        }

        void MoveLeft() {
            r_controller.r_rb.AddForce(r_joystick.LeftStick,0);
        }
    }
}