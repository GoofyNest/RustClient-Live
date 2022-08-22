public struct Editor // TypeDefIndex: 5274
{	private PublishedFileId fileId; // 0x0
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

	public static Editor NewMicrotransactionFile { get; }


	internal void .ctor(WorkshopFileType filetype) { }

	public void .ctor(PublishedFileId fileId) { }

	public static Editor get_NewMicrotransactionFile() { }

	public Editor WithTitle(string t) { }

	public Editor WithChangeLog(string t) { }

	public Editor WithPreviewFile(string t) { }

	public Editor WithContent(DirectoryInfo t) { }

	public Editor WithContent(string folderName) { }

	public Editor WithPublicVisibility() { }

	public Editor WithTag(string tag) { }

	[AsyncStateMachineAttribute] // RVA: 0x9C970 Offset: 0x9BD70 VA: 0x18009C970
	public Task<PublishResult> SubmitAsync(IProgress<float> progress, Action<PublishResult> onItemCreated) { }

}

private struct Editor.<SubmitAsync>d__40 : IAsyncStateMachine // TypeDefIndex: 5275
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<PublishResult> <>t__builder; // 0x8
	public IProgress<float> progress; // 0x20
	public Editor <>4__this; // 0x28
	public Action<PublishResult> onItemCreated; // 0x98
	private PublishResult <result>5__2; // 0xA0
	private CallResult<CreateItemResult_t> <>u__1; // 0xB8
	private UGCUpdateHandle_t <handle>5__3; // 0xD0
	private CallResult<SubmitItemUpdateResult_t> <updating>5__4; // 0xD8
	private TaskAwaiter <>u__2; // 0xF0


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Editor : ConsoleSystem // TypeDefIndex: 11905
{
	public void .ctor() { }

}

