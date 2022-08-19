public class Scoreboard : MonoBehaviour, IClientComponent // TypeDefIndex: 11212
{	// Fields
	public static Scoreboard instance; // 0x0
	public RustText scoreboardTitle; // 0x18
	public RectTransform scoreboardRootContents; // 0x20
	public RustText scoreLimitText; // 0x28
	public GameObject teamPrefab; // 0x30
	public GameObject columnPrefab; // 0x38
	public GameObject dividerPrefab; // 0x40
	public Color localPlayerColor; // 0x48
	public Color otherPlayerColor; // 0x58
	public Scoreboard.TeamColumn[] teamColumns; // 0x68
	public GameObject[] TeamPanels; // 0x70
	private GameObject divider; // 0x78
	private bool dirty; // 0x80

	// Methods

	// RVA: 0x49DFC0 Offset: 0x49D3C0 VA: 0x18049DFC0
	private void Awake() { }

	// RVA: 0x49E260 Offset: 0x49D660 VA: 0x18049E260
	public static void ForceScoreboardUpdate() { }

	// RVA: 0x49EE70 Offset: 0x49E270 VA: 0x18049EE70
	public static void UpdateScoreboard() { }

	// RVA: 0x49E430 Offset: 0x49D830 VA: 0x18049E430
	public void OnToggle(bool isShowing) { }

	// RVA: 0x49E350 Offset: 0x49D750 VA: 0x18049E350
	private static void OnDisconnected() { }

	// RVA: 0x49E150 Offset: 0x49D550 VA: 0x18049E150
	public void ClearTeamContents() { }

	// RVA: 0x49E4B0 Offset: 0x49D8B0 VA: 0x18049E4B0
	public void RebuildScoreboard() { }

	// RVA: 0x49EFE0 Offset: 0x49E3E0 VA: 0x18049EFE0
	public void UpdateScoreboard(bool rebuild = False) { }

	// RVA: 0x49F830 Offset: 0x49EC30 VA: 0x18049F830
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class Scoreboard.TeamColumn // TypeDefIndex: 11213
{	// Fields
	public GameObject nameColumn; // 0x10
	public GameObject[] activeColumns; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

