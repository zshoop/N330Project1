using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.F1)){
            LevelOne();
        }

        if(Input.GetKey(KeyCode.F2)){
            LevelTwo();
        }

        if(Input.GetKey(KeyCode.F3)){
            LevelThree();
        }
    }

    public void LevelOne()
    {
        SceneManager.LoadScene("MainScene");
    }
    
    public void LevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }

    public void LevelThree()
    {
        SceneManager.LoadScene("LevelThree");
    }
}
