using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class setTextScript : MonoBehaviour
{

    TextMeshPro speedText2;
    public Slider speedSlider;

    void Start()
    {
        speedText2 = GetComponent<TextMeshPro>();
    }

    public void SetSliderValue()
    {
        //speedText2.text = Mathf.Round(sliderValue * 100).ToString();
        speedText2.text = speedSlider.value.ToString();
    }
}