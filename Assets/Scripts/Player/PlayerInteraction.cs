using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private PlayerController controller;
    [SerializeField] private float interactRadius;

    private void OnEnable()
    {
        controller.PlayerInput.Player.Intereact.performed += _ => Interact();
    }

    private void OnDisable()
    {
        controller.PlayerInput.Player.Intereact.performed -= _ => Interact();
    }

    private void Interact()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.GetComponent<IInteractible>() != null)
            {
                collider.GetComponent<IInteractible>().Interact();
                break;
            }
        }
    }
}
