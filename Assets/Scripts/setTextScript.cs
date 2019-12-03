using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class setTextScript : MonoBehaviour
{

    public TextMeshProUGUI speedText2;
    public Slider speedSlider;

    void Start()
    {
        speedText2 = GetComponent<TextMeshProUGUI>();
    }

    public void SetSliderValue()
    {
        //speedText2.text = Mathf.Round(sliderValue * 100).ToString();
        speedText2.text = speedSlider.value.ToString();
    }
}