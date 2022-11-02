using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public static DamageManager instance;
    public TextMeshProUGUI damageText;
    public int damage;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    public void ChangeDamage(int damageValue)
    {
        damage += damageValue;
        damageText.text = damage.ToString();
    }
}
