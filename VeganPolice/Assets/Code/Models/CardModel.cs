using UnityEngine;
using System.Collections;

public class CardModel : MonoBehaviour {
	public BaseCard card;
	public int location;
	private bool selected = false;
	public PlayerModel mPlayer;

	void Update(){

		// when we execute the deck, deselect all the cards. TODO: Maybe put this into a card controller?
		if (Input.GetButtonDown (Constants.INPUT_EXECUTE_DECK)) {
			(gameObject.GetComponent("Halo") as Behaviour).enabled = false;
			selected = false;
		}
	}

	void OnMouseDown(){
		if (!selected) {
			mPlayer.onCardSelect (location);
			(gameObject.GetComponent("Halo") as Behaviour).enabled = true;
			selected = true;
		} else {
			mPlayer.onCardDeselect (location);
			(gameObject.GetComponent("Halo") as Behaviour).enabled = false;
			selected = false;
		}
	}

	public bool getSelected(){
		return selected;
	}
}
