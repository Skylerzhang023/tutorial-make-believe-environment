using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(CharacterController))]
//[AddComponentMenu("Control Script/CharacterMove")]
public class CharacterMove : MonoBehaviour
{
    public CharacterController cController;
    public Rigidbody rigidbody;
    public float speed = 1;

    // Use this for initialization
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        cController = this.GetComponent<CharacterController>();
    }

    //Move

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.forward;// .TransformDirection(Vector3.forward);
        Vector3 right = transform.right;// .TransformDirection(Vector3.right);
        //Move
        if (Input.GetKey(KeyCode.A))
            cController.Move(new Vector3(1,0,0) * speed);
        //transform.Translate(-right*speed);
        else if (Input.GetKey(KeyCode.D))
            cController.Move(new Vector3(-1, 0, 0) * speed);
        //transform.Translate(right * speed);
        else if (Input.GetKey(KeyCode.W))
            cController.Move(forward * speed);
        //transform.Translate(forward * speed);
        else if (Input.GetKey(KeyCode.S))
            cController.Move(-forward * speed);
        //transform.Translate(-forward * speed);
    }
}

