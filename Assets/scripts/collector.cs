using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class collector : MonoBehaviour

{
    int score = 0;
    [SerializeField] TMP_Text scoreText;
    private void OnTriggerEnter(Collider other) 
    { 
        if (other.gameObject.CompareTag("a"))
            { 
            Destroy(other.gameObject);
            score++;
            

            scoreText.text = ("score:" + score);

            if(score == 6) 
            { 
                SceneManager.LoadScene(1);
               

            }
            

        }
    }
}
