using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("Player")) return;
        PlayerColor playerColor = col.gameObject.GetComponent<PlayerColor>();
        playerColor.ChangePlayerColor();
    }
}
