using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnFloorCollison : MonoBehaviour
{
    [SerializeField]
    KeyCode reset;

    [SerializeField]
    string p1;

    [SerializeField]
    string p2;

    public GameObject uiObject;

    public GameObject uiObject2;

    //score for each player
    int p1score;
    int p2score;

    private void Start() 
    {
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == p1 && uiObject != null)
        {
            uiObject.SetActive(true);
            Destroy(uiObject2);
            KeepScoreP1.Scorep1++;
            StartCoroutine("WaitForSec");
        }
        if(collision.gameObject.tag == p2 && uiObject2 != null)
        {
            uiObject2.SetActive(true);
            Destroy(uiObject);
            KeepScoreP2.Scorep2++;
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        if(gameObject == uiObject){
            Destroy(uiObject);
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else{
            Destroy(uiObject2);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
