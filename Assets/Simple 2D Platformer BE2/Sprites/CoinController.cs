using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    float coinSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Random.Range(-0.05f, -0.1f) * coinSpeed, 0);

        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }
}
