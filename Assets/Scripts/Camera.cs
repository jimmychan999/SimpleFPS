using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public PlayerMovement player;
    public float rotateSpeed = 400f;
    float rotationX;
    float rotationY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * rotateSpeed;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * rotateSpeed;
        Debug.Log(mouseX + " " + mouseY);

        rotationX -= mouseY;
        rotationY += mouseX;

        Quaternion rotation = Quaternion.Euler(0f, rotationY, 0f);
        Quaternion rotationVert = Quaternion.Euler(rotationX, 0f, 0f);


        player.transform.rotation = rotation;
        transform.localRotation = rotationVert;
    }
}