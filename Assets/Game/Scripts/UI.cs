using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

    public Canvas[] UICanvas;//0 GameUI 1 PauseUI 2 MenuUI 3 EndGameUI

    private void Awake()
    {
        for (int i = 0; i <UICanvas.Length; i++)
        {
            UICanvas[i].enabled = false;
        }
    }

    public void ManageUI(int UI)
    {
        if (UICanvas[UI].enabled == true)
        {
            UICanvas[UI].enabled = false;
        }
        else
        {
            UICanvas[UI].enabled = true;
            for (int i = 0; i < UICanvas.Length; i++)
            {
                if (i != UI)
                {
                    UICanvas[i].enabled = false;
                }
            }
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Again()
    {
        SceneManager.LoadScene(0);
    }

}
