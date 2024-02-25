using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{
    public TextMeshPro nameText;
    public Slider hpSlider;

    public void SetHUD(Unit unit)
    {
        nameText = unit.unitName;
        hpSlider.maxValue = unit.maxHealth;
        hpSlider.value = unit.health;

    }

    public void SetHP(int hp)
    {
        hpSlider.value = hp;
    }
}
