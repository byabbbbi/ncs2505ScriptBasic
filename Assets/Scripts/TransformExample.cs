using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformExample : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.right *
            moveSpeed *
            Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.right *
            moveSpeed *
            Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.left, turnSpeed *
            Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.right, turnSpeed *
            Time.deltaTime);
    }
}
