using UnityEngine;
using System.Collections;

public class Sensor : MonoBehaviour {
    int index; // What is my id
    Syntetizer synthetizer;
    bool playing = false;
    NoteData playing_note;

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
            if (Input.GetKeyDown(my_key) && !note_data.Stroked)
            {
                synthetizer.playNote(note_data.Note);
                note_data.Stroked = true;
                playing_note = note_data;
                playing = true;
            }
            if (playing && Input.GetKeyUp(my_key))
            {
                stopPlaying();
            }
            // Note has ended and new one followed just after
            if (playing && !note_data.Stroked)
            {
                stopPlaying();
            }

        }
        else if (playing == true)
        {
            stopPlaying();
        }
    }

    void stopPlaying()
    {
        synthetizer.stopNote(playing_note.Note);
        playing_note = null;
        playing = false;
    }
}
