using UnityEngine;

public class TestHealer : MonoBehaviour
{
    public int TestSanityHeal = 13;
    public PlayerSanity playerSanity;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerSanity.HealDamage(TestSanityHeal);
            Debug.Log("HealTaken = " + TestSanityHeal);
        }
    }
}