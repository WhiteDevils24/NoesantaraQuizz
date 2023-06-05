using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text teks;
    public int NilaiScore;
    public GameObject PanelKalah;
    public GameObject PanelMenang;
    // Start is called before the first frame update
    void Start()
    {
        teks = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        teks.text = NilaiScore.ToString();
        if (NilaiScore <= 0)
        {
            PanelKalah.SetActive(true);
            Time.timeScale = 0;
        }
        if (NilaiScore >= 100)
        {
            PanelMenang.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
