using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class MyCharacterActions : PlayerActionSet
{
    public PlayerAction Left;
    public PlayerAction Right;
    public PlayerAction Jump;
    public PlayerAction Shoot;
    public PlayerAction Sword;
    public PlayerAction Dash;

    public  MyCharacterActions() {
        Left = CreatePlayerAction ("Move Left");
        Right = CreatePlayerAction ("Move Right");
        Jump = CreatePlayerAction ("Jump");
        Shoot = CreatePlayerAction ("Shoot");
        Sword = CreatePlayerAction ("Sword Swing");
        Dash = CreatePlayerAction ("Dash");
    }
    
}
