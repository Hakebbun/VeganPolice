using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TileModel : MonoBehaviour {
	public int row;
	public int col;

	// List of neighbours to this tile
	private TileModel[] mNeighbours;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	/*
	 * Getters and Setters
	 */ 

	public TileModel[] getNeighbours(){
		return this.mNeighbours;
	}

	public void setNeighbours(TileModel[] newNeighbours){
		this.mNeighbours = newNeighbours;
	}
}
