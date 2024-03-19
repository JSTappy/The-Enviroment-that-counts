using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
public class TImer : MonoBehaviour
{
    public float timer = 60;
    public TMP_Text Text;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Text.SetText(timer.ToString("F0"));
       timer -= Time.deltaTime;
       Console.WriteLine(timer);
    }
}
