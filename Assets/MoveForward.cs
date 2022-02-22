using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float forwardSpeed;
    public float lateralSpeed;
    public float lateralAmplitude;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if (transform.position.z > 20f)
        // {
        //     transform.position = new Vector3(0, 0, 0);
        // }

        Vector3 newPos = new Vector3(lateralAmplitude * Mathf.Sin(Time.time * lateralSpeed),
         0, forwardSpeed * Time.deltaTime) + transform.position;
        transform.position = newPos;
    }
}
