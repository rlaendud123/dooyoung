using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject score;
    // Start is called before the first frame update
    void Start()
    {
       this.score = GameObject.Find("score"); 
    
    }

      void OntriggerEnter2D(Collider2D other)
      {this.score.GetComponent<scoreController>().gamescore -= 5;
       Destroy(other.gameObject);
      }
    // Update is called once per frame
    void Update()
       
    {
    
      if (Input.GetKey(KeyCode.LeftArrow))
         {transform.localScale = new Vector3(-1, 1, 1);
         transform.Translate(-0.05f, 0, 0);}

      if (Input.GetKey(KeyCode.RightArrow))

      {transform.localScale = new Vector3(1, 1, 1);
         transform.Translate(0.05f, 0, 0);}


    }

    
}
