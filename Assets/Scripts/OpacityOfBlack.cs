using UnityEngine;
using UnityEngine.UI; // 1. Added this to allow access to UI components

public class OpacityOfBlack : MonoBehaviour
{
    public float value = 0f;
    private Image blackImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 2. Cache the Image component from this GameObject
        blackImage = GetComponent<Image>();

        // Turn the object off immediately on start as you intended
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 3. Call this method from other scripts to turn the image on and change opacity
    public void RevealAndSetOpacity(float alphaValue)
    {
        // Ensure the object is turned on so it is visible
        gameObject.SetActive(true);
        value = value + alphaValue/400f;
        

        if (blackImage != null)
        {
            // Read, modify alpha, and reassign the color
            Color currentColor = blackImage.color;
            Color newColor = new Color(currentColor.r, currentColor.g, currentColor.b, value);
            blackImage.color = newColor;
        }
    }
}