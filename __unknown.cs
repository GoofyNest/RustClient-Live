internal sealed class <>f__AnonymousType0<<message>j__TPar> // TypeDefIndex: 1
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
internal sealed class <>f__AnonymousType0<<message>j__TPar> // TypeDefIndex: 1
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x9E7F0 Offset: 0x9DBF0 VA: 0x18009E7F0
	private readonly <message>j__TPar <message>i__Field; // 0x0

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(<message>j__TPar message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1354950 Offset: 0x1353D50 VA: 0x181354950
	|-<>f__AnonymousType0<object>..ctor
	|-<>f__AnonymousType0<string>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E4250 Offset: 0x15E3650 VA: 0x1815E4250
	|-<>f__AnonymousType0<object>.Equals
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E4300 Offset: 0x15E3700 VA: 0x1815E4300
	|-<>f__AnonymousType0<object>.GetHashCode
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E4350 Offset: 0x15E3750 VA: 0x1815E4350
	|-<>f__AnonymousType0<object>.ToString
	*/

}

internal class __Filters // TypeDefIndex: 143
{	// Fields
	internal static readonly __Filters Instance; // 0x12E60

	// Methods

	// RVA: 0x2146FB0 Offset: 0x21463B0 VA: 0x182146FB0 Slot: 4
	internal virtual bool FilterAttribute(MemberInfo m, object filterCriteria) { }

	// RVA: 0x21475A0 Offset: 0x21469A0 VA: 0x1821475A0 Slot: 5
	internal virtual bool FilterName(MemberInfo m, object filterCriteria) { }

	// RVA: 0x21473E0 Offset: 0x21467E0 VA: 0x1821473E0 Slot: 6
	internal virtual bool FilterIgnoreCase(MemberInfo m, object filterCriteria) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x2147750 Offset: 0x2146B50 VA: 0x182147750
	private static void .cctor() { }

}

public sealed class Func<TResult> : MulticastDelegate // TypeDefIndex: 155
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-Func<MP3Stream>..ctor
	|-Func<JsonSerializerSettings>..ctor
	|-Func<PublishResult>..ctor
	|-Func<bool>..ctor
	|-Func<byte>..ctor
	|-Func<Stream>..ctor
	|-Func<int>..ctor
	|-Func<UdpReceiveResult>..ctor
	|-Func<Nullable<ServerInfo>>..ctor
	|-Func<Nullable<Image>>..ctor
	|-Func<Nullable<InventoryPurchaseResult>>..ctor
	|-Func<Nullable<InventoryResult>>..ctor
	|-Func<Nullable<Item>>..ctor
	|-Func<Nullable<ResultPage>>..ctor
	|-Func<Nullable<int>>..ctor
	|-Func<Nullable<Int32Enum>>..ctor
	|-Func<object>..ctor
	|-Func<string>..ctor
	|-Func<StringBuilder>..ctor
	|-Func<ManualResetEvent>..ctor
	|-Func<SemaphoreSlim>..ctor
	|-Func<Task.ContingentProperties>..ctor
	|-Func<Task<Stream>>..ctor
	|-Func<Task<WebResponse>>..ctor
	|-Func<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B837C0 Offset: 0x1B82BC0 VA: 0x181B837C0
	|-Func<JsonSerializerSettings>.Invoke
	|-Func<IReferenceResolver>.Invoke
	|-Func<string>.Invoke
	|-Func<object>.Invoke
	|
	|-RVA: 0x1B841C0 Offset: 0x1B835C0 VA: 0x181B841C0
	|-Func<bool>.Invoke
	|-Func<byte>.Invoke
	|-Func<VoidTaskResult>.Invoke
	|
	|-RVA: 0x1B83F50 Offset: 0x1B83350 VA: 0x181B83F50
	|-Func<int>.Invoke
	|
	|-RVA: 0x1B83CA0 Offset: 0x1B830A0 VA: 0x181B83CA0
	|-Func<PublishResult>.Invoke
	|-Func<Nullable<Image>>.Invoke
	|
	|-RVA: 0x121B500 Offset: 0x121A900 VA: 0x18121B500
	|-Func<UdpReceiveResult>.Invoke
	|
	|-RVA: 0x1B849C0 Offset: 0x1B83DC0 VA: 0x181B849C0
	|-Func<Nullable<ServerInfo>>.Invoke
	|
	|-RVA: 0x1B83510 Offset: 0x1B82910 VA: 0x181B83510
	|-Func<Nullable<InventoryPurchaseResult>>.Invoke
	|-Func<Nullable<ResultPage>>.Invoke
	|
	|-RVA: 0x19855E0 Offset: 0x19849E0 VA: 0x1819855E0
	|-Func<Nullable<InventoryResult>>.Invoke
	|
	|-RVA: 0x1B84430 Offset: 0x1B83830 VA: 0x181B84430
	|-Func<Nullable<Item>>.Invoke
	|
	|-RVA: 0x1B83A30 Offset: 0x1B82E30 VA: 0x181B83A30
	|-Func<Nullable<int>>.Invoke
	|-Func<Nullable<Int32Enum>>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497020 Offset: 0x496420 VA: 0x180497020
	|-Func<PublishResult>.BeginInvoke
	|-Func<bool>.BeginInvoke
	|-Func<byte>.BeginInvoke
	|-Func<int>.BeginInvoke
	|-Func<UdpReceiveResult>.BeginInvoke
	|-Func<Nullable<ServerInfo>>.BeginInvoke
	|-Func<Nullable<Image>>.BeginInvoke
	|-Func<Nullable<InventoryPurchaseResult>>.BeginInvoke
	|-Func<Nullable<InventoryResult>>.BeginInvoke
	|-Func<Nullable<Item>>.BeginInvoke
	|-Func<Nullable<ResultPage>>.BeginInvoke
	|-Func<Nullable<int>>.BeginInvoke
	|-Func<Nullable<Int32Enum>>.BeginInvoke
	|-Func<object>.BeginInvoke
	|-Func<VoidTaskResult>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F3FF0 Offset: 0x19F33F0 VA: 0x1819F3FF0
	|-Func<PublishResult>.EndInvoke
	|-Func<Nullable<Image>>.EndInvoke
	|
	|-RVA: 0xFF1100 Offset: 0xFF0500 VA: 0x180FF1100
	|-Func<bool>.EndInvoke
	|-Func<byte>.EndInvoke
	|-Func<VoidTaskResult>.EndInvoke
	|
	|-RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0
	|-Func<int>.EndInvoke
	|
	|-RVA: 0x121B4C0 Offset: 0x121A8C0 VA: 0x18121B4C0
	|-Func<UdpReceiveResult>.EndInvoke
	|
	|-RVA: 0x19F3E60 Offset: 0x19F3260 VA: 0x1819F3E60
	|-Func<Nullable<ServerInfo>>.EndInvoke
	|
	|-RVA: 0x19F3ED0 Offset: 0x19F32D0 VA: 0x1819F3ED0
	|-Func<Nullable<InventoryPurchaseResult>>.EndInvoke
	|-Func<Nullable<ResultPage>>.EndInvoke
	|
	|-RVA: 0x19855A0 Offset: 0x19849A0 VA: 0x1819855A0
	|-Func<Nullable<InventoryResult>>.EndInvoke
	|
	|-RVA: 0x19F3F40 Offset: 0x19F3340 VA: 0x1819F3F40
	|-Func<Nullable<Item>>.EndInvoke
	|
	|-RVA: 0x121BE10 Offset: 0x121B210 VA: 0x18121BE10
	|-Func<Nullable<int>>.EndInvoke
	|-Func<Nullable<Int32Enum>>.EndInvoke
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-Func<object>.EndInvoke
	*/

}

public sealed class Func<T, TResult> : MulticastDelegate // TypeDefIndex: 156
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-Func<AchievementGroup.AchievementItem, bool>..ctor
	|-Func<BaseEntity, bool>..ctor
	|-Func<BaseNetworkable, Debugging.EntityInfo>..ctor
	|-Func<BaseNetworkable, bool>..ctor
	|-Func<BaseNetworkable, uint>..ctor
	|-Func<BaseViewModel, string>..ctor
	|-Func<Admin.PlayerInfo, GameObjectRef>..ctor
	|-Func<Admin.PlayerInfo, object>..ctor
	|-Func<Admin.ServerConvarInfo, GameObjectRef>..ctor
	|-Func<Admin.ServerConvarInfo, object>..ctor
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Func<Debugging.EntityInfo, bool>..ctor
	|-Func<Entity.EntityInfo, bool>..ctor
	|-Func<ConsoleSystem.Command, bool>..ctor
	|-Func<ConstructionGrade, BuildingGrade.Enum>..ctor
	|-Func<ConstructionGrade, bool>..ctor
	|-Func<CraftingQueueIcon, bool>..ctor
	|-Func<Demos.DemoInfo, DateTime>..ctor
	|-Func<Demos.DemoInfo, object>..ctor
	|-Func<Demos.DemoInfo, string>..ctor
	|-Func<Demos.DemoInfo, TimeSpan>..ctor
	|-Func<DungeonBaseInfo, int>..ctor
	|-Func<EZSoftBone.BoneChain, int>..ctor
	|-Func<AccountNotice, bool>..ctor
	|-Func<AccountNotice, DateTime>..ctor
	|-Func<BurstCloth.Chain, FourBitNumber>..ctor
	|-Func<BurstCloth.Chain, SevenBitNumber>..ctor
	|-Func<BurstCloth.Chain, bool>..ctor
	|-Func<BurstCloth.Chain, int>..ctor
	|-Func<CardPlayerData, bool>..ctor
	|-Func<Hero, Guid>..ctor
	|-Func<Input.Button, bool>..ctor
	|-Func<Input.Button, string>..ctor
	|-Func<Manifest.Administrator, bool>..ctor
	|-Func<Manifest.ServerDesc, string>..ctor
	|-Func<RCon.BannedAddresses, bool>..ctor
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>..ctor
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>..ctor
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>..ctor
	|-Func<SkeletonDefinition.Bone, Option>..ctor
	|-Func<SkeletonDefinition.Bone, InventoryItem>..ctor
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>..ctor
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>..ctor
	|-Func<SkeletonDefinition.Bone, bool>..ctor
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>..ctor
	|-Func<SkeletonDefinition.Bone, int>..ctor
	|-Func<SkeletonDefinition.Bone, Int32Enum>..ctor
	|-Func<SkeletonDefinition.Bone, long>..ctor
	|-Func<SkeletonDefinition.Bone, object>..ctor
	|-Func<SkeletonDefinition.Bone, float>..ctor
	|-Func<SkeletonDefinition.Bone, GameObject>..ctor
	|-Func<SkeletonDefinition.Bone, Resolution>..ctor
	|-Func<SkeletonDefinition.Bone, Transform>..ctor
	|-Func<WeightedStringList.Container, bool>..ctor
	|-Func<WeightedStringList.Container, float>..ctor
	|-Func<GameManifest.PrefabProperties, bool>..ctor
	|-Func<GameManifest.PrefabProperties, string>..ctor
	|-Func<GameStat.Stat, bool>..ctor
	|-Func<GenerateDungeonBase.DungeonSegment, float>..ctor
	|-Func<GenerateDungeonGrid.PathNode, PathFinder.Point>..ctor
	|-Func<GenerateDungeonGrid.PathNode, bool>..ctor
	|-Func<GeneratePowerlineLayout.PathNode, PathFinder.Point>..ctor
	|-Func<GeneratePowerlineLayout.PathNode, bool>..ctor
	|-Func<GenerateRoadLayout.PathNode, PathFinder.Point>..ctor
	|-Func<GenerateRoadLayout.PathNode, bool>..ctor
	|-Func<HitboxDefinition, int>..ctor
	|-Func<IPlayerInfo, bool>..ctor
	|-Func<IPlayerInfo, int>..ctor
	|-Func<IPlayerInfo, string>..ctor
	|-Func<IPlayerItem, bool>..ctor
	|-Func<IPlayerItem, DateTimeOffset>..ctor
	|-Func<IPlayerItem, int>..ctor
	|-Func<IPlayerItemDefinition, bool>..ctor
	|-Func<IPlayerItemDefinition, int>..ctor
	|-Func<ImageStorageEntity.ImageRequest, IImageReceiver>..ctor
	|-Func<ImageStorageEntity.ImageRequest, object>..ctor
	|-Func<Item, bool>..ctor
	|-Func<Item, int>..ctor
	|-Func<ItemBlueprint, Rarity>..ctor
	|-Func<ItemBlueprint, bool>..ctor
	|-Func<ItemBlueprint, int>..ctor
	|-Func<ItemDefinition, ItemCategory>..ctor
	|-Func<ItemDefinition, ItemModWearable>..ctor
	|-Func<ItemDefinition, bool>..ctor
	|-Func<ItemDefinition, float>..ctor
	|-Func<ItemDefinition, string>..ctor
	|-Func<ItemIcon, int>..ctor
	|-Func<ItemModWearable, bool>..ctor
	|-Func<ItemModWearable, Guid>..ctor
	|-Func<ItemSkinDirectory.Skin, bool>..ctor
	|-Func<LoadAssetsResult, bool>..ctor
	|-Func<LoadAssetsResult, int>..ctor
	|-Func<FourBitNumber, FourBitNumber>..ctor
	|-Func<FourBitNumber, bool>..ctor
	|-Func<SevenBitNumber, SevenBitNumber>..ctor
	|-Func<SevenBitNumber, bool>..ctor
	|-Func<SevenBitNumber, object>..ctor
	|-Func<EventsCollection, int>..ctor
	|-Func<TrackChunk, EventsCollection>..ctor
	|-Func<TrackChunk, bool>..ctor
	|-Func<ITempoMapValuesCache, bool>..ctor
	|-Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, bool>..ctor
	|-Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, long>..ctor
	|-Func<ValueChange<TimeSignature>, bool>..ctor
	|-Func<MusicTheme, float>..ctor
	|-Func<DefaultSerializationBinder.TypeNameKey, object>..ctor
	|-Func<DefaultSerializationBinder.TypeNameKey, Type>..ctor
	|-Func<JsonProperty, JsonProperty>..ctor
	|-Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence>..ctor
	|-Func<JsonProperty, int>..ctor
	|-Func<JsonProperty, string>..ctor
	|-Func<JsonSerializerInternalReader.CreatorPropertyContext, bool>..ctor
	|-Func<ConvertUtils.TypeConvertKey, Func<object, object>>..ctor
	|-Func<ConvertUtils.TypeConvertKey, object>..ctor
	|-Func<PathFinder.Point, PathFinder.Point>..ctor
	|-Func<PathFinder.Point, bool>..ctor
	|-Func<PetCommandList.PetCommandDesc, bool>..ctor
	|-Func<PieMenu.MenuOption, bool>..ctor
	|-Func<PieMenu.MenuOption, int>..ctor
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>..ctor
	|-Func<PlayerItemRecipe, IPlayerItemDefinition>..ctor
	|-Func<PlayerItemRecipe, PathFinder.Point>..ctor
	|-Func<PlayerItemRecipe, PlayerItemRecipe>..ctor
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>..ctor
	|-Func<PlayerItemRecipe, Option>..ctor
	|-Func<PlayerItemRecipe, InventoryItem>..ctor
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>..ctor
	|-Func<PlayerItemRecipe, InventoryRecipe>..ctor
	|-Func<PlayerItemRecipe, bool>..ctor
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>..ctor
	|-Func<PlayerItemRecipe, int>..ctor
	|-Func<PlayerItemRecipe, Int32Enum>..ctor
	|-Func<PlayerItemRecipe, long>..ctor
	|-Func<PlayerItemRecipe, object>..ctor
	|-Func<PlayerItemRecipe, float>..ctor
	|-Func<PlayerItemRecipe, Resolution>..ctor
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>..ctor
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>..ctor
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Func<PlayerItemRecipe.Ingredient, bool>..ctor
	|-Func<PlayerItemRecipe.Ingredient, int>..ctor
	|-Func<Prefab, bool>..ctor
	|-Func<Prefab<DungeonGridLink>, int>..ctor
	|-Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier>..ctor
	|-Func<ProjectileWeaponMod, bool>..ctor
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Func<ProjectileWeaponMod.Modifier, bool>..ctor
	|-Func<ProjectileWeaponMod.Modifier, float>..ctor
	|-Func<MarketTerminal.PendingOrder, uint>..ctor
	|-Func<PathData, PathList>..ctor
	|-Func<PathData, bool>..ctor
	|-Func<PlayerNameID, bool>..ctor
	|-Func<PlayerTeam.TeamMember, ulong>..ctor
	|-Func<PrefabData, bool>..ctor
	|-Func<PrefabData, string>..ctor
	|-Func<RelationshipManager.PlayerRelationshipInfo, ulong>..ctor
	|-Func<Indexer.Entity, Indexer.Entity>..ctor
	|-Func<Indexer.Entity, uint>..ctor
	|-Func<SteamItem, InventoryItem>..ctor
	|-Func<SteamItemDefinition, InventoryDef>..ctor
	|-Func<Option, Option>..ctor
	|-Func<Option, bool>..ctor
	|-Func<OptionAttribute, Option>..ctor
	|-Func<SteamInventoryItem, bool>..ctor
	|-Func<SteamInventoryItem, IEnumerable<PlayerItemRecipe>>..ctor
	|-Func<SteamInventoryItem, Task<IPlayerInventory>>..ctor
	|-Func<ServerBrowserTag, bool>..ctor
	|-Func<ServerInfo, Debugging.EntityInfo>..ctor
	|-Func<ServerInfo, FourBitNumber>..ctor
	|-Func<ServerInfo, SevenBitNumber>..ctor
	|-Func<ServerInfo, PathFinder.Point>..ctor
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>..ctor
	|-Func<ServerInfo, Option>..ctor
	|-Func<ServerInfo, InventoryItem>..ctor
	|-Func<ServerInfo, InventoryRecipe.Ingredient>..ctor
	|-Func<ServerInfo, InventoryRecipe>..ctor
	|-Func<ServerInfo, bool>..ctor
	|-Func<ServerInfo, KeyValuePair<object, int>>..ctor
	|-Func<ServerInfo, int>..ctor
	|-Func<ServerInfo, Int32Enum>..ctor
	|-Func<ServerInfo, long>..ctor
	|-Func<ServerInfo, object>..ctor
	|-Func<ServerInfo, float>..ctor
	|-Func<ServerInfo, string>..ctor
	|-Func<ServerInfo, uint>..ctor
	|-Func<ServerInfo, Resolution>..ctor
	|-Func<SkeletonProperties.BoneProperty, bool>..ctor
	|-Func<Skinnable, bool>..ctor
	|-Func<Skinnable, string>..ctor
	|-Func<SkinnedMultiMesh.Part, bool>..ctor
	|-Func<SkinnedMultiMesh.Part, long>..ctor
	|-Func<Achievement, <>f__AnonymousType0<string, string, bool>>..ctor
	|-Func<Achievement, Debugging.EntityInfo>..ctor
	|-Func<Achievement, PathFinder.Point>..ctor
	|-Func<Achievement, ProjectileWeaponMod.Modifier>..ctor
	|-Func<Achievement, Option>..ctor
	|-Func<Achievement, InventoryItem>..ctor
	|-Func<Achievement, InventoryRecipe.Ingredient>..ctor
	|-Func<Achievement, InventoryRecipe>..ctor
	|-Func<Achievement, bool>..ctor
	|-Func<Achievement, KeyValuePair<object, int>>..ctor
	|-Func<Achievement, int>..ctor
	|-Func<Achievement, Int32Enum>..ctor
	|-Func<Achievement, long>..ctor
	|-Func<Achievement, object>..ctor
	|-Func<Achievement, float>..ctor
	|-Func<Achievement, Resolution>..ctor
	|-Func<InventoryDefId, Debugging.EntityInfo>..ctor
	|-Func<InventoryDefId, PathFinder.Point>..ctor
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>..ctor
	|-Func<InventoryDefId, Option>..ctor
	|-Func<InventoryDefId, InventoryDef>..ctor
	|-Func<InventoryDefId, InventoryItem>..ctor
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>..ctor
	|-Func<InventoryDefId, InventoryRecipe>..ctor
	|-Func<InventoryDefId, bool>..ctor
	|-Func<InventoryDefId, KeyValuePair<object, int>>..ctor
	|-Func<InventoryDefId, int>..ctor
	|-Func<InventoryDefId, Int32Enum>..ctor
	|-Func<InventoryDefId, long>..ctor
	|-Func<InventoryDefId, object>..ctor
	|-Func<InventoryDefId, float>..ctor
	|-Func<InventoryDefId, Resolution>..ctor
	|-Func<InventoryItemId, InventoryItemId>..ctor
	|-Func<InventoryItemId, bool>..ctor
	|-Func<ServerInfo, ServerInfo>..ctor
	|-Func<ServerInfo, bool>..ctor
	|-Func<ServerInfo, int>..ctor
	|-Func<ServerInfo, object>..ctor
	|-Func<Friend, Debugging.EntityInfo>..ctor
	|-Func<Friend, PathFinder.Point>..ctor
	|-Func<Friend, ProjectileWeaponMod.Modifier>..ctor
	|-Func<Friend, SteamPlayer>..ctor
	|-Func<Friend, Option>..ctor
	|-Func<Friend, InventoryItem>..ctor
	|-Func<Friend, InventoryRecipe.Ingredient>..ctor
	|-Func<Friend, InventoryRecipe>..ctor
	|-Func<Friend, bool>..ctor
	|-Func<Friend, KeyValuePair<object, int>>..ctor
	|-Func<Friend, int>..ctor
	|-Func<Friend, Int32Enum>..ctor
	|-Func<Friend, long>..ctor
	|-Func<Friend, object>..ctor
	|-Func<Friend, float>..ctor
	|-Func<Friend, Resolution>..ctor
	|-Func<InventoryDef, IPlayerItemDefinition>..ctor
	|-Func<InventoryDef, SteamItemDefinition>..ctor
	|-Func<InventoryDef, InventoryDefId>..ctor
	|-Func<InventoryDef, InventoryRecipe[]>..ctor
	|-Func<InventoryDef, string>..ctor
	|-Func<InventoryItem, Debugging.EntityInfo>..ctor
	|-Func<InventoryItem, FourBitNumber>..ctor
	|-Func<InventoryItem, SevenBitNumber>..ctor
	|-Func<InventoryItem, PathFinder.Point>..ctor
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>..ctor
	|-Func<InventoryItem, SteamItem>..ctor
	|-Func<InventoryItem, Option>..ctor
	|-Func<InventoryItem, InventoryDefId>..ctor
	|-Func<InventoryItem, InventoryItemId>..ctor
	|-Func<InventoryItem, InventoryItem>..ctor
	|-Func<InventoryItem, InventoryRecipe.Ingredient>..ctor
	|-Func<InventoryItem, InventoryRecipe>..ctor
	|-Func<InventoryItem, bool>..ctor
	|-Func<InventoryItem, KeyValuePair<object, int>>..ctor
	|-Func<InventoryItem, int>..ctor
	|-Func<InventoryItem, Int32Enum>..ctor
	|-Func<InventoryItem, long>..ctor
	|-Func<InventoryItem, object>..ctor
	|-Func<InventoryItem, float>..ctor
	|-Func<InventoryItem, uint>..ctor
	|-Func<InventoryItem, Resolution>..ctor
	|-Func<InventoryItem.Amount, InventoryItemId>..ctor
	|-Func<InventoryItem.Amount, bool>..ctor
	|-Func<InventoryItem.Amount, uint>..ctor
	|-Func<InventoryRecipe, PlayerItemRecipe>..ctor
	|-Func<InventoryRecipe, InventoryRecipe>..ctor
	|-Func<InventoryRecipe, bool>..ctor
	|-Func<InventoryRecipe, object>..ctor
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>..ctor
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>..ctor
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>..ctor
	|-Func<InventoryRecipe.Ingredient, Option>..ctor
	|-Func<InventoryRecipe.Ingredient, InventoryItem>..ctor
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>..ctor
	|-Func<InventoryRecipe.Ingredient, bool>..ctor
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>..ctor
	|-Func<InventoryRecipe.Ingredient, int>..ctor
	|-Func<InventoryRecipe.Ingredient, Int32Enum>..ctor
	|-Func<InventoryRecipe.Ingredient, long>..ctor
	|-Func<InventoryRecipe.Ingredient, object>..ctor
	|-Func<InventoryRecipe.Ingredient, float>..ctor
	|-Func<InventoryRecipe.Ingredient, string>..ctor
	|-Func<InventoryRecipe.Ingredient, Resolution>..ctor
	|-Func<InventoryRecipe[], bool>..ctor
	|-Func<InventoryRecipe[], IEnumerable<InventoryRecipe>>..ctor
	|-Func<Item, DateTime>..ctor
	|-Func<ArraySegment<byte>, WebSocketHttpRequest>..ctor
	|-Func<ArraySegment<byte>, object>..ctor
	|-Func<bool, bool>..ctor
	|-Func<byte[], bool>..ctor
	|-Func<byte[], IEnumerable<byte>>..ctor
	|-Func<byte[], int>..ctor
	|-Func<char, bool>..ctor
	|-Func<DictionaryEntry, bool>..ctor
	|-Func<DictionaryEntry, KeyValuePair<object, object>>..ctor
	|-Func<DictionaryEntry, object>..ctor
	|-Func<KeyValuePair<IPAddress, int>, int>..ctor
	|-Func<KeyValuePair<object, int>, bool>..ctor
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Func<KeyValuePair<object, int>, int>..ctor
	|-Func<KeyValuePair<object, long>, long>..ctor
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>..ctor
	|-Func<KeyValuePair<object, object>, PathFinder.Point>..ctor
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Func<KeyValuePair<object, object>, Option>..ctor
	|-Func<KeyValuePair<object, object>, InventoryItem>..ctor
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>..ctor
	|-Func<KeyValuePair<object, object>, InventoryRecipe>..ctor
	|-Func<KeyValuePair<object, object>, bool>..ctor
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>..ctor
	|-Func<KeyValuePair<object, object>, int>..ctor
	|-Func<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Func<KeyValuePair<object, object>, long>..ctor
	|-Func<KeyValuePair<object, object>, object>..ctor
	|-Func<KeyValuePair<object, object>, float>..ctor
	|-Func<KeyValuePair<object, object>, Resolution>..ctor
	|-Func<KeyValuePair<string, Stats.Node>, long>..ctor
	|-Func<KeyValuePair<string, AssetBundle>, bool>..ctor
	|-Func<KeyValuePair<Type, Pool.ICollection>, long>..ctor
	|-Func<KeyValuePair<Type, long>, long>..ctor
	|-Func<KeyValuePair<Type, PostProcessBundle>, bool>..ctor
	|-Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle>..ctor
	|-Func<KeyValuePair<uint, FileStorage.CacheData>, bool>..ctor
	|-Func<KeyValuePair<uint, FileStorage.CacheData>, uint>..ctor
	|-Func<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity>..ctor
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>..ctor
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>..ctor
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Func<KeyValuePair<uint, object>, Option>..ctor
	|-Func<KeyValuePair<uint, object>, InventoryItem>..ctor
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>..ctor
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>..ctor
	|-Func<KeyValuePair<uint, object>, bool>..ctor
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>..ctor
	|-Func<KeyValuePair<uint, object>, int>..ctor
	|-Func<KeyValuePair<uint, object>, Int32Enum>..ctor
	|-Func<KeyValuePair<uint, object>, long>..ctor
	|-Func<KeyValuePair<uint, object>, object>..ctor
	|-Func<KeyValuePair<uint, object>, float>..ctor
	|-Func<KeyValuePair<uint, object>, uint>..ctor
	|-Func<KeyValuePair<uint, object>, Resolution>..ctor
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>..ctor
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>..ctor
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>..ctor
	|-Func<KeyValuePair<Transform, int>, int>..ctor
	|-Func<StackFrame, Report.StackTrace.StackFrame>..ctor
	|-Func<double, double>..ctor
	|-Func<Exception, bool>..ctor
	|-Func<Guid, int>..ctor
	|-Func<Guid, object>..ctor
	|-Func<IAsyncResult, ISocket>..ctor
	|-Func<IAsyncResult, Stream>..ctor
	|-Func<IAsyncResult, int>..ctor
	|-Func<IAsyncResult, UdpReceiveResult>..ctor
	|-Func<IAsyncResult, WebResponse>..ctor
	|-Func<FileInfo, bool>..ctor
	|-Func<int, FourBitNumber>..ctor
	|-Func<int, SevenBitNumber>..ctor
	|-Func<int, bool>..ctor
	|-Func<int, int>..ctor
	|-Func<int, object>..ctor
	|-Func<int, float>..ctor
	|-Func<int, Material[]>..ctor
	|-Func<Int32Enum, Debugging.EntityInfo>..ctor
	|-Func<Int32Enum, PathFinder.Point>..ctor
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>..ctor
	|-Func<Int32Enum, Option>..ctor
	|-Func<Int32Enum, InventoryItem>..ctor
	|-Func<Int32Enum, InventoryRecipe.Ingredient>..ctor
	|-Func<Int32Enum, InventoryRecipe>..ctor
	|-Func<Int32Enum, bool>..ctor
	|-Func<Int32Enum, KeyValuePair<object, int>>..ctor
	|-Func<Int32Enum, int>..ctor
	|-Func<Int32Enum, Int32Enum>..ctor
	|-Func<Int32Enum, long>..ctor
	|-Func<Int32Enum, object>..ctor
	|-Func<Int32Enum, float>..ctor
	|-Func<Int32Enum, Resolution>..ctor
	|-Func<long, bool>..ctor
	|-Func<long, long>..ctor
	|-Func<IntPtr, object>..ctor
	|-Func<IGrouping<ItemCategory, ItemDefinition>, ItemCategory>..ctor
	|-Func<IGrouping<InventoryDefId, InventoryDef>, InventoryDefId>..ctor
	|-Func<IGrouping<InventoryDefId, InventoryDef>, uint>..ctor
	|-Func<IGrouping<string, IPlayerInfo>, string>..ctor
	|-Func<IGrouping<string, PrefabData>, List<PrefabData>>..ctor
	|-Func<IGrouping<string, PrefabData>, string>..ctor
	|-Func<IGrouping<string, Animator>, int>..ctor
	|-Func<IGrouping<string, Collider>, int>..ctor
	|-Func<IGrouping<string, LODGroup>, int>..ctor
	|-Func<IGrouping<string, Rigidbody>, int>..ctor
	|-Func<IGrouping<string, Transform>, KeyValuePair<Transform, int>>..ctor
	|-Func<IGrouping<string, Transform>, int>..ctor
	|-Func<IGrouping<Type, Object>, int>..ctor
	|-Func<IGrouping<uint, BaseNetworkable>, BaseNetworkable>..ctor
	|-Func<IGrouping<uint, BaseNetworkable>, int>..ctor
	|-Func<IGrouping<AssetBundle, string>, LoadAssetsResult>..ctor
	|-Func<IGrouping<Vector2Int, Resolution>, Resolution>..ctor
	|-Func<SimpleAsyncResult, bool>..ctor
	|-Func<object, Debugging.EntityInfo>..ctor
	|-Func<object, FourBitNumber>..ctor
	|-Func<object, SevenBitNumber>..ctor
	|-Func<object, PathFinder.Point>..ctor
	|-Func<object, PlayerItemRecipe.Ingredient>..ctor
	|-Func<object, PlayerItemRecipe>..ctor
	|-Func<object, ProjectileWeaponMod.Modifier>..ctor
	|-Func<object, Option>..ctor
	|-Func<object, InventoryDefId>..ctor
	|-Func<object, InventoryItemId>..ctor
	|-Func<object, InventoryItem>..ctor
	|-Func<object, InventoryRecipe.Ingredient>..ctor
	|-Func<object, InventoryRecipe>..ctor
	|-Func<object, PublishResult>..ctor
	|-Func<object, bool>..ctor
	|-Func<object, KeyValuePair<object, int>>..ctor
	|-Func<object, DateTime>..ctor
	|-Func<object, DateTimeOffset>..ctor
	|-Func<object, Guid>..ctor
	|-Func<object, int>..ctor
	|-Func<object, Int32Enum>..ctor
	|-Func<object, long>..ctor
	|-Func<object, UdpReceiveResult>..ctor
	|-Func<object, Nullable<ServerInfo>>..ctor
	|-Func<object, Nullable<Image>>..ctor
	|-Func<object, Nullable<InventoryPurchaseResult>>..ctor
	|-Func<object, Nullable<InventoryResult>>..ctor
	|-Func<object, Nullable<Item>>..ctor
	|-Func<object, Nullable<ResultPage>>..ctor
	|-Func<object, Nullable<int>>..ctor
	|-Func<object, Nullable<Int32Enum>>..ctor
	|-Func<object, object>..ctor
	|-Func<object, float>..ctor
	|-Func<object, string>..ctor
	|-Func<object, VoidTaskResult>..ctor
	|-Func<object, Type>..ctor
	|-Func<object, uint>..ctor
	|-Func<object, ulong>..ctor
	|-Func<object, Resolution>..ctor
	|-Func<object[], JsonConverter>..ctor
	|-Func<Assembly, IEnumerable<Type>>..ctor
	|-Func<AssemblyName, Assembly>..ctor
	|-Func<ConstructorInfo, bool>..ctor
	|-Func<FieldInfo, bool>..ctor
	|-Func<FieldInfo, int>..ctor
	|-Func<FieldInfo, ParameterOverride>..ctor
	|-Func<MemberInfo, bool>..ctor
	|-Func<MemberInfo, string>..ctor
	|-Func<ParameterInfo, Type>..ctor
	|-Func<PropertyInfo, bool>..ctor
	|-Func<EnumMemberAttribute, string>..ctor
	|-Func<MemberHolder, MemberInfo[]>..ctor
	|-Func<float, bool>..ctor
	|-Func<float, float>..ctor
	|-Func<string, Report.StackTrace.StackFrame>..ctor
	|-Func<string, InventoryRecipe.Ingredient>..ctor
	|-Func<string, InventoryRecipe>..ctor
	|-Func<string, bool>..ctor
	|-Func<string, Guid>..ctor
	|-Func<string, string>..ctor
	|-Func<string, Match>..ctor
	|-Func<string, AssetBundle>..ctor
	|-Func<string, GameObject>..ctor
	|-Func<string, KeyCode>..ctor
	|-Func<Match, bool>..ctor
	|-Func<Match, string>..ctor
	|-Func<Task<Dictionary<string, string>>, Task<Dictionary<string, string>>>..ctor
	|-Func<Type, BidirectionalDictionary<string, string>>..ctor
	|-Func<Type, ReflectionObject>..ctor
	|-Func<Type, bool>..ctor
	|-Func<Type, IEnumerable<MemberInfo>>..ctor
	|-Func<Type, Func<object[], JsonConverter>>..ctor
	|-Func<Type, Tuple<bool, bool, bool, bool>>..ctor
	|-Func<Type, Type>..ctor
	|-Func<uint, bool>..ctor
	|-Func<uint, uint>..ctor
	|-Func<ulong, bool>..ctor
	|-Func<ulong, ulong>..ctor
	|-Func<ValueTuple<ItemDefinition.AmountType, int>, string>..ctor
	|-Func<ValueTuple<Int32Enum, int>, object>..ctor
	|-Func<KerningPair, uint>..ctor
	|-Func<TMP_Character, uint>..ctor
	|-Func<TMP_GlyphPairAdjustmentRecord, uint>..ctor
	|-Func<TechTreeData.NodeInstance, int>..ctor
	|-Func<TechTreeData.NodeInstance, TechTreeData.NodeInstance>..ctor
	|-Func<Animator, string>..ctor
	|-Func<Collider, bool>..ctor
	|-Func<Collider, string>..ctor
	|-Func<GameObject, ItemBlueprint>..ctor
	|-Func<GameObject, ItemDefinition>..ctor
	|-Func<KeyCode, bool>..ctor
	|-Func<KeyCode, string>..ctor
	|-Func<LODGroup, string>..ctor
	|-Func<PlayerEditorConnectionEvents.MessageTypeSubscribers, bool>..ctor
	|-Func<Object, bool>..ctor
	|-Func<Object, Type>..ctor
	|-Func<Renderer, bool>..ctor
	|-Func<Resolution, bool>..ctor
	|-Func<Resolution, int>..ctor
	|-Func<Resolution, Resolution>..ctor
	|-Func<Resolution, Vector2Int>..ctor
	|-Func<Rigidbody, bool>..ctor
	|-Func<Rigidbody, string>..ctor
	|-Func<Glyph, uint>..ctor
	|-Func<Transform, bool>..ctor
	|-Func<Transform, int>..ctor
	|-Func<Transform, object>..ctor
	|-Func<Transform, string>..ctor
	|-Func<Dropdown.OptionData, bool>..ctor
	|-Func<ILayoutElement, float>..ctor
	|-Func<Toggle, SteamInventoryItem>..ctor
	|-Func<Toggle, bool>..ctor
	|-Func<Wearable, bool>..ctor
	|-Func<WeatherPreset, bool>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke(T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16CD8C0 Offset: 0x16CCCC0 VA: 0x1816CD8C0
	|-Func<Entity.EntityInfo, bool>.Invoke
	|-Func<ItemSkinDirectory.Skin, bool>.Invoke
	|-Func<Option, bool>.Invoke
	|-Func<SkinnedMultiMesh.Part, bool>.Invoke
	|-Func<InventoryItem, FourBitNumber>.Invoke
	|-Func<InventoryItem, SevenBitNumber>.Invoke
	|-Func<InventoryItem, bool>.Invoke
	|
	|-RVA: 0x1B10600 Offset: 0x1B0FA00 VA: 0x181B10600
	|-Func<ArraySegment<byte>, WebSocketHttpRequest>.Invoke
	|-Func<ImageStorageEntity.ImageRequest, object>.Invoke
	|-Func<DefaultSerializationBinder.TypeNameKey, object>.Invoke
	|-Func<ConvertUtils.TypeConvertKey, object>.Invoke
	|-Func<PlayerItemRecipe, long>.Invoke
	|-Func<PlayerItemRecipe, object>.Invoke
	|-Func<ArraySegment<byte>, object>.Invoke
	|-Func<DictionaryEntry, object>.Invoke
	|-Func<KeyValuePair<object, long>, long>.Invoke
	|-Func<KeyValuePair<object, object>, long>.Invoke
	|-Func<KeyValuePair<object, object>, object>.Invoke
	|-Func<KeyValuePair<uint, object>, long>.Invoke
	|-Func<KeyValuePair<uint, object>, object>.Invoke
	|-Func<Guid, object>.Invoke
	|
	|-RVA: 0x19F8D60 Offset: 0x19F8160 VA: 0x1819F8D60
	|-Func<Exception, bool>.Invoke
	|-Func<SimpleAsyncResult, bool>.Invoke
	|-Func<string, bool>.Invoke
	|-Func<object, bool>.Invoke
	|
	|-RVA: 0x2126580 Offset: 0x2125980 VA: 0x182126580
	|-Func<int, int>.Invoke
	|-Func<Int32Enum, int>.Invoke
	|-Func<Int32Enum, Int32Enum>.Invoke
	|
	|-RVA: 0x212AAA0 Offset: 0x2129EA0 VA: 0x18212AAA0
	|-Func<int, float>.Invoke
	|-Func<Int32Enum, float>.Invoke
	|
	|-RVA: 0x19F6090 Offset: 0x19F5490 VA: 0x1819F6090
	|-Func<object, string>.Invoke
	|-Func<object[], JsonConverter>.Invoke
	|-Func<string, string>.Invoke
	|-Func<string, GameObject>.Invoke
	|-Func<object, object>.Invoke
	|-Func<AssemblyName, Assembly>.Invoke
	|
	|-RVA: 0x189F950 Offset: 0x189ED50 VA: 0x18189F950
	|-Func<ulong, bool>.Invoke
	|-Func<long, bool>.Invoke
	|
	|-RVA: 0x19F6F10 Offset: 0x19F6310 VA: 0x1819F6F10
	|-Func<ILayoutElement, float>.Invoke
	|-Func<object, float>.Invoke
	|
	|-RVA: 0x189F460 Offset: 0x189E860 VA: 0x18189F460
	|-Func<NativeInputUpdateType, bool>.Invoke
	|-Func<int, bool>.Invoke
	|-Func<Int32Enum, bool>.Invoke
	|
	|-RVA: 0x1B90BA0 Offset: 0x1B8FFA0 VA: 0x181B90BA0
	|-Func<Admin.PlayerInfo, object>.Invoke
	|
	|-RVA: 0x1B8FA80 Offset: 0x1B8EE80 VA: 0x181B8FA80
	|-Func<Admin.ServerConvarInfo, object>.Invoke
	|-Func<InventoryRecipe, object>.Invoke
	|-Func<InventoryRecipe.Ingredient, long>.Invoke
	|-Func<InventoryRecipe.Ingredient, object>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.Invoke
	|
	|-RVA: 0x1B88960 Offset: 0x1B87D60 VA: 0x181B88960
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>.Invoke
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>.Invoke
	|-Func<PlayerItemRecipe, PlayerItemRecipe>.Invoke
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>.Invoke
	|-Func<DictionaryEntry, KeyValuePair<object, object>>.Invoke
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>.Invoke
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>.Invoke
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>.Invoke
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>.Invoke
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x16CD280 Offset: 0x16CC680 VA: 0x1816CD280
	|-Func<Debugging.EntityInfo, bool>.Invoke
	|-Func<RCon.BannedAddresses, bool>.Invoke
	|-Func<WeightedStringList.Container, bool>.Invoke
	|-Func<GameStat.Stat, bool>.Invoke
	|-Func<PlayerItemRecipe, bool>.Invoke
	|-Func<DictionaryEntry, bool>.Invoke
	|-Func<KeyValuePair<object, int>, bool>.Invoke
	|-Func<KeyValuePair<object, object>, bool>.Invoke
	|-Func<KeyValuePair<uint, object>, bool>.Invoke
	|
	|-RVA: 0x1B8D410 Offset: 0x1B8C810 VA: 0x181B8D410
	|-Func<Demos.DemoInfo, DateTime>.Invoke
	|-Func<Demos.DemoInfo, TimeSpan>.Invoke
	|-Func<InventoryItem, PathFinder.Point>.Invoke
	|-Func<InventoryItem, InventoryItemId>.Invoke
	|
	|-RVA: 0x1B89820 Offset: 0x1B88C20 VA: 0x181B89820
	|-Func<Demos.DemoInfo, object>.Invoke
	|-Func<SkinnedMultiMesh.Part, long>.Invoke
	|-Func<InventoryItem, long>.Invoke
	|-Func<InventoryItem, object>.Invoke
	|
	|-RVA: 0x16CD5C0 Offset: 0x16CC9C0 VA: 0x1816CD5C0
	|-Func<BurstCloth.Chain, FourBitNumber>.Invoke
	|-Func<BurstCloth.Chain, SevenBitNumber>.Invoke
	|-Func<BurstCloth.Chain, bool>.Invoke
	|-Func<PathFinder.Point, bool>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, bool>.Invoke
	|-Func<Achievement, bool>.Invoke
	|-Func<InventoryItemId, bool>.Invoke
	|-Func<Friend, bool>.Invoke
	|
	|-RVA: 0x1B136D0 Offset: 0x1B12AD0 VA: 0x181B136D0
	|-Func<BurstCloth.Chain, int>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, int>.Invoke
	|
	|-RVA: 0x1B8E910 Offset: 0x1B8DD10 VA: 0x181B8E910
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.Invoke
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x1B91AD0 Offset: 0x1B90ED0 VA: 0x181B91AD0
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.Invoke
	|-Func<InventoryItem.Amount, InventoryItemId>.Invoke
	|
	|-RVA: 0x1B8EDB0 Offset: 0x1B8E1B0 VA: 0x181B8EDB0
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<SkeletonDefinition.Bone, Resolution>.Invoke
	|
	|-RVA: 0x1B880D0 Offset: 0x1B874D0 VA: 0x181B880D0
	|-Func<SkeletonDefinition.Bone, Option>.Invoke
	|-Func<SkeletonDefinition.Bone, InventoryItem>.Invoke
	|
	|-RVA: 0x1B8E150 Offset: 0x1B8D550 VA: 0x181B8E150
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Invoke
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.Invoke
	|
	|-RVA: 0x16CE230 Offset: 0x16CD630 VA: 0x1816CE230
	|-Func<SkeletonDefinition.Bone, bool>.Invoke
	|-Func<InventoryItem.Amount, bool>.Invoke
	|
	|-RVA: 0x1B8E5E0 Offset: 0x1B8D9E0 VA: 0x181B8E5E0
	|-Func<SkeletonDefinition.Bone, int>.Invoke
	|-Func<SkeletonDefinition.Bone, Int32Enum>.Invoke
	|
	|-RVA: 0x1B88CE0 Offset: 0x1B880E0 VA: 0x181B88CE0
	|-Func<SkeletonDefinition.Bone, long>.Invoke
	|-Func<SkeletonDefinition.Bone, object>.Invoke
	|
	|-RVA: 0x1B88550 Offset: 0x1B87950 VA: 0x181B88550
	|-Func<SkeletonDefinition.Bone, float>.Invoke
	|
	|-RVA: 0x1B8C9D0 Offset: 0x1B8BDD0 VA: 0x181B8C9D0
	|-Func<WeightedStringList.Container, float>.Invoke
	|-Func<PlayerItemRecipe, float>.Invoke
	|-Func<KeyValuePair<object, object>, float>.Invoke
	|-Func<KeyValuePair<uint, object>, float>.Invoke
	|
	|-RVA: 0x18A2F60 Offset: 0x18A2360 VA: 0x1818A2F60
	|-Func<FourBitNumber, FourBitNumber>.Invoke
	|-Func<FourBitNumber, bool>.Invoke
	|-Func<SevenBitNumber, SevenBitNumber>.Invoke
	|-Func<SevenBitNumber, bool>.Invoke
	|
	|-RVA: 0x1B90530 Offset: 0x1B8F930 VA: 0x181B90530
	|-Func<SevenBitNumber, object>.Invoke
	|
	|-RVA: 0x1B8F780 Offset: 0x1B8EB80 VA: 0x181B8F780
	|-Func<PathFinder.Point, PathFinder.Point>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Invoke
	|-Func<Achievement, PathFinder.Point>.Invoke
	|-Func<InventoryItemId, InventoryItemId>.Invoke
	|-Func<Friend, PathFinder.Point>.Invoke
	|
	|-RVA: 0x16CF200 Offset: 0x16CE600 VA: 0x1816CF200
	|-Func<PetCommandList.PetCommandDesc, bool>.Invoke
	|
	|-RVA: 0x1B8A4A0 Offset: 0x1B898A0 VA: 0x181B8A4A0
	|-Func<PlayerItemRecipe, PathFinder.Point>.Invoke
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.Invoke
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.Invoke
	|
	|-RVA: 0x1B8B880 Offset: 0x1B8AC80 VA: 0x181B8B880
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<PlayerItemRecipe, Resolution>.Invoke
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<KeyValuePair<object, object>, Resolution>.Invoke
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<KeyValuePair<uint, object>, Resolution>.Invoke
	|
	|-RVA: 0x1B8B200 Offset: 0x1B8A600 VA: 0x181B8B200
	|-Func<PlayerItemRecipe, Option>.Invoke
	|-Func<PlayerItemRecipe, InventoryItem>.Invoke
	|-Func<KeyValuePair<object, object>, Option>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryItem>.Invoke
	|-Func<KeyValuePair<uint, object>, Option>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryItem>.Invoke
	|
	|-RVA: 0x1B8B540 Offset: 0x1B8A940 VA: 0x181B8B540
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.Invoke
	|-Func<PlayerItemRecipe, InventoryRecipe>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B8DE90 Offset: 0x1B8D290 VA: 0x181B8DE90
	|-Func<PlayerItemRecipe, int>.Invoke
	|-Func<PlayerItemRecipe, Int32Enum>.Invoke
	|-Func<KeyValuePair<object, object>, int>.Invoke
	|-Func<KeyValuePair<object, object>, Int32Enum>.Invoke
	|-Func<KeyValuePair<uint, object>, int>.Invoke
	|-Func<KeyValuePair<uint, object>, Int32Enum>.Invoke
	|
	|-RVA: 0x19F6840 Offset: 0x19F5C40 VA: 0x1819F6840
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Resolution, Resolution>.Invoke
	|
	|-RVA: 0x16CFB50 Offset: 0x16CEF50 VA: 0x1816CFB50
	|-Func<ProjectileWeaponMod.Modifier, bool>.Invoke
	|-Func<Resolution, bool>.Invoke
	|
	|-RVA: 0x1B90180 Offset: 0x1B8F580 VA: 0x181B90180
	|-Func<ProjectileWeaponMod.Modifier, float>.Invoke
	|
	|-RVA: 0x1B91050 Offset: 0x1B90450 VA: 0x181B91050
	|-Func<Option, Option>.Invoke
	|-Func<InventoryItem, Option>.Invoke
	|-Func<InventoryItem, InventoryItem>.Invoke
	|
	|-RVA: 0x1B8CD10 Offset: 0x1B8C110 VA: 0x181B8CD10
	|-Func<ServerInfo, Debugging.EntityInfo>.Invoke
	|-Func<ServerInfo, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x189EDA0 Offset: 0x189E1A0 VA: 0x18189EDA0
	|-Func<ServerInfo, FourBitNumber>.Invoke
	|-Func<ServerInfo, SevenBitNumber>.Invoke
	|-Func<ServerInfo, bool>.Invoke
	|-Func<ServerInfo, bool>.Invoke
	|
	|-RVA: 0x1B8D7E0 Offset: 0x1B8CBE0 VA: 0x181B8D7E0
	|-Func<ServerInfo, PathFinder.Point>.Invoke
	|
	|-RVA: 0x1B8BC00 Offset: 0x1B8B000 VA: 0x181B8BC00
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<ServerInfo, Resolution>.Invoke
	|
	|-RVA: 0x1B89130 Offset: 0x1B88530 VA: 0x181B89130
	|-Func<ServerInfo, Option>.Invoke
	|-Func<ServerInfo, InventoryItem>.Invoke
	|
	|-RVA: 0x1B8AB10 Offset: 0x1B89F10 VA: 0x181B8AB10
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.Invoke
	|-Func<ServerInfo, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B8F250 Offset: 0x1B8E650 VA: 0x181B8F250
	|-Func<ServerInfo, int>.Invoke
	|-Func<ServerInfo, Int32Enum>.Invoke
	|
	|-RVA: 0x1B89BE0 Offset: 0x1B88FE0 VA: 0x181B89BE0
	|-Func<ServerInfo, long>.Invoke
	|-Func<ServerInfo, object>.Invoke
	|-Func<ServerInfo, object>.Invoke
	|
	|-RVA: 0x1B91F10 Offset: 0x1B91310 VA: 0x181B91F10
	|-Func<ServerInfo, float>.Invoke
	|
	|-RVA: 0x1B8C310 Offset: 0x1B8B710 VA: 0x181B8C310
	|-Func<ServerInfo, uint>.Invoke
	|-Func<ServerInfo, int>.Invoke
	|
	|-RVA: 0x1B91460 Offset: 0x1B90860 VA: 0x181B91460
	|-Func<Achievement, Debugging.EntityInfo>.Invoke
	|-Func<Achievement, KeyValuePair<object, int>>.Invoke
	|-Func<Friend, Debugging.EntityInfo>.Invoke
	|-Func<Friend, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x1B90830 Offset: 0x1B8FC30 VA: 0x181B90830
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Achievement, Resolution>.Invoke
	|-Func<Friend, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Friend, Resolution>.Invoke
	|
	|-RVA: 0x1B8A7E0 Offset: 0x1B89BE0 VA: 0x181B8A7E0
	|-Func<Achievement, Option>.Invoke
	|-Func<Achievement, InventoryItem>.Invoke
	|-Func<Friend, Option>.Invoke
	|-Func<Friend, InventoryItem>.Invoke
	|
	|-RVA: 0x1B8FE50 Offset: 0x1B8F250 VA: 0x181B8FE50
	|-Func<Achievement, InventoryRecipe.Ingredient>.Invoke
	|-Func<Achievement, InventoryRecipe>.Invoke
	|-Func<Friend, InventoryRecipe.Ingredient>.Invoke
	|-Func<Friend, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B8A2A0 Offset: 0x1B896A0 VA: 0x181B8A2A0
	|-Func<Achievement, int>.Invoke
	|-Func<Achievement, Int32Enum>.Invoke
	|-Func<Friend, int>.Invoke
	|-Func<Friend, Int32Enum>.Invoke
	|
	|-RVA: 0x19F7FE0 Offset: 0x19F73E0 VA: 0x1819F7FE0
	|-Func<Achievement, long>.Invoke
	|-Func<Achievement, object>.Invoke
	|-Func<Friend, long>.Invoke
	|-Func<Friend, object>.Invoke
	|-Func<ValueTuple<Int32Enum, int>, object>.Invoke
	|
	|-RVA: 0x1B917D0 Offset: 0x1B90BD0 VA: 0x181B917D0
	|-Func<Achievement, float>.Invoke
	|-Func<Friend, float>.Invoke
	|
	|-RVA: 0x2129210 Offset: 0x2128610 VA: 0x182129210
	|-Func<InventoryDefId, Debugging.EntityInfo>.Invoke
	|-Func<InventoryDefId, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x2127630 Offset: 0x2126A30 VA: 0x182127630
	|-Func<InventoryDefId, PathFinder.Point>.Invoke
	|
	|-RVA: 0x2126780 Offset: 0x2125B80 VA: 0x182126780
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryDefId, Resolution>.Invoke
	|
	|-RVA: 0x212A770 Offset: 0x2129B70 VA: 0x18212A770
	|-Func<InventoryDefId, Option>.Invoke
	|-Func<InventoryDefId, InventoryItem>.Invoke
	|
	|-RVA: 0x2127FD0 Offset: 0x21273D0 VA: 0x182127FD0
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryDefId, InventoryRecipe>.Invoke
	|
	|-RVA: 0x18A1830 Offset: 0x18A0C30 VA: 0x1818A1830
	|-Func<InventoryDefId, bool>.Invoke
	|
	|-RVA: 0x212B3C0 Offset: 0x212A7C0 VA: 0x18212B3C0
	|-Func<InventoryDefId, int>.Invoke
	|-Func<InventoryDefId, Int32Enum>.Invoke
	|
	|-RVA: 0x212A0C0 Offset: 0x21294C0 VA: 0x18212A0C0
	|-Func<InventoryDefId, long>.Invoke
	|-Func<InventoryDefId, object>.Invoke
	|
	|-RVA: 0x212D640 Offset: 0x212CA40 VA: 0x18212D640
	|-Func<InventoryDefId, float>.Invoke
	|
	|-RVA: 0x2126AF0 Offset: 0x2125EF0 VA: 0x182126AF0
	|-Func<ServerInfo, ServerInfo>.Invoke
	|
	|-RVA: 0x212C7D0 Offset: 0x212BBD0 VA: 0x18212C7D0
	|-Func<InventoryItem, Debugging.EntityInfo>.Invoke
	|-Func<InventoryItem, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x2128E00 Offset: 0x2128200 VA: 0x182128E00
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryItem, Resolution>.Invoke
	|
	|-RVA: 0x212A3B0 Offset: 0x21297B0 VA: 0x18212A3B0
	|-Func<InventoryItem, InventoryDefId>.Invoke
	|-Func<InventoryItem, uint>.Invoke
	|
	|-RVA: 0x21286A0 Offset: 0x2127AA0 VA: 0x1821286A0
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryItem, InventoryRecipe>.Invoke
	|
	|-RVA: 0x2127CA0 Offset: 0x21270A0 VA: 0x182127CA0
	|-Func<InventoryItem, int>.Invoke
	|-Func<InventoryItem, Int32Enum>.Invoke
	|
	|-RVA: 0x2128300 Offset: 0x2127700 VA: 0x182128300
	|-Func<InventoryItem, float>.Invoke
	|
	|-RVA: 0x212D1F0 Offset: 0x212C5F0 VA: 0x18212D1F0
	|-Func<InventoryItem.Amount, uint>.Invoke
	|
	|-RVA: 0x2126180 Offset: 0x2125580 VA: 0x182126180
	|-Func<InventoryRecipe, PlayerItemRecipe>.Invoke
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Invoke
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.Invoke
	|
	|-RVA: 0x2127230 Offset: 0x2126630 VA: 0x182127230
	|-Func<InventoryRecipe, InventoryRecipe>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.Invoke
	|
	|-RVA: 0x16CEE40 Offset: 0x16CE240 VA: 0x1816CEE40
	|-Func<InventoryRecipe, bool>.Invoke
	|-Func<InventoryRecipe.Ingredient, bool>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.Invoke
	|
	|-RVA: 0x212B7C0 Offset: 0x212ABC0 VA: 0x18212B7C0
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.Invoke
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Invoke
	|
	|-RVA: 0x21298B0 Offset: 0x2128CB0 VA: 0x1821298B0
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryRecipe.Ingredient, Resolution>.Invoke
	|
	|-RVA: 0x2129CC0 Offset: 0x21290C0 VA: 0x182129CC0
	|-Func<InventoryRecipe.Ingredient, Option>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.Invoke
	|
	|-RVA: 0x2128AB0 Offset: 0x2127EB0 VA: 0x182128AB0
	|-Func<InventoryRecipe.Ingredient, int>.Invoke
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.Invoke
	|
	|-RVA: 0x212ACA0 Offset: 0x212A0A0 VA: 0x18212ACA0
	|-Func<InventoryRecipe.Ingredient, float>.Invoke
	|
	|-RVA: 0x212BEC0 Offset: 0x212B2C0 VA: 0x18212BEC0
	|-Func<Item, DateTime>.Invoke
	|
	|-RVA: 0x189E6A0 Offset: 0x189DAA0 VA: 0x18189E6A0
	|-Func<bool, bool>.Invoke
	|
	|-RVA: 0x18A0FE0 Offset: 0x18A03E0 VA: 0x1818A0FE0
	|-Func<char, bool>.Invoke
	|
	|-RVA: 0x1B11DC0 Offset: 0x1B111C0 VA: 0x181B11DC0
	|-Func<KeyValuePair<object, int>, int>.Invoke
	|-Func<KeyValuePair<uint, object>, uint>.Invoke
	|-Func<Guid, int>.Invoke
	|
	|-RVA: 0x212CBE0 Offset: 0x212BFE0 VA: 0x18212CBE0
	|-Func<double, double>.Invoke
	|
	|-RVA: 0x1468840 Offset: 0x1467C40 VA: 0x181468840
	|-Func<int, FourBitNumber>.Invoke
	|-Func<int, SevenBitNumber>.Invoke
	|-Func<uint, bool>.Invoke
	|
	|-RVA: 0x212B5C0 Offset: 0x212A9C0 VA: 0x18212B5C0
	|-Func<int, object>.Invoke
	|-Func<Int32Enum, object>.Invoke
	|
	|-RVA: 0x212B050 Offset: 0x212A450 VA: 0x18212B050
	|-Func<Int32Enum, Debugging.EntityInfo>.Invoke
	|-Func<Int32Enum, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x212CEF0 Offset: 0x212C2F0 VA: 0x18212CEF0
	|-Func<Int32Enum, PathFinder.Point>.Invoke
	|
	|-RVA: 0x2127930 Offset: 0x2126D30 VA: 0x182127930
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Int32Enum, Resolution>.Invoke
	|
	|-RVA: 0x212BB90 Offset: 0x212AF90 VA: 0x18212BB90
	|-Func<Int32Enum, Option>.Invoke
	|-Func<Int32Enum, InventoryItem>.Invoke
	|
	|-RVA: 0x2129580 Offset: 0x2128980 VA: 0x182129580
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.Invoke
	|-Func<Int32Enum, InventoryRecipe>.Invoke
	|
	|-RVA: 0x20C2400 Offset: 0x20C1800 VA: 0x1820C2400
	|-Func<Int32Enum, long>.Invoke
	|
	|-RVA: 0x19F5900 Offset: 0x19F4D00 VA: 0x1819F5900
	|-Func<long, long>.Invoke
	|-Func<IntPtr, object>.Invoke
	|-Func<ulong, ulong>.Invoke
	|
	|-RVA: 0x19F44C0 Offset: 0x19F38C0 VA: 0x1819F44C0
	|-Func<object, Debugging.EntityInfo>.Invoke
	|-Func<object, PlayerItemRecipe>.Invoke
	|-Func<object, KeyValuePair<object, int>>.Invoke
	|-Func<object, DateTimeOffset>.Invoke
	|-Func<object, Guid>.Invoke
	|-Func<object, UdpReceiveResult>.Invoke
	|
	|-RVA: 0x1780DE0 Offset: 0x17801E0 VA: 0x181780DE0
	|-Func<object, FourBitNumber>.Invoke
	|-Func<object, SevenBitNumber>.Invoke
	|
	|-RVA: 0x19F63C0 Offset: 0x19F57C0 VA: 0x1819F63C0
	|-Func<object, PathFinder.Point>.Invoke
	|-Func<object, PlayerItemRecipe.Ingredient>.Invoke
	|-Func<object, DateTime>.Invoke
	|-Func<object, Nullable<int>>.Invoke
	|-Func<object, Nullable<Int32Enum>>.Invoke
	|
	|-RVA: 0x19F4A00 Offset: 0x19F3E00 VA: 0x1819F4A00
	|-Func<object, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<object, Nullable<InventoryResult>>.Invoke
	|-Func<object, Resolution>.Invoke
	|
	|-RVA: 0x19F4030 Offset: 0x19F3430 VA: 0x1819F4030
	|-Func<object, Option>.Invoke
	|-Func<object, InventoryItem>.Invoke
	|-Func<object, Nullable<InventoryPurchaseResult>>.Invoke
	|-Func<object, Nullable<ResultPage>>.Invoke
	|
	|-RVA: 0x19F4F40 Offset: 0x19F4340 VA: 0x1819F4F40
	|-Func<object, InventoryDefId>.Invoke
	|-Func<object, uint>.Invoke
	|
	|-RVA: 0x1486D40 Offset: 0x1486140 VA: 0x181486D40
	|-Func<object, InventoryItemId>.Invoke
	|
	|-RVA: 0x19F5C00 Offset: 0x19F5000 VA: 0x1819F5C00
	|-Func<object, InventoryRecipe.Ingredient>.Invoke
	|-Func<object, InventoryRecipe>.Invoke
	|-Func<object, PublishResult>.Invoke
	|-Func<object, Nullable<Image>>.Invoke
	|
	|-RVA: 0x19F5350 Offset: 0x19F4750 VA: 0x1819F5350
	|-Func<object, int>.Invoke
	|-Func<object, Int32Enum>.Invoke
	|
	|-RVA: 0x1472460 Offset: 0x1471860 VA: 0x181472460
	|-Func<object, long>.Invoke
	|
	|-RVA: 0x19F73A0 Offset: 0x19F67A0 VA: 0x1819F73A0
	|-Func<object, Nullable<ServerInfo>>.Invoke
	|
	|-RVA: 0x19F82E0 Offset: 0x19F76E0 VA: 0x1819F82E0
	|-Func<object, Nullable<Item>>.Invoke
	|
	|-RVA: 0x19F9160 Offset: 0x19F8560 VA: 0x1819F9160
	|-Func<object, VoidTaskResult>.Invoke
	|
	|-RVA: 0x1336020 Offset: 0x1335420 VA: 0x181336020
	|-Func<object, ulong>.Invoke
	|
	|-RVA: 0x189F660 Offset: 0x189EA60 VA: 0x18189F660
	|-Func<float, bool>.Invoke
	|
	|-RVA: 0x19F6C20 Offset: 0x19F6020 VA: 0x1819F6C20
	|-Func<float, float>.Invoke
	|
	|-RVA: 0x19F5610 Offset: 0x19F4A10 VA: 0x1819F5610
	|-Func<uint, uint>.Invoke
	|
	|-RVA: 0x19F7C40 Offset: 0x19F7040 VA: 0x1819F7C40
	|-Func<Resolution, int>.Invoke
	|
	|-RVA: 0x19F78A0 Offset: 0x19F6CA0 VA: 0x1819F78A0
	|-Func<Resolution, Vector2Int>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T arg, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B87650 Offset: 0x1B86A50 VA: 0x181B87650
	|-Func<Admin.PlayerInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B85CD0 Offset: 0x1B850D0 VA: 0x181B85CD0
	|-Func<Admin.ServerConvarInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B863D0 Offset: 0x1B857D0 VA: 0x181B863D0
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B87C50 Offset: 0x1B87050 VA: 0x181B87C50
	|-Func<Debugging.EntityInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B86D50 Offset: 0x1B86150 VA: 0x181B86D50
	|-Func<Entity.EntityInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B86C50 Offset: 0x1B86050 VA: 0x181B86C50
	|-Func<Demos.DemoInfo, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B867D0 Offset: 0x1B85BD0 VA: 0x181B867D0
	|-Func<Demos.DemoInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B86CD0 Offset: 0x1B860D0 VA: 0x181B86CD0
	|-Func<Demos.DemoInfo, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B86A50 Offset: 0x1B85E50 VA: 0x181B86A50
	|-Func<BurstCloth.Chain, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B88050 Offset: 0x1B87450 VA: 0x181B88050
	|-Func<BurstCloth.Chain, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B85A50 Offset: 0x1B84E50 VA: 0x181B85A50
	|-Func<BurstCloth.Chain, bool>.BeginInvoke
	|
	|-RVA: 0x1B85850 Offset: 0x1B84C50 VA: 0x181B85850
	|-Func<BurstCloth.Chain, int>.BeginInvoke
	|
	|-RVA: 0x1B85DD0 Offset: 0x1B851D0 VA: 0x181B85DD0
	|-Func<RCon.BannedAddresses, bool>.BeginInvoke
	|
	|-RVA: 0x1B86350 Offset: 0x1B85750 VA: 0x181B86350
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B86650 Offset: 0x1B85A50 VA: 0x181B86650
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B857D0 Offset: 0x1B84BD0 VA: 0x181B857D0
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B873D0 Offset: 0x1B867D0 VA: 0x181B873D0
	|-Func<SkeletonDefinition.Bone, Option>.BeginInvoke
	|
	|-RVA: 0x1B87250 Offset: 0x1B86650 VA: 0x181B87250
	|-Func<SkeletonDefinition.Bone, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B875D0 Offset: 0x1B869D0 VA: 0x181B875D0
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B85650 Offset: 0x1B84A50 VA: 0x181B85650
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B874D0 Offset: 0x1B868D0 VA: 0x181B874D0
	|-Func<SkeletonDefinition.Bone, bool>.BeginInvoke
	|
	|-RVA: 0x1B86B50 Offset: 0x1B85F50 VA: 0x181B86B50
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B86450 Offset: 0x1B85850 VA: 0x181B86450
	|-Func<SkeletonDefinition.Bone, int>.BeginInvoke
	|
	|-RVA: 0x1B871D0 Offset: 0x1B865D0 VA: 0x181B871D0
	|-Func<SkeletonDefinition.Bone, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B87AD0 Offset: 0x1B86ED0 VA: 0x181B87AD0
	|-Func<SkeletonDefinition.Bone, long>.BeginInvoke
	|
	|-RVA: 0x1B86850 Offset: 0x1B85C50 VA: 0x181B86850
	|-Func<SkeletonDefinition.Bone, object>.BeginInvoke
	|
	|-RVA: 0x1B878D0 Offset: 0x1B86CD0 VA: 0x181B878D0
	|-Func<SkeletonDefinition.Bone, float>.BeginInvoke
	|
	|-RVA: 0x1B86950 Offset: 0x1B85D50 VA: 0x181B86950
	|-Func<SkeletonDefinition.Bone, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B853D0 Offset: 0x1B847D0 VA: 0x181B853D0
	|-Func<WeightedStringList.Container, bool>.BeginInvoke
	|
	|-RVA: 0x1B87ED0 Offset: 0x1B872D0 VA: 0x181B87ED0
	|-Func<WeightedStringList.Container, float>.BeginInvoke
	|
	|-RVA: 0x1B84DD0 Offset: 0x1B841D0 VA: 0x181B84DD0
	|-Func<GameStat.Stat, bool>.BeginInvoke
	|
	|-RVA: 0x1B84D50 Offset: 0x1B84150 VA: 0x181B84D50
	|-Func<ImageStorageEntity.ImageRequest, object>.BeginInvoke
	|
	|-RVA: 0x1B87CD0 Offset: 0x1B870D0 VA: 0x181B87CD0
	|-Func<ItemSkinDirectory.Skin, bool>.BeginInvoke
	|
	|-RVA: 0x1B85D50 Offset: 0x1B85150 VA: 0x181B85D50
	|-Func<FourBitNumber, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B85B50 Offset: 0x1B84F50 VA: 0x181B85B50
	|-Func<FourBitNumber, bool>.BeginInvoke
	|
	|-RVA: 0x1B872D0 Offset: 0x1B866D0 VA: 0x181B872D0
	|-Func<SevenBitNumber, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B87050 Offset: 0x1B86450 VA: 0x181B87050
	|-Func<SevenBitNumber, bool>.BeginInvoke
	|
	|-RVA: 0x1B85350 Offset: 0x1B84750 VA: 0x181B85350
	|-Func<SevenBitNumber, object>.BeginInvoke
	|
	|-RVA: 0x1B87950 Offset: 0x1B86D50 VA: 0x181B87950
	|-Func<DefaultSerializationBinder.TypeNameKey, object>.BeginInvoke
	|
	|-RVA: 0x1B85550 Offset: 0x1B84950 VA: 0x181B85550
	|-Func<ConvertUtils.TypeConvertKey, object>.BeginInvoke
	|
	|-RVA: 0x1B87A50 Offset: 0x1B86E50 VA: 0x181B87A50
	|-Func<PathFinder.Point, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B85ED0 Offset: 0x1B852D0 VA: 0x181B85ED0
	|-Func<PathFinder.Point, bool>.BeginInvoke
	|
	|-RVA: 0x1B86150 Offset: 0x1B85550 VA: 0x181B86150
	|-Func<PetCommandList.PetCommandDesc, bool>.BeginInvoke
	|
	|-RVA: 0x1B84FD0 Offset: 0x1B843D0 VA: 0x181B84FD0
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B852D0 Offset: 0x1B846D0 VA: 0x181B852D0
	|-Func<PlayerItemRecipe, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B85E50 Offset: 0x1B85250 VA: 0x181B85E50
	|-Func<PlayerItemRecipe, PlayerItemRecipe>.BeginInvoke
	|
	|-RVA: 0x1B851D0 Offset: 0x1B845D0 VA: 0x181B851D0
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B86550 Offset: 0x1B85950 VA: 0x181B86550
	|-Func<PlayerItemRecipe, Option>.BeginInvoke
	|
	|-RVA: 0x1B87750 Offset: 0x1B86B50 VA: 0x181B87750
	|-Func<PlayerItemRecipe, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B85750 Offset: 0x1B84B50 VA: 0x181B85750
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B854D0 Offset: 0x1B848D0 VA: 0x181B854D0
	|-Func<PlayerItemRecipe, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B86250 Offset: 0x1B85650 VA: 0x181B86250
	|-Func<PlayerItemRecipe, bool>.BeginInvoke
	|
	|-RVA: 0x1B855D0 Offset: 0x1B849D0 VA: 0x181B855D0
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B86ED0 Offset: 0x1B862D0 VA: 0x181B86ED0
	|-Func<PlayerItemRecipe, int>.BeginInvoke
	|
	|-RVA: 0x1B85250 Offset: 0x1B84650 VA: 0x181B85250
	|-Func<PlayerItemRecipe, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B86BD0 Offset: 0x1B85FD0 VA: 0x181B86BD0
	|-Func<PlayerItemRecipe, long>.BeginInvoke
	|
	|-RVA: 0x1B85FD0 Offset: 0x1B853D0 VA: 0x181B85FD0
	|-Func<PlayerItemRecipe, object>.BeginInvoke
	|
	|-RVA: 0x1B86F50 Offset: 0x1B86350 VA: 0x181B86F50
	|-Func<PlayerItemRecipe, float>.BeginInvoke
	|
	|-RVA: 0x1B84F50 Offset: 0x1B84350 VA: 0x181B84F50
	|-Func<PlayerItemRecipe, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B86750 Offset: 0x1B85B50 VA: 0x181B86750
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B864D0 Offset: 0x1B858D0 VA: 0x181B864D0
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B856D0 Offset: 0x1B84AD0 VA: 0x181B856D0
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B87850 Offset: 0x1B86C50 VA: 0x181B87850
	|-Func<PlayerItemRecipe.Ingredient, bool>.BeginInvoke
	|
	|-RVA: 0x1B85C50 Offset: 0x1B85050 VA: 0x181B85C50
	|-Func<PlayerItemRecipe.Ingredient, int>.BeginInvoke
	|
	|-RVA: 0x1B868D0 Offset: 0x1B85CD0 VA: 0x181B868D0
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B85050 Offset: 0x1B84450 VA: 0x181B85050
	|-Func<ProjectileWeaponMod.Modifier, bool>.BeginInvoke
	|
	|-RVA: 0x1B87B50 Offset: 0x1B86F50 VA: 0x181B87B50
	|-Func<ProjectileWeaponMod.Modifier, float>.BeginInvoke
	|
	|-RVA: 0x1B87BD0 Offset: 0x1B86FD0 VA: 0x181B87BD0
	|-Func<Option, Option>.BeginInvoke
	|
	|-RVA: 0x1B87FD0 Offset: 0x1B873D0 VA: 0x181B87FD0
	|-Func<Option, bool>.BeginInvoke
	|
	|-RVA: 0x1B861D0 Offset: 0x1B855D0 VA: 0x181B861D0
	|-Func<ServerInfo, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B85950 Offset: 0x1B84D50 VA: 0x181B85950
	|-Func<ServerInfo, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B865D0 Offset: 0x1B859D0 VA: 0x181B865D0
	|-Func<ServerInfo, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B85AD0 Offset: 0x1B84ED0 VA: 0x181B85AD0
	|-Func<ServerInfo, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B858D0 Offset: 0x1B84CD0 VA: 0x181B858D0
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B84ED0 Offset: 0x1B842D0 VA: 0x181B84ED0
	|-Func<ServerInfo, Option>.BeginInvoke
	|
	|-RVA: 0x1B870D0 Offset: 0x1B864D0 VA: 0x181B870D0
	|-Func<ServerInfo, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B85F50 Offset: 0x1B85350 VA: 0x181B85F50
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B84E50 Offset: 0x1B84250 VA: 0x181B84E50
	|-Func<ServerInfo, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B879D0 Offset: 0x1B86DD0 VA: 0x181B879D0
	|-Func<ServerInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B86AD0 Offset: 0x1B85ED0 VA: 0x181B86AD0
	|-Func<ServerInfo, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B877D0 Offset: 0x1B86BD0 VA: 0x181B877D0
	|-Func<ServerInfo, int>.BeginInvoke
	|
	|-RVA: 0x1B87150 Offset: 0x1B86550 VA: 0x181B87150
	|-Func<ServerInfo, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B869D0 Offset: 0x1B85DD0 VA: 0x181B869D0
	|-Func<ServerInfo, long>.BeginInvoke
	|
	|-RVA: 0x1B87350 Offset: 0x1B86750 VA: 0x181B87350
	|-Func<ServerInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B859D0 Offset: 0x1B84DD0 VA: 0x181B859D0
	|-Func<ServerInfo, float>.BeginInvoke
	|
	|-RVA: 0x1B866D0 Offset: 0x1B85AD0 VA: 0x181B866D0
	|-Func<ServerInfo, uint>.BeginInvoke
	|
	|-RVA: 0x1B85150 Offset: 0x1B84550 VA: 0x181B85150
	|-Func<ServerInfo, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B87450 Offset: 0x1B86850 VA: 0x181B87450
	|-Func<SkinnedMultiMesh.Part, bool>.BeginInvoke
	|
	|-RVA: 0x1B86E50 Offset: 0x1B86250 VA: 0x181B86E50
	|-Func<SkinnedMultiMesh.Part, long>.BeginInvoke
	|
	|-RVA: 0x1B87F50 Offset: 0x1B87350 VA: 0x181B87F50
	|-Func<Achievement, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B876D0 Offset: 0x1B86AD0 VA: 0x181B876D0
	|-Func<Achievement, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B86050 Offset: 0x1B85450 VA: 0x181B86050
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B85450 Offset: 0x1B84850 VA: 0x181B85450
	|-Func<Achievement, Option>.BeginInvoke
	|
	|-RVA: 0x1B86FD0 Offset: 0x1B863D0 VA: 0x181B86FD0
	|-Func<Achievement, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B860D0 Offset: 0x1B854D0 VA: 0x181B860D0
	|-Func<Achievement, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B87D50 Offset: 0x1B87150 VA: 0x181B87D50
	|-Func<Achievement, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B850D0 Offset: 0x1B844D0 VA: 0x181B850D0
	|-Func<Achievement, bool>.BeginInvoke
	|
	|-RVA: 0x1B87DD0 Offset: 0x1B871D0 VA: 0x181B87DD0
	|-Func<Achievement, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B862D0 Offset: 0x1B856D0 VA: 0x181B862D0
	|-Func<Achievement, int>.BeginInvoke
	|
	|-RVA: 0x1B86DD0 Offset: 0x1B861D0 VA: 0x181B86DD0
	|-Func<Achievement, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B87550 Offset: 0x1B86950 VA: 0x181B87550
	|-Func<Achievement, long>.BeginInvoke
	|
	|-RVA: 0x1B84CD0 Offset: 0x1B840D0 VA: 0x181B84CD0
	|-Func<Achievement, object>.BeginInvoke
	|
	|-RVA: 0x1B85BD0 Offset: 0x1B84FD0 VA: 0x181B85BD0
	|-Func<Achievement, float>.BeginInvoke
	|
	|-RVA: 0x1B87E50 Offset: 0x1B87250 VA: 0x181B87E50
	|-Func<Achievement, Resolution>.BeginInvoke
	|
	|-RVA: 0x2122260 Offset: 0x2121660 VA: 0x182122260
	|-Func<InventoryDefId, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2123DE0 Offset: 0x21231E0 VA: 0x182123DE0
	|-Func<InventoryDefId, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2121760 Offset: 0x2120B60 VA: 0x182121760
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2123960 Offset: 0x2122D60 VA: 0x182123960
	|-Func<InventoryDefId, Option>.BeginInvoke
	|
	|-RVA: 0x21235E0 Offset: 0x21229E0 VA: 0x1821235E0
	|-Func<InventoryDefId, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x21258E0 Offset: 0x2124CE0 VA: 0x1821258E0
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x21216E0 Offset: 0x2120AE0 VA: 0x1821216E0
	|-Func<InventoryDefId, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2124760 Offset: 0x2123B60 VA: 0x182124760
	|-Func<InventoryDefId, bool>.BeginInvoke
	|
	|-RVA: 0x2124FE0 Offset: 0x21243E0 VA: 0x182124FE0
	|-Func<InventoryDefId, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2121560 Offset: 0x2120960 VA: 0x182121560
	|-Func<InventoryDefId, int>.BeginInvoke
	|
	|-RVA: 0x2124BE0 Offset: 0x2123FE0 VA: 0x182124BE0
	|-Func<InventoryDefId, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2122EE0 Offset: 0x21222E0 VA: 0x182122EE0
	|-Func<InventoryDefId, long>.BeginInvoke
	|
	|-RVA: 0x21257E0 Offset: 0x2124BE0 VA: 0x1821257E0
	|-Func<InventoryDefId, object>.BeginInvoke
	|
	|-RVA: 0x2121F60 Offset: 0x2121360 VA: 0x182121F60
	|-Func<InventoryDefId, float>.BeginInvoke
	|
	|-RVA: 0x21236E0 Offset: 0x2122AE0 VA: 0x1821236E0
	|-Func<InventoryDefId, Resolution>.BeginInvoke
	|
	|-RVA: 0x2122CE0 Offset: 0x21220E0 VA: 0x182122CE0
	|-Func<InventoryItemId, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x21221E0 Offset: 0x21215E0 VA: 0x1821221E0
	|-Func<InventoryItemId, bool>.BeginInvoke
	|
	|-RVA: 0x2124B60 Offset: 0x2123F60 VA: 0x182124B60
	|-Func<ServerInfo, ServerInfo>.BeginInvoke
	|
	|-RVA: 0x2125E60 Offset: 0x2125260 VA: 0x182125E60
	|-Func<ServerInfo, bool>.BeginInvoke
	|
	|-RVA: 0x2123460 Offset: 0x2122860 VA: 0x182123460
	|-Func<ServerInfo, int>.BeginInvoke
	|
	|-RVA: 0x2121BE0 Offset: 0x2120FE0 VA: 0x182121BE0
	|-Func<ServerInfo, object>.BeginInvoke
	|
	|-RVA: 0x2125FE0 Offset: 0x21253E0 VA: 0x182125FE0
	|-Func<Friend, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2123B60 Offset: 0x2122F60 VA: 0x182123B60
	|-Func<Friend, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2122B60 Offset: 0x2121F60 VA: 0x182122B60
	|-Func<Friend, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x21255E0 Offset: 0x21249E0 VA: 0x1821255E0
	|-Func<Friend, Option>.BeginInvoke
	|
	|-RVA: 0x2125160 Offset: 0x2124560 VA: 0x182125160
	|-Func<Friend, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x2121B60 Offset: 0x2120F60 VA: 0x182121B60
	|-Func<Friend, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2122360 Offset: 0x2121760 VA: 0x182122360
	|-Func<Friend, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2125760 Offset: 0x2124B60 VA: 0x182125760
	|-Func<Friend, bool>.BeginInvoke
	|
	|-RVA: 0x2125060 Offset: 0x2124460 VA: 0x182125060
	|-Func<Friend, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21243E0 Offset: 0x21237E0 VA: 0x1821243E0
	|-Func<Friend, int>.BeginInvoke
	|
	|-RVA: 0x2124CE0 Offset: 0x21240E0 VA: 0x182124CE0
	|-Func<Friend, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2125660 Offset: 0x2124A60 VA: 0x182125660
	|-Func<Friend, long>.BeginInvoke
	|
	|-RVA: 0x2123F60 Offset: 0x2123360 VA: 0x182123F60
	|-Func<Friend, object>.BeginInvoke
	|
	|-RVA: 0x2123CE0 Offset: 0x21230E0 VA: 0x182123CE0
	|-Func<Friend, float>.BeginInvoke
	|
	|-RVA: 0x2123A60 Offset: 0x2122E60 VA: 0x182123A60
	|-Func<Friend, Resolution>.BeginInvoke
	|
	|-RVA: 0x2122660 Offset: 0x2121A60 VA: 0x182122660
	|-Func<InventoryItem, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2125B60 Offset: 0x2124F60 VA: 0x182125B60
	|-Func<InventoryItem, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x2125860 Offset: 0x2124C60 VA: 0x182125860
	|-Func<InventoryItem, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x2122E60 Offset: 0x2122260 VA: 0x182122E60
	|-Func<InventoryItem, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2124AE0 Offset: 0x2123EE0 VA: 0x182124AE0
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2123BE0 Offset: 0x2122FE0 VA: 0x182123BE0
	|-Func<InventoryItem, Option>.BeginInvoke
	|
	|-RVA: 0x2124660 Offset: 0x2123A60 VA: 0x182124660
	|-Func<InventoryItem, InventoryDefId>.BeginInvoke
	|
	|-RVA: 0x2121AE0 Offset: 0x2120EE0 VA: 0x182121AE0
	|-Func<InventoryItem, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x2125AE0 Offset: 0x2124EE0 VA: 0x182125AE0
	|-Func<InventoryItem, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x2124E60 Offset: 0x2124260 VA: 0x182124E60
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x21222E0 Offset: 0x21216E0 VA: 0x1821222E0
	|-Func<InventoryItem, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x21231E0 Offset: 0x21225E0 VA: 0x1821231E0
	|-Func<InventoryItem, bool>.BeginInvoke
	|
	|-RVA: 0x2122BE0 Offset: 0x2121FE0 VA: 0x182122BE0
	|-Func<InventoryItem, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2123D60 Offset: 0x2123160 VA: 0x182123D60
	|-Func<InventoryItem, int>.BeginInvoke
	|
	|-RVA: 0x2124C60 Offset: 0x2124060 VA: 0x182124C60
	|-Func<InventoryItem, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2122860 Offset: 0x2121C60 VA: 0x182122860
	|-Func<InventoryItem, long>.BeginInvoke
	|
	|-RVA: 0x21239E0 Offset: 0x2122DE0 VA: 0x1821239E0
	|-Func<InventoryItem, object>.BeginInvoke
	|
	|-RVA: 0x2121FE0 Offset: 0x21213E0 VA: 0x182121FE0
	|-Func<InventoryItem, float>.BeginInvoke
	|
	|-RVA: 0x2125360 Offset: 0x2124760 VA: 0x182125360
	|-Func<InventoryItem, uint>.BeginInvoke
	|
	|-RVA: 0x2124260 Offset: 0x2123660 VA: 0x182124260
	|-Func<InventoryItem, Resolution>.BeginInvoke
	|
	|-RVA: 0x21249E0 Offset: 0x2123DE0 VA: 0x1821249E0
	|-Func<InventoryItem.Amount, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x2123060 Offset: 0x2122460 VA: 0x182123060
	|-Func<InventoryItem.Amount, bool>.BeginInvoke
	|
	|-RVA: 0x2125560 Offset: 0x2124960 VA: 0x182125560
	|-Func<InventoryItem.Amount, uint>.BeginInvoke
	|
	|-RVA: 0x2122DE0 Offset: 0x21221E0 VA: 0x182122DE0
	|-Func<InventoryRecipe, PlayerItemRecipe>.BeginInvoke
	|
	|-RVA: 0x2121960 Offset: 0x2120D60 VA: 0x182121960
	|-Func<InventoryRecipe, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2122760 Offset: 0x2121B60 VA: 0x182122760
	|-Func<InventoryRecipe, bool>.BeginInvoke
	|
	|-RVA: 0x21227E0 Offset: 0x2121BE0 VA: 0x1821227E0
	|-Func<InventoryRecipe, object>.BeginInvoke
	|
	|-RVA: 0x21230E0 Offset: 0x21224E0 VA: 0x1821230E0
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2122460 Offset: 0x2121860 VA: 0x182122460
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x21237E0 Offset: 0x2122BE0 VA: 0x1821237E0
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x21229E0 Offset: 0x2121DE0 VA: 0x1821229E0
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x21219E0 Offset: 0x2120DE0 VA: 0x1821219E0
	|-Func<InventoryRecipe.Ingredient, Option>.BeginInvoke
	|
	|-RVA: 0x2123FE0 Offset: 0x21233E0 VA: 0x182123FE0
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x2125260 Offset: 0x2124660 VA: 0x182125260
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2121C60 Offset: 0x2121060 VA: 0x182121C60
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2121EE0 Offset: 0x21212E0 VA: 0x182121EE0
	|-Func<InventoryRecipe.Ingredient, bool>.BeginInvoke
	|
	|-RVA: 0x2123AE0 Offset: 0x2122EE0 VA: 0x182123AE0
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2121A60 Offset: 0x2120E60 VA: 0x182121A60
	|-Func<InventoryRecipe.Ingredient, int>.BeginInvoke
	|
	|-RVA: 0x2123E60 Offset: 0x2123260 VA: 0x182123E60
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x21245E0 Offset: 0x21239E0 VA: 0x1821245E0
	|-Func<InventoryRecipe.Ingredient, long>.BeginInvoke
	|
	|-RVA: 0x21247E0 Offset: 0x2123BE0 VA: 0x1821247E0
	|-Func<InventoryRecipe.Ingredient, object>.BeginInvoke
	|
	|-RVA: 0x21240E0 Offset: 0x21234E0 VA: 0x1821240E0
	|-Func<InventoryRecipe.Ingredient, float>.BeginInvoke
	|
	|-RVA: 0x2121860 Offset: 0x2120C60 VA: 0x182121860
	|-Func<InventoryRecipe.Ingredient, Resolution>.BeginInvoke
	|
	|-RVA: 0x21228E0 Offset: 0x2121CE0 VA: 0x1821228E0
	|-Func<Item, DateTime>.BeginInvoke
	|
	|-RVA: 0x2125960 Offset: 0x2124D60 VA: 0x182125960
	|-Func<ArraySegment<byte>, object>.BeginInvoke
	|
	|-RVA: 0x21241E0 Offset: 0x21235E0 VA: 0x1821241E0
	|-Func<bool, bool>.BeginInvoke
	|
	|-RVA: 0x2124360 Offset: 0x2123760 VA: 0x182124360
	|-Func<char, bool>.BeginInvoke
	|
	|-RVA: 0x2123260 Offset: 0x2122660 VA: 0x182123260
	|-Func<DictionaryEntry, bool>.BeginInvoke
	|
	|-RVA: 0x2124D60 Offset: 0x2124160 VA: 0x182124D60
	|-Func<DictionaryEntry, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x21242E0 Offset: 0x21236E0 VA: 0x1821242E0
	|-Func<DictionaryEntry, object>.BeginInvoke
	|
	|-RVA: 0x2125DE0 Offset: 0x21251E0 VA: 0x182125DE0
	|-Func<KeyValuePair<object, int>, bool>.BeginInvoke
	|
	|-RVA: 0x2124960 Offset: 0x2123D60 VA: 0x182124960
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2123560 Offset: 0x2122960 VA: 0x182123560
	|-Func<KeyValuePair<object, int>, int>.BeginInvoke
	|
	|-RVA: 0x2123760 Offset: 0x2122B60 VA: 0x182123760
	|-Func<KeyValuePair<object, long>, long>.BeginInvoke
	|
	|-RVA: 0x21217E0 Offset: 0x2120BE0 VA: 0x1821217E0
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2123660 Offset: 0x2122A60 VA: 0x182123660
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2122D60 Offset: 0x2122160 VA: 0x182122D60
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2122060 Offset: 0x2121460 VA: 0x182122060
	|-Func<KeyValuePair<object, object>, Option>.BeginInvoke
	|
	|-RVA: 0x2125460 Offset: 0x2124860 VA: 0x182125460
	|-Func<KeyValuePair<object, object>, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x2124160 Offset: 0x2123560 VA: 0x182124160
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x21252E0 Offset: 0x21246E0 VA: 0x1821252E0
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2124860 Offset: 0x2123C60 VA: 0x182124860
	|-Func<KeyValuePair<object, object>, bool>.BeginInvoke
	|
	|-RVA: 0x2122FE0 Offset: 0x21223E0 VA: 0x182122FE0
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2121D60 Offset: 0x2121160 VA: 0x182121D60
	|-Func<KeyValuePair<object, object>, int>.BeginInvoke
	|
	|-RVA: 0x2125BE0 Offset: 0x2124FE0 VA: 0x182125BE0
	|-Func<KeyValuePair<object, object>, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x21232E0 Offset: 0x21226E0 VA: 0x1821232E0
	|-Func<KeyValuePair<object, object>, long>.BeginInvoke
	|
	|-RVA: 0x21215E0 Offset: 0x21209E0 VA: 0x1821215E0
	|-Func<KeyValuePair<object, object>, object>.BeginInvoke
	|
	|-RVA: 0x2125CE0 Offset: 0x21250E0 VA: 0x182125CE0
	|-Func<KeyValuePair<object, object>, float>.BeginInvoke
	|
	|-RVA: 0x2121CE0 Offset: 0x21210E0 VA: 0x182121CE0
	|-Func<KeyValuePair<object, object>, Resolution>.BeginInvoke
	|
	|-RVA: 0x21251E0 Offset: 0x21245E0 VA: 0x1821251E0
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2122960 Offset: 0x2121D60 VA: 0x182122960
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2125C60 Offset: 0x2125060 VA: 0x182125C60
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2124DE0 Offset: 0x21241E0 VA: 0x182124DE0
	|-Func<KeyValuePair<uint, object>, Option>.BeginInvoke
	|
	|-RVA: 0x21234E0 Offset: 0x21228E0 VA: 0x1821234E0
	|-Func<KeyValuePair<uint, object>, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x2126060 Offset: 0x2125460 VA: 0x182126060
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2123EE0 Offset: 0x21232E0 VA: 0x182123EE0
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2125D60 Offset: 0x2125160 VA: 0x182125D60
	|-Func<KeyValuePair<uint, object>, bool>.BeginInvoke
	|
	|-RVA: 0x2125A60 Offset: 0x2124E60 VA: 0x182125A60
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21250E0 Offset: 0x21244E0 VA: 0x1821250E0
	|-Func<KeyValuePair<uint, object>, int>.BeginInvoke
	|
	|-RVA: 0x2121DE0 Offset: 0x21211E0 VA: 0x182121DE0
	|-Func<KeyValuePair<uint, object>, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2124460 Offset: 0x2123860 VA: 0x182124460
	|-Func<KeyValuePair<uint, object>, long>.BeginInvoke
	|
	|-RVA: 0x21244E0 Offset: 0x21238E0 VA: 0x1821244E0
	|-Func<KeyValuePair<uint, object>, object>.BeginInvoke
	|
	|-RVA: 0x21224E0 Offset: 0x21218E0 VA: 0x1821224E0
	|-Func<KeyValuePair<uint, object>, float>.BeginInvoke
	|
	|-RVA: 0x2122C60 Offset: 0x2122060 VA: 0x182122C60
	|-Func<KeyValuePair<uint, object>, uint>.BeginInvoke
	|
	|-RVA: 0x21256E0 Offset: 0x2124AE0 VA: 0x1821256E0
	|-Func<KeyValuePair<uint, object>, Resolution>.BeginInvoke
	|
	|-RVA: 0x2121660 Offset: 0x2120A60 VA: 0x182121660
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.BeginInvoke
	|
	|-RVA: 0x21253E0 Offset: 0x21247E0 VA: 0x1821253E0
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.BeginInvoke
	|
	|-RVA: 0x21218E0 Offset: 0x2120CE0 VA: 0x1821218E0
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.BeginInvoke
	|
	|-RVA: 0x21238E0 Offset: 0x2122CE0 VA: 0x1821238E0
	|-Func<double, double>.BeginInvoke
	|
	|-RVA: 0x21220E0 Offset: 0x21214E0 VA: 0x1821220E0
	|-Func<Guid, int>.BeginInvoke
	|
	|-RVA: 0x2123860 Offset: 0x2122C60 VA: 0x182123860
	|-Func<Guid, object>.BeginInvoke
	|
	|-RVA: 0x2121E60 Offset: 0x2121260 VA: 0x182121E60
	|-Func<int, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x2122560 Offset: 0x2121960 VA: 0x182122560
	|-Func<int, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x21223E0 Offset: 0x21217E0 VA: 0x1821223E0
	|-Func<int, bool>.BeginInvoke
	|
	|-RVA: 0x2124560 Offset: 0x2123960 VA: 0x182124560
	|-Func<int, int>.BeginInvoke
	|
	|-RVA: 0x2122F60 Offset: 0x2122360 VA: 0x182122F60
	|-Func<int, object>.BeginInvoke
	|
	|-RVA: 0x21259E0 Offset: 0x2124DE0 VA: 0x1821259E0
	|-Func<int, float>.BeginInvoke
	|
	|-RVA: 0x21226E0 Offset: 0x2121AE0 VA: 0x1821226E0
	|-Func<Int32Enum, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x21225E0 Offset: 0x21219E0 VA: 0x1821225E0
	|-Func<Int32Enum, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2124EE0 Offset: 0x21242E0 VA: 0x182124EE0
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x21254E0 Offset: 0x21248E0 VA: 0x1821254E0
	|-Func<Int32Enum, Option>.BeginInvoke
	|
	|-RVA: 0x21233E0 Offset: 0x21227E0 VA: 0x1821233E0
	|-Func<Int32Enum, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x2122160 Offset: 0x2121560 VA: 0x182122160
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2123160 Offset: 0x2122560 VA: 0x182123160
	|-Func<Int32Enum, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2124060 Offset: 0x2123460 VA: 0x182124060
	|-Func<Int32Enum, bool>.BeginInvoke
	|
	|-RVA: 0x2122A60 Offset: 0x2121E60 VA: 0x182122A60
	|-Func<Int32Enum, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21246E0 Offset: 0x2123AE0 VA: 0x1821246E0
	|-Func<Int32Enum, int>.BeginInvoke
	|
	|-RVA: 0x21248E0 Offset: 0x2123CE0 VA: 0x1821248E0
	|-Func<Int32Enum, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2124F60 Offset: 0x2124360 VA: 0x182124F60
	|-Func<Int32Enum, long>.BeginInvoke
	|
	|-RVA: 0x2122AE0 Offset: 0x2121EE0 VA: 0x182122AE0
	|-Func<Int32Enum, object>.BeginInvoke
	|
	|-RVA: 0x2125F60 Offset: 0x2125360 VA: 0x182125F60
	|-Func<Int32Enum, float>.BeginInvoke
	|
	|-RVA: 0x2123C60 Offset: 0x2123060 VA: 0x182123C60
	|-Func<Int32Enum, Resolution>.BeginInvoke
	|
	|-RVA: 0x2124A60 Offset: 0x2123E60 VA: 0x182124A60
	|-Func<long, bool>.BeginInvoke
	|
	|-RVA: 0x2123360 Offset: 0x2122760 VA: 0x182123360
	|-Func<long, long>.BeginInvoke
	|
	|-RVA: 0x2125EE0 Offset: 0x21252E0 VA: 0x182125EE0
	|-Func<IntPtr, object>.BeginInvoke
	|
	|-RVA: 0x497210 Offset: 0x496610 VA: 0x180497210
	|-Func<object, Debugging.EntityInfo>.BeginInvoke
	|-Func<object, FourBitNumber>.BeginInvoke
	|-Func<object, SevenBitNumber>.BeginInvoke
	|-Func<object, PathFinder.Point>.BeginInvoke
	|-Func<object, PlayerItemRecipe.Ingredient>.BeginInvoke
	|-Func<object, PlayerItemRecipe>.BeginInvoke
	|-Func<object, ProjectileWeaponMod.Modifier>.BeginInvoke
	|-Func<object, Option>.BeginInvoke
	|-Func<object, InventoryDefId>.BeginInvoke
	|-Func<object, InventoryItemId>.BeginInvoke
	|-Func<object, InventoryItem>.BeginInvoke
	|-Func<object, InventoryRecipe.Ingredient>.BeginInvoke
	|-Func<object, InventoryRecipe>.BeginInvoke
	|-Func<object, PublishResult>.BeginInvoke
	|-Func<object, bool>.BeginInvoke
	|-Func<object, KeyValuePair<object, int>>.BeginInvoke
	|-Func<object, DateTime>.BeginInvoke
	|-Func<object, DateTimeOffset>.BeginInvoke
	|-Func<object, Guid>.BeginInvoke
	|-Func<object, int>.BeginInvoke
	|-Func<object, Int32Enum>.BeginInvoke
	|-Func<object, long>.BeginInvoke
	|-Func<object, UdpReceiveResult>.BeginInvoke
	|-Func<object, Nullable<ServerInfo>>.BeginInvoke
	|-Func<object, Nullable<Image>>.BeginInvoke
	|-Func<object, Nullable<InventoryPurchaseResult>>.BeginInvoke
	|-Func<object, Nullable<InventoryResult>>.BeginInvoke
	|-Func<object, Nullable<Item>>.BeginInvoke
	|-Func<object, Nullable<ResultPage>>.BeginInvoke
	|-Func<object, Nullable<int>>.BeginInvoke
	|-Func<object, Nullable<Int32Enum>>.BeginInvoke
	|-Func<object, object>.BeginInvoke
	|-Func<object, float>.BeginInvoke
	|-Func<object, VoidTaskResult>.BeginInvoke
	|-Func<object, uint>.BeginInvoke
	|-Func<object, ulong>.BeginInvoke
	|-Func<object, Resolution>.BeginInvoke
	|
	|-RVA: 0x19F3BE0 Offset: 0x19F2FE0 VA: 0x1819F3BE0
	|-Func<float, bool>.BeginInvoke
	|
	|-RVA: 0x19F3AE0 Offset: 0x19F2EE0 VA: 0x1819F3AE0
	|-Func<float, float>.BeginInvoke
	|
	|-RVA: 0x19F38E0 Offset: 0x19F2CE0 VA: 0x1819F38E0
	|-Func<uint, bool>.BeginInvoke
	|
	|-RVA: 0x19F3960 Offset: 0x19F2D60 VA: 0x1819F3960
	|-Func<uint, uint>.BeginInvoke
	|
	|-RVA: 0x19F3D60 Offset: 0x19F3160 VA: 0x1819F3D60
	|-Func<ulong, bool>.BeginInvoke
	|
	|-RVA: 0x19F3B60 Offset: 0x19F2F60 VA: 0x1819F3B60
	|-Func<ulong, ulong>.BeginInvoke
	|
	|-RVA: 0x19F39E0 Offset: 0x19F2DE0 VA: 0x1819F39E0
	|-Func<ValueTuple<Int32Enum, int>, object>.BeginInvoke
	|
	|-RVA: 0x19F3DE0 Offset: 0x19F31E0 VA: 0x1819F3DE0
	|-Func<Resolution, bool>.BeginInvoke
	|
	|-RVA: 0x19F3C60 Offset: 0x19F3060 VA: 0x1819F3C60
	|-Func<Resolution, int>.BeginInvoke
	|
	|-RVA: 0x19F3CE0 Offset: 0x19F30E0 VA: 0x1819F3CE0
	|-Func<Resolution, Resolution>.BeginInvoke
	|
	|-RVA: 0x19F3A60 Offset: 0x19F2E60 VA: 0x1819F3A60
	|-Func<Resolution, Vector2Int>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-Func<Admin.PlayerInfo, object>.EndInvoke
	|-Func<Admin.ServerConvarInfo, object>.EndInvoke
	|-Func<Demos.DemoInfo, object>.EndInvoke
	|-Func<SkeletonDefinition.Bone, object>.EndInvoke
	|-Func<ImageStorageEntity.ImageRequest, object>.EndInvoke
	|-Func<SevenBitNumber, object>.EndInvoke
	|-Func<DefaultSerializationBinder.TypeNameKey, object>.EndInvoke
	|-Func<ConvertUtils.TypeConvertKey, object>.EndInvoke
	|-Func<PlayerItemRecipe, object>.EndInvoke
	|-Func<ServerInfo, object>.EndInvoke
	|-Func<Achievement, object>.EndInvoke
	|-Func<InventoryDefId, object>.EndInvoke
	|-Func<ServerInfo, object>.EndInvoke
	|-Func<Friend, object>.EndInvoke
	|-Func<InventoryItem, object>.EndInvoke
	|-Func<InventoryRecipe, object>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, object>.EndInvoke
	|-Func<ArraySegment<byte>, object>.EndInvoke
	|-Func<DictionaryEntry, object>.EndInvoke
	|-Func<KeyValuePair<object, object>, object>.EndInvoke
	|-Func<KeyValuePair<uint, object>, object>.EndInvoke
	|-Func<Guid, object>.EndInvoke
	|-Func<int, object>.EndInvoke
	|-Func<Int32Enum, object>.EndInvoke
	|-Func<IntPtr, object>.EndInvoke
	|-Func<object, object>.EndInvoke
	|-Func<ValueTuple<Int32Enum, int>, object>.EndInvoke
	|
	|-RVA: 0x121B4C0 Offset: 0x121A8C0 VA: 0x18121B4C0
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>.EndInvoke
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.EndInvoke
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.EndInvoke
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>.EndInvoke
	|-Func<PlayerItemRecipe, PlayerItemRecipe>.EndInvoke
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>.EndInvoke
	|-Func<ServerInfo, Debugging.EntityInfo>.EndInvoke
	|-Func<ServerInfo, KeyValuePair<object, int>>.EndInvoke
	|-Func<Achievement, Debugging.EntityInfo>.EndInvoke
	|-Func<Achievement, KeyValuePair<object, int>>.EndInvoke
	|-Func<InventoryDefId, Debugging.EntityInfo>.EndInvoke
	|-Func<InventoryDefId, KeyValuePair<object, int>>.EndInvoke
	|-Func<Friend, Debugging.EntityInfo>.EndInvoke
	|-Func<Friend, KeyValuePair<object, int>>.EndInvoke
	|-Func<InventoryItem, Debugging.EntityInfo>.EndInvoke
	|-Func<InventoryItem, KeyValuePair<object, int>>.EndInvoke
	|-Func<InventoryRecipe, PlayerItemRecipe>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.EndInvoke
	|-Func<DictionaryEntry, KeyValuePair<object, object>>.EndInvoke
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>.EndInvoke
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>.EndInvoke
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>.EndInvoke
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>.EndInvoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.EndInvoke
	|-Func<Int32Enum, Debugging.EntityInfo>.EndInvoke
	|-Func<Int32Enum, KeyValuePair<object, int>>.EndInvoke
	|-Func<object, Debugging.EntityInfo>.EndInvoke
	|-Func<object, PlayerItemRecipe>.EndInvoke
	|-Func<object, KeyValuePair<object, int>>.EndInvoke
	|-Func<object, DateTimeOffset>.EndInvoke
	|-Func<object, Guid>.EndInvoke
	|-Func<object, UdpReceiveResult>.EndInvoke
	|
	|-RVA: 0xFF1100 Offset: 0xFF0500 VA: 0x180FF1100
	|-Func<Debugging.EntityInfo, bool>.EndInvoke
	|-Func<Entity.EntityInfo, bool>.EndInvoke
	|-Func<BurstCloth.Chain, FourBitNumber>.EndInvoke
	|-Func<BurstCloth.Chain, SevenBitNumber>.EndInvoke
	|-Func<BurstCloth.Chain, bool>.EndInvoke
	|-Func<RCon.BannedAddresses, bool>.EndInvoke
	|-Func<SkeletonDefinition.Bone, bool>.EndInvoke
	|-Func<WeightedStringList.Container, bool>.EndInvoke
	|-Func<GameStat.Stat, bool>.EndInvoke
	|-Func<ItemSkinDirectory.Skin, bool>.EndInvoke
	|-Func<FourBitNumber, FourBitNumber>.EndInvoke
	|-Func<FourBitNumber, bool>.EndInvoke
	|-Func<SevenBitNumber, SevenBitNumber>.EndInvoke
	|-Func<SevenBitNumber, bool>.EndInvoke
	|-Func<PathFinder.Point, bool>.EndInvoke
	|-Func<PetCommandList.PetCommandDesc, bool>.EndInvoke
	|-Func<PlayerItemRecipe, bool>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, bool>.EndInvoke
	|-Func<ProjectileWeaponMod.Modifier, bool>.EndInvoke
	|-Func<Option, bool>.EndInvoke
	|-Func<ServerInfo, FourBitNumber>.EndInvoke
	|-Func<ServerInfo, SevenBitNumber>.EndInvoke
	|-Func<ServerInfo, bool>.EndInvoke
	|-Func<SkinnedMultiMesh.Part, bool>.EndInvoke
	|-Func<Achievement, bool>.EndInvoke
	|-Func<InventoryDefId, bool>.EndInvoke
	|-Func<InventoryItemId, bool>.EndInvoke
	|-Func<ServerInfo, bool>.EndInvoke
	|-Func<Friend, bool>.EndInvoke
	|-Func<InventoryItem, FourBitNumber>.EndInvoke
	|-Func<InventoryItem, SevenBitNumber>.EndInvoke
	|-Func<InventoryItem, bool>.EndInvoke
	|-Func<InventoryItem.Amount, bool>.EndInvoke
	|-Func<InventoryRecipe, bool>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, bool>.EndInvoke
	|-Func<bool, bool>.EndInvoke
	|-Func<char, bool>.EndInvoke
	|-Func<DictionaryEntry, bool>.EndInvoke
	|-Func<KeyValuePair<object, int>, bool>.EndInvoke
	|-Func<KeyValuePair<object, object>, bool>.EndInvoke
	|-Func<KeyValuePair<uint, object>, bool>.EndInvoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.EndInvoke
	|-Func<int, FourBitNumber>.EndInvoke
	|-Func<int, SevenBitNumber>.EndInvoke
	|-Func<int, bool>.EndInvoke
	|-Func<Int32Enum, bool>.EndInvoke
	|-Func<long, bool>.EndInvoke
	|-Func<object, FourBitNumber>.EndInvoke
	|-Func<object, SevenBitNumber>.EndInvoke
	|-Func<object, bool>.EndInvoke
	|-Func<object, VoidTaskResult>.EndInvoke
	|-Func<float, bool>.EndInvoke
	|-Func<uint, bool>.EndInvoke
	|-Func<ulong, bool>.EndInvoke
	|-Func<Resolution, bool>.EndInvoke
	|
	|-RVA: 0x121BE10 Offset: 0x121B210 VA: 0x18121BE10
	|-Func<Demos.DemoInfo, DateTime>.EndInvoke
	|-Func<Demos.DemoInfo, TimeSpan>.EndInvoke
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.EndInvoke
	|-Func<SkeletonDefinition.Bone, long>.EndInvoke
	|-Func<PathFinder.Point, PathFinder.Point>.EndInvoke
	|-Func<PlayerItemRecipe, PathFinder.Point>.EndInvoke
	|-Func<PlayerItemRecipe, long>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.EndInvoke
	|-Func<ServerInfo, PathFinder.Point>.EndInvoke
	|-Func<ServerInfo, long>.EndInvoke
	|-Func<SkinnedMultiMesh.Part, long>.EndInvoke
	|-Func<Achievement, PathFinder.Point>.EndInvoke
	|-Func<Achievement, long>.EndInvoke
	|-Func<InventoryDefId, PathFinder.Point>.EndInvoke
	|-Func<InventoryDefId, long>.EndInvoke
	|-Func<InventoryItemId, InventoryItemId>.EndInvoke
	|-Func<Friend, PathFinder.Point>.EndInvoke
	|-Func<Friend, long>.EndInvoke
	|-Func<InventoryItem, PathFinder.Point>.EndInvoke
	|-Func<InventoryItem, InventoryItemId>.EndInvoke
	|-Func<InventoryItem, long>.EndInvoke
	|-Func<InventoryItem.Amount, InventoryItemId>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, long>.EndInvoke
	|-Func<Item, DateTime>.EndInvoke
	|-Func<KeyValuePair<object, long>, long>.EndInvoke
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.EndInvoke
	|-Func<KeyValuePair<object, object>, long>.EndInvoke
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.EndInvoke
	|-Func<KeyValuePair<uint, object>, long>.EndInvoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.EndInvoke
	|-Func<Int32Enum, PathFinder.Point>.EndInvoke
	|-Func<Int32Enum, long>.EndInvoke
	|-Func<long, long>.EndInvoke
	|-Func<object, PathFinder.Point>.EndInvoke
	|-Func<object, PlayerItemRecipe.Ingredient>.EndInvoke
	|-Func<object, InventoryItemId>.EndInvoke
	|-Func<object, DateTime>.EndInvoke
	|-Func<object, long>.EndInvoke
	|-Func<object, Nullable<int>>.EndInvoke
	|-Func<object, Nullable<Int32Enum>>.EndInvoke
	|-Func<object, ulong>.EndInvoke
	|-Func<ulong, ulong>.EndInvoke
	|-Func<Resolution, Vector2Int>.EndInvoke
	|
	|-RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0
	|-Func<BurstCloth.Chain, int>.EndInvoke
	|-Func<SkeletonDefinition.Bone, int>.EndInvoke
	|-Func<SkeletonDefinition.Bone, Int32Enum>.EndInvoke
	|-Func<PlayerItemRecipe, int>.EndInvoke
	|-Func<PlayerItemRecipe, Int32Enum>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, int>.EndInvoke
	|-Func<ServerInfo, int>.EndInvoke
	|-Func<ServerInfo, Int32Enum>.EndInvoke
	|-Func<ServerInfo, uint>.EndInvoke
	|-Func<Achievement, int>.EndInvoke
	|-Func<Achievement, Int32Enum>.EndInvoke
	|-Func<InventoryDefId, int>.EndInvoke
	|-Func<InventoryDefId, Int32Enum>.EndInvoke
	|-Func<ServerInfo, int>.EndInvoke
	|-Func<Friend, int>.EndInvoke
	|-Func<Friend, Int32Enum>.EndInvoke
	|-Func<InventoryItem, InventoryDefId>.EndInvoke
	|-Func<InventoryItem, int>.EndInvoke
	|-Func<InventoryItem, Int32Enum>.EndInvoke
	|-Func<InventoryItem, uint>.EndInvoke
	|-Func<InventoryItem.Amount, uint>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, int>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.EndInvoke
	|-Func<KeyValuePair<object, int>, int>.EndInvoke
	|-Func<KeyValuePair<object, object>, int>.EndInvoke
	|-Func<KeyValuePair<object, object>, Int32Enum>.EndInvoke
	|-Func<KeyValuePair<uint, object>, int>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Int32Enum>.EndInvoke
	|-Func<KeyValuePair<uint, object>, uint>.EndInvoke
	|-Func<Guid, int>.EndInvoke
	|-Func<int, int>.EndInvoke
	|-Func<Int32Enum, int>.EndInvoke
	|-Func<Int32Enum, Int32Enum>.EndInvoke
	|-Func<object, InventoryDefId>.EndInvoke
	|-Func<object, int>.EndInvoke
	|-Func<object, Int32Enum>.EndInvoke
	|-Func<object, uint>.EndInvoke
	|-Func<uint, uint>.EndInvoke
	|-Func<Resolution, int>.EndInvoke
	|
	|-RVA: 0x19855A0 Offset: 0x19849A0 VA: 0x1819855A0
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<SkeletonDefinition.Bone, Resolution>.EndInvoke
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<PlayerItemRecipe, Resolution>.EndInvoke
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<ServerInfo, Resolution>.EndInvoke
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<Achievement, Resolution>.EndInvoke
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<InventoryDefId, Resolution>.EndInvoke
	|-Func<Friend, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<Friend, Resolution>.EndInvoke
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<InventoryItem, Resolution>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Resolution>.EndInvoke
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<KeyValuePair<object, object>, Resolution>.EndInvoke
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Resolution>.EndInvoke
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<Int32Enum, Resolution>.EndInvoke
	|-Func<object, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<object, Nullable<InventoryResult>>.EndInvoke
	|-Func<object, Resolution>.EndInvoke
	|-Func<Resolution, Resolution>.EndInvoke
	|
	|-RVA: 0x19F3ED0 Offset: 0x19F32D0 VA: 0x1819F3ED0
	|-Func<SkeletonDefinition.Bone, Option>.EndInvoke
	|-Func<SkeletonDefinition.Bone, InventoryItem>.EndInvoke
	|-Func<PlayerItemRecipe, Option>.EndInvoke
	|-Func<PlayerItemRecipe, InventoryItem>.EndInvoke
	|-Func<Option, Option>.EndInvoke
	|-Func<ServerInfo, Option>.EndInvoke
	|-Func<ServerInfo, InventoryItem>.EndInvoke
	|-Func<Achievement, Option>.EndInvoke
	|-Func<Achievement, InventoryItem>.EndInvoke
	|-Func<InventoryDefId, Option>.EndInvoke
	|-Func<InventoryDefId, InventoryItem>.EndInvoke
	|-Func<Friend, Option>.EndInvoke
	|-Func<Friend, InventoryItem>.EndInvoke
	|-Func<InventoryItem, Option>.EndInvoke
	|-Func<InventoryItem, InventoryItem>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Option>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.EndInvoke
	|-Func<KeyValuePair<object, object>, Option>.EndInvoke
	|-Func<KeyValuePair<object, object>, InventoryItem>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Option>.EndInvoke
	|-Func<KeyValuePair<uint, object>, InventoryItem>.EndInvoke
	|-Func<Int32Enum, Option>.EndInvoke
	|-Func<Int32Enum, InventoryItem>.EndInvoke
	|-Func<object, Option>.EndInvoke
	|-Func<object, InventoryItem>.EndInvoke
	|-Func<object, Nullable<InventoryPurchaseResult>>.EndInvoke
	|-Func<object, Nullable<ResultPage>>.EndInvoke
	|
	|-RVA: 0x19F3FF0 Offset: 0x19F33F0 VA: 0x1819F3FF0
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.EndInvoke
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<PlayerItemRecipe, InventoryRecipe>.EndInvoke
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<ServerInfo, InventoryRecipe>.EndInvoke
	|-Func<Achievement, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<Achievement, InventoryRecipe>.EndInvoke
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<InventoryDefId, InventoryRecipe>.EndInvoke
	|-Func<Friend, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<Friend, InventoryRecipe>.EndInvoke
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<InventoryItem, InventoryRecipe>.EndInvoke
	|-Func<InventoryRecipe, InventoryRecipe>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.EndInvoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.EndInvoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.EndInvoke
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<Int32Enum, InventoryRecipe>.EndInvoke
	|-Func<object, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<object, InventoryRecipe>.EndInvoke
	|-Func<object, PublishResult>.EndInvoke
	|-Func<object, Nullable<Image>>.EndInvoke
	|
	|-RVA: 0x19F3F10 Offset: 0x19F3310 VA: 0x1819F3F10
	|-Func<SkeletonDefinition.Bone, float>.EndInvoke
	|-Func<WeightedStringList.Container, float>.EndInvoke
	|-Func<PlayerItemRecipe, float>.EndInvoke
	|-Func<ProjectileWeaponMod.Modifier, float>.EndInvoke
	|-Func<ServerInfo, float>.EndInvoke
	|-Func<Achievement, float>.EndInvoke
	|-Func<InventoryDefId, float>.EndInvoke
	|-Func<Friend, float>.EndInvoke
	|-Func<InventoryItem, float>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, float>.EndInvoke
	|-Func<KeyValuePair<object, object>, float>.EndInvoke
	|-Func<KeyValuePair<uint, object>, float>.EndInvoke
	|-Func<int, float>.EndInvoke
	|-Func<Int32Enum, float>.EndInvoke
	|-Func<object, float>.EndInvoke
	|-Func<float, float>.EndInvoke
	|
	|-RVA: 0x21260E0 Offset: 0x21254E0 VA: 0x1821260E0
	|-Func<ServerInfo, ServerInfo>.EndInvoke
	|
	|-RVA: 0x2126150 Offset: 0x2125550 VA: 0x182126150
	|-Func<double, double>.EndInvoke
	|
	|-RVA: 0x19F3E60 Offset: 0x19F3260 VA: 0x1819F3E60
	|-Func<object, Nullable<ServerInfo>>.EndInvoke
	|
	|-RVA: 0x19F3F40 Offset: 0x19F3340 VA: 0x1819F3F40
	|-Func<object, Nullable<Item>>.EndInvoke
	*/

}

public sealed class Converter<TInput, TOutput> : MulticastDelegate // TypeDefIndex: 161
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-Converter<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TOutput Invoke(TInput input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD547F0 Offset: 0xD53BF0 VA: 0x180D547F0
	|-Converter<Type, string>.Invoke
	|-Converter<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(TInput input, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497210 Offset: 0x496610 VA: 0x180497210
	|-Converter<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual TOutput EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-Converter<object, object>.EndInvoke
	*/

}

internal struct __DTString // TypeDefIndex: 231
{	// Fields
	internal string Value; // 0x0
	internal int Index; // 0x8
	internal int len; // 0xC
	internal char m_current; // 0x10
	private CompareInfo m_info; // 0x18
	private bool m_checkDigitToken; // 0x20
	private static char[] WhiteSpaceChecks; // 0x0

	// Properties
	internal CompareInfo CompareInfo { get; }

	// Methods

	// RVA: 0x235240 Offset: 0x234640 VA: 0x180235240
	internal void .ctor(string str, DateTimeFormatInfo dtfi, bool checkDigitToken) { }

	// RVA: 0x235320 Offset: 0x234720 VA: 0x180235320
	internal void .ctor(string str, DateTimeFormatInfo dtfi) { }

	// RVA: 0xF3DE0 Offset: 0xF31E0 VA: 0x1800F3DE0
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x2347F0 Offset: 0x233BF0 VA: 0x1802347F0
	internal bool GetNext() { }

	// RVA: 0x2346A0 Offset: 0x233AA0 VA: 0x1802346A0
	internal bool AtEnd() { }

	// RVA: 0x234660 Offset: 0x233A60 VA: 0x180234660
	internal bool Advance(int count) { }

	// RVA: 0x234830 Offset: 0x233C30 VA: 0x180234830
	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2348C0 Offset: 0x233CC0 VA: 0x1802348C0
	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) { }

	// RVA: 0x234C80 Offset: 0x234080 VA: 0x180234C80
	internal bool MatchSpecifiedWord(string target) { }

	// RVA: 0x234C00 Offset: 0x234000 VA: 0x180234C00
	internal bool MatchSpecifiedWord(string target, int endIndex) { }

	// RVA: 0x234D00 Offset: 0x234100 VA: 0x180234D00
	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) { }

	// RVA: 0x234D10 Offset: 0x234110 VA: 0x180234D10
	internal bool Match(string str) { }

	// RVA: 0x234DC0 Offset: 0x2341C0 VA: 0x180234DC0
	internal bool Match(char ch) { }

	// RVA: 0x234B50 Offset: 0x233F50 VA: 0x180234B50
	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) { }

	// RVA: 0x234840 Offset: 0x233C40 VA: 0x180234840
	internal int GetRepeatCount() { }

	// RVA: 0x234770 Offset: 0x233B70 VA: 0x180234770
	internal bool GetNextDigit() { }

	// RVA: 0x234710 Offset: 0x233B10 VA: 0x180234710
	internal char GetChar() { }

	// RVA: 0x234740 Offset: 0x233B40 VA: 0x180234740
	internal int GetDigit() { }

	// RVA: 0x2350C0 Offset: 0x2344C0 VA: 0x1802350C0
	internal void SkipWhiteSpaces() { }

	// RVA: 0x2350B0 Offset: 0x2344B0 VA: 0x1802350B0
	internal bool SkipWhiteSpaceCurrent() { }

	// RVA: 0x235160 Offset: 0x234560 VA: 0x180235160
	internal void TrimTail() { }

	// RVA: 0x234F40 Offset: 0x234340 VA: 0x180234F40
	internal void RemoveTrailingInQuoteSpaces() { }

	// RVA: 0x234E20 Offset: 0x234220 VA: 0x180234E20
	internal void RemoveLeadingInQuoteSpaces() { }

	// RVA: 0x2349D0 Offset: 0x233DD0 VA: 0x1802349D0
	internal DTSubString GetSubString() { }

	// RVA: 0x2346B0 Offset: 0x233AB0 VA: 0x1802346B0
	internal void ConsumeSubString(DTSubString sub) { }

	// RVA: 0x2146D70 Offset: 0x2146170 VA: 0x182146D70
	private static void .cctor() { }

}

internal class __ComObject // TypeDefIndex: 429
{	// Methods

	// RVA: 0x2145B10 Offset: 0x2144F10 VA: 0x182145B10
	private void .ctor() { }

}

internal static class __Error // TypeDefIndex: 615
{	// Methods

	// RVA: 0x1681EC0 Offset: 0x16812C0 VA: 0x181681EC0
	internal static void EndOfFile() { }

	// RVA: 0x1682010 Offset: 0x1681410 VA: 0x181682010
	internal static void FileNotOpen() { }

	// RVA: 0x1682330 Offset: 0x1681730 VA: 0x181682330
	internal static void StreamIsClosed() { }

	// RVA: 0x16821E0 Offset: 0x16815E0 VA: 0x1816821E0
	internal static void MemoryStreamNotExpandable() { }

	// RVA: 0x16822C0 Offset: 0x16816C0 VA: 0x1816822C0
	internal static void ReaderClosed() { }

	// RVA: 0x1682250 Offset: 0x1681650 VA: 0x181682250
	internal static void ReadNotSupported() { }

	// RVA: 0x1682B50 Offset: 0x1681F50 VA: 0x181682B50
	internal static void WrongAsyncResult() { }

	// RVA: 0x1681F30 Offset: 0x1681330 VA: 0x181681F30
	internal static void EndReadCalledTwice() { }

	// RVA: 0x1681FA0 Offset: 0x16813A0 VA: 0x181681FA0
	internal static void EndWriteCalledTwice() { }

	// RVA: 0x1682080 Offset: 0x1681480 VA: 0x181682080
	internal static string GetDisplayablePath(string path, bool isInvalidPath) { }

	// RVA: 0x16823A0 Offset: 0x16817A0 VA: 0x1816823A0
	internal static void WinIOError(int errorCode, string maybeFullPath) { }

	// RVA: 0x1682A70 Offset: 0x1681E70 VA: 0x181682A70
	internal static void WriteNotSupported() { }

	// RVA: 0x1682AE0 Offset: 0x1681EE0 VA: 0x181682AE0
	internal static void WriterClosed() { }

}

internal abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 627
{	// Fields
	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	// Properties
	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DE2C0 Offset: 0x19DD6C0 VA: 0x1819DE2C0
	|-Iterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Iterator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract Iterator<TSource> Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Iterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19FD470 Offset: 0x19FC870 VA: 0x1819FD470
	|-Iterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DD080 Offset: 0x19DC480 VA: 0x1819DD080
	|-Iterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DD140 Offset: 0x19DC540 VA: 0x1819DD140
	|-Iterator<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Iterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13508E0 Offset: 0x134FCE0 VA: 0x1813508E0
	|-Iterator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ECE60 Offset: 0x17EC260 VA: 0x1817ECE60
	|-Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19FD4F0 Offset: 0x19FC8F0 VA: 0x1819FD4F0
	|-Iterator<object>.System.Collections.IEnumerator.Reset
	*/

}

internal abstract class SearchResultHandler<TSource> // TypeDefIndex: 629
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool IsResultIncluded(SearchResult result);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SearchResultHandler<object>.IsResultIncluded
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract TSource CreateObject(SearchResult result);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SearchResultHandler<object>.CreateObject
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-SearchResultHandler<object>..ctor
	|-SearchResultHandler<string>..ctor
	*/

}

internal static class _ThreadPoolWaitCallback // TypeDefIndex: 814
{	// Methods

	// RVA: 0x16195A0 Offset: 0x16189A0 VA: 0x1816195A0
	internal static bool PerformWaitCallback() { }

}

public class Task<TResult> : Task // TypeDefIndex: 842
{	// Fields
	internal TResult m_result; // 0x0
	private static readonly TaskFactory<TResult> s_Factory; // 0x0
	internal static readonly Func<Task<Task>, Task<TResult>> TaskWhenAnyCast; // 0x0

	// Properties
	[DebuggerBrowsableAttribute] // RVA: 0x9E7F0 Offset: 0x9DBF0 VA: 0x18009E7F0
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }
	public static TaskFactory<TResult> Factory { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8E190 Offset: 0x1A8D590 VA: 0x181A8E190
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A8C3B0 Offset: 0x1A8B7B0 VA: 0x181A8C3B0
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A8CB10 Offset: 0x1A8BF10 VA: 0x181A8CB10
	|-Task<int>..ctor
	|
	|-RVA: 0x1A8C6B0 Offset: 0x1A8BAB0 VA: 0x181A8C6B0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A8CE90 Offset: 0x1A8C290 VA: 0x181A8CE90
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A8C040 Offset: 0x1A8B440 VA: 0x181A8C040
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A8D520 Offset: 0x1A8C920 VA: 0x181A8D520
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A8DE60 Offset: 0x1A8D260 VA: 0x181A8DE60
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A8C410 Offset: 0x1A8B810 VA: 0x181A8C410
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A8C350 Offset: 0x1A8B750 VA: 0x181A8C350
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A48730 Offset: 0x1A47B30 VA: 0x181A48730
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A47F10 Offset: 0x1A47310 VA: 0x181A47F10
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A47A70 Offset: 0x1A46E70 VA: 0x181A47A70
	|-Task<object>..ctor
	|-Task<Task>..ctor
	|
	|-RVA: 0x1A47F70 Offset: 0x1A47370 VA: 0x181A47F70
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object state, TaskCreationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8CEF0 Offset: 0x1A8C2F0 VA: 0x181A8CEF0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A8D060 Offset: 0x1A8C460 VA: 0x181A8D060
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A8DF50 Offset: 0x1A8D350 VA: 0x181A8DF50
	|-Task<int>..ctor
	|
	|-RVA: 0x1A8E100 Offset: 0x1A8D500 VA: 0x181A8E100
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A8BD60 Offset: 0x1A8B160 VA: 0x181A8BD60
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A8C620 Offset: 0x1A8BA20 VA: 0x181A8C620
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A8C230 Offset: 0x1A8B630 VA: 0x181A8C230
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A8C2C0 Offset: 0x1A8B6C0 VA: 0x181A8C2C0
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A8ACA0 Offset: 0x1A8A0A0 VA: 0x181A8ACA0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A8B170 Offset: 0x1A8A570 VA: 0x181A8B170
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A47E80 Offset: 0x1A47280 VA: 0x181A47E80
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A480F0 Offset: 0x1A474F0 VA: 0x181A480F0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A48580 Offset: 0x1A47980 VA: 0x181A48580
	|-Task<object>..ctor
	|
	|-RVA: 0x1A48830 Offset: 0x1A47C30 VA: 0x181A48830
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8BB00 Offset: 0x1A8AF00 VA: 0x181A8BB00
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A8A580 Offset: 0x1A89980 VA: 0x181A8A580
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A8AD30 Offset: 0x1A8A130 VA: 0x181A8AD30
	|-Task<int>..ctor
	|
	|-RVA: 0x1A8DEC0 Offset: 0x1A8D2C0 VA: 0x181A8DEC0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A8D580 Offset: 0x1A8C980 VA: 0x181A8D580
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A8D480 Offset: 0x1A8C880 VA: 0x181A8D480
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A8C470 Offset: 0x1A8B870 VA: 0x181A8C470
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A8BFB0 Offset: 0x1A8B3B0 VA: 0x181A8BFB0
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A8D660 Offset: 0x1A8CA60 VA: 0x181A8D660
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A8B0E0 Offset: 0x1A8A4E0 VA: 0x181A8B0E0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A482A0 Offset: 0x1A476A0 VA: 0x181A482A0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A47180 Offset: 0x1A46580 VA: 0x181A47180
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A47BF0 Offset: 0x1A46FF0 VA: 0x181A47BF0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A479F0 Offset: 0x1A46DF0 VA: 0x181A479F0
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8E1F0 Offset: 0x1A8D5F0 VA: 0x181A8E1F0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A8B200 Offset: 0x1A8A600 VA: 0x181A8B200
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A8A600 Offset: 0x1A89A00 VA: 0x181A8A600
	|-Task<int>..ctor
	|
	|-RVA: 0x1A8D3D0 Offset: 0x1A8C7D0 VA: 0x181A8D3D0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A8B4A0 Offset: 0x1A8A8A0 VA: 0x181A8B4A0
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A8B920 Offset: 0x1A8AD20 VA: 0x181A8B920
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A8C180 Offset: 0x1A8B580 VA: 0x181A8C180
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A8DDB0 Offset: 0x1A8D1B0 VA: 0x181A8DDB0
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A8ADB0 Offset: 0x1A8A1B0 VA: 0x181A8ADB0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A8BCB0 Offset: 0x1A8B0B0 VA: 0x181A8BCB0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A48320 Offset: 0x1A47720 VA: 0x181A48320
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A47200 Offset: 0x1A46600 VA: 0x181A47200
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A476A0 Offset: 0x1A46AA0 VA: 0x181A476A0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A48790 Offset: 0x1A47B90 VA: 0x181A48790
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8D210 Offset: 0x1A8C610 VA: 0x181A8D210
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A8D2F0 Offset: 0x1A8C6F0 VA: 0x181A8D2F0
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A8AA00 Offset: 0x1A89E00 VA: 0x181A8AA00
	|-Task<int>..ctor
	|
	|-RVA: 0x1A8AAE0 Offset: 0x1A89EE0 VA: 0x181A8AAE0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A8ABC0 Offset: 0x1A89FC0 VA: 0x181A8ABC0
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A8B680 Offset: 0x1A8AA80 VA: 0x181A8B680
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A8CA30 Offset: 0x1A8BE30 VA: 0x181A8CA30
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A8B2A0 Offset: 0x1A8A6A0 VA: 0x181A8B2A0
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A8AEE0 Offset: 0x1A8A2E0 VA: 0x181A8AEE0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A8CF80 Offset: 0x1A8C380 VA: 0x181A8CF80
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A47DA0 Offset: 0x1A471A0 VA: 0x181A47DA0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A473C0 Offset: 0x1A467C0 VA: 0x181A473C0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A47750 Offset: 0x1A46B50 VA: 0x181A47750
	|-Task<object>..ctor
	|
	|-RVA: 0x1A474A0 Offset: 0x1A468A0 VA: 0x181A474A0
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8BED0 Offset: 0x1A8B2D0 VA: 0x181A8BED0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A8DCD0 Offset: 0x1A8D0D0 VA: 0x181A8DCD0
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A8CC90 Offset: 0x1A8C090 VA: 0x181A8CC90
	|-Task<int>..ctor
	|
	|-RVA: 0x1A8C830 Offset: 0x1A8BC30 VA: 0x181A8C830
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A8BDF0 Offset: 0x1A8B1F0 VA: 0x181A8BDF0
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A8C0A0 Offset: 0x1A8B4A0 VA: 0x181A8C0A0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A8B5A0 Offset: 0x1A8A9A0 VA: 0x181A8B5A0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A8B760 Offset: 0x1A8AB60 VA: 0x181A8B760
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A8DBF0 Offset: 0x1A8CFF0 VA: 0x181A8DBF0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A8B840 Offset: 0x1A8AC40 VA: 0x181A8B840
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A47910 Offset: 0x1A46D10 VA: 0x181A47910
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A483C0 Offset: 0x1A477C0 VA: 0x181A483C0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A484A0 Offset: 0x1A478A0 VA: 0x181A484A0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A47830 Offset: 0x1A46C30 VA: 0x181A47830
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8DFE0 Offset: 0x1A8D3E0 VA: 0x181A8DFE0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A8D770 Offset: 0x1A8CB70 VA: 0x181A8D770
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A8A6A0 Offset: 0x1A89AA0 VA: 0x181A8A6A0
	|-Task<int>..ctor
	|
	|-RVA: 0x1A8DAD0 Offset: 0x1A8CED0 VA: 0x181A8DAD0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A8B380 Offset: 0x1A8A780 VA: 0x181A8B380
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A8A7C0 Offset: 0x1A89BC0 VA: 0x181A8A7C0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A8C910 Offset: 0x1A8BD10 VA: 0x181A8C910
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A8A460 Offset: 0x1A89860 VA: 0x181A8A460
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A8A8E0 Offset: 0x1A89CE0 VA: 0x181A8A8E0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A8E2A0 Offset: 0x1A8D6A0 VA: 0x181A8E2A0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A47C80 Offset: 0x1A47080 VA: 0x181A47C80
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A488C0 Offset: 0x1A47CC0 VA: 0x181A488C0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A48610 Offset: 0x1A47A10 VA: 0x181A48610
	|-Task<object>..ctor
	|
	|-RVA: 0x1A48180 Offset: 0x1A47580 VA: 0x181A48180
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8B9E0 Offset: 0x1A8ADE0 VA: 0x181A8B9E0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A8C500 Offset: 0x1A8B900 VA: 0x181A8C500
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A8BB90 Offset: 0x1A8AF90 VA: 0x181A8BB90
	|-Task<int>..ctor
	|
	|-RVA: 0x1A8D890 Offset: 0x1A8CC90 VA: 0x181A8D890
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A8AFC0 Offset: 0x1A8A3C0 VA: 0x181A8AFC0
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A8D9B0 Offset: 0x1A8CDB0 VA: 0x181A8D9B0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A8CB70 Offset: 0x1A8BF70 VA: 0x181A8CB70
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A8CD70 Offset: 0x1A8C170 VA: 0x181A8CD70
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A8D0F0 Offset: 0x1A8C4F0 VA: 0x181A8D0F0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A8C710 Offset: 0x1A8BB10 VA: 0x181A8C710
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A472A0 Offset: 0x1A466A0 VA: 0x181A472A0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A47AD0 Offset: 0x1A46ED0 VA: 0x181A47AD0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A47580 Offset: 0x1A46980 VA: 0x181A47580
	|-Task<object>..ctor
	|
	|-RVA: 0x1A47FD0 Offset: 0x1A473D0 VA: 0x181A47FD0
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A89B40 Offset: 0x1A88F40 VA: 0x181A89B40
	|-Task<PublishResult>.StartNew
	|
	|-RVA: 0x1A88DC0 Offset: 0x1A881C0 VA: 0x181A88DC0
	|-Task<bool>.StartNew
	|
	|-RVA: 0x1A88B80 Offset: 0x1A87F80 VA: 0x181A88B80
	|-Task<int>.StartNew
	|
	|-RVA: 0x1A89240 Offset: 0x1A88640 VA: 0x181A89240
	|-Task<UdpReceiveResult>.StartNew
	|
	|-RVA: 0x1A89000 Offset: 0x1A88400 VA: 0x181A89000
	|-Task<Nullable<ServerInfo>>.StartNew
	|
	|-RVA: 0x1A89900 Offset: 0x1A88D00 VA: 0x181A89900
	|-Task<Nullable<Image>>.StartNew
	|
	|-RVA: 0x1A88940 Offset: 0x1A87D40 VA: 0x181A88940
	|-Task<Nullable<InventoryPurchaseResult>>.StartNew
	|
	|-RVA: 0x1A88700 Offset: 0x1A87B00 VA: 0x181A88700
	|-Task<Nullable<InventoryResult>>.StartNew
	|
	|-RVA: 0x1A896C0 Offset: 0x1A88AC0 VA: 0x181A896C0
	|-Task<Nullable<Item>>.StartNew
	|
	|-RVA: 0x1A89480 Offset: 0x1A88880 VA: 0x181A89480
	|-Task<Nullable<ResultPage>>.StartNew
	|
	|-RVA: 0x1A468F0 Offset: 0x1A45CF0 VA: 0x181A468F0
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x1A46230 Offset: 0x1A45630 VA: 0x181A46230
	|-Task<Nullable<Int32Enum>>.StartNew
	|
	|-RVA: 0x1A46470 Offset: 0x1A45870 VA: 0x181A46470
	|-Task<object>.StartNew
	|
	|-RVA: 0x1A466B0 Offset: 0x1A45AB0 VA: 0x181A466B0
	|-Task<VoidTaskResult>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8A3A0 Offset: 0x1A897A0 VA: 0x181A8A3A0
	|-Task<PublishResult>.TrySetResult
	|
	|-RVA: 0x1A46DD0 Offset: 0x1A461D0 VA: 0x181A46DD0
	|-Task<bool>.TrySetResult
	|-Task<VoidTaskResult>.TrySetResult
	|
	|-RVA: 0x1A89D80 Offset: 0x1A89180 VA: 0x181A89D80
	|-Task<int>.TrySetResult
	|
	|-RVA: 0x1A89EF0 Offset: 0x1A892F0 VA: 0x181A89EF0
	|-Task<UdpReceiveResult>.TrySetResult
	|
	|-RVA: 0x1A8A100 Offset: 0x1A89500 VA: 0x181A8A100
	|-Task<Nullable<ServerInfo>>.TrySetResult
	|
	|-RVA: 0x1A8A210 Offset: 0x1A89610 VA: 0x181A8A210
	|-Task<Nullable<Image>>.TrySetResult
	|
	|-RVA: 0x1A89E30 Offset: 0x1A89230 VA: 0x181A89E30
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetResult
	|-Task<Nullable<ResultPage>>.TrySetResult
	|
	|-RVA: 0x1A8A2E0 Offset: 0x1A896E0 VA: 0x181A8A2E0
	|-Task<Nullable<InventoryResult>>.TrySetResult
	|
	|-RVA: 0x1A89FB0 Offset: 0x1A893B0 VA: 0x181A89FB0
	|-Task<Nullable<Item>>.TrySetResult
	|
	|-RVA: 0x1A46C60 Offset: 0x1A46060 VA: 0x181A46C60
	|-Task<Nullable<int>>.TrySetResult
	|-Task<Nullable<Int32Enum>>.TrySetResult
	|
	|-RVA: 0x1A46D10 Offset: 0x1A46110 VA: 0x181A46D10
	|-Task<object>.TrySetResult
	|-Task<Task>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A878C0 Offset: 0x1A86CC0 VA: 0x181A878C0
	|-Task<PublishResult>.DangerousSetResult
	|
	|-RVA: 0x1A45D60 Offset: 0x1A45160 VA: 0x181A45D60
	|-Task<bool>.DangerousSetResult
	|-Task<VoidTaskResult>.DangerousSetResult
	|
	|-RVA: 0x1A87670 Offset: 0x1A86A70 VA: 0x181A87670
	|-Task<int>.DangerousSetResult
	|
	|-RVA: 0x1A876D0 Offset: 0x1A86AD0 VA: 0x181A876D0
	|-Task<UdpReceiveResult>.DangerousSetResult
	|
	|-RVA: 0x1A877B0 Offset: 0x1A86BB0 VA: 0x181A877B0
	|-Task<Nullable<ServerInfo>>.DangerousSetResult
	|
	|-RVA: 0x1A87940 Offset: 0x1A86D40 VA: 0x181A87940
	|-Task<Nullable<Image>>.DangerousSetResult
	|
	|-RVA: 0x1A87740 Offset: 0x1A86B40 VA: 0x181A87740
	|-Task<Nullable<InventoryPurchaseResult>>.DangerousSetResult
	|-Task<Nullable<ResultPage>>.DangerousSetResult
	|
	|-RVA: 0x1A87600 Offset: 0x1A86A00 VA: 0x181A87600
	|-Task<Nullable<InventoryResult>>.DangerousSetResult
	|
	|-RVA: 0x1A87480 Offset: 0x1A86880 VA: 0x181A87480
	|-Task<Nullable<Item>>.DangerousSetResult
	|
	|-RVA: 0x1A45DC0 Offset: 0x1A451C0 VA: 0x181A45DC0
	|-Task<Nullable<int>>.DangerousSetResult
	|-Task<Nullable<Int32Enum>>.DangerousSetResult
	|
	|-RVA: 0x1A45E20 Offset: 0x1A45220 VA: 0x181A45E20
	|-Task<object>.DangerousSetResult
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A489E0 Offset: 0x1A47DE0 VA: 0x181A489E0
	|-Task<ISocket>.get_Result
	|-Task<SteamInventoryCrafting.MarketPrice>.get_Result
	|-Task<Nullable<int>>.get_Result
	|-Task<Nullable<Int32Enum>>.get_Result
	|-Task<object>.get_Result
	|-Task<Task>.get_Result
	|
	|-RVA: 0x1A8E8C0 Offset: 0x1A8DCC0 VA: 0x181A8E8C0
	|-Task<PublishResult>.get_Result
	|-Task<Nullable<Image>>.get_Result
	|
	|-RVA: 0x1A48A50 Offset: 0x1A47E50 VA: 0x181A48A50
	|-Task<bool>.get_Result
	|-Task<VoidTaskResult>.get_Result
	|
	|-RVA: 0x1A8E850 Offset: 0x1A8DC50 VA: 0x181A8E850
	|-Task<int>.get_Result
	|
	|-RVA: 0x1A8E730 Offset: 0x1A8DB30 VA: 0x181A8E730
	|-Task<UdpReceiveResult>.get_Result
	|
	|-RVA: 0x1A8E960 Offset: 0x1A8DD60 VA: 0x181A8E960
	|-Task<Nullable<ServerInfo>>.get_Result
	|
	|-RVA: 0x1A8E7C0 Offset: 0x1A8DBC0 VA: 0x181A8E7C0
	|-Task<Nullable<InventoryPurchaseResult>>.get_Result
	|-Task<Nullable<ResultPage>>.get_Result
	|
	|-RVA: 0x1A8E520 Offset: 0x1A8D920 VA: 0x181A8E520
	|-Task<Nullable<InventoryResult>>.get_Result
	|
	|-RVA: 0x1A8E5C0 Offset: 0x1A8D9C0 VA: 0x181A8E5C0
	|-Task<Nullable<Item>>.get_Result
	*/

	// RVA: -1 Offset: -1
	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8E3E0 Offset: 0x1A8D7E0 VA: 0x181A8E3E0
	|-Task<PublishResult>.get_ResultOnSuccess
	|-Task<Nullable<Image>>.get_ResultOnSuccess
	|
	|-RVA: 0x778E40 Offset: 0x778240 VA: 0x180778E40
	|-Task<bool>.get_ResultOnSuccess
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	|
	|-RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	|-Task<int>.get_ResultOnSuccess
	|
	|-RVA: 0x1058C50 Offset: 0x1058050 VA: 0x181058C50
	|-Task<UdpReceiveResult>.get_ResultOnSuccess
	|
	|-RVA: 0x1A8E4C0 Offset: 0x1A8D8C0 VA: 0x181A8E4C0
	|-Task<Nullable<ServerInfo>>.get_ResultOnSuccess
	|
	|-RVA: 0x1A8E4A0 Offset: 0x1A8D8A0 VA: 0x181A8E4A0
	|-Task<Nullable<InventoryPurchaseResult>>.get_ResultOnSuccess
	|-Task<Nullable<ResultPage>>.get_ResultOnSuccess
	|
	|-RVA: 0x1A8E3C0 Offset: 0x1A8D7C0 VA: 0x181A8E3C0
	|-Task<Nullable<InventoryResult>>.get_ResultOnSuccess
	|
	|-RVA: 0x1A8E400 Offset: 0x1A8D800 VA: 0x181A8E400
	|-Task<Nullable<Item>>.get_ResultOnSuccess
	|
	|-RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	|-Task<Nullable<int>>.get_ResultOnSuccess
	|-Task<Nullable<Int32Enum>>.get_ResultOnSuccess
	|-Task<object>.get_ResultOnSuccess
	*/

	// RVA: -1 Offset: -1
	internal TResult GetResultCore(bool waitCompletionNotification) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A879C0 Offset: 0x1A86DC0 VA: 0x181A879C0
	|-Task<PublishResult>.GetResultCore
	|-Task<Nullable<Image>>.GetResultCore
	|
	|-RVA: 0x1A45EB0 Offset: 0x1A452B0 VA: 0x181A45EB0
	|-Task<bool>.GetResultCore
	|-Task<VoidTaskResult>.GetResultCore
	|
	|-RVA: 0x1A87CF0 Offset: 0x1A870F0 VA: 0x181A87CF0
	|-Task<int>.GetResultCore
	|
	|-RVA: 0x1A87C60 Offset: 0x1A87060 VA: 0x181A87C60
	|-Task<UdpReceiveResult>.GetResultCore
	|
	|-RVA: 0x1A87B80 Offset: 0x1A86F80 VA: 0x181A87B80
	|-Task<Nullable<ServerInfo>>.GetResultCore
	|
	|-RVA: 0x1A87A60 Offset: 0x1A86E60 VA: 0x181A87A60
	|-Task<Nullable<InventoryPurchaseResult>>.GetResultCore
	|-Task<Nullable<ResultPage>>.GetResultCore
	|
	|-RVA: 0x1A87AF0 Offset: 0x1A86EF0 VA: 0x181A87AF0
	|-Task<Nullable<InventoryResult>>.GetResultCore
	|
	|-RVA: 0x1A87D60 Offset: 0x1A87160 VA: 0x181A87D60
	|-Task<Nullable<Item>>.GetResultCore
	|
	|-RVA: 0x1A45F30 Offset: 0x1A45330 VA: 0x181A45F30
	|-Task<Nullable<int>>.GetResultCore
	|-Task<Nullable<Int32Enum>>.GetResultCore
	|-Task<object>.GetResultCore
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetException(object exceptionObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A46BE0 Offset: 0x1A45FE0 VA: 0x181A46BE0
	|-Task<PublishResult>.TrySetException
	|-Task<bool>.TrySetException
	|-Task<int>.TrySetException
	|-Task<UdpReceiveResult>.TrySetException
	|-Task<Nullable<ServerInfo>>.TrySetException
	|-Task<Nullable<Image>>.TrySetException
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetException
	|-Task<Nullable<InventoryResult>>.TrySetException
	|-Task<Nullable<Item>>.TrySetException
	|-Task<Nullable<ResultPage>>.TrySetException
	|-Task<Nullable<int>>.TrySetException
	|-Task<Nullable<Int32Enum>>.TrySetException
	|-Task<object>.TrySetException
	|-Task<VoidTaskResult>.TrySetException
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A46B30 Offset: 0x1A45F30 VA: 0x181A46B30
	|-Task<PublishResult>.TrySetCanceled
	|-Task<bool>.TrySetCanceled
	|-Task<int>.TrySetCanceled
	|-Task<UdpReceiveResult>.TrySetCanceled
	|-Task<Nullable<ServerInfo>>.TrySetCanceled
	|-Task<Nullable<Image>>.TrySetCanceled
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetCanceled
	|-Task<Nullable<InventoryResult>>.TrySetCanceled
	|-Task<Nullable<Item>>.TrySetCanceled
	|-Task<Nullable<ResultPage>>.TrySetCanceled
	|-Task<Nullable<int>>.TrySetCanceled
	|-Task<Nullable<Int32Enum>>.TrySetCanceled
	|-Task<object>.TrySetCanceled
	|-Task<VoidTaskResult>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A46B60 Offset: 0x1A45F60 VA: 0x181A46B60
	|-Task<PublishResult>.TrySetCanceled
	|-Task<bool>.TrySetCanceled
	|-Task<int>.TrySetCanceled
	|-Task<UdpReceiveResult>.TrySetCanceled
	|-Task<Nullable<ServerInfo>>.TrySetCanceled
	|-Task<Nullable<Image>>.TrySetCanceled
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetCanceled
	|-Task<Nullable<InventoryResult>>.TrySetCanceled
	|-Task<Nullable<Item>>.TrySetCanceled
	|-Task<Nullable<ResultPage>>.TrySetCanceled
	|-Task<Nullable<int>>.TrySetCanceled
	|-Task<Nullable<Int32Enum>>.TrySetCanceled
	|-Task<object>.TrySetCanceled
	|-Task<VoidTaskResult>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public static TaskFactory<TResult> get_Factory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11784F0 Offset: 0x11778F0 VA: 0x1811784F0
	|-Task<Stream>.get_Factory
	|-Task<int>.get_Factory
	|-Task<UdpReceiveResult>.get_Factory
	|-Task<WebResponse>.get_Factory
	|-Task<PublishResult>.get_Factory
	|-Task<bool>.get_Factory
	|-Task<Nullable<ServerInfo>>.get_Factory
	|-Task<Nullable<Image>>.get_Factory
	|-Task<Nullable<InventoryPurchaseResult>>.get_Factory
	|-Task<Nullable<InventoryResult>>.get_Factory
	|-Task<Nullable<Item>>.get_Factory
	|-Task<Nullable<ResultPage>>.get_Factory
	|-Task<Nullable<int>>.get_Factory
	|-Task<Nullable<Int32Enum>>.get_Factory
	|-Task<object>.get_Factory
	|-Task<VoidTaskResult>.get_Factory
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A88610 Offset: 0x1A87A10 VA: 0x181A88610
	|-Task<PublishResult>.InnerInvoke
	|
	|-RVA: 0x1A46160 Offset: 0x1A45560 VA: 0x181A46160
	|-Task<bool>.InnerInvoke
	|-Task<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0x1A88130 Offset: 0x1A87530 VA: 0x181A88130
	|-Task<int>.InnerInvoke
	|
	|-RVA: 0x1A88520 Offset: 0x1A87920 VA: 0x181A88520
	|-Task<UdpReceiveResult>.InnerInvoke
	|
	|-RVA: 0x1A882F0 Offset: 0x1A876F0 VA: 0x181A882F0
	|-Task<Nullable<ServerInfo>>.InnerInvoke
	|
	|-RVA: 0x1A87E70 Offset: 0x1A87270 VA: 0x181A87E70
	|-Task<Nullable<Image>>.InnerInvoke
	|
	|-RVA: 0x1A88200 Offset: 0x1A87600 VA: 0x181A88200
	|-Task<Nullable<InventoryPurchaseResult>>.InnerInvoke
	|-Task<Nullable<ResultPage>>.InnerInvoke
	|
	|-RVA: 0x1A88430 Offset: 0x1A87830 VA: 0x181A88430
	|-Task<Nullable<InventoryResult>>.InnerInvoke
	|
	|-RVA: 0x1A87F60 Offset: 0x1A87360 VA: 0x181A87F60
	|-Task<Nullable<Item>>.InnerInvoke
	|
	|-RVA: 0x1A45FB0 Offset: 0x1A453B0 VA: 0x181A45FB0
	|-Task<Nullable<int>>.InnerInvoke
	|-Task<Nullable<Int32Enum>>.InnerInvoke
	|
	|-RVA: 0x1A46080 Offset: 0x1A45480 VA: 0x181A46080
	|-Task<object>.InnerInvoke
	|-Task<Task>.InnerInvoke
	*/

	// RVA: -1 Offset: -1
	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A45E80 Offset: 0x1A45280 VA: 0x181A45E80
	|-Task<CompanionSubscription.Status>.GetAwaiter
	|-Task<IAuthTicket>.GetAwaiter
	|-Task<IPlayerInfo>.GetAwaiter
	|-Task<IPlayerInventory>.GetAwaiter
	|-Task<IPlayerInventory[]>.GetAwaiter
	|-Task<MP3Stream>.GetAwaiter
	|-Task<SteamInventoryCrafting.MarketPrice>.GetAwaiter
	|-Task<AuthTicket>.GetAwaiter
	|-Task<InventoryDef[]>.GetAwaiter
	|-Task<PublishResult>.GetAwaiter
	|-Task<byte[]>.GetAwaiter
	|-Task<Dictionary<string, string>>.GetAwaiter
	|-Task<List<IPlayerItemDefinition>>.GetAwaiter
	|-Task<Stream>.GetAwaiter
	|-Task<HttpResponseMessage>.GetAwaiter
	|-Task<UdpReceiveResult>.GetAwaiter
	|-Task<Nullable<ServerInfo>>.GetAwaiter
	|-Task<Nullable<Image>>.GetAwaiter
	|-Task<Nullable<InventoryPurchaseResult>>.GetAwaiter
	|-Task<Nullable<InventoryResult>>.GetAwaiter
	|-Task<Nullable<Item>>.GetAwaiter
	|-Task<Nullable<ResultPage>>.GetAwaiter
	|-Task<string>.GetAwaiter
	|-Task<bool>.GetAwaiter
	|-Task<int>.GetAwaiter
	|-Task<Nullable<int>>.GetAwaiter
	|-Task<Nullable<Int32Enum>>.GetAwaiter
	|-Task<object>.GetAwaiter
	|-Task<VoidTaskResult>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A45270 Offset: 0x1A44670 VA: 0x181A45270
	|-Task<AsyncProtocolResult>.ConfigureAwait
	|-Task<Stream>.ConfigureAwait
	|-Task<HttpResponseMessage>.ConfigureAwait
	|-Task<WebResponse>.ConfigureAwait
	|-Task<Nullable<int>>.ConfigureAwait
	|-Task<string>.ConfigureAwait
	|-Task<PublishResult>.ConfigureAwait
	|-Task<bool>.ConfigureAwait
	|-Task<int>.ConfigureAwait
	|-Task<UdpReceiveResult>.ConfigureAwait
	|-Task<Nullable<ServerInfo>>.ConfigureAwait
	|-Task<Nullable<Image>>.ConfigureAwait
	|-Task<Nullable<InventoryPurchaseResult>>.ConfigureAwait
	|-Task<Nullable<InventoryResult>>.ConfigureAwait
	|-Task<Nullable<Item>>.ConfigureAwait
	|-Task<Nullable<ResultPage>>.ConfigureAwait
	|-Task<Nullable<Int32Enum>>.ConfigureAwait
	|-Task<object>.ConfigureAwait
	|-Task<Task>.ConfigureAwait
	|-Task<VoidTaskResult>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A45930 Offset: 0x1A44D30 VA: 0x181A45930
	|-Task<ISocket>.ContinueWith
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x1A860F0 Offset: 0x1A854F0 VA: 0x181A860F0
	|-Task<PublishResult>.ContinueWith
	|
	|-RVA: 0x1A867D0 Offset: 0x1A85BD0 VA: 0x181A867D0
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1A86710 Offset: 0x1A85B10 VA: 0x181A86710
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1A861B0 Offset: 0x1A855B0 VA: 0x181A861B0
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-RVA: 0x1A86650 Offset: 0x1A85A50 VA: 0x181A86650
	|-Task<Nullable<ServerInfo>>.ContinueWith
	|
	|-RVA: 0x1A85A60 Offset: 0x1A84E60 VA: 0x181A85A60
	|-Task<Nullable<Image>>.ContinueWith
	|
	|-RVA: 0x1A87110 Offset: 0x1A86510 VA: 0x181A87110
	|-Task<Nullable<InventoryPurchaseResult>>.ContinueWith
	|
	|-RVA: 0x1A86E60 Offset: 0x1A86260 VA: 0x181A86E60
	|-Task<Nullable<InventoryResult>>.ContinueWith
	|
	|-RVA: 0x1A873C0 Offset: 0x1A867C0 VA: 0x181A873C0
	|-Task<Nullable<Item>>.ContinueWith
	|
	|-RVA: 0x1A859A0 Offset: 0x1A84DA0 VA: 0x181A859A0
	|-Task<Nullable<ResultPage>>.ContinueWith
	|
	|-RVA: 0x1A45BE0 Offset: 0x1A44FE0 VA: 0x181A45BE0
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1A45680 Offset: 0x1A44A80 VA: 0x181A45680
	|-Task<Nullable<Int32Enum>>.ContinueWith
	|
	|-RVA: 0x1A45CA0 Offset: 0x1A450A0 VA: 0x181A45CA0
	|-Task<VoidTaskResult>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A86890 Offset: 0x1A85C90 VA: 0x181A86890
	|-Task<PublishResult>.ContinueWith
	|
	|-RVA: 0x1A871D0 Offset: 0x1A865D0 VA: 0x181A871D0
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1A85F00 Offset: 0x1A85300 VA: 0x181A85F00
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1A85D10 Offset: 0x1A85110 VA: 0x181A85D10
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-RVA: 0x1A86270 Offset: 0x1A85670 VA: 0x181A86270
	|-Task<Nullable<ServerInfo>>.ContinueWith
	|
	|-RVA: 0x1A85B20 Offset: 0x1A84F20 VA: 0x181A85B20
	|-Task<Nullable<Image>>.ContinueWith
	|
	|-RVA: 0x1A86460 Offset: 0x1A85860 VA: 0x181A86460
	|-Task<Nullable<InventoryPurchaseResult>>.ContinueWith
	|
	|-RVA: 0x1A86C70 Offset: 0x1A86070 VA: 0x181A86C70
	|-Task<Nullable<InventoryResult>>.ContinueWith
	|
	|-RVA: 0x1A86F20 Offset: 0x1A86320 VA: 0x181A86F20
	|-Task<Nullable<Item>>.ContinueWith
	|
	|-RVA: 0x1A86A80 Offset: 0x1A85E80 VA: 0x181A86A80
	|-Task<Nullable<ResultPage>>.ContinueWith
	|
	|-RVA: 0x1A45740 Offset: 0x1A44B40 VA: 0x181A45740
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1A452A0 Offset: 0x1A446A0 VA: 0x181A452A0
	|-Task<Nullable<Int32Enum>>.ContinueWith
	|
	|-RVA: 0x1A45490 Offset: 0x1A44890 VA: 0x181A45490
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x1A459F0 Offset: 0x1A44DF0 VA: 0x181A459F0
	|-Task<VoidTaskResult>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84940 Offset: 0xE83D40 VA: 0x180E84940
	|-Task<Dictionary<string, string>>.ContinueWith<Task<Dictionary<string, string>>>
	|-Task<object>.ContinueWith<object>
	*/

	// RVA: -1 Offset: -1
	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE849F0 Offset: 0xE83DF0 VA: 0x180E849F0
	|-Task<object>.ContinueWith<object>
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A46E80 Offset: 0x1A46280 VA: 0x181A46E80
	|-Task<PublishResult>..cctor
	|-Task<bool>..cctor
	|-Task<int>..cctor
	|-Task<UdpReceiveResult>..cctor
	|-Task<Nullable<ServerInfo>>..cctor
	|-Task<Nullable<Image>>..cctor
	|-Task<Nullable<InventoryPurchaseResult>>..cctor
	|-Task<Nullable<InventoryResult>>..cctor
	|-Task<Nullable<Item>>..cctor
	|-Task<Nullable<ResultPage>>..cctor
	|-Task<Nullable<int>>..cctor
	|-Task<Nullable<Int32Enum>>..cctor
	|-Task<object>..cctor
	|-Task<VoidTaskResult>..cctor
	*/

}

public class TaskFactory<TResult> // TypeDefIndex: 845
{
// Namespace: System.Threading.Tasks
public class TaskFactory<TResult> // TypeDefIndex: 845
	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x0
	private TaskScheduler m_defaultScheduler; // 0x0
	private TaskCreationOptions m_defaultCreationOptions; // 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A85960 Offset: 0x1A84D60 VA: 0x181A85960
	|-TaskFactory<PublishResult>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<UdpReceiveResult>..ctor
	|-TaskFactory<Nullable<ServerInfo>>..ctor
	|-TaskFactory<Nullable<Image>>..ctor
	|-TaskFactory<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskFactory<Nullable<InventoryResult>>..ctor
	|-TaskFactory<Nullable<Item>>..ctor
	|-TaskFactory<Nullable<ResultPage>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<Nullable<Int32Enum>>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A858E0 Offset: 0x1A84CE0 VA: 0x181A858E0
	|-TaskFactory<PublishResult>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<UdpReceiveResult>..ctor
	|-TaskFactory<Nullable<ServerInfo>>..ctor
	|-TaskFactory<Nullable<Image>>..ctor
	|-TaskFactory<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskFactory<Nullable<InventoryResult>>..ctor
	|-TaskFactory<Nullable<Item>>..ctor
	|-TaskFactory<Nullable<ResultPage>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<Nullable<Int32Enum>>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A853A0 Offset: 0x1A847A0 VA: 0x181A853A0
	|-TaskFactory<PublishResult>.StartNew
	|
	|-RVA: 0x1A84D10 Offset: 0x1A84110 VA: 0x181A84D10
	|-TaskFactory<bool>.StartNew
	|
	|-RVA: 0x1A84BC0 Offset: 0x1A83FC0 VA: 0x181A84BC0
	|-TaskFactory<int>.StartNew
	|
	|-RVA: 0x1A84920 Offset: 0x1A83D20 VA: 0x181A84920
	|-TaskFactory<UdpReceiveResult>.StartNew
	|
	|-RVA: 0x1A854F0 Offset: 0x1A848F0 VA: 0x181A854F0
	|-TaskFactory<Nullable<ServerInfo>>.StartNew
	|
	|-RVA: 0x1A85640 Offset: 0x1A84A40 VA: 0x181A85640
	|-TaskFactory<Nullable<Image>>.StartNew
	|
	|-RVA: 0x1A847D0 Offset: 0x1A83BD0 VA: 0x181A847D0
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.StartNew
	|
	|-RVA: 0x1A85250 Offset: 0x1A84650 VA: 0x181A85250
	|-TaskFactory<Nullable<InventoryResult>>.StartNew
	|
	|-RVA: 0x1A85100 Offset: 0x1A84500 VA: 0x181A85100
	|-TaskFactory<Nullable<Item>>.StartNew
	|
	|-RVA: 0x1A84A70 Offset: 0x1A83E70 VA: 0x181A84A70
	|-TaskFactory<Nullable<ResultPage>>.StartNew
	|
	|-RVA: 0x1A84FB0 Offset: 0x1A843B0 VA: 0x181A84FB0
	|-TaskFactory<Nullable<int>>.StartNew
	|
	|-RVA: 0x1A84E60 Offset: 0x1A84260 VA: 0x181A84E60
	|-TaskFactory<Nullable<Int32Enum>>.StartNew
	|
	|-RVA: 0x1A84680 Offset: 0x1A83A80 VA: 0x181A84680
	|-TaskFactory<object>.StartNew
	|
	|-RVA: 0x1A85790 Offset: 0x1A84B90 VA: 0x181A85790
	|-TaskFactory<VoidTaskResult>.StartNew
	*/

	// RVA: -1 Offset: -1
	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A7A910 Offset: 0x1A79D10 VA: 0x181A7A910
	|-TaskFactory<PublishResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7BC80 Offset: 0x1A7B080 VA: 0x181A7BC80
	|-TaskFactory<bool>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7B290 Offset: 0x1A7A690 VA: 0x181A7B290
	|-TaskFactory<int>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7C110 Offset: 0x1A7B510 VA: 0x181A7C110
	|-TaskFactory<UdpReceiveResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7B720 Offset: 0x1A7AB20 VA: 0x181A7B720
	|-TaskFactory<Nullable<ServerInfo>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7ADD0 Offset: 0x1A7A1D0 VA: 0x181A7ADD0
	|-TaskFactory<Nullable<Image>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7DDF0 Offset: 0x1A7D1F0 VA: 0x181A7DDF0
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7CED0 Offset: 0x1A7C2D0 VA: 0x181A7CED0
	|-TaskFactory<Nullable<InventoryResult>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7D370 Offset: 0x1A7C770 VA: 0x181A7D370
	|-TaskFactory<Nullable<Item>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7C5B0 Offset: 0x1A7B9B0 VA: 0x181A7C5B0
	|-TaskFactory<Nullable<ResultPage>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7D980 Offset: 0x1A7CD80 VA: 0x181A7D980
	|-TaskFactory<Nullable<int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7CA60 Offset: 0x1A7BE60 VA: 0x181A7CA60
	|-TaskFactory<Nullable<Int32Enum>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7A010 Offset: 0x1A79410 VA: 0x181A7A010
	|-TaskFactory<object>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A7A4A0 Offset: 0x1A798A0 VA: 0x181A7A4A0
	|-TaskFactory<VoidTaskResult>.FromAsyncCoreLogic
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A84630 Offset: 0x1A83A30 VA: 0x181A84630
	|-TaskFactory<Stream>.FromAsync
	|-TaskFactory<UdpReceiveResult>.FromAsync
	|-TaskFactory<WebResponse>.FromAsync
	|-TaskFactory<PublishResult>.FromAsync
	|-TaskFactory<bool>.FromAsync
	|-TaskFactory<int>.FromAsync
	|-TaskFactory<Nullable<ServerInfo>>.FromAsync
	|-TaskFactory<Nullable<Image>>.FromAsync
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsync
	|-TaskFactory<Nullable<InventoryResult>>.FromAsync
	|-TaskFactory<Nullable<Item>>.FromAsync
	|-TaskFactory<Nullable<ResultPage>>.FromAsync
	|-TaskFactory<Nullable<int>>.FromAsync
	|-TaskFactory<Nullable<Int32Enum>>.FromAsync
	|-TaskFactory<object>.FromAsync
	|-TaskFactory<VoidTaskResult>.FromAsync
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A7F7E0 Offset: 0x1A7EBE0 VA: 0x181A7F7E0
	|-TaskFactory<PublishResult>.FromAsyncImpl
	|
	|-RVA: 0x1A83F40 Offset: 0x1A83340 VA: 0x181A83F40
	|-TaskFactory<bool>.FromAsyncImpl
	|
	|-RVA: 0x1A81560 Offset: 0x1A80960 VA: 0x181A81560
	|-TaskFactory<int>.FromAsyncImpl
	|
	|-RVA: 0x1A83840 Offset: 0x1A82C40 VA: 0x181A83840
	|-TaskFactory<UdpReceiveResult>.FromAsyncImpl
	|
	|-RVA: 0x1A80DE0 Offset: 0x1A801E0 VA: 0x181A80DE0
	|-TaskFactory<Nullable<ServerInfo>>.FromAsyncImpl
	|
	|-RVA: 0x1A7E2A0 Offset: 0x1A7D6A0 VA: 0x181A7E2A0
	|-TaskFactory<Nullable<Image>>.FromAsyncImpl
	|
	|-RVA: 0x1A82340 Offset: 0x1A81740 VA: 0x181A82340
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsyncImpl
	|
	|-RVA: 0x1A7FF10 Offset: 0x1A7F310 VA: 0x181A7FF10
	|-TaskFactory<Nullable<InventoryResult>>.FromAsyncImpl
	|
	|-RVA: 0x1A80630 Offset: 0x1A7FA30 VA: 0x181A80630
	|-TaskFactory<Nullable<Item>>.FromAsyncImpl
	|
	|-RVA: 0x1A7F0C0 Offset: 0x1A7E4C0 VA: 0x181A7F0C0
	|-TaskFactory<Nullable<ResultPage>>.FromAsyncImpl
	|
	|-RVA: 0x1A81C50 Offset: 0x1A81050 VA: 0x181A81C50
	|-TaskFactory<Nullable<int>>.FromAsyncImpl
	|
	|-RVA: 0x1A82A60 Offset: 0x1A81E60 VA: 0x181A82A60
	|-TaskFactory<Nullable<Int32Enum>>.FromAsyncImpl
	|
	|-RVA: 0x1A7E9D0 Offset: 0x1A7DDD0 VA: 0x181A7E9D0
	|-TaskFactory<object>.FromAsyncImpl
	|
	|-RVA: 0x1A83150 Offset: 0x1A82550 VA: 0x181A83150
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1549980 Offset: 0x1548D80 VA: 0x181549980
	|-TaskFactory<int>.FromAsync<byte[], int>
	|-TaskFactory<int>.FromAsync<object, int>
	|
	|-RVA: 0x15499E0 Offset: 0x1548DE0 VA: 0x1815499E0
	|-TaskFactory<object>.FromAsync<object, object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15487F0 Offset: 0x1547BF0 VA: 0x1815487F0
	|-TaskFactory<int>.FromAsyncImpl<object, int>
	|
	|-RVA: 0x1548E30 Offset: 0x1548230 VA: 0x181548E30
	|-TaskFactory<object>.FromAsyncImpl<object, object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1549470 Offset: 0x1548870 VA: 0x181549470
	|-TaskFactory<int>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x15497D0 Offset: 0x1548BD0 VA: 0x1815497D0
	|-TaskFactory<object>.FromAsyncTrim<object, object>
	|
	|-RVA: 0x1549620 Offset: 0x1548A20 VA: 0x181549620
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	*/

}

internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction // TypeDefIndex: 868
{	// Fields
	private byte _state; // 0x0
	private readonly bool _lookForOce; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A51F40 Offset: 0x1A51340 VA: 0x181A51F40
	|-UnwrapPromise<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void Invoke(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A518A0 Offset: 0x1A50CA0 VA: 0x181A518A0
	|-UnwrapPromise<object>.Invoke
	*/

	// RVA: -1 Offset: -1
	private void InvokeCore(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A51840 Offset: 0x1A50C40 VA: 0x181A51840
	|-UnwrapPromise<object>.InvokeCore
	*/

	// RVA: -1 Offset: -1
	private void InvokeCoreAsync(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A51600 Offset: 0x1A50A00 VA: 0x181A51600
	|-UnwrapPromise<object>.InvokeCoreAsync
	*/

	// RVA: -1 Offset: -1
	private void ProcessCompletedOuterTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A51A10 Offset: 0x1A50E10 VA: 0x181A51A10
	|-UnwrapPromise<object>.ProcessCompletedOuterTask
	*/

	// RVA: -1 Offset: -1
	private bool TrySetFromTask(Task task, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A51C70 Offset: 0x1A51070 VA: 0x181A51C70
	|-UnwrapPromise<object>.TrySetFromTask
	*/

	// RVA: -1 Offset: -1
	private void ProcessInnerTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A51BC0 Offset: 0x1A50FC0 VA: 0x181A51BC0
	|-UnwrapPromise<object>.ProcessInnerTask
	*/

}

public class TaskCompletionSource<TResult> // TypeDefIndex: 871
{	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363EB0 Offset: 0x13632B0 VA: 0x181363EB0
	|-TaskCompletionSource<HttpResponseMessage>..ctor
	|-TaskCompletionSource<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	|-TaskCompletionSource<HttpResponseMessage>.get_Task
	|-TaskCompletionSource<object>.get_Task
	*/

	// RVA: -1 Offset: -1
	private void SpinUntilCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363DA0 Offset: 0x13631A0 VA: 0x181363DA0
	|-TaskCompletionSource<object>.SpinUntilCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363E80 Offset: 0x1363280 VA: 0x181363E80
	|-TaskCompletionSource<object>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363E00 Offset: 0x1363200 VA: 0x181363E00
	|-TaskCompletionSource<object>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public void SetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363D00 Offset: 0x1363100 VA: 0x181363D00
	|-TaskCompletionSource<HttpResponseMessage>.SetCanceled
	|-TaskCompletionSource<object>.SetCanceled
	*/

}

internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task // TypeDefIndex: 873
{	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x135F8A0 Offset: 0x135ECA0 VA: 0x18135F8A0
	|-ContinuationTaskFromResultTask<PublishResult>..ctor
	|
	|-RVA: 0x135FE40 Offset: 0x135F240 VA: 0x18135FE40
	|-ContinuationTaskFromResultTask<bool>..ctor
	|
	|-RVA: 0x135FC60 Offset: 0x135F060 VA: 0x18135FC60
	|-ContinuationTaskFromResultTask<int>..ctor
	|
	|-RVA: 0x135F990 Offset: 0x135ED90 VA: 0x18135F990
	|-ContinuationTaskFromResultTask<UdpReceiveResult>..ctor
	|
	|-RVA: 0x135FB70 Offset: 0x135EF70 VA: 0x18135FB70
	|-ContinuationTaskFromResultTask<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x135FD50 Offset: 0x135F150 VA: 0x18135FD50
	|-ContinuationTaskFromResultTask<Nullable<Image>>..ctor
	|
	|-RVA: 0x135F7B0 Offset: 0x135EBB0 VA: 0x18135F7B0
	|-ContinuationTaskFromResultTask<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x135F4E0 Offset: 0x135E8E0 VA: 0x18135F4E0
	|-ContinuationTaskFromResultTask<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x135F5D0 Offset: 0x135E9D0 VA: 0x18135F5D0
	|-ContinuationTaskFromResultTask<Nullable<Item>>..ctor
	|
	|-RVA: 0x135FF30 Offset: 0x135F330 VA: 0x18135FF30
	|-ContinuationTaskFromResultTask<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x135F6C0 Offset: 0x135EAC0 VA: 0x18135F6C0
	|-ContinuationTaskFromResultTask<Nullable<int>>..ctor
	|
	|-RVA: 0x135F300 Offset: 0x135E700 VA: 0x18135F300
	|-ContinuationTaskFromResultTask<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x135F3F0 Offset: 0x135E7F0 VA: 0x18135F3F0
	|-ContinuationTaskFromResultTask<object>..ctor
	|
	|-RVA: 0x135FA80 Offset: 0x135EE80 VA: 0x18135FA80
	|-ContinuationTaskFromResultTask<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x135F1F0 Offset: 0x135E5F0 VA: 0x18135F1F0
	|-ContinuationTaskFromResultTask<PublishResult>.InnerInvoke
	|-ContinuationTaskFromResultTask<bool>.InnerInvoke
	|-ContinuationTaskFromResultTask<int>.InnerInvoke
	|-ContinuationTaskFromResultTask<UdpReceiveResult>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<ServerInfo>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<Image>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<InventoryPurchaseResult>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<InventoryResult>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<Item>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<ResultPage>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<int>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<Int32Enum>>.InnerInvoke
	|-ContinuationTaskFromResultTask<object>.InnerInvoke
	|-ContinuationTaskFromResultTask<VoidTaskResult>.InnerInvoke
	*/

}

internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult> // TypeDefIndex: 874
{	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x135F060 Offset: 0x135E460 VA: 0x18135F060
	|-ContinuationResultTaskFromResultTask<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x135EF40 Offset: 0x135E340 VA: 0x18135EF40
	|-ContinuationResultTaskFromResultTask<object, object>.InnerInvoke
	*/

}

internal sealed class __BinaryWriter // TypeDefIndex: 1105
{	// Fields
	internal Stream sout; // 0x10
	internal FormatterTypeStyle formatterTypeStyle; // 0x18
	internal Hashtable objectMapTable; // 0x20
	internal ObjectWriter objectWriter; // 0x28
	internal BinaryWriter dataWriter; // 0x30
	internal int m_nestedObjectCount; // 0x38
	private int nullCount; // 0x3C
	internal BinaryMethodCall binaryMethodCall; // 0x40
	internal BinaryMethodReturn binaryMethodReturn; // 0x48
	internal BinaryObject binaryObject; // 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; // 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; // 0x60
	internal BinaryObjectString binaryObjectString; // 0x68
	internal BinaryArray binaryArray; // 0x70
	private byte[] byteBuffer; // 0x78
	private int chunkSize; // 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0x90
	internal ObjectNull objectNull; // 0x98
	internal MemberReference memberReference; // 0xA0
	internal BinaryAssembly binaryAssembly; // 0xA8

	// Methods

	// RVA: 0x12A76D0 Offset: 0x12A6AD0 VA: 0x1812A76D0
	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void WriteBegin() { }

	// RVA: 0x12A5550 Offset: 0x12A4950 VA: 0x1812A5550
	internal void WriteEnd() { }

	// RVA: 0x12A5330 Offset: 0x12A4730 VA: 0x1812A5330
	internal void WriteBoolean(bool value) { }

	// RVA: 0x12A5360 Offset: 0x12A4760 VA: 0x1812A5360
	internal void WriteByte(byte value) { }

	// RVA: 0x12A5390 Offset: 0x12A4790 VA: 0x1812A5390
	private void WriteBytes(byte[] value) { }

	// RVA: 0x12A53C0 Offset: 0x12A47C0 VA: 0x1812A53C0
	private void WriteBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x12A53F0 Offset: 0x12A47F0 VA: 0x1812A53F0
	internal void WriteChar(char value) { }

	// RVA: 0x12A5420 Offset: 0x12A4820 VA: 0x1812A5420
	internal void WriteChars(char[] value) { }

	// RVA: 0x12A5480 Offset: 0x12A4880 VA: 0x1812A5480
	internal void WriteDecimal(Decimal value) { }

	// RVA: 0x12A6D40 Offset: 0x12A6140 VA: 0x1812A6D40
	internal void WriteSingle(float value) { }

	// RVA: 0x12A5520 Offset: 0x12A4920 VA: 0x1812A5520
	internal void WriteDouble(double value) { }

	// RVA: 0x12A5580 Offset: 0x12A4980 VA: 0x1812A5580
	internal void WriteInt16(short value) { }

	// RVA: 0x12A55B0 Offset: 0x12A49B0 VA: 0x1812A55B0
	internal void WriteInt32(int value) { }

	// RVA: 0x12A5450 Offset: 0x12A4850 VA: 0x1812A5450
	internal void WriteInt64(long value) { }

	// RVA: 0x12A5360 Offset: 0x12A4760 VA: 0x1812A5360
	internal void WriteSByte(sbyte value) { }

	// RVA: 0x12A6D70 Offset: 0x12A6170 VA: 0x1812A6D70
	internal void WriteString(string value) { }

	// RVA: 0x12A5450 Offset: 0x12A4850 VA: 0x1812A5450
	internal void WriteTimeSpan(TimeSpan value) { }

	// RVA: 0x12A5450 Offset: 0x12A4850 VA: 0x1812A5450
	internal void WriteDateTime(DateTime value) { }

	// RVA: 0x12A6DA0 Offset: 0x12A61A0 VA: 0x1812A6DA0
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x12A6DD0 Offset: 0x12A61D0 VA: 0x1812A6DD0
	internal void WriteUInt32(uint value) { }

	// RVA: 0x12A6E00 Offset: 0x12A6200 VA: 0x1812A6E00
	internal void WriteUInt64(ulong value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x12A68B0 Offset: 0x12A5CB0 VA: 0x1812A68B0
	internal void WriteSerializationHeaderEnd() { }

	// RVA: 0x12A6930 Offset: 0x12A5D30 VA: 0x1812A6930
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	// RVA: 0x12A5DD0 Offset: 0x12A51D0 VA: 0x1812A5DD0
	internal void WriteMethodCall() { }

	// RVA: 0x12A5E70 Offset: 0x12A5270 VA: 0x1812A5E70
	internal void WriteMethodReturn() { }

	// RVA: 0x12A6130 Offset: 0x12A5530 VA: 0x1812A6130
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x12A6060 Offset: 0x12A5460 VA: 0x1812A6060
	internal void WriteObjectString(int objectId, string value) { }

	// RVA: 0x12A69F0 Offset: 0x12A5DF0 VA: 0x1812A69F0
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	// RVA: 0x12A4FC0 Offset: 0x12A43C0 VA: 0x1812A4FC0
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	// RVA: 0x12A5850 Offset: 0x12A4C50 VA: 0x1812A5850
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	// RVA: 0x12A66F0 Offset: 0x12A5AF0 VA: 0x1812A66F0
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	// RVA: 0x12A6000 Offset: 0x12A5400 VA: 0x1812A6000
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	// RVA: 0x12A5C50 Offset: 0x12A5050 VA: 0x1812A5C50
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x12A5F20 Offset: 0x12A5320 VA: 0x1812A5F20
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x12A5A90 Offset: 0x12A4E90 VA: 0x1812A5A90
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	// RVA: 0x12A5A60 Offset: 0x12A4E60 VA: 0x1812A5A60
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	// RVA: 0x12A5B60 Offset: 0x12A4F60 VA: 0x1812A5B60
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	// RVA: 0x12A56D0 Offset: 0x12A4AD0 VA: 0x1812A56D0
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x12A5F10 Offset: 0x12A5310 VA: 0x1812A5F10
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x12A5510 Offset: 0x12A4910 VA: 0x1812A5510
	internal void WriteDelayedNullItem() { }

	// RVA: 0x12A55E0 Offset: 0x12A49E0 VA: 0x1812A55E0
	internal void WriteItemEnd() { }

	// RVA: 0x12A4F00 Offset: 0x12A4300 VA: 0x1812A4F00
	private void InternalWriteItemNull() { }

	// RVA: 0x12A55F0 Offset: 0x12A49F0 VA: 0x1812A55F0
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	// RVA: 0x12A5230 Offset: 0x12A4630 VA: 0x1812A5230
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	// RVA: 0x12A6E30 Offset: 0x12A6230 VA: 0x1812A6E30
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }

}

internal sealed class __BinaryParser // TypeDefIndex: 1116
{	// Fields
	internal ObjectReader objectReader; // 0x10
	internal Stream input; // 0x18
	internal long topId; // 0x20
	internal long headerId; // 0x28
	internal SizedArray objectMapIdTable; // 0x30
	internal SizedArray assemIdToAssemblyTable; // 0x38
	internal SerStack stack; // 0x40
	internal BinaryTypeEnum expectedType; // 0x48
	internal object expectedTypeInformation; // 0x50
	internal ParseRecord PRS; // 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; // 0x60
	private BinaryReader dataReader; // 0x68
	private static Encoding encoding; // 0x0
	private SerStack opPool; // 0x70
	private BinaryObject binaryObject; // 0x78
	private BinaryObjectWithMap bowm; // 0x80
	private BinaryObjectWithMapTyped bowmt; // 0x88
	internal BinaryObjectString objectString; // 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; // 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0xA0
	private byte[] byteBuffer; // 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0xB0
	internal MemberReference memberReference; // 0xB8
	internal ObjectNull objectNull; // 0xC0
	internal static MessageEnd messageEnd; // 0x8

	// Properties
	internal BinaryAssemblyInfo SystemAssemblyInfo { get; }
	internal SizedArray ObjectMapIdTable { get; }
	internal SizedArray AssemIdToAssemblyTable { get; }
	internal ParseRecord prs { get; }

	// Methods

	// RVA: 0x1209BE0 Offset: 0x1208FE0 VA: 0x181209BE0
	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	// RVA: 0x1209EA0 Offset: 0x12092A0 VA: 0x181209EA0
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	// RVA: 0x1209DD0 Offset: 0x12091D0 VA: 0x181209DD0
	internal SizedArray get_ObjectMapIdTable() { }

	// RVA: 0x1209D00 Offset: 0x1209100 VA: 0x181209D00
	internal SizedArray get_AssemIdToAssemblyTable() { }

	// RVA: 0x1209F80 Offset: 0x1209380 VA: 0x181209F80
	internal ParseRecord get_prs() { }

	// RVA: 0x12095F0 Offset: 0x12089F0 VA: 0x1812095F0
	internal void Run() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void ReadBegin() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void ReadEnd() { }

	// RVA: 0x1204D60 Offset: 0x1204160 VA: 0x181204D60
	internal bool ReadBoolean() { }

	// RVA: 0x1204D90 Offset: 0x1204190 VA: 0x181204D90
	internal byte ReadByte() { }

	// RVA: 0x1204E50 Offset: 0x1204250 VA: 0x181204E50
	internal byte[] ReadBytes(int length) { }

	// RVA: 0x1204DC0 Offset: 0x12041C0 VA: 0x181204DC0
	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x1204E80 Offset: 0x1204280 VA: 0x181204E80
	internal char ReadChar() { }

	// RVA: 0x1204EB0 Offset: 0x12042B0 VA: 0x181204EB0
	internal char[] ReadChars(int length) { }

	// RVA: 0x1205CC0 Offset: 0x12050C0 VA: 0x181205CC0
	internal Decimal ReadDecimal() { }

	// RVA: 0x1208FE0 Offset: 0x12083E0 VA: 0x181208FE0
	internal float ReadSingle() { }

	// RVA: 0x1205D90 Offset: 0x1205190 VA: 0x181205D90
	internal double ReadDouble() { }

	// RVA: 0x1205DC0 Offset: 0x12051C0 VA: 0x181205DC0
	internal short ReadInt16() { }

	// RVA: 0x1205DF0 Offset: 0x12051F0 VA: 0x181205DF0
	internal int ReadInt32() { }

	// RVA: 0x1205E20 Offset: 0x1205220 VA: 0x181205E20
	internal long ReadInt64() { }

	// RVA: 0x1204D90 Offset: 0x1204190 VA: 0x181204D90
	internal sbyte ReadSByte() { }

	// RVA: 0x1209010 Offset: 0x1208410 VA: 0x181209010
	internal string ReadString() { }

	// RVA: 0x1205E20 Offset: 0x1205220 VA: 0x181205E20
	internal TimeSpan ReadTimeSpan() { }

	// RVA: 0x1205C40 Offset: 0x1205040 VA: 0x181205C40
	internal DateTime ReadDateTime() { }

	// RVA: 0x1209040 Offset: 0x1208440 VA: 0x181209040
	internal ushort ReadUInt16() { }

	// RVA: 0x1209070 Offset: 0x1208470 VA: 0x181209070
	internal uint ReadUInt32() { }

	// RVA: 0x12090A0 Offset: 0x12084A0 VA: 0x1812090A0
	internal ulong ReadUInt64() { }

	// RVA: 0x1208F30 Offset: 0x1208330 VA: 0x181208F30
	internal void ReadSerializationHeaderRecord() { }

	// RVA: 0x1204A90 Offset: 0x1203E90 VA: 0x181204A90
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1208A30 Offset: 0x1207E30 VA: 0x181208A30
	private void ReadObject() { }

	// RVA: 0x1204EE0 Offset: 0x12042E0 VA: 0x181204EE0
	internal void ReadCrossAppDomainMap() { }

	// RVA: 0x1208350 Offset: 0x1207750 VA: 0x181208350
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1208410 Offset: 0x1207810 VA: 0x181208410
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	// RVA: 0x1208290 Offset: 0x1207690 VA: 0x181208290
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1207C40 Offset: 0x1207040 VA: 0x181207C40
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	// RVA: 0x12072A0 Offset: 0x12066A0 VA: 0x1812072A0
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1205E50 Offset: 0x1205250 VA: 0x181205E50
	private void ReadMemberPrimitiveTyped() { }

	// RVA: 0x12043A0 Offset: 0x12037A0 VA: 0x1812043A0
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1203E30 Offset: 0x1203230 VA: 0x181203E30
	private void ReadArrayAsBytes(ParseRecord pr) { }

	// RVA: 0x1206450 Offset: 0x1205850 VA: 0x181206450
	private void ReadMemberPrimitiveUnTyped() { }

	// RVA: 0x1206990 Offset: 0x1205D90 VA: 0x181206990
	private void ReadMemberReference() { }

	// RVA: 0x1206ED0 Offset: 0x12062D0 VA: 0x181206ED0
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1206D50 Offset: 0x1206150 VA: 0x181206D50
	private void ReadMessageEnd() { }

	// RVA: 0x12090D0 Offset: 0x12084D0 VA: 0x1812090D0
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	// RVA: 0x1203BF0 Offset: 0x1202FF0 VA: 0x181203BF0
	private ObjectProgress GetOp() { }

	// RVA: 0x1203D90 Offset: 0x1203190 VA: 0x181203D90
	private void PutOp(ObjectProgress op) { }

	// RVA: 0x1209B80 Offset: 0x1208F80 VA: 0x181209B80
	private static void .cctor() { }

}

public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1291
{	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	|-TaskAwaiter<PublishResult>..ctor
	|-TaskAwaiter<bool>..ctor
	|-TaskAwaiter<int>..ctor
	|-TaskAwaiter<UdpReceiveResult>..ctor
	|-TaskAwaiter<Nullable<ServerInfo>>..ctor
	|-TaskAwaiter<Nullable<Image>>..ctor
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskAwaiter<Nullable<InventoryResult>>..ctor
	|-TaskAwaiter<Nullable<Item>>..ctor
	|-TaskAwaiter<Nullable<ResultPage>>..ctor
	|-TaskAwaiter<Nullable<int>>..ctor
	|-TaskAwaiter<Nullable<Int32Enum>>..ctor
	|-TaskAwaiter<object>..ctor
	|-TaskAwaiter<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF50 Offset: 0x14B350 VA: 0x18014BF50
	|-TaskAwaiter<CompanionSubscription.Status>.get_IsCompleted
	|-TaskAwaiter<IAuthTicket>.get_IsCompleted
	|-TaskAwaiter<IPlayerInfo>.get_IsCompleted
	|-TaskAwaiter<IPlayerInventory>.get_IsCompleted
	|-TaskAwaiter<IPlayerInventory[]>.get_IsCompleted
	|-TaskAwaiter<MP3Stream>.get_IsCompleted
	|-TaskAwaiter<SteamInventoryCrafting.MarketPrice>.get_IsCompleted
	|-TaskAwaiter<AuthTicket>.get_IsCompleted
	|-TaskAwaiter<InventoryDef[]>.get_IsCompleted
	|-TaskAwaiter<PublishResult>.get_IsCompleted
	|-TaskAwaiter<bool>.get_IsCompleted
	|-TaskAwaiter<byte[]>.get_IsCompleted
	|-TaskAwaiter<Dictionary<string, string>>.get_IsCompleted
	|-TaskAwaiter<List<IPlayerItemDefinition>>.get_IsCompleted
	|-TaskAwaiter<Stream>.get_IsCompleted
	|-TaskAwaiter<int>.get_IsCompleted
	|-TaskAwaiter<HttpResponseMessage>.get_IsCompleted
	|-TaskAwaiter<UdpReceiveResult>.get_IsCompleted
	|-TaskAwaiter<Nullable<ServerInfo>>.get_IsCompleted
	|-TaskAwaiter<Nullable<Image>>.get_IsCompleted
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.get_IsCompleted
	|-TaskAwaiter<Nullable<InventoryResult>>.get_IsCompleted
	|-TaskAwaiter<Nullable<Item>>.get_IsCompleted
	|-TaskAwaiter<Nullable<ResultPage>>.get_IsCompleted
	|-TaskAwaiter<Nullable<int>>.get_IsCompleted
	|-TaskAwaiter<Nullable<Int32Enum>>.get_IsCompleted
	|-TaskAwaiter<object>.get_IsCompleted
	|-TaskAwaiter<string>.get_IsCompleted
	|-TaskAwaiter<VoidTaskResult>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C890 Offset: 0x14BC90 VA: 0x18014C890
	|-TaskAwaiter<PublishResult>.OnCompleted
	|-TaskAwaiter<bool>.OnCompleted
	|-TaskAwaiter<int>.OnCompleted
	|-TaskAwaiter<UdpReceiveResult>.OnCompleted
	|-TaskAwaiter<Nullable<ServerInfo>>.OnCompleted
	|-TaskAwaiter<Nullable<Image>>.OnCompleted
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.OnCompleted
	|-TaskAwaiter<Nullable<InventoryResult>>.OnCompleted
	|-TaskAwaiter<Nullable<Item>>.OnCompleted
	|-TaskAwaiter<Nullable<ResultPage>>.OnCompleted
	|-TaskAwaiter<Nullable<int>>.OnCompleted
	|-TaskAwaiter<Nullable<Int32Enum>>.OnCompleted
	|-TaskAwaiter<object>.OnCompleted
	|-TaskAwaiter<VoidTaskResult>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C8C0 Offset: 0x14BCC0 VA: 0x18014C8C0
	|-TaskAwaiter<PublishResult>.UnsafeOnCompleted
	|-TaskAwaiter<bool>.UnsafeOnCompleted
	|-TaskAwaiter<int>.UnsafeOnCompleted
	|-TaskAwaiter<UdpReceiveResult>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<ServerInfo>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<Image>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<InventoryResult>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<Item>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<ResultPage>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<Int32Enum>>.UnsafeOnCompleted
	|-TaskAwaiter<object>.UnsafeOnCompleted
	|-TaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3AF0 Offset: 0x1E2EF0 VA: 0x1801E3AF0
	|-TaskAwaiter<CompanionSubscription.Status>.GetResult
	|-TaskAwaiter<IAuthTicket>.GetResult
	|-TaskAwaiter<IPlayerInfo>.GetResult
	|-TaskAwaiter<IPlayerInventory>.GetResult
	|-TaskAwaiter<IPlayerInventory[]>.GetResult
	|-TaskAwaiter<MP3Stream>.GetResult
	|-TaskAwaiter<SteamInventoryCrafting.MarketPrice>.GetResult
	|-TaskAwaiter<AuthTicket>.GetResult
	|-TaskAwaiter<InventoryDef[]>.GetResult
	|-TaskAwaiter<byte[]>.GetResult
	|-TaskAwaiter<Dictionary<string, string>>.GetResult
	|-TaskAwaiter<List<IPlayerItemDefinition>>.GetResult
	|-TaskAwaiter<Stream>.GetResult
	|-TaskAwaiter<HttpResponseMessage>.GetResult
	|-TaskAwaiter<string>.GetResult
	|-TaskAwaiter<object>.GetResult
	|
	|-RVA: 0x1E2DA0 Offset: 0x1E21A0 VA: 0x1801E2DA0
	|-TaskAwaiter<PublishResult>.GetResult
	|-TaskAwaiter<Nullable<Image>>.GetResult
	|
	|-RVA: 0x1E2F20 Offset: 0x1E2320 VA: 0x1801E2F20
	|-TaskAwaiter<UdpReceiveResult>.GetResult
	|
	|-RVA: 0x1E2FD0 Offset: 0x1E23D0 VA: 0x1801E2FD0
	|-TaskAwaiter<Nullable<ServerInfo>>.GetResult
	|
	|-RVA: 0x1E2E60 Offset: 0x1E2260 VA: 0x1801E2E60
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.GetResult
	|-TaskAwaiter<Nullable<ResultPage>>.GetResult
	|
	|-RVA: 0x1E3210 Offset: 0x1E2610 VA: 0x1801E3210
	|-TaskAwaiter<Nullable<InventoryResult>>.GetResult
	|
	|-RVA: 0x1E30D0 Offset: 0x1E24D0 VA: 0x1801E30D0
	|-TaskAwaiter<Nullable<Item>>.GetResult
	|
	|-RVA: 0x1E3AE0 Offset: 0x1E2EE0 VA: 0x1801E3AE0
	|-TaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x1E2D10 Offset: 0x1E2110 VA: 0x1801E2D10
	|-TaskAwaiter<int>.GetResult
	|-TaskAwaiter<Nullable<int>>.GetResult
	|-TaskAwaiter<Nullable<Int32Enum>>.GetResult
	|-TaskAwaiter<VoidTaskResult>.GetResult
	*/

}

public struct ConfiguredTaskAwaitable<TResult> // TypeDefIndex: 1294
{	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2CA0 Offset: 0x1E20A0 VA: 0x1801E2CA0
	|-ConfiguredTaskAwaitable<PublishResult>..ctor
	|-ConfiguredTaskAwaitable<bool>..ctor
	|-ConfiguredTaskAwaitable<int>..ctor
	|-ConfiguredTaskAwaitable<UdpReceiveResult>..ctor
	|-ConfiguredTaskAwaitable<Nullable<ServerInfo>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<Image>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<InventoryPurchaseResult>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<InventoryResult>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<Item>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<ResultPage>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<int>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<Int32Enum>>..ctor
	|-ConfiguredTaskAwaitable<object>..ctor
	|-ConfiguredTaskAwaitable<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B600 Offset: 0x14AA00 VA: 0x18014B600
	|-ConfiguredTaskAwaitable<AsyncProtocolResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<Stream>.GetAwaiter
	|-ConfiguredTaskAwaitable<HttpResponseMessage>.GetAwaiter
	|-ConfiguredTaskAwaitable<WebResponse>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<int>>.GetAwaiter
	|-ConfiguredTaskAwaitable<string>.GetAwaiter
	|-ConfiguredTaskAwaitable<PublishResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<bool>.GetAwaiter
	|-ConfiguredTaskAwaitable<int>.GetAwaiter
	|-ConfiguredTaskAwaitable<UdpReceiveResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<ServerInfo>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<Image>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<InventoryPurchaseResult>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<InventoryResult>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<Item>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<ResultPage>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<Int32Enum>>.GetAwaiter
	|-ConfiguredTaskAwaitable<object>.GetAwaiter
	|-ConfiguredTaskAwaitable<Task>.GetAwaiter
	|-ConfiguredTaskAwaitable<VoidTaskResult>.GetAwaiter
	*/

}

internal struct ConcurrentSet<KeyType, ItemType> // TypeDefIndex: 1507
{	// Fields
	private ItemType[] items; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public ItemType TryGet(KeyType key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B300 Offset: 0x22A700 VA: 0x18022B300
	|-ConcurrentSet<KeyValuePair<object, Int32Enum>, object>.TryGet
	|-ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>.TryGet
	|
	|-RVA: 0x22B3C0 Offset: 0x22A7C0 VA: 0x18022B3C0
	|-ConcurrentSet<object, object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public ItemType GetOrAdd(ItemType newItem) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B2F0 Offset: 0x22A6F0 VA: 0x18022B2F0
	|-ConcurrentSet<KeyValuePair<object, Int32Enum>, object>.GetOrAdd
	|-ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>.GetOrAdd
	|-ConcurrentSet<object, object>.GetOrAdd
	*/

}

internal abstract class ConcurrentSetItem<KeyType, ItemType> // TypeDefIndex: 1508
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int Compare(ItemType other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ConcurrentSetItem<object, object>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(KeyType key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ConcurrentSetItem<object, object>.Compare
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-ConcurrentSetItem<KeyValuePair<object, Int32Enum>, object>..ctor
	|-ConcurrentSetItem<KeyValuePair<string, EventTags>, NameInfo>..ctor
	|-ConcurrentSetItem<object, object>..ctor
	*/

}

internal sealed class InvokeTypeInfo<ContainerType> : TraceLoggingTypeInfo<ContainerType> // TypeDefIndex: 1524
{	// Fields
	private readonly PropertyAnalysis[] properties; // 0x0
	private readonly PropertyAccessor<ContainerType>[] accessors; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TypeAnalysis typeAnalysis) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4CA90 Offset: 0x1B4BE90 VA: 0x181B4CA90
	|-InvokeTypeInfo<bool>..ctor
	|-InvokeTypeInfo<byte>..ctor
	|-InvokeTypeInfo<char>..ctor
	|-InvokeTypeInfo<KeyValuePair<object, object>>..ctor
	|-InvokeTypeInfo<DateTime>..ctor
	|-InvokeTypeInfo<DateTimeOffset>..ctor
	|-InvokeTypeInfo<Decimal>..ctor
	|-InvokeTypeInfo<EmptyStruct>..ctor
	|-InvokeTypeInfo<double>..ctor
	|-InvokeTypeInfo<Guid>..ctor
	|-InvokeTypeInfo<short>..ctor
	|-InvokeTypeInfo<int>..ctor
	|-InvokeTypeInfo<long>..ctor
	|-InvokeTypeInfo<IntPtr>..ctor
	|-InvokeTypeInfo<object>..ctor
	|-InvokeTypeInfo<sbyte>..ctor
	|-InvokeTypeInfo<float>..ctor
	|-InvokeTypeInfo<TimeSpan>..ctor
	|-InvokeTypeInfo<ushort>..ctor
	|-InvokeTypeInfo<uint>..ctor
	|-InvokeTypeInfo<ulong>..ctor
	|-InvokeTypeInfo<UIntPtr>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4C450 Offset: 0x1B4B850 VA: 0x181B4C450
	|-InvokeTypeInfo<bool>.WriteMetadata
	|-InvokeTypeInfo<byte>.WriteMetadata
	|-InvokeTypeInfo<char>.WriteMetadata
	|-InvokeTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|-InvokeTypeInfo<DateTime>.WriteMetadata
	|-InvokeTypeInfo<DateTimeOffset>.WriteMetadata
	|-InvokeTypeInfo<Decimal>.WriteMetadata
	|-InvokeTypeInfo<EmptyStruct>.WriteMetadata
	|-InvokeTypeInfo<double>.WriteMetadata
	|-InvokeTypeInfo<Guid>.WriteMetadata
	|-InvokeTypeInfo<short>.WriteMetadata
	|-InvokeTypeInfo<int>.WriteMetadata
	|-InvokeTypeInfo<long>.WriteMetadata
	|-InvokeTypeInfo<IntPtr>.WriteMetadata
	|-InvokeTypeInfo<object>.WriteMetadata
	|-InvokeTypeInfo<sbyte>.WriteMetadata
	|-InvokeTypeInfo<float>.WriteMetadata
	|-InvokeTypeInfo<TimeSpan>.WriteMetadata
	|-InvokeTypeInfo<ushort>.WriteMetadata
	|-InvokeTypeInfo<uint>.WriteMetadata
	|-InvokeTypeInfo<ulong>.WriteMetadata
	|-InvokeTypeInfo<UIntPtr>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ContainerType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4C3C0 Offset: 0x1B4B7C0 VA: 0x181B4C3C0
	|-InvokeTypeInfo<bool>.WriteData
	|-InvokeTypeInfo<byte>.WriteData
	|-InvokeTypeInfo<char>.WriteData
	|-InvokeTypeInfo<KeyValuePair<object, object>>.WriteData
	|-InvokeTypeInfo<DateTime>.WriteData
	|-InvokeTypeInfo<DateTimeOffset>.WriteData
	|-InvokeTypeInfo<Decimal>.WriteData
	|-InvokeTypeInfo<EmptyStruct>.WriteData
	|-InvokeTypeInfo<double>.WriteData
	|-InvokeTypeInfo<Guid>.WriteData
	|-InvokeTypeInfo<short>.WriteData
	|-InvokeTypeInfo<int>.WriteData
	|-InvokeTypeInfo<long>.WriteData
	|-InvokeTypeInfo<IntPtr>.WriteData
	|-InvokeTypeInfo<object>.WriteData
	|-InvokeTypeInfo<sbyte>.WriteData
	|-InvokeTypeInfo<float>.WriteData
	|-InvokeTypeInfo<TimeSpan>.WriteData
	|-InvokeTypeInfo<ushort>.WriteData
	|-InvokeTypeInfo<uint>.WriteData
	|-InvokeTypeInfo<ulong>.WriteData
	|-InvokeTypeInfo<UIntPtr>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4A5C0 Offset: 0x1B499C0 VA: 0x181B4A5C0
	|-InvokeTypeInfo<bool>.GetData
	|
	|-RVA: 0x1B4B240 Offset: 0x1B4A640 VA: 0x181B4B240
	|-InvokeTypeInfo<byte>.GetData
	|
	|-RVA: 0x1B49440 Offset: 0x1B48840 VA: 0x181B49440
	|-InvokeTypeInfo<char>.GetData
	|
	|-RVA: 0x1B4AFC0 Offset: 0x1B4A3C0 VA: 0x181B4AFC0
	|-InvokeTypeInfo<KeyValuePair<object, object>>.GetData
	|
	|-RVA: 0x1B48F40 Offset: 0x1B48340 VA: 0x181B48F40
	|-InvokeTypeInfo<DateTime>.GetData
	|
	|-RVA: 0x1B4A0C0 Offset: 0x1B494C0 VA: 0x181B4A0C0
	|-InvokeTypeInfo<DateTimeOffset>.GetData
	|
	|-RVA: 0x1B491C0 Offset: 0x1B485C0 VA: 0x181B491C0
	|-InvokeTypeInfo<Decimal>.GetData
	|
	|-RVA: 0x1B49940 Offset: 0x1B48D40 VA: 0x181B49940
	|-InvokeTypeInfo<EmptyStruct>.GetData
	|
	|-RVA: 0x1B4B4C0 Offset: 0x1B4A8C0 VA: 0x181B4B4C0
	|-InvokeTypeInfo<double>.GetData
	|
	|-RVA: 0x1B49BC0 Offset: 0x1B48FC0 VA: 0x181B49BC0
	|-InvokeTypeInfo<Guid>.GetData
	|
	|-RVA: 0x1B4B9C0 Offset: 0x1B4ADC0 VA: 0x181B4B9C0
	|-InvokeTypeInfo<short>.GetData
	|
	|-RVA: 0x1B496C0 Offset: 0x1B48AC0 VA: 0x181B496C0
	|-InvokeTypeInfo<int>.GetData
	|
	|-RVA: 0x1B48CC0 Offset: 0x1B480C0 VA: 0x181B48CC0
	|-InvokeTypeInfo<long>.GetData
	|
	|-RVA: 0x1B4A840 Offset: 0x1B49C40 VA: 0x181B4A840
	|-InvokeTypeInfo<IntPtr>.GetData
	|
	|-RVA: 0x1B4BC40 Offset: 0x1B4B040 VA: 0x181B4BC40
	|-InvokeTypeInfo<object>.GetData
	|
	|-RVA: 0x1B49E40 Offset: 0x1B49240 VA: 0x181B49E40
	|-InvokeTypeInfo<sbyte>.GetData
	|
	|-RVA: 0x1B4AD40 Offset: 0x1B4A140 VA: 0x181B4AD40
	|-InvokeTypeInfo<float>.GetData
	|
	|-RVA: 0x1B4C140 Offset: 0x1B4B540 VA: 0x181B4C140
	|-InvokeTypeInfo<TimeSpan>.GetData
	|
	|-RVA: 0x1B4A340 Offset: 0x1B49740 VA: 0x181B4A340
	|-InvokeTypeInfo<ushort>.GetData
	|
	|-RVA: 0x1B4AAC0 Offset: 0x1B49EC0 VA: 0x181B4AAC0
	|-InvokeTypeInfo<uint>.GetData
	|
	|-RVA: 0x1B4B740 Offset: 0x1B4AB40 VA: 0x181B4B740
	|-InvokeTypeInfo<ulong>.GetData
	|
	|-RVA: 0x1B4BEC0 Offset: 0x1B4B2C0 VA: 0x181B4BEC0
	|-InvokeTypeInfo<UIntPtr>.GetData
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void WriteObjectData(TraceLoggingDataCollector collector, object valueObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4C680 Offset: 0x1B4BA80 VA: 0x181B4C680
	|-InvokeTypeInfo<bool>.WriteObjectData
	|-InvokeTypeInfo<byte>.WriteObjectData
	|-InvokeTypeInfo<EmptyStruct>.WriteObjectData
	|-InvokeTypeInfo<sbyte>.WriteObjectData
	|
	|-RVA: 0x1B4C880 Offset: 0x1B4BC80 VA: 0x181B4C880
	|-InvokeTypeInfo<char>.WriteObjectData
	|-InvokeTypeInfo<short>.WriteObjectData
	|-InvokeTypeInfo<ushort>.WriteObjectData
	|
	|-RVA: 0x1B4C5D0 Offset: 0x1B4B9D0 VA: 0x181B4C5D0
	|-InvokeTypeInfo<KeyValuePair<object, object>>.WriteObjectData
	|-InvokeTypeInfo<DateTimeOffset>.WriteObjectData
	|-InvokeTypeInfo<Decimal>.WriteObjectData
	|-InvokeTypeInfo<Guid>.WriteObjectData
	|
	|-RVA: 0x1B4C7D0 Offset: 0x1B4BBD0 VA: 0x181B4C7D0
	|-InvokeTypeInfo<DateTime>.WriteObjectData
	|-InvokeTypeInfo<long>.WriteObjectData
	|-InvokeTypeInfo<IntPtr>.WriteObjectData
	|-InvokeTypeInfo<TimeSpan>.WriteObjectData
	|-InvokeTypeInfo<ulong>.WriteObjectData
	|-InvokeTypeInfo<UIntPtr>.WriteObjectData
	|
	|-RVA: 0x1B4C520 Offset: 0x1B4B920 VA: 0x181B4C520
	|-InvokeTypeInfo<double>.WriteObjectData
	|
	|-RVA: 0x1B4C9E0 Offset: 0x1B4BDE0 VA: 0x181B4C9E0
	|-InvokeTypeInfo<int>.WriteObjectData
	|-InvokeTypeInfo<uint>.WriteObjectData
	|
	|-RVA: 0x1B4C730 Offset: 0x1B4BB30 VA: 0x181B4C730
	|-InvokeTypeInfo<object>.WriteObjectData
	|
	|-RVA: 0x1B4C930 Offset: 0x1B4BD30 VA: 0x181B4C930
	|-InvokeTypeInfo<float>.WriteObjectData
	*/

}

internal abstract class PropertyAccessor<ContainerType> // TypeDefIndex: 1526
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Write(TraceLoggingDataCollector collector, ref ContainerType value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PropertyAccessor<object>.Write
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object GetData(ContainerType value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PropertyAccessor<object>.GetData
	*/

	// RVA: -1 Offset: -1
	public static PropertyAccessor<ContainerType> Create(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B50DD0 Offset: 0x1B501D0 VA: 0x181B50DD0
	|-PropertyAccessor<bool>.Create
	|
	|-RVA: 0x1B4EA60 Offset: 0x1B4DE60 VA: 0x181B4EA60
	|-PropertyAccessor<byte>.Create
	|
	|-RVA: 0x1B4FA20 Offset: 0x1B4EE20 VA: 0x181B4FA20
	|-PropertyAccessor<char>.Create
	|
	|-RVA: 0x1B511C0 Offset: 0x1B505C0 VA: 0x181B511C0
	|-PropertyAccessor<KeyValuePair<object, object>>.Create
	|
	|-RVA: 0x1B52960 Offset: 0x1B51D60 VA: 0x181B52960
	|-PropertyAccessor<DateTime>.Create
	|
	|-RVA: 0x1B4F240 Offset: 0x1B4E640 VA: 0x181B4F240
	|-PropertyAccessor<DateTimeOffset>.Create
	|
	|-RVA: 0x1B4E280 Offset: 0x1B4D680 VA: 0x181B4E280
	|-PropertyAccessor<Decimal>.Create
	|
	|-RVA: 0x1B4EE50 Offset: 0x1B4E250 VA: 0x181B4EE50
	|-PropertyAccessor<EmptyStruct>.Create
	|
	|-RVA: 0x1B4D6B0 Offset: 0x1B4CAB0 VA: 0x181B4D6B0
	|-PropertyAccessor<double>.Create
	|
	|-RVA: 0x1B52180 Offset: 0x1B51580 VA: 0x181B52180
	|-PropertyAccessor<Guid>.Create
	|
	|-RVA: 0x1B51D90 Offset: 0x1B51190 VA: 0x181B51D90
	|-PropertyAccessor<short>.Create
	|
	|-RVA: 0x1B4FE10 Offset: 0x1B4F210 VA: 0x181B4FE10
	|-PropertyAccessor<int>.Create
	|
	|-RVA: 0x1B4F630 Offset: 0x1B4EA30 VA: 0x181B4F630
	|-PropertyAccessor<long>.Create
	|
	|-RVA: 0x1B515B0 Offset: 0x1B509B0 VA: 0x181B515B0
	|-PropertyAccessor<IntPtr>.Create
	|
	|-RVA: 0x1B52570 Offset: 0x1B51970 VA: 0x181B52570
	|-PropertyAccessor<object>.Create
	|
	|-RVA: 0x1B4E670 Offset: 0x1B4DA70 VA: 0x181B4E670
	|-PropertyAccessor<sbyte>.Create
	|
	|-RVA: 0x1B50200 Offset: 0x1B4F600 VA: 0x181B50200
	|-PropertyAccessor<float>.Create
	|
	|-RVA: 0x1B509E0 Offset: 0x1B4FDE0 VA: 0x181B509E0
	|-PropertyAccessor<TimeSpan>.Create
	|
	|-RVA: 0x1B505F0 Offset: 0x1B4F9F0 VA: 0x181B505F0
	|-PropertyAccessor<ushort>.Create
	|
	|-RVA: 0x1B4DE90 Offset: 0x1B4D290 VA: 0x181B4DE90
	|-PropertyAccessor<uint>.Create
	|
	|-RVA: 0x1B4DAA0 Offset: 0x1B4CEA0 VA: 0x181B4DAA0
	|-PropertyAccessor<ulong>.Create
	|
	|-RVA: 0x1B519A0 Offset: 0x1B50DA0 VA: 0x181B519A0
	|-PropertyAccessor<UIntPtr>.Create
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-PropertyAccessor<bool>..ctor
	|-PropertyAccessor<byte>..ctor
	|-PropertyAccessor<char>..ctor
	|-PropertyAccessor<KeyValuePair<object, object>>..ctor
	|-PropertyAccessor<DateTime>..ctor
	|-PropertyAccessor<DateTimeOffset>..ctor
	|-PropertyAccessor<Decimal>..ctor
	|-PropertyAccessor<EmptyStruct>..ctor
	|-PropertyAccessor<double>..ctor
	|-PropertyAccessor<Guid>..ctor
	|-PropertyAccessor<short>..ctor
	|-PropertyAccessor<int>..ctor
	|-PropertyAccessor<long>..ctor
	|-PropertyAccessor<IntPtr>..ctor
	|-PropertyAccessor<object>..ctor
	|-PropertyAccessor<sbyte>..ctor
	|-PropertyAccessor<float>..ctor
	|-PropertyAccessor<TimeSpan>..ctor
	|-PropertyAccessor<ushort>..ctor
	|-PropertyAccessor<uint>..ctor
	|-PropertyAccessor<ulong>..ctor
	|-PropertyAccessor<UIntPtr>..ctor
	*/

}

internal class NonGenericProperytWriter<ContainerType> : PropertyAccessor<ContainerType> // TypeDefIndex: 1527
{	// Fields
	private readonly TraceLoggingTypeInfo typeInfo; // 0x0
	private readonly MethodInfo getterInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4D620 Offset: 0x1B4CA20 VA: 0x181B4D620
	|-NonGenericProperytWriter<bool>..ctor
	|-NonGenericProperytWriter<byte>..ctor
	|-NonGenericProperytWriter<char>..ctor
	|-NonGenericProperytWriter<KeyValuePair<object, object>>..ctor
	|-NonGenericProperytWriter<DateTime>..ctor
	|-NonGenericProperytWriter<DateTimeOffset>..ctor
	|-NonGenericProperytWriter<Decimal>..ctor
	|-NonGenericProperytWriter<EmptyStruct>..ctor
	|-NonGenericProperytWriter<double>..ctor
	|-NonGenericProperytWriter<Guid>..ctor
	|-NonGenericProperytWriter<short>..ctor
	|-NonGenericProperytWriter<int>..ctor
	|-NonGenericProperytWriter<long>..ctor
	|-NonGenericProperytWriter<IntPtr>..ctor
	|-NonGenericProperytWriter<object>..ctor
	|-NonGenericProperytWriter<sbyte>..ctor
	|-NonGenericProperytWriter<float>..ctor
	|-NonGenericProperytWriter<TimeSpan>..ctor
	|-NonGenericProperytWriter<ushort>..ctor
	|-NonGenericProperytWriter<uint>..ctor
	|-NonGenericProperytWriter<ulong>..ctor
	|-NonGenericProperytWriter<UIntPtr>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Write(TraceLoggingDataCollector collector, ref ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4D1A0 Offset: 0x1B4C5A0 VA: 0x181B4D1A0
	|-NonGenericProperytWriter<bool>.Write
	|-NonGenericProperytWriter<byte>.Write
	|-NonGenericProperytWriter<EmptyStruct>.Write
	|-NonGenericProperytWriter<sbyte>.Write
	|
	|-RVA: 0x1B4D250 Offset: 0x1B4C650 VA: 0x181B4D250
	|-NonGenericProperytWriter<char>.Write
	|-NonGenericProperytWriter<short>.Write
	|-NonGenericProperytWriter<ushort>.Write
	|
	|-RVA: 0x1B4D3B0 Offset: 0x1B4C7B0 VA: 0x181B4D3B0
	|-NonGenericProperytWriter<KeyValuePair<object, object>>.Write
	|-NonGenericProperytWriter<DateTimeOffset>.Write
	|-NonGenericProperytWriter<Decimal>.Write
	|-NonGenericProperytWriter<Guid>.Write
	|
	|-RVA: 0x1B4D0F0 Offset: 0x1B4C4F0 VA: 0x181B4D0F0
	|-NonGenericProperytWriter<DateTime>.Write
	|-NonGenericProperytWriter<long>.Write
	|-NonGenericProperytWriter<IntPtr>.Write
	|-NonGenericProperytWriter<TimeSpan>.Write
	|-NonGenericProperytWriter<ulong>.Write
	|-NonGenericProperytWriter<UIntPtr>.Write
	|
	|-RVA: 0x1B4D300 Offset: 0x1B4C700 VA: 0x181B4D300
	|-NonGenericProperytWriter<double>.Write
	|
	|-RVA: 0x1B4D460 Offset: 0x1B4C860 VA: 0x181B4D460
	|-NonGenericProperytWriter<int>.Write
	|-NonGenericProperytWriter<uint>.Write
	|
	|-RVA: 0x1B4D5C0 Offset: 0x1B4C9C0 VA: 0x181B4D5C0
	|-NonGenericProperytWriter<object>.Write
	|
	|-RVA: 0x1B4D510 Offset: 0x1B4C910 VA: 0x181B4D510
	|-NonGenericProperytWriter<float>.Write
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object GetData(ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4CF70 Offset: 0x1B4C370 VA: 0x181B4CF70
	|-NonGenericProperytWriter<bool>.GetData
	|-NonGenericProperytWriter<byte>.GetData
	|-NonGenericProperytWriter<EmptyStruct>.GetData
	|-NonGenericProperytWriter<sbyte>.GetData
	|
	|-RVA: 0x1B4CF00 Offset: 0x1B4C300 VA: 0x181B4CF00
	|-NonGenericProperytWriter<char>.GetData
	|-NonGenericProperytWriter<short>.GetData
	|-NonGenericProperytWriter<ushort>.GetData
	|
	|-RVA: 0x1B4CE20 Offset: 0x1B4C220 VA: 0x181B4CE20
	|-NonGenericProperytWriter<KeyValuePair<object, object>>.GetData
	|-NonGenericProperytWriter<DateTimeOffset>.GetData
	|-NonGenericProperytWriter<Decimal>.GetData
	|-NonGenericProperytWriter<Guid>.GetData
	|
	|-RVA: 0x1B4CDB0 Offset: 0x1B4C1B0 VA: 0x181B4CDB0
	|-NonGenericProperytWriter<DateTime>.GetData
	|-NonGenericProperytWriter<long>.GetData
	|-NonGenericProperytWriter<IntPtr>.GetData
	|-NonGenericProperytWriter<TimeSpan>.GetData
	|-NonGenericProperytWriter<ulong>.GetData
	|-NonGenericProperytWriter<UIntPtr>.GetData
	|
	|-RVA: 0x1B4CE90 Offset: 0x1B4C290 VA: 0x181B4CE90
	|-NonGenericProperytWriter<double>.GetData
	|
	|-RVA: 0x1B4D080 Offset: 0x1B4C480 VA: 0x181B4D080
	|-NonGenericProperytWriter<int>.GetData
	|-NonGenericProperytWriter<uint>.GetData
	|
	|-RVA: 0x1B4D050 Offset: 0x1B4C450 VA: 0x181B4D050
	|-NonGenericProperytWriter<object>.GetData
	|
	|-RVA: 0x1B4CFE0 Offset: 0x1B4C3E0 VA: 0x181B4CFE0
	|-NonGenericProperytWriter<float>.GetData
	*/

}

internal class ClassPropertyWriter<ContainerType, ValueType> : PropertyAccessor<ContainerType> // TypeDefIndex: 1528
{	// Fields
	private readonly TraceLoggingTypeInfo<ValueType> valueTypeInfo; // 0x0
	private readonly ClassPropertyWriter.Getter<ContainerType, ValueType> getter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20BB9C0 Offset: 0x20BADC0 VA: 0x1820BB9C0
	|-ClassPropertyWriter<bool, int>..ctor
	|
	|-RVA: 0x20BEDC0 Offset: 0x20BE1C0 VA: 0x1820BEDC0
	|-ClassPropertyWriter<bool, long>..ctor
	|
	|-RVA: 0x20BF440 Offset: 0x20BE840 VA: 0x1820BF440
	|-ClassPropertyWriter<bool, object>..ctor
	|
	|-RVA: 0x20BC040 Offset: 0x20BB440 VA: 0x1820BC040
	|-ClassPropertyWriter<byte, int>..ctor
	|
	|-RVA: 0x20BFFA0 Offset: 0x20BF3A0 VA: 0x1820BFFA0
	|-ClassPropertyWriter<byte, long>..ctor
	|
	|-RVA: 0x20BF2A0 Offset: 0x20BE6A0 VA: 0x1820BF2A0
	|-ClassPropertyWriter<byte, object>..ctor
	|
	|-RVA: 0x20BBD00 Offset: 0x20BB100 VA: 0x1820BBD00
	|-ClassPropertyWriter<char, int>..ctor
	|
	|-RVA: 0x20BE740 Offset: 0x20BDB40 VA: 0x1820BE740
	|-ClassPropertyWriter<char, long>..ctor
	|
	|-RVA: 0x20BCEE0 Offset: 0x20BC2E0 VA: 0x1820BCEE0
	|-ClassPropertyWriter<char, object>..ctor
	|
	|-RVA: 0x20BE400 Offset: 0x20BD800 VA: 0x1820BE400
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0x20BC6C0 Offset: 0x20BBAC0 VA: 0x1820BC6C0
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>..ctor
	|
	|-RVA: 0x20BC1E0 Offset: 0x20BB5E0 VA: 0x1820BC1E0
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x20BC380 Offset: 0x20BB780 VA: 0x1820BC380
	|-ClassPropertyWriter<DateTime, int>..ctor
	|
	|-RVA: 0x20BF780 Offset: 0x20BEB80 VA: 0x1820BF780
	|-ClassPropertyWriter<DateTime, long>..ctor
	|
	|-RVA: 0x20BBB60 Offset: 0x20BAF60 VA: 0x1820BBB60
	|-ClassPropertyWriter<DateTime, object>..ctor
	|
	|-RVA: 0x20BD8A0 Offset: 0x20BCCA0 VA: 0x1820BD8A0
	|-ClassPropertyWriter<DateTimeOffset, int>..ctor
	|
	|-RVA: 0x20BC520 Offset: 0x20BB920 VA: 0x1820BC520
	|-ClassPropertyWriter<DateTimeOffset, long>..ctor
	|
	|-RVA: 0x20BEC20 Offset: 0x20BE020 VA: 0x1820BEC20
	|-ClassPropertyWriter<DateTimeOffset, object>..ctor
	|
	|-RVA: 0x20BD220 Offset: 0x20BC620 VA: 0x1820BD220
	|-ClassPropertyWriter<Decimal, int>..ctor
	|
	|-RVA: 0x20BF5E0 Offset: 0x20BE9E0 VA: 0x1820BF5E0
	|-ClassPropertyWriter<Decimal, long>..ctor
	|
	|-RVA: 0x20BFC60 Offset: 0x20BF060 VA: 0x1820BFC60
	|-ClassPropertyWriter<Decimal, object>..ctor
	|
	|-RVA: 0x20BD700 Offset: 0x20BCB00 VA: 0x1820BD700
	|-ClassPropertyWriter<EmptyStruct, int>..ctor
	|
	|-RVA: 0x20BDA40 Offset: 0x20BCE40 VA: 0x1820BDA40
	|-ClassPropertyWriter<EmptyStruct, long>..ctor
	|
	|-RVA: 0x20BD560 Offset: 0x20BC960 VA: 0x1820BD560
	|-ClassPropertyWriter<EmptyStruct, object>..ctor
	|
	|-RVA: 0x20BE0C0 Offset: 0x20BD4C0 VA: 0x1820BE0C0
	|-ClassPropertyWriter<double, int>..ctor
	|
	|-RVA: 0x20BEA80 Offset: 0x20BDE80 VA: 0x1820BEA80
	|-ClassPropertyWriter<double, long>..ctor
	|
	|-RVA: 0x20BF920 Offset: 0x20BED20 VA: 0x1820BF920
	|-ClassPropertyWriter<double, object>..ctor
	|
	|-RVA: 0x20BE260 Offset: 0x20BD660 VA: 0x1820BE260
	|-ClassPropertyWriter<Guid, int>..ctor
	|
	|-RVA: 0x20BDBE0 Offset: 0x20BCFE0 VA: 0x1820BDBE0
	|-ClassPropertyWriter<Guid, long>..ctor
	|
	|-RVA: 0x20BF100 Offset: 0x20BE500 VA: 0x1820BF100
	|-ClassPropertyWriter<Guid, object>..ctor
	|
	|-RVA: 0x20BCBA0 Offset: 0x20BBFA0 VA: 0x1820BCBA0
	|-ClassPropertyWriter<short, int>..ctor
	|
	|-RVA: 0x20BD080 Offset: 0x20BC480 VA: 0x1820BD080
	|-ClassPropertyWriter<short, long>..ctor
	|
	|-RVA: 0x20BC860 Offset: 0x20BBC60 VA: 0x1820BC860
	|-ClassPropertyWriter<short, object>..ctor
	|
	|-RVA: 0x20BBEA0 Offset: 0x20BB2A0 VA: 0x1820BBEA0
	|-ClassPropertyWriter<int, int>..ctor
	|
	|-RVA: 0x20BFAC0 Offset: 0x20BEEC0 VA: 0x1820BFAC0
	|-ClassPropertyWriter<int, long>..ctor
	|
	|-RVA: 0x20BEF60 Offset: 0x20BE360 VA: 0x1820BEF60
	|-ClassPropertyWriter<int, object>..ctor
	|
	|-RVA: 0x20BB820 Offset: 0x20BAC20 VA: 0x1820BB820
	|-ClassPropertyWriter<long, int>..ctor
	|
	|-RVA: 0x20BD3C0 Offset: 0x20BC7C0 VA: 0x1820BD3C0
	|-ClassPropertyWriter<long, long>..ctor
	|
	|-RVA: 0x20BDF20 Offset: 0x20BD320 VA: 0x1820BDF20
	|-ClassPropertyWriter<long, object>..ctor
	|
	|-RVA: 0x20BE8E0 Offset: 0x20BDCE0 VA: 0x1820BE8E0
	|-ClassPropertyWriter<IntPtr, int>..ctor
	|
	|-RVA: 0x20C0140 Offset: 0x20BF540 VA: 0x1820C0140
	|-ClassPropertyWriter<IntPtr, long>..ctor
	|
	|-RVA: 0x20BFE00 Offset: 0x20BF200 VA: 0x1820BFE00
	|-ClassPropertyWriter<IntPtr, object>..ctor
	|
	|-RVA: 0x20BCA00 Offset: 0x20BBE00 VA: 0x1820BCA00
	|-ClassPropertyWriter<object, int>..ctor
	|
	|-RVA: 0x20BDD80 Offset: 0x20BD180 VA: 0x1820BDD80
	|-ClassPropertyWriter<object, long>..ctor
	|
	|-RVA: 0x20BCD40 Offset: 0x20BC140 VA: 0x1820BCD40
	|-ClassPropertyWriter<object, object>..ctor
	|
	|-RVA: 0x20BE5A0 Offset: 0x20BD9A0 VA: 0x1820BE5A0
	|-ClassPropertyWriter<sbyte, int>..ctor
	|
	|-RVA: 0x20C02E0 Offset: 0x20BF6E0 VA: 0x1820C02E0
	|-ClassPropertyWriter<sbyte, long>..ctor
	|
	|-RVA: 0x1B0A420 Offset: 0x1B09820 VA: 0x181B0A420
	|-ClassPropertyWriter<sbyte, object>..ctor
	|
	|-RVA: 0x1B0C160 Offset: 0x1B0B560 VA: 0x181B0C160
	|-ClassPropertyWriter<float, int>..ctor
	|
	|-RVA: 0x1B0BAE0 Offset: 0x1B0AEE0 VA: 0x181B0BAE0
	|-ClassPropertyWriter<float, long>..ctor
	|
	|-RVA: 0x1B0A5C0 Offset: 0x1B099C0 VA: 0x181B0A5C0
	|-ClassPropertyWriter<float, object>..ctor
	|
	|-RVA: 0x1B0B600 Offset: 0x1B0AA00 VA: 0x181B0B600
	|-ClassPropertyWriter<TimeSpan, int>..ctor
	|
	|-RVA: 0x1B0B940 Offset: 0x1B0AD40 VA: 0x181B0B940
	|-ClassPropertyWriter<TimeSpan, long>..ctor
	|
	|-RVA: 0x1B0AF80 Offset: 0x1B0A380 VA: 0x181B0AF80
	|-ClassPropertyWriter<TimeSpan, object>..ctor
	|
	|-RVA: 0x1B0AAA0 Offset: 0x1B09EA0 VA: 0x181B0AAA0
	|-ClassPropertyWriter<ushort, int>..ctor
	|
	|-RVA: 0x1B0AC40 Offset: 0x1B0A040 VA: 0x181B0AC40
	|-ClassPropertyWriter<ushort, long>..ctor
	|
	|-RVA: 0x1B0BFC0 Offset: 0x1B0B3C0 VA: 0x181B0BFC0
	|-ClassPropertyWriter<ushort, object>..ctor
	|
	|-RVA: 0x1B0BC80 Offset: 0x1B0B080 VA: 0x181B0BC80
	|-ClassPropertyWriter<uint, int>..ctor
	|
	|-RVA: 0x1B0BE20 Offset: 0x1B0B220 VA: 0x181B0BE20
	|-ClassPropertyWriter<uint, long>..ctor
	|
	|-RVA: 0x1B0B120 Offset: 0x1B0A520 VA: 0x181B0B120
	|-ClassPropertyWriter<uint, object>..ctor
	|
	|-RVA: 0x1B0B2C0 Offset: 0x1B0A6C0 VA: 0x181B0B2C0
	|-ClassPropertyWriter<ulong, int>..ctor
	|
	|-RVA: 0x1B0B460 Offset: 0x1B0A860 VA: 0x181B0B460
	|-ClassPropertyWriter<ulong, long>..ctor
	|
	|-RVA: 0x1B0A900 Offset: 0x1B09D00 VA: 0x181B0A900
	|-ClassPropertyWriter<ulong, object>..ctor
	|
	|-RVA: 0x1B0A760 Offset: 0x1B09B60 VA: 0x181B0A760
	|-ClassPropertyWriter<UIntPtr, int>..ctor
	|
	|-RVA: 0x1B0ADE0 Offset: 0x1B0A1E0 VA: 0x181B0ADE0
	|-ClassPropertyWriter<UIntPtr, long>..ctor
	|
	|-RVA: 0x1B0B7A0 Offset: 0x1B0ABA0 VA: 0x181B0B7A0
	|-ClassPropertyWriter<UIntPtr, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Write(TraceLoggingDataCollector collector, ref ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20BB580 Offset: 0x20BA980 VA: 0x1820BB580
	|-ClassPropertyWriter<bool, int>.Write
	|-ClassPropertyWriter<byte, int>.Write
	|-ClassPropertyWriter<sbyte, int>.Write
	|
	|-RVA: 0x1B09FC0 Offset: 0x1B093C0 VA: 0x181B09FC0
	|-ClassPropertyWriter<bool, long>.Write
	|-ClassPropertyWriter<bool, object>.Write
	|-ClassPropertyWriter<byte, long>.Write
	|-ClassPropertyWriter<byte, object>.Write
	|-ClassPropertyWriter<sbyte, long>.Write
	|-ClassPropertyWriter<sbyte, object>.Write
	|
	|-RVA: 0x1B0A260 Offset: 0x1B09660 VA: 0x181B0A260
	|-ClassPropertyWriter<char, int>.Write
	|-ClassPropertyWriter<short, int>.Write
	|-ClassPropertyWriter<ushort, int>.Write
	|
	|-RVA: 0x1B09F50 Offset: 0x1B09350 VA: 0x181B09F50
	|-ClassPropertyWriter<char, long>.Write
	|-ClassPropertyWriter<char, object>.Write
	|-ClassPropertyWriter<short, long>.Write
	|-ClassPropertyWriter<short, object>.Write
	|-ClassPropertyWriter<ushort, long>.Write
	|-ClassPropertyWriter<ushort, object>.Write
	|
	|-RVA: 0x20BB500 Offset: 0x20BA900 VA: 0x1820BB500
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>.Write
	|-ClassPropertyWriter<DateTimeOffset, int>.Write
	|-ClassPropertyWriter<Decimal, int>.Write
	|-ClassPropertyWriter<Guid, int>.Write
	|
	|-RVA: 0x20BB410 Offset: 0x20BA810 VA: 0x1820BB410
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>.Write
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>.Write
	|-ClassPropertyWriter<DateTimeOffset, long>.Write
	|-ClassPropertyWriter<DateTimeOffset, object>.Write
	|-ClassPropertyWriter<Decimal, long>.Write
	|-ClassPropertyWriter<Decimal, object>.Write
	|-ClassPropertyWriter<Guid, long>.Write
	|-ClassPropertyWriter<Guid, object>.Write
	|
	|-RVA: 0x1B0A2D0 Offset: 0x1B096D0 VA: 0x181B0A2D0
	|-ClassPropertyWriter<DateTime, int>.Write
	|-ClassPropertyWriter<TimeSpan, int>.Write
	|
	|-RVA: 0x1B0A340 Offset: 0x1B09740 VA: 0x181B0A340
	|-ClassPropertyWriter<DateTime, long>.Write
	|-ClassPropertyWriter<DateTime, object>.Write
	|-ClassPropertyWriter<TimeSpan, long>.Write
	|-ClassPropertyWriter<TimeSpan, object>.Write
	|
	|-RVA: 0x20BB7B0 Offset: 0x20BABB0 VA: 0x1820BB7B0
	|-ClassPropertyWriter<EmptyStruct, int>.Write
	|
	|-RVA: 0x20BB490 Offset: 0x20BA890 VA: 0x1820BB490
	|-ClassPropertyWriter<EmptyStruct, long>.Write
	|-ClassPropertyWriter<EmptyStruct, object>.Write
	|
	|-RVA: 0x20BB740 Offset: 0x20BAB40 VA: 0x1820BB740
	|-ClassPropertyWriter<double, int>.Write
	|
	|-RVA: 0x20BB660 Offset: 0x20BAA60 VA: 0x1820BB660
	|-ClassPropertyWriter<double, long>.Write
	|-ClassPropertyWriter<double, object>.Write
	|
	|-RVA: 0x1B0A3B0 Offset: 0x1B097B0 VA: 0x181B0A3B0
	|-ClassPropertyWriter<int, int>.Write
	|-ClassPropertyWriter<uint, int>.Write
	|
	|-RVA: 0x1B0A110 Offset: 0x1B09510 VA: 0x181B0A110
	|-ClassPropertyWriter<int, long>.Write
	|-ClassPropertyWriter<int, object>.Write
	|-ClassPropertyWriter<uint, long>.Write
	|-ClassPropertyWriter<uint, object>.Write
	|
	|-RVA: 0x1B0A1F0 Offset: 0x1B095F0 VA: 0x181B0A1F0
	|-ClassPropertyWriter<long, int>.Write
	|-ClassPropertyWriter<IntPtr, int>.Write
	|-ClassPropertyWriter<ulong, int>.Write
	|-ClassPropertyWriter<UIntPtr, int>.Write
	|
	|-RVA: 0x1B0A0A0 Offset: 0x1B094A0 VA: 0x181B0A0A0
	|-ClassPropertyWriter<long, long>.Write
	|-ClassPropertyWriter<long, object>.Write
	|-ClassPropertyWriter<IntPtr, long>.Write
	|-ClassPropertyWriter<IntPtr, object>.Write
	|-ClassPropertyWriter<ulong, long>.Write
	|-ClassPropertyWriter<ulong, object>.Write
	|-ClassPropertyWriter<UIntPtr, long>.Write
	|-ClassPropertyWriter<UIntPtr, object>.Write
	|
	|-RVA: 0x20BB6D0 Offset: 0x20BAAD0 VA: 0x1820BB6D0
	|-ClassPropertyWriter<object, int>.Write
	|
	|-RVA: 0x20BB5F0 Offset: 0x20BA9F0 VA: 0x1820BB5F0
	|-ClassPropertyWriter<object, long>.Write
	|-ClassPropertyWriter<object, object>.Write
	|
	|-RVA: 0x1B0A180 Offset: 0x1B09580 VA: 0x181B0A180
	|-ClassPropertyWriter<float, int>.Write
	|
	|-RVA: 0x1B0A030 Offset: 0x1B09430 VA: 0x181B0A030
	|-ClassPropertyWriter<float, long>.Write
	|-ClassPropertyWriter<float, object>.Write
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object GetData(ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B09D60 Offset: 0x1B09160 VA: 0x181B09D60
	|-ClassPropertyWriter<bool, int>.GetData
	|-ClassPropertyWriter<byte, int>.GetData
	|-ClassPropertyWriter<char, int>.GetData
	|-ClassPropertyWriter<EmptyStruct, int>.GetData
	|-ClassPropertyWriter<short, int>.GetData
	|-ClassPropertyWriter<int, int>.GetData
	|-ClassPropertyWriter<sbyte, int>.GetData
	|-ClassPropertyWriter<ushort, int>.GetData
	|-ClassPropertyWriter<uint, int>.GetData
	|
	|-RVA: 0x1B09CC0 Offset: 0x1B090C0 VA: 0x181B09CC0
	|-ClassPropertyWriter<bool, long>.GetData
	|-ClassPropertyWriter<byte, long>.GetData
	|-ClassPropertyWriter<char, long>.GetData
	|-ClassPropertyWriter<DateTime, long>.GetData
	|-ClassPropertyWriter<EmptyStruct, long>.GetData
	|-ClassPropertyWriter<short, long>.GetData
	|-ClassPropertyWriter<int, long>.GetData
	|-ClassPropertyWriter<long, long>.GetData
	|-ClassPropertyWriter<IntPtr, long>.GetData
	|-ClassPropertyWriter<sbyte, long>.GetData
	|-ClassPropertyWriter<TimeSpan, long>.GetData
	|-ClassPropertyWriter<ushort, long>.GetData
	|-ClassPropertyWriter<uint, long>.GetData
	|-ClassPropertyWriter<ulong, long>.GetData
	|-ClassPropertyWriter<UIntPtr, long>.GetData
	|
	|-RVA: 0x1B09D30 Offset: 0x1B09130 VA: 0x181B09D30
	|-ClassPropertyWriter<bool, object>.GetData
	|-ClassPropertyWriter<byte, object>.GetData
	|-ClassPropertyWriter<char, object>.GetData
	|-ClassPropertyWriter<DateTime, object>.GetData
	|-ClassPropertyWriter<EmptyStruct, object>.GetData
	|-ClassPropertyWriter<short, object>.GetData
	|-ClassPropertyWriter<int, object>.GetData
	|-ClassPropertyWriter<long, object>.GetData
	|-ClassPropertyWriter<IntPtr, object>.GetData
	|-ClassPropertyWriter<sbyte, object>.GetData
	|-ClassPropertyWriter<TimeSpan, object>.GetData
	|-ClassPropertyWriter<ushort, object>.GetData
	|-ClassPropertyWriter<uint, object>.GetData
	|-ClassPropertyWriter<ulong, object>.GetData
	|-ClassPropertyWriter<UIntPtr, object>.GetData
	|
	|-RVA: 0x20BB130 Offset: 0x20BA530 VA: 0x1820BB130
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>.GetData
	|-ClassPropertyWriter<DateTimeOffset, int>.GetData
	|-ClassPropertyWriter<Decimal, int>.GetData
	|-ClassPropertyWriter<Guid, int>.GetData
	|
	|-RVA: 0x20BB1E0 Offset: 0x20BA5E0 VA: 0x1820BB1E0
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>.GetData
	|-ClassPropertyWriter<DateTimeOffset, long>.GetData
	|-ClassPropertyWriter<Decimal, long>.GetData
	|-ClassPropertyWriter<Guid, long>.GetData
	|
	|-RVA: 0x20BB1A0 Offset: 0x20BA5A0 VA: 0x1820BB1A0
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>.GetData
	|-ClassPropertyWriter<DateTimeOffset, object>.GetData
	|-ClassPropertyWriter<Decimal, object>.GetData
	|-ClassPropertyWriter<Guid, object>.GetData
	|
	|-RVA: 0x1B09DD0 Offset: 0x1B091D0 VA: 0x181B09DD0
	|-ClassPropertyWriter<DateTime, int>.GetData
	|-ClassPropertyWriter<long, int>.GetData
	|-ClassPropertyWriter<IntPtr, int>.GetData
	|-ClassPropertyWriter<TimeSpan, int>.GetData
	|-ClassPropertyWriter<ulong, int>.GetData
	|-ClassPropertyWriter<UIntPtr, int>.GetData
	|
	|-RVA: 0x20BB320 Offset: 0x20BA720 VA: 0x1820BB320
	|-ClassPropertyWriter<double, int>.GetData
	|
	|-RVA: 0x1B09EB0 Offset: 0x1B092B0 VA: 0x181B09EB0
	|-ClassPropertyWriter<double, long>.GetData
	|-ClassPropertyWriter<float, long>.GetData
	|
	|-RVA: 0x1B09F20 Offset: 0x1B09320 VA: 0x181B09F20
	|-ClassPropertyWriter<double, object>.GetData
	|-ClassPropertyWriter<float, object>.GetData
	|
	|-RVA: 0x20BB390 Offset: 0x20BA790 VA: 0x1820BB390
	|-ClassPropertyWriter<object, int>.GetData
	|
	|-RVA: 0x20BB2A0 Offset: 0x20BA6A0 VA: 0x1820BB2A0
	|-ClassPropertyWriter<object, long>.GetData
	|
	|-RVA: 0x20BB260 Offset: 0x20BA660 VA: 0x1820BB260
	|-ClassPropertyWriter<object, object>.GetData
	|
	|-RVA: 0x1B09E40 Offset: 0x1B09240 VA: 0x181B09E40
	|-ClassPropertyWriter<float, int>.GetData
	*/

}

internal sealed class NullTypeInfo<DataType> : TraceLoggingTypeInfo<DataType> // TypeDefIndex: 1531
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4D680 Offset: 0x1B4CA80 VA: 0x181B4D680
	|-NullTypeInfo<EmptyStruct>.WriteMetadata
	|-NullTypeInfo<object>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref DataType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	|-NullTypeInfo<EmptyStruct>.WriteData
	|-NullTypeInfo<object>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	|-NullTypeInfo<EmptyStruct>.GetData
	|-NullTypeInfo<object>.GetData
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B10B0 Offset: 0x11B04B0 VA: 0x1811B10B0
	|-NullTypeInfo<EmptyStruct>..ctor
	|-NullTypeInfo<object>..ctor
	*/

}

internal abstract class TraceLoggingTypeInfo<DataType> : TraceLoggingTypeInfo // TypeDefIndex: 1590
{	// Fields
	private static TraceLoggingTypeInfo<DataType> instance; // 0x0

	// Properties
	public static TraceLoggingTypeInfo<DataType> Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B53140 Offset: 0x1B52540 VA: 0x181B53140
	|-TraceLoggingTypeInfo<bool>..ctor
	|
	|-RVA: 0x1B97410 Offset: 0x1B96810 VA: 0x181B97410
	|-TraceLoggingTypeInfo<bool[]>..ctor
	|-TraceLoggingTypeInfo<byte[]>..ctor
	|-TraceLoggingTypeInfo<char[]>..ctor
	|-TraceLoggingTypeInfo<double[]>..ctor
	|-TraceLoggingTypeInfo<Guid[]>..ctor
	|-TraceLoggingTypeInfo<short[]>..ctor
	|-TraceLoggingTypeInfo<int[]>..ctor
	|-TraceLoggingTypeInfo<long[]>..ctor
	|-TraceLoggingTypeInfo<IntPtr[]>..ctor
	|-TraceLoggingTypeInfo<object>..ctor
	|-TraceLoggingTypeInfo<sbyte[]>..ctor
	|-TraceLoggingTypeInfo<float[]>..ctor
	|-TraceLoggingTypeInfo<string>..ctor
	|-TraceLoggingTypeInfo<ushort[]>..ctor
	|-TraceLoggingTypeInfo<uint[]>..ctor
	|-TraceLoggingTypeInfo<ulong[]>..ctor
	|-TraceLoggingTypeInfo<UIntPtr[]>..ctor
	|
	|-RVA: 0x1B96360 Offset: 0x1B95760 VA: 0x181B96360
	|-TraceLoggingTypeInfo<byte>..ctor
	|
	|-RVA: 0x1B961F0 Offset: 0x1B955F0 VA: 0x181B961F0
	|-TraceLoggingTypeInfo<char>..ctor
	|
	|-RVA: 0x1B97210 Offset: 0x1B96610 VA: 0x181B97210
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1B97180 Offset: 0x1B96580 VA: 0x181B97180
	|-TraceLoggingTypeInfo<DateTime>..ctor
	|
	|-RVA: 0x1B96D30 Offset: 0x1B96130 VA: 0x181B96D30
	|-TraceLoggingTypeInfo<DateTimeOffset>..ctor
	|
	|-RVA: 0x1B96DC0 Offset: 0x1B961C0 VA: 0x181B96DC0
	|-TraceLoggingTypeInfo<Decimal>..ctor
	|
	|-RVA: 0x1B96080 Offset: 0x1B95480 VA: 0x181B96080
	|-TraceLoggingTypeInfo<EmptyStruct>..ctor
	|
	|-RVA: 0x1B965B0 Offset: 0x1B959B0 VA: 0x181B965B0
	|-TraceLoggingTypeInfo<double>..ctor
	|
	|-RVA: 0x1B97860 Offset: 0x1B96C60 VA: 0x181B97860
	|-TraceLoggingTypeInfo<Guid>..ctor
	|
	|-RVA: 0x1B976F0 Offset: 0x1B96AF0 VA: 0x181B976F0
	|-TraceLoggingTypeInfo<short>..ctor
	|
	|-RVA: 0x1B96800 Offset: 0x1B95C00 VA: 0x181B96800
	|-TraceLoggingTypeInfo<int>..ctor
	|
	|-RVA: 0x1B96B30 Offset: 0x1B95F30 VA: 0x181B96B30
	|-TraceLoggingTypeInfo<long>..ctor
	|
	|-RVA: 0x1B972A0 Offset: 0x1B966A0 VA: 0x181B972A0
	|-TraceLoggingTypeInfo<IntPtr>..ctor
	|
	|-RVA: 0x1B96E50 Offset: 0x1B96250 VA: 0x181B96E50
	|-TraceLoggingTypeInfo<sbyte>..ctor
	|
	|-RVA: 0x1B97580 Offset: 0x1B96980 VA: 0x181B97580
	|-TraceLoggingTypeInfo<float>..ctor
	|
	|-RVA: 0x1B95C30 Offset: 0x1B95030 VA: 0x181B95C30
	|-TraceLoggingTypeInfo<TimeSpan>..ctor
	|
	|-RVA: 0x1B979D0 Offset: 0x1B96DD0 VA: 0x181B979D0
	|-TraceLoggingTypeInfo<ushort>..ctor
	|
	|-RVA: 0x1B96BC0 Offset: 0x1B95FC0 VA: 0x181B96BC0
	|-TraceLoggingTypeInfo<uint>..ctor
	|
	|-RVA: 0x1B95E30 Offset: 0x1B95230 VA: 0x181B95E30
	|-TraceLoggingTypeInfo<ulong>..ctor
	|
	|-RVA: 0x1B95CC0 Offset: 0x1B950C0 VA: 0x181B95CC0
	|-TraceLoggingTypeInfo<UIntPtr>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B53060 Offset: 0x1B52460 VA: 0x181B53060
	|-TraceLoggingTypeInfo<bool>..ctor
	|
	|-RVA: 0x1B97780 Offset: 0x1B96B80 VA: 0x181B97780
	|-TraceLoggingTypeInfo<byte>..ctor
	|
	|-RVA: 0x1B96890 Offset: 0x1B95C90 VA: 0x181B96890
	|-TraceLoggingTypeInfo<char>..ctor
	|
	|-RVA: 0x1B96640 Offset: 0x1B95A40 VA: 0x181B96640
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1B96A50 Offset: 0x1B95E50 VA: 0x181B96A50
	|-TraceLoggingTypeInfo<DateTime>..ctor
	|
	|-RVA: 0x1B97330 Offset: 0x1B96730 VA: 0x181B97330
	|-TraceLoggingTypeInfo<DateTimeOffset>..ctor
	|
	|-RVA: 0x1B964D0 Offset: 0x1B958D0 VA: 0x181B964D0
	|-TraceLoggingTypeInfo<Decimal>..ctor
	|
	|-RVA: 0x1B96720 Offset: 0x1B95B20 VA: 0x181B96720
	|-TraceLoggingTypeInfo<EmptyStruct>..ctor
	|
	|-RVA: 0x1B96970 Offset: 0x1B95D70 VA: 0x181B96970
	|-TraceLoggingTypeInfo<double>..ctor
	|
	|-RVA: 0x1B95FA0 Offset: 0x1B953A0 VA: 0x181B95FA0
	|-TraceLoggingTypeInfo<Guid>..ctor
	|
	|-RVA: 0x1B978F0 Offset: 0x1B96CF0 VA: 0x181B978F0
	|-TraceLoggingTypeInfo<short>..ctor
	|
	|-RVA: 0x1B96280 Offset: 0x1B95680 VA: 0x181B96280
	|-TraceLoggingTypeInfo<int>..ctor
	|
	|-RVA: 0x1B95EC0 Offset: 0x1B952C0 VA: 0x181B95EC0
	|-TraceLoggingTypeInfo<long>..ctor
	|
	|-RVA: 0x1B96EE0 Offset: 0x1B962E0 VA: 0x181B96EE0
	|-TraceLoggingTypeInfo<IntPtr>..ctor
	|
	|-RVA: 0x1B96110 Offset: 0x1B95510 VA: 0x181B96110
	|-TraceLoggingTypeInfo<object>..ctor
	|
	|-RVA: 0x1B96FC0 Offset: 0x1B963C0 VA: 0x181B96FC0
	|-TraceLoggingTypeInfo<sbyte>..ctor
	|
	|-RVA: 0x1B96C50 Offset: 0x1B96050 VA: 0x181B96C50
	|-TraceLoggingTypeInfo<float>..ctor
	|
	|-RVA: 0x1B970A0 Offset: 0x1B964A0 VA: 0x181B970A0
	|-TraceLoggingTypeInfo<TimeSpan>..ctor
	|
	|-RVA: 0x1B95D50 Offset: 0x1B95150 VA: 0x181B95D50
	|-TraceLoggingTypeInfo<ushort>..ctor
	|
	|-RVA: 0x1B97610 Offset: 0x1B96A10 VA: 0x181B97610
	|-TraceLoggingTypeInfo<uint>..ctor
	|
	|-RVA: 0x1B963F0 Offset: 0x1B957F0 VA: 0x181B963F0
	|-TraceLoggingTypeInfo<ulong>..ctor
	|
	|-RVA: 0x1B974A0 Offset: 0x1B968A0 VA: 0x181B974A0
	|-TraceLoggingTypeInfo<UIntPtr>..ctor
	*/

	// RVA: -1 Offset: -1
	public static TraceLoggingTypeInfo<DataType> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B531D0 Offset: 0x1B525D0 VA: 0x181B531D0
	|-TraceLoggingTypeInfo<bool>.get_Instance
	|-TraceLoggingTypeInfo<byte>.get_Instance
	|-TraceLoggingTypeInfo<char>.get_Instance
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.get_Instance
	|-TraceLoggingTypeInfo<DateTime>.get_Instance
	|-TraceLoggingTypeInfo<DateTimeOffset>.get_Instance
	|-TraceLoggingTypeInfo<Decimal>.get_Instance
	|-TraceLoggingTypeInfo<EmptyStruct>.get_Instance
	|-TraceLoggingTypeInfo<double>.get_Instance
	|-TraceLoggingTypeInfo<Guid>.get_Instance
	|-TraceLoggingTypeInfo<short>.get_Instance
	|-TraceLoggingTypeInfo<int>.get_Instance
	|-TraceLoggingTypeInfo<long>.get_Instance
	|-TraceLoggingTypeInfo<IntPtr>.get_Instance
	|-TraceLoggingTypeInfo<object>.get_Instance
	|-TraceLoggingTypeInfo<sbyte>.get_Instance
	|-TraceLoggingTypeInfo<float>.get_Instance
	|-TraceLoggingTypeInfo<string>.get_Instance
	|-TraceLoggingTypeInfo<TimeSpan>.get_Instance
	|-TraceLoggingTypeInfo<ushort>.get_Instance
	|-TraceLoggingTypeInfo<uint>.get_Instance
	|-TraceLoggingTypeInfo<ulong>.get_Instance
	|-TraceLoggingTypeInfo<UIntPtr>.get_Instance
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void WriteData(TraceLoggingDataCollector collector, ref DataType value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TraceLoggingTypeInfo<object>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void WriteObjectData(TraceLoggingDataCollector collector, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B52FB0 Offset: 0x1B523B0 VA: 0x181B52FB0
	|-TraceLoggingTypeInfo<bool>.WriteObjectData
	|-TraceLoggingTypeInfo<byte>.WriteObjectData
	|-TraceLoggingTypeInfo<EmptyStruct>.WriteObjectData
	|-TraceLoggingTypeInfo<sbyte>.WriteObjectData
	|
	|-RVA: 0x1B95A20 Offset: 0x1B94E20 VA: 0x181B95A20
	|-TraceLoggingTypeInfo<bool[]>.WriteObjectData
	|-TraceLoggingTypeInfo<byte[]>.WriteObjectData
	|-TraceLoggingTypeInfo<char[]>.WriteObjectData
	|-TraceLoggingTypeInfo<double[]>.WriteObjectData
	|-TraceLoggingTypeInfo<Guid[]>.WriteObjectData
	|-TraceLoggingTypeInfo<short[]>.WriteObjectData
	|-TraceLoggingTypeInfo<int[]>.WriteObjectData
	|-TraceLoggingTypeInfo<long[]>.WriteObjectData
	|-TraceLoggingTypeInfo<IntPtr[]>.WriteObjectData
	|-TraceLoggingTypeInfo<object>.WriteObjectData
	|-TraceLoggingTypeInfo<sbyte[]>.WriteObjectData
	|-TraceLoggingTypeInfo<float[]>.WriteObjectData
	|-TraceLoggingTypeInfo<string>.WriteObjectData
	|-TraceLoggingTypeInfo<ushort[]>.WriteObjectData
	|-TraceLoggingTypeInfo<uint[]>.WriteObjectData
	|-TraceLoggingTypeInfo<ulong[]>.WriteObjectData
	|-TraceLoggingTypeInfo<UIntPtr[]>.WriteObjectData
	|
	|-RVA: 0x1B958C0 Offset: 0x1B94CC0 VA: 0x181B958C0
	|-TraceLoggingTypeInfo<char>.WriteObjectData
	|-TraceLoggingTypeInfo<short>.WriteObjectData
	|-TraceLoggingTypeInfo<ushort>.WriteObjectData
	|
	|-RVA: 0x1B95810 Offset: 0x1B94C10 VA: 0x181B95810
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.WriteObjectData
	|-TraceLoggingTypeInfo<DateTimeOffset>.WriteObjectData
	|-TraceLoggingTypeInfo<Decimal>.WriteObjectData
	|-TraceLoggingTypeInfo<Guid>.WriteObjectData
	|
	|-RVA: 0x1B95760 Offset: 0x1B94B60 VA: 0x181B95760
	|-TraceLoggingTypeInfo<DateTime>.WriteObjectData
	|-TraceLoggingTypeInfo<long>.WriteObjectData
	|-TraceLoggingTypeInfo<IntPtr>.WriteObjectData
	|-TraceLoggingTypeInfo<TimeSpan>.WriteObjectData
	|-TraceLoggingTypeInfo<ulong>.WriteObjectData
	|-TraceLoggingTypeInfo<UIntPtr>.WriteObjectData
	|
	|-RVA: 0x1B95B80 Offset: 0x1B94F80 VA: 0x181B95B80
	|-TraceLoggingTypeInfo<double>.WriteObjectData
	|
	|-RVA: 0x1B95AD0 Offset: 0x1B94ED0 VA: 0x181B95AD0
	|-TraceLoggingTypeInfo<int>.WriteObjectData
	|-TraceLoggingTypeInfo<uint>.WriteObjectData
	|
	|-RVA: 0x1B95970 Offset: 0x1B94D70 VA: 0x181B95970
	|-TraceLoggingTypeInfo<float>.WriteObjectData
	*/

	// RVA: -1 Offset: -1
	internal static TraceLoggingTypeInfo<DataType> GetInstance(List<Type> recursionCheck) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B52D50 Offset: 0x1B52150 VA: 0x181B52D50
	|-TraceLoggingTypeInfo<bool>.GetInstance
	|
	|-RVA: 0x1B92C40 Offset: 0x1B92040 VA: 0x181B92C40
	|-TraceLoggingTypeInfo<byte>.GetInstance
	|
	|-RVA: 0x1B943E0 Offset: 0x1B937E0 VA: 0x181B943E0
	|-TraceLoggingTypeInfo<char>.GetInstance
	|
	|-RVA: 0x1B93ED0 Offset: 0x1B932D0 VA: 0x181B93ED0
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.GetInstance
	|
	|-RVA: 0x1B94740 Offset: 0x1B93B40 VA: 0x181B94740
	|-TraceLoggingTypeInfo<DateTime>.GetInstance
	|
	|-RVA: 0x1B934B0 Offset: 0x1B928B0 VA: 0x181B934B0
	|-TraceLoggingTypeInfo<DateTimeOffset>.GetInstance
	|
	|-RVA: 0x1B93B70 Offset: 0x1B92F70 VA: 0x181B93B70
	|-TraceLoggingTypeInfo<Decimal>.GetInstance
	|
	|-RVA: 0x1B94590 Offset: 0x1B93990 VA: 0x181B94590
	|-TraceLoggingTypeInfo<EmptyStruct>.GetInstance
	|
	|-RVA: 0x1B93300 Offset: 0x1B92700 VA: 0x181B93300
	|-TraceLoggingTypeInfo<double>.GetInstance
	|
	|-RVA: 0x1B94230 Offset: 0x1B93630 VA: 0x181B94230
	|-TraceLoggingTypeInfo<Guid>.GetInstance
	|
	|-RVA: 0x1B93660 Offset: 0x1B92A60 VA: 0x181B93660
	|-TraceLoggingTypeInfo<short>.GetInstance
	|
	|-RVA: 0x1B92DF0 Offset: 0x1B921F0 VA: 0x181B92DF0
	|-TraceLoggingTypeInfo<int>.GetInstance
	|
	|-RVA: 0x1B94080 Offset: 0x1B93480 VA: 0x181B94080
	|-TraceLoggingTypeInfo<long>.GetInstance
	|
	|-RVA: 0x1B93D20 Offset: 0x1B93120 VA: 0x181B93D20
	|-TraceLoggingTypeInfo<IntPtr>.GetInstance
	|
	|-RVA: 0x1B92FA0 Offset: 0x1B923A0 VA: 0x181B92FA0
	|-TraceLoggingTypeInfo<object>.GetInstance
	|
	|-RVA: 0x1B92580 Offset: 0x1B91980 VA: 0x181B92580
	|-TraceLoggingTypeInfo<sbyte>.GetInstance
	|
	|-RVA: 0x1B939C0 Offset: 0x1B92DC0 VA: 0x181B939C0
	|-TraceLoggingTypeInfo<float>.GetInstance
	|
	|-RVA: 0x1B92A90 Offset: 0x1B91E90 VA: 0x181B92A90
	|-TraceLoggingTypeInfo<TimeSpan>.GetInstance
	|
	|-RVA: 0x1B928E0 Offset: 0x1B91CE0 VA: 0x181B928E0
	|-TraceLoggingTypeInfo<ushort>.GetInstance
	|
	|-RVA: 0x1B92730 Offset: 0x1B91B30 VA: 0x181B92730
	|-TraceLoggingTypeInfo<uint>.GetInstance
	|
	|-RVA: 0x1B93150 Offset: 0x1B92550 VA: 0x181B93150
	|-TraceLoggingTypeInfo<ulong>.GetInstance
	|
	|-RVA: 0x1B93810 Offset: 0x1B92C10 VA: 0x181B93810
	|-TraceLoggingTypeInfo<UIntPtr>.GetInstance
	*/

	// RVA: -1 Offset: -1
	private static TraceLoggingTypeInfo<DataType> InitInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B52F00 Offset: 0x1B52300 VA: 0x181B52F00
	|-TraceLoggingTypeInfo<bool>.InitInstance
	|
	|-RVA: 0x1B94DC0 Offset: 0x1B941C0 VA: 0x181B94DC0
	|-TraceLoggingTypeInfo<byte>.InitInstance
	|
	|-RVA: 0x1B95550 Offset: 0x1B94950 VA: 0x181B95550
	|-TraceLoggingTypeInfo<char>.InitInstance
	|
	|-RVA: 0x1B94BB0 Offset: 0x1B93FB0 VA: 0x181B94BB0
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.InitInstance
	|
	|-RVA: 0x1B95290 Offset: 0x1B94690 VA: 0x181B95290
	|-TraceLoggingTypeInfo<DateTime>.InitInstance
	|
	|-RVA: 0x1B949A0 Offset: 0x1B93DA0 VA: 0x181B949A0
	|-TraceLoggingTypeInfo<DateTimeOffset>.InitInstance
	|
	|-RVA: 0x1B94FD0 Offset: 0x1B943D0 VA: 0x181B94FD0
	|-TraceLoggingTypeInfo<Decimal>.InitInstance
	|
	|-RVA: 0x1B94A50 Offset: 0x1B93E50 VA: 0x181B94A50
	|-TraceLoggingTypeInfo<EmptyStruct>.InitInstance
	|
	|-RVA: 0x1B951E0 Offset: 0x1B945E0 VA: 0x181B951E0
	|-TraceLoggingTypeInfo<double>.InitInstance
	|
	|-RVA: 0x1B948F0 Offset: 0x1B93CF0 VA: 0x181B948F0
	|-TraceLoggingTypeInfo<Guid>.InitInstance
	|
	|-RVA: 0x1B956B0 Offset: 0x1B94AB0 VA: 0x181B956B0
	|-TraceLoggingTypeInfo<short>.InitInstance
	|
	|-RVA: 0x1B95130 Offset: 0x1B94530 VA: 0x181B95130
	|-TraceLoggingTypeInfo<int>.InitInstance
	|
	|-RVA: 0x1B94B00 Offset: 0x1B93F00 VA: 0x181B94B00
	|-TraceLoggingTypeInfo<long>.InitInstance
	|
	|-RVA: 0x1B94F20 Offset: 0x1B94320 VA: 0x181B94F20
	|-TraceLoggingTypeInfo<IntPtr>.InitInstance
	|
	|-RVA: 0x1B953F0 Offset: 0x1B947F0 VA: 0x181B953F0
	|-TraceLoggingTypeInfo<object>.InitInstance
	|
	|-RVA: 0x1B95080 Offset: 0x1B94480 VA: 0x181B95080
	|-TraceLoggingTypeInfo<sbyte>.InitInstance
	|
	|-RVA: 0x1B95600 Offset: 0x1B94A00 VA: 0x181B95600
	|-TraceLoggingTypeInfo<float>.InitInstance
	|
	|-RVA: 0x1B94E70 Offset: 0x1B94270 VA: 0x181B94E70
	|-TraceLoggingTypeInfo<TimeSpan>.InitInstance
	|
	|-RVA: 0x1B95340 Offset: 0x1B94740 VA: 0x181B95340
	|-TraceLoggingTypeInfo<ushort>.InitInstance
	|
	|-RVA: 0x1B94C60 Offset: 0x1B94060 VA: 0x181B94C60
	|-TraceLoggingTypeInfo<uint>.InitInstance
	|
	|-RVA: 0x1B954A0 Offset: 0x1B948A0 VA: 0x181B954A0
	|-TraceLoggingTypeInfo<ulong>.InitInstance
	|
	|-RVA: 0x1B94D10 Offset: 0x1B94110 VA: 0x181B94D10
	|-TraceLoggingTypeInfo<UIntPtr>.InitInstance
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1635
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 0392525BCB01691D1F319D89F2C12BF93A478467 /*Metadata offset 0x520F94*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 0588059ACBD52F7EA2835882F977A9CF72EB9775 /*Metadata offset 0x521094*/; // 0x100
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=84 0A1ADB22C1D3E1F4B2448EE3F27DF9DE63329C4C /*Metadata offset 0x5210DC*/; // 0x148
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 121EC59E23F7559B28D338D562528F6299C2DE22 /*Metadata offset 0x521130*/; // 0x19C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C /*Metadata offset 0x521220*/; // 0x28C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D /*Metadata offset 0x521223*/; // 0x28F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 1730F09044E91DB8371B849EFF5E6D17BDE4AED0 /*Metadata offset 0x521226*/; // 0x292
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x52123E*/; // 0x2AA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 1AEF3D8DF416A46288C91C724CBF7B154D9E5BF3 /*Metadata offset 0x521241*/; // 0x2AD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 1E41C4CD0767AEA21C00DEABA2EA9407F1E6CEA5 /*Metadata offset 0x522241*/; // 0x12AD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 1FE6CE411858B3D864679DE2139FB081F08BFACD /*Metadata offset 0x522A41*/; // 0x1AAD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC /*Metadata offset 0x522A51*/; // 0x1ABD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 25420D0055076FA8D3E4DD96BC53AE24DE6E619F /*Metadata offset 0x522A54*/; // 0x1AC0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1208 25CF935D2AE9EDF05DD75BCD47FF84D9255D6F6E /*Metadata offset 0x522A7C*/; // 0x1AE8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=42 29C1A61550F0E3260E1953D4FAD71C256218EF40 /*Metadata offset 0x522F34*/; // 0x1FA0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 2B33BEC8C30DFDC49DAFE20D3BDE19487850D717 /*Metadata offset 0x522F5E*/; // 0x1FCA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 2BA840FF6020B8FF623DBCB7188248CF853FAF4F /*Metadata offset 0x522F6A*/; // 0x1FD6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 2C840AFA48C27B9C05593E468C1232CA1CC74AFD /*Metadata offset 0x522F8E*/; // 0x1FFA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2D1DA5BB407F0C11C3B5116196C0C6374D932B20 /*Metadata offset 0x522FD6*/; // 0x2042
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130 /*Metadata offset 0x522FE6*/; // 0x2052
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 2F71D2DA12F3CD0A6A112F5A5A75B4FDC6FE8547 /*Metadata offset 0x522FF4*/; // 0x2060
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359 /*Metadata offset 0x52303C*/; // 0x20A8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 34476C29F6F81C989CFCA42F7C06E84C66236834 /*Metadata offset 0x52307C*/; // 0x20E8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2382 35EED060772F2748D13B745DAEC8CD7BD3B87604 /*Metadata offset 0x5230C4*/; // 0x2130
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 375F9AE9769A3D1DA789E9ACFE81F3A1BB14F0D3 /*Metadata offset 0x523A12*/; // 0x2A7E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1450 379C06C9E702D31469C29033F0DD63931EB349F5 /*Metadata offset 0x523A38*/; // 0x2AA4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 399BD13E240F33F808CA7940293D6EC4E6FD5A00 /*Metadata offset 0x523FE2*/; // 0x304E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 39C9CE73C7B0619D409EF28344F687C1B5C130FE /*Metadata offset 0x523FEC*/; // 0x3058
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=320 3C53AFB51FEC23491684C7BEDBC6D4E0F409F851 /*Metadata offset 0x524034*/; // 0x30A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68 /*Metadata offset 0x524174*/; // 0x31E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 3E4BBF9D0CDD2E34F78AA7A9A3979DCE1F7B02BD /*Metadata offset 0x524177*/; // 0x31E3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3E823444D2DFECF0F90B436B88F02A533CB376F1 /*Metadata offset 0x5241B7*/; // 0x3223
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 3FE6C283BCF384FD2C8789880DFF59664E2AB4A1 /*Metadata offset 0x5241C3*/; // 0x322F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1665 40981BAA39513E58B28DCF0103CC04DE2A0A0444 /*Metadata offset 0x52420B*/; // 0x3277
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 40E7C49413D261F3F38AD3A870C0AC69C8BDA048 /*Metadata offset 0x52488C*/; // 0x38F8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 421EC7E82F2967DF6CA8C3605514DC6F29EE5845 /*Metadata offset 0x5248B4*/; // 0x3920
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 433175D38B13FFE177FDD661A309F1B528B3F6E2 /*Metadata offset 0x5248FC*/; // 0x3968
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 46232052BC757E030490D851F265FB47FA100902 /*Metadata offset 0x5249FC*/; // 0x3A68
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 4858DB4AA76D3933F1CA9E6712D4FDB16903F628 /*Metadata offset 0x524A74*/; // 0x3AE0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195 /*Metadata offset 0x524ABC*/; // 0x3B28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 4F7A8890F332B22B8DE0BD29D36FA7364748D76A /*Metadata offset 0x524AEC*/; // 0x3B58
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 536422B321459B242ADED7240B7447E904E083E3 /*Metadata offset 0x524B14*/; // 0x3B80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1080 5382CEF491F422BFE0D6FC46EFAFF9EF9D4C89F3 /*Metadata offset 0x524B5C*/; // 0x3BC8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949 /*Metadata offset 0x524F94*/; // 0x4000
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 57218C316B6921E2CD61027A2387EDC31A2D9471 /*Metadata offset 0x524F9E*/; // 0x400A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 57F320D62696EC99727E0FE2045A05F1289CC0C6 /*Metadata offset 0x524FA1*/; // 0x400D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 594A33A00BC4F785DFD43E3C6C44FBA1242CCAF3 /*Metadata offset 0x524FC9*/; // 0x4035
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 5BBDF8058D4235C33F2E8DCF76004031B6187A2F /*Metadata offset 0x52509D*/; // 0x4109
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 5BCD21C341BE6DDF8FFFAE1A23ABA24DCBB612BF /*Metadata offset 0x5250C1*/; // 0x412D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 5BFE2819B4778217C56416C7585FF0E56EBACD89 /*Metadata offset 0x5251E1*/; // 0x424D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 609C0E8D8DA86A09D6013D301C86BA8782C16B8C /*Metadata offset 0x525229*/; // 0x4295
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 62BAB0F245E66C3EB982CF5A7015F0A7C3382283 /*Metadata offset 0x5252A9*/; // 0x4315
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 646036A65DECCD6835C914A46E6E44B729433B60 /*Metadata offset 0x5252D9*/; // 0x4345
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 65E32B4E150FD8D24B93B0D42A17F1DAD146162B /*Metadata offset 0x525AD9*/; // 0x4B45
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 6770974FEF1E98B9C1864370E2B5B786EB0EA39E /*Metadata offset 0x525B01*/; // 0x4B6D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 67EEAD805D708D9AA4E14BF747E44CED801744F3 /*Metadata offset 0x525B35*/; // 0x4BA1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 6C71197D228427B2864C69B357FEF73D8C9D59DF /*Metadata offset 0x525B7D*/; // 0x4BE9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6CEE45445AFD150B047A5866FFA76AA651CDB7B7 /*Metadata offset 0x525BF5*/; // 0x4C61
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x525C05*/; // 0x4C71
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 6D797C11E1D4FB68B6570CF2A92B792433527065 /*Metadata offset 0x525C0E*/; // 0x4C7A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9 /*Metadata offset 0x52640E*/; // 0x547A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 6FC754859E4EC74E447048364B216D825C6F8FE7 /*Metadata offset 0x52704A*/; // 0x60B6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 704939CD172085D1295FCE3F1D92431D685D7AA2 /*Metadata offset 0x527096*/; // 0x6102
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 7088AAE49F0627B72729078DE6E3182DDCF8ED99 /*Metadata offset 0x5270BE*/; // 0x612A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 7341C933A70EAE383CC50C4B945ADB8E08F06737 /*Metadata offset 0x5270D6*/; // 0x6142
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57 /*Metadata offset 0x52711E*/; // 0x618A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 7F42F2EDC974BE29B2746957416ED1AEFA605F47 /*Metadata offset 0x527121*/; // 0x618D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 7FE820C9CF0F0B90445A71F1D262D22E4F0C4C68 /*Metadata offset 0x528121*/; // 0x718D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=21252 811A927B7DADD378BE60BBDE794B9277AA9B50EC /*Metadata offset 0x528149*/; // 0x71B5
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 81917F1E21F3C22B9F916994547A614FB03E968E /*Metadata offset 0x52D44D*/; // 0xC4B9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 823566DA642D6EA356E15585921F2A4CA23D6760 /*Metadata offset 0x52D471*/; // 0xC4DD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 82C2A59850B2E85BCE1A45A479537A384DF6098D /*Metadata offset 0x52D499*/; // 0xC505
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 82C383F8E6E4D3D87AEBB986A5D0077E8AD157C4 /*Metadata offset 0x52D4A5*/; // 0xC511
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A /*Metadata offset 0x52D4D1*/; // 0xC53D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 871B9CF85DB352BAADF12BAE8F19857683E385AC /*Metadata offset 0x52D4D4*/; // 0xC540
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 89A040451C8CC5C8FB268BE44BDD74964C104155 /*Metadata offset 0x52D4FC*/; // 0xC568
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 8CAA092E783257106251246FF5C97F88D28517A6 /*Metadata offset 0x52D50C*/; // 0xC578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2100 8D231DD55FE1AD7631BBD0905A17D5EB616C2154 /*Metadata offset 0x52D534*/; // 0xC5A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 8E10AC2F34545DFBBF3FCBC06055D797A8C99991 /*Metadata offset 0x52DD68*/; // 0xCDD4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3 /*Metadata offset 0x52DD90*/; // 0xCDFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=640 90A0542282A011472F94E97CEAE59F8B3B1A3291 /*Metadata offset 0x52DE90*/; // 0xCEFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 93A63E90605400F34B49F0EB3361D23C89164BDA /*Metadata offset 0x52E110*/; // 0xD17C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 94841DD2F330CCB1089BF413E4FA9B04505152E2 /*Metadata offset 0x52E11C*/; // 0xD188
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 95264589E48F94B7857CFF398FB72A537E13EEE2 /*Metadata offset 0x52E164*/; // 0xD1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 95C48758CAE1715783472FB073AB158AB8A0AB2A /*Metadata offset 0x52E170*/; // 0xD1DC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 973417296623D8DC6961B09664E54039E44CA5D8 /*Metadata offset 0x52E1B8*/; // 0xD224
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003 /*Metadata offset 0x52E200*/; // 0xD26C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 99E2E88877D14C7DDC4E957A0ED7079CA0E9EB24 /*Metadata offset 0x52E203*/; // 0xD26F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5 /*Metadata offset 0x52F203*/; // 0xE26F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88 /*Metadata offset 0x52F243*/; // 0xE2AF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 A0074C15377C0C870B055927403EA9FA7A349D12 /*Metadata offset 0x52F246*/; // 0xE2B2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=130 A1319B706116AB2C6D44483F60A7D0ACEA543396 /*Metadata offset 0x52F26E*/; // 0xE2DA
	internal static readonly long A13AA52274D951A18029131A8DDECF76B569A15D = -44474084896931794; // 0xE360
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B /*Metadata offset 0x52F2F8*/; // 0xE368
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 A5444763673307F6828C748D4B9708CFC02B0959 /*Metadata offset 0x52F2FB*/; // 0xE36B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 A6732F8E7FC23766AB329B492D6BF82E3B33233F /*Metadata offset 0x52F3CF*/; // 0xE43F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 A705A106D95282BD15E13EEA6B0AF583FF786D83 /*Metadata offset 0x52F417*/; // 0xE487
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1018 A8A491E4CED49AE0027560476C10D933CE70C8DF /*Metadata offset 0x52F4C5*/; // 0xE535
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 AC791C4F39504D1184B73478943D0636258DA7B1 /*Metadata offset 0x52F8BF*/; // 0xE92F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 AFCD4E1211233E99373A3367B23105A3D624B1F2 /*Metadata offset 0x52F907*/; // 0xE977
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 B472ED77CB3B2A66D49D179F1EE2081B70A6AB61 /*Metadata offset 0x52F93B*/; // 0xE9AB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B4FBD02AAB5B16E0F4BD858DA5D9E348F3CE501D /*Metadata offset 0x52F963*/; // 0xE9D3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 B53A2C6DF21FC88B17AEFC40EB895B8D63210CDF /*Metadata offset 0x52F973*/; // 0xE9E3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 B6002BBF29B2704922EC3BBF0F9EE40ABF185D6B /*Metadata offset 0x52FA73*/; // 0xEAE3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=998 B881DA88BE0B68D8A6B6B6893822586B8B2CFC45 /*Metadata offset 0x530A73*/; // 0xFAE3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=162 B8864ACB9DD69E3D42151513C840AAE270BF21C8 /*Metadata offset 0x530E59*/; // 0xFEC9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=360 B8F87834C3597B2EEF22BA6D3A392CC925636401 /*Metadata offset 0x530EFB*/; // 0xFF6B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 B9B670F134A59FB1107AF01A9FE8F8E3980B3093 /*Metadata offset 0x531063*/; // 0x100D3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8 /*Metadata offset 0x5310AB*/; // 0x1011B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 BEBC9ECC660A13EFC359BA3383411F698CFF25DB /*Metadata offset 0x5310BF*/; // 0x1012F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 BEE1CFE5DFAA408E14CE4AF4DCD824FA2E42DCB7 /*Metadata offset 0x531107*/; // 0x10177
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A /*Metadata offset 0x53112F*/; // 0x1019F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 BF5EB60806ECB74EE484105DD9D6F463BF994867 /*Metadata offset 0x531132*/; // 0x101A2
	internal static readonly long C1A1100642BA9685B30A84D97348484E14AA1865 = 23362753784184900; // 0x101A8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C6F364A0AD934EFED8909446C215752E565D77C1 /*Metadata offset 0x531140*/; // 0x101B0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 CE5835130F5277F63D716FC9115526B0AC68FFAD /*Metadata offset 0x531150*/; // 0x101C0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 CE93C35B755802BC4B3D180716B048FC61701EF7 /*Metadata offset 0x5311FE*/; // 0x1026E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814 /*Metadata offset 0x531204*/; // 0x10274
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D002CBBE1FF33721AF7C4D1D3ECAD1B7DB5258B7 /*Metadata offset 0x531244*/; // 0x102B4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D117188BE8D4609C0D531C51B0BB911A4219DEBE /*Metadata offset 0x531344*/; // 0x103B4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE /*Metadata offset 0x531364*/; // 0x103D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F /*Metadata offset 0x531384*/; // 0x103F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=82 D76478B994B312CD022DCA207AA2254880D2FCC9 /*Metadata offset 0x531484*/; // 0x104F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 D78D08081C7A5AD6FBA7A8DC86BCD6D7A577C636 /*Metadata offset 0x5314D6*/; // 0x10546
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 DA19DB47B583EFCF7825D2E39D661D2354F28219 /*Metadata offset 0x531502*/; // 0x10572
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DC2B830D8CD59AD6A4E4332D21CA0DCA2821AD82 /*Metadata offset 0x53154E*/; // 0x105BE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x531586*/; // 0x105F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 E1827270A5FE1C85F5352A66FD87BA747213D006 /*Metadata offset 0x5315BA*/; // 0x1062A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 E45BAB43F7D5D038672B3E3431F92E34A7AF2571 /*Metadata offset 0x5315DE*/; // 0x1064E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17 /*Metadata offset 0x531606*/; // 0x10676
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x531646*/; // 0x106B6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 EA9506959484C55CFE0C139C624DF6060E285866 /*Metadata offset 0x53167A*/; // 0x106EA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=262 EB5E9A80A40096AB74D2E226650C7258D7BC5E9D /*Metadata offset 0x531686*/; // 0x106F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 EBF68F411848D603D059DFDEA2321C5A5EA78044 /*Metadata offset 0x53178C*/; // 0x107FC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11 /*Metadata offset 0x5317CC*/; // 0x1083C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3 /*Metadata offset 0x5317D6*/; // 0x10846
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 EC89C317EA2BF49A70EFF5E89C691E34733D7C37 /*Metadata offset 0x5317D9*/; // 0x10849
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 F06E829E62F3AFBC045D064E10A4F5DF7C969612 /*Metadata offset 0x531821*/; // 0x10891
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=11614 F073AA332018FDA0D572E99448FFF1D6422BD520 /*Metadata offset 0x531849*/; // 0x108B9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 F34B0E10653402E8F788F8BC3F7CD7090928A429 /*Metadata offset 0x5345A7*/; // 0x13617
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 F37E34BEADB04F34FCC31078A59F49856CA83D5B /*Metadata offset 0x53461F*/; // 0x1368F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=94 F512A9ABF88066AAEB92684F95CC05D8101B462B /*Metadata offset 0x534667*/; // 0x136D7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 F8FAABB821300AA500C2CEC6091B3782A7FB44A4 /*Metadata offset 0x5346C5*/; // 0x13735
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2350 FCBD2781A933F0828ED4AAF88FD8B08D76DDD49B /*Metadata offset 0x5346D1*/; // 0x13741

	// Methods

	// RVA: 0xAA6880 Offset: 0xAA5C80 VA: 0x180AA6880
	internal static uint ComputeStringHash(string s) { }

}

internal class __Il2CppComObject // TypeDefIndex: 1690
{	// Methods

	// RVA: 0x21477B0 Offset: 0x2146BB0 VA: 0x1821477B0 Slot: 1
	protected override void Finalize() { }

}

internal sealed class __Il2CppComDelegate : __Il2CppComObject // TypeDefIndex: 1691
{	// Methods

	// RVA: 0x21477B0 Offset: 0x2146BB0 VA: 0x1821477B0 Slot: 1
	protected override void Finalize() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1772
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C /*Metadata offset 0x5352D7*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D /*Metadata offset 0x5352DA*/; // 0x3
	internal static readonly long 16968835DEF6DD3BB86EABA9DEC53BF41851CD6D = -1295888024253181014; // 0x8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x5352E5*/; // 0x10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC /*Metadata offset 0x5352E8*/; // 0x13
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130 /*Metadata offset 0x5352EB*/; // 0x16
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359 /*Metadata offset 0x5352F9*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68 /*Metadata offset 0x535339*/; // 0x64
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195 /*Metadata offset 0x53533C*/; // 0x67
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949 /*Metadata offset 0x53536C*/; // 0x97
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x535376*/; // 0xA1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9 /*Metadata offset 0x53537F*/; // 0xAA
	internal static readonly long 6FA00AC9FFFD87F82A38A7F9ECC8134F4A7052AF = 22609615381091406; // 0xCE8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57 /*Metadata offset 0x535FC3*/; // 0xCF0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A /*Metadata offset 0x535FC6*/; // 0xCF3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003 /*Metadata offset 0x535FC9*/; // 0xCF6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5 /*Metadata offset 0x535FCC*/; // 0xCF9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88 /*Metadata offset 0x53600C*/; // 0xD39
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B /*Metadata offset 0x53600F*/; // 0xD3C
	internal static readonly long AEA5F1CC5CFE1660539EDD691FE017F775F63A0D = 2676302836908902219; // 0xD40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8 /*Metadata offset 0x53601A*/; // 0xD48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A /*Metadata offset 0x53602E*/; // 0xD5C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814 /*Metadata offset 0x536031*/; // 0xD5F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE /*Metadata offset 0x536071*/; // 0xD9F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F /*Metadata offset 0x536091*/; // 0xDBF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17 /*Metadata offset 0x536191*/; // 0xEBF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11 /*Metadata offset 0x5361D1*/; // 0xEFF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3 /*Metadata offset 0x5361DB*/; // 0xF09

	// Methods

	// RVA: 0xAA6880 Offset: 0xAA5C80 VA: 0x180AA6880
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 2431
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 0701435C4E2C38EFE43C51BD22C114AB8B80124D /*Metadata offset 0x537145*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0EE6555EB2C89F29655BD23FAB0573D8D684331A /*Metadata offset 0x537151*/; // 0xC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 0F6A1E2CEA2FA691D57F3F3FDCF9B82A3FBF6EE1 /*Metadata offset 0x537175*/; // 0x30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 161F91CE1721D8F16622810CBB39887D21C47031 /*Metadata offset 0x5371B9*/; // 0x74
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 2051D7520B96DCC12F2E4DE851CB9F203D623805 /*Metadata offset 0x5371C5*/; // 0x80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 221CE291CD044114B4369175B9B91177F5932876 /*Metadata offset 0x5371E5*/; // 0xA0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D /*Metadata offset 0x537211*/; // 0xCC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 360487BE4278986419B568EFD887F6145383168A /*Metadata offset 0x537237*/; // 0xF2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 42DDBEE388AB59C20A3D7D4D6555E78D74A45AE1 /*Metadata offset 0x53725F*/; // 0x11A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 485F43E332C2F7530815B17C08DAC169A8F697E0 /*Metadata offset 0x537273*/; // 0x12E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 49C5BA13401986EC93E4677F52CBE2248184DFBD /*Metadata offset 0x537293*/; // 0x14E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 51E4CA1C2B009A2876C6E57D8E69E3502BCA3440 /*Metadata offset 0x537303*/; // 0x1BE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 553E235E202D57C9F1156E7D232E02BBDC920165 /*Metadata offset 0x53731B*/; // 0x1D6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 574B9D4E4C39F6E8004181E5765B627B75EB1AD1 /*Metadata offset 0x5376DB*/; // 0x596
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 5BE9DB9EEB9CBB4D22472CA9734B1FA1D36126BD /*Metadata offset 0x537713*/; // 0x5CE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 5D100A87B697F3AE2015A5D3B2A7B5419E1BCA98 /*Metadata offset 0x53771F*/; // 0x5DA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=664 68D0F86889D5D656483EEE829BCEECDFEC91D8EA /*Metadata offset 0x537725*/; // 0x5E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 6A0D50D692745A6663128CD315B71079584F3E59 /*Metadata offset 0x5379BD*/; // 0x878
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 702F6A3276CBE481D247A77C20B5459FB94D07D2 /*Metadata offset 0x537B5D*/; // 0xA18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7A32E1A19C182315E4263A65A72066492550D8CD /*Metadata offset 0x537B75*/; // 0xA30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 8B4E5E81A88D29642679AFCE41DCA380F9000462 /*Metadata offset 0x537B95*/; // 0xA50
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 977375E4E1ED54F588076ACA36CC17E6C2195CB9 /*Metadata offset 0x537BA5*/; // 0xA60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 99F0664C2AC8464B51252D92FC24F3834C6FB90C /*Metadata offset 0x537F65*/; // 0xE20
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D /*Metadata offset 0x537F71*/; // 0xE2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 9E374D7263B2452E25DE3D6E617F6A728D98A439 /*Metadata offset 0x537F8D*/; // 0xE48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 A933F173482FF50754B4942AF8DFC584EF14A45B /*Metadata offset 0x53801D*/; // 0xED8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 AB4EAD1DB94B8220FAAEDAA6A593B2E6DB0A8A9C /*Metadata offset 0x538061*/; // 0xF1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 B368804F0C6DAB083B253A6B106D0783D5C32E90 /*Metadata offset 0x538079*/; // 0xF34
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 B9F0004E3873FDDCABFDA6174EA18F0859B637B4 /*Metadata offset 0x538219*/; // 0x10D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BAD037B714E1CD1052149B51238A3D4351DD10B5 /*Metadata offset 0x538241*/; // 0x10FC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C2D6E36D84DDA5D661B95D7B32D3F47CD7ACBF6C /*Metadata offset 0x538255*/; // 0x1110
	internal static readonly long DB9F879BE80CC2DA24DEF633D23DBB2B1ADBCC81 = 361700859878507267; // 0x1120
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 DCF398750721AA7A27A6BA56E99350329B06E8B1 /*Metadata offset 0x53826D*/; // 0x1128
	internal static readonly long EBC658B067B5C785A3F0BB67D73755F6FEE7F70C = 3659217647501344; // 0x1138
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 ED18A4A1FF7C89B400D7CA156BA8D11BB09E1DE4 /*Metadata offset 0x538285*/; // 0x1140
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 EE3413A2C088FF9432054D6E60A7CB6A498D25F0 /*Metadata offset 0x5382A9*/; // 0x1164
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 F64F25EAE9A3D7A356813C4218000185541D7779 /*Metadata offset 0x5382E9*/; // 0x11A4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1212 FB0C58D8B3094F018764CC6E3094B9576DB08069 /*Metadata offset 0x53830D*/; // 0x11C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 FFE3F15642234E7FAD6951D432F1134D5AD15922 /*Metadata offset 0x5387C9*/; // 0x1684

	// Methods

	// RVA: 0xAA6880 Offset: 0xAA5C80 VA: 0x180AA6880
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3155
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3155
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 0283A6AF88802AB45989B29549915BEA0F6CD515 /*Metadata offset 0x539983*/; // 0x0
	internal static readonly long 03F4297FCC30D0FD5E420E5D26E7FA711167C7EF = 2533317740920864; // 0x10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 1A39764B112685485A5BA7B2880D878B858C1A7A /*Metadata offset 0x539999*/; // 0x18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x5399A2*/; // 0x21
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3BE77BF818331C2D8400FFFFF9FADD3F16AD89AC /*Metadata offset 0x5399A5*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 53437C3B2572EDB9B8640C3195DF3BC2729C5EA1 /*Metadata offset 0x5399B1*/; // 0x30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 59F5BD34B6C013DEACC784F69C67E95150033A84 /*Metadata offset 0x5399BB*/; // 0x3A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 5BC3486B05BA8CF4689C7BDB198B3F477BB4E20C /*Metadata offset 0x5399DB*/; // 0x5A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x5399E1*/; // 0x60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 6F3AD3DC3AF8047587C4C9D696EB68A01FEF796E /*Metadata offset 0x5399EA*/; // 0x69
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 8821BF2BDFF225D177372C9F3E0A8286EE241FF4 /*Metadata offset 0x539A6A*/; // 0xE9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 8E0EF3D67A3EB1863224EE3CACB424BC2F8CFBA3 /*Metadata offset 0x539A70*/; // 0xEF
	internal static readonly long 98A44A6F8606AE6F23FE230286C1D6FBCC407226 = 11540663026319392; // 0x120
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 C02C28AFEBE998F767E4AF43E3BE8F5E9FA11536 /*Metadata offset 0x539AA4*/; // 0x128
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 CCEEADA43268372341F81AE0C9208C6856441C04 /*Metadata offset 0x539AC4*/; // 0x148
	internal static readonly long E5BC1BAFADE1862DD6E0B9FB632BFAA6C3873A78 = 2533330625626144; // 0x1C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 EC5842B3154E1AF94500B57220EB9F684BCCC42A /*Metadata offset 0x539B4C*/; // 0x1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 EEAFE8C6E1AB017237567305EE925C976CDB6458 /*Metadata offset 0x539B6C*/; // 0x1F0

	// Methods

	// RVA: 0xAA6880 Offset: 0xAA5C80 VA: 0x180AA6880
	internal static uint ComputeStringHash(string s) { }

}

internal class EmptyEnumerable<TElement> // TypeDefIndex: 3221
{	// Fields
	public static readonly TElement[] Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5D160 Offset: 0xD5C560 VA: 0x180D5D160
	|-EmptyEnumerable<byte>..cctor
	|-EmptyEnumerable<object>..cctor
	*/

}

internal class IdentityFunction<TElement> // TypeDefIndex: 3222
{	// Properties
	public static Func<TElement, TElement> Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Func<TElement, TElement> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175F040 Offset: 0x175E440 VA: 0x18175F040
	|-IdentityFunction<InventoryItem>.get_Instance
	|-IdentityFunction<object>.get_Instance
	|-IdentityFunction<Resolution>.get_Instance
	*/

}

internal class Set<TElement> // TypeDefIndex: 3230
{	// Fields
	private int[] buckets; // 0x0
	private Set.Slot<TElement>[] slots; // 0x0
	private int count; // 0x0
	private int freeList; // 0x0
	private IEqualityComparer<TElement> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TElement> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1766090 Offset: 0x1765490 VA: 0x181766090
	|-Set<ServerInfo>..ctor
	|
	|-RVA: 0x1765EB0 Offset: 0x17652B0 VA: 0x181765EB0
	|-Set<char>..ctor
	|
	|-RVA: 0x1765DC0 Offset: 0x17651C0 VA: 0x181765DC0
	|-Set<object>..ctor
	|
	|-RVA: 0x1765CD0 Offset: 0x17650D0 VA: 0x181765CD0
	|-Set<float>..ctor
	|
	|-RVA: 0x1765FA0 Offset: 0x17653A0 VA: 0x181765FA0
	|-Set<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1763E70 Offset: 0x1763270 VA: 0x181763E70
	|-Set<ServerInfo>.Add
	|
	|-RVA: 0x1763E40 Offset: 0x1763240 VA: 0x181763E40
	|-Set<char>.Add
	|-Set<object>.Add
	|
	|-RVA: 0x1763F40 Offset: 0x1763340 VA: 0x181763F40
	|-Set<float>.Add
	|
	|-RVA: 0x1763F00 Offset: 0x1763300 VA: 0x181763F00
	|-Set<Vector2>.Add
	*/

	// RVA: -1 Offset: -1
	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1763F70 Offset: 0x1763370 VA: 0x181763F70
	|-Set<ServerInfo>.Find
	|
	|-RVA: 0x1764CA0 Offset: 0x17640A0 VA: 0x181764CA0
	|-Set<char>.Find
	|
	|-RVA: 0x1764690 Offset: 0x1763A90 VA: 0x181764690
	|-Set<object>.Find
	|
	|-RVA: 0x17643A0 Offset: 0x17637A0 VA: 0x1817643A0
	|-Set<float>.Find
	|
	|-RVA: 0x1764980 Offset: 0x1763D80 VA: 0x181764980
	|-Set<Vector2>.Find
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1765760 Offset: 0x1764B60 VA: 0x181765760
	|-Set<ServerInfo>.Resize
	|
	|-RVA: 0x1765930 Offset: 0x1764D30 VA: 0x181765930
	|-Set<char>.Resize
	|
	|-RVA: 0x1765B00 Offset: 0x1764F00 VA: 0x181765B00
	|-Set<object>.Resize
	|
	|-RVA: 0x1765590 Offset: 0x1764990 VA: 0x181765590
	|-Set<float>.Resize
	|
	|-RVA: 0x17653C0 Offset: 0x17647C0 VA: 0x1817653C0
	|-Set<Vector2>.Resize
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1765290 Offset: 0x1764690 VA: 0x181765290
	|-Set<ServerInfo>.InternalGetHashCode
	|
	|-RVA: 0x1764FA0 Offset: 0x17643A0 VA: 0x181764FA0
	|-Set<char>.InternalGetHashCode
	|
	|-RVA: 0x1765070 Offset: 0x1764470 VA: 0x181765070
	|-Set<object>.InternalGetHashCode
	|
	|-RVA: 0x17651C0 Offset: 0x17645C0 VA: 0x1817651C0
	|-Set<float>.InternalGetHashCode
	|
	|-RVA: 0x17650F0 Offset: 0x17644F0 VA: 0x1817650F0
	|-Set<Vector2>.InternalGetHashCode
	*/

}

internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 3232
{	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, TKey> keySelector; // 0x0
	private Func<TSource, TElement> elementSelector; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175BC00 Offset: 0x175B000 VA: 0x18175BC00
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>..ctor
	|
	|-RVA: 0x175BD10 Offset: 0x175B110 VA: 0x18175BD10
	|-GroupedEnumerable<object, InventoryDefId, object>..ctor
	|
	|-RVA: 0x175BE20 Offset: 0x175B220 VA: 0x18175BE20
	|-GroupedEnumerable<object, Int32Enum, object>..ctor
	|
	|-RVA: 0x175C040 Offset: 0x175B440 VA: 0x18175C040
	|-GroupedEnumerable<object, object, object>..ctor
	|
	|-RVA: 0x175BF30 Offset: 0x175B330 VA: 0x18175BF30
	|-GroupedEnumerable<object, uint, object>..ctor
	|
	|-RVA: 0x175C150 Offset: 0x175B550 VA: 0x18175C150
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175BB70 Offset: 0x175AF70 VA: 0x18175BB70
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>.GetEnumerator
	|-GroupedEnumerable<object, InventoryDefId, object>.GetEnumerator
	|-GroupedEnumerable<object, Int32Enum, object>.GetEnumerator
	|-GroupedEnumerable<object, object, object>.GetEnumerator
	|-GroupedEnumerable<object, uint, object>.GetEnumerator
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175BBD0 Offset: 0x175AFD0 VA: 0x18175BBD0
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, InventoryDefId, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, uint, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 3233
{	// Fields
	internal IEnumerable<TElement> source; // 0x0

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0xD1970 Offset: 0xD0D70 VA: 0x1800D1970
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17622A0 Offset: 0x17616A0 VA: 0x1817622A0
	|-OrderedEnumerable<Demos.DemoInfo>.GetEnumerator
	|
	|-RVA: 0x1762210 Offset: 0x1761610 VA: 0x181762210
	|-OrderedEnumerable<ServerInfo>.GetEnumerator
	|
	|-RVA: 0x1762060 Offset: 0x1761460 VA: 0x181762060
	|-OrderedEnumerable<Item>.GetEnumerator
	|
	|-RVA: 0x17620F0 Offset: 0x17614F0 VA: 0x1817620F0
	|-OrderedEnumerable<KeyValuePair<object, int>>.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, long>>.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x1762180 Offset: 0x1761580 VA: 0x181762180
	|-OrderedEnumerable<double>.GetEnumerator
	|-OrderedEnumerable<object>.GetEnumerator
	|-OrderedEnumerable<Resolution>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OrderedEnumerable<object>.GetEnumerableSorter
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13508E0 Offset: 0x134FCE0 VA: 0x1813508E0
	|-OrderedEnumerable<Demos.DemoInfo>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<ServerInfo>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<Item>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, long>>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<double>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<Resolution>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE828C0 Offset: 0xE81CC0 VA: 0x180E828C0
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<DateTime>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<int>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<Int32Enum>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<object>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<Resolution>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<int>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-OrderedEnumerable<Demos.DemoInfo>..ctor
	|-OrderedEnumerable<ServerInfo>..ctor
	|-OrderedEnumerable<Item>..ctor
	|-OrderedEnumerable<KeyValuePair<object, int>>..ctor
	|-OrderedEnumerable<KeyValuePair<object, long>>..ctor
	|-OrderedEnumerable<KeyValuePair<object, object>>..ctor
	|-OrderedEnumerable<double>..ctor
	|-OrderedEnumerable<object>..ctor
	|-OrderedEnumerable<Resolution>..ctor
	*/

}

internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement> // TypeDefIndex: 3235
{	// Fields
	internal OrderedEnumerable<TElement> parent; // 0x0
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1762CC0 Offset: 0x17620C0 VA: 0x181762CC0
	|-OrderedEnumerable<Demos.DemoInfo, DateTime>..ctor
	|
	|-RVA: 0x1763BC0 Offset: 0x1762FC0 VA: 0x181763BC0
	|-OrderedEnumerable<Demos.DemoInfo, object>..ctor
	|
	|-RVA: 0x1763440 Offset: 0x1762840 VA: 0x181763440
	|-OrderedEnumerable<Demos.DemoInfo, TimeSpan>..ctor
	|
	|-RVA: 0x1763580 Offset: 0x1762980 VA: 0x181763580
	|-OrderedEnumerable<ServerInfo, int>..ctor
	|
	|-RVA: 0x1762B80 Offset: 0x1761F80 VA: 0x181762B80
	|-OrderedEnumerable<ServerInfo, object>..ctor
	|
	|-RVA: 0x1762E00 Offset: 0x1762200 VA: 0x181762E00
	|-OrderedEnumerable<ServerInfo, uint>..ctor
	|
	|-RVA: 0x1762900 Offset: 0x1761D00 VA: 0x181762900
	|-OrderedEnumerable<Item, DateTime>..ctor
	|
	|-RVA: 0x1763300 Offset: 0x1762700 VA: 0x181763300
	|-OrderedEnumerable<KeyValuePair<object, int>, int>..ctor
	|
	|-RVA: 0x1763800 Offset: 0x1762C00 VA: 0x181763800
	|-OrderedEnumerable<KeyValuePair<object, long>, long>..ctor
	|
	|-RVA: 0x1762A40 Offset: 0x1761E40 VA: 0x181762A40
	|-OrderedEnumerable<KeyValuePair<object, object>, long>..ctor
	|
	|-RVA: 0x1762540 Offset: 0x1761940 VA: 0x181762540
	|-OrderedEnumerable<double, double>..ctor
	|
	|-RVA: 0x1763940 Offset: 0x1762D40 VA: 0x181763940
	|-OrderedEnumerable<object, bool>..ctor
	|
	|-RVA: 0x17631C0 Offset: 0x17625C0 VA: 0x1817631C0
	|-OrderedEnumerable<object, DateTime>..ctor
	|
	|-RVA: 0x1762400 Offset: 0x1761800 VA: 0x181762400
	|-OrderedEnumerable<object, DateTimeOffset>..ctor
	|
	|-RVA: 0x1762F40 Offset: 0x1762340 VA: 0x181762F40
	|-OrderedEnumerable<object, Guid>..ctor
	|
	|-RVA: 0x17627C0 Offset: 0x1761BC0 VA: 0x1817627C0
	|-OrderedEnumerable<object, int>..ctor
	|
	|-RVA: 0x1763080 Offset: 0x1762480 VA: 0x181763080
	|-OrderedEnumerable<object, Int32Enum>..ctor
	|
	|-RVA: 0x17636C0 Offset: 0x1762AC0 VA: 0x1817636C0
	|-OrderedEnumerable<object, object>..ctor
	|
	|-RVA: 0x1762680 Offset: 0x1761A80 VA: 0x181762680
	|-OrderedEnumerable<object, float>..ctor
	|
	|-RVA: 0x1763A80 Offset: 0x1762E80 VA: 0x181763A80
	|-OrderedEnumerable<object, uint>..ctor
	|
	|-RVA: 0x1763D00 Offset: 0x1763100 VA: 0x181763D00
	|-OrderedEnumerable<Resolution, int>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1762330 Offset: 0x1761730 VA: 0x181762330
	|-OrderedEnumerable<Demos.DemoInfo, DateTime>.GetEnumerableSorter
	|-OrderedEnumerable<Demos.DemoInfo, object>.GetEnumerableSorter
	|-OrderedEnumerable<Demos.DemoInfo, TimeSpan>.GetEnumerableSorter
	|-OrderedEnumerable<ServerInfo, int>.GetEnumerableSorter
	|-OrderedEnumerable<ServerInfo, object>.GetEnumerableSorter
	|-OrderedEnumerable<ServerInfo, uint>.GetEnumerableSorter
	|-OrderedEnumerable<Item, DateTime>.GetEnumerableSorter
	|-OrderedEnumerable<KeyValuePair<object, int>, int>.GetEnumerableSorter
	|-OrderedEnumerable<KeyValuePair<object, long>, long>.GetEnumerableSorter
	|-OrderedEnumerable<KeyValuePair<object, object>, long>.GetEnumerableSorter
	|-OrderedEnumerable<double, double>.GetEnumerableSorter
	|-OrderedEnumerable<object, bool>.GetEnumerableSorter
	|-OrderedEnumerable<object, DateTime>.GetEnumerableSorter
	|-OrderedEnumerable<object, DateTimeOffset>.GetEnumerableSorter
	|-OrderedEnumerable<object, Guid>.GetEnumerableSorter
	|-OrderedEnumerable<object, int>.GetEnumerableSorter
	|-OrderedEnumerable<object, Int32Enum>.GetEnumerableSorter
	|-OrderedEnumerable<object, object>.GetEnumerableSorter
	|-OrderedEnumerable<object, float>.GetEnumerableSorter
	|-OrderedEnumerable<object, uint>.GetEnumerableSorter
	|-OrderedEnumerable<Resolution, int>.GetEnumerableSorter
	*/

}

internal struct Buffer<TElement> // TypeDefIndex: 3238
{	// Fields
	internal TElement[] items; // 0x0
	internal int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2251B0 Offset: 0x2245B0 VA: 0x1802251B0
	|-Buffer<Debugging.EntityInfo>..ctor
	|
	|-RVA: 0x2251E0 Offset: 0x2245E0 VA: 0x1802251E0
	|-Buffer<Demos.DemoInfo>..ctor
	|
	|-RVA: 0x225280 Offset: 0x224680 VA: 0x180225280
	|-Buffer<GameStat.Stat>..ctor
	|
	|-RVA: 0x225140 Offset: 0x224540 VA: 0x180225140
	|-Buffer<ItemSkinDirectory.Skin>..ctor
	|
	|-RVA: 0x225160 Offset: 0x224560 VA: 0x180225160
	|-Buffer<FourBitNumber>..ctor
	|
	|-RVA: 0x2251A0 Offset: 0x2245A0 VA: 0x1802251A0
	|-Buffer<SevenBitNumber>..ctor
	|
	|-RVA: 0x225270 Offset: 0x224670 VA: 0x180225270
	|-Buffer<Option>..ctor
	|
	|-RVA: 0x225240 Offset: 0x224640 VA: 0x180225240
	|-Buffer<ServerInfo>..ctor
	|
	|-RVA: 0x225170 Offset: 0x224570 VA: 0x180225170
	|-Buffer<SkinnedMultiMesh.Part>..ctor
	|
	|-RVA: 0x225220 Offset: 0x224620 VA: 0x180225220
	|-Buffer<InventoryDefId>..ctor
	|
	|-RVA: 0x225290 Offset: 0x224690 VA: 0x180225290
	|-Buffer<InventoryItemId>..ctor
	|
	|-RVA: 0x225150 Offset: 0x224550 VA: 0x180225150
	|-Buffer<InventoryItem>..ctor
	|
	|-RVA: 0x225250 Offset: 0x224650 VA: 0x180225250
	|-Buffer<InventoryRecipe.Ingredient>..ctor
	|
	|-RVA: 0x225200 Offset: 0x224600 VA: 0x180225200
	|-Buffer<InventoryRecipe>..ctor
	|
	|-RVA: 0x225190 Offset: 0x224590 VA: 0x180225190
	|-Buffer<Item>..ctor
	|
	|-RVA: 0x2251F0 Offset: 0x2245F0 VA: 0x1802251F0
	|-Buffer<byte>..ctor
	|
	|-RVA: 0x225260 Offset: 0x224660 VA: 0x180225260
	|-Buffer<char>..ctor
	|
	|-RVA: 0x2251C0 Offset: 0x2245C0 VA: 0x1802251C0
	|-Buffer<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x225210 Offset: 0x224610 VA: 0x180225210
	|-Buffer<KeyValuePair<object, long>>..ctor
	|
	|-RVA: 0x2251D0 Offset: 0x2245D0 VA: 0x1802251D0
	|-Buffer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2252A0 Offset: 0x2246A0 VA: 0x1802252A0
	|-Buffer<double>..ctor
	|
	|-RVA: 0x225110 Offset: 0x224510 VA: 0x180225110
	|-Buffer<int>..ctor
	|
	|-RVA: 0x225180 Offset: 0x224580 VA: 0x180225180
	|-Buffer<Int32Enum>..ctor
	|
	|-RVA: 0x225230 Offset: 0x224630 VA: 0x180225230
	|-Buffer<long>..ctor
	|
	|-RVA: 0x2252B0 Offset: 0x2246B0 VA: 0x1802252B0
	|-Buffer<object>..ctor
	|
	|-RVA: 0x225120 Offset: 0x224520 VA: 0x180225120
	|-Buffer<uint>..ctor
	|
	|-RVA: 0x225130 Offset: 0x224530 VA: 0x180225130
	|-Buffer<Resolution>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TElement[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x225010 Offset: 0x224410 VA: 0x180225010
	|-Buffer<Debugging.EntityInfo>.ToArray
	|-Buffer<Demos.DemoInfo>.ToArray
	|-Buffer<GameStat.Stat>.ToArray
	|-Buffer<ItemSkinDirectory.Skin>.ToArray
	|-Buffer<FourBitNumber>.ToArray
	|-Buffer<SevenBitNumber>.ToArray
	|-Buffer<Option>.ToArray
	|-Buffer<ServerInfo>.ToArray
	|-Buffer<SkinnedMultiMesh.Part>.ToArray
	|-Buffer<InventoryDefId>.ToArray
	|-Buffer<InventoryItemId>.ToArray
	|-Buffer<InventoryItem>.ToArray
	|-Buffer<InventoryRecipe.Ingredient>.ToArray
	|-Buffer<InventoryRecipe>.ToArray
	|-Buffer<Item>.ToArray
	|-Buffer<byte>.ToArray
	|-Buffer<char>.ToArray
	|-Buffer<KeyValuePair<object, int>>.ToArray
	|-Buffer<KeyValuePair<object, long>>.ToArray
	|-Buffer<KeyValuePair<object, object>>.ToArray
	|-Buffer<double>.ToArray
	|-Buffer<int>.ToArray
	|-Buffer<Int32Enum>.ToArray
	|-Buffer<long>.ToArray
	|-Buffer<object>.ToArray
	|-Buffer<uint>.ToArray
	|-Buffer<Resolution>.ToArray
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3258
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3258
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 0AA802CD6847EB893FE786B5EA5168B2FDCD7B93 /*Metadata offset 0x539E03*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 0C4110BC17D746F018F47B49E0EB0D6590F69939 /*Metadata offset 0x539E7B*/; // 0x78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 20733E1283D873EBE47133A95C233E11B76F5F11 /*Metadata offset 0x539F7B*/; // 0x178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 21F4CBF8283FF1CAEB4A39316A97FC1D6DF1D35E /*Metadata offset 0x53A37B*/; // 0x578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 23DFDCA6F045D4257BF5AC8CB1CF2EFADAFE9B94 /*Metadata offset 0x53A77B*/; // 0x978
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 30A0358B25B1372DD598BB4B1AC56AD6B8F08A47 /*Metadata offset 0x53AB7B*/; // 0xD78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 5B5DF5A459E902D96F7DB0FB235A25346CA85C5D /*Metadata offset 0x53AF7B*/; // 0x1178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 5BE411F1438EAEF33726D855E99011D5FECDDD4E /*Metadata offset 0x53B37B*/; // 0x1578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3 /*Metadata offset 0x53B77B*/; // 0x1978
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 A02DD1D8604EA8EC2D2BDA717A93A4EE85F13E53 /*Metadata offset 0x53B87B*/; // 0x1A78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 AE2F76ECEF8B08F0BC7EA95DCFE945E1727927C9 /*Metadata offset 0x53BC7B*/; // 0x1E78

}

public struct BatchQueryJob<CommandT, ResultT> // TypeDefIndex: 3307
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal NativeArray<CommandT> commands; // 0x0
	internal NativeArray<ResultT> results; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<CommandT> commands, NativeArray<ResultT> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F9EC0 Offset: 0x1F92C0 VA: 0x1801F9EC0
	|-BatchQueryJob<RaycastCommand, RaycastHit>..ctor
	*/

}

internal class InvokableCall<T1> : BaseInvokableCall // TypeDefIndex: 3629
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private UnityAction<T1> Delegate; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	protected void add_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A7B00 Offset: 0x17A6F00 VA: 0x1817A7B00
	|-InvokableCall<Option>.add_Delegate
	|-InvokableCall<bool>.add_Delegate
	|-InvokableCall<int>.add_Delegate
	|-InvokableCall<Int32Enum>.add_Delegate
	|-InvokableCall<object>.add_Delegate
	|-InvokableCall<float>.add_Delegate
	|-InvokableCall<Color>.add_Delegate
	|-InvokableCall<Vector2>.add_Delegate
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	protected void remove_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A7BC0 Offset: 0x17A6FC0 VA: 0x1817A7BC0
	|-InvokableCall<Option>.remove_Delegate
	|-InvokableCall<bool>.remove_Delegate
	|-InvokableCall<int>.remove_Delegate
	|-InvokableCall<Int32Enum>.remove_Delegate
	|-InvokableCall<object>.remove_Delegate
	|-InvokableCall<float>.remove_Delegate
	|-InvokableCall<Color>.remove_Delegate
	|-InvokableCall<Vector2>.remove_Delegate
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A7380 Offset: 0x17A6780 VA: 0x1817A7380
	|-InvokableCall<Option>..ctor
	|
	|-RVA: 0x17A79D0 Offset: 0x17A6DD0 VA: 0x1817A79D0
	|-InvokableCall<bool>..ctor
	|
	|-RVA: 0x17A74B0 Offset: 0x17A68B0 VA: 0x1817A74B0
	|-InvokableCall<int>..ctor
	|
	|-RVA: 0x17A7770 Offset: 0x17A6B70 VA: 0x1817A7770
	|-InvokableCall<Int32Enum>..ctor
	|
	|-RVA: 0x17A7640 Offset: 0x17A6A40 VA: 0x1817A7640
	|-InvokableCall<object>..ctor
	|
	|-RVA: 0x17A78A0 Offset: 0x17A6CA0 VA: 0x1817A78A0
	|-InvokableCall<float>..ctor
	|
	|-RVA: 0x19B8840 Offset: 0x19B7C40 VA: 0x1819B8840
	|-InvokableCall<Color>..ctor
	|
	|-RVA: 0x19B8710 Offset: 0x19B7B10 VA: 0x1819B8710
	|-InvokableCall<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T1> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A75E0 Offset: 0x17A69E0 VA: 0x1817A75E0
	|-InvokableCall<Option>..ctor
	|-InvokableCall<bool>..ctor
	|-InvokableCall<int>..ctor
	|-InvokableCall<Int32Enum>..ctor
	|-InvokableCall<object>..ctor
	|-InvokableCall<float>..ctor
	|-InvokableCall<Color>..ctor
	|-InvokableCall<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6D90 Offset: 0x17A6190 VA: 0x1817A6D90
	|-InvokableCall<Option>.Invoke
	|
	|-RVA: 0x17A7100 Offset: 0x17A6500 VA: 0x1817A7100
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x17A6B90 Offset: 0x17A5F90 VA: 0x1817A6B90
	|-InvokableCall<int>.Invoke
	|
	|-RVA: 0x17A6F60 Offset: 0x17A6360 VA: 0x1817A6F60
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x17A7240 Offset: 0x17A6640 VA: 0x1817A7240
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x17A69F0 Offset: 0x17A5DF0 VA: 0x1817A69F0
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x19B8390 Offset: 0x19B7790 VA: 0x1819B8390
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x19B84E0 Offset: 0x19B78E0 VA: 0x1819B84E0
	|-InvokableCall<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual void Invoke(T1 args0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6EF0 Offset: 0x17A62F0 VA: 0x1817A6EF0
	|-InvokableCall<Option>.Invoke
	|
	|-RVA: 0x17A6CD0 Offset: 0x17A60D0 VA: 0x1817A6CD0
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x17A6D30 Offset: 0x17A6130 VA: 0x1817A6D30
	|-InvokableCall<int>.Invoke
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x17A70A0 Offset: 0x17A64A0 VA: 0x1817A70A0
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x17A6B30 Offset: 0x17A5F30 VA: 0x1817A6B30
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x19B8630 Offset: 0x19B7A30 VA: 0x1819B8630
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x19B86A0 Offset: 0x19B7AA0 VA: 0x1819B86A0
	|-InvokableCall<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6990 Offset: 0x17A5D90 VA: 0x1817A6990
	|-InvokableCall<Option>.Find
	|-InvokableCall<bool>.Find
	|-InvokableCall<int>.Find
	|-InvokableCall<Int32Enum>.Find
	|-InvokableCall<object>.Find
	|-InvokableCall<float>.Find
	|-InvokableCall<Color>.Find
	|-InvokableCall<Vector2>.Find
	*/

}

public sealed class UnityAction<T0> : MulticastDelegate // TypeDefIndex: 3641
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-UnityAction<Option>..ctor
	|-UnityAction<bool>..ctor
	|-UnityAction<List<IEventSystemHandler>>..ctor
	|-UnityAction<int>..ctor
	|-UnityAction<Int32Enum>..ctor
	|-UnityAction<object>..ctor
	|-UnityAction<float>..ctor
	|-UnityAction<string>..ctor
	|-UnityAction<Color>..ctor
	|-UnityAction<Component>..ctor
	|-UnityAction<MessageEventArgs>..ctor
	|-UnityAction<Scene>..ctor
	|-UnityAction<LayoutRebuilder>..ctor
	|-UnityAction<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C36C0 Offset: 0x19C2AC0 VA: 0x1819C36C0
	|-UnityAction<Option>.Invoke
	|
	|-RVA: 0x19C3160 Offset: 0x19C2560 VA: 0x1819C3160
	|-UnityAction<bool>.Invoke
	|
	|-RVA: 0x19C2F70 Offset: 0x19C2370 VA: 0x1819C2F70
	|-UnityAction<int>.Invoke
	|-UnityAction<Int32Enum>.Invoke
	|
	|-RVA: 0x19C2C50 Offset: 0x19C2050 VA: 0x1819C2C50
	|-UnityAction<object>.Invoke
	|-UnityAction<Component>.Invoke
	|
	|-RVA: 0x19C2690 Offset: 0x19C1A90 VA: 0x1819C2690
	|-UnityAction<float>.Invoke
	|
	|-RVA: 0x129FFD0 Offset: 0x129F3D0 VA: 0x18129FFD0
	|-UnityAction<Color>.Invoke
	|
	|-RVA: 0x19C2970 Offset: 0x19C1D70 VA: 0x1819C2970
	|-UnityAction<Scene>.Invoke
	|
	|-RVA: 0x19C33E0 Offset: 0x19C27E0 VA: 0x1819C33E0
	|-UnityAction<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C2310 Offset: 0x19C1710 VA: 0x1819C2310
	|-UnityAction<Option>.BeginInvoke
	|
	|-RVA: 0x19C2410 Offset: 0x19C1810 VA: 0x1819C2410
	|-UnityAction<bool>.BeginInvoke
	|
	|-RVA: 0x19C2390 Offset: 0x19C1790 VA: 0x1819C2390
	|-UnityAction<int>.BeginInvoke
	|
	|-RVA: 0x19C2290 Offset: 0x19C1690 VA: 0x1819C2290
	|-UnityAction<Int32Enum>.BeginInvoke
	|
	|-RVA: 0x497210 Offset: 0x496610 VA: 0x180497210
	|-UnityAction<object>.BeginInvoke
	|
	|-RVA: 0x19C2590 Offset: 0x19C1990 VA: 0x1819C2590
	|-UnityAction<float>.BeginInvoke
	|
	|-RVA: 0x19C2610 Offset: 0x19C1A10 VA: 0x1819C2610
	|-UnityAction<Color>.BeginInvoke
	|
	|-RVA: 0x19C2490 Offset: 0x19C1890 VA: 0x1819C2490
	|-UnityAction<Scene>.BeginInvoke
	|
	|-RVA: 0x19C2510 Offset: 0x19C1910 VA: 0x1819C2510
	|-UnityAction<Vector2>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-UnityAction<Option>.EndInvoke
	|-UnityAction<bool>.EndInvoke
	|-UnityAction<int>.EndInvoke
	|-UnityAction<Int32Enum>.EndInvoke
	|-UnityAction<object>.EndInvoke
	|-UnityAction<float>.EndInvoke
	|-UnityAction<Color>.EndInvoke
	|-UnityAction<Scene>.EndInvoke
	|-UnityAction<Vector2>.EndInvoke
	*/

}

public abstract class UnityEvent<T0> : UnityEventBase // TypeDefIndex: 3642
{	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6B60 Offset: 0x19C5F60 VA: 0x1819C6B60
	|-UnityEvent<Brush>..ctor
	|-UnityEvent<Option>..ctor
	|-UnityEvent<bool>..ctor
	|-UnityEvent<int>..ctor
	|-UnityEvent<Int32Enum>..ctor
	|-UnityEvent<object>..ctor
	|-UnityEvent<float>..ctor
	|-UnityEvent<string>..ctor
	|-UnityEvent<Color>..ctor
	|-UnityEvent<BaseEventData>..ctor
	|-UnityEvent<MessageEventArgs>..ctor
	|-UnityEvent<TouchScreenKeyboard.Status>..ctor
	|-UnityEvent<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C4CF0 Offset: 0x19C40F0 VA: 0x1819C4CF0
	|-UnityEvent<Option>.AddListener
	|-UnityEvent<bool>.AddListener
	|-UnityEvent<int>.AddListener
	|-UnityEvent<Int32Enum>.AddListener
	|-UnityEvent<object>.AddListener
	|-UnityEvent<float>.AddListener
	|-UnityEvent<string>.AddListener
	|-UnityEvent<Color>.AddListener
	|-UnityEvent<MessageEventArgs>.AddListener
	|-UnityEvent<Vector2>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6B10 Offset: 0x19C5F10 VA: 0x1819C6B10
	|-UnityEvent<Option>.RemoveListener
	|-UnityEvent<bool>.RemoveListener
	|-UnityEvent<int>.RemoveListener
	|-UnityEvent<Int32Enum>.RemoveListener
	|-UnityEvent<object>.RemoveListener
	|-UnityEvent<float>.RemoveListener
	|-UnityEvent<Color>.RemoveListener
	|-UnityEvent<MessageEventArgs>.RemoveListener
	|-UnityEvent<Vector2>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C5390 Offset: 0x19C4790 VA: 0x1819C5390
	|-UnityEvent<Brush>.FindMethod_Impl
	|-UnityEvent<object>.FindMethod_Impl
	|-UnityEvent<string>.FindMethod_Impl
	|-UnityEvent<BaseEventData>.FindMethod_Impl
	|-UnityEvent<MessageEventArgs>.FindMethod_Impl
	|
	|-RVA: 0x19C4D30 Offset: 0x19C4130 VA: 0x1819C4D30
	|-UnityEvent<Option>.FindMethod_Impl
	|
	|-RVA: 0x19C5060 Offset: 0x19C4460 VA: 0x1819C5060
	|-UnityEvent<bool>.FindMethod_Impl
	|
	|-RVA: 0x19C4F50 Offset: 0x19C4350 VA: 0x1819C4F50
	|-UnityEvent<int>.FindMethod_Impl
	|
	|-RVA: 0x19C5280 Offset: 0x19C4680 VA: 0x1819C5280
	|-UnityEvent<Int32Enum>.FindMethod_Impl
	|-UnityEvent<TouchScreenKeyboard.Status>.FindMethod_Impl
	|
	|-RVA: 0x19C4E40 Offset: 0x19C4240 VA: 0x1819C4E40
	|-UnityEvent<float>.FindMethod_Impl
	|
	|-RVA: 0x19C5170 Offset: 0x19C4570 VA: 0x1819C5170
	|-UnityEvent<Color>.FindMethod_Impl
	|
	|-RVA: 0x19C54A0 Offset: 0x19C48A0 VA: 0x1819C54A0
	|-UnityEvent<Vector2>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C55B0 Offset: 0x19C49B0 VA: 0x1819C55B0
	|-UnityEvent<Brush>.GetDelegate
	|-UnityEvent<Option>.GetDelegate
	|-UnityEvent<bool>.GetDelegate
	|-UnityEvent<int>.GetDelegate
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<float>.GetDelegate
	|-UnityEvent<string>.GetDelegate
	|-UnityEvent<Color>.GetDelegate
	|-UnityEvent<BaseEventData>.GetDelegate
	|-UnityEvent<MessageEventArgs>.GetDelegate
	|-UnityEvent<TouchScreenKeyboard.Status>.GetDelegate
	|-UnityEvent<Vector2>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C5630 Offset: 0x19C4A30 VA: 0x1819C5630
	|-UnityEvent<Option>.GetDelegate
	|-UnityEvent<bool>.GetDelegate
	|-UnityEvent<int>.GetDelegate
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<float>.GetDelegate
	|-UnityEvent<Color>.GetDelegate
	|-UnityEvent<Vector2>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C5700 Offset: 0x19C4B00 VA: 0x1819C5700
	|-UnityEvent<Brush>.Invoke
	|-UnityEvent<object>.Invoke
	|-UnityEvent<string>.Invoke
	|-UnityEvent<BaseEventData>.Invoke
	|-UnityEvent<MessageEventArgs>.Invoke
	|
	|-RVA: 0x19C60D0 Offset: 0x19C54D0 VA: 0x1819C60D0
	|-UnityEvent<Option>.Invoke
	|
	|-RVA: 0x19C6390 Offset: 0x19C5790 VA: 0x1819C6390
	|-UnityEvent<bool>.Invoke
	|
	|-RVA: 0x19C6610 Offset: 0x19C5A10 VA: 0x1819C6610
	|-UnityEvent<int>.Invoke
	|
	|-RVA: 0x19C5930 Offset: 0x19C4D30 VA: 0x1819C5930
	|-UnityEvent<Int32Enum>.Invoke
	|-UnityEvent<TouchScreenKeyboard.Status>.Invoke
	|
	|-RVA: 0x19C5E50 Offset: 0x19C5250 VA: 0x1819C5E50
	|-UnityEvent<float>.Invoke
	|
	|-RVA: 0x19C5BB0 Offset: 0x19C4FB0 VA: 0x1819C5BB0
	|-UnityEvent<Color>.Invoke
	|
	|-RVA: 0x19C6890 Offset: 0x19C5C90 VA: 0x1819C6890
	|-UnityEvent<Vector2>.Invoke
	*/

}

public sealed class UnityAction<T0, T1> : MulticastDelegate // TypeDefIndex: 3643
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-UnityAction<object, object>..ctor
	|-UnityAction<ulong, object>..ctor
	|-UnityAction<Scene, Int32Enum>..ctor
	|-UnityAction<Scene, LoadSceneMode>..ctor
	|-UnityAction<Scene, Scene>..ctor
	|-UnityAction<Vector2, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110BDC0 Offset: 0x110B1C0 VA: 0x18110BDC0
	|-UnityAction<object, object>.Invoke
	|
	|-RVA: 0x19C3CA0 Offset: 0x19C30A0 VA: 0x1819C3CA0
	|-UnityAction<ulong, object>.Invoke
	|
	|-RVA: 0x19C45E0 Offset: 0x19C39E0 VA: 0x1819C45E0
	|-UnityAction<Scene, Int32Enum>.Invoke
	|-UnityAction<Scene, LoadSceneMode>.Invoke
	|
	|-RVA: 0x19C3FD0 Offset: 0x19C33D0 VA: 0x1819C3FD0
	|-UnityAction<Scene, Scene>.Invoke
	|
	|-RVA: 0x19C42E0 Offset: 0x19C36E0 VA: 0x1819C42E0
	|-UnityAction<Vector2, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10
	|-UnityAction<object, object>.BeginInvoke
	|
	|-RVA: 0x19C3B80 Offset: 0x19C2F80 VA: 0x1819C3B80
	|-UnityAction<ulong, object>.BeginInvoke
	|
	|-RVA: 0x19C3AF0 Offset: 0x19C2EF0 VA: 0x1819C3AF0
	|-UnityAction<Scene, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x19C3C10 Offset: 0x19C3010 VA: 0x1819C3C10
	|-UnityAction<Scene, Scene>.BeginInvoke
	|
	|-RVA: 0x19C3A60 Offset: 0x19C2E60 VA: 0x1819C3A60
	|-UnityAction<Vector2, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-UnityAction<object, object>.EndInvoke
	|-UnityAction<ulong, object>.EndInvoke
	|-UnityAction<Scene, Int32Enum>.EndInvoke
	|-UnityAction<Scene, Scene>.EndInvoke
	|-UnityAction<Vector2, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1> : UnityEventBase // TypeDefIndex: 3644
{	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6B60 Offset: 0x19C5F60 VA: 0x1819C6B60
	|-UnityEvent<object, object>..ctor
	|-UnityEvent<ulong, object>..ctor
	|-UnityEvent<ulong, string>..ctor
	|-UnityEvent<Vector2, Brush>..ctor
	|-UnityEvent<Vector2, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6B90 Offset: 0x19C5F90 VA: 0x1819C6B90
	|-UnityEvent<object, object>.FindMethod_Impl
	|
	|-RVA: 0x19C6EB0 Offset: 0x19C62B0 VA: 0x1819C6EB0
	|-UnityEvent<ulong, object>.FindMethod_Impl
	|-UnityEvent<ulong, string>.FindMethod_Impl
	|
	|-RVA: 0x19C6D20 Offset: 0x19C6120 VA: 0x1819C6D20
	|-UnityEvent<Vector2, Brush>.FindMethod_Impl
	|-UnityEvent<Vector2, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C7040 Offset: 0x19C6440 VA: 0x1819C7040
	|-UnityEvent<object, object>.GetDelegate
	|-UnityEvent<ulong, object>.GetDelegate
	|-UnityEvent<ulong, string>.GetDelegate
	|-UnityEvent<Vector2, Brush>.GetDelegate
	|-UnityEvent<Vector2, object>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C76C0 Offset: 0x19C6AC0 VA: 0x1819C76C0
	|-UnityEvent<object, object>.Invoke
	|
	|-RVA: 0x19C70C0 Offset: 0x19C64C0 VA: 0x1819C70C0
	|-UnityEvent<ulong, object>.Invoke
	|-UnityEvent<ulong, string>.Invoke
	|
	|-RVA: 0x19C73C0 Offset: 0x19C67C0 VA: 0x1819C73C0
	|-UnityEvent<Vector2, Brush>.Invoke
	|-UnityEvent<Vector2, object>.Invoke
	*/

}

public sealed class UnityAction<T0, T1, T2> : MulticastDelegate // TypeDefIndex: 3645
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-UnityAction<object, int, int>..ctor
	|-UnityAction<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1344630 Offset: 0x1343A30 VA: 0x181344630
	|-UnityAction<object, int, int>.Invoke
	|
	|-RVA: 0x19C4990 Offset: 0x19C3D90 VA: 0x1819C4990
	|-UnityAction<object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C48F0 Offset: 0x19C3CF0 VA: 0x1819C48F0
	|-UnityAction<object, int, int>.BeginInvoke
	|
	|-RVA: 0x130A3E0 Offset: 0x13097E0 VA: 0x18130A3E0
	|-UnityAction<object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-UnityAction<object, int, int>.EndInvoke
	|-UnityAction<object, object, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 3646
{	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6B60 Offset: 0x19C5F60 VA: 0x1819C6B60
	|-UnityEvent<object, int, int>..ctor
	|-UnityEvent<object, object, object>..ctor
	|-UnityEvent<string, int, int>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C7960 Offset: 0x19C6D60 VA: 0x1819C7960
	|-UnityEvent<object, int, int>.FindMethod_Impl
	|-UnityEvent<string, int, int>.FindMethod_Impl
	|
	|-RVA: 0x19C7B60 Offset: 0x19C6F60 VA: 0x1819C7B60
	|-UnityEvent<object, object, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C55B0 Offset: 0x19C49B0 VA: 0x1819C55B0
	|-UnityEvent<object, int, int>.GetDelegate
	|-UnityEvent<object, object, object>.GetDelegate
	|-UnityEvent<string, int, int>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C8080 Offset: 0x19C7480 VA: 0x1819C8080
	|-UnityEvent<object, int, int>.Invoke
	|-UnityEvent<string, int, int>.Invoke
	|
	|-RVA: 0x19C7D60 Offset: 0x19C7160 VA: 0x1819C7D60
	|-UnityEvent<object, object, object>.Invoke
	*/

}

public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 3647
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-UnityAction<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x130BFB0 Offset: 0x130B3B0 VA: 0x18130BFB0
	|-UnityAction<object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF41F0 Offset: 0xFF35F0 VA: 0x180FF41F0
	|-UnityAction<object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-UnityAction<object, object, object, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1, T2, T3> : UnityEventBase // TypeDefIndex: 3648
{	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6B60 Offset: 0x19C5F60 VA: 0x1819C6B60
	|-UnityEvent<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C8430 Offset: 0x19C7830 VA: 0x1819C8430
	|-UnityEvent<object, object, object, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C86A0 Offset: 0x19C7AA0 VA: 0x1819C86A0
	|-UnityEvent<object, object, object, object>.GetDelegate
	*/

}

public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 3941
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD4BD40 Offset: 0xD4B140 VA: 0x180D4BD40
	|-IntegratedSubsystemDescriptor<object>..ctor
	|-IntegratedSubsystemDescriptor<XRDisplaySubsystem>..ctor
	|-IntegratedSubsystemDescriptor<XRInputSubsystem>..ctor
	|-IntegratedSubsystemDescriptor<XRMeshSubsystem>..ctor
	*/

}

public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem // TypeDefIndex: 3947
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD4BD40 Offset: 0xD4B140 VA: 0x180D4BD40
	|-IntegratedSubsystem<object>..ctor
	|-IntegratedSubsystem<XRDisplaySubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRInputSubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRMeshSubsystemDescriptor>..ctor
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4066
{	// Methods

	// RVA: 0xAA6880 Offset: 0xAA5C80 VA: 0x180AA6880
	internal static uint ComputeStringHash(string s) { }

}

internal abstract class RBTree<K> : IEnumerable // TypeDefIndex: 4286
{	// Fields
	private RBTree.TreePage<K>[] _pageTable; // 0x0
	private int[] _pageTableMap; // 0x0
	private int _inUsePageCount; // 0x0
	private int _nextFreePageLine; // 0x0
	public int root; // 0x0
	private int _version; // 0x0
	private int _inUseNodeCount; // 0x0
	private int _inUseSatelliteTreeCount; // 0x0
	private readonly TreeAccessMethod _accessMethod; // 0x0

	// Properties
	public int Count { get; }
	public bool HasDuplicates { get; }
	public K Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract int CompareNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<object>.CompareNode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract int CompareSateliteTreeNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<object>.CompareSateliteTreeNode
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(TreeAccessMethod accessMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787350 Offset: 0x1786750 VA: 0x181787350
	|-RBTree<DataRow>..ctor
	|-RBTree<int>..ctor
	|-RBTree<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitTree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783480 Offset: 0x1782880 VA: 0x181783480
	|-RBTree<int>.InitTree
	|
	|-RVA: 0x20C42B0 Offset: 0x20C36B0 VA: 0x1820C42B0
	|-RBTree<object>.InitTree
	*/

	// RVA: -1 Offset: -1
	private void FreePage(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1782770 Offset: 0x1781B70 VA: 0x181782770
	|-RBTree<int>.FreePage
	|-RBTree<object>.FreePage
	*/

	// RVA: -1 Offset: -1
	private RBTree.TreePage<K> AllocPage(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17817F0 Offset: 0x1780BF0 VA: 0x1817817F0
	|-RBTree<int>.AllocPage
	|
	|-RVA: 0x20C2EF0 Offset: 0x20C22F0 VA: 0x1820C2EF0
	|-RBTree<object>.AllocPage
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFull(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783DB0 Offset: 0x17831B0 VA: 0x181783DB0
	|-RBTree<int>.MarkPageFull
	|-RBTree<object>.MarkPageFull
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFree(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783CF0 Offset: 0x17830F0 VA: 0x181783CF0
	|-RBTree<int>.MarkPageFree
	|-RBTree<object>.MarkPageFree
	*/

	// RVA: -1 Offset: -1
	private static int GetIntValueFromBitMap(uint bitMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1782D60 Offset: 0x1782160 VA: 0x181782D60
	|-RBTree<int>.GetIntValueFromBitMap
	|-RBTree<object>.GetIntValueFromBitMap
	*/

	// RVA: -1 Offset: -1
	private void FreeNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17825D0 Offset: 0x17819D0 VA: 0x1817825D0
	|-RBTree<int>.FreeNode
	|
	|-RVA: 0x20C36E0 Offset: 0x20C2AE0 VA: 0x1820C36E0
	|-RBTree<object>.FreeNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1782B60 Offset: 0x1781F60 VA: 0x181782B60
	|-RBTree<int>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x20C3A50 Offset: 0x20C2E50 VA: 0x1820C3A50
	|-RBTree<object>.GetIndexOfPageWithFreeSlot
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787420 Offset: 0x1786820 VA: 0x181787420
	|-RBTree<DataRow>.get_Count
	|-RBTree<int>.get_Count
	|-RBTree<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_HasDuplicates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787430 Offset: 0x1786830 VA: 0x181787430
	|-RBTree<int>.get_HasDuplicates
	|-RBTree<object>.get_HasDuplicates
	*/

	// RVA: -1 Offset: -1
	private int GetNewNode(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1782DD0 Offset: 0x17821D0 VA: 0x181782DD0
	|-RBTree<int>.GetNewNode
	|
	|-RVA: 0x20C3C50 Offset: 0x20C3050 VA: 0x1820C3C50
	|-RBTree<object>.GetNewNode
	*/

	// RVA: -1 Offset: -1
	private int Successor(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787180 Offset: 0x1786580 VA: 0x181787180
	|-RBTree<int>.Successor
	|-RBTree<object>.Successor
	*/

	// RVA: -1 Offset: -1
	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787020 Offset: 0x1786420 VA: 0x181787020
	|-RBTree<int>.Successor
	|
	|-RVA: 0x20C7BC0 Offset: 0x20C6FC0 VA: 0x1820C7BC0
	|-RBTree<object>.Successor
	*/

	// RVA: -1 Offset: -1
	private int Minimum(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783E70 Offset: 0x1783270 VA: 0x181783E70
	|-RBTree<int>.Minimum
	|-RBTree<object>.Minimum
	*/

	// RVA: -1 Offset: -1
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17837B0 Offset: 0x1782BB0 VA: 0x1817837B0
	|-RBTree<int>.LeftRotate
	|
	|-RVA: 0x20C45B0 Offset: 0x20C39B0 VA: 0x1820C45B0
	|-RBTree<object>.LeftRotate
	*/

	// RVA: -1 Offset: -1
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786660 Offset: 0x1785A60 VA: 0x181786660
	|-RBTree<int>.RightRotate
	|
	|-RVA: 0x20C71F0 Offset: 0x20C65F0 VA: 0x1820C71F0
	|-RBTree<object>.RightRotate
	*/

	// RVA: -1 Offset: -1
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1785560 Offset: 0x1784960 VA: 0x181785560
	|-RBTree<int>.RBInsert
	|
	|-RVA: 0x20C6120 Offset: 0x20C5520 VA: 0x1820C6120
	|-RBTree<object>.RBInsert
	*/

	// RVA: -1 Offset: -1
	public void UpdateNodeKey(K currentKey, K newKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787280 Offset: 0x1786680 VA: 0x181787280
	|-RBTree<int>.UpdateNodeKey
	|
	|-RVA: 0x20C7D20 Offset: 0x20C7120 VA: 0x1820C7D20
	|-RBTree<object>.UpdateNodeKey
	*/

	// RVA: -1 Offset: -1
	public K DeleteByIndex(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1782520 Offset: 0x1781920 VA: 0x181782520
	|-RBTree<int>.DeleteByIndex
	|
	|-RVA: 0x20C3630 Offset: 0x20C2A30 VA: 0x1820C3630
	|-RBTree<object>.DeleteByIndex
	*/

	// RVA: -1 Offset: -1
	public int RBDelete(int z_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1785520 Offset: 0x1784920 VA: 0x181785520
	|-RBTree<DataRow>.RBDelete
	|-RBTree<int>.RBDelete
	|-RBTree<object>.RBDelete
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17848A0 Offset: 0x1783CA0 VA: 0x1817848A0
	|-RBTree<int>.RBDeleteX
	|
	|-RVA: 0x20C54A0 Offset: 0x20C48A0 VA: 0x1820C54A0
	|-RBTree<object>.RBDeleteX
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783FD0 Offset: 0x17833D0 VA: 0x181783FD0
	|-RBTree<int>.RBDeleteFixup
	|
	|-RVA: 0x20C4BD0 Offset: 0x20C3FD0 VA: 0x1820C4BD0
	|-RBTree<object>.RBDeleteFixup
	*/

	// RVA: -1 Offset: -1
	private int SearchSubTree(int root_id, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786B90 Offset: 0x1785F90 VA: 0x181786B90
	|-RBTree<int>.SearchSubTree
	|
	|-RVA: 0x20C7720 Offset: 0x20C6B20 VA: 0x1820C7720
	|-RBTree<object>.SearchSubTree
	*/

	// RVA: -1 Offset: -1
	public K get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787440 Offset: 0x1786840 VA: 0x181787440
	|-RBTree<DataRow>.get_Item
	|-RBTree<int>.get_Item
	|-RBTree<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783150 Offset: 0x1782550 VA: 0x181783150
	|-RBTree<int>.GetNodeByKey
	|
	|-RVA: 0x20C4000 Offset: 0x20C3400 VA: 0x1820C4000
	|-RBTree<object>.GetNodeByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17828D0 Offset: 0x1781CD0 VA: 0x1817828D0
	|-RBTree<int>.GetIndexByKey
	|-RBTree<object>.GetIndexByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByNode(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1782A10 Offset: 0x1781E10 VA: 0x181782A10
	|-RBTree<int>.GetIndexByNode
	|
	|-RVA: 0x20C3900 Offset: 0x20C2D00 VA: 0x1820C3900
	|-RBTree<object>.GetIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexByNodePath(RBTree.NodePath<K> path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1782950 Offset: 0x1781D50 VA: 0x181782950
	|-RBTree<int>.GetIndexByNodePath
	|-RBTree<object>.GetIndexByNodePath
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1781B90 Offset: 0x1780F90 VA: 0x181781B90
	|-RBTree<int>.ComputeIndexByNode
	|-RBTree<object>.ComputeIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1781CB0 Offset: 0x17810B0 VA: 0x181781CB0
	|-RBTree<int>.ComputeIndexWithSatelliteByNode
	|-RBTree<object>.ComputeIndexWithSatelliteByNode
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByIndex(int userIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783070 Offset: 0x1782470 VA: 0x181783070
	|-RBTree<int>.GetNodeByIndex
	|
	|-RVA: 0x20C3F00 Offset: 0x20C3300 VA: 0x1820C3F00
	|-RBTree<object>.GetNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1781E30 Offset: 0x1781230 VA: 0x181781E30
	|-RBTree<int>.ComputeNodeByIndex
	|-RBTree<object>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int x_id, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1782050 Offset: 0x1781450 VA: 0x181782050
	|-RBTree<int>.ComputeNodeByIndex
	|-RBTree<object>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	public int Insert(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1781770 Offset: 0x1780B70 VA: 0x181781770
	|-RBTree<int>.Insert
	|-RBTree<object>.Insert
	*/

	// RVA: -1 Offset: -1
	public int Add(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1781770 Offset: 0x1780B70 VA: 0x181781770
	|-RBTree<DataRow>.Add
	|-RBTree<int>.Add
	|-RBTree<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C3880 Offset: 0x20C2C80 VA: 0x1820C3880
	|-RBTree<DataRow>.GetEnumerator
	|-RBTree<object>.GetEnumerator
	|
	|-RVA: 0x1782820 Offset: 0x1781C20 VA: 0x181782820
	|-RBTree<int>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(int nodeId, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C41B0 Offset: 0x20C35B0 VA: 0x1820C41B0
	|-RBTree<DataRow>.IndexOf
	|-RBTree<object>.IndexOf
	|
	|-RVA: 0x17832F0 Offset: 0x17826F0 VA: 0x1817832F0
	|-RBTree<int>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int Insert(int position, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783710 Offset: 0x1782B10 VA: 0x181783710
	|-RBTree<DataRow>.Insert
	|-RBTree<int>.Insert
	|-RBTree<object>.Insert
	*/

	// RVA: -1 Offset: -1
	public int InsertAt(int position, K item, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783670 Offset: 0x1782A70 VA: 0x181783670
	|-RBTree<int>.InsertAt
	|
	|-RVA: 0x20C44A0 Offset: 0x20C38A0 VA: 0x1820C44A0
	|-RBTree<object>.InsertAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786630 Offset: 0x1785A30 VA: 0x181786630
	|-RBTree<DataRow>.RemoveAt
	|-RBTree<int>.RemoveAt
	|-RBTree<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1781B60 Offset: 0x1780F60 VA: 0x181781B60
	|-RBTree<DataRow>.Clear
	|-RBTree<int>.Clear
	|-RBTree<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C3260 Offset: 0x20C2660 VA: 0x1820C3260
	|-RBTree<DataRow>.CopyTo
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x17822C0 Offset: 0x17816C0 VA: 0x1817822C0
	|-RBTree<int>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(K[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C3400 Offset: 0x20C2800 VA: 0x1820C3400
	|-RBTree<DataRow>.CopyTo
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x1782110 Offset: 0x1781510 VA: 0x181782110
	|-RBTree<int>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void SetRight(int nodeId, int rightNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786ED0 Offset: 0x17862D0 VA: 0x181786ED0
	|-RBTree<int>.SetRight
	|
	|-RVA: 0x20C7A70 Offset: 0x20C6E70 VA: 0x1820C7A70
	|-RBTree<object>.SetRight
	*/

	// RVA: -1 Offset: -1
	private void SetLeft(int nodeId, int leftNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786D80 Offset: 0x1786180 VA: 0x181786D80
	|-RBTree<int>.SetLeft
	|
	|-RVA: 0x20C7920 Offset: 0x20C6D20 VA: 0x1820C7920
	|-RBTree<object>.SetLeft
	*/

	// RVA: -1 Offset: -1
	private void SetParent(int nodeId, int parentNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786E60 Offset: 0x1786260 VA: 0x181786E60
	|-RBTree<int>.SetParent
	|
	|-RVA: 0x20C7A00 Offset: 0x20C6E00 VA: 0x1820C7A00
	|-RBTree<object>.SetParent
	*/

	// RVA: -1 Offset: -1
	private void SetColor(int nodeId, RBTree.NodeColor<K> color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786CA0 Offset: 0x17860A0 VA: 0x181786CA0
	|-RBTree<int>.SetColor
	|
	|-RVA: 0x20C7830 Offset: 0x20C6C30 VA: 0x1820C7830
	|-RBTree<object>.SetColor
	*/

	// RVA: -1 Offset: -1
	private void SetKey(int nodeId, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786D10 Offset: 0x1786110 VA: 0x181786D10
	|-RBTree<int>.SetKey
	|
	|-RVA: 0x20C78A0 Offset: 0x20C6CA0 VA: 0x1820C78A0
	|-RBTree<object>.SetKey
	*/

	// RVA: -1 Offset: -1
	private void SetNext(int nodeId, int nextNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786DF0 Offset: 0x17861F0 VA: 0x181786DF0
	|-RBTree<int>.SetNext
	|
	|-RVA: 0x20C7990 Offset: 0x20C6D90 VA: 0x1820C7990
	|-RBTree<object>.SetNext
	*/

	// RVA: -1 Offset: -1
	private void SetSubTreeSize(int nodeId, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786F40 Offset: 0x1786340 VA: 0x181786F40
	|-RBTree<int>.SetSubTreeSize
	|
	|-RVA: 0x20C7AE0 Offset: 0x20C6EE0 VA: 0x1820C7AE0
	|-RBTree<object>.SetSubTreeSize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783280 Offset: 0x1782680 VA: 0x181783280
	|-RBTree<int>.IncreaseSize
	|
	|-RVA: 0x20C4140 Offset: 0x20C3540 VA: 0x1820C4140
	|-RBTree<object>.IncreaseSize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17864A0 Offset: 0x17858A0 VA: 0x1817864A0
	|-RBTree<int>.RecomputeSize
	|
	|-RVA: 0x20C7060 Offset: 0x20C6460 VA: 0x1820C7060
	|-RBTree<object>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void DecreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17824B0 Offset: 0x17818B0 VA: 0x1817824B0
	|-RBTree<int>.DecreaseSize
	|
	|-RVA: 0x20C35C0 Offset: 0x20C29C0 VA: 0x1820C35C0
	|-RBTree<object>.DecreaseSize
	*/

	// RVA: -1 Offset: -1
	public int Right(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786B20 Offset: 0x1785F20 VA: 0x181786B20
	|-RBTree<int>.Right
	|
	|-RVA: 0x20C76B0 Offset: 0x20C6AB0 VA: 0x1820C76B0
	|-RBTree<object>.Right
	*/

	// RVA: -1 Offset: -1
	public int Left(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783C80 Offset: 0x1783080 VA: 0x181783C80
	|-RBTree<int>.Left
	|
	|-RVA: 0x20C4A80 Offset: 0x20C3E80 VA: 0x1820C4A80
	|-RBTree<object>.Left
	*/

	// RVA: -1 Offset: -1
	public int Parent(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783F60 Offset: 0x1783360 VA: 0x181783F60
	|-RBTree<int>.Parent
	|
	|-RVA: 0x20C4B60 Offset: 0x20C3F60 VA: 0x1820C4B60
	|-RBTree<object>.Parent
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodeColor<K> color(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17873B0 Offset: 0x17867B0 VA: 0x1817873B0
	|-RBTree<int>.color
	|
	|-RVA: 0x20C7DF0 Offset: 0x20C71F0 VA: 0x1820C7DF0
	|-RBTree<object>.color
	*/

	// RVA: -1 Offset: -1
	public int Next(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783EF0 Offset: 0x17832F0 VA: 0x181783EF0
	|-RBTree<int>.Next
	|
	|-RVA: 0x20C4AF0 Offset: 0x20C3EF0 VA: 0x1820C4AF0
	|-RBTree<object>.Next
	*/

	// RVA: -1 Offset: -1
	public int SubTreeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786FB0 Offset: 0x17863B0 VA: 0x181786FB0
	|-RBTree<int>.SubTreeSize
	|
	|-RVA: 0x20C7B50 Offset: 0x20C6F50 VA: 0x1820C7B50
	|-RBTree<object>.SubTreeSize
	*/

	// RVA: -1 Offset: -1
	public K Key(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1783740 Offset: 0x1782B40 VA: 0x181783740
	|-RBTree<int>.Key
	|
	|-RVA: 0x20C4540 Offset: 0x20C3940 VA: 0x1820C4540
	|-RBTree<object>.Key
	*/

}

internal sealed class Listeners<TElem> // TypeDefIndex: 4304
{	// Fields
	private readonly List<TElem> _listeners; // 0x0
	private readonly Listeners.Func<TElem, TElem, bool> _filter; // 0x0
	private readonly int _objectID; // 0x0
	private int _listenerReaderCount; // 0x0

	// Properties
	internal bool HasListeners { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int ObjectID, Listeners.Func<TElem, TElem, bool> notifyFilter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17813B0 Offset: 0x17807B0 VA: 0x1817813B0
	|-Listeners<DataViewListener>..ctor
	|-Listeners<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool get_HasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1781480 Offset: 0x1780880 VA: 0x181781480
	|-Listeners<DataViewListener>.get_HasListeners
	|-Listeners<object>.get_HasListeners
	*/

	// RVA: -1 Offset: -1
	internal void Add(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFF570 Offset: 0xDFE970 VA: 0x180DFF570
	|-Listeners<DataViewListener>.Add
	|-Listeners<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal int IndexOfReference(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1781260 Offset: 0x1780660 VA: 0x181781260
	|-Listeners<object>.IndexOfReference
	*/

	// RVA: -1 Offset: -1
	internal void Remove(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1781300 Offset: 0x1780700 VA: 0x181781300
	|-Listeners<DataViewListener>.Remove
	|-Listeners<object>.Remove
	*/

	// RVA: -1 Offset: -1
	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners.Action<TElem, TElem, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFD330 Offset: 0xDFC730 VA: 0x180DFD330
	|-Listeners<DataViewListener>.Notify<ListChangedEventArgs, bool, bool>
	|-Listeners<object>.Notify<object, bool, bool>
	|
	|-RVA: 0xDFD130 Offset: 0xDFC530 VA: 0x180DFD130
	|-Listeners<DataViewListener>.Notify<ListChangedType, DataRow, bool>
	|-Listeners<object>.Notify<Int32Enum, object, bool>
	|
	|-RVA: 0xDFD530 Offset: 0xDFC930 VA: 0x180DFD530
	|-Listeners<object>.Notify<object, object, object>
	*/

	// RVA: -1 Offset: -1
	private void RemoveNullListeners(int nullIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1781280 Offset: 0x1780680 VA: 0x181781280
	|-Listeners<object>.RemoveNullListeners
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4436
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0EE6555EB2C89F29655BD23FAB0573D8D684331A /*Metadata offset 0x53E22F*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 229F48C8598232AD9236772DD710E64615D0EE51 /*Metadata offset 0x53E253*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D /*Metadata offset 0x53E2EB*/; // 0xBC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 547FF12759F2EA9866F3E2095113686A6379ABBF /*Metadata offset 0x53E311*/; // 0xE2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 57F92A12C48A0856350D3C95C4145F2AF4C9DEFF /*Metadata offset 0x53E3A9*/; // 0x17A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 624B37B4C211942F3422DFFEAE9F44901E57339C /*Metadata offset 0x53E459*/; // 0x22A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x53E4F1*/; // 0x2C2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x53E525*/; // 0x2F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 FA7899481F1198B5A3F90368A998C285FCE19878 /*Metadata offset 0x53E559*/; // 0x32A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 FF8FD0AC7542FD42A8A7C8D145E120345BA51C56 /*Metadata offset 0x53E599*/; // 0x36A

}

internal sealed class _AndroidJNIHelper // TypeDefIndex: 4471
{	// Methods

	// RVA: 0x22759D0 Offset: 0x2274DD0 VA: 0x1822759D0
	public static IntPtr CreateJavaProxy(IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x226D050 Offset: 0x226C450 VA: 0x18226D050
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2276BF0 Offset: 0x2275FF0 VA: 0x182276BF0
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x2274F20 Offset: 0x2274320 VA: 0x182274F20
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x2276EC0 Offset: 0x22762C0 VA: 0x182276EC0
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x22773F0 Offset: 0x22767F0 VA: 0x1822773F0
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x2273740 Offset: 0x2272B40 VA: 0x182273740
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x226D180 Offset: 0x226C580 VA: 0x18226D180
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x2274630 Offset: 0x2273A30 VA: 0x182274630
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1259D00 Offset: 0x1259100 VA: 0x181259D00
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x125A5B0 Offset: 0x12599B0 VA: 0x18125A5B0
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x125AE60 Offset: 0x125A260 VA: 0x18125AE60
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x125B710 Offset: 0x125AB10 VA: 0x18125B710
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x125BFC0 Offset: 0x125B3C0 VA: 0x18125BFC0
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x125C870 Offset: 0x125BC70 VA: 0x18125C870
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x125D120 Offset: 0x125C520 VA: 0x18125D120
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x125DA10 Offset: 0x125CE10 VA: 0x18125DA10
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x125E2C0 Offset: 0x125D6C0 VA: 0x18125E2C0
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	*/

	// RVA: 0x226D2B0 Offset: 0x226C6B0 VA: 0x18226D2B0
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84FD0 Offset: 0xE843D0 VA: 0x180E84FD0
	|-_AndroidJNIHelper.GetMethodID<bool>
	|-_AndroidJNIHelper.GetMethodID<char>
	|-_AndroidJNIHelper.GetMethodID<double>
	|-_AndroidJNIHelper.GetMethodID<short>
	|-_AndroidJNIHelper.GetMethodID<int>
	|-_AndroidJNIHelper.GetMethodID<long>
	|-_AndroidJNIHelper.GetMethodID<object>
	|-_AndroidJNIHelper.GetMethodID<sbyte>
	|-_AndroidJNIHelper.GetMethodID<float>
	*/

	// RVA: 0x2275B30 Offset: 0x2274F30 VA: 0x182275B30
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x2275D90 Offset: 0x2275190 VA: 0x182275D90
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2275D00 Offset: 0x2275100 VA: 0x182275D00
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2275F70 Offset: 0x2275370 VA: 0x182275F70
	public static string GetSignature(object obj) { }

	// RVA: 0x2276B10 Offset: 0x2275F10 VA: 0x182276B10
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE85030 Offset: 0xE84430 VA: 0x180E85030
	|-_AndroidJNIHelper.GetSignature<bool>
	|
	|-RVA: 0xE85170 Offset: 0xE84570 VA: 0x180E85170
	|-_AndroidJNIHelper.GetSignature<char>
	|
	|-RVA: 0xE852B0 Offset: 0xE846B0 VA: 0x180E852B0
	|-_AndroidJNIHelper.GetSignature<double>
	|
	|-RVA: 0xE853F0 Offset: 0xE847F0 VA: 0x180E853F0
	|-_AndroidJNIHelper.GetSignature<short>
	|
	|-RVA: 0xE85530 Offset: 0xE84930 VA: 0x180E85530
	|-_AndroidJNIHelper.GetSignature<int>
	|
	|-RVA: 0xE85670 Offset: 0xE84A70 VA: 0x180E85670
	|-_AndroidJNIHelper.GetSignature<long>
	|
	|-RVA: 0xE857B0 Offset: 0xE84BB0 VA: 0x180E857B0
	|-_AndroidJNIHelper.GetSignature<object>
	|
	|-RVA: 0xE858F0 Offset: 0xE84CF0 VA: 0x180E858F0
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|
	|-RVA: 0xE85A30 Offset: 0xE84E30 VA: 0x180E85A30
	|-_AndroidJNIHelper.GetSignature<float>
	*/

}

public class Memoized<TResult, TArgs> // TypeDefIndex: 4824
{	// Fields
	private readonly Func<TArgs, TResult> _factory; // 0x0
	private readonly Dictionary<TArgs, TResult> _cache; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<TArgs, TResult> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F3620 Offset: 0x17F2A20 VA: 0x1817F3620
	|-Memoized<object, int>..ctor
	|-Memoized<Material[], int>..ctor
	|
	|-RVA: 0x17F3800 Offset: 0x17F2C00 VA: 0x1817F3800
	|-Memoized<object, object>..ctor
	|-Memoized<string, string>..ctor
	|
	|-RVA: 0x17F3710 Offset: 0x17F2B10 VA: 0x1817F3710
	|-Memoized<object, ValueTuple<Int32Enum, int>>..ctor
	|-Memoized<string, ValueTuple<ItemDefinition.AmountType, int>>..ctor
	*/

	// RVA: -1 Offset: -1
	public TResult Get(TArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F33E0 Offset: 0x17F27E0 VA: 0x1817F33E0
	|-Memoized<string, string>.Get
	|-Memoized<object, object>.Get
	|
	|-RVA: 0x17F3560 Offset: 0x17F2960 VA: 0x1817F3560
	|-Memoized<string, ValueTuple<ItemDefinition.AmountType, int>>.Get
	|-Memoized<object, ValueTuple<Int32Enum, int>>.Get
	|
	|-RVA: 0x17F34A0 Offset: 0x17F28A0 VA: 0x1817F34A0
	|-Memoized<Material[], int>.Get
	|-Memoized<object, int>.Get
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4849
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=146 062825E0D4AB4302B73500604BF9520511ACFD15 /*Metadata offset 0x53EB43*/; // 0x1298D

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4899
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=104 1D1E8406C3A31F2298952B0976625EEDFB010FDC /*Metadata offset 0x53ECA9*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 339A8BB625A037BA37DB4DF24A276E689D62172D /*Metadata offset 0x53ED11*/; // 0x68
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 48DE754CC0C776DAD1A85DB81BEFAAADE3A447E9 /*Metadata offset 0x53ED5D*/; // 0xB4
	internal static readonly long A5F5D64EF7BB696455C9841B907D2E09986EA902 = 2533317740920876; // 0x100

	// Methods

	// RVA: 0xAA6880 Offset: 0xAA5C80 VA: 0x180AA6880
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5096
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46 /*Metadata offset 0x53F0B7*/; // 0x12AB0

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5561
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5 B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9 /*Metadata offset 0x53FCF1*/; // 0x2590

	// Methods

	// RVA: 0xAA6880 Offset: 0xAA5C80 VA: 0x180AA6880
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5616
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 BA8C008E9A9CA9629B0D5A47EB9DFDC7E9E88D61 /*Metadata offset 0x53FECD*/; // 0x2640

}

internal class PriorityQueue<TPriority, TItem> // TypeDefIndex: 5668
{	// Fields
	private readonly SortedDictionary<TPriority, Queue<TItem>> _subqueues; // 0x0

	// Properties
	public bool HasItems { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TPriority> priorityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E34F0 Offset: 0x15E28F0 VA: 0x1815E34F0
	|-PriorityQueue<long, object>..ctor
	|-PriorityQueue<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3590 Offset: 0x15E2990 VA: 0x1815E3590
	|-PriorityQueue<long, TimedBlock>..ctor
	|-PriorityQueue<long, object>..ctor
	|-PriorityQueue<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(TPriority priority, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3290 Offset: 0x15E2690 VA: 0x1815E3290
	|-PriorityQueue<long, TimedBlock>.Enqueue
	|-PriorityQueue<long, object>.Enqueue
	|-PriorityQueue<object, object>.Enqueue
	*/

	// RVA: -1 Offset: -1
	private void AddQueueOfPriority(TPriority priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E2FE0 Offset: 0x15E23E0 VA: 0x1815E2FE0
	|-PriorityQueue<long, object>.AddQueueOfPriority
	|-PriorityQueue<object, object>.AddQueueOfPriority
	*/

	// RVA: -1 Offset: -1
	public TItem Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3350 Offset: 0x15E2750 VA: 0x1815E3350
	|-PriorityQueue<long, TimedBlock>.Peek
	|-PriorityQueue<long, object>.Peek
	|
	|-RVA: 0x15E3420 Offset: 0x15E2820 VA: 0x1815E3420
	|-PriorityQueue<object, object>.Peek
	*/

	// RVA: -1 Offset: -1
	public bool get_HasItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E35F0 Offset: 0x15E29F0 VA: 0x1815E35F0
	|-PriorityQueue<long, TimedBlock>.get_HasItems
	|-PriorityQueue<long, object>.get_HasItems
	|-PriorityQueue<object, object>.get_HasItems
	*/

	// RVA: -1 Offset: -1
	public TItem Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3150 Offset: 0x15E2550 VA: 0x1815E3150
	|-PriorityQueue<long, TimedBlock>.Dequeue
	|-PriorityQueue<long, object>.Dequeue
	|
	|-RVA: 0x15E31F0 Offset: 0x15E25F0 VA: 0x1815E31F0
	|-PriorityQueue<object, object>.Dequeue
	*/

	// RVA: -1 Offset: -1
	private TItem DequeueFromHighPriorityQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3080 Offset: 0x15E2480 VA: 0x1815E3080
	|-PriorityQueue<long, object>.DequeueFromHighPriorityQueue
	|-PriorityQueue<object, object>.DequeueFromHighPriorityQueue
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5677
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 00C40B3F013EDA60390F2E849C4581815A9419E4 /*Metadata offset 0x53FF4B*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 03B569C38E3CD6B720388919D43735A904012C52 /*Metadata offset 0x53FF73*/; // 0x28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 1FDC8DB567F5AAA7068D0D2A601CD71657CBDF38 /*Metadata offset 0x53FF9B*/; // 0x50
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 373B494F210C656134C5728D551D4C97B013EB33 /*Metadata offset 0x53FFE7*/; // 0x9C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 6BC4EAB0D604C8D4599021AD611C5DBA7FF7E306 /*Metadata offset 0x5403E7*/; // 0x49C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 89CE0E8EA590FD37283D6BEFD9E6805C8C47ADBD /*Metadata offset 0x54040F*/; // 0x4C4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 DB7C763C9670DD0F6ED34B75B3410A39D835F964 /*Metadata offset 0x54041F*/; // 0x4D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 ED032026472FF77A8A17BA4AFF3FC57AF4B4BF79 /*Metadata offset 0x540447*/; // 0x4FC

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5812
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=127 A097044521F478B3A2A9A3AC52887BA733E4DE56 /*Metadata offset 0x5404F0*/; // 0x2760

	// Methods

	// RVA: 0xAA6880 Offset: 0xAA5C80 VA: 0x180AA6880
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class XHashtable<TValue> // TypeDefIndex: 5818
{	// Fields
	private XHashtable.XHashtableState<TValue> state; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A59A50 Offset: 0x1A58E50 VA: 0x181A59A50
	|-XHashtable<object>..ctor
	|-XHashtable<WeakReference>..ctor
	|-XHashtable<XName>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A59A10 Offset: 0x1A58E10 VA: 0x181A59A10
	|-XHashtable<object>.TryGetValue
	|-XHashtable<WeakReference>.TryGetValue
	|-XHashtable<XName>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue Add(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A59880 Offset: 0x1A58C80 VA: 0x181A59880
	|-XHashtable<object>.Add
	|-XHashtable<WeakReference>.Add
	|-XHashtable<XName>.Add
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5852
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5852
	// Methods

	// RVA: 0xAA6880 Offset: 0xAA5C80 VA: 0x180AA6880
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class MethodCall<T, TResult> : MulticastDelegate // TypeDefIndex: 5930
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-MethodCall<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke(T target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD541D0 Offset: 0xD535D0 VA: 0x180D541D0
	|-MethodCall<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T target, object[] args, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10
	|-MethodCall<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-MethodCall<object, object>.EndInvoke
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6148
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D /*Metadata offset 0x54095A*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 ADFD2E1C801C825415DD53F4F2F72A13B389313C /*Metadata offset 0x540976*/; // 0x1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 D40004AB0E92BF6C8DFE481B56BE3D04ABDA76EB /*Metadata offset 0x540982*/; // 0x28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x54098C*/; // 0x32
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x5409C0*/; // 0x66

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6262
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 553AD71118F2B31C74BC988917343BADFA8F78EE /*Metadata offset 0x540B0D*/; // 0x2890

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6635
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 373B494F210C656134C5728D551D4C97B013EB33 /*Metadata offset 0x541166*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 E03C5B88B476F381E452F92C935A5B86131DFC4A /*Metadata offset 0x541566*/; // 0x400

}

internal class <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA} // TypeDefIndex: 6713
{	// Fields
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=32 $$method0x600002d-1 /*Metadata offset 0x541E4F*/; // 0x0
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=32 $$method0x600002d-2 /*Metadata offset 0x541E6F*/; // 0x20
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=128 $$method0x600002d-3 /*Metadata offset 0x541E8F*/; // 0x40
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=256 $$method0x600002d-4 /*Metadata offset 0x541F0F*/; // 0xC0

}

public class FastAction<A> // TypeDefIndex: 6738
{	// Fields
	private LinkedList<Action<A>> delegates; // 0x0
	private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6440 Offset: 0x17A5840 VA: 0x1817A6440
	|-FastAction<bool>.Add
	|-FastAction<object>.Add
	|-FastAction<Object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6590 Offset: 0x17A5990 VA: 0x1817A6590
	|-FastAction<bool>.Remove
	|-FastAction<object>.Remove
	|-FastAction<Object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A446F0 Offset: 0x1A43AF0 VA: 0x181A446F0
	|-FastAction<bool>.Call
	|
	|-RVA: 0x17A64E0 Offset: 0x17A58E0 VA: 0x1817A64E0
	|-FastAction<object>.Call
	|-FastAction<TMP_ColorGradient>.Call
	|-FastAction<Object>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6630 Offset: 0x17A5A30 VA: 0x1817A6630
	|-FastAction<bool>..ctor
	|-FastAction<object>..ctor
	|-FastAction<TMP_ColorGradient>..ctor
	|-FastAction<Object>..ctor
	*/

}

public class FastAction<A, B> // TypeDefIndex: 6739
{	// Fields
	private LinkedList<Action<A, B>> delegates; // 0x0
	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6440 Offset: 0x17A5840 VA: 0x1817A6440
	|-FastAction<bool, object>.Add
	|-FastAction<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6590 Offset: 0x17A5990 VA: 0x1817A6590
	|-FastAction<bool, object>.Remove
	|-FastAction<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A67E0 Offset: 0x17A5BE0 VA: 0x1817A67E0
	|-FastAction<bool, object>.Call
	|-FastAction<bool, TMP_FontAsset>.Call
	|-FastAction<bool, TextMeshPro>.Call
	|-FastAction<bool, TextMeshProUGUI>.Call
	|-FastAction<bool, Material>.Call
	|-FastAction<bool, Object>.Call
	|
	|-RVA: 0x17A6710 Offset: 0x17A5B10 VA: 0x1817A6710
	|-FastAction<object, object>.Call
	|-FastAction<object, Compute_DT_EventArgs>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6630 Offset: 0x17A5A30 VA: 0x1817A6630
	|-FastAction<bool, object>..ctor
	|-FastAction<bool, TMP_FontAsset>..ctor
	|-FastAction<bool, TextMeshPro>..ctor
	|-FastAction<bool, TextMeshProUGUI>..ctor
	|-FastAction<bool, Material>..ctor
	|-FastAction<bool, Object>..ctor
	|-FastAction<object, object>..ctor
	|-FastAction<object, Compute_DT_EventArgs>..ctor
	*/

}

public class FastAction<A, B, C> // TypeDefIndex: 6740
{	// Fields
	private LinkedList<Action<A, B, C>> delegates; // 0x0
	private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6440 Offset: 0x17A5840 VA: 0x1817A6440
	|-FastAction<object, object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6590 Offset: 0x17A5990 VA: 0x1817A6590
	|-FastAction<object, object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b, C c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A68B0 Offset: 0x17A5CB0 VA: 0x1817A68B0
	|-FastAction<object, object, object>.Call
	|-FastAction<GameObject, Material, Material>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A6630 Offset: 0x17A5A30 VA: 0x1817A6630
	|-FastAction<object, object, object>..ctor
	|-FastAction<GameObject, Material, Material>..ctor
	*/

}

public enum _HorizontalAlignmentOptions // TypeDefIndex: 6827
{	// Fields
	public int value__; // 0x0
	public const _HorizontalAlignmentOptions Left = 1;
	public const _HorizontalAlignmentOptions Center = 2;
	public const _HorizontalAlignmentOptions Right = 4;
	public const _HorizontalAlignmentOptions Justified = 8;
	public const _HorizontalAlignmentOptions Flush = 16;
	public const _HorizontalAlignmentOptions Geometry = 32;

}

public enum _VerticalAlignmentOptions // TypeDefIndex: 6828
{	// Fields
	public int value__; // 0x0
	public const _VerticalAlignmentOptions Top = 256;
	public const _VerticalAlignmentOptions Middle = 512;
	public const _VerticalAlignmentOptions Bottom = 1024;
	public const _VerticalAlignmentOptions Baseline = 2048;
	public const _VerticalAlignmentOptions Geometry = 4096;
	public const _VerticalAlignmentOptions Capline = 8192;

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6870
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46 /*Metadata offset 0x54261F*/; // 0x2C3F

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6937
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 B633673BF635D4C719EF5A0496BD28129A8CE5D3B76217371B6C1FDDFFDD780B /*Metadata offset 0x542679*/; // 0x2CB0

}

internal class <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7} // TypeDefIndex: 6968
{	// Fields
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=76 $$method0x6000504-1 /*Metadata offset 0x54277F*/; // 0x0
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=68 $$method0x6000505-1 /*Metadata offset 0x5427CB*/; // 0x4C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=6144 $$method0x6000507-1 /*Metadata offset 0x54280F*/; // 0x90
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=384 $$method0x6000507-2 /*Metadata offset 0x54400F*/; // 0x1890
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 $$method0x6000507-3 /*Metadata offset 0x54418F*/; // 0x1A10
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 $$method0x6000507-4 /*Metadata offset 0x54420B*/; // 0x1A8C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000507-5 /*Metadata offset 0x544287*/; // 0x1B08
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000507-6 /*Metadata offset 0x5442FF*/; // 0x1B80
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 $$method0x6000509-1 /*Metadata offset 0x544377*/; // 0x1BF8
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000509-2 /*Metadata offset 0x5443EB*/; // 0x1C6C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=76 $$method0x6000509-3 /*Metadata offset 0x544463*/; // 0x1CE4
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=19 $$method0x6000509-4 /*Metadata offset 0x5444AF*/; // 0x1D30
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=512 $$method0x6000509-5 /*Metadata offset 0x5444C2*/; // 0x1D43
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=256 $$method0x6000509-6 /*Metadata offset 0x5446C2*/; // 0x1F43
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 $$method0x6000509-7 /*Metadata offset 0x5447C2*/; // 0x2043
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000509-8 /*Metadata offset 0x544836*/; // 0x20B7
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=1152 $$method0x6000475-1 /*Metadata offset 0x5448AE*/; // 0x212F
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000475-2 /*Metadata offset 0x544D2E*/; // 0x25AF

}

internal class <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8} // TypeDefIndex: 6993
{	// Fields
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=32 $$method0x600007d-1 /*Metadata offset 0x544DDF*/; // 0x0
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=32 $$method0x600007d-2 /*Metadata offset 0x544DFF*/; // 0x20
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=128 $$method0x600007d-3 /*Metadata offset 0x544E1F*/; // 0x40
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=256 $$method0x600007d-4 /*Metadata offset 0x544E9F*/; // 0xC0

}

public struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> // TypeDefIndex: 7086
{	// Fields
	internal readonly object _obj; // 0x0
	internal readonly TResult _result; // 0x0
	internal readonly short _token; // 0x0
	internal readonly bool _continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TResult Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228B30 Offset: 0x227F30 VA: 0x180228B30
	|-ValueTask<bool>..ctor
	|
	|-RVA: 0x228AA0 Offset: 0x227EA0 VA: 0x180228AA0
	|-ValueTask<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228A50 Offset: 0x227E50 VA: 0x180228A50
	|-ValueTask<bool>..ctor
	|
	|-RVA: 0x228AE0 Offset: 0x227EE0 VA: 0x180228AE0
	|-ValueTask<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228830 Offset: 0x227C30 VA: 0x180228830
	|-ValueTask<bool>.GetHashCode
	|
	|-RVA: 0x228870 Offset: 0x227C70 VA: 0x180228870
	|-ValueTask<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2284F0 Offset: 0x2278F0 VA: 0x1802284F0
	|-ValueTask<bool>.Equals
	|
	|-RVA: 0x228630 Offset: 0x227A30 VA: 0x180228630
	|-ValueTask<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228750 Offset: 0x227B50 VA: 0x180228750
	|-ValueTask<bool>.Equals
	|
	|-RVA: 0x228600 Offset: 0x227A00 VA: 0x180228600
	|-ValueTask<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228B90 Offset: 0x227F90 VA: 0x180228B90
	|-ValueTask<bool>.get_IsCompleted
	|
	|-RVA: 0x228CD0 Offset: 0x2280D0 VA: 0x180228CD0
	|-ValueTask<object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228B80 Offset: 0x227F80 VA: 0x180228B80
	|-ValueTask<bool>.get_IsCompletedSuccessfully
	|
	|-RVA: 0x228B70 Offset: 0x227F70 VA: 0x180228B70
	|-ValueTask<object>.get_IsCompletedSuccessfully
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228E20 Offset: 0x228220 VA: 0x180228E20
	|-ValueTask<bool>.get_Result
	|
	|-RVA: 0x228E10 Offset: 0x228210 VA: 0x180228E10
	|-ValueTask<object>.get_Result
	*/

	// RVA: -1 Offset: -1
	public ValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228770 Offset: 0x227B70 VA: 0x180228770
	|-ValueTask<bool>.GetAwaiter
	|
	|-RVA: 0x2287C0 Offset: 0x227BC0 VA: 0x1802287C0
	|-ValueTask<object>.GetAwaiter
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228980 Offset: 0x227D80 VA: 0x180228980
	|-ValueTask<bool>.ToString
	|
	|-RVA: 0x2288B0 Offset: 0x227CB0 VA: 0x1802288B0
	|-ValueTask<object>.ToString
	*/

}

public struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 7096
{	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3BC0 Offset: 0x1E2FC0 VA: 0x1801E3BC0
	|-ValueTaskAwaiter<bool>..ctor
	|
	|-RVA: 0x1E3BE0 Offset: 0x1E2FE0 VA: 0x1801E3BE0
	|-ValueTaskAwaiter<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3C40 Offset: 0x1E3040 VA: 0x1801E3C40
	|-ValueTaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x1E3C00 Offset: 0x1E3000 VA: 0x1801E3C00
	|-ValueTaskAwaiter<object>.get_IsCompleted
	*/

	[StackTraceHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3B00 Offset: 0x1E2F00 VA: 0x1801E3B00
	|-ValueTaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x1E3B40 Offset: 0x1E2F40 VA: 0x1801E3B40
	|-ValueTaskAwaiter<object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3B90 Offset: 0x1E2F90 VA: 0x1801E3B90
	|-ValueTaskAwaiter<bool>.OnCompleted
	|
	|-RVA: 0x1E3B80 Offset: 0x1E2F80 VA: 0x1801E3B80
	|-ValueTaskAwaiter<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3BA0 Offset: 0x1E2FA0 VA: 0x1801E3BA0
	|-ValueTaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x1E3BB0 Offset: 0x1E2FB0 VA: 0x1801E3BB0
	|-ValueTaskAwaiter<object>.UnsafeOnCompleted
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7366
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 C92FBDBB320D6C40BEB41D97EE6C7B301C4ADB1D /*Metadata offset 0x546E97*/; // 0x1860

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7415
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 021F8912B268BE164A590D1440F05920A3F2A63B9874F994402C7AFFC6F92F82 /*Metadata offset 0x5476D3*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 02E68C9160BF270CAF19E18D3A77BC2EAA90EFCB3ECA3C454B58CD5BBA5FF7ED /*Metadata offset 0x547713*/; // 0x40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 047D891CAC8D4F883998ACEFD1EB63F6A679046FFD19EC1276A057F847EE37F6 /*Metadata offset 0x547813*/; // 0x140
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 06ADCD404637282636289E77FA01C56630CB4945332C96D5FA2D9239FE0D6B04 /*Metadata offset 0x547823*/; // 0x150
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 06D49AE61368F7B7C195381125B5A5E8F6830EA024D49F5C1A62950E74DBAF3D /*Metadata offset 0x5478A3*/; // 0x1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 091971E0756262C068D16B941EA6256855E94532833A9CE3374D9768E27E4596 /*Metadata offset 0x5478E3*/; // 0x210
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 124360CE49E1C84604EFA93F8F0C3292C1D216DB605CF153414D893922B18C9F /*Metadata offset 0x547973*/; // 0x2A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 13BE6783CC652C89CC0161446DBD67966CAC410DEA4DE4279FC767A259EFD546 /*Metadata offset 0x5479B3*/; // 0x2E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 1B8D49F1227D3FC61644822B9FC00CE70A3B2438A1064323BFBE6A022A26F042 /*Metadata offset 0x5479EB*/; // 0x318
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 1C01F69BD2391DE00F8F1B377D2D9E5991674702AD777030BA910AC531E4B0FE /*Metadata offset 0x5479FB*/; // 0x328
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 22E5D3D9ABC124EE0214CEF7079F24CFF9BE30FD6AF6BA5BBE15920C57497EA1 /*Metadata offset 0x547A3B*/; // 0x368
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2A03DC27FE2EB4E5D0A4358E22435065F2FB1BBF8CC2C4D9F754A9F24089344E /*Metadata offset 0x547A4B*/; // 0x378
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 2A1C6CEE1B003A06B471AA7632C6B5C4ED18A4E1A4784BF8CA09BD4F38BA4BB5 /*Metadata offset 0x547A8B*/; // 0x3B8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2BCE8E19B19AAD97CC510F21B5828CCB319639FA317FB59926A436ED3543F58D /*Metadata offset 0x547AC7*/; // 0x3F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2C72B27AAD08F98379E9F3E0F6A2D625F895C9E55F61404790377FC196FA14B8 /*Metadata offset 0x547B07*/; // 0x434
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2F4596419894C88417AC4DF5C99E98A374EFE4B57B7A4EB89CE65FEB92850A61 /*Metadata offset 0x547B47*/; // 0x474
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 320B0930454D74130DD5E245B70DA1736A2C1B5E664DD5BB82B490E60F3ECA2A /*Metadata offset 0x547B57*/; // 0x484
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 3229DAC3DA84FAC1A1018091DAF2A0C3D6B3624AC33BECF13A371238DAC95055 /*Metadata offset 0x547B67*/; // 0x494
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 3543AE0E1ED6A92350687219F717764E126E06D4FA179DE5B0CB3E2BDFE4AC9E /*Metadata offset 0x547B77*/; // 0x4A4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 3554CE8BB09083C24D298DF77456CB67242E6EEE3DEDFE595E11B90D2F70C0FF /*Metadata offset 0x547BD3*/; // 0x500
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1500 3B42FF7B534B27868E300720C678882AF0698E9434D0FA135656E097480324FF /*Metadata offset 0x547C13*/; // 0x540
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 3EDD050356C639DD16815E64CA19652B1B981F1BA2FF76176BB3995FF0DB860D /*Metadata offset 0x5481EF*/; // 0xB1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 4053901EA5134D137292C48A98E1382B09C1E49C98EEF77C2D00D8FF24481D4F /*Metadata offset 0x5481FF*/; // 0xB2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 419EB5F371A1171DBE8C085F1BB25D78AA0647C1365608E167054A37BFEAD834 /*Metadata offset 0x54823F*/; // 0xB6C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 4517AF16CD9D95D0B56C33292D289749B763021F170127ED439165498D243E69 /*Metadata offset 0x54824F*/; // 0xB7C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 4E7A2BE1E8600FA773FA4952A14AE27AD21E294C2C90F674BEA6BB8B089F39C1 /*Metadata offset 0x548263*/; // 0xB90
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 550560694565D72C91221BEE89B41C8AA412660E1CF28C626BC523BC959438A9 /*Metadata offset 0x548283*/; // 0xBB0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8748 5600405012DD0807E058E5A8F3F7A9AF31716C8560F552613672D0D770364603 /*Metadata offset 0x5482C3*/; // 0xBF0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 56C5F192F58A478FC32D5428DA86D03B15A95E9A982E82BA5026E6EBE259FE48 /*Metadata offset 0x54A4EF*/; // 0x2E1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 57CD95842F6B0D5A0823F7A82A33632D2D4DA79615A834507722CBBBD054E3CF /*Metadata offset 0x54A57F*/; // 0x2EAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 58BB6050E828A1FDB65D46F61ADBE862543CF7261AA487580A1328D24E944BBD /*Metadata offset 0x54A5BF*/; // 0x2EEC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 5ED52DA9C543DD730BD7056787DF87C0AED3189F42C3321C4196EA8B70C87D2A /*Metadata offset 0x54A5CF*/; // 0x2EFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=88 6547EC5EB178C3DBF6A302152A1FE3BDF747E8E5EB41343EECEA2F45D745E5D1 /*Metadata offset 0x54A65F*/; // 0x2F8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 673F8620472294A2666EB7018FC21EF377E5B15A76872E89803CBDBDBC17F1B8 /*Metadata offset 0x54A6B7*/; // 0x2FE4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6807ED2269DB8E9A70F5D22C6D41806D26C51C306050C58861DEBD9B21D76D0B /*Metadata offset 0x54A6C7*/; // 0x2FF4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6810D47101B1F88C982302E36EF8DBDB344EAFDF31E058B2AE9B23522DA15D89 /*Metadata offset 0x54A6D7*/; // 0x3004
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 683133215F3906FE49DACDB11CE3F917EF1B439110BF4CE1092DB8F15D087E2F /*Metadata offset 0x54A6E7*/; // 0x3014
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 68F20C1D1F9AD9A40A6FF9C3879482F58AED8E4A58995CEB0F83B2575DCFD2BC /*Metadata offset 0x54A743*/; // 0x3070
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6B6C31FF54224894CC66030691DB54C3EEE6BE4D42DB3DDA43EEC126F036360E /*Metadata offset 0x54A753*/; // 0x3080
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 70CBEAD43E82DC4CCC445D5552A983D797EEF8D2AD3665EB8FAAB2187F64F6FE /*Metadata offset 0x54A793*/; // 0x30C0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 70CF9A93794FD166C020BBDF13AE34B6B43B3A2271EC768A35797C135FC62D20 /*Metadata offset 0x54A7D3*/; // 0x3100
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 79B6797C01D7827A0E35892156B642BD84A9FA528E603C743515D3822864A051 /*Metadata offset 0x54A80B*/; // 0x3138
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7A5DCFD7518F8A0A3FA422FA014FF84FE08070112345B17E00C0FB0AFC6D7461 /*Metadata offset 0x54A82B*/; // 0x3158
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7CC4C8FC1CA4B0FA871FEB4911499E0268FE161D01C6ADFD186B0378C4063EBA /*Metadata offset 0x54A84B*/; // 0x3178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 8C6C0F60451FBE1D2DDDF80A2A9F0B7684893D5B0B8CEAB4CA837EE615B3954E /*Metadata offset 0x54A86B*/; // 0x3198
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 941D4DCAADBEC3CC42B0F9F20212661AC83343F86BC7F873B237BC25AF1B195C /*Metadata offset 0x54B06B*/; // 0x3998
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9742CA838C60363B639BEC16A2086253E96A532C05331B73181E45ED9D213F13 /*Metadata offset 0x54B0AB*/; // 0x39D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324 9F53690DAB4D28E43D6BB3EB96D00F76FAF99D7681A6E8F0061297C8DD5EFF33 /*Metadata offset 0x54B0EB*/; // 0x3A18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9FB71D398994B2E0C6CE3CE99EE4CBD26EE1524A81DDB919603C13A2885F5483 /*Metadata offset 0x54B22F*/; // 0x3B5C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 A28E77C3345C5351A69C7393656A759AABE24F2E59F5BFC49A771E190D9C9FCC /*Metadata offset 0x54B26F*/; // 0x3B9C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 A3F937EE796D2312148DDB921F1293E76047E426F9BF3864DD12817D66034E74 /*Metadata offset 0x54B27F*/; // 0x3BAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 A4B3F75E2EA169B5351F2BAA4DBAB862A18EDFBAE5B1CB4DBEFAEC4E22DA6BD3 /*Metadata offset 0x54B2BF*/; // 0x3BEC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 A84E72B8CD1EB5B569F80091ADA35B15F45C05E48515346C276DFBC7457817CD /*Metadata offset 0x54B2FF*/; // 0x3C2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 AC808BDFC94A2720F9A403E96C598F28C4A82AACBF21E2A1A6347C32A66B6425 /*Metadata offset 0x54B37F*/; // 0x3CAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B107577D43B15DF28D27533ADF012E72BD63868C2A2E688AC15978DC38CD5677 /*Metadata offset 0x54B38F*/; // 0x3CBC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 B10D5342782BFD3820C0FFBD8DDCDF80BAA0ED5F0DF5746D2EA885110239AC7A /*Metadata offset 0x54B39F*/; // 0x3CCC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 B79C140A0DE10B238571FE854A6BC223D6D8C50F6ED4E227CCC677094DCB3558 /*Metadata offset 0x54B3DF*/; // 0x3D0C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B9C5D4C45600219530B355BB1786AA4E282347901A9E3BF35DC8EE98E1307DFB /*Metadata offset 0x54B3FF*/; // 0x3D2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 BBDCD859D8A76172AF0C213EFB99A6F64E8AB028BECE6D313FA5B6BCF96CD15A /*Metadata offset 0x54B40F*/; // 0x3D3C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C271A86BEFE71CEF20615946687F7A3A13E980C14FD4637951697CD4A6112156 /*Metadata offset 0x54B46B*/; // 0x3D98
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C31F1438706DA962938E7F1D03470E164E0EA9EE1CD0F0D19CA29C7E932C91DC /*Metadata offset 0x54B4C7*/; // 0x3DF4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 C3FBE83D14A8E5B3DCCAF45D7AD6C35F769326FFAED483A102ACF50FB824C9C2 /*Metadata offset 0x54B4D7*/; // 0x3E04
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 C6D060549430A52150918BF2837FCCD94C6D727B74A5946A8F7EF51B940C3CF7 /*Metadata offset 0x54B517*/; // 0x3E44
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C775F22681F0D15310756B294BB58FC4364A5DE6030B819E8D3EEC4E75454915 /*Metadata offset 0x54B54F*/; // 0x3E7C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 C807773510A04834C84A6A093A8267D127DC4413714AD99057315D8CABE1D467 /*Metadata offset 0x54B5AB*/; // 0x3ED8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C842A7F36E23186A8F55DC7D0E63E781469950969CB88357227234F95C35DEA9 /*Metadata offset 0x54B5CB*/; // 0x3EF8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 CCC564D5CDB40E327F07151E33EF8AD040EEB5129CE505D00FE6EC11BD28C359 /*Metadata offset 0x54B627*/; // 0x3F54
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 CD4DE47C20503BFF1B99694EAF6390723510293766C75243F8B3CA7B56C89359 /*Metadata offset 0x54B65F*/; // 0x3F8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 D20525C66D9D2B26BC9D3A773951775A3813FC7F97CC4A2EADFF258D3C9D869E /*Metadata offset 0x54B6EF*/; // 0x401C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 D3310F8730C74E00C7014874471A5E27574CD015457352EFB0373E8C5DA85FD1 /*Metadata offset 0x54B6FF*/; // 0x402C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DD54E6E73536232DFD682C64D36E265B59ACF8AD04FC6062A2EB7225BBDDDB02 /*Metadata offset 0x54B70F*/; // 0x403C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 DDC358E79464AB64B601CE4D8FBC308D787438D4CE92844B5FD77F2DE1E21575 /*Metadata offset 0x54B747*/; // 0x4074
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 DE26AA4452A148F1FCFF9D95EA656766D0DC19BDCEE086F85BC3F9BD8AB7F25B /*Metadata offset 0x54B847*/; // 0x4174
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 E2AA696710083FEFF382491A86DF649DB1E8EE6AA4ECF99E8D98CFBF871BFCE4 /*Metadata offset 0x54B857*/; // 0x4184
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 ED977BBA7102E7758BEF3DA21CD69B44B8864A1D6F43BB20E6BF59862487ECBA /*Metadata offset 0x54B867*/; // 0x4194
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 EFC52C86FFF3F24CE6C0C14D161FCF00584AB329C5997334034F2B4D91225307 /*Metadata offset 0x54B8A3*/; // 0x41D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 F1B0145A5F0D3E964A90201094730422F3013B94D7B9E73B6FFDED5643D486A2 /*Metadata offset 0x54B8EB*/; // 0x4218
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 F8756C1F7B8F886752A7B73230C5AC5397F7CE2B1BFDC5C139DBED513BD228C3 /*Metadata offset 0x54B923*/; // 0x4250

}

internal sealed class TimedObjectsComparer<TObject> : IComparer<TObject> // TypeDefIndex: 7464
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int Compare(TObject x, TObject y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F68F0 Offset: 0x17F5CF0 VA: 0x1817F68F0
	|-TimedObjectsComparer<object>.Compare
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-TimedObjectsComparer<object>..ctor
	*/

}

public sealed class ValueChange<TValue> : ITimedObject // TypeDefIndex: 7504
{	// Fields
	private readonly long _time; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly TValue <Value>k__BackingField; // 0x0

	// Properties
	public long Time { get; }
	public TValue Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(long time, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F7910 Offset: 0x17F6D10 VA: 0x1817F7910
	|-ValueChange<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public long get_Time() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	|-ValueChange<Tempo>.get_Time
	|-ValueChange<TimeSignature>.get_Time
	|-ValueChange<object>.get_Time
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public TValue get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-ValueChange<Tempo>.get_Value
	|-ValueChange<TimeSignature>.get_Value
	|-ValueChange<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(ValueChange<TValue> change1, ValueChange<TValue> change2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F79A0 Offset: 0x17F6DA0 VA: 0x1817F79A0
	|-ValueChange<object>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(ValueChange<TValue> change1, ValueChange<TValue> change2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F7B70 Offset: 0x17F6F70 VA: 0x1817F7B70
	|-ValueChange<object>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F7860 Offset: 0x17F6C60 VA: 0x1817F7860
	|-ValueChange<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F7740 Offset: 0x17F6B40 VA: 0x1817F7740
	|-ValueChange<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F77C0 Offset: 0x17F6BC0 VA: 0x1817F77C0
	|-ValueChange<object>.GetHashCode
	*/

}

public sealed class ValueLine<TValue> : IEnumerable<ValueChange<TValue>>, IEnumerable // TypeDefIndex: 7505
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler ValuesChanged; // 0x0
	private readonly TimedObjectsComparer<ValueChange<TValue>> _comparer; // 0x0
	private readonly List<ValueChange<TValue>> _valueChanges; // 0x0
	private readonly TValue _defaultValue; // 0x0
	private bool _valuesChanged; // 0x0
	private long _maxTime; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal void add_ValuesChanged(EventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F8990 Offset: 0x17F7D90 VA: 0x1817F8990
	|-ValueLine<Tempo>.add_ValuesChanged
	|-ValueLine<TimeSignature>.add_ValuesChanged
	|-ValueLine<object>.add_ValuesChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal void remove_ValuesChanged(EventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F8A40 Offset: 0x17F7E40 VA: 0x1817F8A40
	|-ValueLine<Tempo>.remove_ValuesChanged
	|-ValueLine<TimeSignature>.remove_ValuesChanged
	|-ValueLine<object>.remove_ValuesChanged
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TValue defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F8890 Offset: 0x17F7C90 VA: 0x1817F8890
	|-ValueLine<Tempo>..ctor
	|-ValueLine<TimeSignature>..ctor
	|-ValueLine<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TValue GetValueAtTime(long time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F7CB0 Offset: 0x17F70B0 VA: 0x1817F7CB0
	|-ValueLine<TimeSignature>.GetValueAtTime
	|-ValueLine<object>.GetValueAtTime
	*/

	// RVA: -1 Offset: -1
	internal ValueChange<TValue> GetValueChangeAtTime(long time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F7D50 Offset: 0x17F7150 VA: 0x1817F7D50
	|-ValueLine<object>.GetValueChangeAtTime
	*/

	// RVA: -1 Offset: -1
	internal void SetValue(long time, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F8630 Offset: 0x17F7A30 VA: 0x1817F8630
	|-ValueLine<Tempo>.SetValue
	|-ValueLine<TimeSignature>.SetValue
	|-ValueLine<object>.SetValue
	*/

	// RVA: -1 Offset: -1
	internal ValueLine<TValue> Reverse(long centerTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F7F00 Offset: 0x17F7300 VA: 0x1817F7F00
	|-ValueLine<Tempo>.Reverse
	|-ValueLine<TimeSignature>.Reverse
	|-ValueLine<object>.Reverse
	*/

	// RVA: -1 Offset: -1
	private void OnValuesChanged(bool forceSort = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F7E40 Offset: 0x17F7240 VA: 0x1817F7E40
	|-ValueLine<object>.OnValuesChanged
	*/

	// RVA: -1 Offset: -1
	private void OnValueChangesNeedSorting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC3110 Offset: 0xFC2510 VA: 0x180FC3110
	|-ValueLine<object>.OnValueChangesNeedSorting
	*/

	// RVA: -1 Offset: -1
	private void OnValueChangesSortingCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5AC10 Offset: 0xF5A010 VA: 0x180F5AC10
	|-ValueLine<object>.OnValueChangesSortingCompleted
	*/

	// RVA: -1 Offset: -1
	private void SortValueChanges() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F87F0 Offset: 0x17F7BF0 VA: 0x1817F87F0
	|-ValueLine<object>.SortValueChanges
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<ValueChange<TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F7C00 Offset: 0x17F7000 VA: 0x1817F7C00
	|-ValueLine<Tempo>.GetEnumerator
	|-ValueLine<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F8860 Offset: 0x17F7C60 VA: 0x1817F8860
	|-ValueLine<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7638
{	// Fields
	internal static readonly int B52DDE3D967E604310620E80EFBFBED9B6FB8C0605B3CB29D31534DAA6181A7C = 505223448; // 0x18B0

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7836
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$132 $$field-0 /*Metadata offset 0x54C971*/; // 0x1B70

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7854
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x54D1A1*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x54D3A1*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x54D5A1*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x54D7A1*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x54D9A1*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x54DBA1*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x54DDA1*/; // 0xC00

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7895
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x54E74D*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x54E94D*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x54EB4D*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x54ED4D*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x54EF4D*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x54F14D*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x54F34D*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x54F54D*/; // 0xE00

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7973
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x54FEF9*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x5500F9*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x5502F9*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x5504F9*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x5506F9*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x5508F9*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x550AF9*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x550CF9*/; // 0xE00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-8 /*Metadata offset 0x550EF9*/; // 0x1000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-9 /*Metadata offset 0x5510F9*/; // 0x1200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-10 /*Metadata offset 0x5512F9*/; // 0x1400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-11 /*Metadata offset 0x5514F9*/; // 0x1600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-12 /*Metadata offset 0x5516F9*/; // 0x1800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-13 /*Metadata offset 0x5518F9*/; // 0x1A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-14 /*Metadata offset 0x551AF9*/; // 0x1C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-15 /*Metadata offset 0x551CF9*/; // 0x1E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-16 /*Metadata offset 0x551EF9*/; // 0x2000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-17 /*Metadata offset 0x5520F9*/; // 0x2200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-18 /*Metadata offset 0x5522F9*/; // 0x2400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-19 /*Metadata offset 0x5524F9*/; // 0x2600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-20 /*Metadata offset 0x5526F9*/; // 0x2800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-21 /*Metadata offset 0x5528F9*/; // 0x2A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-22 /*Metadata offset 0x552AF9*/; // 0x2C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-23 /*Metadata offset 0x552CF9*/; // 0x2E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-24 /*Metadata offset 0x552EF9*/; // 0x3000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-25 /*Metadata offset 0x5530F9*/; // 0x3200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-26 /*Metadata offset 0x5532F9*/; // 0x3400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-27 /*Metadata offset 0x5534F9*/; // 0x3600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-28 /*Metadata offset 0x5536F9*/; // 0x3800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-29 /*Metadata offset 0x5538F9*/; // 0x3A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-30 /*Metadata offset 0x553AF9*/; // 0x3C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-31 /*Metadata offset 0x553CF9*/; // 0x3E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-32 /*Metadata offset 0x553EF9*/; // 0x4000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-33 /*Metadata offset 0x5540F9*/; // 0x4200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-34 /*Metadata offset 0x5542F9*/; // 0x4400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-35 /*Metadata offset 0x5544F9*/; // 0x4600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-36 /*Metadata offset 0x5546F9*/; // 0x4800

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 8007
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x5550A5*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x5552A5*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x5554A5*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x5556A5*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x5558A5*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x555AA5*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x555CA5*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x555EA5*/; // 0xE00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-8 /*Metadata offset 0x5560A5*/; // 0x1000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-9 /*Metadata offset 0x5562A5*/; // 0x1200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-10 /*Metadata offset 0x5564A5*/; // 0x1400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-11 /*Metadata offset 0x5566A5*/; // 0x1600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-12 /*Metadata offset 0x5568A5*/; // 0x1800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-13 /*Metadata offset 0x556AA5*/; // 0x1A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-14 /*Metadata offset 0x556CA5*/; // 0x1C00

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class CC_AnalogTV : CC_Base // TypeDefIndex: 8034
{	// Fields
	public float phase; // 0x28
	public bool grayscale; // 0x2C
	public float noiseIntensity; // 0x30
	public float scanlinesIntensity; // 0x34
	public float scanlinesCount; // 0x38
	public float distortion; // 0x3C
	public float cubicDistortion; // 0x40
	public float scale; // 0x44

	// Methods

	// RVA: 0x1063510 Offset: 0x1062910 VA: 0x181063510
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x10636F0 Offset: 0x1062AF0 VA: 0x1810636F0
	public void .ctor() { }

}

public class CC_Base : MonoBehaviour // TypeDefIndex: 8035
{	// Fields
	public Shader shader; // 0x18
	protected Material _material; // 0x20

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x10637C0 Offset: 0x1062BC0 VA: 0x1810637C0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x1063860 Offset: 0x1062C60 VA: 0x181063860
	protected Material get_material() { }

	// RVA: 0x1063730 Offset: 0x1062B30 VA: 0x181063730 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class CC_BleachBypass : CC_Base // TypeDefIndex: 8036
{	// Fields
	public float amount; // 0x28

	// Methods

	// RVA: 0x1063920 Offset: 0x1062D20 VA: 0x181063920
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0xA11CA0 Offset: 0xA110A0 VA: 0x180A11CA0
	public void .ctor() { }

}

public class CC_Blend : CC_Base // TypeDefIndex: 8037
{	// Fields
	public Texture texture; // 0x28
	public float amount; // 0x30
	public int mode; // 0x34

	// Methods

	// RVA: 0x1063A20 Offset: 0x1062E20 VA: 0x181063A20
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1063B90 Offset: 0x1062F90 VA: 0x181063B90
	public void .ctor() { }

}

public class CC_BrightnessContrastGamma : CC_Base // TypeDefIndex: 8038
{	// Fields
	public float redCoeff; // 0x28
	public float greenCoeff; // 0x2C
	public float blueCoeff; // 0x30
	public float brightness; // 0x34
	public float contrast; // 0x38
	public float gamma; // 0x3C

	// Methods

	// RVA: 0x1063BA0 Offset: 0x1062FA0 VA: 0x181063BA0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1063DB0 Offset: 0x10631B0 VA: 0x181063DB0
	public void .ctor() { }

}

public class CC_ChannelMixer : CC_Base // TypeDefIndex: 8039
{	// Fields
	public float redR; // 0x28
	public float redG; // 0x2C
	public float redB; // 0x30
	public float greenR; // 0x34
	public float greenG; // 0x38
	public float greenB; // 0x3C
	public float blueR; // 0x40
	public float blueG; // 0x44
	public float blueB; // 0x48
	public float constantR; // 0x4C
	public float constantG; // 0x50
	public float constantB; // 0x54

	// Methods

	// RVA: 0x1063DE0 Offset: 0x10631E0 VA: 0x181063DE0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1064040 Offset: 0x1063440 VA: 0x181064040
	public void .ctor() { }

}

public class CC_Convolution3x3 : CC_Base // TypeDefIndex: 8040
{	// Fields
	public Vector3 kernelTop; // 0x28
	public Vector3 kernelMiddle; // 0x34
	public Vector3 kernelBottom; // 0x40
	public float divisor; // 0x4C
	public float amount; // 0x50

	// Methods

	// RVA: 0x1064060 Offset: 0x1063460 VA: 0x181064060
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1064370 Offset: 0x1063770 VA: 0x181064370
	public void .ctor() { }

}

public class CC_CrossStitch : CC_Base // TypeDefIndex: 8041
{	// Fields
	public int size; // 0x28
	public float brightness; // 0x2C
	public bool invert; // 0x30
	public bool pixelize; // 0x31

	// Methods

	// RVA: 0x1064420 Offset: 0x1063820 VA: 0x181064420
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1064600 Offset: 0x1063A00 VA: 0x181064600
	public void .ctor() { }

}

public class CC_DoubleVision : CC_Base, IImageEffect // TypeDefIndex: 8042
{	// Fields
	public Vector2 displace; // 0x28
	public float amount; // 0x30

	// Methods

	// RVA: 0x1064620 Offset: 0x1063A20 VA: 0x181064620 Slot: 6
	public bool IsActive() { }

	// RVA: 0x1064660 Offset: 0x1063A60 VA: 0x181064660 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1064820 Offset: 0x1063C20 VA: 0x181064820
	public void .ctor() { }

}

public class CC_FastVignette : CC_Base // TypeDefIndex: 8043
{	// Fields
	public float sharpness; // 0x28
	public float darkness; // 0x2C
	public bool desaturate; // 0x30

	// Methods

	// RVA: 0x1064870 Offset: 0x1063C70 VA: 0x181064870
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1064980 Offset: 0x1063D80 VA: 0x181064980
	public void .ctor() { }

}

public class CC_Frost : CC_Base, IImageEffect // TypeDefIndex: 8044
{	// Fields
	public float scale; // 0x28
	public float sharpness; // 0x2C
	public float darkness; // 0x30
	public bool enableVignette; // 0x34

	// Methods

	// RVA: 0x10649A0 Offset: 0x1063DA0 VA: 0x1810649A0 Slot: 6
	public bool IsActive() { }

	// RVA: 0x10649E0 Offset: 0x1063DE0 VA: 0x1810649E0 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1064B70 Offset: 0x1063F70 VA: 0x181064B70
	public void .ctor() { }

}

public class CC_GradientRamp : CC_Base // TypeDefIndex: 8045
{	// Fields
	public Texture rampTexture; // 0x28
	public float amount; // 0x30

	// Methods

	// RVA: 0x1064B90 Offset: 0x1063F90 VA: 0x181064B90
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1063B90 Offset: 0x1062F90 VA: 0x181063B90
	public void .ctor() { }

}

public class CC_Grayscale : CC_Base, IImageEffect // TypeDefIndex: 8046
{	// Fields
	public float redLuminance; // 0x28
	public float greenLuminance; // 0x2C
	public float blueLuminance; // 0x30
	public float amount; // 0x34

	// Methods

	// RVA: 0x1064CF0 Offset: 0x10640F0 VA: 0x181064CF0 Slot: 6
	public bool IsActive() { }

	// RVA: 0x1064D30 Offset: 0x1064130 VA: 0x181064D30 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1064E80 Offset: 0x1064280 VA: 0x181064E80
	public void .ctor() { }

}

public class CC_Halftone : CC_Base // TypeDefIndex: 8047
{	// Fields
	public float density; // 0x28
	public int mode; // 0x2C
	public bool antialiasing; // 0x30
	public bool showOriginal; // 0x31

	// Methods

	// RVA: 0x1064EB0 Offset: 0x10642B0 VA: 0x181064EB0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1064FB0 Offset: 0x10643B0 VA: 0x181064FB0
	public void .ctor() { }

}

public class CC_HueSaturationValue : CC_Base // TypeDefIndex: 8048
{	// Fields
	public float hue; // 0x28
	public float saturation; // 0x2C
	public float value; // 0x30

	// Methods

	// RVA: 0x1064FD0 Offset: 0x10643D0 VA: 0x181064FD0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class CC_Led : CC_Base // TypeDefIndex: 8049
{	// Fields
	public float scale; // 0x28
	public bool automaticRatio; // 0x2C
	public float ratio; // 0x30
	public float brightness; // 0x34
	public int mode; // 0x38

	// Methods

	// RVA: 0x1065150 Offset: 0x1064550 VA: 0x181065150
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1065310 Offset: 0x1064710 VA: 0x181065310
	public void .ctor() { }

}

public class CC_Levels : CC_Base // TypeDefIndex: 8050
{	// Fields
	public int mode; // 0x28
	public float inputMinL; // 0x2C
	public float inputMaxL; // 0x30
	public float inputGammaL; // 0x34
	public float inputMinR; // 0x38
	public float inputMaxR; // 0x3C
	public float inputGammaR; // 0x40
	public float inputMinG; // 0x44
	public float inputMaxG; // 0x48
	public float inputGammaG; // 0x4C
	public float inputMinB; // 0x50
	public float inputMaxB; // 0x54
	public float inputGammaB; // 0x58
	public float outputMinL; // 0x5C
	public float outputMaxL; // 0x60
	public float outputMinR; // 0x64
	public float outputMaxR; // 0x68
	public float outputMinG; // 0x6C
	public float outputMaxG; // 0x70
	public float outputMinB; // 0x74
	public float outputMaxB; // 0x78

	// Methods

	// RVA: 0x1065330 Offset: 0x1064730 VA: 0x181065330
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1065800 Offset: 0x1064C00 VA: 0x181065800
	public void .ctor() { }

}

public class CC_LookupFilter : CC_Base // TypeDefIndex: 8051
{	// Fields
	public Texture lookupTexture; // 0x28

	// Methods

	// RVA: 0x1065860 Offset: 0x1064C60 VA: 0x181065860
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class CC_Negative : CC_Base // TypeDefIndex: 8052
{	// Fields
	public float amount; // 0x28

	// Methods

	// RVA: 0x1065980 Offset: 0x1064D80 VA: 0x181065980
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0xA11CA0 Offset: 0xA110A0 VA: 0x180A11CA0
	public void .ctor() { }

}

public class CC_PhotoFilter : CC_Base, IImageEffect // TypeDefIndex: 8053
{	// Fields
	public Color color; // 0x28
	public float density; // 0x38

	// Methods

	// RVA: 0x1065A80 Offset: 0x1064E80 VA: 0x181065A80 Slot: 6
	public bool IsActive() { }

	// RVA: 0x1065AC0 Offset: 0x1064EC0 VA: 0x181065AC0 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1065BF0 Offset: 0x1064FF0 VA: 0x181065BF0
	public void .ctor() { }

}

public class CC_Pixelate : CC_Base // TypeDefIndex: 8054
{	// Fields
	public float scale; // 0x28
	public bool automaticRatio; // 0x2C
	public float ratio; // 0x30
	public int mode; // 0x34

	// Methods

	// RVA: 0x1065C60 Offset: 0x1065060 VA: 0x181065C60
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1065E00 Offset: 0x1065200 VA: 0x181065E00
	public void .ctor() { }

}

public class CC_Posterize : CC_Base // TypeDefIndex: 8055
{	// Fields
	public int levels; // 0x28

	// Methods

	// RVA: 0x1065E20 Offset: 0x1065220 VA: 0x181065E20
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1065ED0 Offset: 0x10652D0 VA: 0x181065ED0
	public void .ctor() { }

}

public class CC_RGBSplit : CC_Base // TypeDefIndex: 8056
{	// Fields
	public float amount; // 0x28
	public float angle; // 0x2C

	// Methods

	// RVA: 0x1065EE0 Offset: 0x10652E0 VA: 0x181065EE0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class CC_RadialBlur : CC_Base // TypeDefIndex: 8057
{	// Fields
	public float amount; // 0x28
	public Vector2 center; // 0x2C
	public int quality; // 0x34

	// Methods

	// RVA: 0x1066080 Offset: 0x1065480 VA: 0x181066080
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1066200 Offset: 0x1065600 VA: 0x181066200
	public void .ctor() { }

}

public class CC_Sharpen : CC_Base // TypeDefIndex: 8058
{	// Fields
	public float strength; // 0x28
	public float clamp; // 0x2C

	// Methods

	// RVA: 0x1066530 Offset: 0x1065930 VA: 0x181066530
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x10666F0 Offset: 0x1065AF0 VA: 0x1810666F0
	public void .ctor() { }

}

public class CC_SharpenAndVignette : CC_Base, IImageEffect // TypeDefIndex: 8059
{	// Fields
	[HeaderAttribute] // RVA: 0xC3900 Offset: 0xC2D00 VA: 0x1800C3900
	public bool applySharpen; // 0x28
	[RangeAttribute] // RVA: 0x75910 Offset: 0x74D10 VA: 0x180075910
	public float strength; // 0x2C
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float clamp; // 0x30
	[HeaderAttribute] // RVA: 0xC4E20 Offset: 0xC4220 VA: 0x1800C4E20
	public bool applyVignette; // 0x34
	[RangeAttribute] // RVA: 0xC4F20 Offset: 0xC4320 VA: 0x1800C4F20
	public float sharpness; // 0x38
	[RangeAttribute] // RVA: 0x77CA0 Offset: 0x770A0 VA: 0x180077CA0
	public float darkness; // 0x3C

	// Methods

	// RVA: 0x8C5D70 Offset: 0x8C5170 VA: 0x1808C5D70 Slot: 6
	public bool IsActive() { }

	// RVA: 0x1066260 Offset: 0x1065660 VA: 0x181066260 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1066500 Offset: 0x1065900 VA: 0x181066500
	public void .ctor() { }

}

public class CC_Threshold : CC_Base // TypeDefIndex: 8060
{	// Fields
	public float threshold; // 0x28
	public bool useNoise; // 0x2C
	public float noiseRange; // 0x30

	// Methods

	// RVA: 0x1066710 Offset: 0x1065B10 VA: 0x181066710
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1066820 Offset: 0x1065C20 VA: 0x181066820
	public void .ctor() { }

}

public class CC_Vibrance : CC_Base // TypeDefIndex: 8061
{	// Fields
	public float amount; // 0x28

	// Methods

	// RVA: 0x1066840 Offset: 0x1065C40 VA: 0x181066840
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class CC_Wiggle : CC_Base, IImageEffect // TypeDefIndex: 8062
{	// Fields
	public float timer; // 0x28
	public float speed; // 0x2C
	public float scale; // 0x30

	// Methods

	// RVA: 0x1066A60 Offset: 0x1065E60 VA: 0x181066A60
	private void Update() { }

	// RVA: 0x1064620 Offset: 0x1063A20 VA: 0x181064620 Slot: 6
	public bool IsActive() { }

	// RVA: 0x1066940 Offset: 0x1065D40 VA: 0x181066940 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1066AB0 Offset: 0x1065EB0 VA: 0x181066AB0
	public void .ctor() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 8239
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19552 1DC4C1B55DC0F7A09DD49557857282243A661721 /*Metadata offset 0x557370*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420 4D97B7EA75C57A5C53C1E01B1C6253465DE43B65 /*Metadata offset 0x55BFD0*/; // 0x4C60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 9B733B2872507920FB43A4A60F4CBE3E17200C8C /*Metadata offset 0x55C174*/; // 0x4E04
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 C01F4A345A0DC451B12954EDA4ED605D0075A2A5 /*Metadata offset 0x55FF76*/; // 0x8C06
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD09230AEF3C2384FBC6D4B1BC4EADBE9911368E /*Metadata offset 0x563D78*/; // 0xCA08
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9776 F2AB9A53871DA3CF4444B73A4D38E5580D8F8ED3 /*Metadata offset 0x563DAC*/; // 0xCA3C

}

internal sealed class <>f__AnonymousType0<<Identifier>j__TPar, <Name>j__TPar, <State>j__TPar> // TypeDefIndex: 8246
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420 // TypeDefIndex: 8241

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9776 // TypeDefIndex: 8242

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 // TypeDefIndex: 8243

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19552 // TypeDefIndex: 8244

// Namespace: 
internal class <Module> // TypeDefIndex: 8245

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
internal sealed class <>f__AnonymousType0<<Identifier>j__TPar, <Name>j__TPar, <State>j__TPar> // TypeDefIndex: 8246
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x9E7F0 Offset: 0x9DBF0 VA: 0x18009E7F0
	private readonly <Identifier>j__TPar <Identifier>i__Field; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x9E7F0 Offset: 0x9DBF0 VA: 0x18009E7F0
	private readonly <Name>j__TPar <Name>i__Field; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x9E7F0 Offset: 0x9DBF0 VA: 0x18009E7F0
	private readonly <State>j__TPar <State>i__Field; // 0x0

	// Properties
	public <Identifier>j__TPar Identifier { get; }
	public <Name>j__TPar Name { get; }
	public <State>j__TPar State { get; }

	// Methods

	// RVA: -1 Offset: -1
	public <Identifier>j__TPar get_Identifier() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	|-<>f__AnonymousType0<object, object, bool>.get_Identifier
	|-<>f__AnonymousType0<object, object, object>.get_Identifier
	*/

	// RVA: -1 Offset: -1
	public <Name>j__TPar get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-<>f__AnonymousType0<object, object, bool>.get_Name
	|-<>f__AnonymousType0<object, object, object>.get_Name
	*/

	// RVA: -1 Offset: -1
	public <State>j__TPar get_State() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	|-<>f__AnonymousType0<object, object, bool>.get_State
	|
	|-RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	|-<>f__AnonymousType0<object, object, object>.get_State
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(<Identifier>j__TPar Identifier, <Name>j__TPar Name, <State>j__TPar State) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E4C30 Offset: 0x15E4030 VA: 0x1815E4C30
	|-<>f__AnonymousType0<object, object, bool>..ctor
	|-<>f__AnonymousType0<string, string, bool>..ctor
	|
	|-RVA: 0x15E4CA0 Offset: 0x15E40A0 VA: 0x1815E4CA0
	|-<>f__AnonymousType0<object, object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E4560 Offset: 0x15E3960 VA: 0x1815E4560
	|-<>f__AnonymousType0<object, object, bool>.Equals
	|
	|-RVA: 0x15E4440 Offset: 0x15E3840 VA: 0x1815E4440
	|-<>f__AnonymousType0<object, object, object>.Equals
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E4680 Offset: 0x15E3A80 VA: 0x1815E4680
	|-<>f__AnonymousType0<object, object, bool>.GetHashCode
	|
	|-RVA: 0x15E4770 Offset: 0x15E3B70 VA: 0x1815E4770
	|-<>f__AnonymousType0<object, object, object>.GetHashCode
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E4860 Offset: 0x15E3C60 VA: 0x1815E4860
	|-<>f__AnonymousType0<object, object, bool>.ToString
	|
	|-RVA: 0x15E4A40 Offset: 0x15E3E40 VA: 0x1815E4A40
	|-<>f__AnonymousType0<object, object, object>.ToString
	*/

}

public class v_chainsaw : MonoBehaviour // TypeDefIndex: 8896
{	// Fields
	public bool bAttacking; // 0x18
	public bool bHitMetal; // 0x19
	public bool bHitWood; // 0x1A
	public bool bHitFlesh; // 0x1B
	public bool bEngineOn; // 0x1C
	public ParticleSystem[] hitMetalFX; // 0x20
	public ParticleSystem[] hitWoodFX; // 0x28
	public ParticleSystem[] hitFleshFX; // 0x30
	public SoundDefinition hitMetalSoundDef; // 0x38
	public SoundDefinition hitWoodSoundDef; // 0x40
	public SoundDefinition hitFleshSoundDef; // 0x48
	public Sound hitSound; // 0x50
	public GameObject hitSoundTarget; // 0x58
	public float hitSoundFadeTime; // 0x60
	public ParticleSystem smokeEffect; // 0x68
	public Animator chainsawAnimator; // 0x70
	public Renderer chainRenderer; // 0x78
	public Material chainlink; // 0x80
	private MaterialPropertyBlock block; // 0x88
	private Vector2 saveST; // 0x90
	private float chainSpeed; // 0x98
	private float chainAmount; // 0x9C
	public float temp1; // 0xA0
	public float temp2; // 0xA4

	// Methods

	// RVA: 0x1A9D4D0 Offset: 0x1A9C8D0 VA: 0x181A9D4D0
	public void OnEnable() { }

	// RVA: 0x1A9D310 Offset: 0x1A9C710 VA: 0x181A9D310
	private void Awake() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void Start() { }

	// RVA: 0x1A9D5E0 Offset: 0x1A9C9E0 VA: 0x181A9D5E0
	private void ScrollChainTexture() { }

	// RVA: 0x1A9D6F0 Offset: 0x1A9CAF0 VA: 0x181A9D6F0
	private void Update() { }

	// RVA: 0x1A9D350 Offset: 0x1A9C750 VA: 0x181A9D350
	private void DoHitSound(SoundDefinition soundDef) { }

	// RVA: 0x1A9DC60 Offset: 0x1A9D060 VA: 0x181A9DC60
	public void .ctor() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 12149
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 12149
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 08A598D3DC7ED63443A0CAF087F7CDF5BAA67E3D /*Metadata offset 0x569E60*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 0ED907628EE272F93737B500A23D77C9B1C88368 /*Metadata offset 0x569E78*/; // 0x18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 17ADC9F18EEFE619644F7B3C7C90D5FD8DCDE2BB /*Metadata offset 0x569E8C*/; // 0x2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 1C910D34886830DDE4A52B59726EB240ADBF9F34 /*Metadata offset 0x569EA8*/; // 0x48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2277B245F935EBA3EA2D03B6871C13871FD4D572 /*Metadata offset 0x569EAE*/; // 0x4E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 24F287DA5BA36E31C3946E2FBE95B8388C241662 /*Metadata offset 0x569EBE*/; // 0x5E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 386DD6935C2F38BB8114CA4DF96C8BC2D3E639DA /*Metadata offset 0x569ED6*/; // 0x76
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 42A4001D1CFDC98C761C0CFE5497A75F739D92F8 /*Metadata offset 0x569EE2*/; // 0x82
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 43A214299CEA27B6A55E61A929FC7B62C5D4941E /*Metadata offset 0x569EEE*/; // 0x8E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 44D235DAFB9C469EBDA7640EB1F2CC833B40E9E5 /*Metadata offset 0x56A6EE*/; // 0x88E
	internal static readonly long 4CAECE539B039B16E16206EA2478F8C5FFB2CA05 = 727905341920923785; // 0x8D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 59E933D7501F1D8F431F5807AC6C357BBA5F2D58 /*Metadata offset 0x56A736*/; // 0x8D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 6B8D5CC14D2709C84958ED5E3855C874DA314CB4 /*Metadata offset 0x56A74E*/; // 0x8F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6BA637A252B6BFA8895B67AD72DCCAE79715984C /*Metadata offset 0x56A84E*/; // 0x9F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=80 6DBA8D05A3CD51B9E01E83FDDF49241693E5D4E4 /*Metadata offset 0x56A88E*/; // 0xA30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 843D396E2EE569B035A7AC2BEB7A8253FC4AEDA7 /*Metadata offset 0x56A8DE*/; // 0xA80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 9365FDAD4BD75AEF9446E0B22483D217BE36E309 /*Metadata offset 0x56A8EA*/; // 0xA8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 9EFF88EB2F3540C5CE20FEF36A8E3AA37629AF80 /*Metadata offset 0x56A902*/; // 0xAA4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 B9B198B061D08812F585C9E56641F4E897E88E38 /*Metadata offset 0x56AA22*/; // 0xBC4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 C18072E27FC2B4816C8694EB22427195375388F0 /*Metadata offset 0x56AA2E*/; // 0xBD0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 C7F420F4B2F68D0B3647564554BA8DB99509F64F /*Metadata offset 0x56AA66*/; // 0xC08
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 D950356082C70AD4018410AD313BA99D655D4D4A /*Metadata offset 0x56AA82*/; // 0xC24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 E3D5EABE71635FCDE2C05162A6CDE245A9796318 /*Metadata offset 0x56AA8E*/; // 0xC30
	internal static readonly long FCBA60311CDE80DE090AE6F8834C9CEC477FA56A = 5927942488114331648; // 0xCB0

	// Methods

	// RVA: 0xAA6880 Offset: 0xAA5C80 VA: 0x180AA6880
	internal static uint ComputeStringHash(string s) { }

}

