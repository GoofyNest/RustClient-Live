public class Publisher : MonoBehaviour // TypeDefIndex: 7762
{	public InputField ChangeLog; // 0x18
	public Button PublishButton; // 0x20
	public Texture2D IconBackground; // 0x28
	private Skinnable Skinnable; // 0x30
	private Skin Skin; // 0x38
	private ulong ItemId; // 0x40
	private string Title; // 0x48
	private GameObject Prefab; // 0x50

	protected WorkshopInterface Interface { get; }
	protected WorkshopItemEditor Editor { get; }


	protected WorkshopInterface get_Interface() { }

	protected WorkshopItemEditor get_Editor() { }

	public void StartExport() { }

	public void Update() { }

	public bool CanPublish() { }

	[AsyncStateMachineAttribute] // RVA: 0xD6C20 Offset: 0xD6020 VA: 0x1800D6C20
	private Task DoExport(bool publishToSteam, bool OpenFolder, string forceFolderName) { }

	[AsyncStateMachineAttribute] // RVA: 0xD6D20 Offset: 0xD6120 VA: 0x1800D6D20
	private Task ExportToFolder(string folder, bool OpenFolder) { }

	private void CreateWorkshopIcon(string folder) { }

	[AsyncStateMachineAttribute] // RVA: 0xD7000 Offset: 0xD6400 VA: 0x1800D7000
	private Task PublishToSteam(string folder) { }

	[AsyncStateMachineAttribute] // RVA: 0xD7090 Offset: 0xD6490 VA: 0x1800D7090
	private Task ExportTexture(Dictionary<string, string> data, string folder, int group, string paramname, Material mat, Material defaultMat, bool isNormalMap = False) { }

	public void Export() { }

	[AsyncStateMachineAttribute] // RVA: 0xD71B0 Offset: 0xD65B0 VA: 0x1800D71B0
	public Task DoExport() { }

	public void .ctor() { }

}

private struct Publisher.<DoExport>d__15 : IAsyncStateMachine // TypeDefIndex: 7763
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Publisher <>4__this; // 0x20
	public string forceFolderName; // 0x28
	public bool OpenFolder; // 0x30
	public bool publishToSteam; // 0x31
	private string <tempFolder>5__2; // 0x38
	private TaskAwaiter <>u__1; // 0x40


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<ExportToFolder>d__16 : IAsyncStateMachine // TypeDefIndex: 7764
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Publisher <>4__this; // 0x20
	public string folder; // 0x28
	public bool OpenFolder; // 0x30
	private Skin.Manifest <data>5__2; // 0x38
	private int <i>5__3; // 0x40
	private Material <mat>5__4; // 0x48
	private Skin.Manifest.Group <group>5__5; // 0x50
	private bool <isCloth>5__6; // 0x58
	private bool <hasDetailLayer>5__7; // 0x59
	private bool <hasDirtLayer>5__8; // 0x5A
	private TaskAwaiter <>u__1; // 0x60


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<PublishToSteam>d__18 : IAsyncStateMachine // TypeDefIndex: 7765
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Publisher <>4__this; // 0x20
	public string folder; // 0x28
	private TaskAwaiter<PublishResult> <>u__1; // 0x30
	private TaskAwaiter<Nullable<Item>> <>u__2; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<ExportTexture>d__19 : IAsyncStateMachine // TypeDefIndex: 7766
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string paramname; // 0x20
	public Material mat; // 0x28
	public Material defaultMat; // 0x30
	public Dictionary<string, string> data; // 0x38
	public Publisher <>4__this; // 0x40
	public int group; // 0x48
	public bool isNormalMap; // 0x4C
	public string folder; // 0x50
	private TaskAwaiter <>u__1; // 0x58


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<DoExport>d__21 : IAsyncStateMachine // TypeDefIndex: 7767
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Publisher <>4__this; // 0x20
	private TaskAwaiter<string> <>u__1; // 0x28
	private TaskAwaiter <>u__2; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

