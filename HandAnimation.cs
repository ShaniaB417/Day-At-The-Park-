using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour //leave this 
{
    [SerializeField] private InputActionReference gripReference;
    [SerializeField] private InputActionReference TriggerReference;
    [SerializeField] private Animator handAnimator;

    void Update()
    {
        float gripValue = gripReference.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);

        float TriggerValue = TriggerReference.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", TriggerValue);
    }
}


//issue with right hand controls 