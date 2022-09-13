using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/CurrentEquipableParts")]
public class PlayerCurrentParts : ScriptableObject
{
    public List<PlayerEquippablePart> Heads = new List<PlayerEquippablePart>();
    public List<PlayerEquippablePart> Arms = new List<PlayerEquippablePart>();
    public List<PlayerEquippablePart> Torso = new List<PlayerEquippablePart>();
    public List<PlayerEquippablePart> Legs = new List<PlayerEquippablePart>();
    public List<PlayerEquippablePart> Hands = new List<PlayerEquippablePart>();
}
