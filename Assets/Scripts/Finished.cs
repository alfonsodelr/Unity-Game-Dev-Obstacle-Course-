using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finished : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        int current_scene = SceneManager.GetActiveScene().buildIndex;
        int next_scene = current_scene++;

        if(other.gameObject.tag == "Player"){
            SceneManager.LoadScene(current_scene++);
        }
    }
}
