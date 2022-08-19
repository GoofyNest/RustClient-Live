public class ChippyArcadeGame : BaseArcadeGame // TypeDefIndex: 8765
{	// Fields
	public ChippyMainCharacter mainChar; // 0x90
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

	// Methods

	// RVA: 0x551590 Offset: 0x550990 VA: 0x180551590 Slot: 7
	public override void Initialize() { }

	// RVA: 0x551810 Offset: 0x550C10 VA: 0x180551810 Slot: 6
	public override void OnNoHost() { }

	// RVA: 0x551160 Offset: 0x550560 VA: 0x180551160
	public void DestroyNonMapEntites() { }

	// RVA: 0x5515B0 Offset: 0x5509B0 VA: 0x1805515B0
	public void MainMenu() { }

	// RVA: 0x552480 Offset: 0x551880 VA: 0x180552480
	public void SetLevel(int newLevel) { }

	// RVA: 0x552D00 Offset: 0x552100 VA: 0x180552D00
	public void StartGame() { }

	// RVA: 0x5510C0 Offset: 0x5504C0 VA: 0x1805510C0
	public void BossKilled(ChippyBoss killed) { }

	// RVA: 0x5529C0 Offset: 0x551DC0 VA: 0x1805529C0
	public void SpawnEnemies() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void FixedUpdate() { }

	// RVA: 0x5514D0 Offset: 0x5508D0 VA: 0x1805514D0
	public void GameOver() { }

	// RVA: 0x552500 Offset: 0x551900 VA: 0x180552500
	public void SetMenuVisible(bool isVisible) { }

	// RVA: 0x551790 Offset: 0x550B90 VA: 0x180551790 Slot: 8
	public override void MenuAction(string message) { }

	// RVA: 0x552ED0 Offset: 0x5522D0 VA: 0x180552ED0
	public void UpdateMenuButtons() { }

	// RVA: 0x5523E0 Offset: 0x5517E0 VA: 0x1805523E0
	public void SelectNextButton(int dir) { }

	// RVA: 0x552610 Offset: 0x551A10 VA: 0x180552610
	public void SetScoresVisible(bool wantsVis) { }

	// RVA: 0x551880 Offset: 0x550C80 VA: 0x180551880 Slot: 9
	public override void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	// RVA: 0x552F60 Offset: 0x552360 VA: 0x180552F60
	public void .ctor() { }

}

