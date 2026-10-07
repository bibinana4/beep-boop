using UnityEngine;

public class PlayerSanity : MonoBehaviour
{
    public int Sanity = 100;

    public void TakeDamage(int SanDmg)
    {
        if (Sanity - SanDmg < 0)
        {
            Sanity = 0;
            Debug.Log("CurrentSanity" + Sanity);
        }

        else
        {
            Sanity -= SanDmg;
            Debug.Log("CurrentSanity" + Sanity);
        }
    }

    public void HealDamage(int SanHeal)
    {
        if (Sanity + SanHeal > 100)
        {
            Sanity = 100;
            Debug.Log("CurrentSanity" + Sanity);
        }
        else
        {
            Sanity += SanHeal;
            Debug.Log("CurrentSanity" + Sanity);
        }
    }
}