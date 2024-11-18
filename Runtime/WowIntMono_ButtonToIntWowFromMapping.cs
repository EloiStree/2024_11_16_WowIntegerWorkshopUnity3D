using UnityEngine.InputSystem;

namespace Eloi.Wow
{
    public class WowIntMono_ButtonToIntWowFromMapping : WowIntMono_ButtonToIntWow
    {
        public InputActionReference m_buttonReference;

        public void OnEnable()
        {
            m_buttonReference.action.performed += OnPerformed;
            m_buttonReference.action.canceled += OnCanceled;
        }
        public void OnDisable()
        {
            m_buttonReference.action.performed -= OnPerformed;
            m_buttonReference.action.canceled -= OnCanceled;
        }
        public void OnPerformed(InputAction.CallbackContext obj)
        {
            bool value = obj.ReadValue<float>() > 0.5f;
            SetIsDown(value);
        }
        public void OnCanceled(InputAction.CallbackContext obj)
        {
            bool value = obj.ReadValue<float>() > 0.5f;
            SetIsDown(value);
        }

    }

}