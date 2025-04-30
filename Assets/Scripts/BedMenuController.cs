using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BedMenuController : MonoBehaviour
{
    public TMP_Text timeText;
    private PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = playerStats.timeLeft.ToString();
    }

    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement>().enabled = true;
    }

    public void TrainButton()
    {
        // Increase player speed
        playerStats.timeLeft = 16;

        // Update the strength text
        timeText.text = playerStats.timeLeft.ToString();
    }
}
