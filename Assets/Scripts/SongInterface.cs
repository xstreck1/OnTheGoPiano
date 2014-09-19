using UnityEngine;
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
    public static readonly float BPS = 5f; // Beats per second
    public static readonly float BEAT_SIZE = 1.4f;
    public static readonly float BEAT_MOVE = BEAT_SIZE * BPS;

    float offset;
    Content content;
    Object note_res;
    Object vibe_res;
    Transform sond_holder;

    float remaining_time = 0f;

    float score = 0f;

    List<GameObject> notes = new List<GameObject>();

    void CreateSong(List<Stroke> song)
    {
        List<GameObject> notes_temp = new List<GameObject>();
        foreach (GameObject note in notes)
            if (note.activeSelf)
                notes_temp.Add(note);
            else
                Destroy(note);
        notes = notes_temp;


        float max_length = 0f;
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

            // Game state
            max_length = Mathf.Max(max_length, stroke.Length + stroke.Position);
        }

        remaining_time = max_length / BPS;
    }

    // Use this for initialization
    void Start()
    {
        content = GameObject.Find("Content").GetComponent<Content>();
        offset = GameObject.Find("Main Camera").GetComponent<Camera>().orthographicSize;
        note_res = Resources.Load("note");
        sond_holder = GameObject.Find("song").transform;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject note in notes)
            note.transform.Translate(Vector3.back * BEAT_MOVE * Time.deltaTime);
        remaining_time -= Time.deltaTime;
        if (remaining_time < 0f)
            CreateSong(Songs.getSong(score));
    }
}
