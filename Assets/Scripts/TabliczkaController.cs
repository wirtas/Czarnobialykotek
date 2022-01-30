using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TabliczkaController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txtfield;
    [SerializeField] private string tekst;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            txtfield.text = tekst;
            txtfield.gameObject.SetActive(true);
        }
        
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            txtfield.gameObject.SetActive(false);
        }
        
    }
}
