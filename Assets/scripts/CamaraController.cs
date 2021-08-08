using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public float speed = 4f;
    public float RotationSpeed = 200;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton (0)) {
            transform.position += new Vector3 (Input.GetAxisRaw ("Mouse X") * Time.deltaTime * speed, Input.GetAxisRaw ("Mouse Y") * Time.deltaTime * speed, 0f);
    	}
        if (Input.GetMouseButton (1)) {
            transform.Rotate((Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime), (Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime), 0, Space.World);
            transform.position += new Vector3 (Input.GetAxisRaw ("Mouse Y") * Time.deltaTime * speed, Input.GetAxisRaw ("Mouse X") * Time.deltaTime * speed, 0f);
    	}
        transform.position += new Vector3 (0f, 0f, Input.GetAxis("Mouse ScrollWheel"));        
    }
}
