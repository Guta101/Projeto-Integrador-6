using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSlot : MonoBehaviour
{
    private PlayerEquippablePart part;

    public void Init(PlayerEquippablePart part)
    {
        this.part = part;
    }
}
