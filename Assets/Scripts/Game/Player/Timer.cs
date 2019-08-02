using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    private float startTime;
    //// Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;   // If doesnt work try TIme.deltaTIme
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

      string minutes = ((int) t / 60). ToString();
        string seconds = (t % 60). ToString("f0");
        timerText.text = minutes + ":" + seconds;
        

    }
}
