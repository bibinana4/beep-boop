using UnityEngine;

public class SanityInteraction : MonoBehaviour
{
    public int sanityChange = -10;      // negative drains sanity, positive restores it
    public bool oneTimePerDay = true;
    public PlayerSanity playerSanity;

    private bool playerInRange = false;
    private bool usedToday = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) playerInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) playerInRange = false;
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Use();
        }
    }

    private void Use()
    {
        if (oneTimePerDay && usedToday) return;
        usedToday = true;

        if (sanityChange < 0) playerSanity.TakeDamage(-sanityChange);
        else playerSanity.HealDamage(sanityChange);
    }

    public void ResetForNewDay()
    {
        usedToday = false;
    }
}