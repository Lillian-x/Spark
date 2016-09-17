﻿using UnityEngine;
using System.Collections;

public class BlackHoleHorizon : MonoBehaviour {
    public Rigidbody blackHoleRigidBody;

	void OnTriggerEnter(Collider other)
    {
        var rb = other.gameObject.GetComponent<Rigidbody>();
        if (rb == null) return;
        // Add mass and destroy other object
        var otherMass = rb.mass;
        blackHoleRigidBody.mass += otherMass;
        if (other.gameObject.tag == "Character") Destroy(other.gameObject);
        other.gameObject.SetActive(false);
    }
}
