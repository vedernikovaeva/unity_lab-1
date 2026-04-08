using UnityEngine;

public class ObstacleB : MonoBehaviour {
    public float speed = 2f;
    public float radius = 2f; 
    private float t = 0;

    void Update() {
        float oldX = Mathf.Cos(t) * radius;
        float oldZ = Mathf.Sin(t) * radius;

        t += Time.deltaTime * speed;

        float newX = Mathf.Cos(t) * radius;
        float newZ = Mathf.Sin(t) * radius;

        transform.Translate(new Vector3(newX - oldX, 0, newZ - oldZ), Space.World);
        
        transform.Rotate(0, -speed * Time.deltaTime * Mathf.Rad2Deg, 0);
    }
}