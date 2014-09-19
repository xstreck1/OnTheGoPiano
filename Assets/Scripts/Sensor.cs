using UnityEngine;
using System.Collections;

public class Sensor : MonoBehaviour {
    int index; // What is my id
    Syntetizer synthetizer;
    SongInterface song_interface;
    bool playing = false;
    NoteData playing_note;
    Animator anim;

	// Use this for initialization
	void Start () {
        synthetizer = GameObject.Find("Synthetizer").GetComponent<Syntetizer>();
        song_interface = GameObject.Find("Content").GetComponent<SongInterface>();
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D coll) {
        Destroy(coll.gameObject);
        song_interface.vibeHit();
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
            if (Input.GetKey(my_key) && !playing)
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
        else 
        {
            if (Input.GetKey(my_key))
                song_interface.voidKept(Time.deltaTime);
            if (playing == true)
                stopPlaying();
        }

        collider2D.enabled = Input.GetKey(my_key);
        anim.SetBool("is_pressed", Input.GetKey(my_key));
    }

    void stopPlaying()
    {
        synthetizer.stopNote(playing_note.Note);
        playing_note = null;
        playing = false;
    }
}
