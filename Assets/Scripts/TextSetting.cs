using UnityEngine;
using System.Collections;

public class TextSetting : MonoBehaviour {

	public TextMesh Times;
	public TextMesh Num1;
	public TextMesh Num2;
	public TextMesh DC1;
	public TextMesh DC2;
	public TextMesh DC3;
	public TextMesh DC4;
	public TextMesh DC5;
	public TextMesh MoneySum;
	public TextMesh GuanLevel_text;
	
	void setTimes (string str) {
		Times.text = str;
	}
	void setNum1 (string str) {
		Num1.text = str;
	}
	void setNum2 (string str) {
		Num2.text = str;
	}
	void setDC1 (string str) {
		DC1.text = str;
	}
	void setDC2 (string str) {
		DC2.text = str;
	}
	void setDC3 (string str) {
		DC3.text = str;
	}
	void setDC4 (string str) {
		DC4.text = str;
	}
	void setDC5 (string str) {
		DC5.text = str;
	}
	void setMoneySum (string str) {
		MoneySum.text = str;
	}
	void setGuanLevel_text (string str) {
		GuanLevel_text.text = str;
	}
}
