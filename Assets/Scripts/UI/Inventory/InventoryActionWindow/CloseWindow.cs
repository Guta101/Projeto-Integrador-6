using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindow : MonoBehaviour
{
    [SerializeField] private GameEvent closeContextWindow;

    public void CloseWindows()
    {
        closeContextWindow.Raise();
    }
}
