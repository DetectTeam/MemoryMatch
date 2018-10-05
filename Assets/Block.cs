using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour 
{

	public Text textBox;
	void OnMouseDown()
    {
        // load a new scene
        Debug.Log( "THis is  " + gameObject.name );
		textBox.text = gameObject.name;
    }

}
