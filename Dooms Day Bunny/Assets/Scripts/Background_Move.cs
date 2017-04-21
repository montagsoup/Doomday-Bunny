using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Move : MonoBehaviour {
    public GameObject Bground0;
    public GameObject Bground1;

    private float speed = 0.1f;
    //public Camera Cam;

    private Bounds BgroundBounds;

    // Use this for initialization
    void Start () {
        BgroundBounds = Bground0.GetComponent<SpriteRenderer>().bounds;
	}
	
	// Update is called once per frame
	void Update () {
        Bground0.transform.position = new Vector3(Bground0.transform.position.x - speed, 0);
        Bground1.transform.position = new Vector3(Bground1.transform.position.x - speed, 0);

        if(Bground0.transform.position.x < -BgroundBounds.size.x)
        {
            Bground0.transform.position = new Vector3(Bground0.transform.position.x + BgroundBounds.size.x * 2,0); 
        }
        if (Bground1.transform.position.x < -BgroundBounds.size.x)
        {
            Bground1.transform.position = new Vector3(Bground1.transform.position.x + BgroundBounds.size.x * 2, 0);
        }
        speed += speed / 10000;
    }
}
