using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	public static Controls controls;

	public string up = "up";
	public string down = "down";
	public string left = "left";
	public string right = "right";
	public string use = "E";

	void Start()
	{
		if(!controls)
		{
			controls = this;
			DontDestroyOnLoad(controls);
			Debug.Log(KeyCode.E);
		}
	}

	public static bool changeControl(string control, string key)
	{
		switch(control)
		{
			case "up":
			{
				Controls.controls.up = key;
				break;
			}
			case "down":
			{
				Controls.controls.down = key;
				break;
			}
			case "left":
			{
				Controls.controls.left = key;
				break;
			}
			case "right":
			{
				Controls.controls.right = key;
				break;
			}
			case "use":
			{
				Controls.controls.use = key;
				break;
			}
			default:
			{
				return false;
			}
		}
		return true;
	}

	public static string getKey(string control)
	{
		switch(control)
		{
			case "up":
			{
				return Controls.controls.up;
			}
			case "down":
			{
				return Controls.controls.down;
			}
			case "left":
			{
				return Controls.controls.left;
			}
			case "right":
			{
				return Controls.controls.right;
			}
			case "use":
			{
				return Controls.controls.use;
			}
			default:
			{
				return null;
			}
		}
	}
}
