public struct Editor // TypeDefIndex: 5280
{
	private PublishedFileId fileId;
	private bool creatingNew;
	private WorkshopFileType creatingType;
	private AppId consumerAppId;
	private string Title;
	private string Description;
	private string MetaData;
	private string ChangeLog;
	private string Language;
	private string PreviewFile;
	private DirectoryInfo ContentFolder;
	private Nullable<RemoteStoragePublishedFileVisibility> Visibility;
	private List<string> Tags;
	private Dictionary<string, List<string>> KeyValueTags;
	private HashSet<string> KeyValueTagsToRemove;

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

	[AsyncStateMachineAttribute]
	public Task<PublishResult> SubmitAsync(IProgress<float> progress, Action<PublishResult> onItemCreated) { }

}

private struct Editor.<SubmitAsync>d__40 : IAsyncStateMachine // TypeDefIndex: 5281
{
	public int <>1__state;
	public AsyncTaskMethodBuilder<PublishResult> <>t__builder;
	public IProgress<float> progress;
	public Editor <>4__this;
	public Action<PublishResult> onItemCreated;
	private PublishResult <result>5__2;
	private CallResult<CreateItemResult_t> <>u__1;
	private UGCUpdateHandle_t <handle>5__3;
	private CallResult<SubmitItemUpdateResult_t> <updating>5__4;
	private TaskAwaiter <>u__2;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Editor : ConsoleSystem // TypeDefIndex: 13714
{

	public void .ctor() { }

}

