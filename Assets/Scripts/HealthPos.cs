using UnityEngine;

public class HealthPos : MonoBehaviour
{
    public int ChangeX = 0;
    

    public void ChangePos(int Pos)
    {
        float x = transform.position.x;
        float y = transform.position.y;

        if (x + (Pos * 4) < -200)
        {
            transform.position = new Vector3(-200, y, 0);
            
            Debug.Log("it worked 1");
        }
        else if (x + (Pos * 4) > 200)
        {
            transform.position = new Vector3(200, y, 0);
            
            Debug.Log("it worked 2");
        }
        else
        {
            ChangeX = (Pos * 4);
            Debug.Log("ChangePositionBy" + ChangeX);
            transform.position += new Vector3(ChangeX, 0, 0);
            
            
            Debug.Log("it worked");
        }
        x = transform.position.x;
        Debug.Log(("Absolute = " + Mathf.Abs(Pos) * 4));
        Debug.Log("x position = " + x);
    }    

}

