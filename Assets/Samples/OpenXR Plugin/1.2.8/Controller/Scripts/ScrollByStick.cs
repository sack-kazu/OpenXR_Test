using UnityEngine.UI;
using UnityEngine.InputSystem;

namespace UnityEngine.XR.OpenXR.Samples.ControllerSample
{
    public class ScrollByStick : MonoBehaviour
    {
        [SerializeField]
        private InputActionReference m_ActionReference;
        public InputActionReference actionReference { get => m_ActionReference; set => m_ActionReference = value; }

        [SerializeField]
        private Scrollbar _scrollbar;
        
        [SerializeField]
        private float scrollSpeed = 0.1f;
        private float newValue = 0;
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (actionReference != null && actionReference.action != null && _scrollbar != null)
            {
                Vector2 value = actionReference.action.ReadValue<Vector2>();
                newValue = _scrollbar.value + scrollSpeed * value.y;
                
                if(newValue > 1 || newValue < 0) return;

                _scrollbar.value = newValue;
            }
            
        }
    }
}
