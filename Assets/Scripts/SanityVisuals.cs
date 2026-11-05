using UnityEngine;
using UnityEngine.UI;

public class SanityVisuals : MonoBehaviour
{
    public PlayerSanity playerSanity;   // drag your player (with PlayerSanity) here
    public Light mainLight;             // drag your Directional Light here
    public Image darkOverlay;           // a full-screen UI Image (optional for now)

    public float normalLightIntensity = 1f;
    public float darkestLightIntensity = 0.15f;
    public float maxOverlayAlpha = 0.7f;
    public float smoothSpeed = 2f;

    private float currentT = 0f;

    private void Update()
    {
        // 0 = full sanity, 1 = no sanity
        float targetT = 1f - (playerSanity.Sanity / 100f);

        // ease toward the target so it fades instead of snapping
        currentT = Mathf.Lerp(currentT, targetT, Time.deltaTime * smoothSpeed);

        // squaring makes the effect ramp up harder near the end
        float harsh = currentT * currentT;

        if (mainLight != null)
        {
            mainLight.intensity = Mathf.Lerp(normalLightIntensity, darkestLightIntensity, harsh);
        }

        if (darkOverlay != null)
        {
            Color c = darkOverlay.color;
            c.a = Mathf.Lerp(0f, maxOverlayAlpha, harsh);
            darkOverlay.color = c;
        }
    }
}