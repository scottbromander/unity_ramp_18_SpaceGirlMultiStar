using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public Image starImage;
	public Sprite iconStar;
	public Sprite iconNoStar;
	private bool carryingStar = false;

	//From other file where we were practicing MVC
	//private PlayerInventoryDisplay playerInventoryDisplay;


	//Once again, used for the MVC structure, but not used here.
	// Use this for initialization
	//void Start () {
		//playerInventoryDisplay = GetComponent<PlayerInventoryDisplay> ();
		//playerInventoryDisplay.OnChangeCarryingStar (carryingStar);
	//}

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("Star")){
			carryingStar = true;
			//playerInventoryDisplay.OnChangeCarryingStar (carryingStar);
			UpdateStarImage();
			Destroy (hit.gameObject);
		}
	}
	

	void UpdateStarImage () {
		if (carryingStar) {
			starImage.sprite = iconStar;
		} else {
			starImage.sprite = iconNoStar;
		}
	}
}
