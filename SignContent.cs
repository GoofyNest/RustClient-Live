public class SignContent : ImageStorageEntity, IUGCBrowserEntity // TypeDefIndex: 9516
{	// Fields
	private uint[] textureIDs; // 0x170
	private List<ulong> editHistory; // 0x178

	// Properties
	protected override uint CrcToLoad { get; }
	protected override FileStorage.Type StorageType { get; }

	// Methods

	// RVA: 0x5B3C70 Offset: 0x5B3070 VA: 0x1805B3C70 Slot: 132
	protected override uint get_CrcToLoad() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 131
	protected override FileStorage.Type get_StorageType() { }

	// RVA: 0x5B3BE0 Offset: 0x5B2FE0 VA: 0x1805B3BE0
	public void .ctor() { }

}

