using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class MovePlayer : MonoBehaviour
{
    //Connects to joystick
    public SteamVR_Action_Vector2 moveValue;
    //Max speed player can move
    public float maxSpeed;
    //How much controll the joystick has over movement
    public float sensitivity;
    //Detects player head to stop passthrough of objects
    public Rigidbody head;
    //Detects distance player is from objects
    public float distance;

    private float speed = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //Makes sure player can't walk through walls
        RaycastHit hit;
        if (head.SweepTest(Player.instance.hmdTransform.TransformDirection(Vector3.forward), out hit, distance))
        {

        }
        else
        {
            //Detects joystick pushed forward
            if (moveValue.axis.y > 0)
            {
                //Detects HMD direction facing
                Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(0, 0, moveValue.axis.y));
                //Multiplies the joystick value by the sensitivity value
                speed = moveValue.axis.y * sensitivity;
                //Sets max speed of player
                speed = Mathf.Clamp(speed, 0, maxSpeed);
                //Moves the player along a horizontal plane of specified direction
                transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
            }
        }
    }
}