using System;
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
    int currentIndex;
    private void Start() {
         currentIndex = SceneManager.GetActiveScene().buildIndex;
         Time.timeScale = 1;
    }
    void Update()
    {
        if(isLevelCompleted() && !_completed){
            AudioManager.Play(AudioEffects.levelCompleted);
            canvasController.Activate(levelNumber);
            _completed = true;
            PlayerPrefs.SetInt("currentLevel", SceneManager.GetActiveScene().buildIndex);
        }
        if(_completed && Input.anyKeyDown){
            SceneManager.LoadScene(currentIndex + 1);
        }
        //reset 
        if(Input.GetKeyDown(KeyCode.F)){
            ReloadScene();
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene(currentIndex);
    }
  internal void GameOver()
  {
      AudioManager.Play(AudioEffects.gameOver);
      Invoke("ReloadScene",1);
      
    //   Time.timeScale = 0;
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
