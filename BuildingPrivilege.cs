public class BuildInfo // TypeDefIndex: 6173
{
	[CompilerGeneratedAttribute] 
	private int <Date>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BuildInfo.ScmInfo <Scm>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BuildInfo.BuildDesc <Build>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Valid>k__BackingField; 
	private static BuildInfo _current; 

	public int Date { get; set; }
	[JsonIgnoreAttribute] 
	public DateTime BuildDate { get; }
	public BuildInfo.ScmInfo Scm { get; set; }
	public BuildInfo.BuildDesc Build { get; set; }
	public bool Valid { get; set; }
	public static BuildInfo Current { get; }


	[CompilerGeneratedAttribute] 
	public int get_Date() { }

	[CompilerGeneratedAttribute] 
	public void set_Date(int value) { }

	public DateTime get_BuildDate() { }

	[CompilerGeneratedAttribute] 
	public BuildInfo.ScmInfo get_Scm() { }

	[CompilerGeneratedAttribute] 
	public void set_Scm(BuildInfo.ScmInfo value) { }

	[CompilerGeneratedAttribute] 
	public BuildInfo.BuildDesc get_Build() { }

	[CompilerGeneratedAttribute] 
	public void set_Build(BuildInfo.BuildDesc value) { }

	[CompilerGeneratedAttribute] 
	public bool get_Valid() { }

	[CompilerGeneratedAttribute] 
	public void set_Valid(bool value) { }

	public static BuildInfo get_Current() { }

	public void .ctor() { }

}

public class BuildInfo.ScmInfo // TypeDefIndex: 6174
{
	[CompilerGeneratedAttribute] 
	private string <Type>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <ChangeId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Branch>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Repo>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Comment>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Author>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Date>k__BackingField; 

	public string Type { get; set; }
	public string ChangeId { get; set; }
	public string Branch { get; set; }
	public string Repo { get; set; }
	public string Comment { get; set; }
	public string Author { get; set; }
	public string Date { get; set; }


	[CompilerGeneratedAttribute] 
	public string get_Type() { }

	[CompilerGeneratedAttribute] 
	public void set_Type(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_ChangeId() { }

	[CompilerGeneratedAttribute] 
	public void set_ChangeId(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Branch() { }

	[CompilerGeneratedAttribute] 
	public void set_Branch(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Repo() { }

	[CompilerGeneratedAttribute] 
	public void set_Repo(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Comment() { }

	[CompilerGeneratedAttribute] 
	public void set_Comment(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Author() { }

	[CompilerGeneratedAttribute] 
	public void set_Author(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Date() { }

	[CompilerGeneratedAttribute] 
	public void set_Date(string value) { }

	public void .ctor() { }

}

public class BuildInfo.BuildDesc // TypeDefIndex: 6175
{
	[CompilerGeneratedAttribute] 
	private string <Id>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Number>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Tag>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Url>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Name>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Node>k__BackingField; 

	public string Id { get; set; }
	public string Number { get; set; }
	public string Tag { get; set; }
	public string Url { get; set; }
	public string Name { get; set; }
	public string Node { get; set; }


	[CompilerGeneratedAttribute] 
	public string get_Id() { }

	[CompilerGeneratedAttribute] 
	public void set_Id(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Number() { }

	[CompilerGeneratedAttribute] 
	public void set_Number(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Tag() { }

	[CompilerGeneratedAttribute] 
	public void set_Tag(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Url() { }

	[CompilerGeneratedAttribute] 
	public void set_Url(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Name() { }

	[CompilerGeneratedAttribute] 
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Node() { }

	[CompilerGeneratedAttribute] 
	public void set_Node(string value) { }

	public void .ctor() { }

}

public class BuildingBlock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6307
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int model; 
	public int grade; 
	public bool beingDemolished; 


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

public class BuildingPrivilege : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6314
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<PlayerNameID> users; 
	public float upkeepPeriodMinutes; 
	public float costFraction; 
	public float protectedMinutes; 


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

public class BuildingPrivlidge : StorageContainer // TypeDefIndex: 10069
{
	private Option __menuOption_Menu_MaxAuth; 
	private Option __menuOption_Menu_RotateVM; 
	private Option __menuOption_MenuAuthorize; 
	private Option __menuOption_MenuClearList; 
	private Option __menuOption_MenuDeauthorize; 
	private float cachedProtectedMinutes; 
	private float cachedUpkeepPeriodMinutes; 
	private float cachedUpkeepCostFraction; 
	public List<PlayerNameID> authorizedPlayers; 
	public const BaseEntity.Flags Flag_MaxAuths = 2048;
	public List<ItemDefinition> allowedConstructionItems; 

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

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_MaxAuth(BasePlayer player) { }

	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuAuthorize(BasePlayer player) { }

	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuDeauthorize(BasePlayer player) { }

	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuClearList(BasePlayer player) { }

	public bool MenuClearList_ShowIf(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_RotateVM(BasePlayer player) { }

	public bool Menu_RotateTC_ShowIf(BasePlayer player) { }

	public override bool HasSlot(BaseEntity.Slot slot) { }

	public void .ctor() { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass20_0 // TypeDefIndex: 10070
{
	public BasePlayer player; 


	public void .ctor() { }

	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass21_0 // TypeDefIndex: 10071
{
	public ulong userID; 


	public void .ctor() { }

	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

public class BuildingBlock : StabilityEntity // TypeDefIndex: 10246
{
	private bool forceSkinRefresh; 
	private int modelState; 
	private int lastModelState; 
	public BuildingGrade.Enum grade; 
	private BuildingGrade.Enum lastGrade; 
	private ConstructionSkin currentSkin; 
	private DeferredAction skinChange; 
	private MeshRenderer placeholderRenderer; 
	private MeshCollider placeholderCollider; 
	private static Material HighlightMaterial; 
	public static BuildingBlock.UpdateSkinWorkQueue updateSkinQueueClient; 
	public bool CullBushes; 
	public Construction blockDefinition; 
	private static Vector3[] outsideLookupOffsets; 

	public ConstructionGrade currentGrade { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	public override void PostNetworkUpdate() { }

	public List<Option> GetBuildMenu(BasePlayer player) { }

	[BaseEntity.RPC_Client] 
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

public static class BuildingBlock.BlockFlags // TypeDefIndex: 10247
{
	public const BaseEntity.Flags CanRotate = 128;
	public const BaseEntity.Flags CanDemolish = 256;

}

public class BuildingBlock.UpdateSkinWorkQueue : ObjectWorkQueue<BuildingBlock> // TypeDefIndex: 10248
{

	protected override void RunJob(BuildingBlock entity) { }

	protected override bool ShouldAdd(BuildingBlock entity) { }

	public void .ctor() { }

}

private sealed class BuildingBlock.<>c__DisplayClass31_0 // TypeDefIndex: 10249
{
	public BuildingGrade.Enum iNewGrade; 
	public BuildingBlock <>4__this; 


	public void .ctor() { }

	internal void <GradeChangingOptions>b__0(BasePlayer ply) { }

}

public class BuildingProximity : PrefabAttribute // TypeDefIndex: 10764
{
	private const float check_radius = 2;
	private const float check_forgiveness = 0,01;
	private const float foundation_width = 3;
	private const float foundation_extents = 1,5;


	public static bool Check(BasePlayer player, Construction construction, Vector3 position, Quaternion rotation) { }

	private static BuildingProximity.ProximityInfo GetProximity(Construction construction1, Vector3 position1, Quaternion rotation1, Construction construction2, Vector3 position2, Quaternion rotation2) { }

	public Vector3 GetSelectPivot(Vector3 position, Quaternion rotation) { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

private struct BuildingProximity.ProximityInfo // TypeDefIndex: 10765
{
	public bool hit; 
	public bool connection; 
	public Line line; 
	public float sqrDist; 

}

public class BuildingBlockDecay : Decay // TypeDefIndex: 11244
{

	public void .ctor() { }

}

public class BuildingGradeDecay : Decay // TypeDefIndex: 11245
{
	public BuildingGrade.Enum decayGrade; 


	public void .ctor() { }

}

public abstract class BuildingManager // TypeDefIndex: 11545
{
	public static ClientBuildingManager client; 
	protected ListHashSet<DecayEntity> decayEntities; 
	protected ListDictionary<uint, BuildingManager.Building> buildingDictionary; 


	public BuildingManager.Building GetBuilding(uint buildingID) { }

	public void Add(DecayEntity ent) { }

	public void Remove(DecayEntity ent) { }

	public void Clear() { }

	protected abstract BuildingManager.Building CreateBuilding(uint id);

	protected abstract void DisposeBuilding(ref BuildingManager.Building building);

	protected void .ctor() { }

	private static void .cctor() { }

}

public class BuildingManager.Building // TypeDefIndex: 11546
{
	public uint ID; 
	public ListHashSet<BuildingPrivlidge> buildingPrivileges; 
	public ListHashSet<BuildingBlock> buildingBlocks; 
	public ListHashSet<DecayEntity> decayEntities; 
	public NavMeshObstacle buildingNavMeshObstacle; 
	public ListHashSet<NavMeshObstacle> navmeshCarvers; 
	public bool isNavMeshCarvingDirty; 
	public bool isNavMeshCarveOptimized; 


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

public class BuildingGrade : ScriptableObject // TypeDefIndex: 12445
{
	public BuildingGrade.Enum type; 
	public float baseHealth; 
	public List<ItemAmount> baseCost; 
	public PhysicMaterial physicMaterial; 
	public ProtectionProperties damageProtecton; 
	public BaseEntity.Menu.Option upgradeMenu; 


	public void .ctor() { }

}

public enum BuildingGrade.Enum // TypeDefIndex: 12446
{
	public int value__; 
	public const BuildingGrade.Enum None = -1;
	public const BuildingGrade.Enum Twigs = 0;
	public const BuildingGrade.Enum Wood = 1;
	public const BuildingGrade.Enum Stone = 2;
	public const BuildingGrade.Enum Metal = 3;
	public const BuildingGrade.Enum TopTier = 4;
	public const BuildingGrade.Enum Count = 5;

}

