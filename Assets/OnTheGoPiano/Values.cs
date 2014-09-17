using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum Note
{
    C, Cs, D, Ds, E, F, Fs, G, Gs, A, As, B
};


public class Values : MonoBehaviour
{
    public static readonly List<Color> colors = new List<Color> {
            new Color(1f, 0f, 1f, 1f),
            new Color(0.5f, 0.1f, 0.9f, 1f),
            new Color(0.0f, 0.0f, 1f, 1f),
            new Color(0f, 1f, 1f, 1f),
            new Color(0f, 0.5f, 0f, 1f),
            new Color(1f, 1f, 0f, 1f),
            new Color(1f, 0.5f, 0f, 1f),
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

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
