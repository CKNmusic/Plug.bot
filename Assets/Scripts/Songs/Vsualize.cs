using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SonicBloom.Koreo;

public class Vsualize : MonoBehaviour
{
    public AudioClip[] musicas;
    public AudioSource Fone;
    int musicaAtual;
    public Text nome;

    private void Awake()
    {
        musicaAtual = Random.Range(0, musicas.Length);
        Fone.clip = musicas[musicaAtual];
        Fone.Play();
    }
    private void Update()
    {
        nome.text = musicas[musicaAtual].name;

        if (!Fone.isPlaying)
        {
            Awake();
        }
    }
}
