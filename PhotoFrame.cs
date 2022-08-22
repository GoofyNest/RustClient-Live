public class PhotoFrame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6384
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint photoEntityId; // 0x14
	public uint overlayImageCrc; // 0x18
	public List<ulong> editHistory; // 0x20


	public static void ResetToPool(PhotoFrame instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PhotoFrame instance) { }

	public PhotoFrame Copy() { }

	public static PhotoFrame Deserialize(Stream stream) { }

	public static PhotoFrame DeserializeLengthDelimited(Stream stream) { }

	public static PhotoFrame DeserializeLength(Stream stream, int length) { }

	public static PhotoFrame Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PhotoFrame previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PhotoFrame Deserialize(byte[] buffer, PhotoFrame instance, bool isDelta = False) { }

	public static PhotoFrame Deserialize(Stream stream, PhotoFrame instance, bool isDelta) { }

	public static PhotoFrame DeserializeLengthDelimited(Stream stream, PhotoFrame instance, bool isDelta) { }

	public static PhotoFrame DeserializeLength(Stream stream, int length, PhotoFrame instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PhotoFrame instance, PhotoFrame previous) { }

	public static void Serialize(Stream stream, PhotoFrame instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PhotoFrame instance) { }

	public static void SerializeLengthDelimited(Stream stream, PhotoFrame instance) { }

	public void .ctor() { }

}

public class PhotoFrame : StorageContainer, ILOD, IImageReceiver, ISignage, IUGCBrowserEntity // TypeDefIndex: 8427
{	private Option __menuOption_Menu_ChangeText; // 0x3D0
	private Option __menuOption_Menu_LockSign; // 0x428
	private Option __menuOption_Menu_UnLockSign; // 0x480
	public GameObjectRef SignEditorDialog; // 0x4D8
	public OverlayMeshPaintableSource PaintableSource; // 0x4E0
	private const float TextureRequestDistance = 100;
	private EntityRef _photoEntity; // 0x4E8
	private uint _overlayTextureCrc; // 0x4F8
	private LODCell _cell; // 0x500
	private Texture2D _photoTexture; // 0x508
	private uint _loadedPhotoEntityId; // 0x510
	private uint _loadedOverlayCrc; // 0x514

	public override bool HasMenuOptions { get; }
	public Vector2i TextureSize { get; }
	public int TextureCount { get; }
	public uint NetworkID { get; }
	public FileStorage.Type FileType { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Vector2i get_TextureSize() { }

	public int get_TextureCount() { }

	public bool CanUpdateSign(BasePlayer player) { }

	public bool CanUnlockSign(BasePlayer player) { }

	public bool CanLockSign(BasePlayer player) { }

	private void RequestOverlayTexture() { }

	private void LoadOverlayTexture(uint crc, byte[] data) { }

	private void ClearOverlayTexture() { }

	private void FreeOverlayTexture() { }

	[BaseEntity.Menu] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	[BaseEntity.Menu.Icon] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	[BaseEntity.Menu.Description] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	public void Menu_ChangeText(BasePlayer player) { }

	public void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void RecieveOverlayTexture(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.Icon] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.Description] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.Icon] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.Description] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	public void Menu_UnLockSign(BasePlayer player) { }

	public override string Categorize() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public uint[] GetTextureCRCs() { }

	public uint get_NetworkID() { }

	public FileStorage.Type get_FileType() { }

	protected override void ClientInit(Entity info) { }

	public override void ClientOnEnable() { }

	protected override void DoClientDestroy() { }

	public override void PostNetworkUpdate() { }

	private bool IsWithinRenderDistance() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	private void UpdateTextures() { }

	private void FreeTextures() { }

	public void OnImageLoaded(Texture2D texture) { }

	private void FreePhotoTexture() { }

	public static void RebuildAll() { }

	public override bool CanPickup(BasePlayer player) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Menu_ChangeText>b__20_0(int frame, Texture2D texture) { }

}

