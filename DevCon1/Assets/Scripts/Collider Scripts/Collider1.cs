using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider1 : MonoBehaviour
{
    public Puzzle_Logic puzzleLogic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Piece1")
        {
            puzzleLogic.isPiece1 = true;
        }
    }
}
