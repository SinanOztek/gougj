using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement1 : MonoBehaviour
{
   
    
        private Rigidbody mainChar;
        public Vector2 moveVal;
        public float moveSpeed=10;

        private void Awake() 
        {
            mainChar = GetComponent<Rigidbody>();
        }
        public void Moving(InputAction.CallbackContext value) 
        {
            if (value.performed) 
            {
            moveVal = value.ReadValue<Vector2>();
            
            }
            if (value.canceled) 
            {
            moveVal = value.ReadValue<Vector2>();
            }
        }
    
    
}
