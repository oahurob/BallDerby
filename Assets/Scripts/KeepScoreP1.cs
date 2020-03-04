using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScoreP1 : MonoBehaviour
{

    public GUIStyle mystyle;

    public static int Scorep1 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI() {
        GUI.Box(new Rect(100, 100, 100, 100), Scorep1.ToString());
    }
}
