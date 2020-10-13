using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Animation : MonoBehaviour
{
     Animator anime;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.RightArrow)){
            spriteRenderer.flipX = true;
            anime.SetBool("IsRunning", true);
        }else if(Input.GetKey(KeyCode.LeftArrow)){
            spriteRenderer.flipX = false;
            anime.SetBool("IsRunning", true);
        }else{
            anime.SetBool("IsRunning", false);
        }
        
    }
}
