public class Scoreboard : MonoBehaviour, IClientComponent // TypeDefIndex: 11240
{
	public static Scoreboard instance; 
	public RustText scoreboardTitle; 
	public RectTransform scoreboardRootContents; 
	public RustText scoreLimitText; 
	public GameObject teamPrefab; 
	public GameObject columnPrefab; 
	public GameObject dividerPrefab; 
	public Color localPlayerColor; 
	public Color otherPlayerColor; 
	public Scoreboard.TeamColumn[] teamColumns; 
	public GameObject[] TeamPanels; 
	private GameObject divider; 
	private bool dirty; 


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

public class Scoreboard.TeamColumn // TypeDefIndex: 11241
{
	public GameObject nameColumn; 
	public GameObject[] activeColumns; 


	public void .ctor() { }

}

