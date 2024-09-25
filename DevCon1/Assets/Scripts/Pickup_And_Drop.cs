using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_And_Drop : MonoBehaviour
{
    //Code inspired by https://www.youtube.com/watch?v=8kKLUsn7tcg

    public Rigidbody rb;
    public BoxCollider coll;
    public Transform player;
    public Transform shuriken;

    public float pickUpRange;

    public bool equipped;
    public static bool handFull;

    // Update is called once per frame
    void Update()
    {
        //If the player is in range of the object and the left mouse button is pressed
        Vector3 distanceToPlayer = player.position - transform.position;
        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetMouseButtonDown(0) && !handFull) PickUp();

        //If something is in the player's hand and right right mouse button is pressed
        if (equipped && Input.GetMouseButtonDown(1)) Place();
    }

    private void PickUp()
    {
        equipped = true;
        handFull = true;

        rb.isKinematic = true;
    }

    private void Place()
    {

    }

}
