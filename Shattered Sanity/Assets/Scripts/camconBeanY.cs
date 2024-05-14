using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontBeanY : MonoBehaviour
{
    
    float rotationY = 0f;
    public float sensitivity = 150f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        
        transform.localEulerAngles = new Vector3(0, rotationY, 0);
    }
}
