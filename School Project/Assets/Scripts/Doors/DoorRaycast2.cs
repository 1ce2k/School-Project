using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRaycast2 : MonoBehaviour
{
    [SerializeField] private readonly float rayLength = 5f;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private readonly string excludeLayerName = null;

    private MyDoorController raycastedObj;

    [SerializeField] private readonly KeyCode openDoorKey = KeyCode.F;


    private bool isCrosshairActive;
    private bool doOnce;

    private const string interactableTag = "InteractiveObject2";

#pragma warning disable IDE0051 
    private void Update()
#pragma warning restore IDE0051
    {
#pragma warning disable IDE0018 
        RaycastHit hit;
#pragma warning restore IDE0018 
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if (hit.collider.CompareTag(interactableTag))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<MyDoorController>();
                }
                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(openDoorKey))
                {
                    raycastedObj.PlayAnimation();
                }
            }
        }

        else
        {
            if (isCrosshairActive)
            {
                doOnce = false;
            }
        }
    }
}
