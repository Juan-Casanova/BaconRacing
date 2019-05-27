using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlVideo : MonoBehaviour
{
    RawImage video;
    private AudioSource au;

    void Start()
    {
        au = this.GetComponent<AudioSource>();
        video = this.GetComponent<RawImage>();

        (video.texture as MovieTexture).Play();
        au.Play();

        Invoke("EscenaQueSigue", 105);
    }

   
    public void EscenaQueSigue()
    {
        
        SceneManager.LoadScene("Login");
    }
}
