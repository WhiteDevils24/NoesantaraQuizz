using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] public float timer;
    Text teks;

    // Start is called before the first frame update
    void Start()
    {
        teks = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        teks.text = timer.ToString("0");

        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        }
    }
}
