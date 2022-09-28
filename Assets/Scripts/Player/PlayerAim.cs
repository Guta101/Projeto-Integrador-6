using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    [SerializeField] private Camera viewportCamera;
    [SerializeField] private Camera renderCamera;
    [SerializeField] private PlayerController controller;

    private void Update()
    {
        Vector3 rawDirection = renderCamera.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, renderCamera.transform.position.z));
        Vector3 direction = viewportCamera.ViewportToWorldPoint(new Vector3(rawDirection.x, rawDirection.y, renderCamera.transform.position.z));
        direction.y = transform.position.y;

        transform.LookAt(direction);
    }
}
