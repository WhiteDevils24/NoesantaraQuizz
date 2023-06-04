using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJawaban : MonoBehaviour
{
    public bool AdalahBenar = false;
    public QuizManager quizManager;
    public Points Point;
    public static ScriptJawaban Instance;
    public AudioSource SFX;
    public AudioClip BenarSFX, SalahSFX;

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

        }
        else
        {
            Debug.Log("Jawaban Salah");
            quizManager.Benar();
            SFX.PlayOneShot(SalahSFX);
        }
    }
}
