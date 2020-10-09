using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed;
    public Transform player1;
    public Transform player2; 

    
    // Start is called before the first frame update
    void Start()
    {
        speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos1 = player1.transform.position;
        Vector3 pos2 = player2.transform.position;


        //movimentação dos personagens

        //Personagem 1 ------------------------------------------------------
        
        //direita
        if(Input.GetKey(KeyCode.RightArrow)){//retorna TRUE enquanto a tecla -> esta precionada
            if(pos1.x <= 7){//para não sair da beirada
                pos1.x += speed * Time.deltaTime;//para nao depender do rocessamento para se locomover
                player1.transform.position = pos1;
            }
        } 
        //esquerda
        if(Input.GetKey(KeyCode.LeftArrow)){//retorna TRUE enquanto a tecla <- esta precionada
            if(pos1.x >= -7){//para não sair da beirada
                pos1.x -= speed * Time.deltaTime;//para nao depender do rocessamento para se locomover
                player1.transform.position = pos1;
            }
        } 

        //Personagem 2 ------------------------------------------------------
        //direita
        if(Input.GetKey(KeyCode.RightArrow)){//retorna TRUE enquanto a tecla -> esta precionada
        if(pos2.x >= -7){//para não sair da beirada
                pos2.x -= speed * Time.deltaTime;//para nao depender do rocessamento para se locomover
                player2.transform.position = pos2;
            }
        } 
        //esquerda
        if(Input.GetKey(KeyCode.LeftArrow)){//retorna TRUE enquanto a tecla <- esta precionada
           if(pos2.x <= 7){//para não sair da beirada
                pos2.x += speed * Time.deltaTime;//para nao depender do rocessamento para se locomover
                player2.transform.position = pos2;
            }
        }
    }
}
