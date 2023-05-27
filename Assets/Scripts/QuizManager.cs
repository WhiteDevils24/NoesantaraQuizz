using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<PertanyaanDanJawaban> TanyaDanJawab;
    public GameObject[] options;
    public int PertanyaanSaatIni;
    

    public Text PertanyaanTxt;

    public void Start()
    {
        BuatPertanyaan();
    }

    public void Benar()
    {
        TanyaDanJawab.RemoveAt(PertanyaanSaatIni);
        BuatPertanyaan();
    }

    void SetPertanyaan()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<ScriptJawaban>().AdalahBenar = false;
            
            options[i].transform.GetChild(0).GetComponent<Text>().text = TanyaDanJawab[PertanyaanSaatIni].Jawaban[i];

            if (TanyaDanJawab[PertanyaanSaatIni].PertanyaanBenar == i + 1)
            {
                options[i].GetComponent<ScriptJawaban>().AdalahBenar = true;
                
            }

        }
    }

    void BuatPertanyaan()
    {
        PertanyaanSaatIni = Random.Range(0, TanyaDanJawab.Count);

        PertanyaanTxt.text = TanyaDanJawab[PertanyaanSaatIni].Pertanyaan;
        SetPertanyaan();

        
    }
}
