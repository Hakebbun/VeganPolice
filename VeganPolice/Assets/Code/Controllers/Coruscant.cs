using UnityEngine;
using System.Collections;

public class Coruscant : MonoBehaviour {
	public PlayerController playerController;
	public BoardController boardController;

	public BoardModel getBoardModel(){
		return boardController.getBoard ();
	}
}
