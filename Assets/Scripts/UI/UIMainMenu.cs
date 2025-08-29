using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button statusButton;
    [SerializeField] private Button InventoryButton;

    public void Start()
    {
        statusButton.onClick.AddListener(UIManager.Instance.ShowStatus);
        InventoryButton.onClick.AddListener (UIManager.Instance.ShowInventory);
    }

    public void SetCharacterData(Character character)
    {

    }
}
