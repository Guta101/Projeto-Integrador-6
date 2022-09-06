using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDTest : MonoBehaviour
{
    [SerializeField] private PlayerBaseState currentSuperState;
    [SerializeField] private PlayerBaseState currentSubState;
    [SerializeField] private PlayerStateManager context;

    [SerializeField] private TextMeshProUGUI superStateText;
    [SerializeField] private TextMeshProUGUI subStateText;

    // Update is called once per frame
    void Update()
    {
        superStateText.text = context.CurrentState.GetType().Name;
        subStateText.text = context.CurrentState.CurrentSubState.GetType().Name;
    }
}
