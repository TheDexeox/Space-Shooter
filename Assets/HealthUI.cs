using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public VerticalLayoutGroup healthPointsContainer;
    public Health playerHealth;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < healthPointsContainer.transform.childCount; i++)
        {
            healthPointsContainer.transform.GetChild(i).gameObject.SetActive(i < playerHealth.health);
        }
    }
}
