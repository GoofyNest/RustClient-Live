public class TechTreeData : ScriptableObject // TypeDefIndex: 10013
{	public string shortname; // 0x18
	public int nextID; // 0x20
	private Dictionary<int, TechTreeData.NodeInstance> _idToNode; // 0x28
	private TechTreeData.NodeInstance _entryNode; // 0x30
	public List<TechTreeData.NodeInstance> nodes; // 0x38


	public TechTreeData.NodeInstance GetByID(int id) { }

	public TechTreeData.NodeInstance GetEntryNode() { }

	public void ClearInputs(TechTreeData.NodeInstance node) { }

	public void SetupInputs(TechTreeData.NodeInstance node) { }

	public bool PlayerHasPathForUnlock(BasePlayer player, TechTreeData.NodeInstance node) { }

	public bool CheckChainRecursive(BasePlayer player, TechTreeData.NodeInstance start, TechTreeData.NodeInstance target) { }

	public bool PlayerCanUnlock(BasePlayer player, TechTreeData.NodeInstance node) { }

	public bool HasPlayerUnlocked(BasePlayer player, TechTreeData.NodeInstance node) { }

	public void GetNodesRequiredToUnlock(BasePlayer player, TechTreeData.NodeInstance node, List<TechTreeData.NodeInstance> foundNodes) { }

	public void .ctor() { }

}

public class TechTreeData.NodeInstance // TypeDefIndex: 10014
{	public int id; // 0x10
	public ItemDefinition itemDef; // 0x18
	public Vector2 graphPosition; // 0x20
	public List<int> outputs; // 0x28
	public List<int> inputs; // 0x30
	public string groupName; // 0x38
	public int costOverride; // 0x40


	public bool IsGroup() { }

	public void .ctor() { }

}

private sealed class TechTreeData.<>c // TypeDefIndex: 10015
{	public static readonly TechTreeData.<>c <>9; // 0x0
	public static Func<TechTreeData.NodeInstance, int> <>9__5_0; // 0x8
	public static Func<TechTreeData.NodeInstance, TechTreeData.NodeInstance> <>9__5_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal int <GetByID>b__5_0(TechTreeData.NodeInstance n) { }

	internal TechTreeData.NodeInstance <GetByID>b__5_1(TechTreeData.NodeInstance n) { }

}

