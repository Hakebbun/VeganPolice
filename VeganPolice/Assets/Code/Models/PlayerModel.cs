using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerModel : MonoBehaviour {
	public PlayerController mPlayerController;
	public List<BaseCard> mDeck = new List<BaseCard> ();
	public List<BaseCard> mCardsInHand = new List<BaseCard> ();
	public int row;
	public int col;
	public int playerCode;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown(Constants.INPUT_EXECUTE_DECK)){
			mPlayerController.executeDeckPressed (this, gameObject);
		}

		if (Input.GetButtonDown (Constants.INPUT_ADD_UP)) {
			mPlayerController.addUpPressed (this, gameObject);

		}

		if (Input.GetButtonDown (Constants.INPUT_ADD_DOWN)) {
			mPlayerController.addDownPressed (this, gameObject);

		}

		if (Input.GetButtonDown (Constants.INPUT_ADD_RIGHT)) {
			mPlayerController.addRightPressed (this, gameObject);

		}

		if (Input.GetButtonDown (Constants.INPUT_ADD_LEFT)) {
			mPlayerController.addLeftPressed (this, gameObject);

		}
			
	}

	public void onCardSelect(int location){
		BaseCard card = mCardsInHand [location];
		mDeck.Add(card);
	}

	public void onCardDeselect(int location){
		mDeck.Remove (mCardsInHand [location]);
	}
}
