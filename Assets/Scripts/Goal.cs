using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public WinLose WinLoseScript;

    void Update(){
        if (transform.position.y <-10.0f){
            WinLoseScript.WinLevel();
        }
    }
}
