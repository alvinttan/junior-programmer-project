using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class newscene : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>(); 
        btn.onClick.AddListener(TaskOnClick); 
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene(1);
    }
}
