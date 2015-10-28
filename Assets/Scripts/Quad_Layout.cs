using UnityEngine;
using System.Collections;

public class Quad_Layout : MonoBehaviour {

	public float X = 1f;
	public float Y = 1f;
	public float W = 1f;
	public float H = 1f;

	public Vector3 screenTo3D( float x2, float y2, float z ){
		return Camera.main.ScreenToWorldPoint( new Vector3( x2, y2, z ) );
	}

	public Rect bound3D( float z ){
		Vector3 leftBottom = screenTo3D( 0, 0, z );
		Vector3 rigthTop = screenTo3D(Camera.main.pixelWidth,Camera.main.pixelHeight,z);
		return new Rect(
			//좌상단
			leftBottom.x, rigthTop.y,
			//가로길이, 세로길이
			rigthTop.x - leftBottom.x, rigthTop.y - leftBottom.y
		);
	}


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		//카메라 z=-5 인 경우, 역전하면 5, 카메라로부터 5만큼 떨어진 곳은 z = 0인거죠!
		Rect bound = bound3D( -Camera.main.transform.position.z );
		
		//좌상단으로 배치, 크기를 화면 꽉차게
		//transform.TransformPoint( new Vector3( bound.x * X, bound.y * Y, 0 ) );
		transform.localScale = new Vector3( bound.width * W, bound.height * H, transform.localScale.z );
		transform.position = new Vector3( bound.x * X, bound.y * Y, transform.position.z );
	}
}
