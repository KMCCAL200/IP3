using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {
	Vector3 old;
	bool h;
	public MapMove MapMove;

	GameObject target;
	public float time = 5;
	Vector3 position;
	// Use this for initialization
	void Start () {
		old = GameObject.Find("BigMap").transform.position;
		target = gameObject;
		position = GameObject.Find("BigMapTarget").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void g(bool j){j=h;}

	void OnMouseDown()
	{
		if(gameObject.name == "Map")
		{	h=true;
			//MapMove.move(h);
			Debug.Log("for");
			//MapMove.Forward(target);
		}
//
//		
		if(gameObject.name == "BigMap")
		{	
			h=false;
			Debug.Log("back");
			//MapMove.move(h);

			//MapMove.Back(target);
		}
	}
}
