using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer r;
    Rigidbody rigidBody;
    [SerializeField] float timeToWait = 5f;

    void Start()
    {
        r = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        r.enabled = false;
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait){
            r.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
