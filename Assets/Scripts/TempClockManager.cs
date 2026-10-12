using UnityEngine;
using UnityEngine.InputSystem;

public class DisableObject : MonoBehaviour
{
    public GameObject rotcent;
    bool IsActive = true;
    bool IsInvisible = false;
    void Update()
    {
        if (Keyboard.current == null)
            return;

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            if (IsActive == true)
            {
                IsActive = false;
                rotcent.SetActive(false);
            }
            else
            {
                IsActive = true;
                rotcent.SetActive(true);
            }
        }

        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            if (IsInvisible == false)
            {
                IsInvisible = true;
                SetInvisible(rotcent, true);
            }
            else
            {
                IsInvisible = false;
                SetInvisible(rotcent, false);
            }

        }
    }

    void SetInvisible(GameObject obj, bool invisible)
    {
        CanvasGroup canvasGroup = obj.GetComponent<CanvasGroup>();

        if (canvasGroup == null)
        {
            canvasGroup = obj.AddComponent<CanvasGroup>();
        }

        canvasGroup.alpha = invisible ? 0f : 1f;
    }
}
}