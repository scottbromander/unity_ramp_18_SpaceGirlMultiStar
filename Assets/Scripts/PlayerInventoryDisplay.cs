using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour {
	public Text starText;

	public void OnChangeCarryingStar(bool carryingStar){
		string starMessage = "No star :(";
		if(carryingStar) starMessage = "Carrying Star :)";
		starText.text = starMessage;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
