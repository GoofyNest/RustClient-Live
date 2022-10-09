public class CraftingQueue : SingletonComponent<CraftingQueue> // TypeDefIndex: 12710
{
	public GameObject queueContainer; 
	public GameObject queueItemPrefab; 
	private ScrollRect scrollRect; 
	private static Dictionary<int, int> CraftingItems; 
	public static bool isCrafting; 


	protected override void Awake() { }

	public void ClearCraftingQueue() { }

	internal static void TaskStarted(int taskid, float time) { }

	internal static int Count(ItemBlueprint bp) { }

	internal static void TaskAdd(int taskid, int itemid, int amount, int skinid) { }

	internal static void TaskFinished(int taskid, bool success, int amountleft) { }

	internal static void TaskFastTracked(int taskid) { }

	public void UpdateVisibility() { }

	public CraftingQueueIcon GetActive() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class CraftingQueue.<>c__DisplayClass6_0 // TypeDefIndex: 12711
{
	public int taskid; 
	public Func<CraftingQueueIcon, bool> <>9__0; 


	public void .ctor() { }

	internal bool <TaskStarted>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass9_0 // TypeDefIndex: 12712
{
	public int taskid; 
	public Func<CraftingQueueIcon, bool> <>9__0; 


	public void .ctor() { }

	internal bool <TaskFinished>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass10_0 // TypeDefIndex: 12713
{
	public int taskid; 
	public Func<CraftingQueueIcon, bool> <>9__0; 


	public void .ctor() { }

	internal bool <TaskFastTracked>b__0(CraftingQueueIcon x) { }

}

