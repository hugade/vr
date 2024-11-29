using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBOScript : MonoBehaviour
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

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == gameObject.tag) ;
        {
            uimanagerscript.UIPuntos = uimanagerscript.UIPuntos + 5;
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag != gameObject.tag)
        {
            if (uimanagerscript.UIPuntos > 0)
            {
                uimanagerscript.UIPuntos = uimanagerscript.UIPuntos - 6; 
                Destroy(collider.gameObject);

                if (uimanagerscript.UIPuntos < 0)
                {
                    uimanagerscript.UIPuntos = 0;
                }
            }
        }
    }
}
