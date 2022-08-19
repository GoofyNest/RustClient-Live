public class EnvironmentFishManager : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8949
{	// Fields
	public EnvironmentFishManager.FishTypeInstance[] fishTypes; // 0x18
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

	// Methods

	// RVA: 0x8B6D20 Offset: 0x8B6120 VA: 0x1808B6D20
	public int GetMaxFish() { }

	// RVA: 0x8B68B0 Offset: 0x8B5CB0 VA: 0x1808B68B0
	public void Init() { }

	// RVA: 0x8B69C0 Offset: 0x8B5DC0 VA: 0x1808B69C0
	public void GenerateFish() { }

	// RVA: 0x8B68C0 Offset: 0x8B5CC0 VA: 0x1808B68C0
	public void Cleanup() { }

	// RVA: 0x8B68B0 Offset: 0x8B5CB0 VA: 0x1808B68B0
	public void Awake() { }

	// RVA: 0x8B6DB0 Offset: 0x8B61B0 VA: 0x1808B6DB0
	public void OnDestroy() { }

	// RVA: 0x8B7960 Offset: 0x8B6D60 VA: 0x1808B7960
	public void Update() { }

	// RVA: 0x8B6DC0 Offset: 0x8B61C0 VA: 0x1808B6DC0
	public void UpdateFish() { }

	// RVA: 0x8B7B00 Offset: 0x8B6F00 VA: 0x1808B7B00
	public void .ctor() { }

	// RVA: 0x8B7A40 Offset: 0x8B6E40 VA: 0x1808B7A40
	private static void .cctor() { }

}

public class EnvironmentFishManager.FishTypeInstance // TypeDefIndex: 8950
{	// Fields
	public GameObjectRef prefab; // 0x10
	public bool shouldSchool; // 0x18
	public float populationScale; // 0x1C
	public bool freshwater; // 0x20
	public bool seawater; // 0x21
	public float minDepth; // 0x24
	public float maxDepth; // 0x28
	public List<EnvironmentFish> activeFish; // 0x30
	public List<EnvironmentFish> sleeping; // 0x38

	// Methods

	// RVA: 0x8C5FA0 Offset: 0x8C53A0 VA: 0x1808C5FA0
	public float GetPopulationScaleForPoint(Vector3 point) { }

	// RVA: 0x8C6110 Offset: 0x8C5510 VA: 0x1808C6110
	public EnvironmentFish GetSleeping() { }

	// RVA: 0x8C61C0 Offset: 0x8C55C0 VA: 0x1808C61C0
	public void Sleep(EnvironmentFish toSleep) { }

	// RVA: 0x8C62E0 Offset: 0x8C56E0 VA: 0x1808C62E0
	public void .ctor() { }

}

public class EnvironmentFishManager.EnvironmentFishWorkQueue : ObjectWorkQueue<EnvironmentFish> // TypeDefIndex: 8951
{	// Methods

	// RVA: 0x8B7B70 Offset: 0x8B6F70 VA: 0x1808B7B70 Slot: 6
	protected override void RunJob(EnvironmentFish entity) { }

	// RVA: 0x8B7BC0 Offset: 0x8B6FC0 VA: 0x1808B7BC0 Slot: 5
	protected override bool ShouldAdd(EnvironmentFish entity) { }

	// RVA: 0x8B7C60 Offset: 0x8B7060 VA: 0x1808B7C60
	public void .ctor() { }

}

