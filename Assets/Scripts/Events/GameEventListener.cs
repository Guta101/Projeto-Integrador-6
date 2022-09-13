using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour, IEventListener
{
    [SerializeField] private GameEvent gameEvent;

    [SerializeField] private UnityEvent response;

    public void OnEnable()
    {
        if (gameEvent != null)
            gameEvent.RegisterListener(this);
    }

    public void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventRaise()
    {
        response?.Invoke();
    }
}
