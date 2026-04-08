using UnityEngine;

public class ObstacleD : MonoBehaviour 
{
    public float r = 1.0f;      
    public float speed = 3.0f; 
    private float t = 0f;
    private Vector3 startPos;

    void Start() 
    {
        startPos = transform.position;
    }

    void Update() 
    {
        float oldX = r * (t - Mathf.Sin(t));
        float oldY = r * (1 - Mathf.Cos(t));

        t += Time.deltaTime * speed;

        float newX = r * (t - Mathf.Sin(t));
        float newY = r * (1 - Mathf.Cos(t));

        float deltaX = newX - oldX;
        float deltaY = newY - oldY;
        
        transform.Translate(new Vector3(deltaX, deltaY, 0), Space.World);

        if (t > 6.28f) 
        {
            t = 0;
            transform.position = startPos; 
        }
    }
}