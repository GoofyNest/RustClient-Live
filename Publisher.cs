public class Publisher : MonoBehaviour // TypeDefIndex: 7762
{
	public InputField ChangeLog; 
	public Button PublishButton; 
	public Texture2D IconBackground; 
	private Skinnable Skinnable; 
	private Skin Skin; 
	private ulong ItemId; 
	private string Title; 
	private GameObject Prefab; 

protected WorkshopInterface Interface { get; }
protected WorkshopItemEditor Editor { get; }


protected WorkshopInterface get_Interface() { }

protected WorkshopItemEditor get_Editor() { }

public void StartExport() { }

public void Update() { }

public bool CanPublish() { }

	[AsyncStateMachineAttribute] 
private Task DoExport(bool publishToSteam, bool OpenFolder, string forceFolderName) { }

	[AsyncStateMachineAttribute] 
private Task ExportToFolder(string folder, bool OpenFolder) { }

private void CreateWorkshopIcon(string folder) { }

	[AsyncStateMachineAttribute] 
private Task PublishToSteam(string folder) { }

	[AsyncStateMachineAttribute] 
private Task ExportTexture(Dictionary<string, string> data, string folder, int group, string paramname, Material mat, Material defaultMat, bool isNormalMap = False) { }

public void Export() { }

	[AsyncStateMachineAttribute] 
public Task DoExport() { }

public void .ctor() { }

}

private struct Publisher.<DoExport>d__15 : IAsyncStateMachine // TypeDefIndex: 7763
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public Publisher <>4__this; 
	public string forceFolderName; 
	public bool OpenFolder; 
	public bool publishToSteam; 
	private string <tempFolder>5__2; 
	private TaskAwaiter <>u__1; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<ExportToFolder>d__16 : IAsyncStateMachine // TypeDefIndex: 7764
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public Publisher <>4__this; 
	public string folder; 
	public bool OpenFolder; 
	private Skin.Manifest <data>5__2; 
	private int <i>5__3; 
	private Material <mat>5__4; 
	private Skin.Manifest.Group <group>5__5; 
	private bool <isCloth>5__6; 
	private bool <hasDetailLayer>5__7; 
	private bool <hasDirtLayer>5__8; 
	private TaskAwaiter <>u__1; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<PublishToSteam>d__18 : IAsyncStateMachine // TypeDefIndex: 7765
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public Publisher <>4__this; 
	public string folder; 
	private TaskAwaiter<PublishResult> <>u__1; 
	private TaskAwaiter<Nullable<Item>> <>u__2; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<ExportTexture>d__19 : IAsyncStateMachine // TypeDefIndex: 7766
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public string paramname; 
	public Material mat; 
	public Material defaultMat; 
	public Dictionary<string, string> data; 
	public Publisher <>4__this; 
	public int group; 
	public bool isNormalMap; 
	public string folder; 
	private TaskAwaiter <>u__1; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<DoExport>d__21 : IAsyncStateMachine // TypeDefIndex: 7767
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public Publisher <>4__this; 
	private TaskAwaiter<string> <>u__1; 
	private TaskAwaiter <>u__2; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

