using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRaycast : MonoBehaviour
{
    [SerializeField] private readonly float rayLength = 5f;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private readonly string excludeLayerName = null;

    private ButtonController raycastedObj;
    public bool isActive = true;


    [SerializeField] public KeyCode openDoorKey = KeyCode.F;

    private bool isCrosshairActive;
    private bool doOnce;

    private const string interactableTag = "Button";
    private const string interactableTag2 = "Button2";

    public GameObject weapon;
    public GameObject _questionToStart;
    public GameObject _questionToStartTour2;
    public Camera Cam;
    public GameObject _crossHair;


    public void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if (Physics.Raycast(transform.position, fwd, out RaycastHit hit, rayLength, mask))
        {
            if (hit.collider.CompareTag(interactableTag))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<ButtonController>();
                }
                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(openDoorKey))
                {
                    raycastedObj.PlayAnimation();
                    Tour1();
                }
            }
            if (hit.collider.CompareTag(interactableTag2))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<ButtonController>();
                }
                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(openDoorKey))
                {
                    raycastedObj.PlayAnimation();
                    Tour2();
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

    

    public void Tour1()
    {
        _questionToStart.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        _crossHair.SetActive(false);
    }

    public void Tour2()
    {
        _questionToStartTour2.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        _crossHair.SetActive(false);
    }
}
