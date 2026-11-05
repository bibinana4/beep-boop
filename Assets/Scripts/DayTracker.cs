using UnityEngine;

public class DayTracker : MonoBehaviour
{
    public int currentDay = 1;
    public int lastDay = 5;

    public void EndDay()
    {
        if (currentDay >= lastDay)
        {
            Debug.Log("Game over. The week is done.");
            // load your ending screen here
            return;
        }

        currentDay++;
        Debug.Log("Starting day " + currentDay);

        // let all interactions be used again
        foreach (var item in FindObjectsByType<SanityInteraction>(FindObjectsSortMode.None))
        {
            item.ResetForNewDay();
        }
    }
}