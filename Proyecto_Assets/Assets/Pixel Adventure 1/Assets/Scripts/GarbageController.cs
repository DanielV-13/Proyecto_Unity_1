using UnityEngine;
using System.Collections.Generic;
using UnityEngine;

public class GarbageController : MonoBehaviour
{
   void onTriggerEnter2D(Collider2D collision)
    {
      Destroy (collision.gameObject);
    }

}
