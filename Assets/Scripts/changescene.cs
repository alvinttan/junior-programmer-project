using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changescene : MonoBehaviour
{
    public Text difficulty;

    public void Start()
    {
        //difficulty.text = StateName.outtext;
        difficulty.text = StateName.difficulty;
    }

    public void goback()
    {
       SceneManager.LoadScene("0");
    }

}
