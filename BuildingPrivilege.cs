public class BuildInfo // TypeDefIndex: 6169
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Date>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BuildInfo.ScmInfo <Scm>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BuildInfo.BuildDesc <Build>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Valid>k__BackingField; // 0x28
	private static BuildInfo _current; // 0x0

	public int Date { get; set; }
	[JsonIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public DateTime BuildDate { get; }
	public BuildInfo.ScmInfo Scm { get; set; }
	public BuildInfo.BuildDesc Build { get; set; }
	public bool Valid { get; set; }
	public static BuildInfo Current { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Date(int value) { }

	public DateTime get_BuildDate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public BuildInfo.ScmInfo get_Scm() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Scm(BuildInfo.ScmInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public BuildInfo.BuildDesc get_Build() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Build(BuildInfo.BuildDesc value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_Valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Valid(bool value) { }

	public static BuildInfo get_Current() { }

	public void .ctor() { }

}

public class BuildInfo.ScmInfo // TypeDefIndex: 6170
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <ChangeId>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Branch>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Repo>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Comment>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Author>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Date>k__BackingField; // 0x40

	public string Type { get; set; }
	public string ChangeId { get; set; }
	public string Branch { get; set; }
	public string Repo { get; set; }
	public string Comment { get; set; }
	public string Author { get; set; }
	public string Date { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Type(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_ChangeId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_ChangeId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Branch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Branch(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Repo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Repo(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Comment(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Author() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Author(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Date(string value) { }

	public void .ctor() { }

}

public class BuildInfo.BuildDesc // TypeDefIndex: 6171
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Id>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Number>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Tag>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Url>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Node>k__BackingField; // 0x38

	public string Id { get; set; }
	public string Number { get; set; }
	public string Tag { get; set; }
	public string Url { get; set; }
	public string Name { get; set; }
	public string Node { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Id(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Number() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Number(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Tag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Tag(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Url() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Url(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Node() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Node(string value) { }

	public void .ctor() { }

}

public class BuildingBlock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6303
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int model; // 0x14
	public int grade; // 0x18
	public bool beingDemolished; // 0x1C


	public static void ResetToPool(BuildingBlock instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BuildingBlock instance) { }

	public BuildingBlock Copy() { }

	public static BuildingBlock Deserialize(Stream stream) { }

	public static BuildingBlock DeserializeLengthDelimited(Stream stream) { }

	public static BuildingBlock DeserializeLength(Stream stream, int length) { }

	public static BuildingBlock Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BuildingBlock previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BuildingBlock Deserialize(byte[] buffer, BuildingBlock instance, bool isDelta = False) { }

	public static BuildingBlock Deserialize(Stream stream, BuildingBlock instance, bool isDelta) { }

	public static BuildingBlock DeserializeLengthDelimited(Stream stream, BuildingBlock instance, bool isDelta) { }

	public static BuildingBlock DeserializeLength(Stream stream, int length, BuildingBlock instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BuildingBlock instance, BuildingBlock previous) { }

	public static void Serialize(Stream stream, BuildingBlock instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BuildingBlock instance) { }

	public static void SerializeLengthDelimited(Stream stream, BuildingBlock instance) { }

	public void .ctor() { }

}

public class BuildingPrivilege : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6310
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PlayerNameID> users; // 0x18
	public float upkeepPeriodMinutes; // 0x20
	public float costFraction; // 0x24
	public float protectedMinutes; // 0x28


	public static void ResetToPool(BuildingPrivilege instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BuildingPrivilege instance) { }

	public BuildingPrivilege Copy() { }

	public static BuildingPrivilege Deserialize(Stream stream) { }

	public static BuildingPrivilege DeserializeLengthDelimited(Stream stream) { }

	public static BuildingPrivilege DeserializeLength(Stream stream, int length) { }

	public static BuildingPrivilege Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BuildingPrivilege previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BuildingPrivilege Deserialize(byte[] buffer, BuildingPrivilege instance, bool isDelta = False) { }

	public static BuildingPrivilege Deserialize(Stream stream, BuildingPrivilege instance, bool isDelta) { }

	public static BuildingPrivilege DeserializeLengthDelimited(Stream stream, BuildingPrivilege instance, bool isDelta) { }

	public static BuildingPrivilege DeserializeLength(Stream stream, int length, BuildingPrivilege instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BuildingPrivilege instance, BuildingPrivilege previous) { }

	public static void Serialize(Stream stream, BuildingPrivilege instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BuildingPrivilege instance) { }

	public static void SerializeLengthDelimited(Stream stream, BuildingPrivilege instance) { }

	public void .ctor() { }

}

public class BuildingPrivlidge : StorageContainer // TypeDefIndex: 8363
{	private Option __menuOption_Menu_MaxAuth; // 0x3D0
	private Option __menuOption_Menu_RotateVM; // 0x428
	private Option __menuOption_MenuAuthorize; // 0x480
	private Option __menuOption_MenuClearList; // 0x4D8
	private Option __menuOption_MenuDeauthorize; // 0x530
	private float cachedProtectedMinutes; // 0x588
	private float cachedUpkeepPeriodMinutes; // 0x58C
	private float cachedUpkeepCostFraction; // 0x590
	public List<PlayerNameID> authorizedPlayers; // 0x598
	public const BaseEntity.Flags Flag_MaxAuths = 2048;
	public List<ItemDefinition> allowedConstructionItems; // 0x5A0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public float CalculateUpkeepPeriodMinutes() { }

	public float CalculateUpkeepCostFraction() { }

	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts) { }

	public float GetProtectedMinutes(bool force = False) { }

	public override void ResetState() { }

	public bool IsAuthed(BasePlayer player) { }

	public bool IsAuthed(ulong userID) { }

	public bool AnyAuthed() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void BuildingDirty() { }

	[BaseEntity.Menu] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	[BaseEntity.Menu.Description] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	[BaseEntity.Menu.Icon] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	[BaseEntity.Menu.ShowIf] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	public void Menu_MaxAuth(BasePlayer player) { }

	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCDD40 Offset: 0xCD140 VA: 0x1800CDD40
	[BaseEntity.Menu.Description] // RVA: 0xCDD40 Offset: 0xCD140 VA: 0x1800CDD40
	[BaseEntity.Menu.Icon] // RVA: 0xCDD40 Offset: 0xCD140 VA: 0x1800CDD40
	[BaseEntity.Menu.ShowIf] // RVA: 0xCDD40 Offset: 0xCD140 VA: 0x1800CDD40
	public void MenuAuthorize(BasePlayer player) { }

	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCE0D0 Offset: 0xCD4D0 VA: 0x1800CE0D0
	[BaseEntity.Menu.Description] // RVA: 0xCE0D0 Offset: 0xCD4D0 VA: 0x1800CE0D0
	[BaseEntity.Menu.Icon] // RVA: 0xCE0D0 Offset: 0xCD4D0 VA: 0x1800CE0D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCE0D0 Offset: 0xCD4D0 VA: 0x1800CE0D0
	public void MenuDeauthorize(BasePlayer player) { }

	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCF730 Offset: 0xCEB30 VA: 0x1800CF730
	[BaseEntity.Menu.Description] // RVA: 0xCF730 Offset: 0xCEB30 VA: 0x1800CF730
	[BaseEntity.Menu.Icon] // RVA: 0xCF730 Offset: 0xCEB30 VA: 0x1800CF730
	[BaseEntity.Menu.ShowIf] // RVA: 0xCF730 Offset: 0xCEB30 VA: 0x1800CF730
	public void MenuClearList(BasePlayer player) { }

	public bool MenuClearList_ShowIf(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xCF920 Offset: 0xCED20 VA: 0x1800CF920
	[BaseEntity.Menu.Description] // RVA: 0xCF920 Offset: 0xCED20 VA: 0x1800CF920
	[BaseEntity.Menu.Icon] // RVA: 0xCF920 Offset: 0xCED20 VA: 0x1800CF920
	[BaseEntity.Menu.ShowIf] // RVA: 0xCF920 Offset: 0xCED20 VA: 0x1800CF920
	public void Menu_RotateVM(BasePlayer player) { }

	public bool Menu_RotateTC_ShowIf(BasePlayer player) { }

	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	public override bool HasSlot(BaseEntity.Slot slot) { }

	public void .ctor() { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass20_0 // TypeDefIndex: 8364
{	public BasePlayer player; // 0x10


	public void .ctor() { }

	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass21_0 // TypeDefIndex: 8365
{	public ulong userID; // 0x10


	public void .ctor() { }

	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

public class BuildingBlock : StabilityEntity // TypeDefIndex: 8538
{	private bool forceSkinRefresh; // 0x268
	private int modelState; // 0x26C
	private int lastModelState; // 0x270
	public BuildingGrade.Enum grade; // 0x274
	private BuildingGrade.Enum lastGrade; // 0x278
	private ConstructionSkin currentSkin; // 0x280
	private DeferredAction skinChange; // 0x288
	private MeshRenderer placeholderRenderer; // 0x290
	private MeshCollider placeholderCollider; // 0x298
	private static Material HighlightMaterial; // 0x0
	public static BuildingBlock.UpdateSkinWorkQueue updateSkinQueueClient; // 0x8
	public bool CullBushes; // 0x2A0
	public Construction blockDefinition; // 0x2A8
	private static Vector3[] outsideLookupOffsets; // 0x10

	public ConstructionGrade currentGrade { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	public override void PostNetworkUpdate() { }

	public List<Option> GetBuildMenu(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void RefreshSkin(BaseEntity.RPCMessage msg) { }

	protected override void SpawnGibs() { }

	public override bool ShouldLerp() { }

	public override bool NeedsCrosshair() { }

	private bool CanDemolish(BasePlayer player) { }

	private bool IsDemolishable() { }

	private bool HasDemolishPrivilege(BasePlayer player) { }

	private void Demolish(BasePlayer player) { }

	private void DemolishOptions(ref List<Option> options, BasePlayer player) { }

	public void SetConditionalModel(int state) { }

	public bool GetConditionalModel(int index) { }

	public ConstructionGrade get_currentGrade() { }

	private ConstructionGrade GetGrade(BuildingGrade.Enum iGrade) { }

	private bool CanChangeToGrade(BuildingGrade.Enum iGrade, BasePlayer player) { }

	private bool HasUpgradePrivilege(BuildingGrade.Enum iGrade, BasePlayer player) { }

	private bool IsUpgradeBlocked() { }

	private bool CanAffordUpgrade(BuildingGrade.Enum iGrade, BasePlayer player) { }

	public void SetGrade(BuildingGrade.Enum iGradeID) { }

	private void UpdateGrade() { }

	private void UpgradeToGrade(BuildingGrade.Enum i, BasePlayer player) { }

	private void GradeChangingOptions(ref List<Option> options, BasePlayer player) { }

	private bool NeedsSkinChange() { }

	public void UpdateSkin(bool force = False) { }

	private void DestroySkin() { }

	private void UpdatePlaceholder(bool state) { }

	private void ChangeSkin() { }

	private void ChangeSkin(GameObjectRef prefab) { }

	public override bool ShouldBlockProjectiles() { }

	public override float MaxHealth() { }

	public override List<ItemAmount> BuildCost() { }

	public void DrawHighlight() { }

	public void Highlight(MeshRenderer renderer) { }

	private bool CanRotate(BasePlayer player) { }

	private bool IsRotatable() { }

	private bool IsRotationBlocked() { }

	private bool HasRotationPrivilege(BasePlayer player) { }

	private void Rotation(BasePlayer player) { }

	private void RotationOptions(ref List<Option> options, BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void ResetState() { }

	public override void InitShared() { }

	public override void PostInitShared() { }

	public override void DestroyShared() { }

	public override string Categorize() { }

	public override float BoundsPadding() { }

	public override bool IsOutside() { }

	public override bool SupportsChildDeployables() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public static class BuildingBlock.BlockFlags // TypeDefIndex: 8539
{	public const BaseEntity.Flags CanRotate = 128;
	public const BaseEntity.Flags CanDemolish = 256;

}

public class BuildingBlock.UpdateSkinWorkQueue : ObjectWorkQueue<BuildingBlock> // TypeDefIndex: 8540
{
	protected override void RunJob(BuildingBlock entity) { }

	protected override bool ShouldAdd(BuildingBlock entity) { }

	public void .ctor() { }

}

private sealed class BuildingBlock.<>c__DisplayClass31_0 // TypeDefIndex: 8541
{	public BuildingGrade.Enum iNewGrade; // 0x10
	public BuildingBlock <>4__this; // 0x18


	public void .ctor() { }

	internal void <GradeChangingOptions>b__0(BasePlayer ply) { }

}

public class BuildingProximity : PrefabAttribute // TypeDefIndex: 9049
{	private const float check_radius = 2;
	private const float check_forgiveness = 0,01;
	private const float foundation_width = 3;
	private const float foundation_extents = 1,5;


	public static bool Check(BasePlayer player, Construction construction, Vector3 position, Quaternion rotation) { }

	private static BuildingProximity.ProximityInfo GetProximity(Construction construction1, Vector3 position1, Quaternion rotation1, Construction construction2, Vector3 position2, Quaternion rotation2) { }

	public Vector3 GetSelectPivot(Vector3 position, Quaternion rotation) { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

private struct BuildingProximity.ProximityInfo // TypeDefIndex: 9050
{	public bool hit; // 0x0
	public bool connection; // 0x1
	public Line line; // 0x4
	public float sqrDist; // 0x1C

}

public class BuildingBlockDecay : Decay // TypeDefIndex: 9525
{
	public void .ctor() { }

}

public class BuildingGradeDecay : Decay // TypeDefIndex: 9526
{	public BuildingGrade.Enum decayGrade; // 0x98


	public void .ctor() { }

}

public abstract class BuildingManager // TypeDefIndex: 9825
{	public static ClientBuildingManager client; // 0x0
	protected ListHashSet<DecayEntity> decayEntities; // 0x10
	protected ListDictionary<uint, BuildingManager.Building> buildingDictionary; // 0x18


	public BuildingManager.Building GetBuilding(uint buildingID) { }

	public void Add(DecayEntity ent) { }

	public void Remove(DecayEntity ent) { }

	public void Clear() { }

	protected abstract BuildingManager.Building CreateBuilding(uint id);

	protected abstract void DisposeBuilding(ref BuildingManager.Building building);

	protected void .ctor() { }

	private static void .cctor() { }

}

public class BuildingManager.Building // TypeDefIndex: 9826
{	public uint ID; // 0x10
	public ListHashSet<BuildingPrivlidge> buildingPrivileges; // 0x18
	public ListHashSet<BuildingBlock> buildingBlocks; // 0x20
	public ListHashSet<DecayEntity> decayEntities; // 0x28
	public NavMeshObstacle buildingNavMeshObstacle; // 0x30
	public ListHashSet<NavMeshObstacle> navmeshCarvers; // 0x38
	public bool isNavMeshCarvingDirty; // 0x40
	public bool isNavMeshCarveOptimized; // 0x41


	public bool IsEmpty() { }

	public BuildingPrivlidge GetDominatingBuildingPrivilege() { }

	public bool HasBuildingPrivileges() { }

	public bool HasBuildingBlocks() { }

	public bool HasDecayEntities() { }

	public void AddBuildingPrivilege(BuildingPrivlidge ent) { }

	public void RemoveBuildingPrivilege(BuildingPrivlidge ent) { }

	public void AddBuildingBlock(BuildingBlock ent) { }

	public void RemoveBuildingBlock(BuildingBlock ent) { }

	public void AddDecayEntity(DecayEntity ent) { }

	public void RemoveDecayEntity(DecayEntity ent) { }

	public void Add(DecayEntity ent) { }

	public void Remove(DecayEntity ent) { }

	public void Dirty() { }

	public void .ctor() { }

}

public class BuildingGrade : ScriptableObject // TypeDefIndex: 10716
{	public BuildingGrade.Enum type; // 0x18
	public float baseHealth; // 0x1C
	public List<ItemAmount> baseCost; // 0x20
	public PhysicMaterial physicMaterial; // 0x28
	public ProtectionProperties damageProtecton; // 0x30
	public BaseEntity.Menu.Option upgradeMenu; // 0x38


	public void .ctor() { }

}

public enum BuildingGrade.Enum // TypeDefIndex: 10717
{	public int value__; // 0x0
	public const BuildingGrade.Enum None = -1;
	public const BuildingGrade.Enum Twigs = 0;
	public const BuildingGrade.Enum Wood = 1;
	public const BuildingGrade.Enum Stone = 2;
	public const BuildingGrade.Enum Metal = 3;
	public const BuildingGrade.Enum TopTier = 4;
	public const BuildingGrade.Enum Count = 5;

}

