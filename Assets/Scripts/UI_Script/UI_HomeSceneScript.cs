using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_HomeSceneScript : MonoBehaviour
{
    [SerializeField] UI_Home_InstructionPanelScript instructionPanel;
    [SerializeField] UI_Home_InstructionPanelScript creditPanel;
    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Credit()
    {
        creditPanel.Appear();
    }
    public void Instruction()
    {
        instructionPanel.Appear();
    }
}
