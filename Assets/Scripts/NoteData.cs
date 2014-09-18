using UnityEngine;
using System.Collections;

public class NoteData : MonoBehaviour {
    Note note;
    bool stroked = false;

    public Note Note { get; internal set; }
    public bool Stroked { get; internal set; }
    public bool Released { get; internal set; }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
