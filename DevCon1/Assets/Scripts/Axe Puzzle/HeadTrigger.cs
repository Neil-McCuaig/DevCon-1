using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTrigger : MonoBehaviour
{
    public Puzzle_Logic_Level2 AxePuzzleLogic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Piece1")
        {
            AxePuzzleLogic.isAxeHead = true;
        }
    }
}
