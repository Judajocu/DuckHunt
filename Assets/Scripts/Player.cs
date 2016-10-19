using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public GameObject Puntero;
    //GameObject Player2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Puntero.transform.position = Input.mousePosition;
        //Puntero.transform.Translate(new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));
        MovP1();

    }
    void MovP1()
    {
        Puntero.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Puntero.transform.position = new Vector3(Puntero.transform.position.x, Puntero.transform.position.y, 0);
    }


}
