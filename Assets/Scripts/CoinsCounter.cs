using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class CoinsCounter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI LabelCount;
    private int MaxCoins = 0;
    private int CoinCounter;
    private string strCounter;
    public int GetMaximumCoins()
    {
        Debug.Log($"Прямых дочерних объектов: {MaxCoins}");
        return MaxCoins;
    }

    public void TakeMoney()
    {
        CoinCounter += 1;
        strCounter = "Монеты: " + CoinCounter + "/" + MaxCoins;
        LabelCount.text = strCounter;
    }
    void Start()
    {
        MaxCoins = transform.childCount;
        CoinCounter = 0;
        LabelCount.text = "Монеты: 0/" + MaxCoins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
