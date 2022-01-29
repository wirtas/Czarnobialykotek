using System;
using UnityEditor;
using UnityEngine;

public class TicketInspector : MonoBehaviour
{
    [SerializeField] private bool isLeftWall = true;
    [SerializeField] private Collider2D wall;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("Player")) return;
        
        PlayerColor playerColor = col.gameObject.GetComponent<PlayerColor>();
        if ((!playerColor.IsRightBlack || !isLeftWall) && (playerColor.IsRightBlack || isLeftWall)) return;
        
        wall.gameObject.SetActive(false);
    }

    public void PlayerLeft()
    {
        wall.gameObject.SetActive(true);
    }
}
