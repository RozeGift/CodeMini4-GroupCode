using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{ 
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Instruction()
    {
        SceneManager.LoadScene("InstructionlScene");
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene("CreditScene");
    }
}
