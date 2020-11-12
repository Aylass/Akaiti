using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour
{
    public Transform player1;  
    public GameObject cameraEncontro;
    public GameObject camera1;
    public GameObject camera2;
    public AudioSource musica;
    // Start is called before the first frame update
    void Start()
    {
        cameraEncontro.SetActive(false);
        camera1.SetActive(true);
        camera2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 posicao = player1.transform.position;
         if(posicao.x >= -0.37){//quando eles se encontrarem
            cameraEncontro.SetActive(true);
            camera1.SetActive(false);
            camera2.SetActive(false);
            musica.spatialBlend = 0;
         }
        
    }
}
