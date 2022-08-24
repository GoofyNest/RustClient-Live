public class TechTreeData : ScriptableObject // TypeDefIndex: 10013
{
	public string shortname; 
	public int nextID; 
	private Dictionary<int, TechTreeData.NodeInstance> _idToNode; 
	private TechTreeData.NodeInstance _entryNode; 
	public List<TechTreeData.NodeInstance> nodes; 


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
{
	public int id; 
	public ItemDefinition itemDef; 
	public Vector2 graphPosition; 
	public List<int> outputs; 
	public List<int> inputs; 
	public string groupName; 
	public int costOverride; 


	public bool IsGroup() { }

	public void .ctor() { }

}

private sealed class TechTreeData.<>c // TypeDefIndex: 10015
{
	public static readonly TechTreeData.<>c <>9; 
	public static Func<TechTreeData.NodeInstance, int> <>9__5_0; 
	public static Func<TechTreeData.NodeInstance, TechTreeData.NodeInstance> <>9__5_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <GetByID>b__5_0(TechTreeData.NodeInstance n) { }

	internal TechTreeData.NodeInstance <GetByID>b__5_1(TechTreeData.NodeInstance n) { }

}

