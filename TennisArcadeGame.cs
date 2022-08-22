public class TennisArcadeGame : BaseArcadeGame // TypeDefIndex: 8775
{	public ArcadeEntity paddle1; // 0x90
	public ArcadeEntity paddle2; // 0x98
	public ArcadeEntity ball; // 0xA0
	public Transform paddle1Origin; // 0xA8
	public Transform paddle2Origin; // 0xB0
	public Transform paddle1Goal; // 0xB8
	public Transform paddle2Goal; // 0xC0
	public Transform ballSpawn; // 0xC8
	public float maxScore; // 0xD0
	public ArcadeEntity[] paddle1ScoreNodes; // 0xD8
	public ArcadeEntity[] paddle2ScoreNodes; // 0xE0
	public int paddle1Score; // 0xE8
	public int paddle2Score; // 0xEC
	public float sensitivity; // 0xF0
	public ArcadeEntity logo; // 0xF8
	public bool OnMainMenu; // 0x100
	public bool GameActive; // 0x101
	private float paddleMoveSpeed; // 0x104
	private float lastInputTime; // 0x108
	private float lastHeight; // 0x10C
	private float lastAIHeight; // 0x110


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

