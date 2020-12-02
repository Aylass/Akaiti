using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    Animator anime;
    SpriteRenderer spriteRenderer;
    public bool correndo;
    // Start is called before the first frame update
    void Start()
    {
        correndo = true;
        anime = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(correndo == true){
        if(Input.GetKey(KeyCode.RightArrow)){
            spriteRenderer.flipX = false;
            anime.SetBool("IsRunning", true);
            
        }else if(Input.GetKey(KeyCode.LeftArrow)){
            spriteRenderer.flipX = true;
            anime.SetBool("IsRunning", true);
        }else{
            anime.SetBool("IsRunning", false);
        }
        }else{
            anime.SetBool("IsRunning", false);
        }
        
    }
}
