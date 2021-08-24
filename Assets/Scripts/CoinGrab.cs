using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGrab : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            gameObject.tag = "Hit";
            GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
