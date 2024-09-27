using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider4 : MonoBehaviour
{
    public Puzzle_Logic puzzleLogic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Piece4")
        {
            puzzleLogic.isPiece4 = true;
        }
    }
}
