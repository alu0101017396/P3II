using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void CollisionAction();
    public static event CollisionAction OnColl;
    public static event CollisionAction CambiarColor;
    public static int keyCount;
    public static bool EnColision = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && OnColl != null) {
            OnColl();
        } 
        if (CambiarColor != null && EnColision) {
            CambiarColor();
        }

    }
}
