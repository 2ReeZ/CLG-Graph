using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    // create a reference to the game manager.
    public static GameMgr manager;

    // awake is called before Start().

    void Awake()
    {
       if(manager != null) 
       {
           Destroy(this.gameObject);
           Debug.Log("There is another Skywalker.");
       } else
       {
           manager = this;
           Debug.Log("There can only be one!");
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
