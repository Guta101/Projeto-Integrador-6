using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipWindow : MonoBehaviour
{
    [SerializeField] private EquipButton equipButton;
    [SerializeField] private Transform windowTransform;


    private EquipableInterface item;

    public void Init(EquipableInterface item)
    {
        this.item = item;
    }

    public void GenEquipButtons()
    {
        Debug.Log(item.ItemData);
        foreach (PlayerEquippablePart part in item.ItemData.EquippableParts)
        {
            EquipButton button = Instantiate(equipButton, windowTransform);
            button.Init(part, item);
        }
    }
}
