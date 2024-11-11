using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManagerP2 : MonoBehaviour
{
    public int lap;
    public TextMeshProUGUI lapText;
    public TextMeshProUGUI winnerText;
    public GameObject course1;
    public GameObject course2;
    public GameObject select;

    // Start is called before the first frame update
    void Start()
    {
        lap = 0;
        UpdateLap(0);
    }

    public void UpdateLap(int lapToAdd)
    {
        lap += lapToAdd;
        lapText.text = $"{lap}/3";
    }

    // Update is called once per frame
    void Update()
    {
        if (lap == 4)
        {
            winnerText.gameObject.SetActive(true);
            course1.gameObject.SetActive(true);
            course2.gameObject.SetActive(true);
            select.gameObject.SetActive(true);
        }
    }
}
