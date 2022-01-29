using System;
using UnityEngine;

public class ExitInspector : MonoBehaviour
{
    [SerializeField] private TicketInspector wall;

    private void OnTriggerExit2D(Collider2D col)
    {
        if (!col.CompareTag("Player")) return;
        wall.PlayerLeft();
    }
}
