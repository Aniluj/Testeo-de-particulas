﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionFenestron : MonoBehaviour {

	public float velocidadDeRotacion;

	void FixedUpdate () {
		transform.Rotate (-Vector3.forward * velocidadDeRotacion * Time.deltaTime);
	}
}
