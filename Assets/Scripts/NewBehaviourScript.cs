using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public Button yourButton; // declare a button variable

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>(); // assign the button variable to btn variable
        btn.onClick.AddListener(TaskOnClick); // onclick function to listen for function attached
    }
    public void Change(string s) // this function is attached on the runtime of inputfield object
    {
        StateName.difficulty = s;
                
    }
    public void TaskOnClick()
    {
        SceneManager.LoadScene(0);
    }
}
