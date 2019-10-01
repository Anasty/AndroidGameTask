 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersController : MonoBehaviour {

    public float speed = 5f;
    private float gravity = -1f;
    bool run = false;

    Vector3 direction;
    CharacterController ch_controller;
    Animator ch_animator;
    MobileController mContr;

    void Start() {
        ch_controller = GetComponent<CharacterController>();
        ch_animator = GetComponent<Animator>();
        mContr = GameObject.FindGameObjectWithTag("Joystick").GetComponent<MobileController>();
    }

    // Update is called once per frame
    void Update() {
        CharacterMove();
        
    }

    private void CharacterMove()
    {
        direction = Vector3.zero;
        direction.x = mContr.Horizontal() * speed;
        direction.z = mContr.Vertical() * speed ;



        if ((direction.x != 0 || direction.z != 0) && (Mathf.Abs(direction.x) + Mathf.Abs(direction.z) < 3) && (Mathf.Abs(direction.x) + Mathf.Abs(direction.z) > -3))
        {
            ch_animator.SetBool("Walk", true);
            ch_animator.SetBool("Run", false);
        }
        else if ((direction.x != 0 || direction.z != 0) && (Mathf.Abs(direction.x) + Mathf.Abs(direction.z) > 3) || (Mathf.Abs(direction.x) + Mathf.Abs(direction.z) < -3))
        {
            ch_animator.SetBool("Walk", false);
            ch_animator.SetBool("Run", true);

        }
        else
        { ch_animator.SetBool("Walk", false); ch_animator.SetBool("Run", false); }

        if (Vector3.Angle(Vector3.forward, direction) > 1f || Vector3.Angle(Vector3.forward, direction) == 0)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, direction, speed, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }

        direction.y = gravity;
        ch_controller.Move(direction * Time.deltaTime);
    }

}
