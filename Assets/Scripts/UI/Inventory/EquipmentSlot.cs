using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentSlot : MonoBehaviour
{
    private PlayerEquippablePart part;
    [SerializeField] private Image partIcon;
    [SerializeField] private Image itemIcon;

    public void Init(PlayerEquippablePart part)
    {
        this.part = part;
        partIcon.sprite = part.PartIcon;
    }
}
