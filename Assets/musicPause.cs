using System;
using UnityEngine;

public class musicPause : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        AudioSource music = musicCube.GetComponent<AudioSource>();
        AudioSource SFX1 = SFXCube1.GetComponent<AudioSource>();
        AudioSource SFX2 = SFXCube2.GetComponent<AudioSource>();
        SFX1.Stop();
        SFX2.Stop();
        music.Play();
    }

    public GameObject musicCube;
    public GameObject SFXCube1;
    public GameObject SFXCube2;
    private AudioSource music;
    private AudioSource SFX1;
    private AudioSource SFX2;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        AudioSource music = musicCube.GetComponent<AudioSource>();
        if (other.gameObject.CompareTag("off"))
        {
            music.Pause();
        }
        if (other.gameObject.CompareTag("SFX1"))
        {
            SFX1.Play();
        }
        if (other.gameObject.CompareTag("SFX2"))
        {
            SFX2.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("off"))
        {
            music.UnPause();
        }
    }
}
