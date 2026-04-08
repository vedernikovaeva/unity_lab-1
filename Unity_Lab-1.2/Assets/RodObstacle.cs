using UnityEngine;

public class RodObstacle : MonoBehaviour
{
    public float speed = 2f;      
    public float length = 2f;     
    private float angle = 0f;   

    void Update()
    {
        float oldX = Mathf.Cos(angle) * length;
        float oldZ = Mathf.Sin(angle) * length;

        angle += speed * Time.deltaTime;

        float newX = Mathf.Cos(angle) * length;
        float newZ = Mathf.Sin(angle) * length;

        transform.Translate(new Vector3(newX - oldX, 0, newZ - oldZ), Space.World);
    }
}