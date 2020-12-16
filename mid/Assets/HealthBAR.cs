using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBAR : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        //1 100 health 
        fill.color=gradient.Evaluate(1f);
    }
    public void SetHealth(int health)
    {
        slider.value = health;
        //depends on what health left 
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
