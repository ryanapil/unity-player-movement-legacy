using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * horizontal + transform.forward * vertical;

        controller.Move(movement * speed * Time.deltaTime);
    }

}
