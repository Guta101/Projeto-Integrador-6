using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentUI : MonoBehaviour
{
    enum PartType
    {
        Head,
        Arm,
        Hand,
        Torso,
        Leg
    }

    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private EquipmentSlot equipSlot;
    [SerializeField] private PartType partType;
    [SerializeField] private List<EquipmentSlot> currentSlots;

    private void OnEnable()
    {
        GenEquipment();
    }

    private void OnDisable()
    {
        DestroyEquipment();
    }

    private void GenEquipment()
    {
        switch(partType)
        {
            case PartType.Head:
                foreach (PlayerEquippablePart part in inventory.PlayerCurrentParts.Heads)
                {
                    EquipmentSlot newSlot = Instantiate(equipSlot, transform);
                    newSlot.Init(part);
                    currentSlots.Add(newSlot);
                }
                break;
            case PartType.Arm:
                foreach (PlayerEquippablePart part in inventory.PlayerCurrentParts.Arms)
                {
                    EquipmentSlot newSlot = Instantiate(equipSlot, transform);
                    newSlot.Init(part);
                    currentSlots.Add(newSlot);
                }
                break;
            case PartType.Hand:
                foreach (PlayerEquippablePart part in inventory.PlayerCurrentParts.Hands)
                {
                    EquipmentSlot newSlot = Instantiate(equipSlot, transform);
                    newSlot.Init(part);
                    currentSlots.Add(newSlot);
                }
                break;
            case PartType.Torso:
                foreach (PlayerEquippablePart part in inventory.PlayerCurrentParts.Torso)
                {
                    EquipmentSlot newSlot = Instantiate(equipSlot, transform);
                    newSlot.Init(part);
                    currentSlots.Add(newSlot);
                }
                break;
            case PartType.Leg:
                foreach (PlayerEquippablePart part in inventory.PlayerCurrentParts.Legs)
                {
                    EquipmentSlot newSlot = Instantiate(equipSlot, transform);
                    newSlot.Init(part);
                    currentSlots.Add(newSlot);
                }
                break;
        }
   
    }

    private void DestroyEquipment()
    {
        foreach(EquipmentSlot slot in currentSlots)
        {
            Destroy(slot.gameObject);
        }
        currentSlots.Clear();
    }

    public void UpdateEquipment()
    {
        DestroyEquipment();
        GenEquipment();
    }
}
