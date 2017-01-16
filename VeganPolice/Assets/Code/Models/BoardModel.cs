using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardModel : MonoBehaviour {
	public BoardController mBoardController;
	public List<TileModel> mTiles = new List<TileModel>();

	// Use this for initialization
	void Start () {
		mBoardController.onStartUp (this, gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public List<TileModel> getTiles(){
		return mTiles;
	}

	public void setTiles(List<TileModel> newTiles){
		mTiles = newTiles;
	}
}
