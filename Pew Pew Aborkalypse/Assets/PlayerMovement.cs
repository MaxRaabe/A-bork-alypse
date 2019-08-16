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
                MoveLeft(r_characterActions.Left.Value);
            if (r_characterActions.Right.IsPressed)
                MoveRight(r_characterActions.Right.Value);
            if (r_characterActions.Left.WasReleased || r_characterActions.Right.WasReleased) {
                if(r_controller.m_isGrounded)
                    StopMovement();
            }
            if (r_characterActions.Jump.IsPressed && r_controller.m_isGrounded)
                Jump();
                

        }

        void MoveLeft(float x) {
            Debug.Log("Pressed Left");
            r_controller.r_rb.AddForce(new Vector2( -r_controller.m_speed * x , 0 ));
        }
        void MoveRight(float x) {
            Debug.Log("Pressed Right");
            r_controller.r_rb.AddForce(new Vector2( r_controller.m_speed * x , 0 ));
        }
        void Jump() {
            Debug.Log("Pressed Jump");
            r_controller.r_rb.AddForce(new Vector2(0, r_controller.m_jumpForce));
        }
        void StopMovement() {
            r_controller.r_rb.velocity = new Vector2(Mathf.Lerp(r_controller.r_rb.velocity.x,0,0.5f), 0);
        }

    }
}