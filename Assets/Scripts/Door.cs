using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private int keyAmount;
    [SerializeField] private Sprite  openSprite;
    [SerializeField] private bool isDoorOpen = false;

    public int KeyAmount
    {
        get => keyAmount;
        set
        {
            keyAmount = value;
            if (value >= 0)
            {
                OpenDoor();
            }
        }
    }
    
    public  void KeyPickedUp()
    {
        KeyAmount--;
    }

    private void OpenDoor()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = openSprite;
        isDoorOpen = true;
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("Player")) return;
        if (isDoorOpen)
        {
            Win();
        }
        
        
    }

    private void Win()
    {
        Debug.Log("You won");
    }
}
