using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPulo : MonoBehaviour
{

    private bool pulo;//true se ele ta no chao e pode pula
  
    public GameObject play1;
     
    public GameObject play2;
    // Start is called before the first frame update
    void Start()
    {
        pulo = true;
    }

    // Update is called once per frame
    void Update()
    {
        //pulo dos personagens
        if(pulo && Input.GetKey(KeyCode.UpArrow)){
            //Debug.Log("Pulo");
            play1.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,100));
            play2.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,100));
            pulo = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col){
            pulo = true;
    }
}
