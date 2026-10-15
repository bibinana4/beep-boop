using UnityEngine;

public class ClockArms : MonoBehaviour
{
    public RectTransform arm1;
    public RectTransform arm2;

    public float speed1 = 3f;
    public float speed2 = 0.05f;
    //oneminute = 6deg

    void Update()
    {
        arm1.RotateAround(
            transform.position,
            Vector3.forward,
            -speed1 * Time.deltaTime
        );

        arm2.RotateAround(
            transform.position,
            Vector3.forward,
            -speed2 * Time.deltaTime
        );
    }
}