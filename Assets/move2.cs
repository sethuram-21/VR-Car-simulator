using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float turnSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        // Move forward when "W" is pressed
        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        // Move backward when "S" is pressed
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }

        // Turn left when "A" is pressed
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

        // Turn right when "D" is pressed
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
}
