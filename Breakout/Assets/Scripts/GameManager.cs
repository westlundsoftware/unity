using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject player;
	public GameObject bricksLevel1;
	public GameObject bricksLevel2;
	private GameObject ball;

	public static GameManager instance = null;
	public GameObject gameOver;
	public Text Level;
	public Text Lives;
	public int lives = 3;
	private int level = 1;
	private int bricksLeft;
	public float resetDelay = 2f;
	public int bricksCountLevel1 = 8;
	public int bricksCountLevel2 = 6;

	private GameObject playerClone;

	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		}
		Setup ();

	}

	void Setup()
	{
		bricksLeft = bricksCountLevel1;
		Lives.text = "Lives: "+lives;
		gameOver.SetActive (false);
		Level.text = "Level: " + level;

		SetupPlayer ();

		Instantiate (bricksLevel1, bricksLevel1.transform.position, Quaternion.identity);
	}

	private void SetupPlayer()
	{
		playerClone = Instantiate (player, player.transform.position, player.transform.rotation) as GameObject;
	}

	public void LostLife()
	{
		lives--;
		UpdateLivesText ();
		Destroy (playerClone);
		Invoke ("SetupPlayer", resetDelay);
		CheckGameOver ();
	}

	public void DestroyBrick(Collision other)
	{
		ball = other.gameObject;
		bricksLeft--;
		CheckGameOver ();
	}

	private void CheckGameOver()
	{
		if (bricksLeft <= 0) {
			Destroy (ball);
			// Next level
			Time.timeScale = 1f;
			Invoke ("LevelUp", resetDelay);
		}
		if (lives <= 0) {
			gameOver.SetActive (true);
			Time.timeScale = 0.3f;
			Invoke ("Reset", resetDelay);
		}
	}

	private void Reset()
	{
		SetupPlayer ();
		Time.timeScale = 1f;

		//Todo byt mot SceneManager
		Application.LoadLevel(Application.loadedLevel);
	}

	private void LevelUp()
	{
		Destroy (playerClone);
		Invoke ("SetupPlayer", resetDelay);

		level++;
		Level.text = "Level: "+level;

		if (level == 2) {
			bricksLeft = bricksCountLevel2;
			Instantiate (bricksLevel2, bricksLevel2.transform.position, Quaternion.identity);
		}
		//Todo LAdda nästa level
		//Application.LoadLevel(Application.loadedLevel);
	}

	private void UpdateLivesText()
	{
		Lives.text = "Lives: "+lives;
	}
}
