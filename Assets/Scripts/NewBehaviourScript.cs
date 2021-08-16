using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public string test;
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    public void Change(string s)
    {
        StateName.difficulty = s;
        Debug.Log("this is the output :" + StateName.difficulty);
        
    }
    public void TaskOnClick()
    {
        SceneManager.LoadScene(0);
    }
}
