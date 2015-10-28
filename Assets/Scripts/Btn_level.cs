using UnityEngine;
using System.Collections;

public class Btn_level : MonoBehaviour {
	
	private ClickObject CO;
	private GameObject Target;
	private main Main;

	// Use this for initialization
	void Start () {
		CO = GetComponent<ClickObject>();
		Target = GameObject.Find("/Main");
		Main = Target.GetComponent<main>();
	}
	
	// Update is called once per frame
	void Update () {
		if (CO.isClick () == true) {
			Main.closeAllWindows ();
			Main.GuanLevel++;
			Main.TS.GuanLevel_text.text = "" + Main.GuanLevel;
		}
	}
}
