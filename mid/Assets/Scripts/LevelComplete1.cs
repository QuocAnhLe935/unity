using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete1 : MonoBehaviour
{
    public bool isPlayLevel2;
    public bool isQuit;

	void OnMouseUp()
	{
		if (isPlayLevel2)
		{
			Application.LoadLevel(4);
		}
		if (isQuit)
		{
			Application.Quit();
		}
	}
}
