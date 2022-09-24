using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ContextMenuCloser : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private bool isMouseOver;

    private void OnEnable()
    {
        playerController.PlayerInput.UI.Click.performed += _ => OnClick();
    }

    private void OnDisable()
    {
        playerController.PlayerInput.UI.Click.performed -= _ => OnClick();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseOver = false;
    }

    public void OnClick()
    {
        Debug.Log("AAA");
        if (!isMouseOver)
            DestroyWindow();
    }

    public void DestroyWindow()
    {
        Destroy(gameObject);
    }
}
