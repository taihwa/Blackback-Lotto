using UnityEngine;
using System.Collections;

public class ClickObject : MonoBehaviour {
	
	public bool isClick()
	{
		if (Input.GetMouseButtonUp (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast (ray,out hit))
			{
				if(transform.gameObject.name == hit.transform.gameObject.name)
				{
					//Debug.Log (transform.gameObject.name+" : "+hit.transform.gameObject.name);
					return true;
				}
			}
		}
		return false;
	}
}
