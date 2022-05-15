using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Jugar()
    {
        int currentLevel = PlayerPrefs.GetInt("currentLevel",SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(currentLevel + 1);
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
