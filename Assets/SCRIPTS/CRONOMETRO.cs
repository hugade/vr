using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CRONOMETRO : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoCrono;
    [SerializeField] private float tiempo;

    private int minutos, segundos;

    public GameObject cuboorg, cubopla, cubopap, cubovid, retrymenu;

    private Animator animatororg, animatorpla, animatorpap, animatorvid;
    void Cronometro()
    {
        tiempo -= Time.deltaTime;

        minutos = Mathf.FloorToInt(tiempo / 60);
        segundos = Mathf.FloorToInt(tiempo % 60);

        textoCrono.text = string.Format("{0:00}:{1:00}", minutos, segundos);

        
    }

    void Start()
    {
        animatororg = cuboorg.GetComponent<Animator>();

        animatorpla = cubopla.GetComponent<Animator>();

        animatorpap = cubopap.GetComponent<Animator>();

        animatorvid = cubovid.GetComponent<Animator>();

        retrymenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo > 1)
        {
            Cronometro();
        }

        if (tiempo <= 0)
        {
            tiempo = 1;

            Time.timeScale = 0f;

            retrymenu.SetActive(true);
        }

        if (tiempo <= 120 && tiempo > 60)
        {
            animatororg.Play("Fase2Org");
            animatorpla.Play("Fase2Pla");
            animatorpap.Play("Fase2Pap");
            animatorvid.Play("Fase2Vid");
        }

        if (tiempo <= 60)
        {
            animatororg.Play("Fase3Org");
            animatorpla.Play("Fase3Pla");
            animatorpap.Play("Fase3Pap");
            animatorvid.Play("Fase3Vid");
        }
    }
}
