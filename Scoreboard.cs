public class Scoreboard : MonoBehaviour, IClientComponent // TypeDefIndex: 11212
{	public static Scoreboard instance; // 0x0
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


	private void Awake() { }

	public static void ForceScoreboardUpdate() { }

	public static void UpdateScoreboard() { }

	public void OnToggle(bool isShowing) { }

	private static void OnDisconnected() { }

	public void ClearTeamContents() { }

	public void RebuildScoreboard() { }

	public void UpdateScoreboard(bool rebuild = False) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class Scoreboard.TeamColumn // TypeDefIndex: 11213
{	public GameObject nameColumn; // 0x10
	public GameObject[] activeColumns; // 0x18


	public void .ctor() { }

}

