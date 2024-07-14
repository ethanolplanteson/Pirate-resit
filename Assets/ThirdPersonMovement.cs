using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform camera;

    public float speed = 6f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y; //returns the angle starting at X axis and returning at X,Y
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f); //allows input of XYZ

            Vector3 movedirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(movedirection.normalized * speed * Time.deltaTime);
        }
    }
}
