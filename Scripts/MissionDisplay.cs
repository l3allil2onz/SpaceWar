using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionDisplay : MonoBehaviour
{
    private Text missionDesTxt;

    private void Start()
    {
        missionDesTxt = transform.GetComponent<Text>();
    }
    private void Update()
    {
        MissionDescriptionDisplay();
    }
    public void MissionDescriptionDisplay()
    {
        missionDesTxt.text = string.Format("- Defeat enemies {0}/{1}", GameManager.instance.enemiesDefeated, GameManager.instance.enemiesToDefeat);
    }
}
