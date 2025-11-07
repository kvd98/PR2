using UnityEngine;
public class DeathZone : MonoBehaviour
{
    public HealthManager health;
    // точка спавна
    public Vector3 respawnPosition = new Vector3(-8, 1.4f, -3);
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //Проверяем, что вошёл игрок
        {
            health.TakeDamage();
            other.transform.position = respawnPosition; //Телепорт
            Rigidbody rb = other.GetComponent<Rigidbody>();  //Сброс скорости, набраной при падении
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
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
