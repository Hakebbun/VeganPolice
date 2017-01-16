using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardController : MonoBehaviour {
	public BoardModel boardModel;
	public Coruscant mCoruscant;

	public void onStartUp(BoardModel model, GameObject go){
		boardModel = model;
		// Setup tiles
		List<TileModel> newTiles = new List<TileModel>();
		for (int i = 0; i < Constants.MAX_NUM_TILE_ROW; i++) {
			for(int j =0; j<Constants.MAX_NUM_TILE_COL;j++){
				GameObject tilePrefab = (GameObject)Resources.Load (Constants.PREFAB_NAME_TILE);
				GameObject newTileGO = (GameObject)Instantiate(tilePrefab, new Vector2(j*Constants.TILE_X_DIST,i*Constants.TILE_Y_DIST), Quaternion.identity);
				TileModel newTile = newTileGO.GetComponent<TileModel> ();
				newTile.row = i;
				newTile.col = j;

				newTiles.Add(newTile);
				newTileGO.gameObject.transform.parent = go.transform;
				model.setTiles (newTiles);
			}
		}
	}

	// There's only one board, we can pass it upwards using this
	public BoardModel getBoard(){
		return boardModel;
	}



}
	