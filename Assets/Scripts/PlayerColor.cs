using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
  [SerializeField] private bool isRightBlack;

  public bool IsRightBlack
  {
    get => isRightBlack;
    set
    { 
      gameObject.GetComponent<SpriteRenderer>().color = isRightBlack ? Color.black : Color.white;
      isRightBlack = value;
    }
  }

  public void ChangePlayerColor()
  {
    IsRightBlack = !isRightBlack;
  }
}
