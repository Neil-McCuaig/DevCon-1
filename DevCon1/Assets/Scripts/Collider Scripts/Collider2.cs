using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2 : MonoBehaviour
{
    public Puzzle_Logic puzzleLogic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Piece2")
        {
            puzzleLogic.isPiece2 = true;
        }
    }
}
