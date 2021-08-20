using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changescene : MonoBehaviour
{
    public Text difficulty; // this is the text that display on the game's page

    public void Start()
    {
        difficulty.text = StateName.difficulty; // assign static variable to the text 
    }

    public void goback()
    {
       SceneManager.LoadScene(1);
    }

}
