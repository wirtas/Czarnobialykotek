using System;
using UnityEditor;
using UnityEngine;

public class TicketInspector : MonoBehaviour
{
    [SerializeField] private bool isLeftWall = true;
    [SerializeField] private Collider2D wall;
    [SerializeField] private GameObject[] oppositeWalls;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("Player")) return;
        PlayerColor playerColor = col.gameObject.GetComponent<PlayerColor>();
        if ((!playerColor.IsRightBlack || !isLeftWall) && (playerColor.IsRightBlack || isLeftWall)) return;
        wall.gameObject.SetActive(false);
        foreach (GameObject oppositeWall in oppositeWalls)
        {
            oppositeWall.SetActive(false);
        }
    }

    public void PlayerLeft(PlayerColor playerColor)
    {
        if ((!playerColor.IsRightBlack || !isLeftWall) && (playerColor.IsRightBlack || isLeftWall))
        {
            wall.gameObject.SetActive(true);
        }
    }
}
