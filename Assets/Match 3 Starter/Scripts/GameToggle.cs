using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameToggle : MonoBehaviour
{
    [SerializeField] Canvas modePanel;
    [SerializeField] GameObject GUI;
    [SerializeField] GameObject boardManager;

    private bool active = false;

    private void Start()
    {
        modePanel.enabled = true;
        GUI.SetActive(false);
        boardManager.SetActive(false);
    }

    public void ToggleGame()
    {
        active = !active;
        modePanel.enabled = active;
    }

    public void StartGame()
    {
        modePanel.enabled = false;
        GUI.SetActive(true);
        boardManager.SetActive(true);

    }
}