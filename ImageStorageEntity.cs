public class ImageStorageEntity : BaseEntity // TypeDefIndex: 8580
{	// Fields
	private List<ImageStorageEntity.ImageRequest> _requests; // 0x168

	// Properties
	protected virtual FileStorage.Type StorageType { get; }
	protected virtual uint CrcToLoad { get; }

	// Methods

	// RVA: 0x80CA10 Offset: 0x80BE10 VA: 0x18080CA10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 131
	protected virtual FileStorage.Type get_StorageType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 132
	protected virtual uint get_CrcToLoad() { }

	// RVA: 0x80CEC0 Offset: 0x80C2C0 VA: 0x18080CEC0
	private void RequestImage(IImageReceiver receiver) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x80CE70 Offset: 0x80C270 VA: 0x18080CE70
	private void ReceiveImage(BaseEntity.RPCMessage msg) { }

	// RVA: 0x80C660 Offset: 0x80BA60 VA: 0x18080C660
	private void LoadFromBytes(byte[] imageData) { }

	[IteratorStateMachineAttribute] // RVA: 0xABE50 Offset: 0xAB250 VA: 0x1800ABE50
	// RVA: 0x80C990 Offset: 0x80BD90 VA: 0x18080C990
	public static IEnumerator LoadImage(uint imageStorageEntityId, IImageReceiver receiver) { }

	// RVA: 0x80D2B0 Offset: 0x80C6B0 VA: 0x18080D2B0
	public void .ctor() { }

}

private struct ImageStorageEntity.ImageRequest // TypeDefIndex: 8581
{	// Fields
	public IImageReceiver Receiver; // 0x0
	public float Time; // 0x8

}

private sealed class ImageStorageEntity.<>c // TypeDefIndex: 8582
{	// Fields
	public static readonly ImageStorageEntity.<>c <>9; // 0x0
	public static Predicate<ImageStorageEntity.ImageRequest> <>9__7_0; // 0x8
	public static Func<ImageStorageEntity.ImageRequest, IImageReceiver> <>9__7_1; // 0x10

	// Methods

	// RVA: 0x81F8A0 Offset: 0x81ECA0 VA: 0x18081F8A0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x81E440 Offset: 0x81D840 VA: 0x18081E440
	internal bool <RequestImage>b__7_0(ImageStorageEntity.ImageRequest r) { }

	// RVA: 0x81E4B0 Offset: 0x81D8B0 VA: 0x18081E4B0
	internal IImageReceiver <RequestImage>b__7_1(ImageStorageEntity.ImageRequest r) { }

}

private sealed class ImageStorageEntity.<LoadImage>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8583
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public uint imageStorageEntityId; // 0x20
	public IImageReceiver receiver; // 0x28
	private RealTimeSince <sinceStart>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x81DFC0 Offset: 0x81D3C0 VA: 0x18081DFC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81E170 Offset: 0x81D570 VA: 0x18081E170 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

