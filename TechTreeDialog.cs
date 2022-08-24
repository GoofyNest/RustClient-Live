public class TechTreeDialog : UIDialog, IInventoryChanged // TypeDefIndex: 10911
{
	public TechTreeData data; 
	public float graphScale; 
	public TechTreeEntry entryPrefab; 
	public TechTreeGroup groupPrefab; 
	public TechTreeLine linePrefab; 
	public RectTransform contents; 
	public RectTransform contentParent; 
	public TechTreeSelectedNodeUI selectedNodeUI; 
	public float nodeSize; 
	public float gridSize; 
	public GameObjectRef unlockEffect; 
	public RustText scrapCount; 
	private Vector2 startPos; 
	public List<int> processed; 
	public Dictionary<int, TechTreeWidget> widgets; 
	public List<TechTreeLine> lines; 
	public ScrollRectZoom zoom; 
	private int selectedNodeID; 
	private Workbench _attachedWorkbench; 


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

	[CompilerGeneratedAttribute] 
private void <OpenDialog>b__17_0() { }

}

private sealed class TechTreeDialog.<>c__DisplayClass37_0 // TypeDefIndex: 10912
{
	public TechTreeDialog <>4__this; 
	public TechTreeData.NodeInstance node; 


public void .ctor() { }

internal void <AddSingleNode>b__0() { }

}

