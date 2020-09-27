using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btProximoNivel : MonoBehaviour
{
    // Start is called before the first frame update
    public int level;
    private string proximonivel;
    public void ProximoNivel(){
        proximonivel = "Level"+level; 
        Application.LoadLevel(proximonivel);
    }
}
