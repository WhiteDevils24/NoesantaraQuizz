using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptJawaban : MonoBehaviour
{
    public bool AdalahBenar = false;
    public QuizManager quizManager;
    public static ScriptJawaban Instance;
    public AudioSource SFX;
    public AudioClip BenarSFX, SalahSFX;
    public Score Score;
    

    private void Awake()
    {
        Instance = this;
    }

    public void Jawaban()
    {
        if(AdalahBenar)
        {
            Debug.Log("Jawaban Benar");
            quizManager.Benar();
            SFX.PlayOneShot(BenarSFX);
            Score.NilaiScore += 10;

        }
        else
        {
            Debug.Log("Jawaban Salah");
            quizManager.Benar();
            SFX.PlayOneShot(SalahSFX);
            Score.NilaiScore -= 5;
        }
    }
}
