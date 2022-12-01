public class ImageStorageEntity : BaseEntity // TypeDefIndex: 10303
{
	private List<ImageStorageEntity.ImageRequest> _requests;

	protected virtual FileStorage.Type StorageType { get; }
	protected virtual uint CrcToLoad { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected virtual FileStorage.Type get_StorageType() { }

	protected virtual uint get_CrcToLoad() { }

	private void RequestImage(IImageReceiver receiver) { }

	[BaseEntity.RPC_Client]
	private void ReceiveImage(BaseEntity.RPCMessage msg) { }

	private void LoadFromBytes(byte[] imageData) { }

	[IteratorStateMachineAttribute]
	public static IEnumerator LoadImage(uint imageStorageEntityId, IImageReceiver receiver) { }

	public void .ctor() { }

}

private struct ImageStorageEntity.ImageRequest // TypeDefIndex: 10304
{
	public IImageReceiver Receiver;
	public float Time;

}

private sealed class ImageStorageEntity.<>c // TypeDefIndex: 10305
{
	public static readonly ImageStorageEntity.<>c <>9;
	public static Predicate<ImageStorageEntity.ImageRequest> <>9__7_0;
	public static Func<ImageStorageEntity.ImageRequest, IImageReceiver> <>9__7_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <RequestImage>

	internal IImageReceiver <RequestImage>

}

private sealed class ImageStorageEntity.<LoadImage>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10306
{
	private int <>1__state;
	private object <>2__current;
	public uint imageStorageEntityId;
	public IImageReceiver receiver;
	private RealTimeSince <sinceStart>5__2;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

