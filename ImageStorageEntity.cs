public class ImageStorageEntity : BaseEntity // TypeDefIndex: 8580
{	private List<ImageStorageEntity.ImageRequest> _requests; // 0x168

	protected virtual FileStorage.Type StorageType { get; }
	protected virtual uint CrcToLoad { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected virtual FileStorage.Type get_StorageType() { }

	protected virtual uint get_CrcToLoad() { }

	private void RequestImage(IImageReceiver receiver) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ReceiveImage(BaseEntity.RPCMessage msg) { }

	private void LoadFromBytes(byte[] imageData) { }

	[IteratorStateMachineAttribute] // RVA: 0xABE50 Offset: 0xAB250 VA: 0x1800ABE50
	public static IEnumerator LoadImage(uint imageStorageEntityId, IImageReceiver receiver) { }

	public void .ctor() { }

}

private struct ImageStorageEntity.ImageRequest // TypeDefIndex: 8581
{	public IImageReceiver Receiver; // 0x0
	public float Time; // 0x8

}

private sealed class ImageStorageEntity.<>c // TypeDefIndex: 8582
{	public static readonly ImageStorageEntity.<>c <>9; // 0x0
	public static Predicate<ImageStorageEntity.ImageRequest> <>9__7_0; // 0x8
	public static Func<ImageStorageEntity.ImageRequest, IImageReceiver> <>9__7_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <RequestImage>b__7_0(ImageStorageEntity.ImageRequest r) { }

	internal IImageReceiver <RequestImage>b__7_1(ImageStorageEntity.ImageRequest r) { }

}

private sealed class ImageStorageEntity.<LoadImage>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8583
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public uint imageStorageEntityId; // 0x20
	public IImageReceiver receiver; // 0x28
	private RealTimeSince <sinceStart>5__2; // 0x30

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

