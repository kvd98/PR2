using TMPro;
using UnityEditor;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public CoinsCounter CoinsFolder;
    
    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerController>(out var player))
        {
            // Уничтожаем текущий объект
            Destroy(gameObject);
            CoinsFolder.TakeMoney();
        }
    }

    void Start()
    {
 
    }
}