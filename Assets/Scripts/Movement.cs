using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x += Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        position.y += Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.position = position;
    }
}
