using UnityEngine;
using System.Collections;

public class Muros : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider otro)
    {
        if(otro.gameObject.tag != "Pato")
        {
            return;
        }
        Debug.Log("Es el pato");
        var rbody = otro.gameObject.GetComponent<Rigidbody>();
        switch (gameObject.name)
        {
            case "Izquierdo":
            case "Derecho":
                rbody.velocity = new Vector3(-rbody.velocity.x, rbody.velocity.y, rbody.velocity.z);
                break;
            case "Tope":
                Destroy(otro.gameObject);
                break;
        }
    }
}
