using UnityEngine;
using System.Collections;

public class MapMove : MonoBehaviour {
	public GameObject target;
	public float time = 5;
	public Vector3 position;
	public bool forward;
	public Map Map;
	public bool k;
	// Use this for initialization
	void Start () {
		target = gameObject;
		position = GameObject.Find("BigMapTarget").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
//		Map.g(k);
//		if(k == true)
//		{position = GameObject.Find("BigMapTarget").transform.position;
//			iTween.MoveTo(target,position,time);
//			Debug.Log("f");
//		}
//		if(k == false)
//		{
//			Debug.Log("gh");
//			position = GameObject.Find("BigMapStart").transform.position;
//			iTween.MoveTo(target,position,time);
//			Debug.Log("b");
//		}
//		//iTween.MoveTo(target,position,time);
	}

	public void move(bool forwar)
	{
		forward=forwar;
		if(forwar == true)
		{position = GameObject.Find("BigMapTarget").transform.position;
			iTween.MoveTo(target,position,time);
			Debug.Log("f");
		}

	}
	public void moveb(bool forwar)
	{

		if(forward == false)
		{
			Debug.Log("gh");
			position = GameObject.Find("BigMapStart").transform.position;
			iTween.MoveTo(target,position,time);
			Debug.Log("b");
		}
	}

	public void Forward(GameObject t) {
		position = GameObject.Find("BigMapTarget").transform.position;
		iTween.MoveTo(target,position,time);
	}
	public void Back(GameObject t) {
		position = GameObject.Find("BigMapStart").transform.position;
		iTween.MoveTo(target,position,time);
	}
}
