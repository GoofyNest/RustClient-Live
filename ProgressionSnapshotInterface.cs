public sealed class ProgressionSnapshotInterface : Handle // TypeDefIndex: 8768
{
	public const int AddprogressionApiLatest = 1;
	public const int BeginsnapshotApiLatest = 1;
	public const int DeletesnapshotApiLatest = 1;
	public const int EndsnapshotApiLatest = 1;
	public const int InvalidProgressionsnapshotid = 0;
	public const int SubmitsnapshotApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result AddProgression(ref AddProgressionOptions options) { }

	public Result BeginSnapshot(ref BeginSnapshotOptions options, out uint outSnapshotId) { }

	public void DeleteSnapshot(ref DeleteSnapshotOptions options, object clientData, OnDeleteSnapshotCallback completionDelegate) { }

	public Result EndSnapshot(ref EndSnapshotOptions options) { }

	public void SubmitSnapshot(ref SubmitSnapshotOptions options, object clientData, OnSubmitSnapshotCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnDeleteSnapshotCallbackInternalImplementation(ref DeleteSnapshotCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnSubmitSnapshotCallbackInternalImplementation(ref SubmitSnapshotCallbackInfoInternal data) { }

}

