using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class Content : MonoBehaviour
{
    List<GameObject> note_backs = new List<GameObject>(8);
    List<GameObject> note_erasers = new List<GameObject>(8);

    void Start()
    {
        Create();
    }

    // Use this for initialization
    void Create()
    {
        var note_back = Resources.Load("note_field");
        GameObject temp = (GameObject)Instantiate(note_back, Vector3.zero, Quaternion.Euler(-90, 0, 0));
        float width = temp.transform.localScale.x * 10f;
        Destroy(temp);
        var note_eraser = Resources.Load("eraser");
        foreach (int i in Enumerable.Range(0, 8))
        {
            Vector3 back_pos = new Vector3(width * (-3.5f + i), 0, 0);
            note_backs.Add((GameObject)Instantiate(note_back, back_pos, Quaternion.Euler(-90, 0, 0)));
            note_backs[i].transform.parent = this.transform;
            note_backs[i].renderer.material.color = Values.colors[i];


            Vector3 front_pos = new Vector3(width * (-3.5f + i), -4.0f, -1f);
            note_erasers.Add((GameObject)Instantiate(note_eraser, front_pos, Quaternion.Euler(-90, 0, 0)));
            note_erasers[i].transform.parent = this.transform;
            note_erasers[i].renderer.material.color = Values.colors[i];
            note_erasers[i].SetActive(false);
        }
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
