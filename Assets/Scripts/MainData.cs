using UnityEngine;
using System.Collections;

public class MainData : MonoBehaviour {

	private int[] GroundStateItem = {-1,-1,-1,-1,-1,-1,-1,-1};
	public void setGroundStateItem(int[] data){
		GroundStateItem = data;
	}
	public int[] getGroundStateItem()
	{
		return GroundStateItem;
	}


	private int[] GroundPriceItem = {1000000,5000000,10000000,50000000,10000000,50000000,10000000,50000000};
	public void setGroundPriceItem(int[] data){
		GroundPriceItem = data;
	}
	public int[] getGroundPriceItem()
	{
		return GroundPriceItem;
	}


	private double DCMoney = 0;
	public void setDCMoney(double data)
	{
		DCMoney = data;
	}
	public double getDCMoney()
	{
		return DCMoney;
	}
	
}
