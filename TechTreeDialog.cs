public class TechTreeDialog : UIDialog, IInventoryChanged // TypeDefIndex: 10911
{	public TechTreeData data; // 0x30
	public float graphScale; // 0x38
	public TechTreeEntry entryPrefab; // 0x40
	public TechTreeGroup groupPrefab; // 0x48
	public TechTreeLine linePrefab; // 0x50
	public RectTransform contents; // 0x58
	public RectTransform contentParent; // 0x60
	public TechTreeSelectedNodeUI selectedNodeUI; // 0x68
	public float nodeSize; // 0x70
	public float gridSize; // 0x74
	public GameObjectRef unlockEffect; // 0x78
	public RustText scrapCount; // 0x80
	private Vector2 startPos; // 0x88
	public List<int> processed; // 0x90
	public Dictionary<int, TechTreeWidget> widgets; // 0x98
	public List<TechTreeLine> lines; // 0xA0
	public ScrollRectZoom zoom; // 0xA8
	private int selectedNodeID; // 0xB0
	private Workbench _attachedWorkbench; // 0xB8


	public override void OpenDialog() { }

	public override void CloseDialog() { }

	public void SetScalerEnabled(bool wants) { }

	public Vector2 CalculateContentSize() { }

	public void GetFarthestExtents(TechTreeData.NodeInstance node, ref Vector2 mins, ref Vector2 maxs) { }

	public Vector2 GetColumnRowIndexForPosition(Vector2 position) { }

	public void SetWidgetSelected(int id, bool wantsSelected) { }

	public void ClearSelection() { }

	public void UpdateSelectedNode(int newSelectedNodeID) { }

	public BaseEntity GetContainerEntity() { }

	public void SetWorkbench(Workbench wb) { }

	private Workbench GetWorkbench() { }

	public void UnlockPressed() { }

	public Vector2 GetNodeStartPoint() { }

	public bool PlayerHasPathForUnlock(TechTreeData.NodeInstance node) { }

	public bool PlayerCanUnlock(TechTreeData.NodeInstance node) { }

	public bool HasPlayerUnlocked(TechTreeData.NodeInstance node) { }

	public void GetNodesRequiredToUnlock(BasePlayer player, TechTreeData.NodeInstance node, List<TechTreeData.NodeInstance> foundNodes) { }

	public void AddSingleNode(TechTreeData.NodeInstance node) { }

	public bool HasLine(int from, int to) { }

	public void AddNodesRecursive(TechTreeData.NodeInstance startNode) { }

	public void UpdateLines() { }

	public void OnInventoryChanged() { }

	private void UpdateScrapCount() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <OpenDialog>b__17_0() { }

}

private sealed class TechTreeDialog.<>c__DisplayClass37_0 // TypeDefIndex: 10912
{	public TechTreeDialog <>4__this; // 0x10
	public TechTreeData.NodeInstance node; // 0x18


	public void .ctor() { }

	internal void <AddSingleNode>b__0() { }

}

