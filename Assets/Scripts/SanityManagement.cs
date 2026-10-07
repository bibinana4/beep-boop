using UnityEngine;

public class PlayerSanity : MonoBehaviour
{
    public int Sanity = 100;
    public int PosMult = 0;
    public HealthPos changepos;

    public void TakeDamage(int SanDmg)
    {
        if (Sanity - SanDmg < 0)
        {
            Sanity = 0;
            changepos.ChangePos(-SanDmg);
            Debug.Log("CurrentSanity" + Sanity);
        }

        else
        {
            Sanity -= SanDmg;
            changepos.ChangePos(-SanDmg);
            Debug.Log("CurrentSanity" + Sanity);
        }
    }

    public void HealDamage(int SanHeal)
    {
        if (Sanity + SanHeal > 100)
        {
            Sanity = 100;
            changepos.ChangePos(SanHeal);
            Debug.Log("CurrentSanity" + Sanity);
        }
        else
        {
            Sanity += SanHeal;
            changepos.ChangePos(SanHeal);
            Debug.Log("CurrentSanity" + Sanity);
        }
    }
}