using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum Note
{
    C1, Cs, D1, Ds, E1, F1, Fs, G1, Gs, A1, As, B1, C2
};


public class Values : MonoBehaviour
{
    public static readonly List<Color> colors = new List<Color> {
            new Color(1f, 0f, 1f, 1f),
            new Color(0.4f, 0.1f, 0.8f, 1f),
            new Color(0.2f, 0.2f, 1f, 1f),
            new Color(0f, 1f, 1f, 1f),
            new Color(0f, 0.5f, 0f, 1f),
            new Color(1f, 1f, 0f, 1f),
            new Color(0.9f, 0.5f, 0.1f, 1f),
            new Color(1f, 0f, 0f, 1f)
        };

    public static readonly List<KeyCode> keys = new List<KeyCode> {
        KeyCode.A,
        KeyCode.S,
        KeyCode.D,
        KeyCode.F,
        KeyCode.G,
        KeyCode.H,
        KeyCode.J,
        KeyCode.K
    };

    public static int getNoteIndex(Note note)
    {
        switch (note)
        {
            case Note.C1:
            case Note.Cs:
                return 0;
            case Note.D1:
            case Note.Ds:
                return 1;
            case Note.E1:
                return 2;
            case Note.F1:
            case Note.Fs:
                return 3;
            case Note.G1:
            case Note.Gs:
                return 4;
            case Note.A1:
            case Note.As:
                return 5;
            case Note.B1:
                return 6;
            case Note.C2:
                return 7;
            default:
                return -1;
        }
    }

    public static bool isFullNote(Note note) {
        switch (note)
        {
            case Note.C1:
            case Note.D1:
            case Note.E1:
            case Note.F1:
            case Note.G1:
            case Note.A1:
            case Note.B1:
            case Note.C2:
                return true;
            default:
                return false;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
