using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Rotate(180f, 0.0f, 0.0f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.y <-7f)
        {
            Destroy(gameObject);
        }
    }
}
