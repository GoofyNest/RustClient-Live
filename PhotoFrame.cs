public class PhotoFrame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6384
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint photoEntityId; // 0x14
	public uint overlayImageCrc; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1EA4660 Offset: 0x1EA3A60 VA: 0x181EA4660
	public static void ResetToPool(PhotoFrame instance) { }

	// RVA: 0x1EA4560 Offset: 0x1EA3960 VA: 0x181EA4560
	public void ResetToPool() { }

	// RVA: 0x1EA43B0 Offset: 0x1EA37B0 VA: 0x181EA43B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA31B0 Offset: 0x1EA25B0 VA: 0x181EA31B0
	public void CopyTo(PhotoFrame instance) { }

	// RVA: 0x1EA32D0 Offset: 0x1EA26D0 VA: 0x181EA32D0
	public PhotoFrame Copy() { }

	// RVA: 0x1EA4060 Offset: 0x1EA3460 VA: 0x181EA4060
	public static PhotoFrame Deserialize(Stream stream) { }

	// RVA: 0x1EA3440 Offset: 0x1EA2840 VA: 0x181EA3440
	public static PhotoFrame DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA37C0 Offset: 0x1EA2BC0 VA: 0x181EA37C0
	public static PhotoFrame DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA3B40 Offset: 0x1EA2F40 VA: 0x181EA3B40
	public static PhotoFrame Deserialize(byte[] buffer) { }

	// RVA: 0x1EA4520 Offset: 0x1EA3920 VA: 0x181EA4520
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA4CD0 Offset: 0x1EA40D0 VA: 0x181EA4CD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA4CF0 Offset: 0x1EA40F0 VA: 0x181EA4CF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhotoFrame previous) { }

	// RVA: 0x1EA4540 Offset: 0x1EA3940 VA: 0x181EA4540 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA42B0 Offset: 0x1EA36B0 VA: 0x181EA42B0
	public static PhotoFrame Deserialize(byte[] buffer, PhotoFrame instance, bool isDelta = False) { }

	// RVA: 0x1EA3E30 Offset: 0x1EA3230 VA: 0x181EA3E30
	public static PhotoFrame Deserialize(Stream stream, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EA34C0 Offset: 0x1EA28C0 VA: 0x181EA34C0
	public static PhotoFrame DeserializeLengthDelimited(Stream stream, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EA3850 Offset: 0x1EA2C50 VA: 0x181EA3850
	public static PhotoFrame DeserializeLength(Stream stream, int length, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EA4760 Offset: 0x1EA3B60 VA: 0x181EA4760
	public static void SerializeDelta(Stream stream, PhotoFrame instance, PhotoFrame previous) { }

	// RVA: 0x1EA4B10 Offset: 0x1EA3F10 VA: 0x181EA4B10
	public static void Serialize(Stream stream, PhotoFrame instance) { }

	// RVA: 0x1EA4CC0 Offset: 0x1EA40C0 VA: 0x181EA4CC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA4CD0 Offset: 0x1EA40D0 VA: 0x181EA4CD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA4A00 Offset: 0x1EA3E00 VA: 0x181EA4A00
	public static byte[] SerializeToBytes(PhotoFrame instance) { }

	// RVA: 0x1EA4950 Offset: 0x1EA3D50 VA: 0x181EA4950
	public static void SerializeLengthDelimited(Stream stream, PhotoFrame instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PhotoFrame : StorageContainer, ILOD, IImageReceiver, ISignage, IUGCBrowserEntity // TypeDefIndex: 8427
{	// Fields
	private Option __menuOption_Menu_ChangeText; // 0x3D0
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

	// Properties
	public override bool HasMenuOptions { get; }
	public Vector2i TextureSize { get; }
	public int TextureCount { get; }
	public uint NetworkID { get; }
	public FileStorage.Type FileType { get; }

	// Methods

	// RVA: 0x8CBF20 Offset: 0x8CB320 VA: 0x1808CBF20 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8CDD90 Offset: 0x8CD190 VA: 0x1808CDD90 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8CCCD0 Offset: 0x8CC0D0 VA: 0x1808CCCD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8CDFD0 Offset: 0x8CD3D0 VA: 0x1808CDFD0 Slot: 160
	public Vector2i get_TextureSize() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 161
	public int get_TextureCount() { }

	// RVA: 0x545FC0 Offset: 0x5453C0 VA: 0x180545FC0 Slot: 158
	public bool CanUpdateSign(BasePlayer player) { }

	// RVA: 0x8CB880 Offset: 0x8CAC80 VA: 0x1808CB880
	public bool CanUnlockSign(BasePlayer player) { }

	// RVA: 0x8CB7A0 Offset: 0x8CABA0 VA: 0x1808CB7A0
	public bool CanLockSign(BasePlayer player) { }

	// RVA: 0x8CD8B0 Offset: 0x8CCCB0 VA: 0x1808CD8B0
	private void RequestOverlayTexture() { }

	// RVA: 0x8CC870 Offset: 0x8CBC70 VA: 0x1808CC870
	private void LoadOverlayTexture(uint crc, byte[] data) { }

	// RVA: 0x8CB9C0 Offset: 0x8CADC0 VA: 0x1808CB9C0
	private void ClearOverlayTexture() { }

	// RVA: 0x8CBCB0 Offset: 0x8CB0B0 VA: 0x1808CBCB0
	private void FreeOverlayTexture() { }

	[BaseEntity.Menu] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	[BaseEntity.Menu.Icon] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	[BaseEntity.Menu.Description] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	// RVA: 0x8CC980 Offset: 0x8CBD80 VA: 0x1808CC980
	public void Menu_ChangeText(BasePlayer player) { }

	// RVA: 0x8CD290 Offset: 0x8CC690 VA: 0x1808CD290 Slot: 165
	public void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8CD660 Offset: 0x8CCA60 VA: 0x1808CD660
	public void RecieveOverlayTexture(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.Icon] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.Description] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	// RVA: 0x8CCB70 Offset: 0x8CBF70 VA: 0x1808CCB70
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.Icon] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.Description] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	// RVA: 0x8CCBB0 Offset: 0x8CBFB0 VA: 0x1808CCBB0
	public void Menu_UnLockSign(BasePlayer player) { }

	// RVA: 0x8CB920 Offset: 0x8CAD20 VA: 0x1808CB920 Slot: 122
	public override string Categorize() { }

	// RVA: 0x8CC910 Offset: 0x8CBD10 VA: 0x1808CC910 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8CC7C0 Offset: 0x8CBBC0 VA: 0x1808CC7C0 Slot: 162
	public uint[] GetTextureCRCs() { }

	// RVA: 0x548730 Offset: 0x547B30 VA: 0x180548730 Slot: 163
	public uint get_NetworkID() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 164
	public FileStorage.Type get_FileType() { }

	// RVA: 0x8CBA60 Offset: 0x8CAE60 VA: 0x1808CBA60 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x8CBAF0 Offset: 0x8CAEF0 VA: 0x1808CBAF0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x8CBB10 Offset: 0x8CAF10 VA: 0x1808CBB10 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x8CD400 Offset: 0x8CC800 VA: 0x1808CD400 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x8CC830 Offset: 0x8CBC30 VA: 0x1808CC830
	private bool IsWithinRenderDistance() { }

	// RVA: 0x8CD830 Offset: 0x8CCC30 VA: 0x1808CD830 Slot: 156
	public void RefreshLOD() { }

	// RVA: 0x8CB950 Offset: 0x8CAD50 VA: 0x1808CB950 Slot: 155
	public void ChangeLOD() { }

	// RVA: 0x8CD9F0 Offset: 0x8CCDF0 VA: 0x1808CD9F0
	private void UpdateTextures() { }

	// RVA: 0x8CBE80 Offset: 0x8CB280 VA: 0x1808CBE80
	private void FreeTextures() { }

	// RVA: 0x8CCBF0 Offset: 0x8CBFF0 VA: 0x1808CCBF0 Slot: 157
	public void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x8CBD40 Offset: 0x8CB140 VA: 0x1808CBD40
	private void FreePhotoTexture() { }

	// RVA: 0x8CD420 Offset: 0x8CC820 VA: 0x1808CD420
	public static void RebuildAll() { }

	// RVA: 0x8CB840 Offset: 0x8CAC40 VA: 0x1808CB840 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x8CDD30 Offset: 0x8CD130 VA: 0x1808CDD30
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8CD290 Offset: 0x8CC690 VA: 0x1808CD290
	private void <Menu_ChangeText>b__20_0(int frame, Texture2D texture) { }

}

