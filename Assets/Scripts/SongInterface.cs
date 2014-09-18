﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Stroke
{
    float position;
    Note note;
    float length;

    public float Position { get; internal set; }
    public Note Note { get; internal set; }
    public float Length { get; internal set; }
};

public class SongInterface : MonoBehaviour
{
    public static readonly float BPS = 1f; // Beats per second
    public static readonly float BEAT_SIZE = 1.4f;
    public static readonly float BEAT_MOVE = BEAT_SIZE * BPS;

    float offset;
    Content content;
    Object note_res;
    Transform sond_holder;

    List<List<Stroke>> songs = new List<List<Stroke>>
    {
        new List<Stroke>(){
            new Stroke() { Position = 0f, Note = Note.C1, Length = 4f },
            new Stroke() { Position = 0f, Note = Note.D1, Length = 1f },
            new Stroke() { Position = 0f, Note = Note.E1, Length = 1f },
            new Stroke() { Position = 0f, Note = Note.F1, Length = 1f },
            new Stroke() { Position = 0f, Note = Note.G1, Length = 1f },
            new Stroke() { Position = 0f, Note = Note.A1, Length = 1f },
            new Stroke() { Position = 0f, Note = Note.B1, Length = 1f },
            new Stroke() { Position = 0f, Note = Note.C2, Length = 1f },
            new Stroke() { Position = 1f, Note = Note.D1, Length = 1f },
            new Stroke() { Position = 2f, Note = Note.D1, Length = 1f },
            new Stroke() { Position = 3f, Note = Note.E1, Length = 1f },
            new Stroke() { Position = 4f, Note = Note.G1, Length = 1f },
            new Stroke() { Position = 5f, Note = Note.C1, Length = 1f },
            new Stroke() { Position = 6f, Note = Note.E1, Length = 1f },
            new Stroke() { Position = 7f, Note = Note.G1, Length = 1f },
        }
    };

    List<GameObject> notes;

    void CreateSong(List<Stroke> song)
    {
        notes = new List<GameObject>();
        
        foreach (Stroke stroke in song)
        {
            // Position
            float y_pos = offset + stroke.Position * BEAT_SIZE;
            Vector3 pos = new Vector3(content.getXpos(stroke.Note), y_pos, 0);
            GameObject note = (GameObject)Instantiate(note_res, pos, Quaternion.Euler(-90, 0, 0));

            // Scale
            note.transform.localScale = new Vector3(BEAT_SIZE * 0.1f, 1f, stroke.Length * BEAT_SIZE * 0.1f );
            note.transform.FindChild("front").transform.localScale = new Vector3(1f - 0.1f, 1f, 1f - (0.1f / stroke.Length));
            note.transform.FindChild("front").renderer.material.color = Values.colors[Values.getNoteIndex(stroke.Note)];

            // Data
            NoteData note_data = note.transform.Find("back").GetComponent<NoteData>();
            note_data.Note = stroke.Note;

            // Inspector
            note.transform.parent = sond_holder;
            string name = Values.field_names[Values.getNoteIndex(stroke.Note)];
            if (!Values.isFullNote(stroke.Note))
                name = name[0] + "#";
            note.name = name;

            notes.Add(note);
        }
    }

    // Use this for initialization
    void Start()
    {
        content = GameObject.Find("Content").GetComponent<Content>();
        offset = 0; // GameObject.Find("Main Camera").GetComponent<Camera>().orthographicSize;
        note_res = Resources.Load("note");
        sond_holder = GameObject.Find("song").transform;
        CreateSong(songs[0]);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject note in notes)
            note.transform.Translate(Vector3.back * BEAT_MOVE * Time.deltaTime);
    }
}
