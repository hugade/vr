using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BASURAScript : MonoBehaviour
{
    private GameObject UIManagerObject;
    private UIManagerScript uimanagerscript;

    // Start is called before the first frame update
    void Start()
    {
        UIManagerObject = GameObject.Find("UIManager");
        uimanagerscript = UIManagerObject.GetComponent<UIManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10 && uimanagerscript.UIPuntos > 0)
        {
            uimanagerscript.UIPuntos--;
            Destroy(this.gameObject);
        }
    }
}
