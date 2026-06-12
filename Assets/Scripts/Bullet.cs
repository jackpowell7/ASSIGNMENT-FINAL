using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // speed variable of 8
    private float _speed = 8.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // translate bullet up
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if (transform.position.y > 8f)
        {
            Destroy(this.gameObject);
        }
    }

  
}
