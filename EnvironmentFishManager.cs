public class EnvironmentFishManager : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8949
{	public EnvironmentFishManager.FishTypeInstance[] fishTypes; // 0x18
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static int maxFishPerType; // 0x0
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float maxFishDistance; // 0x4
	[ClientVar] // RVA: 0xC6C30 Offset: 0xC6030 VA: 0x1800C6C30
	[HelpAttribute] // RVA: 0xC6C30 Offset: 0xC6030 VA: 0x1800C6C30
	public static float framebudgetms; // 0x8
	public static EnvironmentFishManager.EnvironmentFishWorkQueue workQueue; // 0x10
	private GameObject fishContainer; // 0x20
	private int lastMaxFish; // 0x28
	private Vector3 lastFishUpdatePosition; // 0x2C
	private float nextFishUpdateTime; // 0x38


	public int GetMaxFish() { }

	public void Init() { }

	public void GenerateFish() { }

	public void Cleanup() { }

	public void Awake() { }

	public void OnDestroy() { }

	public void Update() { }

	public void UpdateFish() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class EnvironmentFishManager.FishTypeInstance // TypeDefIndex: 8950
{	public GameObjectRef prefab; // 0x10
	public bool shouldSchool; // 0x18
	public float populationScale; // 0x1C
	public bool freshwater; // 0x20
	public bool seawater; // 0x21
	public float minDepth; // 0x24
	public float maxDepth; // 0x28
	public List<EnvironmentFish> activeFish; // 0x30
	public List<EnvironmentFish> sleeping; // 0x38


	public float GetPopulationScaleForPoint(Vector3 point) { }

	public EnvironmentFish GetSleeping() { }

	public void Sleep(EnvironmentFish toSleep) { }

	public void .ctor() { }

}

public class EnvironmentFishManager.EnvironmentFishWorkQueue : ObjectWorkQueue<EnvironmentFish> // TypeDefIndex: 8951
{
	protected override void RunJob(EnvironmentFish entity) { }

	protected override bool ShouldAdd(EnvironmentFish entity) { }

	public void .ctor() { }

}

