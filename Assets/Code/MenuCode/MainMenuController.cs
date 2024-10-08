using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    VisualElement ui;

    // Buttons
    Button startButton;
    Button settingsButton;
    Button creditButton;
    Button exitButton;

    Button exitCreditsButton;
    Button exitSettingsButton;

    // Pop up
    VisualElement damper;
    VisualElement creditsPage;
    VisualElement settingsPage;

    private void Awake()
    {
        ui = GetComponent<UIDocument>().rootVisualElement;
    }

    private void OnEnable()
    {
        //Buttons For main buttons
        startButton = ui.Q<Button>("StartButton");
        startButton.clicked += OnPlayButtonClicked;

        settingsButton = ui.Q<Button>("SettingsButton");
        settingsButton.clicked += OnSettingsButtonClicked;

        creditButton = ui.Q<Button>("CreditsButton");
        creditButton.clicked += OnCreditButtonClicked;

        exitButton = ui.Q<Button>("ExitButton");
        exitButton.clicked += OnExitButtonClicked;

        //Popups 

        damper = ui.Q<VisualElement>("AbsulutDamper");
        creditsPage = ui.Q<VisualElement>("PageCredits");
        settingsPage = ui.Q<VisualElement>("PageSettings");

        //PopUp buttons 
        exitCreditsButton = ui.Q<Button>("ExitCredits");
        exitCreditsButton.clicked += exitCreditsButtonClicked;

        exitSettingsButton = ui.Q<Button>("ExitSettings");
        exitSettingsButton.clicked += exitSettingsButtonClicked;
    }

    void OnPlayButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
    void OnCreditButtonClicked()
    {
        damper.style.display = DisplayStyle.Flex;
        creditsPage.style.display = DisplayStyle.Flex;
    }
    void OnSettingsButtonClicked()
    {
        damper.style.display = DisplayStyle.Flex;
        settingsPage.style.display = DisplayStyle.Flex;
    }
    void OnExitButtonClicked()
    {
        Application.Quit();
    }

    // Exit buttons
    void exitCreditsButtonClicked()
    {
        damper.style.display = DisplayStyle.None;
        settingsPage.style.display = DisplayStyle.None;
    }

    void exitSettingsButtonClicked()
    {
        damper.style.display = DisplayStyle.None;
        settingsPage.style.display = DisplayStyle.None;
    }
}
