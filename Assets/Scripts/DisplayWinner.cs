using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayWinner : MonoBehaviour
{
    [SerializeField]
    string capsule;
    public GameObject uiWinner1;
    public GameObject uiWinner2;

    // Start is called before the first frame update
    void Start()
    {
        uiWinner1.SetActive(false);
        uiWinner2.SetActive(false);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == capsule)
        {

            if(KeepScoreP1.Scorep1 == 3)
            {
                uiWinner1.SetActive(true);
            }
            
            if(KeepScoreP2.Scorep2 == 3)
            {
                uiWinner2.SetActive(true);
            }
        }
    }

}
