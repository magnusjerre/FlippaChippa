﻿using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Course : MonoBehaviour {
	
	public int id;
	public string name;
	public int nTries;
	public int nSuccesses;
	public Stack targetStack;
	public List<Stack> stacks;

	void Start() {
		targetStack.isTargetStack = true;
	}

}
