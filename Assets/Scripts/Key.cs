using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("Player")) return;
        FindObjectOfType<Door>().KeyPickedUp();
        gameObject.SetActive(false);
    }
}
