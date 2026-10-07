using UnityEngine;

public class InteractHitbox : MonoBehaviour
{
    private bool playerInside = false;
    public GameObject interactionUI;
    public GameObject eventcube;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            interactionUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
            interactionUI.SetActive(false);
        }
    }

    private void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    private void Interact()
    {
        Debug.Log("Player interacted!");
        eventcube.SetActive(true);
        
    }
}