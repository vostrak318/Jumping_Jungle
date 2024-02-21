using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Reference na UI panel s pause menu
    public Button resumeButton; // Reference na tla��tko pro pokra�ov�n� ve h�e
    public Button settingsButton; // Reference na tla��tko pro otev�en� nastaven�
    public Button exitButton; // Reference na tla��tko pro ukon�en� hry

    private bool isPaused = false; // Pomocn� prom�nn� pro sledov�n� stavu pauzy

    void Start()
    {
        // Nastaven� funkc� pro ka�d� tla��tko
        resumeButton.onClick.AddListener(ResumeGame);
        settingsButton.onClick.AddListener(OpenSettings);
        exitButton.onClick.AddListener(ExitGame);
    }

    void Update()
    {
        // Kontrola stisknut� kl�vesy Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame(); // Pokud je hra pozastavena, pokra�ujeme ve h�e
            else
                PauseGame(); // Jinak zastav�me hru
        }
    }

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f; // Zastaven� �asu ve h�e
        pauseMenuUI.SetActive(true); // Zobrazen� pause menu
    }

    void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; // Obnoven� norm�ln�ho �asu ve h�e
        pauseMenuUI.SetActive(false); // Skryt� pause menu
    }

    void OpenSettings()
    {
        // Zde m��ete implementovat otev�en� nastaven�
        Debug.Log("Open Settings"); // Prozat�m pouze vyp�eme zpr�vu v konzoli
    }

    void ExitGame()
    {
        // Zde m��ete implementovat ukon�en� hry
        Debug.Log("Exit Game"); // Prozat�m pouze vyp�eme zpr�vu v konzoli
        Application.Quit(); // Toto by m�lo b�t pou�ito pouze v buildu, ne ve h�e v editoru
    }
}
