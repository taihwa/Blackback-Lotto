using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {
	// Global
	public int[] GroundStateItem = {-1,-1,-1,-1,-1,-1,-1,-1};
	public int[] GroundPriceItem = {1000000,5000000,10000000,50000000,10000000,50000000,10000000,50000000};
	// Global /

	public TextSetting TS;

	public GUIText SpeedButtonText;
	public GUIText PlusButtonText;

	public GameObject win_ground;
	public bool win_tog = false;

	public GameObject win_slave;

	double DCMoney = 0;

	double timesCount = 0;
	string[] num1arr = {"","","","","",""};
	string[] num2arr = {"","","","","",""};
	string num1str = "";
	string num2str = "";
	string num1bonus = "";

	int NC = 0;
	double[] NCarr = {0,0,0,0,0,0,0};
	double[] DCMoneyArr = {0,0,0,0,0,0,0};

	float tt = 0f;

	public int SpeedLevel = 0;		// 속도
	public int PlusLevel = 0;		// 뻥튀기 노비 레벨
	public int GuanLevel = 0;		// 관직 레벨
	public double debug = 0;


	// Use this for initialization
	void Start () {
		TS = GetComponent<TextSetting>();
	}
	
	// Update is called once per frame
	void Update () {
		tt += Time.deltaTime;
		if (tt >= (1f-(0.033f*SpeedLevel))) {
			GoGo ();
			tt = 0f;
		}
	}

	public void GoGo()
	{
		DCMoney = 16000000000;
		firstDisplay ();
		secondDisplay ();
	}

	string djr(int n){
		return n > 9 ? "" + n: "0" + n;
	}

	string getNumber(string[] arr){
		string rtn = null;
		for (int h=0; h<1000; h++) {
			string num = djr (Random.Range (1, 45));
			if(System.Array.IndexOf(arr,num) == -1){
				rtn = num;
				break;
			}
		}
		return rtn;
	}

	string[] getNumberArray(){
		string[] arr = {"","","","","",""};
		for (int i=0; i<6; i++) {
			arr [i] = getNumber (arr);
		}
		System.Array.Sort (arr);
		return arr;
	}

	double PlusCache(double cache){
		float tm = PlusLevel / 10f * System.Convert.ToSingle(cache);
		float tm2 = GuanLevel / 1f * System.Convert.ToSingle(cache);
		return cache + tm + tm2;
	}

	int isDangchum(string[] arr1,string[] arr2){
		int cnt = 0;
		int rank = 0;

		for(var i=0;i<arr2.Length;i++){
			if(System.Array.IndexOf(arr1,arr2[i]) != -1){
				cnt++;
			}
		}
		if (cnt == 6) {	// 1st
			rank = 1;
			DCMoneyArr[rank] += PlusCache(DCMoney / 100 * 75) ;
		} else if (cnt == 5) {	// 3st

			if(System.Array.IndexOf(arr2,num1bonus) != -1){
				rank = 2;
				DCMoneyArr[rank] += PlusCache(DCMoney / 1000 * 125 / 30);
			}else{
				rank = 3;
				DCMoneyArr[rank] += PlusCache(DCMoney / 1000 * 125 / 1500);
			}
		} else if (cnt == 4) {	// 4st
			rank = 4;
			DCMoneyArr[rank] += PlusCache(50000);
		} else if (cnt == 3) {	// 5st
			rank = 5;
			DCMoneyArr[rank] += PlusCache(5000);
		}

		debug = PlusCache(5000);

		if(rank > 0) NCarr[rank]++;
		return rank;
	}



	void firstDisplay(){
		timesCount++;
		TS.Times.text = string.Format("{0,8:N0}",timesCount);
		//TS.Times.text = "제 "+string.Format("{0,0:N6}",tt)+" 회 추첨";
		
		num1arr = getNumberArray ();
		num1str = string.Join (" ", num1arr);
		num1bonus = getNumber (num1arr);
		TS.Num1.text = num1str+" : "+num1bonus;

		num2arr = getNumberArray ();
		num2str = string.Join (" ", num2arr);
		TS.Num2.text = num2str;
	}

	void secondDisplay(){
		NC = isDangchum (num1arr,num2arr);
		if (NC == 1) {	// 1st
			TS.DC1.text = secondDisplayText();
		} else if (NC == 2) {	// 2st
			TS.DC2.text = secondDisplayText();
		} else if (NC == 3) {	// 3st
			TS.DC3.text = secondDisplayText();
		} else if (NC == 4) {	// 4st
			TS.DC4.text = secondDisplayText();
		} else if (NC == 5) {	// 5st
			TS.DC5.text = secondDisplayText();
		}

		double sum = DCMoneyArr[1]+DCMoneyArr[2]+DCMoneyArr[3]+DCMoneyArr[4]+DCMoneyArr[5]+DCMoneyArr[6];
		TS.MoneySum.text = "돈 "+string.Format("{0,0:N0}", sum)+"원";
	}

	string secondDisplayText(){
		//return NC+"등   "+string.Format("{0,8:N0}", NCarr[NC])+"회   누적 "+string.Format("{0,14:N0}", DCMoneyArr[NC])+"원   "+NC+"등 "+num2str;
		return num2str+"  "+string.Format("{0,0:N0}", NCarr[NC])+"회";
	}










	public void onClickSpeed(){
		SpeedLevel += 5;
		SpeedButtonText.text = "Speed Up ("+SpeedLevel+")";
	}

	public void onClickPlus(){
		PlusLevel += 1;
		PlusButtonText.text = "Money Plus ("+PlusLevel+"%)";
	}

	public void closeAllWindows(){
		win_ground.gameObject.SetActive (false);
		win_slave.gameObject.SetActive (false);
	}

}
