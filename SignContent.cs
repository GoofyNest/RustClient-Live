public class SignContent : ImageStorageEntity, IUGCBrowserEntity // TypeDefIndex: 9516
{	private uint[] textureIDs; // 0x170
	private List<ulong> editHistory; // 0x178

	protected override uint CrcToLoad { get; }
	protected override FileStorage.Type StorageType { get; }


	protected override uint get_CrcToLoad() { }

	protected override FileStorage.Type get_StorageType() { }

	public void .ctor() { }

}

