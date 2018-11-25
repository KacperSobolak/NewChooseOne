using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public Animator character;

	public void SetTrigger(string name)
    {
        character.SetTrigger(name);
    }
}
