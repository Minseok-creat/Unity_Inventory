using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button backButton;

    private void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.ShowMainMenu);
    }

    public void SetCharacterData(Character character)
    {

    }
}
