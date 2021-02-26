using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image PlayerHealthBar;
    public float currenthealth = 0f;
    public float minhealth = 0f;
    public float maxhealth = 1f;
    
    public void Start()
    {
        //barin fill amount'unu unutma
        currenthealth = minhealth;
        PlayerHealthBar.fillAmount = minhealth;
    }

    void Update()
    {
        
    }

    public void Arttir()
    {
        currenthealth += 0.1f;
        PlayerHealthBar.fillAmount += 0.1f;
        if (currenthealth > 1f)
        {
            currenthealth = maxhealth;
        }
    }

    public void Azalt()
    {
        currenthealth -= 0.1f;
        PlayerHealthBar.fillAmount -= 0.1f;
        if (currenthealth < 0)
        {
            currenthealth = minhealth;
        }
    }
}
