using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour
{
    public GameObject panel;
    int counter;

    void Start()
    {
        panel.SetActive(false);
    }

    public void showhidePanel()
    {
        counter++;
        if (counter % 2 == 1)
        {
            panel.gameObject.SetActive(true);
        }
        else
        {
            panel.gameObject.SetActive(false);
        }
    }
}
