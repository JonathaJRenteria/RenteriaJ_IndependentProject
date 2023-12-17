using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public int totalSpheres = 0; // Set the total number of spheres in the Inspector
    public int collectedSpheres = 0; // Change visibility to public

    // Cache cursor values for optimization
    private bool cursorVisible;
    private CursorLockMode cursorLockState;

    void Start()
    {
        UpdateCursorState();
    }

    void Update()
    {
        // Toggle cursor based on the game over state
        bool isGameOver = gameOverUI.activeInHierarchy;

        // Update cursor values
        cursorVisible = isGameOver ? true : false;
        cursorLockState = isGameOver ? CursorLockMode.None : CursorLockMode.Locked;

        // Apply cursor values only if the current scene is not the Main Menu
        if (SceneManager.GetActiveScene().name != "MainMenu")
        {
            Cursor.visible = cursorVisible;
            Cursor.lockState = cursorLockState;
        }
    }

    public void CollectSphere()
    {
        collectedSpheres++;

        // Check if all spheres are collected
        if (collectedSpheres >= totalSpheres)
        {
            BeatGame();
        }
    }

    // Make BeatGame method public
    public void BeatGame()
    {
        // Add any logic you need when the player beats the game
        Debug.Log("Congratulations! You collected all spheres and beat the game.");

        // Load the victory scene or your desired scene
        SceneManager.LoadScene("VictoryScene");
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void mainMenu()
    {
        Debug.Log("Main Menu button clicked");
        // Add any logic you need when the level ends

        // Load the game over scene or your desired scene
        SceneManager.LoadScene("MainMenu");
    }

    public void quit()
    {
        Debug.Log("Quit button clicked");
        Application.Quit();
    }

    public void play()
    {
        SceneManager.LoadScene("Attempt 0");
    }

    // Updated gameOver method to accept a scene name
    public void gameOver(string sceneName)
    {
        gameOverUI.SetActive(true);
        SceneManager.LoadScene(sceneName);
    }

    // Cache cursor state for optimization
    private void UpdateCursorState()
    {
        cursorVisible = Cursor.visible;
        cursorLockState = Cursor.lockState;
    }
}











