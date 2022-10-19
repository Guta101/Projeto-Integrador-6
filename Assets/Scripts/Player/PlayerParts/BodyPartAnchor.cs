using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartAnchor : MonoBehaviour
{
    [SerializeField] private PartType type;
    public PartType Type { get { return type; } }
    public bool isFree = true;
}
