using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mecanica2Script : MonoBehaviour
{
    public GameObject canvasFim;//para desaparecer o canvas de fim de jogo e so aparecer quando for a hora
    public GameObject canvasGanhou;//para desaparecer o canvas de ganhou e so aparecer quando for a hora

    public GameObject blocoGelo;

    public Transform player1;
    public Transform player2;

    void Start(){
        canvasFim.SetActive(false);
        canvasGanhou.SetActive(false);
        blocoGelo.SetActive(false);
    }

    void Update(){
        Vector3 pos1 = player1.transform.position;
        Vector3 pos2 = player2.transform.position;
        if((pos1.x >= 2)&&(pos1.x <= 4)){//se o jogador1 estiver perto do botao da caixa
            if(Input.GetKey(KeyCode.E)){//retorna TRUE se o jogador apertar E para ativar o botão
                //Debug.Log("clico");
                blocoGelo.SetActive(true);
            }
        }

        //se ambos os personagens chegarem a bandeira
        if((pos1.x <= -8)&&(pos2.x >= 3)){
            canvasGanhou.SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        //Debug.Log("colisao");//aconteceu a colisao com os espinhos
        canvasFim.SetActive(true);
    }
}
