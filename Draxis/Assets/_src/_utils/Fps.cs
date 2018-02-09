
//*********************************************************
//
// $author  : Ismail Ozsaygi
// $purpose : Displays the current fps so we can see the performance.
// $attach  : Attach it to FPS UI text object.Under user interface.
//
//*********************************************************

using UnityEngine;
using UnityEngine.UI;

public class Fps : MonoBehaviour 
{
    [ SerializeField ]
    public static bool   IsEnabled = false;

    private Text  FpsTexT;

    // FPS definitions.
    private float        FrameCount  = 0.0f;
    private float        DiffRate    = 0.0f;
    private float        CurrentFps  = 0.0f;
    private float        UpdateRate  = 4.0f;

    private void Start()
    {
        FpsTexT    = GetComponent< Text >();
    }

    private void Update()
    {
        CalculateFps();
    }

    private void CalculateFps()
    {
        if( IsEnabled )
        {
            FrameCount++;
            DiffRate        += Time.deltaTime;
            if( DiffRate > 1.0f / UpdateRate )
            {
                CurrentFps   = FrameCount / DiffRate;
                FrameCount   = 0;
                FpsTexT.text = "FPS : " + CurrentFps.ToString();
                DiffRate    -= 1.0f / UpdateRate;
            }
        }
        else
        {
            FpsTexT.text     = "";
        }
    }
}
