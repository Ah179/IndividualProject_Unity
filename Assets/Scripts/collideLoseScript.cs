using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideLoseScript : MonoBehaviour
{
    public WinLose WinLoseScript;

    private void OnTriggerEnter(Collider other)
    {
        WinLoseScript.LoseLevel();
    }
}
