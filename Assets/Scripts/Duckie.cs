using UnityEngine;
using System.Collections;

public class Duckie : MonoBehaviour {

    #region Enums:

        enum Direction
    {
        north, south, este, oeste
    }
    #endregion
    Direction direc;
    // Use this for initialization
    void Start () {
        //gameObject.SetActive(false);
        InvokeRepeating("MovDuck", 1f,6f);
        LeavingGrass();
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void LeavingGrass()
    {

    }

    void DyingDuck()
    {

    }

    void MovDuck()
    {
        //gameObject.SetActive(true);
        float randX = Random.Range(-3f, 3f);
        float randY = Random.Range(-1f, 4.5f);
        gameObject.transform.position = new Vector3(randX, randY);
        gameObject.transform.Translate(gameObject.transform.position.x, gameObject.transform.position.y,0);
    }
}
