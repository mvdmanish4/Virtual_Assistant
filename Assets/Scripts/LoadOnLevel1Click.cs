using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadOnLevel1Click : MonoBehaviour {
	

	public void MENU_ACTION_GoToPage(string sceneName)
	{	Application.LoadLevel (sceneName);
	}


}
