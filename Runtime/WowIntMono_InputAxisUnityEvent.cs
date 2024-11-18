using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class WowIntMono_InputAxisUnityEvent : MonoBehaviour
{
    public InputActionReference m_inputAction;
    public UnityEvent<float> m_onValueChanged = new UnityEvent<float>();
   

    [Header("Debug")]
    [Range(-1,1)]
    public float m_axisValue;


    void OnEnable()
    {
        m_inputAction.action.Enable();
        m_inputAction.action.performed += ctx => Context(ctx);
        m_inputAction.action.started += ctx => Context(ctx);
        m_inputAction.action.canceled += ctx => Context(ctx);
    }

    private void Context(InputAction.CallbackContext ctx)
    {
        float value = ctx.ReadValue<float>();
        float current = m_axisValue;
        bool changed= value != current;
        if(changed)
        {
            m_axisValue = value;
            m_onValueChanged.Invoke(m_axisValue);
            
        }

    }

    private void OnDisable()
    {
        m_inputAction.action.Disable();
        m_inputAction.action.performed -= ctx => Context(ctx);
        m_inputAction.action.started -= ctx => Context(ctx);
        m_inputAction.action.canceled -= ctx => Context(ctx);
    
    }
    
}


