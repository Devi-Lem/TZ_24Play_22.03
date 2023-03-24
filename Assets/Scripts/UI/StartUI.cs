using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;// stop the time
    }

    public void ButtonStart()
    {
        Time.timeScale = 1f;// resume the time
        gameObject.SetActive(false);// close the UI window
    }
}
