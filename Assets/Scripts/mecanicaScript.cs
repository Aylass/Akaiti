using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mecanicaScript : MonoBehaviour
{

    public Transform player1;
    public Transform player2;

    public GameObject botaoPonte;
    private bool clico;//verifica se o player1 apertou o botão
    public GameObject ponteLevantada;
    public GameObject ponteAbaixada; 

    public GameObject canvasFim;//para desaparecer o canvas de fim de jogo e so aparecer quando for a hora
    public GameObject canvasGanhou;//para desaparecer o canvas de ganhou e so aparecer quando for a hora
    // Start is called before the first frame update
    void Start()
    {
        ponteLevantada.SetActive(true);//ponte levantada aparece
        ponteAbaixada.SetActive(false);//ponte abaixada não aparece
        botaoPonte.SetActive(true);
        canvasFim.SetActive(false);
        canvasGanhou.SetActive(false);
        clico = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos1 = player1.transform.position;
        Vector3 pos2 = player2.transform.position;

        if((pos1.x >= -8.5)&&(pos1.x <= -7)){//se o jogador1 estiver perto do botao da ponte
            if(Input.GetKey(KeyCode.E)){//retorna TRUE se o jogador apertar E para ativar o botão
                ponteAbaixada.SetActive(true);//ponte abaixada não aparece
                ponteLevantada.SetActive(false);
                botaoPonte.SetActive(false);
                clico = true;
            }
        }

        //se o jogador 2 cair da ponte
        if((pos2.x <= 2)&&(clico == false)){
            canvasFim.SetActive(true);
        }

        //se ambos os personagens chegarem a bandeira
        if((pos1.x >= 6.50)&&(pos2.x <= -6.50)){
            canvasGanhou.SetActive(true);
        }
    }
}
