using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private Animator buttonAnim;


    private void Awake()

    {
        buttonAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        buttonAnim.Play("buttonDown", 0, 0.0f);
    }
}
