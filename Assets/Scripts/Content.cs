using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class Content : MonoBehaviour
{
    readonly List<string> field_names = new List<string> { "C1", "D1", "E1", "F1", "G1", "A1", "B1", "C2" };

    List<GameObject> note_backs = new List<GameObject>(8);
    List<GameObject> note_erasers = new List<GameObject>(8);
    List<float> filed_X_pos = new List<float>(8);
    
    public float getXpos(Note note)
    {
        return filed_X_pos[Values.getNoteIndex(note)];
    }

    void Awake()
    {
        var note_back = Resources.Load("note_field");
        GameObject temp = (GameObject)Instantiate(note_back, Vector3.zero, Quaternion.Euler(-90, 0, 0));
        float width = temp.transform.localScale.x * 10f;
        Destroy(temp);
        var note_eraser = Resources.Load("eraser");
        foreach (int i in Enumerable.Range(0, 8))
        {
            filed_X_pos.Add(width * (-3.5f + i));
            Vector3 back_pos = new Vector3(filed_X_pos[i], 0, 0);
            note_backs.Add((GameObject)Instantiate(note_back, back_pos, Quaternion.Euler(-90, 0, 0)));
            note_backs[i].transform.parent = this.transform;
            note_backs[i].renderer.material.color = Values.colors[i] * 0.75f;
            note_backs[i].name = field_names[i] + "_field";


            Vector3 front_pos = new Vector3(filed_X_pos[i], - 4.0f, -1f);
            note_erasers.Add((GameObject)Instantiate(note_eraser, front_pos, Quaternion.Euler(-90, 0, 0)));
            note_erasers[i].transform.parent = this.transform;
            note_erasers[i].renderer.material.color = Values.colors[i];
            note_erasers[i].SetActive(false);
            note_erasers[i].name = field_names[i] + "_eraser";
        }
    }

    void CreateSong()
    {
        
    }

    void Destroy()
    {
        foreach (Transform child in transform)
        {
            Destroy(child);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (int i in Enumerable.Range(0, 8))
            note_erasers[i].SetActive(Input.GetKey(Values.keys[i]));
    }
}
