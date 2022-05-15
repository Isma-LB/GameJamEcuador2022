using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField,Min(0)] int levelNumber = 0;
    [SerializeField] BrokenPipe[] brokenPipes = null;
    [SerializeField] EndCanvasController canvasController = null;
    bool _completed = false;
    void Update()
    {
        if(isLevelCompleted()){
            canvasController.Activate(levelNumber);
            _completed = true;
            PlayerPrefs.SetInt("currentLevel", SceneManager.GetActiveScene().buildIndex);
        }
        if(_completed && Input.anyKeyDown){
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentIndex + 1);
        }
    }
    bool isLevelCompleted(){
        for (int i = 0; i < brokenPipes.Length; i++)
        {
            if(!brokenPipes[i].isFixed){
                return false;
            }
        }
        return true;
    }
}
