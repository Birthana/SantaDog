using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    float percentage = 1.0f;
    float fullHealth;
    float y;
    public GameObject healthbar;

    // Start is called before the first frame update
    void Start()
    {
        healthbar = this.transform.GetChild(0).gameObject;
        fullHealth = healthbar.GetComponent<RectTransform>().anchoredPosition.x;
        y = healthbar.GetComponent<RectTransform>().anchoredPosition.y;
    }

    public void SetPercentage(float currentHealth, float maxHealth)
    {
        percentage = currentHealth / maxHealth;
        healthbar.GetComponent<RectTransform>().localScale = new Vector3(percentage, 1.0f, 1.0f);
        Vector3 scaledPosition = new Vector3(fullHealth * percentage, y, 0.0f);
        healthbar.GetComponent<RectTransform>().anchoredPosition = scaledPosition;
    }
}
