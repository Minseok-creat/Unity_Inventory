using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private UIMainMenu uiMainMenu;
    public UIMainMenu UIMainMenu { get => uiMainMenu; set => uiMainMenu = value; }

    [SerializeField] private UIStatus uiStatus;
    public UIStatus UIStatus { get => uiStatus; set => uiStatus = value; }

    [SerializeField] private UIInventory uiInventory;
    public UIInventory UIInventory { get => uiInventory; set => uiInventory = value; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        uiMainMenu.gameObject.SetActive(true);
        uiInventory.gameObject.SetActive(false);
        uiStatus.gameObject.SetActive(false);
    }

    public void ShowStatus()
    {
        uiStatus.gameObject.SetActive(true);
        uiInventory.gameObject.SetActive(false);
    }

    public void ShowInventory()
    {
        uiInventory.gameObject.SetActive(true);
        uiStatus.gameObject.SetActive(false);
    }
}

