public class EnvironmentFishManager : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10686
{
	public EnvironmentFishManager.FishTypeInstance[] fishTypes;
	[ClientVar]
	public static int maxFishPerType;
	[ClientVar]
	public static float maxFishDistance;
	[ClientVar]
	[HelpAttribute]
	public static float framebudgetms;
	public static EnvironmentFishManager.EnvironmentFishWorkQueue workQueue;
	private GameObject fishContainer;
	private int lastMaxFish;
	private Vector3 lastFishUpdatePosition;
	private float nextFishUpdateTime;


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

public class EnvironmentFishManager.FishTypeInstance // TypeDefIndex: 10687
{
	public GameObjectRef prefab;
	public bool shouldSchool;
	public float populationScale;
	public bool freshwater;
	public bool seawater;
	public float minDepth;
	public float maxDepth;
	public List<EnvironmentFish> activeFish;
	public List<EnvironmentFish> sleeping;


	public float GetPopulationScaleForPoint(Vector3 point) { }

	public EnvironmentFish GetSleeping() { }

	public void Sleep(EnvironmentFish toSleep) { }

	public void .ctor() { }

}

public class EnvironmentFishManager.EnvironmentFishWorkQueue : ObjectWorkQueue<EnvironmentFish> // TypeDefIndex: 10688
{

	protected override void RunJob(EnvironmentFish entity) { }

	protected override bool ShouldAdd(EnvironmentFish entity) { }

	public void .ctor() { }

}

