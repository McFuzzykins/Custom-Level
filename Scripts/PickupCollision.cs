using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupCollision : MonoBehaviour
{
    void OnCollisionEnter (Collision collider)
    {
        if (collider.collider.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
