using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserState
{
	// Range 0 - 5329
	private int state;

	public void setState(int _state) {
		if (_state < 0 || _state > 5329){
		  this.state = 0;
		} else {
		  this.state = _state;
		}
  }
	
	public void addStep() {
		int session = getSession();
		int serie = getSerie();
		int movement = getMovement();
		int trial = getTrial();
		
		int MAX_SESSION = 5;
		int MAX_SERIE = 3;
		int MAX_MOVEMENT = 2;
		int MAX_TRIAL = 9;

    int currentState = getState();
		
    bool carry = false;

    if (trial + 1 > MAX_TRIAL ) {
      trial = 0;
      carry = true;
    } else {
      trial += 1;
    }

    if (carry && movement + 1 > MAX_MOVEMENT) {
	  movement = 0;
      carry = true;
    } else if (carry) {
	
      movement += 1;
      carry = false;
    }

    if (carry && serie + 1 > MAX_SERIE) {
      serie = 0;
      carry = true;
    } else if (carry) {
      serie += 1;
      carry = false;
    }

    if (carry && session + 1 > MAX_SESSION) {
      session = 0;
    } else if (carry) {
      session += 1;
      carry = false;
    }

    int newState = session * 1000 + serie * 100 + movement * 10 + trial;
    this.state = newState;
	}
	
	public string getStringState() { 
		int MAX_STATE_LENGTH = 4;
		string prePaddedString = Convert.ToString(this.state);
		string padding = "";
		
		for (int i = MAX_STATE_LENGTH - prePaddedString.Length ; i > 0; i--) {	
			padding += "0";
		}
		
		string paddedString = padding + prePaddedString;
		return paddedString; 
	}

	public int getState() { return this.state; }

	public int getSession(){ return (getStringState()[0] - '0'); }

	public int getSerie(){  return (getStringState()[1] - '0'); }

	public int getMovement(){  return (getStringState()[2] - '0'); }

	public int getTrial(){  return (getStringState()[3] - '0'); }
}
