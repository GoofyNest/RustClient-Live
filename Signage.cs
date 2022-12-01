public class Signage : IOEntity, ILOD, ISignage, IUGCBrowserEntity // TypeDefIndex: 10165
{
	private Option __menuOption_Menu_ChangeText;
	private Option __menuOption_Menu_LockSign;
	private Option __menuOption_Menu_UnLockSign;
	private const float TextureRequestTimeout = 15;
	public GameObjectRef changeTextDialog;
	public MeshPaintableSource[] paintableSources;
	public uint[] textureIDs;
	internal RealTimeSince[] timeSinceRequest;
	internal uint[] loadedTextures;
	public ItemDefinition RequiredHeldEntity;
	[ClientVar]
	public static float textureRequestDistance;
	private bool textureRequestSent;
	[CompilerGeneratedAttribute]
	private bool <withinTextureRange>k__BackingField;
	private LODCell cell;

	public override bool HasMenuOptions { get; }
	public Vector2i TextureSize { get; }
	public int TextureCount { get; }
	protected bool withinTextureRange { get; set; }
	public uint NetworkID { get; }
	public FileStorage.Type FileType { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Vector2i get_TextureSize() { }

	public int get_TextureCount() { }

	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	private void FreeTexture() { }

	protected void RequestTextureUpdate() { }

	private void LoadTexture(int frame, uint id, byte[] data) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.ShowIf]
	public void Menu_ChangeText(BasePlayer player) { }

	public virtual void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client]
	public void RecieveTexture(BaseEntity.RPCMessage msg) { }

	private void EnsureInitialized() { }

	[ConditionalAttribute]
	private static void SignDebugLog(string str) { }

	public virtual bool CanUpdateSign(BasePlayer player) { }

	public bool CanUnlockSign(BasePlayer player) { }

	public bool CanLockSign(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private bool HeldEntityCheck(BasePlayer player) { }

	[CompilerGeneratedAttribute]
	protected bool get_withinTextureRange() { }

	[CompilerGeneratedAttribute]
	private void set_withinTextureRange(bool value) { }

	protected override void ClientInit(Entity info) { }

	protected override void DoClientDestroy() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	protected virtual void OnEnterTextureRange() { }

	protected virtual void OnExitTextureRange() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.ShowIf]
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.ShowIf]
	public void Menu_UnLockSign(BasePlayer player) { }

	public static void RebuildAll() { }

	public uint[] GetTextureCRCs() { }

	public uint get_NetworkID() { }

	public FileStorage.Type get_FileType() { }

	public override int ConsumptionAmount() { }

	public override string Categorize() { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute]
	private void <Menu_ChangeText>

}

