using System;
using UnityEngine;

public class musicPause : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        music = musicCube.GetComponent<AudioSource>();
        SFX1 = SFXCube1.GetComponent<AudioSource>();
        SFX2 = SFXCube2.GetComponent<AudioSource>();
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
        
        if (other.gameObject.CompareTag("off"))
        {
            music.Pause();
        }
        if (other.gameObject.CompareTag("SFX1"))
        {
            SFXCube1.SetActive(true);
            
        }
        if (other.gameObject.CompareTag("SFX2"))
        {
            SFXCube2.SetActive(true);
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.CompareTag("off"))
        {
            music.UnPause();
        }
        if (other.gameObject.CompareTag("SFX1"))
        {
            SFXCube1.SetActive(false);

        }
        if (other.gameObject.CompareTag("SFX2"))
        {
            SFXCube2.SetActive(false);

        }
    }
}
