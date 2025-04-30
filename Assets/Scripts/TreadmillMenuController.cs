using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TreadmillMenuController : MonoBehaviour
{
    public TMP_Text staminaText;
    private PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        staminaText.text = playerStats.stamina.ToString();
    }

    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement>().enabled = true;
    }

    public void TrainButton()
    {
        if (playerStats.timeLeft <= 0)
        {
            return;
        }

        // Increase player stamina
        playerStats.stamina += 10;

        // Decrease time by 1 hour
        playerStats.timeLeft--;

        // Update the strength text
        staminaText.text = playerStats.stamina.ToString();
    }
}
