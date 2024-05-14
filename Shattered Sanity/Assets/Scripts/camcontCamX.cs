using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontCamX : MonoBehaviour
{
    // Start is called before the first frame update
    float rotationX = 0f;
    public float sensitivity = 150f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        rotationX += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

       rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.localEulerAngles = new Vector3(rotationX * -1, 0, 0);

    }
}
