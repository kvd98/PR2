using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float Speed = 2f;
    public float Distance = 2f;

    void Update()
    {
        // Движение вперед-назад по синусоиде
        float movement = Mathf.Sin(Time.time * Speed) * Distance + 4f;
        transform.position = new Vector3(transform.position.x, movement, transform.position.z);
    }
}