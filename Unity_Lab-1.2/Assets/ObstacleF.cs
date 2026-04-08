using UnityEngine;

public class ObstacleF : MonoBehaviour {
    public float a = 4f;
    public float speed = 1.5f;
    private float t = 0;

    void Update() {
        float oldX = a * Mathf.Pow(Mathf.Cos(t), 3);
        float oldY = a * Mathf.Pow(Mathf.Sin(t), 3);

        t += Time.deltaTime * speed;

        float newX = a * Mathf.Pow(Mathf.Cos(t), 3);
        float newY = a * Mathf.Pow(Mathf.Sin(t), 3);

        transform.Translate(new Vector3(newX - oldX, newY - oldY, 0), Space.World);
    }
}