using UnityEngine;
using System.Collections;

public class Duckie : MonoBehaviour {

    #region Enums:

        enum Direction
    {
        north, south, east, west, northeast,northwest, southeast, southwest
    }
    #endregion
    Direction direc;
    private static float Velocidad = 2f;
    // Use this for initialization
    void Start () {
        //gameObject.SetActive(false);
        InvokeRepeating("MovDuck", 1f,6f);
        
        LeavingGrass();
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        switch (direc)
        {
            case Direction.north:
                transform.Translate(0, (Velocidad * Time.deltaTime), 0);
                break;

            case Direction.south:
                transform.Translate(0, -1 * (Velocidad * Time.deltaTime), 0);
                break;

            case Direction.east:
                transform.Translate((Velocidad * Time.deltaTime), 0, 0);
                break;

            case Direction.west:
                transform.Translate(-1 * (Velocidad * Time.deltaTime), 0, 0);
                break;
        }
    }

    void LeavingGrass()
    {

    }

    void DyingDuck()
    {

    }
    
    void MovDuck()
    {
        switch (Random.Range(0, 4))
        {
            case 0:
                direc = Direction.north;
                break;
            case 1:
                direc = Direction.east;
                break;
            case 2:
                direc = Direction.south;
                break;
            case 3:
                direc = Direction.west;
                break;
        }

    }

   
}
