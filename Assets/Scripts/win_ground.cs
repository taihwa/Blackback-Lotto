using UnityEngine;
using System.Collections;

public class win_ground : MonoBehaviour {

	public GameObject Target;
	private main other;


	public GameObject[] Blanks;

	// Use this for initialization
	void Start () {
		Target = GameObject.Find("/Main");
		other = Target.GetComponent<main>();
	}
	
	// Update is called once per frame
	void Update () {
		transBlankState ();
	}

	void resClickItem(int itemNumber)
	{
		if (itemNumber > 0)
			itemNumber--;
		other.GroundStateItem [itemNumber] = other.GroundStateItem [itemNumber] * -1;
		transBlankState ();
	}

	void resClickBlank(int itemNumber)
	{
		if (itemNumber > 0)
			itemNumber--;
		other.GroundStateItem [itemNumber] = other.GroundStateItem [itemNumber] * -1;
		transBlankState ();
	}

	public void transBlankState()
	{
		for (int i=0; i<other.GroundStateItem.Length; i++) 
		{
			if(other.GroundStateItem[i] == -1) Blanks[i].gameObject.SetActive(false);
			else  Blanks[i].gameObject.SetActive(true);
		}
	}
}
