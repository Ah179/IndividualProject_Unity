using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartrigger : MonoBehaviour
{
    public WinLose WinLoseScript;

    void Update()
    {
        //if you fall you lose
        if(transform.position.y < -10.0f){
            WinLoseScript.LoseLevel();
        }
    }

}
