using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KumpulanSuara : MonoBehaviour
{
    public static KumpulanSuara instance;
    public AudioClip[] ClipNya;
    [SerializeField] List<AudioSource> Suara = new List<AudioSource>();
    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Suara.Clear();

        for (int i = 0; i < ClipNya.Length; i++)
        {
            Suara.Add(gameObject.AddComponent<AudioSource>());
            Suara[i].clip = ClipNya[i];
        }
    }

    public void PanggilSuara(int i)
    {
        Suara[i].Play();
    }
}
