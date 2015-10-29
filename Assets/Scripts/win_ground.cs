using UnityEngine;
using System.Collections;

public class win_ground : MonoBehaviour {

	public GameObject Target;
	private MainData MD;


	public GameObject[] Blanks;

	// Use this for initialization
	void Start () {
		Target = GameObject.Find("/Main");
		MD = Target.GetComponent<MainData>();
	}
	
	// Update is called once per frame
	void Update () {
		transBlankState ();
	}

	void resClickItem(int itemNumber)
	{
		int[] GSI = MD.getGroundStateItem ();
		if (itemNumber > 0)
			itemNumber--;
		GSI [itemNumber] = GSI [itemNumber] * -1;
		MD.setGroundStateItem (GSI);
		transBlankState ();
	}

	void resClickBlank(int itemNumber)
	{
		resClickItem (itemNumber);
	}

	public void transBlankState()
	{
		int[] GSI = MD.getGroundStateItem ();
		for (int i=0; i<GSI.Length; i++) 
		{
			if(GSI[i] == -1) Blanks[i].gameObject.SetActive(false);
			else  Blanks[i].gameObject.SetActive(true);
		}
	}
}
