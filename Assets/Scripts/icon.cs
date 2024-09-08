using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeIcon : MonoBehaviour
{
    public Image iconImage;  // Reference to the UI Image component
    public Sprite coinSprite;  // Reference to the new coin Sprite

    public void ChangeToCoin()
    {
        iconImage.sprite = coinSprite;  // Set the image to the coin sprite
    }
}

