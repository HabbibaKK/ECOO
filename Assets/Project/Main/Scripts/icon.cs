using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import this to work with UI elements

public class Coin : MonoBehaviour
{
    public Image coinIcon; // Reference to the UI Image for the coin icon
    public Sprite newCoinSprite; // The new sprite that represents the collected coin

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Coin collected!");

            // Change the coin icon
            if (coinIcon != null && newCoinSprite != null)
            {
                coinIcon.sprite = newCoinSprite;
            }

            Destroy(gameObject); // Destroy the coin object after collecting
        }
    }
}
