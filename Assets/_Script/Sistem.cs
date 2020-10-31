using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sistem : MonoBehaviour
{
    public static Sistem instance;
    public int id;
    public GameObject tempatspawn;
    public GameObject Gui_Utama;
    public GameObject[] koleksibuah;
    public AudioClip[] suarabuah;
    AudioSource suara;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        id = 0;
        //SpawnObject();
        Gui_Utama.SetActive(false);
        suara = gameObject.AddComponent<AudioSource>();
    }

    public void SpawnObject()
    {
        GameObject bendasebelumnya = GameObject.FindGameObjectWithTag("Buah");
        if (bendasebelumnya != null) Destroy(bendasebelumnya);

        GameObject benda = Instantiate(koleksibuah[id]);
        benda.transform.SetParent(tempatspawn.transform, false);
        benda.transform.localScale = new Vector3(37, 37, 37);

        tempatspawn.GetComponent<Animation>().Play("PopUp");
        KumpulanSuara.instance.PanggilSuara(1);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GantiBuah(true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GantiBuah(false);
        }
    }

    public void GantiBuah(bool kanan)
    {
        if (kanan)
        {
            if (id >= koleksibuah.Length - 1)
            {
                id = 0;
            }
            else
            {
                id++;
            }
        }
        else
        {
            if (id <= 0)
            {
                id = koleksibuah.Length - 1;
            }
            else
            {
                id--;
            }
        }

        SpawnObject();
    }

    public void PanggilSuaraBuah()
    {
        suara.clip = suarabuah[id];
        suara.Play();
    }
}
