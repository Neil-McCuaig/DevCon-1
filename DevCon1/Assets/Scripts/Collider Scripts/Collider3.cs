using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider3 : MonoBehaviour
{
    public Puzzle_Logic puzzleLogic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Piece3")
        {
            puzzleLogic.isPiece3 = true;
        }
    }
}
