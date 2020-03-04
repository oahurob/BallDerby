using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScoreP2 : MonoBehaviour
{
    public GUIStyle mystyle;
    public static int Scorep2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI() {
        GUI.Box(new Rect(1220, 100, 100, 100), Scorep2.ToString());
    }
}
