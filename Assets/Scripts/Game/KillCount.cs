using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillCount : MonoBehaviour
{
    public static int killCount;

    public TextMeshProUGUI text;

    public void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();

        killCount = 0;
    }
    public void Update()
    {
        text.text = "KillCount:" + killCount;
    }
}
