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
                new Stroke() { Position = 0f, Note = Note.C1, Length = 2f },
                new Stroke() { Position = 3f, Note = Note.E1, Length = 2f },
                new Stroke() { Position = 6f, Note = Note.G1, Length = 2f },
                new Stroke() { Position = 9f, Note = Note.B1, Length = 2f },
            },
            new List<Stroke>(){
                new Stroke() { Position = 0f, Note = Note.C1, Length = 2f },
                new Stroke() { Position = 3f, Note = Note.Ds, Length = 2f },
                new Stroke() { Position = 6f, Note = Note.G1, Length = 2f },
                new Stroke() { Position = 9f, Note = Note.As, Length = 2f },
            }
        },
        // diff 2
        new List<List<Stroke>>() {
            new List<Stroke>(){
                new Stroke() { Position = 0f, Note = Note.C1, Length = 2f },
                new Stroke() { Position = 3f, Note = Note.G1, Length = 2f },
                new Stroke() { Position = 6f, Note = Note.C1, Length = 2f },
                new Stroke() { Position = 9f, Note = Note.E1, Length = 2f },
                new Stroke() { Position = 12f, Note = Note.D1, Length = 2f },
                new Stroke() { Position = 15f, Note = Note.C1, Length = 2f },
            },
            new List<Stroke>(){
                new Stroke() { Position = 0f, Note = Note.C1, Length = 2f },
                new Stroke() { Position = 0f, Note = Note.E1, Length = 2f },
                new Stroke() { Position = 3f, Note = Note.C1, Length = 2f },
                new Stroke() { Position = 3f, Note = Note.G1, Length = 2f },
                new Stroke() { Position = 6f, Note = Note.C1, Length = 2f },
                new Stroke() { Position = 6f, Note = Note.E1, Length = 2f },
                new Stroke() { Position = 9f, Note = Note.G1, Length = 2f },
                new Stroke() { Position = 12f, Note = Note.E1, Length = 2f },
                new Stroke() { Position = 15f, Note = Note.C1, Length = 2f },
            }
        },
        // diff 3
        new List<List<Stroke>>() {
            new List<Stroke>(){
                new Stroke() { Position = 0f, Note = Note.C1, Length = 1f },
                new Stroke() { Position = 1f, Note = Note.E1, Length = 1f },
                new Stroke() { Position = 2f, Note = Note.G1, Length = 1f },
                new Stroke() { Position = 3f, Note = Note.C1, Length = 1f },
                new Stroke() { Position = 4f, Note = Note.E1, Length = 1f },
                new Stroke() { Position = 5f, Note = Note.G1, Length = 1f },
            },
            new List<Stroke>(){
                new Stroke() { Position = 0f, Note = Note.C1, Length = 2f },
                new Stroke() { Position = 0f, Note = Note.Ds, Length = 2f },
                new Stroke() { Position = 0f, Note = Note.G1, Length = 2f },
                new Stroke() { Position = 3f, Note = Note.C1, Length = 1f },
                new Stroke() { Position = 4f, Note = Note.E1, Length = 1f },
                new Stroke() { Position = 5f, Note = Note.G1, Length = 1f },
            }
        },
        // diff 4
        new List<List<Stroke>>() {
            new List<Stroke>(){
                new Stroke() { Position = 0f, Note = Note.E1, Length = 0.5f },
                new Stroke() { Position = 0.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() { Position = 1f, Note = Note.D1, Length = 0.5f },
                new Stroke() { Position = 1.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() { Position = 2f, Note = Note.F1, Length = 1f },
                new Stroke() { Position = 3f, Note = Note.D1, Length = 1f },
                new Stroke() { Position = 4f, Note = Note.E1, Length = 0.5f },
                new Stroke() { Position = 4.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() { Position = 5f, Note = Note.D1, Length = 0.5f },
                new Stroke() { Position = 5.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() { Position = 6f, Note = Note.F1, Length = 1f },
                new Stroke() { Position = 7f, Note = Note.D1, Length = 1f },
                new Stroke() { Position = 8f, Note = Note.E1, Length = 1f },
                new Stroke() { Position = 9f, Note = Note.D1, Length = 1f },
                new Stroke() { Position = 10f, Note = Note.C1, Length = 1f },
            },
            new List<Stroke>(){
                new Stroke() { Position = 0f, Note = Note.C1, Length = 0.5f },
                new Stroke() { Position = 0.5f, Note = Note.C1, Length = 0.5f },
                new Stroke() { Position = 1f, Note = Note.E1, Length = 0.5f },
                new Stroke() { Position = 1.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() { Position = 2f, Note = Note.D1, Length = 0.5f },
                new Stroke() { Position = 2.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() { Position = 3f, Note = Note.C2, Length = 0.5f },
                new Stroke() { Position = 3.5f, Note = Note.C2, Length = 0.5f },
                new Stroke() { Position = 4f, Note = Note.E1, Length = 0.5f },
                new Stroke() { Position = 4.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() { Position = 5f, Note = Note.D1, Length = 0.5f },
                new Stroke() { Position = 5.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() { Position = 6f, Note = Note.C2, Length = 0.5f },
                new Stroke() { Position = 6f, Note = Note.C1, Length = 0.5f },
                new Stroke() { Position = 6.5f, Note = Note.C2, Length = 0.5f },
                new Stroke() { Position = 6.5f, Note = Note.C1, Length = 0.5f },
                new Stroke() { Position = 6f, Note = Note.E1, Length = 0.5f },
                new Stroke() { Position = 6.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() { Position = 7f, Note = Note.D1, Length = 0.5f },
                new Stroke() { Position = 7.5f, Note = Note.E1, Length = 0.5f },
            }
        },
        // diff 5
        new List<List<Stroke>>() {
            new List<Stroke>(){
                new Stroke() {Position = 0.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 1f, Note = Note.D1, Length = 0.5f },
                new Stroke() {Position = 1.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 2f, Note = Note.C1, Length = 1f },
                new Stroke() {Position = 3.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 4f, Note = Note.D1, Length = 1f },
                new Stroke() {Position = 5.5f, Note = Note.D1, Length = 0.5f },
                new Stroke() {Position = 6f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 6.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 7f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 7.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 8f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 8.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 9f, Note = Note.E1, Length = 1f },
                new Stroke() {Position = 10f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 10.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 11f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 11.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 12f, Note = Note.A1, Length = 1f },
                new Stroke() {Position = 13f, Note = Note.A1, Length = 1f },
                new Stroke() {Position = 14f, Note = Note.G1, Length = 0.5f },
                new Stroke() {Position = 14.5f, Note = Note.A1, Length = 0.5f },
                new Stroke() {Position = 15f, Note = Note.G1, Length = 0.5f },
                new Stroke() {Position = 15.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 16f, Note = Note.E1, Length = 0.5f },
            }
        },
        // diff 6
        new List<List<Stroke>>() {
            new List<Stroke>(){
                new Stroke() {Position = 0.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 1f, Note = Note.D1, Length = 0.5f },
                new Stroke() {Position = 1.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 2f, Note = Note.C1, Length = 1f },
                new Stroke() {Position = 3.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 4f, Note = Note.D1, Length = 1f },
                new Stroke() {Position = 5.5f, Note = Note.D1, Length = 0.5f },
                new Stroke() {Position = 6f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 6.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 7f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 7.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 8f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 8.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 9f, Note = Note.E1, Length = 1f },
                new Stroke() {Position = 10f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 10.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 11f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 11.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 12f, Note = Note.A1, Length = 1f },
                new Stroke() {Position = 13f, Note = Note.A1, Length = 1f },
                new Stroke() {Position = 14f, Note = Note.G1, Length = 0.5f },
                new Stroke() {Position = 14.5f, Note = Note.A1, Length = 0.5f },
                new Stroke() {Position = 15f, Note = Note.G1, Length = 0.5f },
                new Stroke() {Position = 15.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 16f, Note = Note.E1, Length = 0.5f },
            }
        },
        // diff 7
        new List<List<Stroke>>() {
            new List<Stroke>(){
                new Stroke() {Position = 0.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 1f, Note = Note.D1, Length = 0.5f },
                new Stroke() {Position = 1.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 2f, Note = Note.C1, Length = 1f },
                new Stroke() {Position = 3.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 4f, Note = Note.D1, Length = 1f },
                new Stroke() {Position = 5.5f, Note = Note.D1, Length = 0.5f },
                new Stroke() {Position = 6f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 6.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 7f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 7.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 8f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 8.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 9f, Note = Note.E1, Length = 1f },
                new Stroke() {Position = 10f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 10.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 11f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 11.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 12f, Note = Note.A1, Length = 1f },
                new Stroke() {Position = 13f, Note = Note.A1, Length = 1f },
                new Stroke() {Position = 14f, Note = Note.G1, Length = 0.5f },
                new Stroke() {Position = 14.5f, Note = Note.A1, Length = 0.5f },
                new Stroke() {Position = 15f, Note = Note.G1, Length = 0.5f },
                new Stroke() {Position = 15.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 16f, Note = Note.E1, Length = 0.5f },
            }
        },
        // diff 8
        new List<List<Stroke>>() {
            new List<Stroke>(){
                new Stroke() {Position = 0.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 1f, Note = Note.D1, Length = 0.5f },
                new Stroke() {Position = 1.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 2f, Note = Note.C1, Length = 1f },
                new Stroke() {Position = 3.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 4f, Note = Note.D1, Length = 1f },
                new Stroke() {Position = 5.5f, Note = Note.D1, Length = 0.5f },
                new Stroke() {Position = 6f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 6.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 7f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 7.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 8f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 8.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 9f, Note = Note.E1, Length = 1f },
                new Stroke() {Position = 10f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 10.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 11f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 11.5f, Note = Note.E1, Length = 0.5f },
                new Stroke() {Position = 12f, Note = Note.A1, Length = 1f },
                new Stroke() {Position = 13f, Note = Note.A1, Length = 1f },
                new Stroke() {Position = 14f, Note = Note.G1, Length = 0.5f },
                new Stroke() {Position = 14.5f, Note = Note.A1, Length = 0.5f },
                new Stroke() {Position = 15f, Note = Note.G1, Length = 0.5f },
                new Stroke() {Position = 15.5f, Note = Note.F1, Length = 0.5f },
                new Stroke() {Position = 16f, Note = Note.E1, Length = 0.5f },
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

    // Debug only
    public static List<Stroke> getSong(int level, int index)
    {
        return songs[level][index];
    }
}
