using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGame : MonoBehaviour {

    public static ManagerGame instance;
    public AudioSource MusikBacksound;

    private void Awake()
    {

        
        if (!instance)
            instance = this;
        //otherwise, if we do, kill this thing
        else
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start () {
        MusikBacksound.Play();
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
