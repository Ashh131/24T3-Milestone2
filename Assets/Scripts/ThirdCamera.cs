
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCamera : MonoBehaviour
{
    public Transform target;
    public float distance = 5.0f;
    public float sensitivity = 2.0f;
    public float heightOffset = 1.5f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void HandleCameraInput()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        rotationY += mouseX;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90, 90);
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
    }
    // Update is called once per frame
    void LateUpdate()
    {
        FollowTarget();
    }
    void FollowTarget()
    {
        Vector3 targetPosition = target.position - target.forward * distance + Vector3.up * heightOffset;
        transform.position = targetPosition;
    }
}