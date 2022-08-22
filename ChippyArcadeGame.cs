public class ChippyArcadeGame : BaseArcadeGame // TypeDefIndex: 8765
{	public ChippyMainCharacter mainChar; // 0x90
	public SpriteArcadeEntity mainCharAim; // 0x98
	public ChippyBoss currentBoss; // 0xA0
	public ChippyBoss[] bossPrefabs; // 0xA8
	public SpriteArcadeEntity mainMenuLogo; // 0xB0
	public Transform respawnPoint; // 0xB8
	public Vector2 mouseAim; // 0xC0
	public TextArcadeEntity levelIndicator; // 0xC8
	public TextArcadeEntity gameOverIndicator; // 0xD0
	public TextArcadeEntity playGameButton; // 0xD8
	public TextArcadeEntity highScoresButton; // 0xE0
	public bool OnMainMenu; // 0xE8
	public bool GameActive; // 0xE9
	public int level; // 0xEC
	public TextArcadeEntity[] scoreDisplays; // 0xF0
	public MenuButtonArcadeEntity[] mainMenuButtons; // 0xF8
	public int selectedButtonIndex; // 0x100
	public bool OnHighScores; // 0x104
	private float lastInputTime; // 0x108
	private float nextFireTime; // 0x10C
	private float nextClickTime; // 0x110


	public override void Initialize() { }

	public override void OnNoHost() { }

	public void DestroyNonMapEntites() { }

	public void MainMenu() { }

	public void SetLevel(int newLevel) { }

	public void StartGame() { }

	public void BossKilled(ChippyBoss killed) { }

	public void SpawnEnemies() { }

	public void FixedUpdate() { }

	public void GameOver() { }

	public void SetMenuVisible(bool isVisible) { }

	public override void MenuAction(string message) { }

	public void UpdateMenuButtons() { }

	public void SelectNextButton(int dir) { }

	public void SetScoresVisible(bool wantsVis) { }

	public override void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	public void .ctor() { }

}

