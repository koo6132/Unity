using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstP : MonoBehaviour
{
    public static FirstP instance;
    private Vector3 mymouce = Vector3.up;
    float mspeed;
    float mouseR;

    public Camera playerCamera;
    public float fov = 60f;
    public bool invertCamera = false;
    public bool cameraCanMove = true;
    public float mouseSensitivity = 10f;
    public float maxLookAngle = 90f;
    public float DPI;
    // Internal Variables
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    // Start is called before the first frame update

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        DPI =  PlayerPrefs.GetFloat("Mouse");
            transform.Rotate(mymouce * mspeed * Time.deltaTime * mouseR);
            mouseR = Input.GetAxis("Mouse X");
        if (cameraCanMove)
        {
            yaw = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * DPI;

            if (!invertCamera)
            {
                pitch -= DPI * Input.GetAxis("Mouse Y");
            }
            else
            {
                // Inverted Y
                pitch += DPI * Input.GetAxis("Mouse Y");
            }

            // Clamp pitch between lookAngle
            pitch = Mathf.Clamp(pitch, -maxLookAngle, maxLookAngle);

            transform.localEulerAngles = new Vector3(0, yaw, 0);
            playerCamera.transform.localEulerAngles = new Vector3(pitch, 0, 0);
        }
    }
}
