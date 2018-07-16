using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class PlayVideo2 : MonoBehaviour
    
{
    public string NamaScenes;
    public MovieTexture movie;
    private AudioSource audio;

    // Use this for initialization
    void Start()
    {
        
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
        movie.Play();
        audio.Play();
        StartCoroutine(PindahLangsung(NamaScenes));
    }

    void Update()
    {
        

    }

    IEnumerator PindahLangsung(string NamaScene)
    {
        yield return new WaitForSeconds(30);
        SceneManager.LoadScene(NamaScene);

    }

}