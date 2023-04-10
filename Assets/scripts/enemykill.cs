using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemykill : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision) 
    {
        if (collision.gameObject.CompareTag("b")) 
        {

            reset();
        }
            
    }
    public void reset() 
    {
        
        SceneManager.LoadScene(1);
       
    }

    
}
