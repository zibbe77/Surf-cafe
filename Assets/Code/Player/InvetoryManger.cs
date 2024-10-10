using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;


public class InvetoryManger : MonoBehaviour
{
    VisualElement ui;
    GameObject uiController;

    VisualElement slot1;
    VisualElement slot2;
    VisualElement slot3;
    VisualElement slot4;

    int[] invetory = new int[4];
    // 0 empty
    // 1 win
    // 2 late

    private void Awake()
    {
        uiController = GameObject.FindGameObjectWithTag("UiControler");
        ui = uiController.GetComponent<UIDocument>().rootVisualElement;

        for (int i = 0; i < 4; i++)
        {

            invetory[i] = 0;
        }
    }

    private void OnEnable()
    {
        slot1 = ui.Q<VisualElement>("slot1");
        slot2 = ui.Q<VisualElement>("slot2");
        slot3 = ui.Q<VisualElement>("slot3");
        slot4 = ui.Q<VisualElement>("slot4");
    }
    int CheckEmptySlot(int type)
    {
        int saveSlot = 0;
        for (int i = 0; i < 4; i++)
        {
            if (invetory[i] == 0)
            {
                invetory[i] = type;
                saveSlot = i + 1;
                break;
            }
        }
        return saveSlot;
    }
    public void AddWine()
    {
        Debug.Log("1");
        int saveSlot = CheckEmptySlot(1);

        switch (saveSlot)
        {
            case 0:
                return;
            case 1:
                // slot1.style.backgroundImage = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Sprites");
                Debug.Log("slot1 ");
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
        }
        Debug.Log("2");
    }
    public void AddLate()
    {

    }
}
