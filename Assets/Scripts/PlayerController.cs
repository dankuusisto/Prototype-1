using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward.
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Make the vehicle flutter around randomly
        //transform.Translate(Random.Range(-1, 2), Random.Range(-1, 2), Random.Range(-1, 2));
        
    }
}
