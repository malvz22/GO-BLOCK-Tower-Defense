using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("Gameplay2");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
