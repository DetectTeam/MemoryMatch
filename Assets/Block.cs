using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour 
{

	void OnMouseDown()
    {
        // load a new scene
        Debug.Log( "THis is  " + gameObject.name );
    }

}
