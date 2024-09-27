using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider5 : MonoBehaviour
{
    public Puzzle_Logic puzzleLogic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Piece5")
        {
            puzzleLogic.isPiece5 = true;
        }
    }
}
