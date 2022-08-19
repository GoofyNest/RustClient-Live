public class CraftingQueue : SingletonComponent<CraftingQueue> // TypeDefIndex: 10987
{	// Fields
	public GameObject queueContainer; // 0x18
	public GameObject queueItemPrefab; // 0x20
	private ScrollRect scrollRect; // 0x28
	private static Dictionary<int, int> CraftingItems; // 0x0
	public static bool isCrafting; // 0x8

	// Methods

	// RVA: 0x51CA10 Offset: 0x51BE10 VA: 0x18051CA10 Slot: 6
	protected override void Awake() { }

	// RVA: 0x51CA90 Offset: 0x51BE90 VA: 0x18051CA90
	public void ClearCraftingQueue() { }

	// RVA: 0x51D990 Offset: 0x51CD90 VA: 0x18051D990
	internal static void TaskStarted(int taskid, float time) { }

	// RVA: 0x51CBB0 Offset: 0x51BFB0 VA: 0x18051CBB0
	internal static int Count(ItemBlueprint bp) { }

	// RVA: 0x51CD50 Offset: 0x51C150 VA: 0x18051CD50
	internal static void TaskAdd(int taskid, int itemid, int amount, int skinid) { }

	// RVA: 0x51D530 Offset: 0x51C930 VA: 0x18051D530
	internal static void TaskFinished(int taskid, bool success, int amountleft) { }

	// RVA: 0x51D110 Offset: 0x51C510 VA: 0x18051D110
	internal static void TaskFastTracked(int taskid) { }

	// RVA: 0x51DC80 Offset: 0x51D080 VA: 0x18051DC80
	public void UpdateVisibility() { }

	// RVA: 0x51CCC0 Offset: 0x51C0C0 VA: 0x18051CCC0
	public CraftingQueueIcon GetActive() { }

	// RVA: 0x51DD70 Offset: 0x51D170 VA: 0x18051DD70
	public void .ctor() { }

	// RVA: 0x51DD10 Offset: 0x51D110 VA: 0x18051DD10
	private static void .cctor() { }

}

private sealed class CraftingQueue.<>c__DisplayClass6_0 // TypeDefIndex: 10988
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x525780 Offset: 0x524B80 VA: 0x180525780
	internal bool <TaskStarted>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass9_0 // TypeDefIndex: 10989
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x525780 Offset: 0x524B80 VA: 0x180525780
	internal bool <TaskFinished>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass10_0 // TypeDefIndex: 10990
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x525780 Offset: 0x524B80 VA: 0x180525780
	internal bool <TaskFastTracked>b__0(CraftingQueueIcon x) { }

}

