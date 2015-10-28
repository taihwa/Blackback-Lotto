using UnityEngine;
using System.Collections;

public class EventSend : MonoBehaviour {

	public GameObject target;
	public string methodName;

	public void OnMouseDown(){
		target.SendMessage (methodName);
	}
}
