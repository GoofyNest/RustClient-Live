public class GameStat : MonoBehaviour // TypeDefIndex: 10929
{	// Fields
	public float refreshTime; // 0x18
	public Text title; // 0x20
	public Text globalStat; // 0x28
	public Text localStat; // 0x30
	private long globalValue; // 0x38
	private long localValue; // 0x40
	private float secondsSinceRefresh; // 0x48
	private float secondsUntilUpdate; // 0x4C
	private float secondsUntilChange; // 0x50
	public GameStat.Stat[] stats; // 0x58
	private GameStat.Stat[] unshownStats; // 0x60
	private GameStat.Stat stat; // 0x68

	// Methods

	// RVA: 0x6F9640 Offset: 0x6F8A40 VA: 0x1806F9640
	private void Awake() { }

	// RVA: 0x6F9680 Offset: 0x6F8A80 VA: 0x1806F9680
	public void Refresh() { }

	// RVA: 0x6F9650 Offset: 0x6F8A50 VA: 0x1806F9650
	public void ForceUpdate() { }

	// RVA: 0x6F99E0 Offset: 0x6F8DE0 VA: 0x1806F99E0
	public void UpdateText() { }

	// RVA: 0x6F9AC0 Offset: 0x6F8EC0 VA: 0x1806F9AC0
	private void Update() { }

	// RVA: 0x6F9B40 Offset: 0x6F8F40 VA: 0x1806F9B40
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6F99C0 Offset: 0x6F8DC0 VA: 0x1806F99C0
	private bool <Refresh>b__14_0(GameStat.Stat x) { }

}

public struct GameStat.Stat // TypeDefIndex: 10930
{	// Fields
	public string statName; // 0x0
	public string statTitle; // 0x8

}

