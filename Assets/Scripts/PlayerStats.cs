using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public TMP_Text text;
    public string playerName = "Steve";
    public int strength = 1;
    public int stamina = 1;
    public int speed = 1;
    public int charisma = 1;
    public int intelligence = 1;
    public int timeLeft = 4;

    private int trains = 0;

    // Start is called before the first frame update
    void Start()
    {
        while (strength < 100)
        {
            
            strength++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 800 == 1)
        {
            StartCoroutine(MyFunction());
        }
    }

    IEnumerator MyFunction()
    {
        Debug.Log("I like trains!");
        trains++;

        if (trains >= 3)
        {
            for (int i = 0; i < 20; i++)
            {
                yield return new WaitForSeconds(0.1f);
                Debug.Log("TRAINS");
            }

            trains = 0;
        }
    }
}
