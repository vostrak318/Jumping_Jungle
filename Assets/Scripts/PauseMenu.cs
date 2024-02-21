using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Reference na UI panel s pause menu
    public Button resumeButton; // Reference na tlaèítko pro pokraèování ve høe
    public Button settingsButton; // Reference na tlaèítko pro otevøení nastavení
    public Button exitButton; // Reference na tlaèítko pro ukonèení hry

    private bool isPaused = false; // Pomocná promìnná pro sledování stavu pauzy

    void Start()
    {
        // Nastavení funkcí pro každé tlaèítko
        resumeButton.onClick.AddListener(ResumeGame);
        settingsButton.onClick.AddListener(OpenSettings);
        exitButton.onClick.AddListener(ExitGame);
    }

    void Update()
    {
        // Kontrola stisknutí klávesy Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame(); // Pokud je hra pozastavena, pokraèujeme ve høe
            else
                PauseGame(); // Jinak zastavíme hru
        }
    }

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f; // Zastavení èasu ve høe
        pauseMenuUI.SetActive(true); // Zobrazení pause menu
    }

    void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; // Obnovení normálního èasu ve høe
        pauseMenuUI.SetActive(false); // Skrytí pause menu
    }

    void OpenSettings()
    {
        // Zde mùžete implementovat otevøení nastavení
        Debug.Log("Open Settings"); // Prozatím pouze vypíšeme zprávu v konzoli
    }

    void ExitGame()
    {
        // Zde mùžete implementovat ukonèení hry
        Debug.Log("Exit Game"); // Prozatím pouze vypíšeme zprávu v konzoli
        Application.Quit(); // Toto by mìlo být použito pouze v buildu, ne ve høe v editoru
    }
}
