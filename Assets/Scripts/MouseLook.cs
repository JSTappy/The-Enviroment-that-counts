using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouselook : MonoBehaviour
{
    [SerializeField]
    float Camerasensativity = 400;

    public Transform PlayerBody;

    float xRotation = 0f;




    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Mouse();

    }

    void Mouse()
    {
        float mouseX = Input.GetAxis("Mouse X") * Camerasensativity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Camerasensativity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * mouseX);
    }

}

