using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneAuto : MonoBehaviour {
    public string NamaScenes;
	// Use this for initialization
	void Start () {
        StartCoroutine(PindahLangsung(NamaScenes));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator PindahLangsung(string NamaScene)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(NamaScene);

    }
}
