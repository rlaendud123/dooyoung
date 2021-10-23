using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour
{
    public float gamescore;
    // Start is called before the first frame update
    void Start()
    {
        gamescore = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        gamescore += 0.01f;
        this.GetComponent<Text>().text = "score : " + (int)gamescore;
    
    }
}
