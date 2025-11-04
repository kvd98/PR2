using UnityEngine;

public class Bouncer : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        float BounceForce = 500f;
        // Проверяем, что у объекта есть компонент PlayerController
        if (other.collider.TryGetComponent<PlayerController>(out var player))
        {
            Rigidbody rb = other.collider.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * BounceForce);
            
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
