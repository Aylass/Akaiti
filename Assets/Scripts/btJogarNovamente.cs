using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class btJogarNovamente : MonoBehaviour
{
    public int level;
    private string proximonivel;
    public void JogarNovamente(){
        proximonivel = "Level"+level; 
        Application.LoadLevel(proximonivel);
    }
}
