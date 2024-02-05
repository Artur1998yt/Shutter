using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InstantGamesBridge;
public class GameInterfase : MonoBehaviour
{
    [SerializeField] private Language lvl;
    public Text lvlNum;
    public Slider slider;
    public Data data;
    private void Start()
    {
        slider.value = data.m_Intensity;
    }
    void Update()
    {
        Muwer.rid.sensitivity = data.m_Intensity;
        data.m_Intensity = slider.value;
        if (Bridge.platform.language == "ru")
        {
            lvlNum.text = lvl.ru + data.record;
        }
        else
        {
            lvlNum.text = lvl.en + data.record;
        }
    }
}
