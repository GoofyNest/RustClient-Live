public class TechTreeData : ScriptableObject // TypeDefIndex: 10013
{	// Fields
	public string shortname; // 0x18
	public int nextID; // 0x20
	private Dictionary<int, TechTreeData.NodeInstance> _idToNode; // 0x28
	private TechTreeData.NodeInstance _entryNode; // 0x30
	public List<TechTreeData.NodeInstance> nodes; // 0x38

	// Methods

	// RVA: 0x7A82A0 Offset: 0x7A76A0 VA: 0x1807A82A0
	public TechTreeData.NodeInstance GetByID(int id) { }

	// RVA: 0x7A85E0 Offset: 0x7A79E0 VA: 0x1807A85E0
	public TechTreeData.NodeInstance GetEntryNode() { }

	// RVA: 0x7A8150 Offset: 0x7A7550 VA: 0x1807A8150
	public void ClearInputs(TechTreeData.NodeInstance node) { }

	// RVA: 0x7A8ED0 Offset: 0x7A82D0 VA: 0x1807A8ED0
	public void SetupInputs(TechTreeData.NodeInstance node) { }

	// RVA: 0x7A8E70 Offset: 0x7A8270 VA: 0x1807A8E70
	public bool PlayerHasPathForUnlock(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7A7DF0 Offset: 0x7A71F0 VA: 0x1807A7DF0
	public bool CheckChainRecursive(BasePlayer player, TechTreeData.NodeInstance start, TechTreeData.NodeInstance target) { }

	// RVA: 0x7A8DF0 Offset: 0x7A81F0 VA: 0x1807A8DF0
	public bool PlayerCanUnlock(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7A8C50 Offset: 0x7A8050 VA: 0x1807A8C50
	public bool HasPlayerUnlocked(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7A87D0 Offset: 0x7A7BD0 VA: 0x1807A87D0
	public void GetNodesRequiredToUnlock(BasePlayer player, TechTreeData.NodeInstance node, List<TechTreeData.NodeInstance> foundNodes) { }

	// RVA: 0x7A9050 Offset: 0x7A8450 VA: 0x1807A9050
	public void .ctor() { }

}

public class TechTreeData.NodeInstance // TypeDefIndex: 10014
{	// Fields
	public int id; // 0x10
	public ItemDefinition itemDef; // 0x18
	public Vector2 graphPosition; // 0x20
	public List<int> outputs; // 0x28
	public List<int> inputs; // 0x30
	public string groupName; // 0x38
	public int costOverride; // 0x40

	// Methods

	// RVA: 0x799A70 Offset: 0x798E70 VA: 0x180799A70
	public bool IsGroup() { }

	// RVA: 0x799B10 Offset: 0x798F10 VA: 0x180799B10
	public void .ctor() { }

}

private sealed class TechTreeData.<>c // TypeDefIndex: 10015
{	// Fields
	public static readonly TechTreeData.<>c <>9; // 0x0
	public static Func<TechTreeData.NodeInstance, int> <>9__5_0; // 0x8
	public static Func<TechTreeData.NodeInstance, TechTreeData.NodeInstance> <>9__5_1; // 0x10

	// Methods

	// RVA: 0x7B2F10 Offset: 0x7B2310 VA: 0x1807B2F10
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2BC0 Offset: 0x7B1FC0 VA: 0x1807B2BC0
	internal int <GetByID>b__5_0(TechTreeData.NodeInstance n) { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	internal TechTreeData.NodeInstance <GetByID>b__5_1(TechTreeData.NodeInstance n) { }

}

