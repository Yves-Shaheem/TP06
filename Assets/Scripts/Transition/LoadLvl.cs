using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLvl : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel1(){
        SceneManager.LoadScene("Scenes/TP03/TP03_scene");
    }
    public void LoadLevel2(){
        SceneManager.LoadScene("Scenes/Level2");
    }
}

