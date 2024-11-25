using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Home_InstructionPanelScript : MonoBehaviour
{
    public GameObject instructionPanel;
    public void Appear()
    {
        instructionPanel.SetActive(true);
    }
    public void Close()
    {
        instructionPanel.SetActive(false);
    }
}
