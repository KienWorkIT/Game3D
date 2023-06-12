using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseDialog : Dialog
{
   public void UnPauseGame()
    {
        Time.timeScale = 1f;
        Show(false );
    }

    public void ExitGame()
    {
        Application.Quit();
    }
  
}
