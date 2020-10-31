using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openURL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Application.OpenURL("http://unity3d.com/");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Github()
    {
        Application.OpenURL("https://github.com/eby8zevin");
    }

    public void Download()
    {
        Application.OpenURL("https://drive.google.com/uc?export=download&id=18tHAfWpa3MGojf6d1lSGOM4-Oj9QuIvF");
    }

    public void WhatsApp()
    {
        Application.OpenURL("https://api.whatsapp.com/send?phone=6282244103410");
    }
}
