public class Signage : IOEntity, ILOD, ISignage, IUGCBrowserEntity // TypeDefIndex: 8445
{	// Fields
	private Option __menuOption_Menu_ChangeText; // 0x288
	private Option __menuOption_Menu_LockSign; // 0x2E0
	private Option __menuOption_Menu_UnLockSign; // 0x338
	private const float TextureRequestTimeout = 15;
	public GameObjectRef changeTextDialog; // 0x390
	public MeshPaintableSource[] paintableSources; // 0x398
	public uint[] textureIDs; // 0x3A0
	internal RealTimeSince[] timeSinceRequest; // 0x3A8
	internal uint[] loadedTextures; // 0x3B0
	public ItemDefinition RequiredHeldEntity; // 0x3B8
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float textureRequestDistance; // 0x0
	private bool textureRequestSent; // 0x3C0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <withinTextureRange>k__BackingField; // 0x3C1
	private LODCell cell; // 0x3C8

	// Properties
	public override bool HasMenuOptions { get; }
	public Vector2i TextureSize { get; }
	public int TextureCount { get; }
	protected bool withinTextureRange { get; set; }
	public uint NetworkID { get; }
	public FileStorage.Type FileType { get; }

	// Methods

	// RVA: 0x5B4930 Offset: 0x5B3D30 VA: 0x1805B4930 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5B6B30 Offset: 0x5B5F30 VA: 0x1805B6B30 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5B5910 Offset: 0x5B4D10 VA: 0x1805B5910 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5B6D20 Offset: 0x5B6120 VA: 0x1805B6D20 Slot: 163
	public Vector2i get_TextureSize() { }

	// RVA: 0x5B6D00 Offset: 0x5B6100 VA: 0x1805B6D00 Slot: 164
	public int get_TextureCount() { }

	// RVA: 0x5B6110 Offset: 0x5B5510 VA: 0x1805B6110 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x5B4820 Offset: 0x5B3C20 VA: 0x1805B4820
	private void FreeTexture() { }

	// RVA: 0x5B6700 Offset: 0x5B5B00 VA: 0x1805B6700
	protected void RequestTextureUpdate() { }

	// RVA: 0x5B5290 Offset: 0x5B4690 VA: 0x1805B5290
	private void LoadTexture(int frame, uint id, byte[] data) { }

	[BaseEntity.Menu] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	[BaseEntity.Menu.Icon] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	[BaseEntity.Menu.Description] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C080 Offset: 0x7B480 VA: 0x18007C080
	// RVA: 0x5B5770 Offset: 0x5B4B70 VA: 0x1805B5770
	public void Menu_ChangeText(BasePlayer player) { }

	// RVA: 0x5B5D60 Offset: 0x5B5160 VA: 0x1805B5D60 Slot: 169
	public virtual void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B6460 Offset: 0x5B5860 VA: 0x1805B6460
	public void RecieveTexture(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5B4740 Offset: 0x5B3B40 VA: 0x1805B4740
	private void EnsureInitialized() { }

	[ConditionalAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: 0x5B6A00 Offset: 0x5B5E00 VA: 0x1805B6A00
	private static void SignDebugLog(string str) { }

	// RVA: 0x5B4310 Offset: 0x5B3710 VA: 0x1805B4310 Slot: 170
	public virtual bool CanUpdateSign(BasePlayer player) { }

	// RVA: 0x5B42B0 Offset: 0x5B36B0 VA: 0x1805B42B0
	public bool CanUnlockSign(BasePlayer player) { }

	// RVA: 0x5B4250 Offset: 0x5B3650 VA: 0x1805B4250
	public bool CanLockSign(BasePlayer player) { }

	// RVA: 0x5B5530 Offset: 0x5B4930 VA: 0x1805B5530 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5B5150 Offset: 0x5B4550 VA: 0x1805B5150
	private bool HeldEntityCheck(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B6DE0 Offset: 0x5B61E0 VA: 0x1805B6DE0
	protected bool get_withinTextureRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B6DF0 Offset: 0x5B61F0 VA: 0x1805B6DF0
	private void set_withinTextureRange(bool value) { }

	// RVA: 0x5B44E0 Offset: 0x5B38E0 VA: 0x1805B44E0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5B4570 Offset: 0x5B3970 VA: 0x1805B4570 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x5B6680 Offset: 0x5B5A80 VA: 0x1805B6680 Slot: 160
	public void RefreshLOD() { }

	// RVA: 0x5B43E0 Offset: 0x5B37E0 VA: 0x1805B43E0 Slot: 159
	public void ChangeLOD() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 171
	protected virtual void OnEnterTextureRange() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 172
	protected virtual void OnExitTextureRange() { }

	[BaseEntity.Menu] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.Icon] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.Description] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C360 Offset: 0x7B760 VA: 0x18007C360
	// RVA: 0x5B5890 Offset: 0x5B4C90 VA: 0x1805B5890
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.Icon] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.Description] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C5F0 Offset: 0x7B9F0 VA: 0x18007C5F0
	// RVA: 0x5B58D0 Offset: 0x5B4CD0 VA: 0x1805B58D0
	public void Menu_UnLockSign(BasePlayer player) { }

	// RVA: 0x5B61F0 Offset: 0x5B55F0 VA: 0x1805B61F0
	public static void RebuildAll() { }

	// RVA: 0x5B5140 Offset: 0x5B4540 VA: 0x1805B5140 Slot: 165
	public uint[] GetTextureCRCs() { }

	// RVA: 0x548730 Offset: 0x547B30 VA: 0x180548730 Slot: 166
	public uint get_NetworkID() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 167
	public FileStorage.Type get_FileType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x5B43B0 Offset: 0x5B37B0 VA: 0x1805B43B0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x5B6AD0 Offset: 0x5B5ED0 VA: 0x1805B6AD0
	public void .ctor() { }

	// RVA: 0x5B6A90 Offset: 0x5B5E90 VA: 0x1805B6A90
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B6A60 Offset: 0x5B5E60 VA: 0x1805B6A60
	private void <Menu_ChangeText>b__21_0(int i, Texture2D x) { }

}

