using UnityEngine;
using System.Collections;

public class Btn_ground : MonoBehaviour {

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
			if (Main.win_tog == false) {
				Main.win_tog =true;
				Main.win_ground.gameObject.SetActive (Main.win_tog);
			} else {
				Main.win_tog = false;
			}
		}
	}
}
