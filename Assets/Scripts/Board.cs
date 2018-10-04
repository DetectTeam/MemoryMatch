using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour 
{
	[SerializeField] private Transform m_emptySprite;
	[SerializeField] private int m_height;
	[SerializeField] private int m_width;

	[SerializeField] private int m_header;
 
	// Use this for initialization
	private void Start () 
	{
		DrawEmptyCells();
	}
	
	// Update is called once per frame
	private void Update () {
		
	}

	private void DrawEmptyCells()
	{
		for( int y = 0; y < m_height - m_header; y ++ )
		{
			for( int x = 0; x < m_width; x ++ )
			{
				Transform clone;
				clone = Instantiate( m_emptySprite, new Vector3( x, y, 0 ), Quaternion.identity ) as Transform;
				clone.name = "Board Space ( x = " + x.ToString() + ", y =" + y.ToString() + " )";
				clone.transform.parent = transform;
			}
		}
	}
}
