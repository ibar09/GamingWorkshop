using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CharacterController>().score += 1;
            Debug.Log(other.gameObject.GetComponent<CharacterController>().score);
            Destroy(gameObject);
        }
    }

}