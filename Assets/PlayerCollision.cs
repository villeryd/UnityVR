
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo) {
   
        if (collisionInfo.collider.tag == "Pin")
         {
            Debug.Log("We hit it");
        }
    }
}
