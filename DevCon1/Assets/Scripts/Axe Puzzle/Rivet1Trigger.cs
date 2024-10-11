using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rivet1Trigger : MonoBehaviour
{
    public Puzzle_Logic_Level2 AxePuzzleLogic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Piece2")
        {
            AxePuzzleLogic.isRivet1 = true;
        }
    }
}
