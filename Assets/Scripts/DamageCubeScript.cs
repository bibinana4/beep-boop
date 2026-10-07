using UnityEngine;

public class TestEnemy : MonoBehaviour
{
    public int TestSanityDamage = 24;
    public PlayerSanity playerSanity;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerSanity.TakeDamage(TestSanityDamage);
            Debug.Log("DamageTaken = " + TestSanityDamage);
        }
    }
}