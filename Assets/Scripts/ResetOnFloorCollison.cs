using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnFloorCollison : MonoBehaviour
{
    [SerializeField]
    string p1;

    [SerializeField]
    string p2;

    public GameObject uiObject;

    //score for each player
    int p1score;
    int p2score;

    private void Start() 
    {
        uiObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag ==  p1 || collision.collider.tag == p2) 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        if(collision.gameObject.tag == p1 || collision.gameObject.tag == p2)
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerable WaitForSec()
    {
        yield return new WaitForSeconds(10);
        Destroy(uiObject);
    }
}
