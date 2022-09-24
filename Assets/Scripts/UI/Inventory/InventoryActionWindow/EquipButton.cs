using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EquipButton : MonoBehaviour
{
    [SerializeField] private PlayerEquippablePart part;
    [SerializeField] private EquipableInterface item;
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private TextMeshProUGUI textMeshPro;

    public void Init(PlayerEquippablePart part, EquipableInterface item)
    {
        this.part = part;
        this.item = item;
        textMeshPro.text = part.name;
    }

    public void Equip()
    {
        playerInventory.EquipItem(item, part);
    }


}
