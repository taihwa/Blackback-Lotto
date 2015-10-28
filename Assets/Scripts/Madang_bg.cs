using UnityEngine;
using System.Collections;

public class Madang_bg : MonoBehaviour {
	private ClickObject CO;
	private GameObject Target;
	
	// Use this for initialization
	void Start () {
		CO = GetComponent<ClickObject>();
		Target = GameObject.Find("/Main");
	}
	
	// Update is called once per frame
	void Update () {
		if (CO.isClick () == true) {
			Target.SendMessage("closeAllWindows");
			Target.SendMessage("GoGo");
		}
	}
}
