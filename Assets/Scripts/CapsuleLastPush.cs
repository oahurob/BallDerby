using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleLastPush : MonoBehaviour
{
    [SerializeField]
    string p1;

    [SerializeField]
    string p2;

    [SerializeField]
    public static GameObject uiCapsule;

    public static bool p1Push;
    public static bool p2Push;

   private void OnCollisionEnter(Collision collision) 
   {
       if(collision.gameObject.tag == p1)
       {
           p2Push = false;
           p1Push = true;
       }
       if(collision.gameObject.tag == p2)
       {
           p1Push = false;
           p2Push = true;
       }
   }
}
