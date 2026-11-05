using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSanity : MonoBehaviour
{
    public int Sanity = 100;
    public int PosMult = 0;
    public HealthPos changepos;

    private bool isDead = false;

    public void TakeDamage(int SanDmg)
    {
        if (isDead) return;

        if (Sanity - SanDmg < 0)
        {
            // only move the bar by what we actually lost
            changepos.ChangePos(-Sanity);
            Sanity = 0;
        }
        else
        {
            Sanity -= SanDmg;
            changepos.ChangePos(-SanDmg);
        }

        Debug.Log("CurrentSanity" + Sanity);

        if (Sanity <= 0)
        {
            Die();
        }
    }

    public void HealDamage(int SanHeal)
    {
        if (isDead) return;

        if (Sanity + SanHeal > 100)
        {
            // only move the bar by what we actually gained
            changepos.ChangePos(100 - Sanity);
            Sanity = 100;
        }
        else
        {
            Sanity += SanHeal;
            changepos.ChangePos(SanHeal);
        }

        Debug.Log("CurrentSanity" + Sanity);
    }

    private void Die()
    {
        isDead = true;
        Debug.Log("You died!");

        // Restarts the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}