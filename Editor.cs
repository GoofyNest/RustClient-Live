public struct Editor // TypeDefIndex: 5274
{	// Fields
	private PublishedFileId fileId; // 0x0
	private bool creatingNew; // 0x8
	private WorkshopFileType creatingType; // 0xC
	private AppId consumerAppId; // 0x10
	private string Title; // 0x18
	private string Description; // 0x20
	private string MetaData; // 0x28
	private string ChangeLog; // 0x30
	private string Language; // 0x38
	private string PreviewFile; // 0x40
	private DirectoryInfo ContentFolder; // 0x48
	private Nullable<RemoteStoragePublishedFileVisibility> Visibility; // 0x50
	private List<string> Tags; // 0x58
	private Dictionary<string, List<string>> KeyValueTags; // 0x60
	private HashSet<string> KeyValueTagsToRemove; // 0x68

	// Properties
	public static Editor NewMicrotransactionFile { get; }

	// Methods

	// RVA: 0x223D90 Offset: 0x223190 VA: 0x180223D90
	internal void .ctor(WorkshopFileType filetype) { }

	// RVA: 0x223DC0 Offset: 0x2231C0 VA: 0x180223DC0
	public void .ctor(PublishedFileId fileId) { }

	// RVA: 0x19D0680 Offset: 0x19CFA80 VA: 0x1819D0680
	public static Editor get_NewMicrotransactionFile() { }

	// RVA: 0x223D20 Offset: 0x223120 VA: 0x180223D20
	public Editor WithTitle(string t) { }

	// RVA: 0x223980 Offset: 0x222D80 VA: 0x180223980
	public Editor WithChangeLog(string t) { }

	// RVA: 0x223B20 Offset: 0x222F20 VA: 0x180223B20
	public Editor WithPreviewFile(string t) { }

	// RVA: 0x2239F0 Offset: 0x222DF0 VA: 0x1802239F0
	public Editor WithContent(DirectoryInfo t) { }

	// RVA: 0x223A60 Offset: 0x222E60 VA: 0x180223A60
	public Editor WithContent(string folderName) { }

	// RVA: 0x223B90 Offset: 0x222F90 VA: 0x180223B90
	public Editor WithPublicVisibility() { }

	// RVA: 0x223C30 Offset: 0x223030 VA: 0x180223C30
	public Editor WithTag(string tag) { }

	[AsyncStateMachineAttribute] // RVA: 0x9C970 Offset: 0x9BD70 VA: 0x18009C970
	// RVA: 0x223820 Offset: 0x222C20 VA: 0x180223820
	public Task<PublishResult> SubmitAsync(IProgress<float> progress, Action<PublishResult> onItemCreated) { }

}

private struct Editor.<SubmitAsync>d__40 : IAsyncStateMachine // TypeDefIndex: 5275
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<PublishResult> <>t__builder; // 0x8
	public IProgress<float> progress; // 0x20
	public Editor <>4__this; // 0x28
	public Action<PublishResult> onItemCreated; // 0x98
	private PublishResult <result>5__2; // 0xA0
	private CallResult<CreateItemResult_t> <>u__1; // 0xB8
	private UGCUpdateHandle_t <handle>5__3; // 0xD0
	private CallResult<SubmitItemUpdateResult_t> <updating>5__4; // 0xD8
	private TaskAwaiter <>u__2; // 0xF0

	// Methods

	// RVA: 0x224DC0 Offset: 0x2241C0 VA: 0x180224DC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224DD0 Offset: 0x2241D0 VA: 0x180224DD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Editor : ConsoleSystem // TypeDefIndex: 11905
{	// Methods

	// RVA: 0x6D97E0 Offset: 0x6D8BE0 VA: 0x1806D97E0
	public void .ctor() { }

}

