using UnityEngine;
using System.Collections;

public class InstatiateDucks : MonoBehaviour {

    public GameObject duck;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Ducks", 1f, 7f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Ducks()
    {
        Instantiate(duck, new Vector3(0,-2), Quaternion.identity);
    }
}
