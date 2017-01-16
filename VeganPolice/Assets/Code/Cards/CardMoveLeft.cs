using System;
using UnityEngine;


public class CardMoveLeft : BaseCard{ 

	public CardMoveLeft (){
		cardName = "Move Left";
		cardText = "Move left one tile";
		type = CardTypes.Movement;
	}

	public override void action (BoardModel board, PlayerModel player, GameObject boardGO, GameObject playerGO){
		if (player.col > 0) {
			TileModel targetTile = (TileModel)board.getTiles ()[(player.row) * Constants.MAX_NUM_TILE_COL + player.col - 1];
			Vector3 targetPos = targetTile.gameObject.transform.position;

			Debug.Log ("moving to...:" + targetPos);
			playerGO.transform.position = Vector3.MoveTowards (playerGO.transform.position, targetPos, 10);
			player.col = player.col - 1;
		}
	}

}


