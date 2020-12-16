using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete2 : MonoBehaviour
{
	public bool isRetryLevel1;
    public bool isRetryLevel2;
    public bool isQuit;

	void OnMouseUp()
	{
		if (isRetryLevel1)
		{
			Application.LoadLevel(1);
		}
		if (isRetryLevel2)
		{
			Application.LoadLevel(4);
		}
		if (isQuit)
		{
			Application.Quit();
		}
	}
}
