using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbable : MonoBehaviour, IInteractible
{
    PlayerStateManager playerStateManager;

    public void Interact()
    {
        Debug.Log("Escada");
    }

    public void EnterClimb()
    {

    }

    private void EndClimb()
    {

    }
}
