using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public GameObject ui;
	public float timestamp = 30f;
	public static bool pauseisactive = false;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) { //|| !(Input.anyKeyDown)){  //|| Input.GetKeyDown (KeyCode.P))
			Toggle ();
	}
		{
 
			if (Input.anyKeyDown) {
				timestamp = Time.time + 30f;
			}
			if (Time.time >= timestamp)
			{
				Debug.Log ("oh noooooo");
				//Toggle ();
				if (pauseisactive == false) {
					Toggle ();
					pauseisactive = true;
					Debug.Log ("pauseactive true");
				}
			}
		}
	}

		
	public void Toggle ()
	{

		ui.SetActive (!ui.activeSelf);

		if (ui.activeSelf)
		{
			Time.timeScale = 0f;
			//Cursor.visible = true;
			Debug.Log("pause on");

		} else
		{
			Time.timeScale = 1f;
			//Cursor.visible = false;
			Debug.Log("pause off");
		}
	}

}
