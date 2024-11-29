using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour
{
    public TMP_Text puntos, finalscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int uipuntos;

    public int UIPuntos
    {
        get
        {
            return uipuntos;
        }
        set
        {
            uipuntos = value;
            puntos.text = uipuntos.ToString();
            finalscore.text = uipuntos.ToString();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
