public class GameStat : MonoBehaviour // TypeDefIndex: 12706
{
	public float refreshTime;
	public Text title;
	public Text globalStat;
	public Text localStat;
	private long globalValue;
	private long localValue;
	private float secondsSinceRefresh;
	private float secondsUntilUpdate;
	private float secondsUntilChange;
	public GameStat.Stat[] stats;
	private GameStat.Stat[] unshownStats;
	private GameStat.Stat stat;


	private void Awake() { }

	public void Refresh() { }

	public void ForceUpdate() { }

	public void UpdateText() { }

	private void Update() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute]
	private bool <Refresh>

}

public struct GameStat.Stat // TypeDefIndex: 12707
{
	public string statName;
	public string statTitle;

}

