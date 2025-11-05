using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;



public class HealthManager : MonoBehaviour
{
    public TextMeshProUGUI Label;
    
        private int _HealPoints;

        public HealthManager()
        {
            _HealPoints = 3;
        }

        public void ResetHealth()
        {
            _HealPoints = 3;
        }

        public void TakeDamage()
        {
            if (_HealPoints == 0)
            {
                SceneManager.LoadScene("MainMenu");
                return;
            }
            _HealPoints -= 1;
            UpdateHealth();
        }

        public int GetHealth()
        { 
        return _HealPoints;
         }



    public void UpdateHealth()
    {
        string Hearts = "";
        int HeartsCount = GetHealth();
        for (int i = 0; i < HeartsCount; i++)
        {
           Hearts += "♥";
        }
        Label.text = Hearts;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
