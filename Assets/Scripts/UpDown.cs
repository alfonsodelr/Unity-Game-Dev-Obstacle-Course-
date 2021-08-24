using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    [SerializeField] float yValue = 0.0f;
    
    void Update()
    {
        if(transform.position.y <= 0.5 || transform.position.y >= 3.0){
            yValue *= -1;
        }
        transform.Translate(0, -yValue, 0);
    }

}
