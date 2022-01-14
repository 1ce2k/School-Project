using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private readonly float rayLength = 5f;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private readonly string excludeLayerName = null;

    private ButtonController raycastedObj;
    public bool isActive = true;


    [SerializeField] public KeyCode openDoorKey = KeyCode.F;

    private bool isCrosshairActive;
    private bool doOnce;

    private const string interactableTag = "InteractiveObject";

    public GameObject spawner;
    public GameObject weapon;
    public GameObject _questionToStart;
    public Camera Cam;


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
                    ButtonPressed();
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

    public void ButtonPressed()
    {
        Cam.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        _questionToStart.SetActive(true);
        Time.timeScale = 0f;


    }

    public void GameStart()
    {
        Cam.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        _questionToStart.SetActive(false);
        spawner.SetActive(true);
        weapon.SetActive(true);
        Time.timeScale = 1f;

    }
}
