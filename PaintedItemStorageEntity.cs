public class PaintedItemStorageEntity : BaseEntity, IServerFileReceiver, IUGCBrowserEntity // TypeDefIndex: 8612
{	// Fields
	private uint _currentImageCrc; // 0x168
	public List<PaintableItem> Targets; // 0x170
	private uint _loadingCrc; // 0x178
	private byte[] _loadedImage; // 0x180
	private uint _loadedImageCrc; // 0x188
	private Action _timeoutAction; // 0x190

	// Methods

	// RVA: 0x937B60 Offset: 0x936F60 VA: 0x180937B60 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x937AD0 Offset: 0x936ED0 VA: 0x180937AD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x938140 Offset: 0x937540 VA: 0x180938140
	public void Setup(PaintableItem target) { }

	// RVA: 0x9382D0 Offset: 0x9376D0 VA: 0x1809382D0
	public void UpdateImage(Texture2D texture) { }

	// RVA: 0x938260 Offset: 0x937660 VA: 0x180938260
	public bool TryGetImageData(out byte[] data) { }

	// RVA: 0x937510 Offset: 0x936910 VA: 0x180937510 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x937760 Offset: 0x936B60 VA: 0x180937760
	private void LoadImage() { }

	// RVA: 0x937FE0 Offset: 0x9373E0 VA: 0x180937FE0
	private void RequestImage() { }

	// RVA: 0x9380C0 Offset: 0x9374C0 VA: 0x1809380C0
	private void RequestTimedOut() { }

	// RVA: 0x937590 Offset: 0x936990 VA: 0x180937590 Slot: 131
	private void IServerFileReceiver.OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data) { }

	// RVA: 0x937ED0 Offset: 0x9372D0 VA: 0x180937ED0
	private void RemoveInvalidTargets() { }

	// RVA: 0x937C50 Offset: 0x937050 VA: 0x180937C50
	public static void RebuildAll() { }

	[ConditionalAttribute] // RVA: 0xB2360 Offset: 0xB1760 VA: 0x1800B2360
	// RVA: 0x9374A0 Offset: 0x9368A0 VA: 0x1809374A0
	private void DebugOnlyLog(string str) { }

	// RVA: 0x938590 Offset: 0x937990 VA: 0x180938590
	public void .ctor() { }

}

private sealed class PaintedItemStorageEntity.<>c // TypeDefIndex: 8613
{	// Fields
	public static readonly PaintedItemStorageEntity.<>c <>9; // 0x0
	public static Predicate<PaintableItem> <>9__16_0; // 0x8

	// Methods

	// RVA: 0x952620 Offset: 0x951A20 VA: 0x180952620
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x951AB0 Offset: 0x950EB0 VA: 0x180951AB0
	internal bool <RemoveInvalidTargets>b__16_0(PaintableItem t) { }

}

