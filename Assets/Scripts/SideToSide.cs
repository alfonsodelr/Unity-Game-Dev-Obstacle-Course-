using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSide : MonoBehaviour
{

    [SerializeField] float zValue = 0.0f;

    void Update()
    {
       
       if(transform.position.z <= 3.7 || transform.position.z >= 9.0){
            zValue *= -1;
        }
        transform.Translate(0, 0, -zValue); 
    }
}

//3.7 - 9.0