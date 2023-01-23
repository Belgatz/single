using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollect : MonoBehaviour
{
    private int pyres = 0;
    [SerializeField] private TextMeshProUGUI PyresText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Pyre"))
        {
            Destroy(collision.gameObject);
            pyres++;
            PyresText.text = "Pyres: " + pyres;
            
      
    }
    }
}
