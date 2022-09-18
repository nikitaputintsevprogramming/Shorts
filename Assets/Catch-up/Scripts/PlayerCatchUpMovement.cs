using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCatchUpMovement : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    [SerializeField] private float PlayerSpeed;
    [SerializeField] private float RotationSpeed;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        PlayerSpeed = 1f;
        RotationSpeed = 100f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = transform.forward * PlayerSpeed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = -transform.forward * PlayerSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, RotationSpeed, 0) * Time.deltaTime * PlayerSpeed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -RotationSpeed, 0) * Time.deltaTime * PlayerSpeed, Space.World);
        }
    }
}
