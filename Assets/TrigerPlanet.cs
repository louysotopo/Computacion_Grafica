using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerPlanet : MonoBehaviour
{
    public GameObject m_Panel_win;
    
    void OnTriggerEnter(Collider collider)

    {
        if (collider.gameObject.tag == "Meteoro")
        {
            print("o no disaster");
            m_Panel_win.gameObject.SetActive(true);
        }
        else
        {
            print("o no disaster no");
            
        }
        print("o no disaster csmr ");
    }
}
