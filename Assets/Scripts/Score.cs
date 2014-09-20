using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
    SongInterface song_interface;
    Transform fill;

    // Use this for initialization
    void Start () {
        song_interface = GameObject.Find("Content").GetComponent<SongInterface>();
        fill = transform.FindChild("fill").transform;
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Score is " + song_interface.score);
        fill.localScale = new Vector3(1f, song_interface.score, 1f);
    }
}
