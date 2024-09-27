using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Puzzle_Logic : MonoBehaviour
{
    //This script does three basic things
    //First, it checks if a gameobject with the correct tag collides with a trigger
    //Second, it destroys that game object and enables a static version of that gameobject in the correct spot
    //Third, it spawns the completed object on the table when all pieces have been placed

    //Declarations
    //Pieces
    public GameObject piece1;
    public GameObject piece2;
    public GameObject piece3;
    public GameObject piece4;
    public GameObject piece5;

    //Static Pieces
    public GameObject staticPiece1;
    public GameObject staticPiece2;
    public GameObject staticPiece3;
    public GameObject staticPiece4;
    public GameObject staticPiece5;

    //Completed Piece
    public GameObject completedPiece;

    //Variables for checking if pieces are placed
    public bool isPiece1;
    public bool isPiece2;
    public bool isPiece3;
    public bool isPiece4;
    public bool isPiece5;

    private void Start()
    {
        //Set the staic pieces to inactive on start
        staticPiece1.gameObject.SetActive(false);
        staticPiece2.gameObject.SetActive(false);
        staticPiece3.gameObject.SetActive(false);
        staticPiece4.gameObject.SetActive(false);
        staticPiece5.gameObject.SetActive(false);
        completedPiece.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Set pieces to appear when bools are true
        if (isPiece1 == true) { staticPiece1.gameObject.SetActive(true); piece1.SetActive(false); }
        if (isPiece2 == true) { staticPiece2.gameObject.SetActive(true); piece2.SetActive(false); }
        if (isPiece3 == true) { staticPiece3.gameObject.SetActive(true); piece3.SetActive(false); }
        if (isPiece4 == true) { staticPiece4.gameObject.SetActive(true); piece4.SetActive(false); }  
        if (isPiece5 == true) { staticPiece5.gameObject.SetActive(true); piece5.SetActive(false); }

        //When everything is true set the final piece to appear
        if (isPiece1 == true && isPiece2 == true && isPiece3 == true && isPiece4 == true && isPiece5 == true)
        {
        staticPiece1.gameObject.SetActive(false);
        staticPiece2.gameObject.SetActive(false);
        staticPiece3.gameObject.SetActive(false);
        staticPiece4.gameObject.SetActive(false);
        staticPiece5.gameObject.SetActive(false);
        completedPiece.gameObject.SetActive(true);
        }
    }


}
