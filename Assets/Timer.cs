using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerTT;
    // eapsedT is elapsedtime
    [SerializeField] float remainT;
    // Update is called once per frame
    void Update()
    {
        if(remainT>0)
        {

 remainT -= Time.deltaTime;
        }
        else if(remainT<0)
        {
            remainT = 0;
            UnityEngine.SceneManagement.SceneManager.LoadScene("YouWon");

        }
           
        int mins = Mathf.FloorToInt(remainT / 60);
        int secs = Mathf.FloorToInt(remainT % 60);
        timerTT.text = string.Format("{0:00}:{1:00}", mins, secs);
    }
}
