public class PaintedItemStorageEntity : BaseEntity, IServerFileReceiver, IUGCBrowserEntity // TypeDefIndex: 10336
{
	private uint _currentImageCrc;
	public List<PaintableItem> Targets;
	private uint _loadingCrc;
	private byte[] _loadedImage;
	private uint _loadedImageCrc;
	private Action _timeoutAction;


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

	[ConditionalAttribute]
	private void DebugOnlyLog(string str) { }

	public void .ctor() { }

}

private sealed class PaintedItemStorageEntity.<>c // TypeDefIndex: 10337
{
	public static readonly PaintedItemStorageEntity.<>c <>9;
	public static Predicate<PaintableItem> <>9__16_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <RemoveInvalidTargets>

}

