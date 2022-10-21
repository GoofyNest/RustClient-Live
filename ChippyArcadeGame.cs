public class ChippyArcadeGame : BaseArcadeGame // TypeDefIndex: 10476
{
	public ChippyMainCharacter mainChar; 
	public SpriteArcadeEntity mainCharAim; 
	public ChippyBoss currentBoss; 
	public ChippyBoss[] bossPrefabs; 
	public SpriteArcadeEntity mainMenuLogo; 
	public Transform respawnPoint; 
	public Vector2 mouseAim; 
	public TextArcadeEntity levelIndicator; 
	public TextArcadeEntity gameOverIndicator; 
	public TextArcadeEntity playGameButton; 
	public TextArcadeEntity highScoresButton; 
	public bool OnMainMenu; 
	public bool GameActive; 
	public int level; 
	public TextArcadeEntity[] scoreDisplays; 
	public MenuButtonArcadeEntity[] mainMenuButtons; 
	public int selectedButtonIndex; 
	public bool OnHighScores; 
	private float lastInputTime; 
	private float nextFireTime; 
	private float nextClickTime; 


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

