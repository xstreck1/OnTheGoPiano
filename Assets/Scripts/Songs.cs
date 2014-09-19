using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Songs : MonoBehaviour
{
    static List<List<List<Stroke>>> songs = new List<List<List<Stroke>>>
    {
        // diff 1
        new List<List<Stroke>>() {
            new List<Stroke>(){
                new Stroke() { Position = 0f, Note = Note.C1, Length = 4f },
                new Stroke() { Position = 4f, Note = Note.E1, Length = 4f },
                new Stroke() { Position = 8f, Note = Note.G1, Length = 4f },
                new Stroke() { Position = 12f, Note = Note.B1, Length = 4f },
            },
            new List<Stroke>(){
                new Stroke() { Position = 0f, Note = Note.C1, Length = 4f },
                new Stroke() { Position = 4f, Note = Note.Ds, Length = 4f },
                new Stroke() { Position = 8f, Note = Note.G1, Length = 4f },
                new Stroke() { Position = 12f, Note = Note.As, Length = 4f },
            }
        },
        // diff 2
        new List<List<Stroke>>() {
            new List<Stroke>(){
                new Stroke() { Position = 0f, Note = Note.C1, Length = 2f },
                new Stroke() { Position = 0f, Note = Note.G1, Length = 2f },
                new Stroke() { Position = 0f, Note = Note.C1, Length = 2f },
                new Stroke() { Position = 0f, Note = Note.E1, Length = 2f },
                new Stroke() { Position = 0f, Note = Note.D1, Length = 2f },
                new Stroke() { Position = 0f, Note = Note.C1, Length = 2f },
            }
        },
        // diff 3
        new List<List<Stroke>>() {
            new List<Stroke>(){
                new Stroke() { Position = 0f, Note = Note.C1, Length = 1f },
                new Stroke() { Position = 3f, Note = Note.E1, Length = 1f },
                new Stroke() { Position = 4f, Note = Note.G1, Length = 1f },
                new Stroke() { Position = 5f, Note = Note.C1, Length = 1f },
                new Stroke() { Position = 6f, Note = Note.E1, Length = 1f },
                new Stroke() { Position = 7f, Note = Note.G1, Length = 1f },
            }
        },
        // diff 4
        new List<List<Stroke>>() {
            new List<Stroke>(){
            }
        },
        // diff 5
        new List<List<Stroke>>() {
            new List<Stroke>(){
            }
        },
        // diff 6
        new List<List<Stroke>>() {
            new List<Stroke>(){
            }
        },
        // diff 7
        new List<List<Stroke>>() {
            new List<Stroke>(){
            }
        },
        // diff 8
        new List<List<Stroke>>() {
            new List<Stroke>(){
            }
        }
    };

    public static List<Stroke> getSong(float score)
    {
        int level = (int)Mathf.Floor(score * songs.Count);
        int index = Random.Range(0, songs[level].Count);
        Debug.Log("Level " + level + " song " + index);
        return songs[level][index];
    }
}
