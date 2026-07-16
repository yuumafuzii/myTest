using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//ずっと、カウントの値を表示する（TextMeshPro)
public class ForeverShowCountPro2 : MonoBehaviour
{

    public CounterType kind = CounterType.Keys; //[カウンターの種類]


    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = GameCounter2.counters[kind].ToString();
    }
}