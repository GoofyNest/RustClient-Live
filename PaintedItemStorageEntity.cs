public class PaintedItemStorageEntity : BaseEntity, IServerFileReceiver, IUGCBrowserEntity // TypeDefIndex: 8612
{	private uint _currentImageCrc; // 0x168
	public List<PaintableItem> Targets; // 0x170
	private uint _loadingCrc; // 0x178
	private byte[] _loadedImage; // 0x180
	private uint _loadedImageCrc; // 0x188
	private Action _timeoutAction; // 0x190


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void Setup(PaintableItem target) { }

	public void UpdateImage(Texture2D texture) { }

	public bool TryGetImageData(out byte[] data) { }

	protected override void DoClientDestroy() { }

	private void LoadImage() { }

	private void RequestImage() { }

	private void RequestTimedOut() { }

	private void IServerFileReceiver.OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data) { }

	private void RemoveInvalidTargets() { }

	public static void RebuildAll() { }

	[ConditionalAttribute] // RVA: 0xB2360 Offset: 0xB1760 VA: 0x1800B2360
	private void DebugOnlyLog(string str) { }

	public void .ctor() { }

}

private sealed class PaintedItemStorageEntity.<>c // TypeDefIndex: 8613
{	public static readonly PaintedItemStorageEntity.<>c <>9; // 0x0
	public static Predicate<PaintableItem> <>9__16_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <RemoveInvalidTargets>b__16_0(PaintableItem t) { }

}

