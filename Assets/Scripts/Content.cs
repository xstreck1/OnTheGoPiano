using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class Content : MonoBehaviour
{

    List<GameObject> note_backs = new List<GameObject>(8);
    List<GameObject> note_sensors = new List<GameObject>(8);
    List<GameObject> score_measure = new List<GameObject>(7);
    List<float> filed_X_pos = new List<float>(8);
    
    public float getXpos(Note note)
    {
        return filed_X_pos[Values.getNoteIndex(note)];
    }

    void Awake()
    {
        var note_back = Resources.Load("field");
        var note_eraser = Resources.Load("sensor");
        var score_res = Resources.Load("score");
        GameObject temp = (GameObject)Instantiate(note_back, Vector3.zero, Quaternion.Euler(-90, 0, 0));
        float width = temp.transform.localScale.x * 10f;
        Destroy(temp);
        foreach (int i in Enumerable.Range(0, 8))
        {
            filed_X_pos.Add(width * (-3.5f + i));
            Vector3 back_pos = new Vector3(filed_X_pos[i], 0, 0);
            note_backs.Add((GameObject)Instantiate(note_back, back_pos, Quaternion.Euler(-90, 0, 0)));
            note_backs[i].transform.parent = this.transform;
            note_backs[i].renderer.material.color = Values.colors[i] * 0.25f;
            note_backs[i].name = Values.field_names[i] + "_field";


            Vector3 front_pos = new Vector3(filed_X_pos[i], - 4.0f, -1f);
            note_sensors.Add((GameObject)Instantiate(note_eraser, front_pos, Quaternion.identity));
            note_sensors[i].transform.parent = this.transform;
            note_sensors[i].transform.localScale = new Vector3(2f, 2f - i / 8f, 1f);
            note_sensors[i].renderer.material.color = Values.colors[i] * 0.1f + Color.white * 0.9f;
            note_sensors[i].name = Values.field_names[i] + "_sensor";
            note_sensors[i].GetComponent<Sensor>().setIndex(i);
        }
        foreach (int i in Enumerable.Range(0, 7))
        {
            filed_X_pos.Add(width * (-3.5f + i));
            Vector3 score_pos = new Vector3((filed_X_pos[i] + filed_X_pos[i + 1]) / 2f, 0, 0);
            score_measure.Add((GameObject)Instantiate(score_res, score_pos, Quaternion.identity));
            score_measure[i].transform.parent = this.transform;
            score_measure[i].name = "score_" + i;
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
    }
}
