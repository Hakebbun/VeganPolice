using System;
using UnityEngine;


public class CardMoveUp : BaseCard{ 

	public CardMoveUp (){
		cardName = "Move Up";
		cardText = "Move up one tile";
		type = CardTypes.Movement;
	}

	public override void action (BoardModel board, PlayerModel player, GameObject boardGO, GameObject playerGO){
		if (player.row > 0) {
			TileModel targetTile = (TileModel)board.getTiles ()[(player.row - 1) * Constants.MAX_NUM_TILE_COL + player.col];
			Vector3 targetPos = targetTile.gameObject.transform.position;

			playerGO.transform.position = Vector3.MoveTowards (playerGO.transform.position, targetPos, 10);
			player.row = player.row - 1;
		}
	}

}


