public class TechTreeDialog : UIDialog, IInventoryChanged // TypeDefIndex: 10911
{	// Fields
	public TechTreeData data; // 0x30
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

	// Methods

	// RVA: 0x7AB300 Offset: 0x7AA700 VA: 0x1807AB300 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x7AA700 Offset: 0x7A9B00 VA: 0x1807AA700 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x7ABB20 Offset: 0x7AAF20 VA: 0x1807ABB20
	public void SetScalerEnabled(bool wants) { }

	// RVA: 0x7AA410 Offset: 0x7A9810 VA: 0x1807AA410
	public Vector2 CalculateContentSize() { }

	// RVA: 0x7AAA00 Offset: 0x7A9E00 VA: 0x1807AAA00
	public void GetFarthestExtents(TechTreeData.NodeInstance node, ref Vector2 mins, ref Vector2 maxs) { }

	// RVA: 0x7AA780 Offset: 0x7A9B80 VA: 0x1807AA780
	public Vector2 GetColumnRowIndexForPosition(Vector2 position) { }

	// RVA: 0x7ABB80 Offset: 0x7AAF80 VA: 0x1807ABB80
	public void SetWidgetSelected(int id, bool wantsSelected) { }

	// RVA: 0x7AA6B0 Offset: 0x7A9AB0 VA: 0x1807AA6B0
	public void ClearSelection() { }

	// RVA: 0x7AC0B0 Offset: 0x7AB4B0 VA: 0x1807AC0B0
	public void UpdateSelectedNode(int newSelectedNodeID) { }

	// RVA: 0x7AA840 Offset: 0x7A9C40 VA: 0x1807AA840
	public BaseEntity GetContainerEntity() { }

	// RVA: 0x7ABCB0 Offset: 0x7AB0B0 VA: 0x1807ABCB0
	public void SetWorkbench(Workbench wb) { }

	// RVA: 0x7AACD0 Offset: 0x7AA0D0 VA: 0x1807AACD0
	private Workbench GetWorkbench() { }

	// RVA: 0x7ABD00 Offset: 0x7AB100 VA: 0x1807ABD00
	public void UnlockPressed() { }

	// RVA: 0x7AAC70 Offset: 0x7AA070 VA: 0x1807AAC70
	public Vector2 GetNodeStartPoint() { }

	// RVA: 0x7ABA20 Offset: 0x7AAE20 VA: 0x1807ABA20
	public bool PlayerHasPathForUnlock(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AB880 Offset: 0x7AAC80 VA: 0x1807AB880
	public bool PlayerCanUnlock(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AAE50 Offset: 0x7AA250 VA: 0x1807AAE50
	public bool HasPlayerUnlocked(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AACA0 Offset: 0x7AA0A0 VA: 0x1807AACA0
	public void GetNodesRequiredToUnlock(BasePlayer player, TechTreeData.NodeInstance node, List<TechTreeData.NodeInstance> foundNodes) { }

	// RVA: 0x7A9B10 Offset: 0x7A8F10 VA: 0x1807A9B10
	public void AddSingleNode(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AACE0 Offset: 0x7AA0E0 VA: 0x1807AACE0
	public bool HasLine(int from, int to) { }

	// RVA: 0x7A90C0 Offset: 0x7A84C0 VA: 0x1807A90C0
	public void AddNodesRecursive(TechTreeData.NodeInstance startNode) { }

	// RVA: 0x7ABDB0 Offset: 0x7AB1B0 VA: 0x1807ABDB0
	public void UpdateLines() { }

	// RVA: 0x7AAF20 Offset: 0x7AA320 VA: 0x1807AAF20 Slot: 10
	public void OnInventoryChanged() { }

	// RVA: 0x7ABF60 Offset: 0x7AB360 VA: 0x1807ABF60
	private void UpdateScrapCount() { }

	// RVA: 0x7AC120 Offset: 0x7AB520 VA: 0x1807AC120
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AA6B0 Offset: 0x7A9AB0 VA: 0x1807AA6B0
	private void <OpenDialog>b__17_0() { }

}

private sealed class TechTreeDialog.<>c__DisplayClass37_0 // TypeDefIndex: 10912
{	// Fields
	public TechTreeDialog <>4__this; // 0x10
	public TechTreeData.NodeInstance node; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2E30 Offset: 0x7B2230 VA: 0x1807B2E30
	internal void <AddSingleNode>b__0() { }

}

