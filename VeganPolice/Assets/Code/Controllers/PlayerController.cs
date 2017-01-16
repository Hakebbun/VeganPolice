using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {
	public Coruscant mCoruscant;
	private bool executing = false;
	private List<int> executingPlayers = new List<int> ();
	private bool playerTurn;

	// Use this for initialization
	void Start () {
		// Add player 1?
		GameObject playerPrefab = (GameObject)Resources.Load (Constants.PREFAB_NAME_PLAYER);
		GameObject newPlayerGO = (GameObject)Instantiate(playerPrefab, new Vector3(Constants.PLAYER_ONE_START_X,Constants.PLAYER_ONE_START_Y,Constants.PLAYER_ONE_START_Z), Quaternion.identity);
		PlayerModel newPlayer = newPlayerGO.GetComponent<PlayerModel> ();
		newPlayer.row = Constants.PLAYER_ONE_START_ROW;
		newPlayer.col = Constants.PLAYER_ONE_START_COL;
		newPlayer.mPlayerController = this;

		// Add the player's hand to the view.
		initPlayerHand (newPlayer);

		GameObject newPlayerGO2 = (GameObject)Instantiate(playerPrefab, new Vector3(Constants.PLAYER_ONE_START_X,Constants.PLAYER_ONE_START_Y,Constants.PLAYER_ONE_START_Z), Quaternion.identity);
		PlayerModel newPlayer2 = newPlayerGO.GetComponent<PlayerModel> ();
		newPlayer2.row = Constants.PLAYER_ONE_START_ROW;
		newPlayer2.col = Constants.PLAYER_ONE_START_COL;
		newPlayer2.mPlayerController = this;

		// Add the player's hand to the view.
		initPlayerHand (newPlayer2);
	}


	public void executeDeckPressed(PlayerModel playerModel, GameObject go){
		// Check if this player has already indicated their readiness
		// TODO: Needs to use a spin lock here instead of...this monstrocity
		if( playerModel.mDeck.Count == Constants.DECK_SIZE && !executingPlayers.Contains(playerModel.playerCode)){
			executingPlayers.Add (playerModel.playerCode);

			// Check if every player is ready
			if (executingPlayers.Count == Constants.MAX_NUM_PLAYERS) {
				if (!executing) {
					executing = true;
					BoardModel board = mCoruscant.getBoardModel ();

					object[] parms = new object[4]{ board, playerModel, board.gameObject, playerModel.gameObject };

					StartCoroutine ("executeDeck", parms);
				}
			}
		}



	}

	public void addUpPressed(PlayerModel curModel, GameObject go){

	}

	public void addDownPressed(PlayerModel curModel, GameObject go){

	}

	public void addRightPressed(PlayerModel curModel, GameObject go){

	}

	public void addLeftPressed(PlayerModel curModel, GameObject go){

	}

	private void initPlayerHand(PlayerModel playerModel){
		// Manually adding cards to the player's hand for now TODO: get this data from menu or something?
		playerModel.mCardsInHand.Add(new CardMoveUp());
		playerModel.mCardsInHand.Add(new CardMoveDown());
		playerModel.mCardsInHand.Add(new CardMoveLeft());
		playerModel.mCardsInHand.Add(new CardMoveRight());

		for(int i = 0; i<playerModel.mCardsInHand.Count;i++) {
			GameObject cardPrefab = (GameObject)Resources.Load (Constants.PREFAB_NAME_CARD);
			GameObject newCard = (GameObject)Instantiate (cardPrefab, new Vector2 (i*1.5f -4, -6.6f), Quaternion.identity);
			GameObject t = newCard.transform.GetChild (0).gameObject;
			TextMesh cardText = t.GetComponent<TextMesh> ();
			CardModel cardModel = newCard.GetComponent<CardModel> ();
			cardText.text = playerModel.mCardsInHand [i].cardName;
			cardModel.card = playerModel.mCardsInHand[i];
			cardModel.mPlayer = playerModel;
			cardModel.location = i;
		}

	}
		
	private IEnumerator executeDeck(object[] parms){
		BoardModel board = (BoardModel)parms [0];
		PlayerModel player = (PlayerModel)parms [1];
		GameObject boardGO = (GameObject)parms [2];
		GameObject playerGO = (GameObject)parms [3];
		foreach(BaseCard card in player.mDeck){
			card.action(board, player, boardGO, playerGO);
			yield return new WaitForSeconds(1);;
		}
		player.mDeck.Clear ();
		executing = false;


	}
}
