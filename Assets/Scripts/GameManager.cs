using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Этот метод можно вызвать через OnClick Events
    public void StartGame()
    {
        //Health.ResetHealth();
        SceneManager.LoadScene("SampleScene"); // SampleScene - это название файла сцены, которая откроется
    }

    public void ExitGame()
    {
        Debug.Log("Игра закрыта");
        Application.Quit();
    }
}