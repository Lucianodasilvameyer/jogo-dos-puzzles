using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sino : MonoBehaviour
{
    public TextMeshProUGUI textoCountdown;

    [SerializeField]
    private float TempoDeBatidaInicial;

    [SerializeField]
    private float TempoDebatidaMax;

    [SerializeField]
    bool isTimerOn = false;



    // Start is called before the first frame update

    [SerializeField]
    private float _tempoParaBatida;

    public float TempoParaBatida
    {
        get
        {
            return _tempoParaBatida;
        }
        set
        {
            if (value <= 0)
            {
                _tempoParaBatida = 0;
            }

            _tempoParaBatida = value;
            textoCountdown.text = TempoParaBatida.ToString();//aqui tem q converter o TempoParaBatida para string pq o .text é do tipo string


        }
    }
    void Start()
    {
        TempoParaBatida = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= TempoDeBatidaInicial + TempoDebatidaMax && isTimerOn)
        {

            isTimerOn = false;
            textoCountdown.enabled = false;
        }

        if (isTimerOn)
        {
            TempoParaBatida = Mathf.Abs((TempoDeBatidaInicial + TempoDebatidaMax) - Time.time);

        }

    }

    public void iniciarCountdown()
    {
        TempoDeBatidaInicial = Time.time;
        isTimerOn = true;
        textoCountdown.enabled = true;
    }

    public bool IsRunning()
    {
        return isTimerOn;
    }
}
