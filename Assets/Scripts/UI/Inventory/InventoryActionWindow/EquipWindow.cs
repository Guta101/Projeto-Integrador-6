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
        if (item is WeaponInterface)
            foreach (PlayerEquippablePart part in ((WeaponInterface)item).ItemData.EquippableParts)
                {
                    EquipButton button = Instantiate(equipButton, windowTransform);
                    button.Init(part, item);
                }
        else if (item is EquipableInterface)
            foreach (PlayerEquippablePart part in item.ItemData.EquippableParts)
                {
                    EquipButton button = Instantiate(equipButton, windowTransform);
                    button.Init(part, item);
                }
    }
}
