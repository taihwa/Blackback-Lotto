using UnityEngine;
using System.Collections;

public class ClickTogItem : MonoBehaviour {
	
	private GameObject Target;
	public int ItemNumber;
	
	void Start()
	{
		Target = GameObject.Find("/Madang/win_ground");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			RaycastHit hit;
			
			if(Physics.Raycast (Camera.main.ScreenPointToRay(Input.mousePosition),out hit))
			{
				if(transform.gameObject.name == hit.transform.gameObject.name)
				{
					Target.gameObject.SendMessage("resClickItem",ItemNumber);
				}
			}
		}
	}
}
