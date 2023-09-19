using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves the vehicle forward
        transform.Translate(0, 0, 1);
        //Time.deltaTime helps to keep track the speed and time between all of the different frames
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
