using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/StatBoostVariable")]
public class StatVariable : ScriptableObject
{
    [SerializeField] private float statBoost;
    public float StatBoost { get { return statBoost; } }

    public void AddStatBoost(float value)
    {
        statBoost += value;
    }

    public void RemoveStatBoost(float value)
    {
        statBoost -= value;
    }
}
