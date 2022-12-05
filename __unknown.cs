internal sealed class <>f__AnonymousType0<<message>j__TPar> // TypeDefIndex: 1
{

[CompilerGeneratedAttribute]
internal sealed class <>f__AnonymousType0<<message>j__TPar>
	[DebuggerBrowsableAttribute]
	private readonly <message>j__TPar <message>i__Field;


	[DebuggerHiddenAttribute]
	public void .ctor(<message>j__TPar message) { }
	/* GenericInstMethod :
	|
	|-<>f__AnonymousType0<object>..ctor
	|-<>f__AnonymousType0<string>..ctor
	*/

	[DebuggerHiddenAttribute]
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-<>f__AnonymousType0<object>.Equals
	*/

	[DebuggerHiddenAttribute]
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-<>f__AnonymousType0<object>.GetHashCode
	*/

	[DebuggerHiddenAttribute]
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-<>f__AnonymousType0<object>.ToString
	*/

}

internal class __Filters // TypeDefIndex: 143
{
	internal static readonly __Filters Instance;


	internal virtual bool FilterAttribute(MemberInfo m, object filterCriteria) { }

	internal virtual bool FilterName(MemberInfo m, object filterCriteria) { }

	internal virtual bool FilterIgnoreCase(MemberInfo m, object filterCriteria) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public sealed class Func<TResult> : MulticastDelegate // TypeDefIndex: 155
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
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
	|-Func<Task>..ctor
	|-Func<Task<Stream>>..ctor
	|-Func<Task<WebResponse>>..ctor
	|-Func<VoidTaskResult>..ctor
	*/

	public virtual TResult Invoke() { }
	/* GenericInstMethod :
	|
	|-Func<JsonSerializerSettings>.Invoke
	|-Func<IReferenceResolver>.Invoke
	|-Func<string>.Invoke
	|-Func<object>.Invoke
	|
	|-Func<bool>.Invoke
	|-Func<byte>.Invoke
	|-Func<VoidTaskResult>.Invoke
	|
	|-Func<int>.Invoke
	|
	|-Func<PublishResult>.Invoke
	|-Func<Nullable<Image>>.Invoke
	|
	|-Func<UdpReceiveResult>.Invoke
	|
	|-Func<Nullable<ServerInfo>>.Invoke
	|
	|-Func<Nullable<InventoryPurchaseResult>>.Invoke
	|-Func<Nullable<ResultPage>>.Invoke
	|
	|-Func<Nullable<InventoryResult>>.Invoke
	|
	|-Func<Nullable<Item>>.Invoke
	|
	|-Func<Nullable<int>>.Invoke
	|-Func<Nullable<Int32Enum>>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
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

	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-Func<PublishResult>.EndInvoke
	|-Func<Nullable<Image>>.EndInvoke
	|
	|-Func<bool>.EndInvoke
	|-Func<byte>.EndInvoke
	|-Func<VoidTaskResult>.EndInvoke
	|
	|-Func<int>.EndInvoke
	|
	|-Func<UdpReceiveResult>.EndInvoke
	|
	|-Func<Nullable<ServerInfo>>.EndInvoke
	|
	|-Func<Nullable<InventoryPurchaseResult>>.EndInvoke
	|-Func<Nullable<ResultPage>>.EndInvoke
	|
	|-Func<Nullable<InventoryResult>>.EndInvoke
	|
	|-Func<Nullable<Item>>.EndInvoke
	|
	|-Func<Nullable<int>>.EndInvoke
	|-Func<Nullable<Int32Enum>>.EndInvoke
	|
	|-Func<object>.EndInvoke
	*/

}

public sealed class Func<T, TResult> : MulticastDelegate // TypeDefIndex: 156
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-Func<AchievementGroup.AchievementItem, bool>..ctor
	|-Func<BaseEntity, bool>..ctor
	|-Func<BaseNetworkable, Debugging.EntityInfo>..ctor
	|-Func<BaseNetworkable, bool>..ctor
	|-Func<BaseNetworkable, uint>..ctor
	|-Func<BaseOven, bool>..ctor
	|-Func<BaseOven, float>..ctor
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
	|-Func<EntityLink, bool>..ctor
	|-Func<AccountNotice, bool>..ctor
	|-Func<AccountNotice, DateTime>..ctor
	|-Func<BurstCloth.Chain, FourBitNumber>..ctor
	|-Func<BurstCloth.Chain, SevenBitNumber>..ctor
	|-Func<BurstCloth.Chain, bool>..ctor
	|-Func<BurstCloth.Chain, int>..ctor
	|-Func<CardPlayerData, bool>..ctor
	|-Func<PlayingCard, bool>..ctor
	|-Func<Hero, Guid>..ctor
	|-Func<Input.Button, bool>..ctor
	|-Func<Input.Button, string>..ctor
	|-Func<Manifest.Administrator, bool>..ctor
	|-Func<Manifest.NewsInfo.BlogInfo, string>..ctor
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
	|-Func<GenerateDungeonBase.DungeonSegment, bool>..ctor
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
	|-Func<OvenItemIcon.OvenSlotConfig, bool>..ctor
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
	|-Func<byte[], bool>..ctor
	|-Func<byte[], IEnumerable<byte>>..ctor
	|-Func<byte[], int>..ctor
	|-Func<char, bool>..ctor
	|-Func<DictionaryEntry, bool>..ctor
	|-Func<DictionaryEntry, KeyValuePair<object, object>>..ctor
	|-Func<DictionaryEntry, object>..ctor
	|-Func<KeyValuePair<IntPtr, Helper.DelegateHolder>, bool>..ctor
	|-Func<KeyValuePair<IntPtr, object>, bool>..ctor
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
	|-Func<Delegate, bool>..ctor
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
	|-Func<GameObject, BaseOven>..ctor
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

	public virtual TResult Invoke(T arg) { }
	/* GenericInstMethod :
	|
	|-Func<Entity.EntityInfo, bool>.Invoke
	|-Func<ItemSkinDirectory.Skin, bool>.Invoke
	|-Func<Option, bool>.Invoke
	|-Func<SkinnedMultiMesh.Part, bool>.Invoke
	|-Func<InventoryItem, FourBitNumber>.Invoke
	|-Func<InventoryItem, SevenBitNumber>.Invoke
	|-Func<InventoryItem, bool>.Invoke
	|
	|-Func<Item, bool>.Invoke
	|-Func<Exception, bool>.Invoke
	|-Func<SimpleAsyncResult, bool>.Invoke
	|-Func<string, bool>.Invoke
	|-Func<object, FourBitNumber>.Invoke
	|-Func<object, SevenBitNumber>.Invoke
	|-Func<object, bool>.Invoke
	|-Func<object, VoidTaskResult>.Invoke
	|
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
	|-Func<int, int>.Invoke
	|-Func<Int32Enum, int>.Invoke
	|-Func<Int32Enum, Int32Enum>.Invoke
	|
	|-Func<int, float>.Invoke
	|-Func<Int32Enum, float>.Invoke
	|
	|-Func<object, string>.Invoke
	|-Func<object[], JsonConverter>.Invoke
	|-Func<string, string>.Invoke
	|-Func<string, GameObject>.Invoke
	|-Func<object, object>.Invoke
	|-Func<AssemblyName, Assembly>.Invoke
	|
	|-Func<ulong, bool>.Invoke
	|-Func<long, bool>.Invoke
	|
	|-Func<ILayoutElement, float>.Invoke
	|-Func<object, float>.Invoke
	|
	|-Func<NativeInputUpdateType, bool>.Invoke
	|-Func<int, bool>.Invoke
	|-Func<Int32Enum, bool>.Invoke
	|
	|-Func<Admin.PlayerInfo, object>.Invoke
	|
	|-Func<Admin.ServerConvarInfo, object>.Invoke
	|-Func<InventoryRecipe, object>.Invoke
	|-Func<InventoryRecipe.Ingredient, long>.Invoke
	|-Func<InventoryRecipe.Ingredient, object>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.Invoke
	|
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
	|-Func<Debugging.EntityInfo, bool>.Invoke
	|-Func<RCon.BannedAddresses, bool>.Invoke
	|-Func<WeightedStringList.Container, bool>.Invoke
	|-Func<GameStat.Stat, bool>.Invoke
	|-Func<PlayerItemRecipe, bool>.Invoke
	|-Func<DictionaryEntry, bool>.Invoke
	|-Func<KeyValuePair<IntPtr, object>, bool>.Invoke
	|-Func<KeyValuePair<object, int>, bool>.Invoke
	|-Func<KeyValuePair<object, object>, bool>.Invoke
	|-Func<KeyValuePair<uint, object>, bool>.Invoke
	|
	|-Func<Demos.DemoInfo, DateTime>.Invoke
	|-Func<Demos.DemoInfo, TimeSpan>.Invoke
	|-Func<InventoryItem, PathFinder.Point>.Invoke
	|-Func<InventoryItem, InventoryItemId>.Invoke
	|
	|-Func<Demos.DemoInfo, object>.Invoke
	|-Func<SkinnedMultiMesh.Part, long>.Invoke
	|-Func<InventoryItem, long>.Invoke
	|-Func<InventoryItem, object>.Invoke
	|
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
	|-Func<BurstCloth.Chain, int>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, int>.Invoke
	|
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.Invoke
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Invoke
	|
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.Invoke
	|-Func<InventoryItem.Amount, InventoryItemId>.Invoke
	|
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<SkeletonDefinition.Bone, Resolution>.Invoke
	|
	|-Func<SkeletonDefinition.Bone, Option>.Invoke
	|-Func<SkeletonDefinition.Bone, InventoryItem>.Invoke
	|
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Invoke
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.Invoke
	|
	|-Func<SkeletonDefinition.Bone, bool>.Invoke
	|-Func<InventoryItem.Amount, bool>.Invoke
	|
	|-Func<SkeletonDefinition.Bone, int>.Invoke
	|-Func<SkeletonDefinition.Bone, Int32Enum>.Invoke
	|
	|-Func<SkeletonDefinition.Bone, long>.Invoke
	|-Func<SkeletonDefinition.Bone, object>.Invoke
	|
	|-Func<SkeletonDefinition.Bone, float>.Invoke
	|
	|-Func<WeightedStringList.Container, float>.Invoke
	|-Func<PlayerItemRecipe, float>.Invoke
	|-Func<KeyValuePair<object, object>, float>.Invoke
	|-Func<KeyValuePair<uint, object>, float>.Invoke
	|
	|-Func<FourBitNumber, FourBitNumber>.Invoke
	|-Func<FourBitNumber, bool>.Invoke
	|-Func<SevenBitNumber, SevenBitNumber>.Invoke
	|-Func<SevenBitNumber, bool>.Invoke
	|
	|-Func<SevenBitNumber, object>.Invoke
	|
	|-Func<PathFinder.Point, PathFinder.Point>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Invoke
	|-Func<Achievement, PathFinder.Point>.Invoke
	|-Func<InventoryItemId, InventoryItemId>.Invoke
	|-Func<Friend, PathFinder.Point>.Invoke
	|
	|-Func<PetCommandList.PetCommandDesc, bool>.Invoke
	|
	|-Func<PlayerItemRecipe, PathFinder.Point>.Invoke
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.Invoke
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.Invoke
	|
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<PlayerItemRecipe, Resolution>.Invoke
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<KeyValuePair<object, object>, Resolution>.Invoke
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<KeyValuePair<uint, object>, Resolution>.Invoke
	|
	|-Func<PlayerItemRecipe, Option>.Invoke
	|-Func<PlayerItemRecipe, InventoryItem>.Invoke
	|-Func<KeyValuePair<object, object>, Option>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryItem>.Invoke
	|-Func<KeyValuePair<uint, object>, Option>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryItem>.Invoke
	|
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.Invoke
	|-Func<PlayerItemRecipe, InventoryRecipe>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.Invoke
	|
	|-Func<PlayerItemRecipe, int>.Invoke
	|-Func<PlayerItemRecipe, Int32Enum>.Invoke
	|-Func<KeyValuePair<object, object>, int>.Invoke
	|-Func<KeyValuePair<object, object>, Int32Enum>.Invoke
	|-Func<KeyValuePair<uint, object>, int>.Invoke
	|-Func<KeyValuePair<uint, object>, Int32Enum>.Invoke
	|
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Resolution, Resolution>.Invoke
	|
	|-Func<ProjectileWeaponMod.Modifier, bool>.Invoke
	|-Func<Resolution, bool>.Invoke
	|
	|-Func<ProjectileWeaponMod.Modifier, float>.Invoke
	|
	|-Func<Option, Option>.Invoke
	|-Func<InventoryItem, Option>.Invoke
	|-Func<InventoryItem, InventoryItem>.Invoke
	|
	|-Func<ServerInfo, Debugging.EntityInfo>.Invoke
	|-Func<ServerInfo, KeyValuePair<object, int>>.Invoke
	|
	|-Func<ServerInfo, FourBitNumber>.Invoke
	|-Func<ServerInfo, SevenBitNumber>.Invoke
	|-Func<ServerInfo, bool>.Invoke
	|-Func<ServerInfo, bool>.Invoke
	|
	|-Func<ServerInfo, PathFinder.Point>.Invoke
	|
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<ServerInfo, Resolution>.Invoke
	|
	|-Func<ServerInfo, Option>.Invoke
	|-Func<ServerInfo, InventoryItem>.Invoke
	|
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.Invoke
	|-Func<ServerInfo, InventoryRecipe>.Invoke
	|
	|-Func<ServerInfo, int>.Invoke
	|-Func<ServerInfo, Int32Enum>.Invoke
	|
	|-Func<ServerInfo, long>.Invoke
	|-Func<ServerInfo, object>.Invoke
	|-Func<ServerInfo, object>.Invoke
	|
	|-Func<ServerInfo, float>.Invoke
	|
	|-Func<ServerInfo, uint>.Invoke
	|-Func<ServerInfo, int>.Invoke
	|
	|-Func<Achievement, Debugging.EntityInfo>.Invoke
	|-Func<Achievement, KeyValuePair<object, int>>.Invoke
	|-Func<Friend, Debugging.EntityInfo>.Invoke
	|-Func<Friend, KeyValuePair<object, int>>.Invoke
	|
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Achievement, Resolution>.Invoke
	|-Func<Friend, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Friend, Resolution>.Invoke
	|
	|-Func<Achievement, Option>.Invoke
	|-Func<Achievement, InventoryItem>.Invoke
	|-Func<Friend, Option>.Invoke
	|-Func<Friend, InventoryItem>.Invoke
	|
	|-Func<Achievement, InventoryRecipe.Ingredient>.Invoke
	|-Func<Achievement, InventoryRecipe>.Invoke
	|-Func<Friend, InventoryRecipe.Ingredient>.Invoke
	|-Func<Friend, InventoryRecipe>.Invoke
	|
	|-Func<Achievement, int>.Invoke
	|-Func<Achievement, Int32Enum>.Invoke
	|-Func<Friend, int>.Invoke
	|-Func<Friend, Int32Enum>.Invoke
	|
	|-Func<Achievement, long>.Invoke
	|-Func<Achievement, object>.Invoke
	|-Func<Friend, long>.Invoke
	|-Func<Friend, object>.Invoke
	|-Func<ValueTuple<Int32Enum, int>, object>.Invoke
	|
	|-Func<Achievement, float>.Invoke
	|-Func<Friend, float>.Invoke
	|
	|-Func<InventoryDefId, Debugging.EntityInfo>.Invoke
	|-Func<InventoryDefId, KeyValuePair<object, int>>.Invoke
	|
	|-Func<InventoryDefId, PathFinder.Point>.Invoke
	|
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryDefId, Resolution>.Invoke
	|
	|-Func<InventoryDefId, Option>.Invoke
	|-Func<InventoryDefId, InventoryItem>.Invoke
	|
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryDefId, InventoryRecipe>.Invoke
	|
	|-Func<InventoryDefId, bool>.Invoke
	|
	|-Func<InventoryDefId, int>.Invoke
	|-Func<InventoryDefId, Int32Enum>.Invoke
	|
	|-Func<InventoryDefId, long>.Invoke
	|-Func<InventoryDefId, object>.Invoke
	|
	|-Func<InventoryDefId, float>.Invoke
	|
	|-Func<ServerInfo, ServerInfo>.Invoke
	|
	|-Func<InventoryItem, Debugging.EntityInfo>.Invoke
	|-Func<InventoryItem, KeyValuePair<object, int>>.Invoke
	|
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryItem, Resolution>.Invoke
	|
	|-Func<InventoryItem, InventoryDefId>.Invoke
	|-Func<InventoryItem, uint>.Invoke
	|
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryItem, InventoryRecipe>.Invoke
	|
	|-Func<InventoryItem, int>.Invoke
	|-Func<InventoryItem, Int32Enum>.Invoke
	|
	|-Func<InventoryItem, float>.Invoke
	|
	|-Func<InventoryItem.Amount, uint>.Invoke
	|
	|-Func<InventoryRecipe, PlayerItemRecipe>.Invoke
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Invoke
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.Invoke
	|
	|-Func<InventoryRecipe, InventoryRecipe>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.Invoke
	|
	|-Func<InventoryRecipe, bool>.Invoke
	|-Func<InventoryRecipe.Ingredient, bool>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.Invoke
	|
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.Invoke
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Invoke
	|
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryRecipe.Ingredient, Resolution>.Invoke
	|
	|-Func<InventoryRecipe.Ingredient, Option>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.Invoke
	|
	|-Func<InventoryRecipe.Ingredient, int>.Invoke
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.Invoke
	|
	|-Func<InventoryRecipe.Ingredient, float>.Invoke
	|
	|-Func<Item, DateTime>.Invoke
	|
	|-Func<char, bool>.Invoke
	|
	|-Func<KeyValuePair<object, int>, int>.Invoke
	|-Func<KeyValuePair<uint, object>, uint>.Invoke
	|-Func<Guid, int>.Invoke
	|
	|-Func<double, double>.Invoke
	|
	|-Func<int, FourBitNumber>.Invoke
	|-Func<int, SevenBitNumber>.Invoke
	|-Func<uint, bool>.Invoke
	|
	|-Func<int, object>.Invoke
	|-Func<Int32Enum, object>.Invoke
	|
	|-Func<Int32Enum, Debugging.EntityInfo>.Invoke
	|-Func<Int32Enum, KeyValuePair<object, int>>.Invoke
	|
	|-Func<Int32Enum, PathFinder.Point>.Invoke
	|
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Int32Enum, Resolution>.Invoke
	|
	|-Func<Int32Enum, Option>.Invoke
	|-Func<Int32Enum, InventoryItem>.Invoke
	|
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.Invoke
	|-Func<Int32Enum, InventoryRecipe>.Invoke
	|
	|-Func<Int32Enum, long>.Invoke
	|
	|-Func<long, long>.Invoke
	|-Func<ulong, ulong>.Invoke
	|
	|-Func<IntPtr, object>.Invoke
	|
	|-Func<object, Debugging.EntityInfo>.Invoke
	|-Func<object, PlayerItemRecipe>.Invoke
	|-Func<object, KeyValuePair<object, int>>.Invoke
	|-Func<object, DateTimeOffset>.Invoke
	|-Func<object, Guid>.Invoke
	|-Func<object, UdpReceiveResult>.Invoke
	|
	|-Func<object, PathFinder.Point>.Invoke
	|-Func<object, PlayerItemRecipe.Ingredient>.Invoke
	|-Func<object, InventoryItemId>.Invoke
	|-Func<object, DateTime>.Invoke
	|-Func<object, Nullable<int>>.Invoke
	|-Func<object, Nullable<Int32Enum>>.Invoke
	|
	|-Func<object, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<object, Nullable<InventoryResult>>.Invoke
	|-Func<object, Resolution>.Invoke
	|
	|-Func<object, Option>.Invoke
	|-Func<object, InventoryItem>.Invoke
	|-Func<object, Nullable<InventoryPurchaseResult>>.Invoke
	|-Func<object, Nullable<ResultPage>>.Invoke
	|
	|-Func<object, InventoryDefId>.Invoke
	|-Func<object, uint>.Invoke
	|
	|-Func<object, InventoryRecipe.Ingredient>.Invoke
	|-Func<object, InventoryRecipe>.Invoke
	|-Func<object, PublishResult>.Invoke
	|-Func<object, Nullable<Image>>.Invoke
	|
	|-Func<object, int>.Invoke
	|-Func<object, Int32Enum>.Invoke
	|
	|-Func<object, long>.Invoke
	|-Func<object, ulong>.Invoke
	|
	|-Func<object, Nullable<ServerInfo>>.Invoke
	|
	|-Func<object, Nullable<Item>>.Invoke
	|
	|-Func<float, bool>.Invoke
	|
	|-Func<float, float>.Invoke
	|
	|-Func<uint, uint>.Invoke
	|
	|-Func<Resolution, int>.Invoke
	|
	|-Func<Resolution, Vector2Int>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T arg, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-Func<Admin.PlayerInfo, object>.BeginInvoke
	|
	|-Func<Admin.ServerConvarInfo, object>.BeginInvoke
	|
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<Debugging.EntityInfo, bool>.BeginInvoke
	|
	|-Func<Entity.EntityInfo, bool>.BeginInvoke
	|
	|-Func<Demos.DemoInfo, DateTime>.BeginInvoke
	|
	|-Func<Demos.DemoInfo, object>.BeginInvoke
	|
	|-Func<Demos.DemoInfo, TimeSpan>.BeginInvoke
	|
	|-Func<BurstCloth.Chain, FourBitNumber>.BeginInvoke
	|
	|-Func<BurstCloth.Chain, SevenBitNumber>.BeginInvoke
	|
	|-Func<BurstCloth.Chain, bool>.BeginInvoke
	|
	|-Func<BurstCloth.Chain, int>.BeginInvoke
	|
	|-Func<RCon.BannedAddresses, bool>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, Option>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, InventoryItem>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, bool>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, int>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, Int32Enum>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, long>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, object>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, float>.BeginInvoke
	|
	|-Func<SkeletonDefinition.Bone, Resolution>.BeginInvoke
	|
	|-Func<WeightedStringList.Container, bool>.BeginInvoke
	|
	|-Func<WeightedStringList.Container, float>.BeginInvoke
	|
	|-Func<GameStat.Stat, bool>.BeginInvoke
	|
	|-Func<ImageStorageEntity.ImageRequest, object>.BeginInvoke
	|
	|-Func<ItemSkinDirectory.Skin, bool>.BeginInvoke
	|
	|-Func<FourBitNumber, FourBitNumber>.BeginInvoke
	|
	|-Func<FourBitNumber, bool>.BeginInvoke
	|
	|-Func<SevenBitNumber, SevenBitNumber>.BeginInvoke
	|
	|-Func<SevenBitNumber, bool>.BeginInvoke
	|
	|-Func<SevenBitNumber, object>.BeginInvoke
	|
	|-Func<DefaultSerializationBinder.TypeNameKey, object>.BeginInvoke
	|
	|-Func<ConvertUtils.TypeConvertKey, object>.BeginInvoke
	|
	|-Func<PathFinder.Point, PathFinder.Point>.BeginInvoke
	|
	|-Func<PathFinder.Point, bool>.BeginInvoke
	|
	|-Func<PetCommandList.PetCommandDesc, bool>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, PathFinder.Point>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, PlayerItemRecipe>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, Option>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, InventoryItem>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, InventoryRecipe>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, bool>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, int>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, Int32Enum>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, long>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, object>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, float>.BeginInvoke
	|
	|-Func<PlayerItemRecipe, Resolution>.BeginInvoke
	|
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>.BeginInvoke
	|
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>.BeginInvoke
	|
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.BeginInvoke
	|
	|-Func<PlayerItemRecipe.Ingredient, bool>.BeginInvoke
	|
	|-Func<PlayerItemRecipe.Ingredient, int>.BeginInvoke
	|
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<ProjectileWeaponMod.Modifier, bool>.BeginInvoke
	|
	|-Func<ProjectileWeaponMod.Modifier, float>.BeginInvoke
	|
	|-Func<Option, Option>.BeginInvoke
	|
	|-Func<Option, bool>.BeginInvoke
	|
	|-Func<ServerInfo, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<ServerInfo, FourBitNumber>.BeginInvoke
	|
	|-Func<ServerInfo, SevenBitNumber>.BeginInvoke
	|
	|-Func<ServerInfo, PathFinder.Point>.BeginInvoke
	|
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<ServerInfo, Option>.BeginInvoke
	|
	|-Func<ServerInfo, InventoryItem>.BeginInvoke
	|
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-Func<ServerInfo, InventoryRecipe>.BeginInvoke
	|
	|-Func<ServerInfo, bool>.BeginInvoke
	|
	|-Func<ServerInfo, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<ServerInfo, int>.BeginInvoke
	|
	|-Func<ServerInfo, Int32Enum>.BeginInvoke
	|
	|-Func<ServerInfo, long>.BeginInvoke
	|
	|-Func<ServerInfo, object>.BeginInvoke
	|
	|-Func<ServerInfo, float>.BeginInvoke
	|
	|-Func<ServerInfo, uint>.BeginInvoke
	|
	|-Func<ServerInfo, Resolution>.BeginInvoke
	|
	|-Func<SkinnedMultiMesh.Part, bool>.BeginInvoke
	|
	|-Func<SkinnedMultiMesh.Part, long>.BeginInvoke
	|
	|-Func<Achievement, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<Achievement, PathFinder.Point>.BeginInvoke
	|
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<Achievement, Option>.BeginInvoke
	|
	|-Func<Achievement, InventoryItem>.BeginInvoke
	|
	|-Func<Achievement, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-Func<Achievement, InventoryRecipe>.BeginInvoke
	|
	|-Func<Achievement, bool>.BeginInvoke
	|
	|-Func<Achievement, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<Achievement, int>.BeginInvoke
	|
	|-Func<Achievement, Int32Enum>.BeginInvoke
	|
	|-Func<Achievement, long>.BeginInvoke
	|
	|-Func<Achievement, object>.BeginInvoke
	|
	|-Func<Achievement, float>.BeginInvoke
	|
	|-Func<Achievement, Resolution>.BeginInvoke
	|
	|-Func<InventoryDefId, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<InventoryDefId, PathFinder.Point>.BeginInvoke
	|
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<InventoryDefId, Option>.BeginInvoke
	|
	|-Func<InventoryDefId, InventoryItem>.BeginInvoke
	|
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-Func<InventoryDefId, InventoryRecipe>.BeginInvoke
	|
	|-Func<InventoryDefId, bool>.BeginInvoke
	|
	|-Func<InventoryDefId, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<InventoryDefId, int>.BeginInvoke
	|
	|-Func<InventoryDefId, Int32Enum>.BeginInvoke
	|
	|-Func<InventoryDefId, long>.BeginInvoke
	|
	|-Func<InventoryDefId, object>.BeginInvoke
	|
	|-Func<InventoryDefId, float>.BeginInvoke
	|
	|-Func<InventoryDefId, Resolution>.BeginInvoke
	|
	|-Func<InventoryItemId, InventoryItemId>.BeginInvoke
	|
	|-Func<InventoryItemId, bool>.BeginInvoke
	|
	|-Func<ServerInfo, ServerInfo>.BeginInvoke
	|
	|-Func<ServerInfo, bool>.BeginInvoke
	|
	|-Func<ServerInfo, int>.BeginInvoke
	|
	|-Func<ServerInfo, object>.BeginInvoke
	|
	|-Func<Friend, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<Friend, PathFinder.Point>.BeginInvoke
	|
	|-Func<Friend, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<Friend, Option>.BeginInvoke
	|
	|-Func<Friend, InventoryItem>.BeginInvoke
	|
	|-Func<Friend, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-Func<Friend, InventoryRecipe>.BeginInvoke
	|
	|-Func<Friend, bool>.BeginInvoke
	|
	|-Func<Friend, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<Friend, int>.BeginInvoke
	|
	|-Func<Friend, Int32Enum>.BeginInvoke
	|
	|-Func<Friend, long>.BeginInvoke
	|
	|-Func<Friend, object>.BeginInvoke
	|
	|-Func<Friend, float>.BeginInvoke
	|
	|-Func<Friend, Resolution>.BeginInvoke
	|
	|-Func<InventoryItem, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<InventoryItem, FourBitNumber>.BeginInvoke
	|
	|-Func<InventoryItem, SevenBitNumber>.BeginInvoke
	|
	|-Func<InventoryItem, PathFinder.Point>.BeginInvoke
	|
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<InventoryItem, Option>.BeginInvoke
	|
	|-Func<InventoryItem, InventoryDefId>.BeginInvoke
	|
	|-Func<InventoryItem, InventoryItemId>.BeginInvoke
	|
	|-Func<InventoryItem, InventoryItem>.BeginInvoke
	|
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-Func<InventoryItem, InventoryRecipe>.BeginInvoke
	|
	|-Func<InventoryItem, bool>.BeginInvoke
	|
	|-Func<InventoryItem, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<InventoryItem, int>.BeginInvoke
	|
	|-Func<InventoryItem, Int32Enum>.BeginInvoke
	|
	|-Func<InventoryItem, long>.BeginInvoke
	|
	|-Func<InventoryItem, object>.BeginInvoke
	|
	|-Func<InventoryItem, float>.BeginInvoke
	|
	|-Func<InventoryItem, uint>.BeginInvoke
	|
	|-Func<InventoryItem, Resolution>.BeginInvoke
	|
	|-Func<InventoryItem.Amount, InventoryItemId>.BeginInvoke
	|
	|-Func<InventoryItem.Amount, bool>.BeginInvoke
	|
	|-Func<InventoryItem.Amount, uint>.BeginInvoke
	|
	|-Func<InventoryRecipe, PlayerItemRecipe>.BeginInvoke
	|
	|-Func<InventoryRecipe, InventoryRecipe>.BeginInvoke
	|
	|-Func<InventoryRecipe, bool>.BeginInvoke
	|
	|-Func<InventoryRecipe, object>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, Option>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, bool>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, int>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, long>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, object>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, float>.BeginInvoke
	|
	|-Func<InventoryRecipe.Ingredient, Resolution>.BeginInvoke
	|
	|-Func<Item, DateTime>.BeginInvoke
	|
	|-Func<ArraySegment<byte>, object>.BeginInvoke
	|
	|-Func<char, bool>.BeginInvoke
	|
	|-Func<DictionaryEntry, bool>.BeginInvoke
	|
	|-Func<DictionaryEntry, KeyValuePair<object, object>>.BeginInvoke
	|
	|-Func<DictionaryEntry, object>.BeginInvoke
	|
	|-Func<KeyValuePair<IntPtr, object>, bool>.BeginInvoke
	|
	|-Func<KeyValuePair<object, int>, bool>.BeginInvoke
	|
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<KeyValuePair<object, int>, int>.BeginInvoke
	|
	|-Func<KeyValuePair<object, long>, long>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, Option>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, InventoryItem>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, bool>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, int>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, Int32Enum>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, long>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, object>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, float>.BeginInvoke
	|
	|-Func<KeyValuePair<object, object>, Resolution>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, Option>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, InventoryItem>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, bool>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, int>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, Int32Enum>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, long>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, object>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, float>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, uint>.BeginInvoke
	|
	|-Func<KeyValuePair<uint, object>, Resolution>.BeginInvoke
	|
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.BeginInvoke
	|
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.BeginInvoke
	|
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.BeginInvoke
	|
	|-Func<double, double>.BeginInvoke
	|
	|-Func<Guid, int>.BeginInvoke
	|
	|-Func<Guid, object>.BeginInvoke
	|
	|-Func<int, FourBitNumber>.BeginInvoke
	|
	|-Func<int, SevenBitNumber>.BeginInvoke
	|
	|-Func<int, bool>.BeginInvoke
	|
	|-Func<int, int>.BeginInvoke
	|
	|-Func<int, object>.BeginInvoke
	|
	|-Func<int, float>.BeginInvoke
	|
	|-Func<Int32Enum, Debugging.EntityInfo>.BeginInvoke
	|
	|-Func<Int32Enum, PathFinder.Point>.BeginInvoke
	|
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-Func<Int32Enum, Option>.BeginInvoke
	|
	|-Func<Int32Enum, InventoryItem>.BeginInvoke
	|
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-Func<Int32Enum, InventoryRecipe>.BeginInvoke
	|
	|-Func<Int32Enum, bool>.BeginInvoke
	|
	|-Func<Int32Enum, KeyValuePair<object, int>>.BeginInvoke
	|
	|-Func<Int32Enum, int>.BeginInvoke
	|
	|-Func<Int32Enum, Int32Enum>.BeginInvoke
	|
	|-Func<Int32Enum, long>.BeginInvoke
	|
	|-Func<Int32Enum, object>.BeginInvoke
	|
	|-Func<Int32Enum, float>.BeginInvoke
	|
	|-Func<Int32Enum, Resolution>.BeginInvoke
	|
	|-Func<long, bool>.BeginInvoke
	|
	|-Func<long, long>.BeginInvoke
	|
	|-Func<IntPtr, object>.BeginInvoke
	|
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
	|-Func<float, bool>.BeginInvoke
	|
	|-Func<float, float>.BeginInvoke
	|
	|-Func<uint, bool>.BeginInvoke
	|
	|-Func<uint, uint>.BeginInvoke
	|
	|-Func<ulong, bool>.BeginInvoke
	|
	|-Func<ulong, ulong>.BeginInvoke
	|
	|-Func<ValueTuple<Int32Enum, int>, object>.BeginInvoke
	|
	|-Func<Resolution, bool>.BeginInvoke
	|
	|-Func<Resolution, int>.BeginInvoke
	|
	|-Func<Resolution, Resolution>.BeginInvoke
	|
	|-Func<Resolution, Vector2Int>.BeginInvoke
	*/

	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
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
	|-Func<char, bool>.EndInvoke
	|-Func<DictionaryEntry, bool>.EndInvoke
	|-Func<KeyValuePair<IntPtr, object>, bool>.EndInvoke
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
	|-Func<ServerInfo, ServerInfo>.EndInvoke
	|
	|-Func<double, double>.EndInvoke
	|
	|-Func<object, Nullable<ServerInfo>>.EndInvoke
	|
	|-Func<object, Nullable<Item>>.EndInvoke
	*/

}

public sealed class Converter<TInput, TOutput> : MulticastDelegate // TypeDefIndex: 161
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-Converter<object, object>..ctor
	*/

	public virtual TOutput Invoke(TInput input) { }
	/* GenericInstMethod :
	|
	|-Converter<Type, string>.Invoke
	|-Converter<object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(TInput input, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-Converter<object, object>.BeginInvoke
	*/

	public virtual TOutput EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-Converter<object, object>.EndInvoke
	*/

}

internal struct __DTString // TypeDefIndex: 231
{
	internal string Value;
	internal int Index;
	internal int len;
	internal char m_current;
	private CompareInfo m_info;
	private bool m_checkDigitToken;
	private static char[] WhiteSpaceChecks;

	internal CompareInfo CompareInfo { get; }


	internal void .ctor(string str, DateTimeFormatInfo dtfi, bool checkDigitToken) { }

	internal void .ctor(string str, DateTimeFormatInfo dtfi) { }

	internal CompareInfo get_CompareInfo() { }

	internal bool GetNext() { }

	internal bool AtEnd() { }

	internal bool Advance(int count) { }

	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) { }

	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) { }

	internal bool MatchSpecifiedWord(string target) { }

	internal bool MatchSpecifiedWord(string target, int endIndex) { }

	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) { }

	internal bool Match(string str) { }

	internal bool Match(char ch) { }

	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) { }

	internal int GetRepeatCount() { }

	internal bool GetNextDigit() { }

	internal char GetChar() { }

	internal int GetDigit() { }

	internal void SkipWhiteSpaces() { }

	internal bool SkipWhiteSpaceCurrent() { }

	internal void TrimTail() { }

	internal void RemoveTrailingInQuoteSpaces() { }

	internal void RemoveLeadingInQuoteSpaces() { }

	internal DTSubString GetSubString() { }

	internal void ConsumeSubString(DTSubString sub) { }

	private static void .cctor() { }

}

internal class __ComObject // TypeDefIndex: 429
{

	private void .ctor() { }

}

internal static class __Error // TypeDefIndex: 615
{

	internal static void EndOfFile() { }

	internal static void FileNotOpen() { }

	internal static void StreamIsClosed() { }

	internal static void MemoryStreamNotExpandable() { }

	internal static void ReaderClosed() { }

	internal static void ReadNotSupported() { }

	internal static void WrongAsyncResult() { }

	internal static void EndReadCalledTwice() { }

	internal static void EndWriteCalledTwice() { }

	internal static string GetDisplayablePath(string path, bool isInvalidPath) { }

	internal static void WinIOError(int errorCode, string maybeFullPath) { }

	internal static void WriteNotSupported() { }

	internal static void WriterClosed() { }

}

internal abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 627
{
	private int threadId;
	internal int state;
	internal TSource current;

	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Iterator<object>..ctor
	*/

	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-Iterator<object>.get_Current
	*/

	protected abstract Iterator<TSource> Clone();
	/* GenericInstMethod :
	|
	|-Iterator<object>.Clone
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-Iterator<object>.Dispose
	*/

	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-Iterator<object>.Dispose
	*/

	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-Iterator<object>.GetEnumerator
	*/

	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-Iterator<object>.MoveNext
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-Iterator<object>.System.Collections.IEnumerator.get_Current
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-Iterator<object>.System.Collections.IEnumerator.Reset
	*/

}

internal abstract class SearchResultHandler<TSource> // TypeDefIndex: 629
{

	internal abstract bool IsResultIncluded(SearchResult result);
	/* GenericInstMethod :
	|
	|-SearchResultHandler<object>.IsResultIncluded
	*/

	internal abstract TSource CreateObject(SearchResult result);
	/* GenericInstMethod :
	|
	|-SearchResultHandler<object>.CreateObject
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-SearchResultHandler<object>..ctor
	|-SearchResultHandler<string>..ctor
	*/

}

internal static class _ThreadPoolWaitCallback // TypeDefIndex: 814
{

	internal static bool PerformWaitCallback() { }

}

public class Task<TResult> : Task // TypeDefIndex: 842
{
	internal TResult m_result;
	private static readonly TaskFactory<TResult> s_Factory;
	internal static readonly Func<Task<Task>, Task<TResult>> TaskWhenAnyCast;

	[DebuggerBrowsableAttribute]
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }
	public static TaskFactory<TResult> Factory { get; }


	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>..ctor
	|
	|-Task<bool>..ctor
	|
	|-Task<int>..ctor
	|
	|-Task<UdpReceiveResult>..ctor
	|
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-Task<Nullable<Image>>..ctor
	|
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-Task<Nullable<Item>>..ctor
	|
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-Task<Nullable<int>>..ctor
	|
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-Task<object>..ctor
	|-Task<Task>..ctor
	|
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(object state, TaskCreationOptions options) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>..ctor
	|
	|-Task<bool>..ctor
	|
	|-Task<int>..ctor
	|
	|-Task<UdpReceiveResult>..ctor
	|
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-Task<Nullable<Image>>..ctor
	|
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-Task<Nullable<Item>>..ctor
	|
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-Task<Nullable<int>>..ctor
	|
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-Task<object>..ctor
	|
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>..ctor
	|
	|-Task<bool>..ctor
	|
	|-Task<int>..ctor
	|
	|-Task<UdpReceiveResult>..ctor
	|
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-Task<Nullable<Image>>..ctor
	|
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-Task<Nullable<Item>>..ctor
	|
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-Task<Nullable<int>>..ctor
	|
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-Task<object>..ctor
	|
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>..ctor
	|
	|-Task<bool>..ctor
	|
	|-Task<int>..ctor
	|
	|-Task<UdpReceiveResult>..ctor
	|
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-Task<Nullable<Image>>..ctor
	|
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-Task<Nullable<Item>>..ctor
	|
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-Task<Nullable<int>>..ctor
	|
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-Task<object>..ctor
	|
	|-Task<VoidTaskResult>..ctor
	*/

	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>..ctor
	|
	|-Task<bool>..ctor
	|
	|-Task<int>..ctor
	|
	|-Task<UdpReceiveResult>..ctor
	|
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-Task<Nullable<Image>>..ctor
	|
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-Task<Nullable<Item>>..ctor
	|
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-Task<Nullable<int>>..ctor
	|
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-Task<object>..ctor
	|
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>..ctor
	|
	|-Task<bool>..ctor
	|
	|-Task<int>..ctor
	|
	|-Task<UdpReceiveResult>..ctor
	|
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-Task<Nullable<Image>>..ctor
	|
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-Task<Nullable<Item>>..ctor
	|
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-Task<Nullable<int>>..ctor
	|
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-Task<object>..ctor
	|
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>..ctor
	|
	|-Task<bool>..ctor
	|
	|-Task<int>..ctor
	|
	|-Task<UdpReceiveResult>..ctor
	|
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-Task<Nullable<Image>>..ctor
	|
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-Task<Nullable<Item>>..ctor
	|
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-Task<Nullable<int>>..ctor
	|
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-Task<object>..ctor
	|
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>..ctor
	|
	|-Task<bool>..ctor
	|
	|-Task<int>..ctor
	|
	|-Task<UdpReceiveResult>..ctor
	|
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-Task<Nullable<Image>>..ctor
	|
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-Task<Nullable<Item>>..ctor
	|
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-Task<Nullable<int>>..ctor
	|
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-Task<object>..ctor
	|
	|-Task<VoidTaskResult>..ctor
	*/

	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>.StartNew
	|
	|-Task<bool>.StartNew
	|
	|-Task<int>.StartNew
	|
	|-Task<UdpReceiveResult>.StartNew
	|
	|-Task<Nullable<ServerInfo>>.StartNew
	|
	|-Task<Nullable<Image>>.StartNew
	|
	|-Task<Nullable<InventoryPurchaseResult>>.StartNew
	|
	|-Task<Nullable<InventoryResult>>.StartNew
	|
	|-Task<Nullable<Item>>.StartNew
	|
	|-Task<Nullable<ResultPage>>.StartNew
	|
	|-Task<Nullable<int>>.StartNew
	|
	|-Task<Nullable<Int32Enum>>.StartNew
	|
	|-Task<object>.StartNew
	|
	|-Task<VoidTaskResult>.StartNew
	*/

	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>.TrySetResult
	|
	|-Task<bool>.TrySetResult
	|-Task<VoidTaskResult>.TrySetResult
	|
	|-Task<int>.TrySetResult
	|
	|-Task<UdpReceiveResult>.TrySetResult
	|
	|-Task<Nullable<ServerInfo>>.TrySetResult
	|
	|-Task<Nullable<Image>>.TrySetResult
	|
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetResult
	|-Task<Nullable<ResultPage>>.TrySetResult
	|
	|-Task<Nullable<InventoryResult>>.TrySetResult
	|
	|-Task<Nullable<Item>>.TrySetResult
	|
	|-Task<Nullable<int>>.TrySetResult
	|-Task<Nullable<Int32Enum>>.TrySetResult
	|
	|-Task<object>.TrySetResult
	|-Task<Task>.TrySetResult
	*/

	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>.DangerousSetResult
	|
	|-Task<bool>.DangerousSetResult
	|-Task<VoidTaskResult>.DangerousSetResult
	|
	|-Task<int>.DangerousSetResult
	|
	|-Task<UdpReceiveResult>.DangerousSetResult
	|
	|-Task<Nullable<ServerInfo>>.DangerousSetResult
	|
	|-Task<Nullable<Image>>.DangerousSetResult
	|
	|-Task<Nullable<InventoryPurchaseResult>>.DangerousSetResult
	|-Task<Nullable<ResultPage>>.DangerousSetResult
	|
	|-Task<Nullable<InventoryResult>>.DangerousSetResult
	|
	|-Task<Nullable<Item>>.DangerousSetResult
	|
	|-Task<Nullable<int>>.DangerousSetResult
	|-Task<Nullable<Int32Enum>>.DangerousSetResult
	|
	|-Task<object>.DangerousSetResult
	*/

	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-Task<ISocket>.get_Result
	|-Task<SteamInventoryCrafting.MarketPrice>.get_Result
	|-Task<Nullable<int>>.get_Result
	|-Task<Nullable<Int32Enum>>.get_Result
	|-Task<object>.get_Result
	|-Task<Task>.get_Result
	|
	|-Task<PublishResult>.get_Result
	|-Task<Nullable<Image>>.get_Result
	|
	|-Task<bool>.get_Result
	|-Task<VoidTaskResult>.get_Result
	|
	|-Task<int>.get_Result
	|
	|-Task<UdpReceiveResult>.get_Result
	|
	|-Task<Nullable<ServerInfo>>.get_Result
	|
	|-Task<Nullable<InventoryPurchaseResult>>.get_Result
	|-Task<Nullable<ResultPage>>.get_Result
	|
	|-Task<Nullable<InventoryResult>>.get_Result
	|
	|-Task<Nullable<Item>>.get_Result
	*/

	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>.get_ResultOnSuccess
	|-Task<Nullable<Image>>.get_ResultOnSuccess
	|
	|-Task<bool>.get_ResultOnSuccess
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	|
	|-Task<int>.get_ResultOnSuccess
	|
	|-Task<UdpReceiveResult>.get_ResultOnSuccess
	|
	|-Task<Nullable<ServerInfo>>.get_ResultOnSuccess
	|
	|-Task<Nullable<InventoryPurchaseResult>>.get_ResultOnSuccess
	|-Task<Nullable<ResultPage>>.get_ResultOnSuccess
	|
	|-Task<Nullable<InventoryResult>>.get_ResultOnSuccess
	|
	|-Task<Nullable<Item>>.get_ResultOnSuccess
	|
	|-Task<Nullable<int>>.get_ResultOnSuccess
	|-Task<Nullable<Int32Enum>>.get_ResultOnSuccess
	|-Task<object>.get_ResultOnSuccess
	*/

	internal TResult GetResultCore(bool waitCompletionNotification) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>.GetResultCore
	|-Task<Nullable<Image>>.GetResultCore
	|
	|-Task<bool>.GetResultCore
	|-Task<VoidTaskResult>.GetResultCore
	|
	|-Task<int>.GetResultCore
	|
	|-Task<UdpReceiveResult>.GetResultCore
	|
	|-Task<Nullable<ServerInfo>>.GetResultCore
	|
	|-Task<Nullable<InventoryPurchaseResult>>.GetResultCore
	|-Task<Nullable<ResultPage>>.GetResultCore
	|
	|-Task<Nullable<InventoryResult>>.GetResultCore
	|
	|-Task<Nullable<Item>>.GetResultCore
	|
	|-Task<Nullable<int>>.GetResultCore
	|-Task<Nullable<Int32Enum>>.GetResultCore
	|-Task<object>.GetResultCore
	*/

	internal bool TrySetException(object exceptionObject) { }
	/* GenericInstMethod :
	|
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

	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }
	/* GenericInstMethod :
	|
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

	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }
	/* GenericInstMethod :
	|
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

	public static TaskFactory<TResult> get_Factory() { }
	/* GenericInstMethod :
	|
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
	|-Task<Task>.get_Factory
	|-Task<VoidTaskResult>.get_Factory
	*/

	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>.InnerInvoke
	|
	|-Task<bool>.InnerInvoke
	|-Task<VoidTaskResult>.InnerInvoke
	|
	|-Task<int>.InnerInvoke
	|
	|-Task<UdpReceiveResult>.InnerInvoke
	|
	|-Task<Nullable<ServerInfo>>.InnerInvoke
	|
	|-Task<Nullable<Image>>.InnerInvoke
	|
	|-Task<Nullable<InventoryPurchaseResult>>.InnerInvoke
	|-Task<Nullable<ResultPage>>.InnerInvoke
	|
	|-Task<Nullable<InventoryResult>>.InnerInvoke
	|
	|-Task<Nullable<Item>>.InnerInvoke
	|
	|-Task<Nullable<int>>.InnerInvoke
	|-Task<Nullable<Int32Enum>>.InnerInvoke
	|
	|-Task<object>.InnerInvoke
	|-Task<Task>.InnerInvoke
	*/

	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
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

	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
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

	public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-Task<ISocket>.ContinueWith
	|-Task<object>.ContinueWith
	|
	|-Task<PublishResult>.ContinueWith
	|
	|-Task<bool>.ContinueWith
	|
	|-Task<int>.ContinueWith
	|
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-Task<Nullable<ServerInfo>>.ContinueWith
	|
	|-Task<Nullable<Image>>.ContinueWith
	|
	|-Task<Nullable<InventoryPurchaseResult>>.ContinueWith
	|
	|-Task<Nullable<InventoryResult>>.ContinueWith
	|
	|-Task<Nullable<Item>>.ContinueWith
	|
	|-Task<Nullable<ResultPage>>.ContinueWith
	|
	|-Task<Nullable<int>>.ContinueWith
	|
	|-Task<Nullable<Int32Enum>>.ContinueWith
	|
	|-Task<VoidTaskResult>.ContinueWith
	*/

	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-Task<PublishResult>.ContinueWith
	|
	|-Task<bool>.ContinueWith
	|
	|-Task<int>.ContinueWith
	|
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-Task<Nullable<ServerInfo>>.ContinueWith
	|
	|-Task<Nullable<Image>>.ContinueWith
	|
	|-Task<Nullable<InventoryPurchaseResult>>.ContinueWith
	|
	|-Task<Nullable<InventoryResult>>.ContinueWith
	|
	|-Task<Nullable<Item>>.ContinueWith
	|
	|-Task<Nullable<ResultPage>>.ContinueWith
	|
	|-Task<Nullable<int>>.ContinueWith
	|
	|-Task<Nullable<Int32Enum>>.ContinueWith
	|
	|-Task<object>.ContinueWith
	|
	|-Task<VoidTaskResult>.ContinueWith
	*/

	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-Task<Dictionary<string, string>>.ContinueWith<Task<Dictionary<string, string>>>
	|-Task<object>.ContinueWith<object>
	*/

	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-Task<object>.ContinueWith<object>
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
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

public class TaskFactory<TResult>
	private CancellationToken m_defaultCancellationToken;
	private TaskScheduler m_defaultScheduler;
	private TaskCreationOptions m_defaultCreationOptions;
	private TaskContinuationOptions m_defaultContinuationOptions;


	public void .ctor() { }
	/* GenericInstMethod :
	|
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

	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
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

	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-TaskFactory<PublishResult>.StartNew
	|
	|-TaskFactory<bool>.StartNew
	|
	|-TaskFactory<int>.StartNew
	|
	|-TaskFactory<UdpReceiveResult>.StartNew
	|
	|-TaskFactory<Nullable<ServerInfo>>.StartNew
	|
	|-TaskFactory<Nullable<Image>>.StartNew
	|
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.StartNew
	|
	|-TaskFactory<Nullable<InventoryResult>>.StartNew
	|
	|-TaskFactory<Nullable<Item>>.StartNew
	|
	|-TaskFactory<Nullable<ResultPage>>.StartNew
	|
	|-TaskFactory<Nullable<int>>.StartNew
	|
	|-TaskFactory<Nullable<Int32Enum>>.StartNew
	|
	|-TaskFactory<object>.StartNew
	|-TaskFactory<Task>.StartNew
	|
	|-TaskFactory<VoidTaskResult>.StartNew
	*/

	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-TaskFactory<PublishResult>.FromAsyncCoreLogic
	|
	|-TaskFactory<bool>.FromAsyncCoreLogic
	|
	|-TaskFactory<int>.FromAsyncCoreLogic
	|
	|-TaskFactory<UdpReceiveResult>.FromAsyncCoreLogic
	|
	|-TaskFactory<Nullable<ServerInfo>>.FromAsyncCoreLogic
	|
	|-TaskFactory<Nullable<Image>>.FromAsyncCoreLogic
	|
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsyncCoreLogic
	|
	|-TaskFactory<Nullable<InventoryResult>>.FromAsyncCoreLogic
	|
	|-TaskFactory<Nullable<Item>>.FromAsyncCoreLogic
	|
	|-TaskFactory<Nullable<ResultPage>>.FromAsyncCoreLogic
	|
	|-TaskFactory<Nullable<int>>.FromAsyncCoreLogic
	|
	|-TaskFactory<Nullable<Int32Enum>>.FromAsyncCoreLogic
	|
	|-TaskFactory<object>.FromAsyncCoreLogic
	|
	|-TaskFactory<VoidTaskResult>.FromAsyncCoreLogic
	*/

	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
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

	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-TaskFactory<PublishResult>.FromAsyncImpl
	|
	|-TaskFactory<bool>.FromAsyncImpl
	|
	|-TaskFactory<int>.FromAsyncImpl
	|
	|-TaskFactory<UdpReceiveResult>.FromAsyncImpl
	|
	|-TaskFactory<Nullable<ServerInfo>>.FromAsyncImpl
	|
	|-TaskFactory<Nullable<Image>>.FromAsyncImpl
	|
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsyncImpl
	|
	|-TaskFactory<Nullable<InventoryResult>>.FromAsyncImpl
	|
	|-TaskFactory<Nullable<Item>>.FromAsyncImpl
	|
	|-TaskFactory<Nullable<ResultPage>>.FromAsyncImpl
	|
	|-TaskFactory<Nullable<int>>.FromAsyncImpl
	|
	|-TaskFactory<Nullable<Int32Enum>>.FromAsyncImpl
	|
	|-TaskFactory<object>.FromAsyncImpl
	|
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl
	*/

	public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }
	/* GenericInstMethod :
	|
	|-TaskFactory<int>.FromAsync<byte[], int>
	|-TaskFactory<int>.FromAsync<object, int>
	|
	|-TaskFactory<object>.FromAsync<object, object>
	*/

	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-TaskFactory<int>.FromAsyncImpl<object, int>
	|
	|-TaskFactory<object>.FromAsyncImpl<object, object>
	*/

	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-TaskFactory<int>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-TaskFactory<object>.FromAsyncTrim<object, object>
	|
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	*/

}

internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction // TypeDefIndex: 868
{
	private byte _state;
	private readonly bool _lookForOce;


	public void .ctor(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-UnwrapPromise<object>..ctor
	|
	|-UnwrapPromise<VoidTaskResult>..ctor
	*/

	public void Invoke(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-UnwrapPromise<object>.Invoke
	|
	|-UnwrapPromise<VoidTaskResult>.Invoke
	*/

	private void InvokeCore(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-UnwrapPromise<object>.InvokeCore
	|-UnwrapPromise<VoidTaskResult>.InvokeCore
	*/

	private void InvokeCoreAsync(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-UnwrapPromise<object>.InvokeCoreAsync
	|
	|-UnwrapPromise<VoidTaskResult>.InvokeCoreAsync
	*/

	private void ProcessCompletedOuterTask(Task task) { }
	/* GenericInstMethod :
	|
	|-UnwrapPromise<object>.ProcessCompletedOuterTask
	|
	|-UnwrapPromise<VoidTaskResult>.ProcessCompletedOuterTask
	*/

	private bool TrySetFromTask(Task task, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-UnwrapPromise<object>.TrySetFromTask
	|
	|-UnwrapPromise<VoidTaskResult>.TrySetFromTask
	*/

	private void ProcessInnerTask(Task task) { }
	/* GenericInstMethod :
	|
	|-UnwrapPromise<object>.ProcessInnerTask
	|-UnwrapPromise<VoidTaskResult>.ProcessInnerTask
	*/

}

public class TaskCompletionSource<TResult> // TypeDefIndex: 871
{
	private readonly Task<TResult> m_task;

	public Task<TResult> Task { get; }


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-TaskCompletionSource<HttpResponseMessage>..ctor
	|-TaskCompletionSource<object>..ctor
	*/

	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-TaskCompletionSource<HttpResponseMessage>.get_Task
	|-TaskCompletionSource<object>.get_Task
	*/

	private void SpinUntilCompleted() { }
	/* GenericInstMethod :
	|
	|-TaskCompletionSource<object>.SpinUntilCompleted
	*/

	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-TaskCompletionSource<object>.TrySetCanceled
	*/

	public bool TrySetCanceled(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-TaskCompletionSource<object>.TrySetCanceled
	*/

	public void SetCanceled() { }
	/* GenericInstMethod :
	|
	|-TaskCompletionSource<HttpResponseMessage>.SetCanceled
	|-TaskCompletionSource<object>.SetCanceled
	*/

}

internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task // TypeDefIndex: 873
{
	private Task<TAntecedentResult> m_antecedent;


	public void .ctor(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-ContinuationTaskFromResultTask<PublishResult>..ctor
	|
	|-ContinuationTaskFromResultTask<bool>..ctor
	|
	|-ContinuationTaskFromResultTask<int>..ctor
	|
	|-ContinuationTaskFromResultTask<UdpReceiveResult>..ctor
	|
	|-ContinuationTaskFromResultTask<Nullable<ServerInfo>>..ctor
	|
	|-ContinuationTaskFromResultTask<Nullable<Image>>..ctor
	|
	|-ContinuationTaskFromResultTask<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-ContinuationTaskFromResultTask<Nullable<InventoryResult>>..ctor
	|
	|-ContinuationTaskFromResultTask<Nullable<Item>>..ctor
	|
	|-ContinuationTaskFromResultTask<Nullable<ResultPage>>..ctor
	|
	|-ContinuationTaskFromResultTask<Nullable<int>>..ctor
	|
	|-ContinuationTaskFromResultTask<Nullable<Int32Enum>>..ctor
	|
	|-ContinuationTaskFromResultTask<object>..ctor
	|
	|-ContinuationTaskFromResultTask<VoidTaskResult>..ctor
	*/

	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
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
{
	private Task<TAntecedentResult> m_antecedent;


	public void .ctor(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-ContinuationResultTaskFromResultTask<object, object>..ctor
	*/

	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-ContinuationResultTaskFromResultTask<object, object>.InnerInvoke
	*/

}

internal sealed class __BinaryWriter // TypeDefIndex: 1105
{
	internal Stream sout;
	internal FormatterTypeStyle formatterTypeStyle;
	internal Hashtable objectMapTable;
	internal ObjectWriter objectWriter;
	internal BinaryWriter dataWriter;
	internal int m_nestedObjectCount;
	private int nullCount;
	internal BinaryMethodCall binaryMethodCall;
	internal BinaryMethodReturn binaryMethodReturn;
	internal BinaryObject binaryObject;
	internal BinaryObjectWithMap binaryObjectWithMap;
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped;
	internal BinaryObjectString binaryObjectString;
	internal BinaryArray binaryArray;
	private byte[] byteBuffer;
	private int chunkSize;
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped;
	internal MemberPrimitiveTyped memberPrimitiveTyped;
	internal ObjectNull objectNull;
	internal MemberReference memberReference;
	internal BinaryAssembly binaryAssembly;


	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	internal void WriteBegin() { }

	internal void WriteEnd() { }

	internal void WriteBoolean(bool value) { }

	internal void WriteByte(byte value) { }

	private void WriteBytes(byte[] value) { }

	private void WriteBytes(byte[] byteA, int offset, int size) { }

	internal void WriteChar(char value) { }

	internal void WriteChars(char[] value) { }

	internal void WriteDecimal(Decimal value) { }

	internal void WriteSingle(float value) { }

	internal void WriteDouble(double value) { }

	internal void WriteInt16(short value) { }

	internal void WriteInt32(int value) { }

	internal void WriteInt64(long value) { }

	internal void WriteSByte(sbyte value) { }

	internal void WriteString(string value) { }

	internal void WriteTimeSpan(TimeSpan value) { }

	internal void WriteDateTime(DateTime value) { }

	internal void WriteUInt16(ushort value) { }

	internal void WriteUInt32(uint value) { }

	internal void WriteUInt64(ulong value) { }

	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	internal void WriteSerializationHeaderEnd() { }

	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	internal void WriteMethodCall() { }

	internal void WriteMethodReturn() { }

	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	internal void WriteObjectString(int objectId, string value) { }

	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	private void WriteArrayAsBytes(Array array, int typeLength) { }

	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	internal void WriteDelayedNullItem() { }

	internal void WriteItemEnd() { }

	private void InternalWriteItemNull() { }

	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }

}

internal sealed class __BinaryParser // TypeDefIndex: 1116
{
	internal ObjectReader objectReader;
	internal Stream input;
	internal long topId;
	internal long headerId;
	internal SizedArray objectMapIdTable;
	internal SizedArray assemIdToAssemblyTable;
	internal SerStack stack;
	internal BinaryTypeEnum expectedType;
	internal object expectedTypeInformation;
	internal ParseRecord PRS;
	private BinaryAssemblyInfo systemAssemblyInfo;
	private BinaryReader dataReader;
	private static Encoding encoding;
	private SerStack opPool;
	private BinaryObject binaryObject;
	private BinaryObjectWithMap bowm;
	private BinaryObjectWithMapTyped bowmt;
	internal BinaryObjectString objectString;
	internal BinaryCrossAppDomainString crossAppDomainString;
	internal MemberPrimitiveTyped memberPrimitiveTyped;
	private byte[] byteBuffer;
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped;
	internal MemberReference memberReference;
	internal ObjectNull objectNull;
	internal static MessageEnd messageEnd;

	internal BinaryAssemblyInfo SystemAssemblyInfo { get; }
	internal SizedArray ObjectMapIdTable { get; }
	internal SizedArray AssemIdToAssemblyTable { get; }
	internal ParseRecord prs { get; }


	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	internal SizedArray get_ObjectMapIdTable() { }

	internal SizedArray get_AssemIdToAssemblyTable() { }

	internal ParseRecord get_prs() { }

	internal void Run() { }

	internal void ReadBegin() { }

	internal void ReadEnd() { }

	internal bool ReadBoolean() { }

	internal byte ReadByte() { }

	internal byte[] ReadBytes(int length) { }

	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	internal char ReadChar() { }

	internal char[] ReadChars(int length) { }

	internal Decimal ReadDecimal() { }

	internal float ReadSingle() { }

	internal double ReadDouble() { }

	internal short ReadInt16() { }

	internal int ReadInt32() { }

	internal long ReadInt64() { }

	internal sbyte ReadSByte() { }

	internal string ReadString() { }

	internal TimeSpan ReadTimeSpan() { }

	internal DateTime ReadDateTime() { }

	internal ushort ReadUInt16() { }

	internal uint ReadUInt32() { }

	internal ulong ReadUInt64() { }

	internal void ReadSerializationHeaderRecord() { }

	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadObject() { }

	internal void ReadCrossAppDomainMap() { }

	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadMemberPrimitiveTyped() { }

	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadArrayAsBytes(ParseRecord pr) { }

	private void ReadMemberPrimitiveUnTyped() { }

	private void ReadMemberReference() { }

	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadMessageEnd() { }

	internal object ReadValue(InternalPrimitiveTypeE code) { }

	private ObjectProgress GetOp() { }

	private void PutOp(ObjectProgress op) { }

	private static void .cctor() { }

}

public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1291
{
	private readonly Task<TResult> m_task;

	public bool IsCompleted { get; }


	internal void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
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

	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
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

	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
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

	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
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

	public TResult GetResult() { }
	/* GenericInstMethod :
	|
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
	|-TaskAwaiter<bool>.GetResult
	|-TaskAwaiter<object>.GetResult
	|
	|-TaskAwaiter<PublishResult>.GetResult
	|-TaskAwaiter<Nullable<Image>>.GetResult
	|
	|-TaskAwaiter<UdpReceiveResult>.GetResult
	|
	|-TaskAwaiter<Nullable<ServerInfo>>.GetResult
	|
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.GetResult
	|-TaskAwaiter<Nullable<ResultPage>>.GetResult
	|
	|-TaskAwaiter<Nullable<InventoryResult>>.GetResult
	|
	|-TaskAwaiter<Nullable<Item>>.GetResult
	|
	|-TaskAwaiter<int>.GetResult
	|-TaskAwaiter<Nullable<int>>.GetResult
	|-TaskAwaiter<Nullable<Int32Enum>>.GetResult
	|-TaskAwaiter<VoidTaskResult>.GetResult
	*/

}

public struct ConfiguredTaskAwaitable<TResult> // TypeDefIndex: 1294
{
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter;


	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
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

	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
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
{
	private ItemType[] items;


	public ItemType TryGet(KeyType key) { }
	/* GenericInstMethod :
	|
	|-ConcurrentSet<KeyValuePair<object, Int32Enum>, object>.TryGet
	|-ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>.TryGet
	|
	|-ConcurrentSet<object, object>.TryGet
	*/

	public ItemType GetOrAdd(ItemType newItem) { }
	/* GenericInstMethod :
	|
	|-ConcurrentSet<KeyValuePair<object, Int32Enum>, object>.GetOrAdd
	|-ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>.GetOrAdd
	|-ConcurrentSet<object, object>.GetOrAdd
	*/

}

internal abstract class ConcurrentSetItem<KeyType, ItemType> // TypeDefIndex: 1508
{

	public abstract int Compare(ItemType other);
	/* GenericInstMethod :
	|
	|-ConcurrentSetItem<object, object>.Compare
	*/

	public abstract int Compare(KeyType key);
	/* GenericInstMethod :
	|
	|-ConcurrentSetItem<object, object>.Compare
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-ConcurrentSetItem<KeyValuePair<object, Int32Enum>, object>..ctor
	|-ConcurrentSetItem<KeyValuePair<string, EventTags>, NameInfo>..ctor
	|-ConcurrentSetItem<object, object>..ctor
	*/

}

internal sealed class InvokeTypeInfo<ContainerType> : TraceLoggingTypeInfo<ContainerType> // TypeDefIndex: 1524
{
	private readonly PropertyAnalysis[] properties;
	private readonly PropertyAccessor<ContainerType>[] accessors;


	public void .ctor(TypeAnalysis typeAnalysis) { }
	/* GenericInstMethod :
	|
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

	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
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

	public override void WriteData(TraceLoggingDataCollector collector, ref ContainerType value) { }
	/* GenericInstMethod :
	|
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

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-InvokeTypeInfo<bool>.GetData
	|
	|-InvokeTypeInfo<byte>.GetData
	|
	|-InvokeTypeInfo<char>.GetData
	|
	|-InvokeTypeInfo<KeyValuePair<object, object>>.GetData
	|
	|-InvokeTypeInfo<DateTime>.GetData
	|
	|-InvokeTypeInfo<DateTimeOffset>.GetData
	|
	|-InvokeTypeInfo<Decimal>.GetData
	|
	|-InvokeTypeInfo<EmptyStruct>.GetData
	|
	|-InvokeTypeInfo<double>.GetData
	|
	|-InvokeTypeInfo<Guid>.GetData
	|
	|-InvokeTypeInfo<short>.GetData
	|
	|-InvokeTypeInfo<int>.GetData
	|
	|-InvokeTypeInfo<long>.GetData
	|
	|-InvokeTypeInfo<IntPtr>.GetData
	|
	|-InvokeTypeInfo<object>.GetData
	|
	|-InvokeTypeInfo<sbyte>.GetData
	|
	|-InvokeTypeInfo<float>.GetData
	|
	|-InvokeTypeInfo<TimeSpan>.GetData
	|
	|-InvokeTypeInfo<ushort>.GetData
	|
	|-InvokeTypeInfo<uint>.GetData
	|
	|-InvokeTypeInfo<ulong>.GetData
	|
	|-InvokeTypeInfo<UIntPtr>.GetData
	*/

	public override void WriteObjectData(TraceLoggingDataCollector collector, object valueObj) { }
	/* GenericInstMethod :
	|
	|-InvokeTypeInfo<bool>.WriteObjectData
	|-InvokeTypeInfo<byte>.WriteObjectData
	|-InvokeTypeInfo<EmptyStruct>.WriteObjectData
	|-InvokeTypeInfo<sbyte>.WriteObjectData
	|
	|-InvokeTypeInfo<char>.WriteObjectData
	|-InvokeTypeInfo<short>.WriteObjectData
	|-InvokeTypeInfo<ushort>.WriteObjectData
	|
	|-InvokeTypeInfo<KeyValuePair<object, object>>.WriteObjectData
	|-InvokeTypeInfo<DateTimeOffset>.WriteObjectData
	|-InvokeTypeInfo<Decimal>.WriteObjectData
	|-InvokeTypeInfo<Guid>.WriteObjectData
	|
	|-InvokeTypeInfo<DateTime>.WriteObjectData
	|-InvokeTypeInfo<long>.WriteObjectData
	|-InvokeTypeInfo<IntPtr>.WriteObjectData
	|-InvokeTypeInfo<TimeSpan>.WriteObjectData
	|-InvokeTypeInfo<ulong>.WriteObjectData
	|-InvokeTypeInfo<UIntPtr>.WriteObjectData
	|
	|-InvokeTypeInfo<double>.WriteObjectData
	|
	|-InvokeTypeInfo<int>.WriteObjectData
	|-InvokeTypeInfo<uint>.WriteObjectData
	|
	|-InvokeTypeInfo<object>.WriteObjectData
	|
	|-InvokeTypeInfo<float>.WriteObjectData
	*/

}

internal abstract class PropertyAccessor<ContainerType> // TypeDefIndex: 1526
{

	public abstract void Write(TraceLoggingDataCollector collector, ref ContainerType value);
	/* GenericInstMethod :
	|
	|-PropertyAccessor<object>.Write
	*/

	public abstract object GetData(ContainerType value);
	/* GenericInstMethod :
	|
	|-PropertyAccessor<object>.GetData
	*/

	public static PropertyAccessor<ContainerType> Create(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
	|-PropertyAccessor<bool>.Create
	|
	|-PropertyAccessor<byte>.Create
	|
	|-PropertyAccessor<char>.Create
	|
	|-PropertyAccessor<KeyValuePair<object, object>>.Create
	|
	|-PropertyAccessor<DateTime>.Create
	|
	|-PropertyAccessor<DateTimeOffset>.Create
	|
	|-PropertyAccessor<Decimal>.Create
	|
	|-PropertyAccessor<EmptyStruct>.Create
	|
	|-PropertyAccessor<double>.Create
	|
	|-PropertyAccessor<Guid>.Create
	|
	|-PropertyAccessor<short>.Create
	|
	|-PropertyAccessor<int>.Create
	|
	|-PropertyAccessor<long>.Create
	|
	|-PropertyAccessor<IntPtr>.Create
	|
	|-PropertyAccessor<object>.Create
	|
	|-PropertyAccessor<sbyte>.Create
	|
	|-PropertyAccessor<float>.Create
	|
	|-PropertyAccessor<TimeSpan>.Create
	|
	|-PropertyAccessor<ushort>.Create
	|
	|-PropertyAccessor<uint>.Create
	|
	|-PropertyAccessor<ulong>.Create
	|
	|-PropertyAccessor<UIntPtr>.Create
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
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
{
	private readonly TraceLoggingTypeInfo typeInfo;
	private readonly MethodInfo getterInfo;


	public void .ctor(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
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

	public override void Write(TraceLoggingDataCollector collector, ref ContainerType container) { }
	/* GenericInstMethod :
	|
	|-NonGenericProperytWriter<bool>.Write
	|-NonGenericProperytWriter<byte>.Write
	|-NonGenericProperytWriter<EmptyStruct>.Write
	|-NonGenericProperytWriter<sbyte>.Write
	|
	|-NonGenericProperytWriter<char>.Write
	|-NonGenericProperytWriter<short>.Write
	|-NonGenericProperytWriter<ushort>.Write
	|
	|-NonGenericProperytWriter<KeyValuePair<object, object>>.Write
	|-NonGenericProperytWriter<DateTimeOffset>.Write
	|-NonGenericProperytWriter<Decimal>.Write
	|-NonGenericProperytWriter<Guid>.Write
	|
	|-NonGenericProperytWriter<DateTime>.Write
	|-NonGenericProperytWriter<long>.Write
	|-NonGenericProperytWriter<IntPtr>.Write
	|-NonGenericProperytWriter<TimeSpan>.Write
	|-NonGenericProperytWriter<ulong>.Write
	|-NonGenericProperytWriter<UIntPtr>.Write
	|
	|-NonGenericProperytWriter<double>.Write
	|
	|-NonGenericProperytWriter<int>.Write
	|-NonGenericProperytWriter<uint>.Write
	|
	|-NonGenericProperytWriter<object>.Write
	|
	|-NonGenericProperytWriter<float>.Write
	*/

	public override object GetData(ContainerType container) { }
	/* GenericInstMethod :
	|
	|-NonGenericProperytWriter<bool>.GetData
	|-NonGenericProperytWriter<byte>.GetData
	|-NonGenericProperytWriter<EmptyStruct>.GetData
	|-NonGenericProperytWriter<sbyte>.GetData
	|
	|-NonGenericProperytWriter<char>.GetData
	|-NonGenericProperytWriter<short>.GetData
	|-NonGenericProperytWriter<ushort>.GetData
	|
	|-NonGenericProperytWriter<KeyValuePair<object, object>>.GetData
	|-NonGenericProperytWriter<DateTimeOffset>.GetData
	|-NonGenericProperytWriter<Decimal>.GetData
	|-NonGenericProperytWriter<Guid>.GetData
	|
	|-NonGenericProperytWriter<DateTime>.GetData
	|-NonGenericProperytWriter<long>.GetData
	|-NonGenericProperytWriter<IntPtr>.GetData
	|-NonGenericProperytWriter<TimeSpan>.GetData
	|-NonGenericProperytWriter<ulong>.GetData
	|-NonGenericProperytWriter<UIntPtr>.GetData
	|
	|-NonGenericProperytWriter<double>.GetData
	|
	|-NonGenericProperytWriter<int>.GetData
	|-NonGenericProperytWriter<uint>.GetData
	|
	|-NonGenericProperytWriter<object>.GetData
	|
	|-NonGenericProperytWriter<float>.GetData
	*/

}

internal class ClassPropertyWriter<ContainerType, ValueType> : PropertyAccessor<ContainerType> // TypeDefIndex: 1528
{
	private readonly TraceLoggingTypeInfo<ValueType> valueTypeInfo;
	private readonly ClassPropertyWriter.Getter<ContainerType, ValueType> getter;


	public void .ctor(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
	|-ClassPropertyWriter<bool, int>..ctor
	|
	|-ClassPropertyWriter<bool, long>..ctor
	|
	|-ClassPropertyWriter<bool, object>..ctor
	|
	|-ClassPropertyWriter<byte, int>..ctor
	|
	|-ClassPropertyWriter<byte, long>..ctor
	|
	|-ClassPropertyWriter<byte, object>..ctor
	|
	|-ClassPropertyWriter<char, int>..ctor
	|
	|-ClassPropertyWriter<char, long>..ctor
	|
	|-ClassPropertyWriter<char, object>..ctor
	|
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>..ctor
	|
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>..ctor
	|
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>..ctor
	|
	|-ClassPropertyWriter<DateTime, int>..ctor
	|
	|-ClassPropertyWriter<DateTime, long>..ctor
	|
	|-ClassPropertyWriter<DateTime, object>..ctor
	|
	|-ClassPropertyWriter<DateTimeOffset, int>..ctor
	|
	|-ClassPropertyWriter<DateTimeOffset, long>..ctor
	|
	|-ClassPropertyWriter<DateTimeOffset, object>..ctor
	|
	|-ClassPropertyWriter<Decimal, int>..ctor
	|
	|-ClassPropertyWriter<Decimal, long>..ctor
	|
	|-ClassPropertyWriter<Decimal, object>..ctor
	|
	|-ClassPropertyWriter<EmptyStruct, int>..ctor
	|
	|-ClassPropertyWriter<EmptyStruct, long>..ctor
	|
	|-ClassPropertyWriter<EmptyStruct, object>..ctor
	|
	|-ClassPropertyWriter<double, int>..ctor
	|
	|-ClassPropertyWriter<double, long>..ctor
	|
	|-ClassPropertyWriter<double, object>..ctor
	|
	|-ClassPropertyWriter<Guid, int>..ctor
	|
	|-ClassPropertyWriter<Guid, long>..ctor
	|
	|-ClassPropertyWriter<Guid, object>..ctor
	|
	|-ClassPropertyWriter<short, int>..ctor
	|
	|-ClassPropertyWriter<short, long>..ctor
	|
	|-ClassPropertyWriter<short, object>..ctor
	|
	|-ClassPropertyWriter<int, int>..ctor
	|
	|-ClassPropertyWriter<int, long>..ctor
	|
	|-ClassPropertyWriter<int, object>..ctor
	|
	|-ClassPropertyWriter<long, int>..ctor
	|
	|-ClassPropertyWriter<long, long>..ctor
	|
	|-ClassPropertyWriter<long, object>..ctor
	|
	|-ClassPropertyWriter<IntPtr, int>..ctor
	|
	|-ClassPropertyWriter<IntPtr, long>..ctor
	|
	|-ClassPropertyWriter<IntPtr, object>..ctor
	|
	|-ClassPropertyWriter<object, int>..ctor
	|
	|-ClassPropertyWriter<object, long>..ctor
	|
	|-ClassPropertyWriter<object, object>..ctor
	|
	|-ClassPropertyWriter<sbyte, int>..ctor
	|
	|-ClassPropertyWriter<sbyte, long>..ctor
	|
	|-ClassPropertyWriter<sbyte, object>..ctor
	|
	|-ClassPropertyWriter<float, int>..ctor
	|
	|-ClassPropertyWriter<float, long>..ctor
	|
	|-ClassPropertyWriter<float, object>..ctor
	|
	|-ClassPropertyWriter<TimeSpan, int>..ctor
	|
	|-ClassPropertyWriter<TimeSpan, long>..ctor
	|
	|-ClassPropertyWriter<TimeSpan, object>..ctor
	|
	|-ClassPropertyWriter<ushort, int>..ctor
	|
	|-ClassPropertyWriter<ushort, long>..ctor
	|
	|-ClassPropertyWriter<ushort, object>..ctor
	|
	|-ClassPropertyWriter<uint, int>..ctor
	|
	|-ClassPropertyWriter<uint, long>..ctor
	|
	|-ClassPropertyWriter<uint, object>..ctor
	|
	|-ClassPropertyWriter<ulong, int>..ctor
	|
	|-ClassPropertyWriter<ulong, long>..ctor
	|
	|-ClassPropertyWriter<ulong, object>..ctor
	|
	|-ClassPropertyWriter<UIntPtr, int>..ctor
	|
	|-ClassPropertyWriter<UIntPtr, long>..ctor
	|
	|-ClassPropertyWriter<UIntPtr, object>..ctor
	*/

	public override void Write(TraceLoggingDataCollector collector, ref ContainerType container) { }
	/* GenericInstMethod :
	|
	|-ClassPropertyWriter<bool, int>.Write
	|-ClassPropertyWriter<byte, int>.Write
	|-ClassPropertyWriter<sbyte, int>.Write
	|
	|-ClassPropertyWriter<bool, long>.Write
	|-ClassPropertyWriter<bool, object>.Write
	|-ClassPropertyWriter<byte, long>.Write
	|-ClassPropertyWriter<byte, object>.Write
	|-ClassPropertyWriter<sbyte, long>.Write
	|-ClassPropertyWriter<sbyte, object>.Write
	|
	|-ClassPropertyWriter<char, int>.Write
	|-ClassPropertyWriter<short, int>.Write
	|-ClassPropertyWriter<ushort, int>.Write
	|
	|-ClassPropertyWriter<char, long>.Write
	|-ClassPropertyWriter<char, object>.Write
	|-ClassPropertyWriter<short, long>.Write
	|-ClassPropertyWriter<short, object>.Write
	|-ClassPropertyWriter<ushort, long>.Write
	|-ClassPropertyWriter<ushort, object>.Write
	|
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>.Write
	|-ClassPropertyWriter<DateTimeOffset, int>.Write
	|-ClassPropertyWriter<Decimal, int>.Write
	|-ClassPropertyWriter<Guid, int>.Write
	|
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>.Write
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>.Write
	|-ClassPropertyWriter<DateTimeOffset, long>.Write
	|-ClassPropertyWriter<DateTimeOffset, object>.Write
	|-ClassPropertyWriter<Decimal, long>.Write
	|-ClassPropertyWriter<Decimal, object>.Write
	|-ClassPropertyWriter<Guid, long>.Write
	|-ClassPropertyWriter<Guid, object>.Write
	|
	|-ClassPropertyWriter<DateTime, int>.Write
	|-ClassPropertyWriter<TimeSpan, int>.Write
	|
	|-ClassPropertyWriter<DateTime, long>.Write
	|-ClassPropertyWriter<DateTime, object>.Write
	|-ClassPropertyWriter<TimeSpan, long>.Write
	|-ClassPropertyWriter<TimeSpan, object>.Write
	|
	|-ClassPropertyWriter<EmptyStruct, int>.Write
	|
	|-ClassPropertyWriter<EmptyStruct, long>.Write
	|-ClassPropertyWriter<EmptyStruct, object>.Write
	|
	|-ClassPropertyWriter<double, int>.Write
	|
	|-ClassPropertyWriter<double, long>.Write
	|-ClassPropertyWriter<double, object>.Write
	|
	|-ClassPropertyWriter<int, int>.Write
	|-ClassPropertyWriter<uint, int>.Write
	|
	|-ClassPropertyWriter<int, long>.Write
	|-ClassPropertyWriter<int, object>.Write
	|-ClassPropertyWriter<uint, long>.Write
	|-ClassPropertyWriter<uint, object>.Write
	|
	|-ClassPropertyWriter<long, int>.Write
	|-ClassPropertyWriter<IntPtr, int>.Write
	|-ClassPropertyWriter<ulong, int>.Write
	|-ClassPropertyWriter<UIntPtr, int>.Write
	|
	|-ClassPropertyWriter<long, long>.Write
	|-ClassPropertyWriter<long, object>.Write
	|-ClassPropertyWriter<IntPtr, long>.Write
	|-ClassPropertyWriter<IntPtr, object>.Write
	|-ClassPropertyWriter<ulong, long>.Write
	|-ClassPropertyWriter<ulong, object>.Write
	|-ClassPropertyWriter<UIntPtr, long>.Write
	|-ClassPropertyWriter<UIntPtr, object>.Write
	|
	|-ClassPropertyWriter<object, int>.Write
	|
	|-ClassPropertyWriter<object, long>.Write
	|-ClassPropertyWriter<object, object>.Write
	|
	|-ClassPropertyWriter<float, int>.Write
	|
	|-ClassPropertyWriter<float, long>.Write
	|-ClassPropertyWriter<float, object>.Write
	*/

	public override object GetData(ContainerType container) { }
	/* GenericInstMethod :
	|
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
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>.GetData
	|-ClassPropertyWriter<DateTimeOffset, int>.GetData
	|-ClassPropertyWriter<Decimal, int>.GetData
	|-ClassPropertyWriter<Guid, int>.GetData
	|
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>.GetData
	|-ClassPropertyWriter<DateTimeOffset, long>.GetData
	|-ClassPropertyWriter<Decimal, long>.GetData
	|-ClassPropertyWriter<Guid, long>.GetData
	|
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>.GetData
	|-ClassPropertyWriter<DateTimeOffset, object>.GetData
	|-ClassPropertyWriter<Decimal, object>.GetData
	|-ClassPropertyWriter<Guid, object>.GetData
	|
	|-ClassPropertyWriter<DateTime, int>.GetData
	|-ClassPropertyWriter<long, int>.GetData
	|-ClassPropertyWriter<IntPtr, int>.GetData
	|-ClassPropertyWriter<TimeSpan, int>.GetData
	|-ClassPropertyWriter<ulong, int>.GetData
	|-ClassPropertyWriter<UIntPtr, int>.GetData
	|
	|-ClassPropertyWriter<double, int>.GetData
	|
	|-ClassPropertyWriter<double, long>.GetData
	|-ClassPropertyWriter<float, long>.GetData
	|
	|-ClassPropertyWriter<double, object>.GetData
	|-ClassPropertyWriter<float, object>.GetData
	|
	|-ClassPropertyWriter<object, int>.GetData
	|
	|-ClassPropertyWriter<object, long>.GetData
	|
	|-ClassPropertyWriter<object, object>.GetData
	|
	|-ClassPropertyWriter<float, int>.GetData
	*/

}

internal sealed class NullTypeInfo<DataType> : TraceLoggingTypeInfo<DataType> // TypeDefIndex: 1531
{

	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-NullTypeInfo<EmptyStruct>.WriteMetadata
	|-NullTypeInfo<object>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref DataType value) { }
	/* GenericInstMethod :
	|
	|-NullTypeInfo<EmptyStruct>.WriteData
	|-NullTypeInfo<object>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-NullTypeInfo<EmptyStruct>.GetData
	|-NullTypeInfo<object>.GetData
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-NullTypeInfo<EmptyStruct>..ctor
	|-NullTypeInfo<object>..ctor
	*/

}

internal abstract class TraceLoggingTypeInfo<DataType> : TraceLoggingTypeInfo // TypeDefIndex: 1590
{
	private static TraceLoggingTypeInfo<DataType> instance;

	public static TraceLoggingTypeInfo<DataType> Instance { get; }


	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-TraceLoggingTypeInfo<bool>..ctor
	|
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
	|-TraceLoggingTypeInfo<byte>..ctor
	|
	|-TraceLoggingTypeInfo<char>..ctor
	|
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>..ctor
	|
	|-TraceLoggingTypeInfo<DateTime>..ctor
	|
	|-TraceLoggingTypeInfo<DateTimeOffset>..ctor
	|
	|-TraceLoggingTypeInfo<Decimal>..ctor
	|
	|-TraceLoggingTypeInfo<EmptyStruct>..ctor
	|
	|-TraceLoggingTypeInfo<double>..ctor
	|
	|-TraceLoggingTypeInfo<Guid>..ctor
	|
	|-TraceLoggingTypeInfo<short>..ctor
	|
	|-TraceLoggingTypeInfo<int>..ctor
	|
	|-TraceLoggingTypeInfo<long>..ctor
	|
	|-TraceLoggingTypeInfo<IntPtr>..ctor
	|
	|-TraceLoggingTypeInfo<sbyte>..ctor
	|
	|-TraceLoggingTypeInfo<float>..ctor
	|
	|-TraceLoggingTypeInfo<TimeSpan>..ctor
	|
	|-TraceLoggingTypeInfo<ushort>..ctor
	|
	|-TraceLoggingTypeInfo<uint>..ctor
	|
	|-TraceLoggingTypeInfo<ulong>..ctor
	|
	|-TraceLoggingTypeInfo<UIntPtr>..ctor
	*/

	protected void .ctor(string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags) { }
	/* GenericInstMethod :
	|
	|-TraceLoggingTypeInfo<bool>..ctor
	|
	|-TraceLoggingTypeInfo<byte>..ctor
	|
	|-TraceLoggingTypeInfo<char>..ctor
	|
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>..ctor
	|
	|-TraceLoggingTypeInfo<DateTime>..ctor
	|
	|-TraceLoggingTypeInfo<DateTimeOffset>..ctor
	|
	|-TraceLoggingTypeInfo<Decimal>..ctor
	|
	|-TraceLoggingTypeInfo<EmptyStruct>..ctor
	|
	|-TraceLoggingTypeInfo<double>..ctor
	|
	|-TraceLoggingTypeInfo<Guid>..ctor
	|
	|-TraceLoggingTypeInfo<short>..ctor
	|
	|-TraceLoggingTypeInfo<int>..ctor
	|
	|-TraceLoggingTypeInfo<long>..ctor
	|
	|-TraceLoggingTypeInfo<IntPtr>..ctor
	|
	|-TraceLoggingTypeInfo<object>..ctor
	|
	|-TraceLoggingTypeInfo<sbyte>..ctor
	|
	|-TraceLoggingTypeInfo<float>..ctor
	|
	|-TraceLoggingTypeInfo<TimeSpan>..ctor
	|
	|-TraceLoggingTypeInfo<ushort>..ctor
	|
	|-TraceLoggingTypeInfo<uint>..ctor
	|
	|-TraceLoggingTypeInfo<ulong>..ctor
	|
	|-TraceLoggingTypeInfo<UIntPtr>..ctor
	*/

	public static TraceLoggingTypeInfo<DataType> get_Instance() { }
	/* GenericInstMethod :
	|
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

	public abstract void WriteData(TraceLoggingDataCollector collector, ref DataType value);
	/* GenericInstMethod :
	|
	|-TraceLoggingTypeInfo<object>.WriteData
	*/

	public override void WriteObjectData(TraceLoggingDataCollector collector, object value) { }
	/* GenericInstMethod :
	|
	|-TraceLoggingTypeInfo<bool>.WriteObjectData
	|-TraceLoggingTypeInfo<byte>.WriteObjectData
	|-TraceLoggingTypeInfo<EmptyStruct>.WriteObjectData
	|-TraceLoggingTypeInfo<sbyte>.WriteObjectData
	|
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
	|-TraceLoggingTypeInfo<char>.WriteObjectData
	|-TraceLoggingTypeInfo<short>.WriteObjectData
	|-TraceLoggingTypeInfo<ushort>.WriteObjectData
	|
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.WriteObjectData
	|-TraceLoggingTypeInfo<DateTimeOffset>.WriteObjectData
	|-TraceLoggingTypeInfo<Decimal>.WriteObjectData
	|-TraceLoggingTypeInfo<Guid>.WriteObjectData
	|
	|-TraceLoggingTypeInfo<DateTime>.WriteObjectData
	|-TraceLoggingTypeInfo<long>.WriteObjectData
	|-TraceLoggingTypeInfo<IntPtr>.WriteObjectData
	|-TraceLoggingTypeInfo<TimeSpan>.WriteObjectData
	|-TraceLoggingTypeInfo<ulong>.WriteObjectData
	|-TraceLoggingTypeInfo<UIntPtr>.WriteObjectData
	|
	|-TraceLoggingTypeInfo<double>.WriteObjectData
	|
	|-TraceLoggingTypeInfo<int>.WriteObjectData
	|-TraceLoggingTypeInfo<uint>.WriteObjectData
	|
	|-TraceLoggingTypeInfo<float>.WriteObjectData
	*/

	internal static TraceLoggingTypeInfo<DataType> GetInstance(List<Type> recursionCheck) { }
	/* GenericInstMethod :
	|
	|-TraceLoggingTypeInfo<bool>.GetInstance
	|
	|-TraceLoggingTypeInfo<byte>.GetInstance
	|
	|-TraceLoggingTypeInfo<char>.GetInstance
	|
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.GetInstance
	|
	|-TraceLoggingTypeInfo<DateTime>.GetInstance
	|
	|-TraceLoggingTypeInfo<DateTimeOffset>.GetInstance
	|
	|-TraceLoggingTypeInfo<Decimal>.GetInstance
	|
	|-TraceLoggingTypeInfo<EmptyStruct>.GetInstance
	|
	|-TraceLoggingTypeInfo<double>.GetInstance
	|
	|-TraceLoggingTypeInfo<Guid>.GetInstance
	|
	|-TraceLoggingTypeInfo<short>.GetInstance
	|
	|-TraceLoggingTypeInfo<int>.GetInstance
	|
	|-TraceLoggingTypeInfo<long>.GetInstance
	|
	|-TraceLoggingTypeInfo<IntPtr>.GetInstance
	|
	|-TraceLoggingTypeInfo<object>.GetInstance
	|
	|-TraceLoggingTypeInfo<sbyte>.GetInstance
	|
	|-TraceLoggingTypeInfo<float>.GetInstance
	|
	|-TraceLoggingTypeInfo<TimeSpan>.GetInstance
	|
	|-TraceLoggingTypeInfo<ushort>.GetInstance
	|
	|-TraceLoggingTypeInfo<uint>.GetInstance
	|
	|-TraceLoggingTypeInfo<ulong>.GetInstance
	|
	|-TraceLoggingTypeInfo<UIntPtr>.GetInstance
	*/

	private static TraceLoggingTypeInfo<DataType> InitInstance() { }
	/* GenericInstMethod :
	|
	|-TraceLoggingTypeInfo<bool>.InitInstance
	|
	|-TraceLoggingTypeInfo<byte>.InitInstance
	|
	|-TraceLoggingTypeInfo<char>.InitInstance
	|
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.InitInstance
	|
	|-TraceLoggingTypeInfo<DateTime>.InitInstance
	|
	|-TraceLoggingTypeInfo<DateTimeOffset>.InitInstance
	|
	|-TraceLoggingTypeInfo<Decimal>.InitInstance
	|
	|-TraceLoggingTypeInfo<EmptyStruct>.InitInstance
	|
	|-TraceLoggingTypeInfo<double>.InitInstance
	|
	|-TraceLoggingTypeInfo<Guid>.InitInstance
	|
	|-TraceLoggingTypeInfo<short>.InitInstance
	|
	|-TraceLoggingTypeInfo<int>.InitInstance
	|
	|-TraceLoggingTypeInfo<long>.InitInstance
	|
	|-TraceLoggingTypeInfo<IntPtr>.InitInstance
	|
	|-TraceLoggingTypeInfo<object>.InitInstance
	|
	|-TraceLoggingTypeInfo<sbyte>.InitInstance
	|
	|-TraceLoggingTypeInfo<float>.InitInstance
	|
	|-TraceLoggingTypeInfo<TimeSpan>.InitInstance
	|
	|-TraceLoggingTypeInfo<ushort>.InitInstance
	|
	|-TraceLoggingTypeInfo<uint>.InitInstance
	|
	|-TraceLoggingTypeInfo<ulong>.InitInstance
	|
	|-TraceLoggingTypeInfo<UIntPtr>.InitInstance
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1635
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 0392525BCB01691D1F319D89F2C12BF93A478467
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 0588059ACBD52F7EA2835882F977A9CF72EB9775
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=84 0A1ADB22C1D3E1F4B2448EE3F27DF9DE63329C4C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 121EC59E23F7559B28D338D562528F6299C2DE22
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 1730F09044E91DB8371B849EFF5E6D17BDE4AED0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 1AEF3D8DF416A46288C91C724CBF7B154D9E5BF3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 1E41C4CD0767AEA21C00DEABA2EA9407F1E6CEA5
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 1FE6CE411858B3D864679DE2139FB081F08BFACD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 25420D0055076FA8D3E4DD96BC53AE24DE6E619F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1208 25CF935D2AE9EDF05DD75BCD47FF84D9255D6F6E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=42 29C1A61550F0E3260E1953D4FAD71C256218EF40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 2B33BEC8C30DFDC49DAFE20D3BDE19487850D717
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 2BA840FF6020B8FF623DBCB7188248CF853FAF4F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 2C840AFA48C27B9C05593E468C1232CA1CC74AFD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2D1DA5BB407F0C11C3B5116196C0C6374D932B20
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 2F71D2DA12F3CD0A6A112F5A5A75B4FDC6FE8547
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 34476C29F6F81C989CFCA42F7C06E84C66236834
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2382 35EED060772F2748D13B745DAEC8CD7BD3B87604
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 375F9AE9769A3D1DA789E9ACFE81F3A1BB14F0D3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1450 379C06C9E702D31469C29033F0DD63931EB349F5
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 399BD13E240F33F808CA7940293D6EC4E6FD5A00
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 39C9CE73C7B0619D409EF28344F687C1B5C130FE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=320 3C53AFB51FEC23491684C7BEDBC6D4E0F409F851
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 3E4BBF9D0CDD2E34F78AA7A9A3979DCE1F7B02BD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3E823444D2DFECF0F90B436B88F02A533CB376F1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 3FE6C283BCF384FD2C8789880DFF59664E2AB4A1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1665 40981BAA39513E58B28DCF0103CC04DE2A0A0444
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 40E7C49413D261F3F38AD3A870C0AC69C8BDA048
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 421EC7E82F2967DF6CA8C3605514DC6F29EE5845
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 433175D38B13FFE177FDD661A309F1B528B3F6E2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 46232052BC757E030490D851F265FB47FA100902
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 4858DB4AA76D3933F1CA9E6712D4FDB16903F628
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 4F7A8890F332B22B8DE0BD29D36FA7364748D76A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 536422B321459B242ADED7240B7447E904E083E3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1080 5382CEF491F422BFE0D6FC46EFAFF9EF9D4C89F3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 57218C316B6921E2CD61027A2387EDC31A2D9471
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 57F320D62696EC99727E0FE2045A05F1289CC0C6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 594A33A00BC4F785DFD43E3C6C44FBA1242CCAF3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 5BBDF8058D4235C33F2E8DCF76004031B6187A2F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 5BCD21C341BE6DDF8FFFAE1A23ABA24DCBB612BF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 5BFE2819B4778217C56416C7585FF0E56EBACD89
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 609C0E8D8DA86A09D6013D301C86BA8782C16B8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 62BAB0F245E66C3EB982CF5A7015F0A7C3382283
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 646036A65DECCD6835C914A46E6E44B729433B60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 65E32B4E150FD8D24B93B0D42A17F1DAD146162B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 6770974FEF1E98B9C1864370E2B5B786EB0EA39E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 67EEAD805D708D9AA4E14BF747E44CED801744F3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 6C71197D228427B2864C69B357FEF73D8C9D59DF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6CEE45445AFD150B047A5866FFA76AA651CDB7B7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 6D797C11E1D4FB68B6570CF2A92B792433527065
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 6FC754859E4EC74E447048364B216D825C6F8FE7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 704939CD172085D1295FCE3F1D92431D685D7AA2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 7088AAE49F0627B72729078DE6E3182DDCF8ED99
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 7341C933A70EAE383CC50C4B945ADB8E08F06737
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 7F42F2EDC974BE29B2746957416ED1AEFA605F47
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 7FE820C9CF0F0B90445A71F1D262D22E4F0C4C68
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=21252 811A927B7DADD378BE60BBDE794B9277AA9B50EC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 81917F1E21F3C22B9F916994547A614FB03E968E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 823566DA642D6EA356E15585921F2A4CA23D6760
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 82C2A59850B2E85BCE1A45A479537A384DF6098D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 82C383F8E6E4D3D87AEBB986A5D0077E8AD157C4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 871B9CF85DB352BAADF12BAE8F19857683E385AC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 89A040451C8CC5C8FB268BE44BDD74964C104155
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 8CAA092E783257106251246FF5C97F88D28517A6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2100 8D231DD55FE1AD7631BBD0905A17D5EB616C2154
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 8E10AC2F34545DFBBF3FCBC06055D797A8C99991
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=640 90A0542282A011472F94E97CEAE59F8B3B1A3291
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 93A63E90605400F34B49F0EB3361D23C89164BDA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 94841DD2F330CCB1089BF413E4FA9B04505152E2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 95264589E48F94B7857CFF398FB72A537E13EEE2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 95C48758CAE1715783472FB073AB158AB8A0AB2A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 973417296623D8DC6961B09664E54039E44CA5D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 99E2E88877D14C7DDC4E957A0ED7079CA0E9EB24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 A0074C15377C0C870B055927403EA9FA7A349D12
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=130 A1319B706116AB2C6D44483F60A7D0ACEA543396
	internal static readonly long A13AA52274D951A18029131A8DDECF76B569A15D = -44474084896931794;
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 A5444763673307F6828C748D4B9708CFC02B0959
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 A6732F8E7FC23766AB329B492D6BF82E3B33233F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 A705A106D95282BD15E13EEA6B0AF583FF786D83
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1018 A8A491E4CED49AE0027560476C10D933CE70C8DF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 AC791C4F39504D1184B73478943D0636258DA7B1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 AFCD4E1211233E99373A3367B23105A3D624B1F2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 B472ED77CB3B2A66D49D179F1EE2081B70A6AB61
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B4FBD02AAB5B16E0F4BD858DA5D9E348F3CE501D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 B53A2C6DF21FC88B17AEFC40EB895B8D63210CDF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 B6002BBF29B2704922EC3BBF0F9EE40ABF185D6B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=998 B881DA88BE0B68D8A6B6B6893822586B8B2CFC45
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=162 B8864ACB9DD69E3D42151513C840AAE270BF21C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=360 B8F87834C3597B2EEF22BA6D3A392CC925636401
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 B9B670F134A59FB1107AF01A9FE8F8E3980B3093
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 BEBC9ECC660A13EFC359BA3383411F698CFF25DB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 BEE1CFE5DFAA408E14CE4AF4DCD824FA2E42DCB7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 BF5EB60806ECB74EE484105DD9D6F463BF994867
	internal static readonly long C1A1100642BA9685B30A84D97348484E14AA1865 = 23362753784184900;
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C6F364A0AD934EFED8909446C215752E565D77C1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 CE5835130F5277F63D716FC9115526B0AC68FFAD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 CE93C35B755802BC4B3D180716B048FC61701EF7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D002CBBE1FF33721AF7C4D1D3ECAD1B7DB5258B7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D117188BE8D4609C0D531C51B0BB911A4219DEBE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=82 D76478B994B312CD022DCA207AA2254880D2FCC9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 D78D08081C7A5AD6FBA7A8DC86BCD6D7A577C636
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 DA19DB47B583EFCF7825D2E39D661D2354F28219
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DC2B830D8CD59AD6A4E4332D21CA0DCA2821AD82
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 E1827270A5FE1C85F5352A66FD87BA747213D006
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 E45BAB43F7D5D038672B3E3431F92E34A7AF2571
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 EA9506959484C55CFE0C139C624DF6060E285866
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=262 EB5E9A80A40096AB74D2E226650C7258D7BC5E9D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 EBF68F411848D603D059DFDEA2321C5A5EA78044
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 EC89C317EA2BF49A70EFF5E89C691E34733D7C37
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 F06E829E62F3AFBC045D064E10A4F5DF7C969612
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=11614 F073AA332018FDA0D572E99448FFF1D6422BD520
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 F34B0E10653402E8F788F8BC3F7CD7090928A429
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 F37E34BEADB04F34FCC31078A59F49856CA83D5B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=94 F512A9ABF88066AAEB92684F95CC05D8101B462B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 F8FAABB821300AA500C2CEC6091B3782A7FB44A4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2350 FCBD2781A933F0828ED4AAF88FD8B08D76DDD49B


	internal static uint ComputeStringHash(string s) { }

}

internal class __Il2CppComObject // TypeDefIndex: 1690
{

	protected override void Finalize() { }

}

internal sealed class __Il2CppComDelegate : __Il2CppComObject // TypeDefIndex: 1691
{

	protected override void Finalize() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1772
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D
	internal static readonly long 16968835DEF6DD3BB86EABA9DEC53BF41851CD6D = -1295888024253181014;
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9
	internal static readonly long 6FA00AC9FFFD87F82A38A7F9ECC8134F4A7052AF = 22609615381091406;
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B
	internal static readonly long AEA5F1CC5CFE1660539EDD691FE017F775F63A0D = 2676302836908902219;
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3


	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 2431
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 0701435C4E2C38EFE43C51BD22C114AB8B80124D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0EE6555EB2C89F29655BD23FAB0573D8D684331A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 0F6A1E2CEA2FA691D57F3F3FDCF9B82A3FBF6EE1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 161F91CE1721D8F16622810CBB39887D21C47031
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 2051D7520B96DCC12F2E4DE851CB9F203D623805
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 221CE291CD044114B4369175B9B91177F5932876
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 360487BE4278986419B568EFD887F6145383168A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 42DDBEE388AB59C20A3D7D4D6555E78D74A45AE1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 485F43E332C2F7530815B17C08DAC169A8F697E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 49C5BA13401986EC93E4677F52CBE2248184DFBD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 51E4CA1C2B009A2876C6E57D8E69E3502BCA3440
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 553E235E202D57C9F1156E7D232E02BBDC920165
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 574B9D4E4C39F6E8004181E5765B627B75EB1AD1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 5BE9DB9EEB9CBB4D22472CA9734B1FA1D36126BD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 5D100A87B697F3AE2015A5D3B2A7B5419E1BCA98
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=664 68D0F86889D5D656483EEE829BCEECDFEC91D8EA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 6A0D50D692745A6663128CD315B71079584F3E59
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 702F6A3276CBE481D247A77C20B5459FB94D07D2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7A32E1A19C182315E4263A65A72066492550D8CD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 8B4E5E81A88D29642679AFCE41DCA380F9000462
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 977375E4E1ED54F588076ACA36CC17E6C2195CB9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 99F0664C2AC8464B51252D92FC24F3834C6FB90C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 9E374D7263B2452E25DE3D6E617F6A728D98A439
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 A933F173482FF50754B4942AF8DFC584EF14A45B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 AB4EAD1DB94B8220FAAEDAA6A593B2E6DB0A8A9C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 B368804F0C6DAB083B253A6B106D0783D5C32E90
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 B9F0004E3873FDDCABFDA6174EA18F0859B637B4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BAD037B714E1CD1052149B51238A3D4351DD10B5
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C2D6E36D84DDA5D661B95D7B32D3F47CD7ACBF6C
	internal static readonly long DB9F879BE80CC2DA24DEF633D23DBB2B1ADBCC81 = 361700859878507267;
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 DCF398750721AA7A27A6BA56E99350329B06E8B1
	internal static readonly long EBC658B067B5C785A3F0BB67D73755F6FEE7F70C = 3659217647501344;
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 ED18A4A1FF7C89B400D7CA156BA8D11BB09E1DE4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 EE3413A2C088FF9432054D6E60A7CB6A498D25F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 F64F25EAE9A3D7A356813C4218000185541D7779
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1212 FB0C58D8B3094F018764CC6E3094B9576DB08069
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 FFE3F15642234E7FAD6951D432F1134D5AD15922


	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3155
{

[CompilerGeneratedAttribute]
internal sealed class <PrivateImplementationDetails>
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 0283A6AF88802AB45989B29549915BEA0F6CD515
	internal static readonly long 03F4297FCC30D0FD5E420E5D26E7FA711167C7EF = 2533317740920864;
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 1A39764B112685485A5BA7B2880D878B858C1A7A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3BE77BF818331C2D8400FFFFF9FADD3F16AD89AC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 53437C3B2572EDB9B8640C3195DF3BC2729C5EA1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 59F5BD34B6C013DEACC784F69C67E95150033A84
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 5BC3486B05BA8CF4689C7BDB198B3F477BB4E20C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 6F3AD3DC3AF8047587C4C9D696EB68A01FEF796E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 8821BF2BDFF225D177372C9F3E0A8286EE241FF4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 8E0EF3D67A3EB1863224EE3CACB424BC2F8CFBA3
	internal static readonly long 98A44A6F8606AE6F23FE230286C1D6FBCC407226 = 11540663026319392;
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 C02C28AFEBE998F767E4AF43E3BE8F5E9FA11536
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 CCEEADA43268372341F81AE0C9208C6856441C04
	internal static readonly long E5BC1BAFADE1862DD6E0B9FB632BFAA6C3873A78 = 2533330625626144;
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 EC5842B3154E1AF94500B57220EB9F684BCCC42A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 EEAFE8C6E1AB017237567305EE925C976CDB6458


	internal static uint ComputeStringHash(string s) { }

}

internal class EmptyEnumerable<TElement> // TypeDefIndex: 3221
{
	public static readonly TElement[] Instance;


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-EmptyEnumerable<byte>..cctor
	|-EmptyEnumerable<object>..cctor
	*/

}

internal class IdentityFunction<TElement> // TypeDefIndex: 3222
{
	public static Func<TElement, TElement> Instance { get; }


	public static Func<TElement, TElement> get_Instance() { }
	/* GenericInstMethod :
	|
	|-IdentityFunction<InventoryItem>.get_Instance
	|-IdentityFunction<object>.get_Instance
	|-IdentityFunction<Resolution>.get_Instance
	*/

}

internal class Set<TElement> // TypeDefIndex: 3230
{
	private int[] buckets;
	private Set.Slot<TElement>[] slots;
	private int count;
	private int freeList;
	private IEqualityComparer<TElement> comparer;


	public void .ctor(IEqualityComparer<TElement> comparer) { }
	/* GenericInstMethod :
	|
	|-Set<ServerInfo>..ctor
	|
	|-Set<char>..ctor
	|
	|-Set<object>..ctor
	|
	|-Set<float>..ctor
	|
	|-Set<Vector2>..ctor
	*/

	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-Set<ServerInfo>.Add
	|
	|-Set<char>.Add
	|-Set<object>.Add
	|
	|-Set<float>.Add
	|
	|-Set<Vector2>.Add
	*/

	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-Set<ServerInfo>.Find
	|
	|-Set<char>.Find
	|
	|-Set<object>.Find
	|
	|-Set<float>.Find
	|
	|-Set<Vector2>.Find
	*/

	private void Resize() { }
	/* GenericInstMethod :
	|
	|-Set<ServerInfo>.Resize
	|
	|-Set<char>.Resize
	|
	|-Set<object>.Resize
	|
	|-Set<float>.Resize
	|
	|-Set<Vector2>.Resize
	*/

	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-Set<ServerInfo>.InternalGetHashCode
	|
	|-Set<char>.InternalGetHashCode
	|
	|-Set<object>.InternalGetHashCode
	|
	|-Set<float>.InternalGetHashCode
	|
	|-Set<Vector2>.InternalGetHashCode
	*/

}

internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 3232
{
	private IEnumerable<TSource> source;
	private Func<TSource, TKey> keySelector;
	private Func<TSource, TElement> elementSelector;
	private IEqualityComparer<TKey> comparer;


	public void .ctor(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>..ctor
	|
	|-GroupedEnumerable<object, InventoryDefId, object>..ctor
	|
	|-GroupedEnumerable<object, Int32Enum, object>..ctor
	|
	|-GroupedEnumerable<object, object, object>..ctor
	|
	|-GroupedEnumerable<object, uint, object>..ctor
	|
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>..ctor
	*/

	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>.GetEnumerator
	|-GroupedEnumerable<object, InventoryDefId, object>.GetEnumerator
	|-GroupedEnumerable<object, Int32Enum, object>.GetEnumerator
	|-GroupedEnumerable<object, object, object>.GetEnumerator
	|-GroupedEnumerable<object, uint, object>.GetEnumerator
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, InventoryDefId, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, uint, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 3233
{
	internal IEnumerable<TElement> source;


	[IteratorStateMachineAttribute]
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-OrderedEnumerable<Demos.DemoInfo>.GetEnumerator
	|
	|-OrderedEnumerable<ServerInfo>.GetEnumerator
	|
	|-OrderedEnumerable<Item>.GetEnumerator
	|
	|-OrderedEnumerable<KeyValuePair<object, int>>.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, long>>.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, object>>.GetEnumerator
	|
	|-OrderedEnumerable<double>.GetEnumerator
	|-OrderedEnumerable<object>.GetEnumerator
	|-OrderedEnumerable<Resolution>.GetEnumerator
	*/

	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);
	/* GenericInstMethod :
	|
	|-OrderedEnumerable<object>.GetEnumerableSorter
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
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

	private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<DateTime>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<int>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<Int32Enum>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<object>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<Resolution>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<int>
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
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
{
	internal OrderedEnumerable<TElement> parent;
	internal Func<TElement, TKey> keySelector;
	internal IComparer<TKey> comparer;
	internal bool descending;


	internal void .ctor(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-OrderedEnumerable<Demos.DemoInfo, DateTime>..ctor
	|
	|-OrderedEnumerable<Demos.DemoInfo, object>..ctor
	|
	|-OrderedEnumerable<Demos.DemoInfo, TimeSpan>..ctor
	|
	|-OrderedEnumerable<ServerInfo, int>..ctor
	|
	|-OrderedEnumerable<ServerInfo, object>..ctor
	|
	|-OrderedEnumerable<ServerInfo, uint>..ctor
	|
	|-OrderedEnumerable<Item, DateTime>..ctor
	|
	|-OrderedEnumerable<KeyValuePair<object, int>, int>..ctor
	|
	|-OrderedEnumerable<KeyValuePair<object, long>, long>..ctor
	|
	|-OrderedEnumerable<KeyValuePair<object, object>, long>..ctor
	|
	|-OrderedEnumerable<double, double>..ctor
	|
	|-OrderedEnumerable<object, bool>..ctor
	|
	|-OrderedEnumerable<object, DateTime>..ctor
	|
	|-OrderedEnumerable<object, DateTimeOffset>..ctor
	|
	|-OrderedEnumerable<object, Guid>..ctor
	|
	|-OrderedEnumerable<object, int>..ctor
	|
	|-OrderedEnumerable<object, Int32Enum>..ctor
	|
	|-OrderedEnumerable<object, object>..ctor
	|
	|-OrderedEnumerable<object, float>..ctor
	|
	|-OrderedEnumerable<object, uint>..ctor
	|
	|-OrderedEnumerable<Resolution, int>..ctor
	*/

	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
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
{
	internal TElement[] items;
	internal int count;


	internal void .ctor(IEnumerable<TElement> source) { }
	/* GenericInstMethod :
	|
	|-Buffer<Debugging.EntityInfo>..ctor
	|
	|-Buffer<Demos.DemoInfo>..ctor
	|
	|-Buffer<GameStat.Stat>..ctor
	|
	|-Buffer<ItemSkinDirectory.Skin>..ctor
	|
	|-Buffer<FourBitNumber>..ctor
	|
	|-Buffer<SevenBitNumber>..ctor
	|
	|-Buffer<Option>..ctor
	|
	|-Buffer<ServerInfo>..ctor
	|
	|-Buffer<SkinnedMultiMesh.Part>..ctor
	|
	|-Buffer<InventoryDefId>..ctor
	|
	|-Buffer<InventoryItemId>..ctor
	|
	|-Buffer<InventoryItem>..ctor
	|
	|-Buffer<InventoryRecipe.Ingredient>..ctor
	|
	|-Buffer<InventoryRecipe>..ctor
	|
	|-Buffer<Item>..ctor
	|
	|-Buffer<byte>..ctor
	|
	|-Buffer<char>..ctor
	|
	|-Buffer<KeyValuePair<object, int>>..ctor
	|
	|-Buffer<KeyValuePair<object, long>>..ctor
	|
	|-Buffer<KeyValuePair<object, object>>..ctor
	|
	|-Buffer<double>..ctor
	|
	|-Buffer<int>..ctor
	|
	|-Buffer<Int32Enum>..ctor
	|
	|-Buffer<long>..ctor
	|
	|-Buffer<object>..ctor
	|
	|-Buffer<float>..ctor
	|
	|-Buffer<uint>..ctor
	|
	|-Buffer<Resolution>..ctor
	*/

	internal TElement[] ToArray() { }
	/* GenericInstMethod :
	|
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
	|-Buffer<float>.ToArray
	|-Buffer<uint>.ToArray
	|-Buffer<Resolution>.ToArray
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3258
{

[CompilerGeneratedAttribute]
internal sealed class <PrivateImplementationDetails>
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 0AA802CD6847EB893FE786B5EA5168B2FDCD7B93
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 0C4110BC17D746F018F47B49E0EB0D6590F69939
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 20733E1283D873EBE47133A95C233E11B76F5F11
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 21F4CBF8283FF1CAEB4A39316A97FC1D6DF1D35E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 23DFDCA6F045D4257BF5AC8CB1CF2EFADAFE9B94
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 30A0358B25B1372DD598BB4B1AC56AD6B8F08A47
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 5B5DF5A459E902D96F7DB0FB235A25346CA85C5D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 5BE411F1438EAEF33726D855E99011D5FECDDD4E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 A02DD1D8604EA8EC2D2BDA717A93A4EE85F13E53
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 AE2F76ECEF8B08F0BC7EA95DCFE945E1727927C9

}

public struct BatchQueryJob<CommandT, ResultT> // TypeDefIndex: 3307
{
	[ReadOnlyAttribute]
	internal NativeArray<CommandT> commands;
	internal NativeArray<ResultT> results;


	public void .ctor(NativeArray<CommandT> commands, NativeArray<ResultT> results) { }
	/* GenericInstMethod :
	|
	|-BatchQueryJob<RaycastCommand, RaycastHit>..ctor
	*/

}

internal class InvokableCall<T1> : BaseInvokableCall // TypeDefIndex: 3632
{
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private UnityAction<T1> Delegate;


	[CompilerGeneratedAttribute]
	protected void add_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-InvokableCall<Option>.add_Delegate
	|-InvokableCall<bool>.add_Delegate
	|-InvokableCall<int>.add_Delegate
	|-InvokableCall<Int32Enum>.add_Delegate
	|-InvokableCall<object>.add_Delegate
	|-InvokableCall<float>.add_Delegate
	|-InvokableCall<Color>.add_Delegate
	|-InvokableCall<Vector2>.add_Delegate
	*/

	[CompilerGeneratedAttribute]
	protected void remove_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-InvokableCall<Option>.remove_Delegate
	|-InvokableCall<bool>.remove_Delegate
	|-InvokableCall<int>.remove_Delegate
	|-InvokableCall<Int32Enum>.remove_Delegate
	|-InvokableCall<object>.remove_Delegate
	|-InvokableCall<float>.remove_Delegate
	|-InvokableCall<Color>.remove_Delegate
	|-InvokableCall<Vector2>.remove_Delegate
	*/

	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-InvokableCall<Option>..ctor
	|
	|-InvokableCall<bool>..ctor
	|
	|-InvokableCall<int>..ctor
	|
	|-InvokableCall<Int32Enum>..ctor
	|
	|-InvokableCall<object>..ctor
	|
	|-InvokableCall<float>..ctor
	|
	|-InvokableCall<Color>..ctor
	|
	|-InvokableCall<Vector2>..ctor
	*/

	public void .ctor(UnityAction<T1> action) { }
	/* GenericInstMethod :
	|
	|-InvokableCall<Option>..ctor
	|-InvokableCall<bool>..ctor
	|-InvokableCall<int>..ctor
	|-InvokableCall<Int32Enum>..ctor
	|-InvokableCall<object>..ctor
	|-InvokableCall<float>..ctor
	|-InvokableCall<Color>..ctor
	|-InvokableCall<Vector2>..ctor
	*/

	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-InvokableCall<Option>.Invoke
	|
	|-InvokableCall<bool>.Invoke
	|
	|-InvokableCall<int>.Invoke
	|
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-InvokableCall<object>.Invoke
	|
	|-InvokableCall<float>.Invoke
	|
	|-InvokableCall<Color>.Invoke
	|
	|-InvokableCall<Vector2>.Invoke
	*/

	public virtual void Invoke(T1 args0) { }
	/* GenericInstMethod :
	|
	|-InvokableCall<Option>.Invoke
	|
	|-InvokableCall<bool>.Invoke
	|
	|-InvokableCall<int>.Invoke
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-InvokableCall<object>.Invoke
	|
	|-InvokableCall<float>.Invoke
	|
	|-InvokableCall<Color>.Invoke
	|
	|-InvokableCall<Vector2>.Invoke
	*/

	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
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

public sealed class UnityAction<T0> : MulticastDelegate // TypeDefIndex: 3644
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
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

	public virtual void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-UnityAction<Option>.Invoke
	|
	|-UnityAction<bool>.Invoke
	|
	|-UnityAction<int>.Invoke
	|-UnityAction<Int32Enum>.Invoke
	|
	|-UnityAction<object>.Invoke
	|-UnityAction<Component>.Invoke
	|
	|-UnityAction<float>.Invoke
	|
	|-UnityAction<Color>.Invoke
	|
	|-UnityAction<Scene>.Invoke
	|
	|-UnityAction<Vector2>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T0 arg0, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-UnityAction<Option>.BeginInvoke
	|
	|-UnityAction<bool>.BeginInvoke
	|
	|-UnityAction<int>.BeginInvoke
	|
	|-UnityAction<Int32Enum>.BeginInvoke
	|
	|-UnityAction<object>.BeginInvoke
	|
	|-UnityAction<float>.BeginInvoke
	|
	|-UnityAction<Color>.BeginInvoke
	|
	|-UnityAction<Scene>.BeginInvoke
	|
	|-UnityAction<Vector2>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
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

public abstract class UnityEvent<T0> : UnityEventBase // TypeDefIndex: 3645
{
	private object[] m_InvokeArray;


	[RequiredByNativeCodeAttribute]
	public void .ctor() { }
	/* GenericInstMethod :
	|
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

	public void AddListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
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

	public void RemoveListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
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

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-UnityEvent<Brush>.FindMethod_Impl
	|-UnityEvent<object>.FindMethod_Impl
	|-UnityEvent<string>.FindMethod_Impl
	|-UnityEvent<BaseEventData>.FindMethod_Impl
	|-UnityEvent<MessageEventArgs>.FindMethod_Impl
	|
	|-UnityEvent<Option>.FindMethod_Impl
	|
	|-UnityEvent<bool>.FindMethod_Impl
	|
	|-UnityEvent<int>.FindMethod_Impl
	|
	|-UnityEvent<Int32Enum>.FindMethod_Impl
	|-UnityEvent<TouchScreenKeyboard.Status>.FindMethod_Impl
	|
	|-UnityEvent<float>.FindMethod_Impl
	|
	|-UnityEvent<Color>.FindMethod_Impl
	|
	|-UnityEvent<Vector2>.FindMethod_Impl
	*/

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
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

	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }
	/* GenericInstMethod :
	|
	|-UnityEvent<Option>.GetDelegate
	|-UnityEvent<bool>.GetDelegate
	|-UnityEvent<int>.GetDelegate
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<float>.GetDelegate
	|-UnityEvent<Color>.GetDelegate
	|-UnityEvent<Vector2>.GetDelegate
	*/

	public void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-UnityEvent<Brush>.Invoke
	|-UnityEvent<object>.Invoke
	|-UnityEvent<string>.Invoke
	|-UnityEvent<BaseEventData>.Invoke
	|-UnityEvent<MessageEventArgs>.Invoke
	|
	|-UnityEvent<Option>.Invoke
	|
	|-UnityEvent<bool>.Invoke
	|
	|-UnityEvent<int>.Invoke
	|
	|-UnityEvent<Int32Enum>.Invoke
	|-UnityEvent<TouchScreenKeyboard.Status>.Invoke
	|
	|-UnityEvent<float>.Invoke
	|
	|-UnityEvent<Color>.Invoke
	|
	|-UnityEvent<Vector2>.Invoke
	*/

}

public sealed class UnityAction<T0, T1> : MulticastDelegate // TypeDefIndex: 3646
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, object>..ctor
	|-UnityAction<ulong, object>..ctor
	|-UnityAction<Scene, Int32Enum>..ctor
	|-UnityAction<Scene, LoadSceneMode>..ctor
	|-UnityAction<Scene, Scene>..ctor
	|-UnityAction<Vector2, object>..ctor
	*/

	public virtual void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, object>.Invoke
	|
	|-UnityAction<ulong, object>.Invoke
	|
	|-UnityAction<Scene, Int32Enum>.Invoke
	|-UnityAction<Scene, LoadSceneMode>.Invoke
	|
	|-UnityAction<Scene, Scene>.Invoke
	|
	|-UnityAction<Vector2, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, object>.BeginInvoke
	|
	|-UnityAction<ulong, object>.BeginInvoke
	|
	|-UnityAction<Scene, Int32Enum>.BeginInvoke
	|
	|-UnityAction<Scene, Scene>.BeginInvoke
	|
	|-UnityAction<Vector2, object>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, object>.EndInvoke
	|-UnityAction<ulong, object>.EndInvoke
	|-UnityAction<Scene, Int32Enum>.EndInvoke
	|-UnityAction<Scene, Scene>.EndInvoke
	|-UnityAction<Vector2, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1> : UnityEventBase // TypeDefIndex: 3647
{
	private object[] m_InvokeArray;


	[RequiredByNativeCodeAttribute]
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-UnityEvent<object, object>..ctor
	|-UnityEvent<ulong, object>..ctor
	|-UnityEvent<ulong, string>..ctor
	|-UnityEvent<Vector2, Brush>..ctor
	|-UnityEvent<Vector2, object>..ctor
	*/

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-UnityEvent<object, object>.FindMethod_Impl
	|
	|-UnityEvent<ulong, object>.FindMethod_Impl
	|-UnityEvent<ulong, string>.FindMethod_Impl
	|
	|-UnityEvent<Vector2, Brush>.FindMethod_Impl
	|-UnityEvent<Vector2, object>.FindMethod_Impl
	*/

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-UnityEvent<object, object>.GetDelegate
	|-UnityEvent<ulong, object>.GetDelegate
	|-UnityEvent<ulong, string>.GetDelegate
	|-UnityEvent<Vector2, Brush>.GetDelegate
	|-UnityEvent<Vector2, object>.GetDelegate
	*/

	public void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-UnityEvent<object, object>.Invoke
	|
	|-UnityEvent<ulong, object>.Invoke
	|-UnityEvent<ulong, string>.Invoke
	|
	|-UnityEvent<Vector2, Brush>.Invoke
	|-UnityEvent<Vector2, object>.Invoke
	*/

}

public sealed class UnityAction<T0, T1, T2> : MulticastDelegate // TypeDefIndex: 3648
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, int, int>..ctor
	|-UnityAction<object, object, object>..ctor
	*/

	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, int, int>.Invoke
	|
	|-UnityAction<object, object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, int, int>.BeginInvoke
	|
	|-UnityAction<object, object, object>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, int, int>.EndInvoke
	|-UnityAction<object, object, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 3649
{
	private object[] m_InvokeArray;


	[RequiredByNativeCodeAttribute]
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-UnityEvent<object, int, int>..ctor
	|-UnityEvent<object, object, object>..ctor
	|-UnityEvent<string, int, int>..ctor
	*/

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-UnityEvent<object, int, int>.FindMethod_Impl
	|-UnityEvent<string, int, int>.FindMethod_Impl
	|
	|-UnityEvent<object, object, object>.FindMethod_Impl
	*/

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-UnityEvent<object, int, int>.GetDelegate
	|-UnityEvent<object, object, object>.GetDelegate
	|-UnityEvent<string, int, int>.GetDelegate
	*/

	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-UnityEvent<object, int, int>.Invoke
	|-UnityEvent<string, int, int>.Invoke
	|
	|-UnityEvent<object, object, object>.Invoke
	*/

}

public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 3650
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, object, object, object>..ctor
	*/

	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, object, object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, object, object, object>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-UnityAction<object, object, object, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1, T2, T3> : UnityEventBase // TypeDefIndex: 3651
{
	private object[] m_InvokeArray;


	[RequiredByNativeCodeAttribute]
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-UnityEvent<object, object, object, object>..ctor
	*/

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-UnityEvent<object, object, object, object>.FindMethod_Impl
	*/

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-UnityEvent<object, object, object, object>.GetDelegate
	*/

}

public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 3946
{

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-IntegratedSubsystemDescriptor<object>..ctor
	|-IntegratedSubsystemDescriptor<XRDisplaySubsystem>..ctor
	|-IntegratedSubsystemDescriptor<XRInputSubsystem>..ctor
	|-IntegratedSubsystemDescriptor<XRMeshSubsystem>..ctor
	*/

}

public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem // TypeDefIndex: 3952
{

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-IntegratedSubsystem<object>..ctor
	|-IntegratedSubsystem<XRDisplaySubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRInputSubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRMeshSubsystemDescriptor>..ctor
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4071
{

	internal static uint ComputeStringHash(string s) { }

}

internal abstract class RBTree<K> : IEnumerable // TypeDefIndex: 4291
{
	private RBTree.TreePage<K>[] _pageTable;
	private int[] _pageTableMap;
	private int _inUsePageCount;
	private int _nextFreePageLine;
	public int root;
	private int _version;
	private int _inUseNodeCount;
	private int _inUseSatelliteTreeCount;
	private readonly TreeAccessMethod _accessMethod;

	public int Count { get; }
	public bool HasDuplicates { get; }
	public K Item { get; }


	protected abstract int CompareNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RBTree<object>.CompareNode
	*/

	protected abstract int CompareSateliteTreeNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RBTree<object>.CompareSateliteTreeNode
	*/

	protected void .ctor(TreeAccessMethod accessMethod) { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>..ctor
	|-RBTree<int>..ctor
	|-RBTree<object>..ctor
	*/

	private void InitTree() { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.InitTree
	|
	|-RBTree<object>.InitTree
	*/

	private void FreePage(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.FreePage
	|-RBTree<object>.FreePage
	*/

	private RBTree.TreePage<K> AllocPage(int size) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.AllocPage
	|
	|-RBTree<object>.AllocPage
	*/

	private void MarkPageFull(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.MarkPageFull
	|-RBTree<object>.MarkPageFull
	*/

	private void MarkPageFree(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.MarkPageFree
	|-RBTree<object>.MarkPageFree
	*/

	private static int GetIntValueFromBitMap(uint bitMap) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.GetIntValueFromBitMap
	|-RBTree<object>.GetIntValueFromBitMap
	*/

	private void FreeNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.FreeNode
	|
	|-RBTree<object>.FreeNode
	*/

	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.GetIndexOfPageWithFreeSlot
	|
	|-RBTree<object>.GetIndexOfPageWithFreeSlot
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>.get_Count
	|-RBTree<int>.get_Count
	|-RBTree<object>.get_Count
	*/

	public bool get_HasDuplicates() { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.get_HasDuplicates
	|-RBTree<object>.get_HasDuplicates
	*/

	private int GetNewNode(K key) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.GetNewNode
	|
	|-RBTree<object>.GetNewNode
	*/

	private int Successor(int x_id) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.Successor
	|-RBTree<object>.Successor
	*/

	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.Successor
	|
	|-RBTree<object>.Successor
	*/

	private int Minimum(int x_id) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.Minimum
	|-RBTree<object>.Minimum
	*/

	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.LeftRotate
	|
	|-RBTree<object>.LeftRotate
	*/

	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.RightRotate
	|
	|-RBTree<object>.RightRotate
	*/

	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.RBInsert
	|
	|-RBTree<object>.RBInsert
	*/

	public void UpdateNodeKey(K currentKey, K newKey) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.UpdateNodeKey
	|
	|-RBTree<object>.UpdateNodeKey
	*/

	public K DeleteByIndex(int i) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.DeleteByIndex
	|
	|-RBTree<object>.DeleteByIndex
	*/

	public int RBDelete(int z_id) { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>.RBDelete
	|-RBTree<int>.RBDelete
	|-RBTree<object>.RBDelete
	*/

	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.RBDeleteX
	|
	|-RBTree<object>.RBDeleteX
	*/

	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.RBDeleteFixup
	|
	|-RBTree<object>.RBDeleteFixup
	*/

	private int SearchSubTree(int root_id, K key) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.SearchSubTree
	|
	|-RBTree<object>.SearchSubTree
	*/

	public K get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>.get_Item
	|-RBTree<int>.get_Item
	|-RBTree<object>.get_Item
	*/

	private RBTree.NodePath<K> GetNodeByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.GetNodeByKey
	|
	|-RBTree<object>.GetNodeByKey
	*/

	public int GetIndexByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.GetIndexByKey
	|-RBTree<object>.GetIndexByKey
	*/

	public int GetIndexByNode(int node) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.GetIndexByNode
	|
	|-RBTree<object>.GetIndexByNode
	*/

	private int GetIndexByNodePath(RBTree.NodePath<K> path) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.GetIndexByNodePath
	|-RBTree<object>.GetIndexByNodePath
	*/

	private int ComputeIndexByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.ComputeIndexByNode
	|-RBTree<object>.ComputeIndexByNode
	*/

	private int ComputeIndexWithSatelliteByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.ComputeIndexWithSatelliteByNode
	|-RBTree<object>.ComputeIndexWithSatelliteByNode
	*/

	private RBTree.NodePath<K> GetNodeByIndex(int userIndex) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.GetNodeByIndex
	|
	|-RBTree<object>.GetNodeByIndex
	*/

	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.ComputeNodeByIndex
	|-RBTree<object>.ComputeNodeByIndex
	*/

	private int ComputeNodeByIndex(int x_id, int index) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.ComputeNodeByIndex
	|-RBTree<object>.ComputeNodeByIndex
	*/

	public int Insert(K item) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.Insert
	|-RBTree<object>.Insert
	*/

	public int Add(K item) { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>.Add
	|-RBTree<int>.Add
	|-RBTree<object>.Add
	*/

	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>.GetEnumerator
	|-RBTree<object>.GetEnumerator
	|
	|-RBTree<int>.GetEnumerator
	*/

	public int IndexOf(int nodeId, K item) { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>.IndexOf
	|-RBTree<object>.IndexOf
	|
	|-RBTree<int>.IndexOf
	*/

	public int Insert(int position, K item) { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>.Insert
	|-RBTree<int>.Insert
	|-RBTree<object>.Insert
	*/

	public int InsertAt(int position, K item, bool append) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.InsertAt
	|
	|-RBTree<object>.InsertAt
	*/

	public void RemoveAt(int position) { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>.RemoveAt
	|-RBTree<int>.RemoveAt
	|-RBTree<object>.RemoveAt
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>.Clear
	|-RBTree<int>.Clear
	|-RBTree<object>.Clear
	*/

	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>.CopyTo
	|-RBTree<object>.CopyTo
	|
	|-RBTree<int>.CopyTo
	*/

	public void CopyTo(K[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RBTree<DataRow>.CopyTo
	|-RBTree<object>.CopyTo
	|
	|-RBTree<int>.CopyTo
	*/

	private void SetRight(int nodeId, int rightNodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.SetRight
	|
	|-RBTree<object>.SetRight
	*/

	private void SetLeft(int nodeId, int leftNodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.SetLeft
	|
	|-RBTree<object>.SetLeft
	*/

	private void SetParent(int nodeId, int parentNodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.SetParent
	|
	|-RBTree<object>.SetParent
	*/

	private void SetColor(int nodeId, RBTree.NodeColor<K> color) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.SetColor
	|
	|-RBTree<object>.SetColor
	*/

	private void SetKey(int nodeId, K key) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.SetKey
	|
	|-RBTree<object>.SetKey
	*/

	private void SetNext(int nodeId, int nextNodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.SetNext
	|
	|-RBTree<object>.SetNext
	*/

	private void SetSubTreeSize(int nodeId, int size) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.SetSubTreeSize
	|
	|-RBTree<object>.SetSubTreeSize
	*/

	private void IncreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.IncreaseSize
	|
	|-RBTree<object>.IncreaseSize
	*/

	private void RecomputeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.RecomputeSize
	|
	|-RBTree<object>.RecomputeSize
	*/

	private void DecreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.DecreaseSize
	|
	|-RBTree<object>.DecreaseSize
	*/

	public int Right(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.Right
	|
	|-RBTree<object>.Right
	*/

	public int Left(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.Left
	|
	|-RBTree<object>.Left
	*/

	public int Parent(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.Parent
	|
	|-RBTree<object>.Parent
	*/

	private RBTree.NodeColor<K> color(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.color
	|
	|-RBTree<object>.color
	*/

	public int Next(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.Next
	|
	|-RBTree<object>.Next
	*/

	public int SubTreeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.SubTreeSize
	|
	|-RBTree<object>.SubTreeSize
	*/

	public K Key(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RBTree<int>.Key
	|
	|-RBTree<object>.Key
	*/

}

internal sealed class Listeners<TElem> // TypeDefIndex: 4309
{
	private readonly List<TElem> _listeners;
	private readonly Listeners.Func<TElem, TElem, bool> _filter;
	private readonly int _objectID;
	private int _listenerReaderCount;

	internal bool HasListeners { get; }


	internal void .ctor(int ObjectID, Listeners.Func<TElem, TElem, bool> notifyFilter) { }
	/* GenericInstMethod :
	|
	|-Listeners<DataViewListener>..ctor
	|-Listeners<object>..ctor
	*/

	internal bool get_HasListeners() { }
	/* GenericInstMethod :
	|
	|-Listeners<DataViewListener>.get_HasListeners
	|-Listeners<object>.get_HasListeners
	*/

	internal void Add(TElem listener) { }
	/* GenericInstMethod :
	|
	|-Listeners<DataViewListener>.Add
	|-Listeners<object>.Add
	*/

	internal int IndexOfReference(TElem listener) { }
	/* GenericInstMethod :
	|
	|-Listeners<object>.IndexOfReference
	*/

	internal void Remove(TElem listener) { }
	/* GenericInstMethod :
	|
	|-Listeners<DataViewListener>.Remove
	|-Listeners<object>.Remove
	*/

	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners.Action<TElem, TElem, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-Listeners<DataViewListener>.Notify<ListChangedEventArgs, bool, bool>
	|-Listeners<object>.Notify<object, bool, bool>
	|
	|-Listeners<DataViewListener>.Notify<ListChangedType, DataRow, bool>
	|-Listeners<object>.Notify<Int32Enum, object, bool>
	|
	|-Listeners<object>.Notify<object, object, object>
	*/

	private void RemoveNullListeners(int nullIndex) { }
	/* GenericInstMethod :
	|
	|-Listeners<object>.RemoveNullListeners
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4441
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0EE6555EB2C89F29655BD23FAB0573D8D684331A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 229F48C8598232AD9236772DD710E64615D0EE51
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 547FF12759F2EA9866F3E2095113686A6379ABBF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 57F92A12C48A0856350D3C95C4145F2AF4C9DEFF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 624B37B4C211942F3422DFFEAE9F44901E57339C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 FA7899481F1198B5A3F90368A998C285FCE19878
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 FF8FD0AC7542FD42A8A7C8D145E120345BA51C56

}

internal sealed class _AndroidJNIHelper // TypeDefIndex: 4476
{

	public static IntPtr CreateJavaProxy(IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCodeAttribute]
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	public static jvalue[] CreateJNIArgArray(object[] args) { }

	public static object UnboxArray(AndroidJavaObject obj) { }

	public static object Unbox(AndroidJavaObject obj) { }

	public static AndroidJavaObject Box(object obj) { }

	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	public static IntPtr ConvertToJNIArray(Array array) { }

	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	*/

	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
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

	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	public static string GetSignature(object obj) { }

	public static string GetSignature(object[] args) { }

	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-_AndroidJNIHelper.GetSignature<bool>
	|
	|-_AndroidJNIHelper.GetSignature<char>
	|
	|-_AndroidJNIHelper.GetSignature<double>
	|
	|-_AndroidJNIHelper.GetSignature<short>
	|
	|-_AndroidJNIHelper.GetSignature<int>
	|
	|-_AndroidJNIHelper.GetSignature<long>
	|
	|-_AndroidJNIHelper.GetSignature<object>
	|
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|
	|-_AndroidJNIHelper.GetSignature<float>
	*/

}

public class Memoized<TResult, TArgs> // TypeDefIndex: 4830
{
	private readonly Func<TArgs, TResult> _factory;
	private readonly Dictionary<TArgs, TResult> _cache;


	public void .ctor(Func<TArgs, TResult> factory) { }
	/* GenericInstMethod :
	|
	|-Memoized<object, int>..ctor
	|-Memoized<Material[], int>..ctor
	|
	|-Memoized<object, object>..ctor
	|-Memoized<string, string>..ctor
	|
	|-Memoized<object, ValueTuple<Int32Enum, int>>..ctor
	|-Memoized<string, ValueTuple<ItemDefinition.AmountType, int>>..ctor
	*/

	public TResult Get(TArgs args) { }
	/* GenericInstMethod :
	|
	|-Memoized<string, string>.Get
	|-Memoized<object, object>.Get
	|
	|-Memoized<string, ValueTuple<ItemDefinition.AmountType, int>>.Get
	|-Memoized<object, ValueTuple<Int32Enum, int>>.Get
	|
	|-Memoized<Material[], int>.Get
	|-Memoized<object, int>.Get
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4855
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=146 062825E0D4AB4302B73500604BF9520511ACFD15

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4905
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=104 1D1E8406C3A31F2298952B0976625EEDFB010FDC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 339A8BB625A037BA37DB4DF24A276E689D62172D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 48DE754CC0C776DAD1A85DB81BEFAAADE3A447E9
	internal static readonly long A5F5D64EF7BB696455C9841B907D2E09986EA902 = 2533317740920876;


	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5102
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5569
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5 B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9


	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5625
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 BA8C008E9A9CA9629B0D5A47EB9DFDC7E9E88D61

}

internal class PriorityQueue<TPriority, TItem> // TypeDefIndex: 5677
{
	private readonly SortedDictionary<TPriority, Queue<TItem>> _subqueues;

	public bool HasItems { get; }


	public void .ctor(IComparer<TPriority> priorityComparer) { }
	/* GenericInstMethod :
	|
	|-PriorityQueue<long, object>..ctor
	|-PriorityQueue<object, object>..ctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-PriorityQueue<long, TimedBlock>..ctor
	|-PriorityQueue<long, object>..ctor
	|-PriorityQueue<object, object>..ctor
	*/

	public void Enqueue(TPriority priority, TItem item) { }
	/* GenericInstMethod :
	|
	|-PriorityQueue<long, TimedBlock>.Enqueue
	|-PriorityQueue<long, object>.Enqueue
	|-PriorityQueue<object, object>.Enqueue
	*/

	private void AddQueueOfPriority(TPriority priority) { }
	/* GenericInstMethod :
	|
	|-PriorityQueue<long, object>.AddQueueOfPriority
	|-PriorityQueue<object, object>.AddQueueOfPriority
	*/

	public TItem Peek() { }
	/* GenericInstMethod :
	|
	|-PriorityQueue<long, TimedBlock>.Peek
	|-PriorityQueue<long, object>.Peek
	|
	|-PriorityQueue<object, object>.Peek
	*/

	public bool get_HasItems() { }
	/* GenericInstMethod :
	|
	|-PriorityQueue<long, TimedBlock>.get_HasItems
	|-PriorityQueue<long, object>.get_HasItems
	|-PriorityQueue<object, object>.get_HasItems
	*/

	public TItem Dequeue() { }
	/* GenericInstMethod :
	|
	|-PriorityQueue<long, TimedBlock>.Dequeue
	|-PriorityQueue<long, object>.Dequeue
	|
	|-PriorityQueue<object, object>.Dequeue
	*/

	private TItem DequeueFromHighPriorityQueue() { }
	/* GenericInstMethod :
	|
	|-PriorityQueue<long, object>.DequeueFromHighPriorityQueue
	|-PriorityQueue<object, object>.DequeueFromHighPriorityQueue
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5686
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 00C40B3F013EDA60390F2E849C4581815A9419E4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 03B569C38E3CD6B720388919D43735A904012C52
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 1FDC8DB567F5AAA7068D0D2A601CD71657CBDF38
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 373B494F210C656134C5728D551D4C97B013EB33
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 6BC4EAB0D604C8D4599021AD611C5DBA7FF7E306
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 89CE0E8EA590FD37283D6BEFD9E6805C8C47ADBD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 DB7C763C9670DD0F6ED34B75B3410A39D835F964
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 ED032026472FF77A8A17BA4AFF3FC57AF4B4BF79

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5821
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=127 A097044521F478B3A2A9A3AC52887BA733E4DE56


	internal static uint ComputeStringHash(string s) { }

}

internal sealed class XHashtable<TValue> // TypeDefIndex: 5827
{
	private XHashtable.XHashtableState<TValue> state;


	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-XHashtable<object>..ctor
	|-XHashtable<WeakReference>..ctor
	|-XHashtable<XName>..ctor
	*/

	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-XHashtable<object>.TryGetValue
	|-XHashtable<WeakReference>.TryGetValue
	|-XHashtable<XName>.TryGetValue
	*/

	public TValue Add(TValue value) { }
	/* GenericInstMethod :
	|
	|-XHashtable<object>.Add
	|-XHashtable<WeakReference>.Add
	|-XHashtable<XName>.Add
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5861
{

[CompilerGeneratedAttribute]
internal sealed class <PrivateImplementationDetails>

	internal static uint ComputeStringHash(string s) { }

}

internal sealed class MethodCall<T, TResult> : MulticastDelegate // TypeDefIndex: 5939
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-MethodCall<object, object>..ctor
	*/

	public virtual TResult Invoke(T target, object[] args) { }
	/* GenericInstMethod :
	|
	|-MethodCall<object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T target, object[] args, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-MethodCall<object, object>.BeginInvoke
	*/

	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-MethodCall<object, object>.EndInvoke
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6157
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 ADFD2E1C801C825415DD53F4F2F72A13B389313C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 D40004AB0E92BF6C8DFE481B56BE3D04ABDA76EB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6271
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 553AD71118F2B31C74BC988917343BADFA8F78EE

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6647
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 373B494F210C656134C5728D551D4C97B013EB33
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 E03C5B88B476F381E452F92C935A5B86131DFC4A

}

public class FastAction<A> // TypeDefIndex: 6680
{
	private LinkedList<Action<A>> delegates;
	private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup;


	public void Add(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-FastAction<bool>.Add
	|-FastAction<object>.Add
	|-FastAction<Object>.Add
	*/

	public void Remove(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-FastAction<bool>.Remove
	|-FastAction<object>.Remove
	|-FastAction<Object>.Remove
	*/

	public void Call(A a) { }
	/* GenericInstMethod :
	|
	|-FastAction<bool>.Call
	|
	|-FastAction<object>.Call
	|-FastAction<TMP_ColorGradient>.Call
	|-FastAction<Object>.Call
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-FastAction<bool>..ctor
	|-FastAction<object>..ctor
	|-FastAction<TMP_ColorGradient>..ctor
	|-FastAction<Object>..ctor
	*/

}

public class FastAction<A, B> // TypeDefIndex: 6681
{
	private LinkedList<Action<A, B>> delegates;
	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup;


	public void Add(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-FastAction<bool, object>.Add
	|-FastAction<object, object>.Add
	*/

	public void Remove(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-FastAction<bool, object>.Remove
	|-FastAction<object, object>.Remove
	*/

	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-FastAction<bool, object>.Call
	|-FastAction<bool, TMP_FontAsset>.Call
	|-FastAction<bool, TextMeshPro>.Call
	|-FastAction<bool, TextMeshProUGUI>.Call
	|-FastAction<bool, Material>.Call
	|-FastAction<bool, Object>.Call
	|
	|-FastAction<object, object>.Call
	|-FastAction<object, Compute_DT_EventArgs>.Call
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
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

public class FastAction<A, B, C> // TypeDefIndex: 6682
{
	private LinkedList<Action<A, B, C>> delegates;
	private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup;


	public void Add(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-FastAction<object, object, object>.Add
	*/

	public void Remove(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-FastAction<object, object, object>.Remove
	*/

	public void Call(A a, B b, C c) { }
	/* GenericInstMethod :
	|
	|-FastAction<object, object, object>.Call
	|-FastAction<GameObject, Material, Material>.Call
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-FastAction<object, object, object>..ctor
	|-FastAction<GameObject, Material, Material>..ctor
	*/

}

public enum _HorizontalAlignmentOptions // TypeDefIndex: 6769
{
	public int value__;
	public const _HorizontalAlignmentOptions Left = 1;
	public const _HorizontalAlignmentOptions Center = 2;
	public const _HorizontalAlignmentOptions Right = 4;
	public const _HorizontalAlignmentOptions Justified = 8;
	public const _HorizontalAlignmentOptions Flush = 16;
	public const _HorizontalAlignmentOptions Geometry = 32;

}

public enum _VerticalAlignmentOptions // TypeDefIndex: 6770
{
	public int value__;
	public const _VerticalAlignmentOptions Top = 256;
	public const _VerticalAlignmentOptions Middle = 512;
	public const _VerticalAlignmentOptions Bottom = 1024;
	public const _VerticalAlignmentOptions Baseline = 2048;
	public const _VerticalAlignmentOptions Geometry = 4096;
	public const _VerticalAlignmentOptions Capline = 8192;

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6812
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46

}

internal class <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA} // TypeDefIndex: 6889
{
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=32 $$method0x600002d-1
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=32 $$method0x600002d-2
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=128 $$method0x600002d-3
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=256 $$method0x600002d-4

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6977
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 B633673BF635D4C719EF5A0496BD28129A8CE5D3B76217371B6C1FDDFFDD780B

}

internal class <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7} // TypeDefIndex: 7008
{
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=76 $$method0x6000504-1
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=68 $$method0x6000505-1
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=6144 $$method0x6000507-1
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=384 $$method0x6000507-2
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 $$method0x6000507-3
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 $$method0x6000507-4
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000507-5
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000507-6
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 $$method0x6000509-1
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000509-2
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=76 $$method0x6000509-3
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=19 $$method0x6000509-4
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=512 $$method0x6000509-5
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=256 $$method0x6000509-6
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 $$method0x6000509-7
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000509-8
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=1152 $$method0x6000475-1
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000475-2

}

internal class <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8} // TypeDefIndex: 7033
{
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=32 $$method0x600007d-1
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=32 $$method0x600007d-2
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=128 $$method0x600007d-3
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=256 $$method0x600007d-4

}

public struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> // TypeDefIndex: 7128
{
	internal readonly object _obj;
	internal readonly TResult _result;
	internal readonly short _token;
	internal readonly bool _continueOnCapturedContext;

	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TResult Result { get; }


	public void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-ValueTask<bool>..ctor
	|
	|-ValueTask<object>..ctor
	*/

	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-ValueTask<bool>..ctor
	|
	|-ValueTask<object>..ctor
	*/

	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-ValueTask<bool>.GetHashCode
	|
	|-ValueTask<object>.GetHashCode
	*/

	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-ValueTask<bool>.Equals
	|
	|-ValueTask<object>.Equals
	*/

	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-ValueTask<bool>.Equals
	|
	|-ValueTask<object>.Equals
	*/

	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-ValueTask<bool>.get_IsCompleted
	|
	|-ValueTask<object>.get_IsCompleted
	*/

	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-ValueTask<bool>.get_IsCompletedSuccessfully
	|
	|-ValueTask<object>.get_IsCompletedSuccessfully
	*/

	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-ValueTask<bool>.get_Result
	|
	|-ValueTask<object>.get_Result
	*/

	public ValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-ValueTask<bool>.GetAwaiter
	|
	|-ValueTask<object>.GetAwaiter
	*/

	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-ValueTask<bool>.ToString
	|
	|-ValueTask<object>.ToString
	*/

}

public struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 7138
{
	private readonly ValueTask<TResult> _value;

	public bool IsCompleted { get; }


	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-ValueTaskAwaiter<bool>..ctor
	|
	|-ValueTaskAwaiter<object>..ctor
	*/

	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-ValueTaskAwaiter<bool>.get_IsCompleted
	|
	|-ValueTaskAwaiter<object>.get_IsCompleted
	*/

	[StackTraceHiddenAttribute]
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-ValueTaskAwaiter<bool>.GetResult
	|
	|-ValueTaskAwaiter<object>.GetResult
	*/

	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-ValueTaskAwaiter<bool>.OnCompleted
	|
	|-ValueTaskAwaiter<object>.OnCompleted
	*/

	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-ValueTaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-ValueTaskAwaiter<object>.UnsafeOnCompleted
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7380
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 C92FBDBB320D6C40BEB41D97EE6C7B301C4ADB1D

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7431
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 021F8912B268BE164A590D1440F05920A3F2A63B9874F994402C7AFFC6F92F82
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 02E68C9160BF270CAF19E18D3A77BC2EAA90EFCB3ECA3C454B58CD5BBA5FF7ED
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 047D891CAC8D4F883998ACEFD1EB63F6A679046FFD19EC1276A057F847EE37F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 06ADCD404637282636289E77FA01C56630CB4945332C96D5FA2D9239FE0D6B04
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 06D49AE61368F7B7C195381125B5A5E8F6830EA024D49F5C1A62950E74DBAF3D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 091971E0756262C068D16B941EA6256855E94532833A9CE3374D9768E27E4596
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 124360CE49E1C84604EFA93F8F0C3292C1D216DB605CF153414D893922B18C9F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 13BE6783CC652C89CC0161446DBD67966CAC410DEA4DE4279FC767A259EFD546
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 1B8D49F1227D3FC61644822B9FC00CE70A3B2438A1064323BFBE6A022A26F042
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 1C01F69BD2391DE00F8F1B377D2D9E5991674702AD777030BA910AC531E4B0FE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 22E5D3D9ABC124EE0214CEF7079F24CFF9BE30FD6AF6BA5BBE15920C57497EA1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2A03DC27FE2EB4E5D0A4358E22435065F2FB1BBF8CC2C4D9F754A9F24089344E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 2A1C6CEE1B003A06B471AA7632C6B5C4ED18A4E1A4784BF8CA09BD4F38BA4BB5
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2BCE8E19B19AAD97CC510F21B5828CCB319639FA317FB59926A436ED3543F58D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2C72B27AAD08F98379E9F3E0F6A2D625F895C9E55F61404790377FC196FA14B8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2F4596419894C88417AC4DF5C99E98A374EFE4B57B7A4EB89CE65FEB92850A61
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 320B0930454D74130DD5E245B70DA1736A2C1B5E664DD5BB82B490E60F3ECA2A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 3229DAC3DA84FAC1A1018091DAF2A0C3D6B3624AC33BECF13A371238DAC95055
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 3543AE0E1ED6A92350687219F717764E126E06D4FA179DE5B0CB3E2BDFE4AC9E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 3554CE8BB09083C24D298DF77456CB67242E6EEE3DEDFE595E11B90D2F70C0FF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1500 3B42FF7B534B27868E300720C678882AF0698E9434D0FA135656E097480324FF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 3EDD050356C639DD16815E64CA19652B1B981F1BA2FF76176BB3995FF0DB860D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 4053901EA5134D137292C48A98E1382B09C1E49C98EEF77C2D00D8FF24481D4F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 419EB5F371A1171DBE8C085F1BB25D78AA0647C1365608E167054A37BFEAD834
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 4517AF16CD9D95D0B56C33292D289749B763021F170127ED439165498D243E69
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 4E7A2BE1E8600FA773FA4952A14AE27AD21E294C2C90F674BEA6BB8B089F39C1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 550560694565D72C91221BEE89B41C8AA412660E1CF28C626BC523BC959438A9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8748 5600405012DD0807E058E5A8F3F7A9AF31716C8560F552613672D0D770364603
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 56C5F192F58A478FC32D5428DA86D03B15A95E9A982E82BA5026E6EBE259FE48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 57CD95842F6B0D5A0823F7A82A33632D2D4DA79615A834507722CBBBD054E3CF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 58BB6050E828A1FDB65D46F61ADBE862543CF7261AA487580A1328D24E944BBD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 5ED52DA9C543DD730BD7056787DF87C0AED3189F42C3321C4196EA8B70C87D2A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=88 6547EC5EB178C3DBF6A302152A1FE3BDF747E8E5EB41343EECEA2F45D745E5D1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 673F8620472294A2666EB7018FC21EF377E5B15A76872E89803CBDBDBC17F1B8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6807ED2269DB8E9A70F5D22C6D41806D26C51C306050C58861DEBD9B21D76D0B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6810D47101B1F88C982302E36EF8DBDB344EAFDF31E058B2AE9B23522DA15D89
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 683133215F3906FE49DACDB11CE3F917EF1B439110BF4CE1092DB8F15D087E2F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 68F20C1D1F9AD9A40A6FF9C3879482F58AED8E4A58995CEB0F83B2575DCFD2BC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6B6C31FF54224894CC66030691DB54C3EEE6BE4D42DB3DDA43EEC126F036360E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 70CBEAD43E82DC4CCC445D5552A983D797EEF8D2AD3665EB8FAAB2187F64F6FE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 70CF9A93794FD166C020BBDF13AE34B6B43B3A2271EC768A35797C135FC62D20
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 79B6797C01D7827A0E35892156B642BD84A9FA528E603C743515D3822864A051
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7A5DCFD7518F8A0A3FA422FA014FF84FE08070112345B17E00C0FB0AFC6D7461
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7CC4C8FC1CA4B0FA871FEB4911499E0268FE161D01C6ADFD186B0378C4063EBA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 8C6C0F60451FBE1D2DDDF80A2A9F0B7684893D5B0B8CEAB4CA837EE615B3954E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 941D4DCAADBEC3CC42B0F9F20212661AC83343F86BC7F873B237BC25AF1B195C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9742CA838C60363B639BEC16A2086253E96A532C05331B73181E45ED9D213F13
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324 9F53690DAB4D28E43D6BB3EB96D00F76FAF99D7681A6E8F0061297C8DD5EFF33
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9FB71D398994B2E0C6CE3CE99EE4CBD26EE1524A81DDB919603C13A2885F5483
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 A28E77C3345C5351A69C7393656A759AABE24F2E59F5BFC49A771E190D9C9FCC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 A3F937EE796D2312148DDB921F1293E76047E426F9BF3864DD12817D66034E74
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 A4B3F75E2EA169B5351F2BAA4DBAB862A18EDFBAE5B1CB4DBEFAEC4E22DA6BD3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 A84E72B8CD1EB5B569F80091ADA35B15F45C05E48515346C276DFBC7457817CD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 AC808BDFC94A2720F9A403E96C598F28C4A82AACBF21E2A1A6347C32A66B6425
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B107577D43B15DF28D27533ADF012E72BD63868C2A2E688AC15978DC38CD5677
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 B10D5342782BFD3820C0FFBD8DDCDF80BAA0ED5F0DF5746D2EA885110239AC7A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 B79C140A0DE10B238571FE854A6BC223D6D8C50F6ED4E227CCC677094DCB3558
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B9C5D4C45600219530B355BB1786AA4E282347901A9E3BF35DC8EE98E1307DFB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 BBDCD859D8A76172AF0C213EFB99A6F64E8AB028BECE6D313FA5B6BCF96CD15A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C271A86BEFE71CEF20615946687F7A3A13E980C14FD4637951697CD4A6112156
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C31F1438706DA962938E7F1D03470E164E0EA9EE1CD0F0D19CA29C7E932C91DC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 C3FBE83D14A8E5B3DCCAF45D7AD6C35F769326FFAED483A102ACF50FB824C9C2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 C6D060549430A52150918BF2837FCCD94C6D727B74A5946A8F7EF51B940C3CF7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C775F22681F0D15310756B294BB58FC4364A5DE6030B819E8D3EEC4E75454915
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 C807773510A04834C84A6A093A8267D127DC4413714AD99057315D8CABE1D467
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C842A7F36E23186A8F55DC7D0E63E781469950969CB88357227234F95C35DEA9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 CCC564D5CDB40E327F07151E33EF8AD040EEB5129CE505D00FE6EC11BD28C359
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 CD4DE47C20503BFF1B99694EAF6390723510293766C75243F8B3CA7B56C89359
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 D20525C66D9D2B26BC9D3A773951775A3813FC7F97CC4A2EADFF258D3C9D869E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 D3310F8730C74E00C7014874471A5E27574CD015457352EFB0373E8C5DA85FD1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DD54E6E73536232DFD682C64D36E265B59ACF8AD04FC6062A2EB7225BBDDDB02
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 DDC358E79464AB64B601CE4D8FBC308D787438D4CE92844B5FD77F2DE1E21575
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 DE26AA4452A148F1FCFF9D95EA656766D0DC19BDCEE086F85BC3F9BD8AB7F25B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 E2AA696710083FEFF382491A86DF649DB1E8EE6AA4ECF99E8D98CFBF871BFCE4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 ED977BBA7102E7758BEF3DA21CD69B44B8864A1D6F43BB20E6BF59862487ECBA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 EFC52C86FFF3F24CE6C0C14D161FCF00584AB329C5997334034F2B4D91225307
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 F1B0145A5F0D3E964A90201094730422F3013B94D7B9E73B6FFDED5643D486A2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 F8756C1F7B8F886752A7B73230C5AC5397F7CE2B1BFDC5C139DBED513BD228C3

}

internal sealed class TimedObjectsComparer<TObject> : IComparer<TObject> // TypeDefIndex: 7480
{

	public int Compare(TObject x, TObject y) { }
	/* GenericInstMethod :
	|
	|-TimedObjectsComparer<object>.Compare
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-TimedObjectsComparer<object>..ctor
	*/

}

public sealed class ValueChange<TValue> : ITimedObject // TypeDefIndex: 7520
{
	private readonly long _time;
	[CompilerGeneratedAttribute]
	private readonly TValue <Value>k__BackingField;

	public long Time { get; }
	public TValue Value { get; }


	internal void .ctor(long time, TValue value) { }
	/* GenericInstMethod :
	|
	|-ValueChange<object>..ctor
	*/

	public long get_Time() { }
	/* GenericInstMethod :
	|
	|-ValueChange<Tempo>.get_Time
	|-ValueChange<TimeSignature>.get_Time
	|-ValueChange<object>.get_Time
	*/

	[CompilerGeneratedAttribute]
	public TValue get_Value() { }
	/* GenericInstMethod :
	|
	|-ValueChange<Tempo>.get_Value
	|-ValueChange<TimeSignature>.get_Value
	|-ValueChange<object>.get_Value
	*/

	public static bool op_Equality(ValueChange<TValue> change1, ValueChange<TValue> change2) { }
	/* GenericInstMethod :
	|
	|-ValueChange<object>.op_Equality
	*/

	public static bool op_Inequality(ValueChange<TValue> change1, ValueChange<TValue> change2) { }
	/* GenericInstMethod :
	|
	|-ValueChange<object>.op_Inequality
	*/

	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-ValueChange<object>.ToString
	*/

	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-ValueChange<object>.Equals
	*/

	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-ValueChange<object>.GetHashCode
	*/

}

public sealed class ValueLine<TValue> : IEnumerable<ValueChange<TValue>>, IEnumerable // TypeDefIndex: 7521
{
	[CompilerGeneratedAttribute]
	private EventHandler ValuesChanged;
	private readonly TimedObjectsComparer<ValueChange<TValue>> _comparer;
	private readonly List<ValueChange<TValue>> _valueChanges;
	private readonly TValue _defaultValue;
	private bool _valuesChanged;
	private long _maxTime;


	[CompilerGeneratedAttribute]
	internal void add_ValuesChanged(EventHandler value) { }
	/* GenericInstMethod :
	|
	|-ValueLine<Tempo>.add_ValuesChanged
	|-ValueLine<TimeSignature>.add_ValuesChanged
	|-ValueLine<object>.add_ValuesChanged
	*/

	[CompilerGeneratedAttribute]
	internal void remove_ValuesChanged(EventHandler value) { }
	/* GenericInstMethod :
	|
	|-ValueLine<Tempo>.remove_ValuesChanged
	|-ValueLine<TimeSignature>.remove_ValuesChanged
	|-ValueLine<object>.remove_ValuesChanged
	*/

	internal void .ctor(TValue defaultValue) { }
	/* GenericInstMethod :
	|
	|-ValueLine<Tempo>..ctor
	|-ValueLine<TimeSignature>..ctor
	|-ValueLine<object>..ctor
	*/

	internal TValue GetValueAtTime(long time) { }
	/* GenericInstMethod :
	|
	|-ValueLine<TimeSignature>.GetValueAtTime
	|-ValueLine<object>.GetValueAtTime
	*/

	internal ValueChange<TValue> GetValueChangeAtTime(long time) { }
	/* GenericInstMethod :
	|
	|-ValueLine<object>.GetValueChangeAtTime
	*/

	internal void SetValue(long time, TValue value) { }
	/* GenericInstMethod :
	|
	|-ValueLine<Tempo>.SetValue
	|-ValueLine<TimeSignature>.SetValue
	|-ValueLine<object>.SetValue
	*/

	internal ValueLine<TValue> Reverse(long centerTime) { }
	/* GenericInstMethod :
	|
	|-ValueLine<Tempo>.Reverse
	|-ValueLine<TimeSignature>.Reverse
	|-ValueLine<object>.Reverse
	*/

	private void OnValuesChanged(bool forceSort = True) { }
	/* GenericInstMethod :
	|
	|-ValueLine<object>.OnValuesChanged
	*/

	private void OnValueChangesNeedSorting() { }
	/* GenericInstMethod :
	|
	|-ValueLine<object>.OnValueChangesNeedSorting
	*/

	private void OnValueChangesSortingCompleted() { }
	/* GenericInstMethod :
	|
	|-ValueLine<object>.OnValueChangesSortingCompleted
	*/

	private void SortValueChanges() { }
	/* GenericInstMethod :
	|
	|-ValueLine<object>.SortValueChanges
	*/

	public IEnumerator<ValueChange<TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-ValueLine<Tempo>.GetEnumerator
	|-ValueLine<object>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-ValueLine<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7654
{
	internal static readonly int B52DDE3D967E604310620E80EFBFBED9B6FB8C0605B3CB29D31534DAA6181A7C = 505223448;

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7855
{
	internal static <PrivateImplementationDetails>.$ArrayType$132 $$field-0


	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7873
{
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6


	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7914
{
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7


	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7992
{
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-8
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-9
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-10
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-11
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-12
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-13
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-14
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-15
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-16
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-17
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-18
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-19
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-20
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-21
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-22
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-23
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-24
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-25
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-26
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-27
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-28
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-29
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-30
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-31
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-32
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-33
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-34
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-35
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-36


	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 8026
{
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-8
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-9
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-10
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-11
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-12
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-13
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-14


	public void .ctor() { }

}

public class CC_AnalogTV : CC_Base // TypeDefIndex: 8054
{
	public float phase;
	public bool grayscale;
	public float noiseIntensity;
	public float scanlinesIntensity;
	public float scanlinesCount;
	public float distortion;
	public float cubicDistortion;
	public float scale;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Base : MonoBehaviour // TypeDefIndex: 8055
{
	public Shader shader;
	protected Material _material;

	protected Material material { get; }


	protected virtual void Start() { }

	protected Material get_material() { }

	protected virtual void OnDisable() { }

	public void .ctor() { }

}

public class CC_BleachBypass : CC_Base // TypeDefIndex: 8056
{
	public float amount;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Blend : CC_Base // TypeDefIndex: 8057
{
	public Texture texture;
	public float amount;
	public int mode;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_BrightnessContrastGamma : CC_Base // TypeDefIndex: 8058
{
	public float redCoeff;
	public float greenCoeff;
	public float blueCoeff;
	public float brightness;
	public float contrast;
	public float gamma;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_ChannelMixer : CC_Base // TypeDefIndex: 8059
{
	public float redR;
	public float redG;
	public float redB;
	public float greenR;
	public float greenG;
	public float greenB;
	public float blueR;
	public float blueG;
	public float blueB;
	public float constantR;
	public float constantG;
	public float constantB;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Convolution3x3 : CC_Base // TypeDefIndex: 8060
{
	public Vector3 kernelTop;
	public Vector3 kernelMiddle;
	public Vector3 kernelBottom;
	public float divisor;
	public float amount;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_CrossStitch : CC_Base // TypeDefIndex: 8061
{
	public int size;
	public float brightness;
	public bool invert;
	public bool pixelize;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_DoubleVision : CC_Base, IImageEffect // TypeDefIndex: 8062
{
	public Vector2 displace;
	public float amount;


	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_FastVignette : CC_Base // TypeDefIndex: 8063
{
	public float sharpness;
	public float darkness;
	public bool desaturate;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Frost : CC_Base, IImageEffect // TypeDefIndex: 8064
{
	public float scale;
	public float sharpness;
	public float darkness;
	public bool enableVignette;


	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_GradientRamp : CC_Base // TypeDefIndex: 8065
{
	public Texture rampTexture;
	public float amount;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Grayscale : CC_Base, IImageEffect // TypeDefIndex: 8066
{
	public float redLuminance;
	public float greenLuminance;
	public float blueLuminance;
	public float amount;


	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Halftone : CC_Base // TypeDefIndex: 8067
{
	public float density;
	public int mode;
	public bool antialiasing;
	public bool showOriginal;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_HueSaturationValue : CC_Base // TypeDefIndex: 8068
{
	public float hue;
	public float saturation;
	public float value;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Led : CC_Base // TypeDefIndex: 8069
{
	public float scale;
	public bool automaticRatio;
	public float ratio;
	public float brightness;
	public int mode;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Levels : CC_Base // TypeDefIndex: 8070
{
	public int mode;
	public float inputMinL;
	public float inputMaxL;
	public float inputGammaL;
	public float inputMinR;
	public float inputMaxR;
	public float inputGammaR;
	public float inputMinG;
	public float inputMaxG;
	public float inputGammaG;
	public float inputMinB;
	public float inputMaxB;
	public float inputGammaB;
	public float outputMinL;
	public float outputMaxL;
	public float outputMinR;
	public float outputMaxR;
	public float outputMinG;
	public float outputMaxG;
	public float outputMinB;
	public float outputMaxB;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_LookupFilter : CC_Base // TypeDefIndex: 8071
{
	public Texture lookupTexture;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Negative : CC_Base // TypeDefIndex: 8072
{
	public float amount;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_PhotoFilter : CC_Base, IImageEffect // TypeDefIndex: 8073
{
	public Color color;
	public float density;


	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Pixelate : CC_Base // TypeDefIndex: 8074
{
	public float scale;
	public bool automaticRatio;
	public float ratio;
	public int mode;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Posterize : CC_Base // TypeDefIndex: 8075
{
	public int levels;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_RGBSplit : CC_Base // TypeDefIndex: 8076
{
	public float amount;
	public float angle;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_RadialBlur : CC_Base // TypeDefIndex: 8077
{
	public float amount;
	public Vector2 center;
	public int quality;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Sharpen : CC_Base // TypeDefIndex: 8078
{
	public float strength;
	public float clamp;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_SharpenAndVignette : CC_Base, IImageEffect // TypeDefIndex: 8079
{
	[HeaderAttribute]
	public bool applySharpen;
	[RangeAttribute]
	public float strength;
	[RangeAttribute]
	public float clamp;
	[HeaderAttribute]
	public bool applyVignette;
	[RangeAttribute]
	public float sharpness;
	[RangeAttribute]
	public float darkness;


	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Threshold : CC_Base // TypeDefIndex: 8080
{
	public float threshold;
	public bool useNoise;
	public float noiseRange;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Vibrance : CC_Base // TypeDefIndex: 8081
{
	public float amount;


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Wiggle : CC_Base, IImageEffect // TypeDefIndex: 8082
{
	public float timer;
	public float speed;
	public float scale;


	private void Update() { }

	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 9955
{
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19552 1DC4C1B55DC0F7A09DD49557857282243A661721
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420 4D97B7EA75C57A5C53C1E01B1C6253465DE43B65
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 9B733B2872507920FB43A4A60F4CBE3E17200C8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 C01F4A345A0DC451B12954EDA4ED605D0075A2A5
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD09230AEF3C2384FBC6D4B1BC4EADBE9911368E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9776 F2AB9A53871DA3CF4444B73A4D38E5580D8F8ED3

}

internal sealed class <>f__AnonymousType0<<Identifier>j__TPar, <Name>j__TPar, <State>j__TPar> // TypeDefIndex: 9962
{

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9776

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19552

internal class <Module>

[CompilerGeneratedAttribute]
internal sealed class <>f__AnonymousType0<<Identifier>j__TPar, <Name>j__TPar, <State>j__TPar>
	[DebuggerBrowsableAttribute]
	private readonly <Identifier>j__TPar <Identifier>i__Field;
	[DebuggerBrowsableAttribute]
	private readonly <Name>j__TPar <Name>i__Field;
	[DebuggerBrowsableAttribute]
	private readonly <State>j__TPar <State>i__Field;

	public <Identifier>j__TPar Identifier { get; }
	public <Name>j__TPar Name { get; }
	public <State>j__TPar State { get; }


	public <Identifier>j__TPar get_Identifier() { }
	/* GenericInstMethod :
	|
	|-<>f__AnonymousType0<object, object, bool>.get_Identifier
	|-<>f__AnonymousType0<object, object, object>.get_Identifier
	*/

	public <Name>j__TPar get_Name() { }
	/* GenericInstMethod :
	|
	|-<>f__AnonymousType0<object, object, bool>.get_Name
	|-<>f__AnonymousType0<object, object, object>.get_Name
	*/

	public <State>j__TPar get_State() { }
	/* GenericInstMethod :
	|
	|-<>f__AnonymousType0<object, object, bool>.get_State
	|
	|-<>f__AnonymousType0<object, object, object>.get_State
	*/

	[DebuggerHiddenAttribute]
	public void .ctor(<Identifier>j__TPar Identifier, <Name>j__TPar Name, <State>j__TPar State) { }
	/* GenericInstMethod :
	|
	|-<>f__AnonymousType0<object, object, bool>..ctor
	|-<>f__AnonymousType0<string, string, bool>..ctor
	|
	|-<>f__AnonymousType0<object, object, object>..ctor
	*/

	[DebuggerHiddenAttribute]
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-<>f__AnonymousType0<object, object, bool>.Equals
	|
	|-<>f__AnonymousType0<object, object, object>.Equals
	*/

	[DebuggerHiddenAttribute]
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-<>f__AnonymousType0<object, object, bool>.GetHashCode
	|
	|-<>f__AnonymousType0<object, object, object>.GetHashCode
	*/

	[DebuggerHiddenAttribute]
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-<>f__AnonymousType0<object, object, bool>.ToString
	|
	|-<>f__AnonymousType0<object, object, object>.ToString
	*/

}

public class v_chainsaw : MonoBehaviour // TypeDefIndex: 10628
{
	public bool bAttacking;
	public bool bHitMetal;
	public bool bHitWood;
	public bool bHitFlesh;
	public bool bEngineOn;
	public ParticleSystem[] hitMetalFX;
	public ParticleSystem[] hitWoodFX;
	public ParticleSystem[] hitFleshFX;
	public SoundDefinition hitMetalSoundDef;
	public SoundDefinition hitWoodSoundDef;
	public SoundDefinition hitFleshSoundDef;
	public Sound hitSound;
	public GameObject hitSoundTarget;
	public float hitSoundFadeTime;
	public ParticleSystem smokeEffect;
	public Animator chainsawAnimator;
	public Renderer chainRenderer;
	public Material chainlink;
	private MaterialPropertyBlock block;
	private Vector2 saveST;
	private float chainSpeed;
	private float chainAmount;
	public float temp1;
	public float temp2;


	public void OnEnable() { }

	private void Awake() { }

	private void Start() { }

	private void ScrollChainTexture() { }

	private void Update() { }

	private void DoHitSound(SoundDefinition soundDef) { }

	public void .ctor() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 13969
{

[CompilerGeneratedAttribute]
internal sealed class <PrivateImplementationDetails>
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 08A598D3DC7ED63443A0CAF087F7CDF5BAA67E3D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 0ED907628EE272F93737B500A23D77C9B1C88368
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 17ADC9F18EEFE619644F7B3C7C90D5FD8DCDE2BB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 1C910D34886830DDE4A52B59726EB240ADBF9F34
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2277B245F935EBA3EA2D03B6871C13871FD4D572
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 24F287DA5BA36E31C3946E2FBE95B8388C241662
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 386DD6935C2F38BB8114CA4DF96C8BC2D3E639DA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 42A4001D1CFDC98C761C0CFE5497A75F739D92F8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 43A214299CEA27B6A55E61A929FC7B62C5D4941E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 44D235DAFB9C469EBDA7640EB1F2CC833B40E9E5
	internal static readonly long 4CAECE539B039B16E16206EA2478F8C5FFB2CA05 = 727905341920923785;
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 59E933D7501F1D8F431F5807AC6C357BBA5F2D58
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 6B8D5CC14D2709C84958ED5E3855C874DA314CB4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6BA637A252B6BFA8895B67AD72DCCAE79715984C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=80 6DBA8D05A3CD51B9E01E83FDDF49241693E5D4E4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 843D396E2EE569B035A7AC2BEB7A8253FC4AEDA7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 9365FDAD4BD75AEF9446E0B22483D217BE36E309
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 9EFF88EB2F3540C5CE20FEF36A8E3AA37629AF80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 B9B198B061D08812F585C9E56641F4E897E88E38
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 C18072E27FC2B4816C8694EB22427195375388F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 C7F420F4B2F68D0B3647564554BA8DB99509F64F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 D950356082C70AD4018410AD313BA99D655D4D4A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 E3D5EABE71635FCDE2C05162A6CDE245A9796318
	internal static readonly long FCBA60311CDE80DE090AE6F8834C9CEC477FA56A = 5927942488114331648;


	internal static uint ComputeStringHash(string s) { }

}

