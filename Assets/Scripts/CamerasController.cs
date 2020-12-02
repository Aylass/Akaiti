using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour
{
    public Transform player1; 
    public Transform player2;  
    public GameObject cameraEncontro;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject canvas;
    public AudioSource musica;
    // Start is called before the first frame update
    void Start()
    {
        cameraEncontro.SetActive(false);
        camera1.SetActive(true);
        camera2.SetActive(true);
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 posicao = player1.transform.position;
         if(posicao.x >= -4.8){//quando eles se encontrarem
            cameraEncontro.SetActive(true);
            camera1.SetActive(false);
            camera2.SetActive(false);
            musica.spatialBlend = 0;
            if(posicao.x >= 1.082474){//quando eles colam no outro
                canvas.SetActive(true);
                player1.GetComponent<playerScript3>().enabled = false;
                player1.GetComponent<playerAnimation>().correndo = false;

                player2.GetComponent<playerScript3>().enabled = false;
                player2.GetComponent<player2Animation>().correndo = false;
            }
         }
        
    }
}
