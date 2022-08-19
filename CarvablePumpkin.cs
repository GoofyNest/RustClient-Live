public class CarvablePumpkin : BaseOven, ILOD, ISignage, IUGCBrowserEntity // TypeDefIndex: 8371
{	// Fields
	private Option __menuOption_Menu_ChangeText; // 0x4E8
	private Option __menuOption_Menu_LockSign; // 0x540
	private Option __menuOption_Menu_UnLockSign; // 0x598
	private const float TextureRequestTimeout = 15;
	public GameObjectRef changeTextDialog; // 0x5F0
	public MeshPaintableSource[] paintableSources; // 0x5F8
	public uint[] textureIDs; // 0x600
	internal RealTimeSince[] timeSinceRequest; // 0x608
	internal uint[] loadedTextures; // 0x610
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float textureRequestDistance; // 0x0
	private bool textureRequestSent; // 0x618
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <withinTextureRange>k__BackingField; // 0x619
	private LODCell cell; // 0x620

	// Properties
	public override bool HasMenuOptions { get; }
	public Vector2i TextureSize { get; }
	public int TextureCount { get; }
	public FileStorage.Type FileType { get; }
	public uint NetworkID { get; }
	protected bool withinTextureRange { get; set; }

	// Methods

	// RVA: 0x5465D0 Offset: 0x5459D0 VA: 0x1805465D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x548560 Offset: 0x547960 VA: 0x180548560 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x547440 Offset: 0x546840 VA: 0x180547440 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x548770 Offset: 0x547B70 VA: 0x180548770 Slot: 161
	public Vector2i get_TextureSize() { }

	// RVA: 0x548750 Offset: 0x547B50 VA: 0x180548750 Slot: 162
	public int get_TextureCount() { }

	// RVA: 0x547C40 Offset: 0x547040 VA: 0x180547C40 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x5464C0 Offset: 0x5458C0 VA: 0x1805464C0
	private void FreeTexture() { }

	// RVA: 0x548180 Offset: 0x547580 VA: 0x180548180
	protected void RequestTextureUpdate() { }

	// RVA: 0x546DC0 Offset: 0x5461C0 VA: 0x180546DC0
	private void LoadTexture(int frame, uint id, byte[] data) { }

	[BaseEntity.Menu] // RVA: 0xD17F0 Offset: 0xD0BF0 VA: 0x1800D17F0
	[BaseEntity.Menu.Icon] // RVA: 0xD17F0 Offset: 0xD0BF0 VA: 0x1800D17F0
	[BaseEntity.Menu.Description] // RVA: 0xD17F0 Offset: 0xD0BF0 VA: 0x1800D17F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD17F0 Offset: 0xD0BF0 VA: 0x1800D17F0
	// RVA: 0x5472A0 Offset: 0x5466A0 VA: 0x1805472A0
	public void Menu_ChangeText(BasePlayer player) { }

	// RVA: 0x547890 Offset: 0x546C90 VA: 0x180547890 Slot: 167
	public virtual void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x547EE0 Offset: 0x5472E0 VA: 0x180547EE0
	public void RecieveTexture(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5463E0 Offset: 0x5457E0 VA: 0x1805463E0
	private void EnsureInitialized() { }

	[ConditionalAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x548480 Offset: 0x547880 VA: 0x180548480
	private static void SignDebugLog(string str) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 165
	public FileStorage.Type get_FileType() { }

	// RVA: 0x546DB0 Offset: 0x5461B0 VA: 0x180546DB0 Slot: 163
	public uint[] GetTextureCRCs() { }

	// RVA: 0x548730 Offset: 0x547B30 VA: 0x180548730 Slot: 164
	public uint get_NetworkID() { }

	// RVA: 0x545FC0 Offset: 0x5453C0 VA: 0x180545FC0 Slot: 168
	public virtual bool CanUpdateSign(BasePlayer player) { }

	// RVA: 0x545F70 Offset: 0x545370 VA: 0x180545F70
	public bool CanUnlockSign(BasePlayer player) { }

	// RVA: 0x545F20 Offset: 0x545320 VA: 0x180545F20
	public bool CanLockSign(BasePlayer player) { }

	// RVA: 0x547060 Offset: 0x546460 VA: 0x180547060 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x548830 Offset: 0x547C30 VA: 0x180548830
	protected bool get_withinTextureRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x548840 Offset: 0x547C40 VA: 0x180548840
	private void set_withinTextureRange(bool value) { }

	// RVA: 0x546180 Offset: 0x545580 VA: 0x180546180 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x546210 Offset: 0x545610 VA: 0x180546210 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x548100 Offset: 0x547500 VA: 0x180548100 Slot: 158
	public void RefreshLOD() { }

	// RVA: 0x546080 Offset: 0x545480 VA: 0x180546080 Slot: 157
	public void ChangeLOD() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 169
	protected virtual void OnEnterTextureRange() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 170
	protected virtual void OnExitTextureRange() { }

	[BaseEntity.Menu] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.Icon] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.Description] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	// RVA: 0x5473C0 Offset: 0x5467C0 VA: 0x1805473C0
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.Icon] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.Description] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	// RVA: 0x547400 Offset: 0x546800 VA: 0x180547400
	public void Menu_UnLockSign(BasePlayer player) { }

	// RVA: 0x547D20 Offset: 0x547120 VA: 0x180547D20
	public static void RebuildAll() { }

	// RVA: 0x546050 Offset: 0x545450 VA: 0x180546050 Slot: 122
	public override string Categorize() { }

	// RVA: 0x548550 Offset: 0x547950 VA: 0x180548550
	public void .ctor() { }

	// RVA: 0x548510 Offset: 0x547910 VA: 0x180548510
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5484E0 Offset: 0x5478E0 VA: 0x1805484E0
	private void <Menu_ChangeText>b__21_0(int i, Texture2D x) { }

}

