using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearDetectorScript : MonoBehaviour
{
    public HoleScript holeRed;
    public HoleScript holeBlue;
    public HoleScript holeGreen;

    private void OnGUI()
    {
        if (holeRed.IsHolding() && holeBlue.IsHolding() && holeGreen.IsHolding())
        {
            GUI.Label(new Rect(50, 50, 100, 30), "Game Clear!");
        }
     }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
