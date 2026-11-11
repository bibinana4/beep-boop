using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public GameObject bubble;        // the DialogueBubble panel
    public TMP_Text dialogueText;    // the DialogueText inside it
    public GameObject prompt;        // the "Press E" text
    public string[] lines;           // what the NPC says, one line per press of E
    public float showTime = 3f;      // seconds before the bubble disappears

    private bool playerInRange = false;
    private bool showing = false;
    private int lineIndex = 0;
    private float hideTimer = 0f;

    private void Start()
    {
        bubble.SetActive(false);
        if (prompt != null) prompt.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            if (prompt != null) prompt.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            lineIndex = 0;
            if (prompt != null) prompt.SetActive(false);
            if (showing) Hide();
        }
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            ShowNextLine();
        }

        if (showing)
        {
            hideTimer -= Time.deltaTime;
            if (hideTimer <= 0f) Hide();
        }
    }

    private void ShowNextLine()
    {
        if (lines.Length == 0) return;

        dialogueText.text = lines[lineIndex];
        bubble.SetActive(true);
        showing = true;
        hideTimer = showTime;

        lineIndex = (lineIndex + 1) % lines.Length;
    }

    private void Hide()
    {
        bubble.SetActive(false);
        showing = false;
    }
}