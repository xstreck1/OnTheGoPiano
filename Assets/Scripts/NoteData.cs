using UnityEngine;
using System.Collections;

public class NoteData : MonoBehaviour {
    Note note;
    bool stroked = false;
    bool released = false;

    public Note Note { get; internal set; }
    public Note Stroked { get; internal set; }
    public Note Released { get; internal set; }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
