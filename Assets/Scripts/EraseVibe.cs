using UnityEngine;
using System.Collections;

public class EraseVibe : MonoBehaviour {
    SongInterface song_interface;

    // Use this for initialization
    void Start()
    {
        song_interface = GameObject.Find("Content").GetComponent<SongInterface>();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(coll.gameObject);
        song_interface.vibeMiss();
    }
}
