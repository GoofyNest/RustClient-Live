public class TennisArcadeGame : BaseArcadeGame // TypeDefIndex: 8775
{	// Fields
	public ArcadeEntity paddle1; // 0x90
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

	// Methods

	// RVA: 0x11303D0 Offset: 0x112F7D0 VA: 0x1811303D0 Slot: 6
	public override void OnNoHost() { }

	// RVA: 0x1130140 Offset: 0x112F540 VA: 0x181130140
	public void MainMenu() { }

	// RVA: 0x112FB70 Offset: 0x112EF70 VA: 0x18112FB70
	public void FixedUpdate() { }

	// RVA: 0x11309A0 Offset: 0x112FDA0 VA: 0x1811309A0
	public void UpdateScoreNodes() { }

	// RVA: 0x1130040 Offset: 0x112F440 VA: 0x181130040 Slot: 7
	public override void Initialize() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void PaddleInput(float amount, int paddleIndex) { }

	// RVA: 0x112FE50 Offset: 0x112F250 VA: 0x18112FE50
	public void GameStart() { }

	// RVA: 0x1130820 Offset: 0x112FC20 VA: 0x181130820
	public void RoundStart() { }

	// RVA: 0x1130470 Offset: 0x112F870 VA: 0x181130470 Slot: 9
	public override void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	// RVA: 0x1130AC0 Offset: 0x112FEC0 VA: 0x181130AC0
	public void .ctor() { }

}

