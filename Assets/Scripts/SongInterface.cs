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
    public static readonly float BPS = 1f; // Beats per second
    public static readonly float BEAT_SIZE = 1.4f;
    public static readonly float BEAT_MOVE = BEAT_SIZE * BPS;
    public static readonly float VIBE_PER_BEAT = 16f;

    // Testing only
    public int init_level = 0; 
    public int init_song = 0;

    float offset;
    Content content;
    Object note_res;
    Object vibe_res;
    Transform sond_holder;

    float remaining_time = 0.00001f;

    readonly static float HIT_INCREASE = 1f / (VIBE_PER_BEAT * 8 * 8);
    readonly static float MISS_DECREASE = -HIT_INCREASE;
    readonly static float VOID_DESCREASE = -BPS / (VIBE_PER_BEAT * 8 * 8);
    public float score = 0f;


    List<GameObject> notes = new List<GameObject>();

    public void vibeHit() {
        score += HIT_INCREASE;
        score = Mathf.Clamp01(score);
    }

    public void vibeMiss() {
        score += MISS_DECREASE;
        score = Mathf.Clamp01(score);
    }

    public void voidKept(float delta_time)
    {
        score += delta_time * VOID_DESCREASE;
        score = Mathf.Clamp01(score);
    }

    void Start()
    {
        content = GameObject.Find("Content").GetComponent<Content>();
#if UNITY_EDITOR
        offset = 0;
#else
        offset = GameObject.Find("Main Camera").GetComponent<Camera>().orthographicSize;
#endif
        note_res = Resources.Load("note");
        vibe_res = Resources.Load("vibe");
        sond_holder = GameObject.Find("song").transform;
        CreateSong(Songs.getSong(init_level, init_song));
    }

    void Update()
    {
        foreach (GameObject note in notes)
            note.transform.Translate(Vector3.back * BEAT_MOVE * Time.deltaTime);
        remaining_time -= Time.deltaTime;
        if (remaining_time < 0f)
            CreateSong(Songs.getSong(score));
    }

    void CreateSong(List<Stroke> song)
    {
        // Delete old data
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
            Vector3 note_pos = new Vector3(content.getXpos(stroke.Note), y_pos, 0);
            GameObject note = (GameObject)Instantiate(note_res, note_pos, Quaternion.Euler(-90, 0, 0));

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

            // Add vibes
            y_pos += BEAT_SIZE * 0.1f;
            for (int i = 0; i < (VIBE_PER_BEAT * stroke.Length) - Mathf.Ceil(VIBE_PER_BEAT * 0.1f); i++)
            {
                Vector3 vibe_pos = new Vector3(content.getXpos(stroke.Note), y_pos, -0.3f);
                GameObject vibe = (GameObject)Instantiate(vibe_res, vibe_pos, Quaternion.identity);
                vibe.transform.parent = note.transform;
                y_pos += BEAT_SIZE / VIBE_PER_BEAT;
            }

            notes.Add(note);

            // Game state
            max_length = Mathf.Max(max_length, stroke.Length + stroke.Position);
        }

        remaining_time = max_length / BPS;
    }

    // OnGUI is called for rendering and handling
    // GUI events.
    void OnGUI()
    {
        GUILayout.Box("Score: " + score);
    }
}
