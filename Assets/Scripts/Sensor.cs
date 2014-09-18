using UnityEngine;
using System.Collections;

public class Sensor : MonoBehaviour {
    int index; // What is my id
    Syntetizer synthetizer;
    bool playing = false;
    Note playing_note;

	// Use this for initialization
	void Start () {
        synthetizer = GameObject.Find("Synthetizer").GetComponent<Syntetizer>();
    }

    public void setIndex(int _index)
    {
        index = _index;
    }
	
	// Update is called once per frame
	void Update () {
        KeyCode my_key = Values.keys[index];
        RaycastHit hit_info;
        if (Physics.Raycast(transform.position, Vector3.forward, out hit_info, Mathf.Infinity, 1 << 8))
        {
            NoteData note_data = hit_info.collider.GetComponent<NoteData>();
            if (Input.GetKeyDown(my_key))
            {
                Debug.Log("Playing note " + (int) note_data.Note);
                synthetizer.playNote(note_data.Note);
                playing_note = note_data.Note;
                playing = true;
            }
            if (Input.GetKeyUp(my_key))
            {
                synthetizer.stopNote(playing_note);
                playing = false;
            }
        }
        else if (playing == true)
        {
            synthetizer.stopNote(playing_note);
            playing = false;
        }
    }
}
