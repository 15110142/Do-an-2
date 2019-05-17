using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XoayVat : MonoBehaviour {

    public float rotspeed = 50;
    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotspeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotspeed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.up, -rotX, Space.World);
        transform.Rotate(Vector3.right, rotY, Space.World);

    }
}
