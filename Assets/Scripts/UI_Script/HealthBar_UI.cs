using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_UI : MonoBehaviour
{
    private Entity entity;
    private RectTransform myTransform;
    private Slider slider;

    //Note: sau khi update characterStats thi bo comment cac cau lenh lien quan den characterStats nhe
    //private CharacterStats myStats;               
    private void Start()
    {
        myTransform = GetComponent<RectTransform>();
        entity = GetComponentInParent<Entity>();
        slider = GetComponentInChildren<Slider>();
        ///myStats = GetComponentInParent<CharacterStats>();
        entity.onFlipped += FlipUI;
        //myStats.onHealthChanged += UpdateHealthUI;
        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        slider.maxValue = 100; // note: vi du ve mau toi da va mau hien tai, bo di sau khi co characterStats, thay the bang 2 cau lenh duoi
        slider.value = 70;
        //slider.maxValue = myStats.GetMaxHealthValue();
        //slider.value = myStats.currentHealth;

    }

    private void FlipUI()
    {
        myTransform.Rotate(0, 180, 0);
    }
    private void OnDisable()
    {
        entity.onFlipped -= FlipUI;
        //myStats.onHealthChanged -= UpdateHealthUI;
    }
}
