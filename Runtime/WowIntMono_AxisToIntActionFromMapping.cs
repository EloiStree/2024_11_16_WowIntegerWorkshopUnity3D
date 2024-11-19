using UnityEngine.InputSystem;

namespace Eloi.Wow
{
    public class WowIntMono_AxisToIntActionFromMapping : WowIntMono_AxisToIntAction
    {
        public InputActionReference m_axisReference;

        public void OnEnable()
        {
            m_axisReference.action.Enable();
            m_axisReference.action.performed += OnPerformed;
            m_axisReference.action.canceled += OnCanceled;
        }
        public void OnDisable()
        {
            m_axisReference.action.performed -= OnPerformed;
            m_axisReference.action.canceled -= OnCanceled;
        }
        public void OnPerformed(InputAction.CallbackContext obj)
        {
            base.SetAxisValue(obj.ReadValue<float>());
        }
        public void OnCanceled(InputAction.CallbackContext obj)
        {;
            base.SetAxisValue(obj.ReadValue<float>());
        }
    }

}