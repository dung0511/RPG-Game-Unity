using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_EndGameSceneScript : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Home()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
