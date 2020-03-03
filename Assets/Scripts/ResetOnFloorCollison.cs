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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag ==  p1 || collision.collider.tag == p2) 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
