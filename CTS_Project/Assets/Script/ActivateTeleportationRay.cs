using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject RightTeleportation;

    public InputActionProperty rightActivate;

    private void Update()
    {
        RightTeleportation.SetActive(rightActivate.action.ReadValue<float>() > 0.1f);
    }
}
