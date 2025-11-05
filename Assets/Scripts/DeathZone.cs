using UnityEngine;
public class DeathZone : MonoBehaviour
{
    public HealthManager heal1;
    // точка спавна
    public Vector3 respawnPosition = new Vector3(-8, 1.4f, -3);
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //Проверяем, что вошёл игрок
        {
            heal1.TakeDamage();
            other.transform.position = respawnPosition;
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
