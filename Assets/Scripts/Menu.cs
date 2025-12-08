using UnityEngine;
using UnityEngine.SceneManagement; 

public class Menu : MonoBehaviour
{
    public GameObject StartMainMenu;
    public GameObject levelSelect;
    public void StartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void GoToLevelSelect()
    {
        StartMainMenu.SetActive(false);
        levelSelect.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
   
}
