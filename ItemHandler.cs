using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

/* This script (so far just the first level) handles pickup 
collisions and collection. Also enables the teleport flag after
all items on that level are collected. */

/* Need to implement:
- text tracking the amount of items collected.
- flag activated when all items are collected.
- move from level 1 to 2 when flag is activated. */

public class ItemHandler : MonoBehaviour
{


    public TextMeshProUGUI countText;

     /* Use something similar to this for
    the teleportation flag between levels */
    public GameObject winTextObject; 

    public GameObject FinalCylinder;
   
    private int count;

    public AudioSource[] keySound;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;

        SetCountText();
        winTextObject.SetActive(false); // !!!!
        FinalCylinder.SetActive(false);
    }


    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("PickUp")) {
            other.gameObject.SetActive(false);
            count = count + 1;
            keySound[0].Play();

            SetCountText();
        }
    }

    void SetCountText() {
        countText.text = "DNA Collected: " + count.ToString();

        
        // !!!!
        if (count >= 10) {
                    // Set the text value of your 'winText'
            winTextObject.SetActive(true);
            FinalCylinder.SetActive(true);
            keySound[1].Play();
		}
    }
}

