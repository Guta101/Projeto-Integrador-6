using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentSlot : MonoBehaviour
{
    private Transform canvasTransform;
    [SerializeField] private ItemActionMenu menu;
    private PlayerEquippablePart part;
    [SerializeField] private Image partIcon;
    [SerializeField] private Image itemIcon;

    public void Init(PlayerEquippablePart part, Transform canvasTransform)
    {
        this.canvasTransform = canvasTransform;
        this.part = part;
        partIcon.sprite = part.PartIcon;
        if (part.EquippedItem != null)
            itemIcon.color = Color.red;
    }

    public void GenMenu()
    {
        if (part.EquippedItem != null)
        {
            ItemActionMenu menuInstance = Instantiate(menu, transform.position, transform.rotation, canvasTransform);
            menuInstance.Init(part);
        }
    }
}
