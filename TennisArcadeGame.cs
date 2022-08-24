public class TennisArcadeGame : BaseArcadeGame // TypeDefIndex: 8775
{
	public ArcadeEntity paddle1; 
	public ArcadeEntity paddle2; 
	public ArcadeEntity ball; 
	public Transform paddle1Origin; 
	public Transform paddle2Origin; 
	public Transform paddle1Goal; 
	public Transform paddle2Goal; 
	public Transform ballSpawn; 
	public float maxScore; 
	public ArcadeEntity[] paddle1ScoreNodes; 
	public ArcadeEntity[] paddle2ScoreNodes; 
	public int paddle1Score; 
	public int paddle2Score; 
	public float sensitivity; 
	public ArcadeEntity logo; 
	public bool OnMainMenu; 
	public bool GameActive; 
	private float paddleMoveSpeed; 
	private float lastInputTime; 
	private float lastHeight; 
	private float lastAIHeight; 


public override void OnNoHost() { }

public void MainMenu() { }

public void FixedUpdate() { }

public void UpdateScoreNodes() { }

public override void Initialize() { }

public void PaddleInput(float amount, int paddleIndex) { }

public void GameStart() { }

public void RoundStart() { }

public override void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

public void .ctor() { }

}

