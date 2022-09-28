internal enum ItemUpdateStatus // TypeDefIndex: 5164
{
	public int value__; 
	public const ItemUpdateStatus Invalid = 0;
	public const ItemUpdateStatus PreparingConfig = 1;
	public const ItemUpdateStatus PreparingContent = 2;
	public const ItemUpdateStatus UploadingContent = 3;
	public const ItemUpdateStatus UploadingPreviewFile = 4;
	public const ItemUpdateStatus CommittingChanges = 5;

}

internal enum ItemState // TypeDefIndex: 5165
{
	public int value__; 
	public const ItemState None = 0;
	public const ItemState Subscribed = 1;
	public const ItemState LegacyItem = 2;
	public const ItemState Installed = 4;
	public const ItemState NeedsUpdate = 8;
	public const ItemState Downloading = 16;
	public const ItemState DownloadPending = 32;

}

internal enum ItemStatistic // TypeDefIndex: 5166
{
	public int value__; 
	public const ItemStatistic NumSubscriptions = 0;
	public const ItemStatistic NumFavorites = 1;
	public const ItemStatistic NumFollowers = 2;
	public const ItemStatistic NumUniqueSubscriptions = 3;
	public const ItemStatistic NumUniqueFavorites = 4;
	public const ItemStatistic NumUniqueFollowers = 5;
	public const ItemStatistic NumUniqueWebsiteViews = 6;
	public const ItemStatistic ReportScore = 7;
	public const ItemStatistic NumSecondsPlayed = 8;
	public const ItemStatistic NumPlaytimeSessions = 9;
	public const ItemStatistic NumComments = 10;
	public const ItemStatistic NumSecondsPlayedDuringTimePeriod = 11;
	public const ItemStatistic NumPlaytimeSessionsDuringTimePeriod = 12;

}

public enum ItemPreviewType // TypeDefIndex: 5167
{
	public int value__; 
	public const ItemPreviewType Image = 0;
	public const ItemPreviewType YouTubeVideo = 1;
	public const ItemPreviewType Sketchfab = 2;
	public const ItemPreviewType EnvironmentMap_HorizontalCross = 3;
	public const ItemPreviewType EnvironmentMap_LatLong = 4;
	public const ItemPreviewType ReservedMax = 255;

}

public struct Item // TypeDefIndex: 5278
{
	internal SteamUGCDetails_t details; 
	internal PublishedFileId _id; 
	[CompilerGeneratedAttribute] 
	private string <Title>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Description>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string[] <Tags>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Dictionary<string, string> <KeyValueTags>k__BackingField; 
	public PublishedFileId[] Children; 
	[CompilerGeneratedAttribute] 
	private UgcAdditionalPreview[] <AdditionalPreviews>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumSubscriptions>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumFavorites>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumFollowers>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumUniqueSubscriptions>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumUniqueFavorites>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumUniqueFollowers>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumUniqueWebsiteViews>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <ReportScore>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumSecondsPlayed>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumPlaytimeSessions>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumComments>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumSecondsPlayedDuringTimePeriod>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <NumPlaytimeSessionsDuringTimePeriod>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <PreviewImageUrl>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Metadata>k__BackingField; 

	public PublishedFileId Id { get; }
	public string Title { get; set; }
	public string Description { get; set; }
	public string[] Tags { get; set; }
	public Dictionary<string, string> KeyValueTags { get; set; }
	public Friend Owner { get; }
	public DateTime Updated { get; }
	public UgcAdditionalPreview[] AdditionalPreviews { get; set; }
	public bool IsInstalled { get; }
	public bool IsDownloading { get; }
	public bool IsDownloadPending { get; }
	public string Directory { get; }
	private ItemState State { get; }
	public string Url { get; }
	internal ulong NumSubscriptions { set; }
	internal ulong NumFavorites { set; }
	internal ulong NumFollowers { set; }
	internal ulong NumUniqueSubscriptions { set; }
	internal ulong NumUniqueFavorites { set; }
	internal ulong NumUniqueFollowers { set; }
	internal ulong NumUniqueWebsiteViews { set; }
	internal ulong ReportScore { set; }
	internal ulong NumSecondsPlayed { set; }
	internal ulong NumPlaytimeSessions { set; }
	internal ulong NumComments { set; }
	internal ulong NumSecondsPlayedDuringTimePeriod { set; }
	internal ulong NumPlaytimeSessionsDuringTimePeriod { set; }
	public string PreviewImageUrl { get; set; }
	internal string Metadata { set; }


	public void .ctor(PublishedFileId id) { }

	public PublishedFileId get_Id() { }

	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public string get_Title() { }

	[CompilerGeneratedAttribute] 
	internal void set_Title(string value) { }

	[CompilerGeneratedAttribute] 
	[IsReadOnlyAttribute] 
	public string get_Description() { }

	[CompilerGeneratedAttribute] 
	internal void set_Description(string value) { }

	[CompilerGeneratedAttribute] 
	[IsReadOnlyAttribute] 
	public string[] get_Tags() { }

	[CompilerGeneratedAttribute] 
	internal void set_Tags(string[] value) { }

	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public Dictionary<string, string> get_KeyValueTags() { }

	[CompilerGeneratedAttribute] 
	internal void set_KeyValueTags(Dictionary<string, string> value) { }

	public Friend get_Owner() { }

	public DateTime get_Updated() { }

	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public UgcAdditionalPreview[] get_AdditionalPreviews() { }

	[CompilerGeneratedAttribute] 
	internal void set_AdditionalPreviews(UgcAdditionalPreview[] value) { }

	public bool get_IsInstalled() { }

	public bool get_IsDownloading() { }

	public bool get_IsDownloadPending() { }

	public string get_Directory() { }

	public bool Download(bool highPriority = False) { }

	private ItemState get_State() { }

	internal static Item From(SteamUGCDetails_t details) { }

	[AsyncStateMachineAttribute] 
	public Task<Nullable<Result>> Vote(bool up) { }

	public string get_Url() { }

	[CompilerGeneratedAttribute] 
	internal void set_NumSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_NumFavorites(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_NumFollowers(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_NumUniqueSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_NumUniqueFavorites(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_NumUniqueFollowers(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_NumUniqueWebsiteViews(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_ReportScore(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_NumSecondsPlayed(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_NumPlaytimeSessions(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_NumComments(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_NumSecondsPlayedDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] 
	internal void set_NumPlaytimeSessionsDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] 
	[IsReadOnlyAttribute] 
	public string get_PreviewImageUrl() { }

	[CompilerGeneratedAttribute] 
	internal void set_PreviewImageUrl(string value) { }

	[CompilerGeneratedAttribute] 
	internal void set_Metadata(string value) { }

}

private struct Item.<Vote>d__83 : IAsyncStateMachine // TypeDefIndex: 5279
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Nullable<Result>> <>t__builder; 
	public Item <>4__this; 
	public bool up; 
	private CallResult<SetUserItemVoteResult_t> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

internal struct ItemInstalled_t : ICallbackData // TypeDefIndex: 5435
{
	internal AppId AppID; 
	internal PublishedFileId PublishedFileId; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

public class ItemContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6440
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint UID; 
	public int slots; 
	public float temperature; 
	public int flags; 
	public int allowedContents; 
	public int maxStackSize; 
	public List<int> allowedItems; 
	public List<int> availableSlots; 
	public List<Item> contents; 


	public static void ResetToPool(ItemContainer instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ItemContainer instance) { }

	public ItemContainer Copy() { }

	public static ItemContainer Deserialize(Stream stream) { }

	public static ItemContainer DeserializeLengthDelimited(Stream stream) { }

	public static ItemContainer DeserializeLength(Stream stream, int length) { }

	public static ItemContainer Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ItemContainer previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ItemContainer Deserialize(byte[] buffer, ItemContainer instance, bool isDelta = False) { }

	public static ItemContainer Deserialize(Stream stream, ItemContainer instance, bool isDelta) { }

	public static ItemContainer DeserializeLengthDelimited(Stream stream, ItemContainer instance, bool isDelta) { }

	public static ItemContainer DeserializeLength(Stream stream, int length, ItemContainer instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ItemContainer instance, ItemContainer previous) { }

	public static void Serialize(Stream stream, ItemContainer instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ItemContainer instance) { }

	public static void SerializeLengthDelimited(Stream stream, ItemContainer instance) { }

	public void .ctor() { }

}

public class Item : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6441
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint UID; 
	public int itemid; 
	public int slot; 
	public int amount; 
	public int flags; 
	public float removetime; 
	public float locktime; 
	public uint worldEntity; 
	public Item.InstanceData instanceData; 
	public uint heldEntity; 
	public Item.ConditionData conditionData; 
	public string name; 
	public string text; 
	public ulong skinid; 
	public ItemContainer contents; 


	public static void ResetToPool(Item instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Item instance) { }

	public Item Copy() { }

	public static Item Deserialize(Stream stream) { }

	public static Item DeserializeLengthDelimited(Stream stream) { }

	public static Item DeserializeLength(Stream stream, int length) { }

	public static Item Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Item previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Item Deserialize(byte[] buffer, Item instance, bool isDelta = False) { }

	public static Item Deserialize(Stream stream, Item instance, bool isDelta) { }

	public static Item DeserializeLengthDelimited(Stream stream, Item instance, bool isDelta) { }

	public static Item DeserializeLength(Stream stream, int length, Item instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Item instance, Item previous) { }

	public static void Serialize(Stream stream, Item instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Item instance) { }

	public static void SerializeLengthDelimited(Stream stream, Item instance) { }

	public void .ctor() { }

}

public class Item.InstanceData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6442
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int dataInt; 
	public int blueprintTarget; 
	public int blueprintAmount; 
	public uint subEntity; 


	public static void ResetToPool(Item.InstanceData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Item.InstanceData instance) { }

	public Item.InstanceData Copy() { }

	public static Item.InstanceData Deserialize(Stream stream) { }

	public static Item.InstanceData DeserializeLengthDelimited(Stream stream) { }

	public static Item.InstanceData DeserializeLength(Stream stream, int length) { }

	public static Item.InstanceData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Item.InstanceData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Item.InstanceData Deserialize(byte[] buffer, Item.InstanceData instance, bool isDelta = False) { }

	public static Item.InstanceData Deserialize(Stream stream, Item.InstanceData instance, bool isDelta) { }

	public static Item.InstanceData DeserializeLengthDelimited(Stream stream, Item.InstanceData instance, bool isDelta) { }

	public static Item.InstanceData DeserializeLength(Stream stream, int length, Item.InstanceData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Item.InstanceData instance, Item.InstanceData previous) { }

	public static void Serialize(Stream stream, Item.InstanceData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Item.InstanceData instance) { }

	public static void SerializeLengthDelimited(Stream stream, Item.InstanceData instance) { }

	public void .ctor() { }

}

public class Item.ConditionData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6443
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float condition; 
	public float maxCondition; 


	public static void ResetToPool(Item.ConditionData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Item.ConditionData instance) { }

	public Item.ConditionData Copy() { }

	public static Item.ConditionData Deserialize(Stream stream) { }

	public static Item.ConditionData DeserializeLengthDelimited(Stream stream) { }

	public static Item.ConditionData DeserializeLength(Stream stream, int length) { }

	public static Item.ConditionData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Item.ConditionData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Item.ConditionData Deserialize(byte[] buffer, Item.ConditionData instance, bool isDelta = False) { }

	public static Item.ConditionData Deserialize(Stream stream, Item.ConditionData instance, bool isDelta) { }

	public static Item.ConditionData DeserializeLengthDelimited(Stream stream, Item.ConditionData instance, bool isDelta) { }

	public static Item.ConditionData DeserializeLength(Stream stream, int length, Item.ConditionData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Item.ConditionData instance, Item.ConditionData previous) { }

	public static void Serialize(Stream stream, Item.ConditionData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Item.ConditionData instance) { }

	public static void SerializeLengthDelimited(Stream stream, Item.ConditionData instance) { }

	public void .ctor() { }

}

public class ItemAmountList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6507
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<int> itemID; 
	public List<float> amount; 


	public static void ResetToPool(ItemAmountList instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ItemAmountList instance) { }

	public ItemAmountList Copy() { }

	public static ItemAmountList Deserialize(Stream stream) { }

	public static ItemAmountList DeserializeLengthDelimited(Stream stream) { }

	public static ItemAmountList DeserializeLength(Stream stream, int length) { }

	public static ItemAmountList Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ItemAmountList previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ItemAmountList Deserialize(byte[] buffer, ItemAmountList instance, bool isDelta = False) { }

	public static ItemAmountList Deserialize(Stream stream, ItemAmountList instance, bool isDelta) { }

	public static ItemAmountList DeserializeLengthDelimited(Stream stream, ItemAmountList instance, bool isDelta) { }

	public static ItemAmountList DeserializeLength(Stream stream, int length, ItemAmountList instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ItemAmountList instance, ItemAmountList previous) { }

	public static void Serialize(Stream stream, ItemAmountList instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ItemAmountList instance) { }

	public static void SerializeLengthDelimited(Stream stream, ItemAmountList instance) { }

	public void .ctor() { }

}

public class ItemSchema // TypeDefIndex: 7713
{
	public int appid; 
	public ItemSchema.Item[] items; 


	public void .ctor() { }

}

public class ItemSchema.Item // TypeDefIndex: 7714
{
	public string name; 
	public uint itemdefid; 
	public string type; 
	public string price_category; 
	public string icon_url; 
	public string icon_url_large; 
	public bool marketable; 
	public bool tradable; 
	public bool commodity; 
	public string market_hash_name; 
	public string market_name; 
	public string bundle; 
	public string description; 
	public string workshopid; 
	public string itemshortname; 
	public string tags; 
	public string store_tags; 
	public string exchange; 
	public bool store_hidden; 
	public string background_color; 
	public string name_color; 
	public DropChance dropChance; 
	public Price priceCategory; 
	public string workshopdownload; 

	[JsonIgnoreAttribute] 
	public double Price { get; }


	public double get_Price() { }

	public void .ctor() { }

}

public struct ItemOwnership // TypeDefIndex: 9433
{
	[CompilerGeneratedAttribute] 
	private Utf8String <Id>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private OwnershipStatus <OwnershipStatus>k__BackingField; 

	public Utf8String Id { get; set; }
	public OwnershipStatus OwnershipStatus { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_Id() { }

	[CompilerGeneratedAttribute] 
	public void set_Id(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public OwnershipStatus get_OwnershipStatus() { }

	[CompilerGeneratedAttribute] 
	public void set_OwnershipStatus(OwnershipStatus value) { }

	internal void Set(ref ItemOwnershipInternal other) { }

}

internal struct ItemOwnershipInternal : IGettable<ItemOwnership>, ISettable<ItemOwnership>, IDisposable // TypeDefIndex: 9434
{
	private int m_ApiVersion; 
	private IntPtr m_Id; 
	private OwnershipStatus m_OwnershipStatus; 

	public Utf8String Id { get; set; }
	public OwnershipStatus OwnershipStatus { get; set; }


	public Utf8String get_Id() { }

	public void set_Id(Utf8String value) { }

	public OwnershipStatus get_OwnershipStatus() { }

	public void set_OwnershipStatus(OwnershipStatus value) { }

	public void Set(ref ItemOwnership other) { }

	public void Set(ref Nullable<ItemOwnership> other) { }

	public void Dispose() { }

	public void Get(out ItemOwnership output) { }

}

public class ItemBasedFlowRestrictor : IOEntity, IContainerSounds // TypeDefIndex: 10071
{
	private Option __menuOption_Menu_Open; 
	public ItemDefinition passthroughItem; 
	public ItemContainer.ContentsType allowedContents; 
	public int maxStackSize; 
	public int numSlots; 
	public string lootPanelName; 
	public const BaseEntity.Flags HasPassthrough = 128;
	public const BaseEntity.Flags Sparks = 256;
	public float passthroughItemConditionLossPerSec; 
	public SoundDefinition openSound; 
	public SoundDefinition closeSound; 

	public override bool HasMenuOptions { get; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	public SoundDefinition get_OpenSound() { }

	public SoundDefinition get_CloseSound() { }

	public void .ctor() { }

}

public class ItemSearchEntry : MonoBehaviour // TypeDefIndex: 10403
{
	public Button button; 
	public Text text; 
	public RawImage image; 
	public RawImage bpImage; 
	private ItemDefinition itemInfo; 
	private AddSellOrderManager manager; 


	public void Setup(ItemDefinition info, AddSellOrderManager mgr) { }

	public void Clicked() { }

	public void ClickedBP() { }

	public void .ctor() { }

}

public class ItemModCrackOpen : ItemModUnwrap // TypeDefIndex: 10457
{

	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModOpenLootBag : ItemModUnwrap // TypeDefIndex: 10465
{

	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModPhoto : ItemModAssociatedEntity<PhotoEntity> // TypeDefIndex: 10486
{
	protected override bool AllowNullParenting { get; }


	protected override bool get_AllowNullParenting() { }

	public void .ctor() { }

}

public class ItemModUnwrap : ItemMod // TypeDefIndex: 10495
{
	public LootSpawn revealList; 
	public GameObjectRef successEffect; 
	public int minTries; 
	public int maxTries; 


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModOpenWrapped : ItemMod // TypeDefIndex: 10501
{
	public GameObjectRef successEffect; 
	public static Translate.Phrase open_wrapped_gift; 
	public static Translate.Phrase open_wrapped_gift_desc; 


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class ItemModWrap : ItemMod // TypeDefIndex: 10502
{
	public GameObjectRef successEffect; 
	public ItemDefinition wrappedDefinition; 
	public static Translate.Phrase wrap_gift; 
	public static Translate.Phrase wrap_gift_desc; 


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class ItemModXMasTreeDecoration : ItemMod // TypeDefIndex: 10504
{
	public ItemModXMasTreeDecoration.xmasFlags flagsToChange; 


	public void .ctor() { }

}

public enum ItemModXMasTreeDecoration.xmasFlags // TypeDefIndex: 10505
{
	public int value__; 
	public const ItemModXMasTreeDecoration.xmasFlags pineCones = 128;
	public const ItemModXMasTreeDecoration.xmasFlags candyCanes = 256;
	public const ItemModXMasTreeDecoration.xmasFlags gingerbreadMen = 512;
	public const ItemModXMasTreeDecoration.xmasFlags Tinsel = 1024;
	public const ItemModXMasTreeDecoration.xmasFlags Balls = 2048;
	public const ItemModXMasTreeDecoration.xmasFlags Star = 16384;
	public const ItemModXMasTreeDecoration.xmasFlags Lights = 32768;

}

public class ItemModRFListener : ItemModAssociatedEntity<PagerEntity> // TypeDefIndex: 10546
{
	public GameObjectRef frequencyPanelPrefab; 
	private uint pendingPagerID; 


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void ConfigureClicked(BasePlayer player) { }

	public void .ctor() { }

}

public class ItemButtonTools : MonoBehaviour // TypeDefIndex: 10953
{
	public Image image; 
	public ItemDefinition itemDef; 


	public void GiveSelf(int amount) { }

	public void GiveArmed() { }

	public void GiveBlueprint() { }

	public void .ctor() { }

}

public class ItemListTools : MonoBehaviour // TypeDefIndex: 10954
{
	public GameObject categoryButton; 
	public GameObject itemButton; 
	public RustInput searchInputText; 
	internal Button lastCategory; 
	private IOrderedEnumerable<ItemDefinition> currentItems; 
	private IOrderedEnumerable<ItemDefinition> allItems; 


	public void OnPanelOpened() { }

	private void OnOpenDevTools() { }

	private void CacheAllItems() { }

	public void Refresh() { }

	private void RebuildCategories() { }

	private void SwitchItemCategory(ItemDefinition[] defs) { }

	public void FilterItems(string searchText) { }

	public void .ctor() { }

}

private sealed class ItemListTools.<>c // TypeDefIndex: 10955
{
	public static readonly ItemListTools.<>c <>9; 
	public static Func<ItemDefinition, string> <>9__8_0; 
	public static Func<ItemDefinition, ItemCategory> <>9__10_0; 
	public static Func<IGrouping<ItemCategory, ItemDefinition>, ItemCategory> <>9__10_1; 
	public static Func<ItemDefinition, string> <>9__11_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal string <CacheAllItems>b__8_0(ItemDefinition x) { }

	internal ItemCategory <RebuildCategories>b__10_0(ItemDefinition x) { }

	internal ItemCategory <RebuildCategories>b__10_1(IGrouping<ItemCategory, ItemDefinition> x) { }

	internal string <SwitchItemCategory>b__11_0(ItemDefinition x) { }

}

private sealed class ItemListTools.<>c__DisplayClass10_0 // TypeDefIndex: 10956
{
	public Button btn; 
	public ItemDefinition[] itemArray; 
	public ItemListTools <>4__this; 


	public void .ctor() { }

	internal void <RebuildCategories>b__2() { }

}

public class ItemTools : MonoBehaviour // TypeDefIndex: 10983
{

public class ItemTools : MonoBehaviour

	public void .ctor() { }

}

public class ItemModAssociatedEntityMobile : ItemModAssociatedEntity<MobileInventoryEntity> // TypeDefIndex: 11116
{
	protected override bool AllowNullParenting { get; }


	protected override bool get_AllowNullParenting() { }

	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModCassette : ItemModAssociatedEntity<Cassette> // TypeDefIndex: 11117
{
	public int noteSpriteIndex; 
	public PreloadedCassetteContent PreloadedContent; 

	protected override bool AllowNullParenting { get; }
	protected override bool AllowHeldEntityParenting { get; }


	protected override bool get_AllowNullParenting() { }

	protected override bool get_AllowHeldEntityParenting() { }

	public void .ctor() { }

}

public class ItemModSign : ItemModAssociatedEntity<SignContent> // TypeDefIndex: 11185
{
	protected override bool AllowNullParenting { get; }


	protected override bool get_AllowNullParenting() { }

	public void .ctor() { }

}

public class ItemPickup : DroppedItem // TypeDefIndex: 11464
{
	public ItemDefinition itemDef; 
	public int amount; 
	public ulong skinOverride; 


	public void .ctor() { }

}

public class ItemCraftTask // TypeDefIndex: 11777
{
	public ItemBlueprint blueprint; 
	public float endTime; 
	public int taskUID; 
	public BasePlayer owner; 
	public bool cancelled; 
	public Item.InstanceData instanceData; 
	public int amount; 
	public int skinID; 
	public List<ulong> potentialOwners; 
	public List<Item> takenItems; 
	public int numCrafted; 
	public float conditionScale; 
	public float workSecondsComplete; 
	public float worksecondsRequired; 


	public void .ctor() { }

}

public class ItemCrafter : EntityComponent<BasePlayer> // TypeDefIndex: 11778
{
	public List<ItemContainer> containers; 
	public LinkedList<ItemCraftTask> queue; 
	public int taskUID; 


	public void AddContainer(ItemContainer container) { }

	public static float GetScaledDuration(ItemBlueprint bp, float workbenchLevel) { }

	private bool DoesHaveUsableItem(int item, int iAmount) { }

	public bool CanCraft(ItemBlueprint bp, int amount = 1, bool free = False) { }

	public bool CanCraft(ItemDefinition def, int amount = 1, bool free = False) { }

	public void .ctor() { }

}

public class ItemEventFlag : MonoBehaviour, IItemUpdate // TypeDefIndex: 11779
{
	public Item.Flag flag; 
	public UnityEvent onEnabled; 
	public UnityEvent onDisable; 
	internal bool firstRun; 
	internal bool lastState; 


	public virtual void OnItemUpdate(Item item) { }

	public void .ctor() { }

}

public class Item // TypeDefIndex: 11780
{
	public Nullable<int> amountOverride; 
	private static readonly Memoized<string, ValueTuple<ItemDefinition.AmountType, int>> FormatAmountMemoized; 
	private const string DefaultArmourBreakEffectPath = "assets/bundled/prefabs/fx/armor_break.prefab";
	private float _condition; 
	private float _maxCondition; 
	public ItemDefinition info; 
	public uint uid; 
	public bool dirty; 
	public int amount; 
	public int position; 
	public float busyTime; 
	public float removeTime; 
	public float fuel; 
	public bool isServer; 
	public Item.InstanceData instanceData; 
	public ulong skin; 
	public string name; 
	public string text; 
	[CompilerGeneratedAttribute] 
	private Action<Item> OnDirty; 
	public Item.Flag flags; 
	public ItemContainer contents; 
	public ItemContainer parent; 
	private EntityRef worldEnt; 
	private EntityRef heldEntity; 

	public float condition { get; set; }
	public float maxCondition { get; set; }
	public float maxConditionNormalized { get; }
	public float conditionNormalized { get; set; }
	public bool hasCondition { get; }
	public bool isBroken { get; }
	public int despawnMultiplier { get; }
	public ItemDefinition blueprintTargetDef { get; }
	public int blueprintTarget { get; set; }
	public int blueprintAmount { get; set; }
	public Item parentItem { get; }
	public float temperature { get; }
	internal Sprite iconSprite { get; }
	internal bool isLoadingIconSprite { get; }
	public BaseEntity.TraitFlag Traits { get; }


	public void UpdateAmountDisplay(Text text) { }

	public static void UpdateAmountDisplay(Text text, Item item, Nullable<int> amountOverride, ItemDefinition infoOverride) { }

	private static string FormatAmount(ItemDefinition.AmountType type, int amount) { }

	public void set_condition(float value) { }

	public float get_condition() { }

	public void set_maxCondition(float value) { }

	public float get_maxCondition() { }

	public float get_maxConditionNormalized() { }

	public float get_conditionNormalized() { }

	public void set_conditionNormalized(float value) { }

	public bool get_hasCondition() { }

	public bool get_isBroken() { }

	public int get_despawnMultiplier() { }

	public ItemDefinition get_blueprintTargetDef() { }

	public int get_blueprintTarget() { }

	public void set_blueprintTarget(int value) { }

	public int get_blueprintAmount() { }

	public void set_blueprintAmount(int value) { }

	public bool IsBlueprint() { }

	[CompilerGeneratedAttribute] 
	public void add_OnDirty(Action<Item> value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnDirty(Action<Item> value) { }

	public bool HasFlag(Item.Flag f) { }

	public void SetFlag(Item.Flag f, bool b) { }

	public bool IsOn() { }

	public bool IsOnFire() { }

	public bool IsCooking() { }

	public bool IsLocked() { }

	public Item get_parentItem() { }

	public void MarkDirty() { }

	public void OnChanged() { }

	public void CollectedForCrafting(BasePlayer crafter) { }

	public void ReturnedFromCancelledCraft(BasePlayer crafter) { }

	public bool IsChildContainer(ItemContainer c) { }

	public bool IsBusy() { }

	public void BusyFor(float fTime) { }

	public void Remove(float fTime = 0) { }

	internal void DoRemove() { }

	public void SwitchOnOff(bool bNewState) { }

	public void LockUnlock(bool bNewState) { }

	public float get_temperature() { }

	public BasePlayer GetOwnerPlayer() { }

	public bool CanBeHeld() { }

	public bool CanStack(Item item) { }

	public bool IsValid() { }

	public void SetWorldEntity(BaseEntity ent) { }

	public void OnMovedToWorld() { }

	public BaseEntity GetWorldEntity() { }

	public BaseEntity GetHeldEntity() { }

	public bool BeltBarSelect(BasePlayer player) { }

	public virtual int GetTotalUISlots() { }

	public virtual int GetFilledUISlots() { }

	public bool HasAmmo(AmmoTypes ammoType) { }

	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	public int GetAmmoAmount(AmmoTypes ammoType) { }

	public override string ToString() { }

	public Item FindItem(uint iUID) { }

	public int MaxStackable() { }

	internal Sprite get_iconSprite() { }

	internal bool get_isLoadingIconSprite() { }

	public BaseEntity.TraitFlag get_Traits() { }

	public virtual Item Save(bool bIncludeContainer = False, bool bIncludeOwners = True) { }

	public virtual void Load(Item load) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	private bool <get_iconSprite>b__95_0(ItemSkinDirectory.Skin x) { }

	[CompilerGeneratedAttribute] 
	private bool <get_isLoadingIconSprite>b__97_0(ItemSkinDirectory.Skin x) { }

}

public enum Item.Flag // TypeDefIndex: 11781
{
	public int value__; 
	public const Item.Flag None = 0;
	public const Item.Flag Placeholder = 1;
	public const Item.Flag IsOn = 2;
	public const Item.Flag OnFire = 4;
	public const Item.Flag IsLocked = 8;
	public const Item.Flag Cooking = 16;

}

private sealed class Item.<>c // TypeDefIndex: 11782
{
	public static readonly Item.<>c <>9; 


	private static void .cctor() { }

	public void .ctor() { }

	internal string <.cctor>b__103_0(ValueTuple<ItemDefinition.AmountType, int> t) { }

}

public sealed class ItemContainer // TypeDefIndex: 11785
{
	public ItemContainer.Flag flags; 
	public ItemContainer.ContentsType allowedContents; 
	public ItemDefinition[] onlyAllowedItems; 
	public List<ItemSlot> availableSlots; 
	public int capacity; 
	public uint uid; 
	public bool dirty; 
	public List<Item> itemList; 
	public float temperature; 
	public Item parent; 
	public BasePlayer playerOwner; 
	public BaseEntity entityOwner; 
	public bool isServer; 
	public int maxStackSize; 

	public bool HasLimitedAllowedItems { get; }


	public bool HasFlag(ItemContainer.Flag f) { }

	public void SetFlag(ItemContainer.Flag f, bool b) { }

	public bool IsLocked() { }

	public bool PlayerItemInputBlocked() { }

	public bool get_HasLimitedAllowedItems() { }

	public void OnChanged() { }

	public void ClientInitialize(Item parentItem, int iMaxCapacity) { }

	public Item FindItemByUID(uint iUID) { }

	public bool IsFull() { }

	public bool IsEmpty() { }

	public bool CanAccept(Item item) { }

	public int GetMaxTransferAmount(ItemDefinition def) { }

	public void SetOnlyAllowedItem(ItemDefinition def) { }

	public void SetOnlyAllowedItems(ItemDefinition[] defs) { }

	internal bool Insert(Item item) { }

	public bool SlotTaken(Item item, int i) { }

	public Item GetSlot(int slot) { }

	internal bool FindPosition(Item item) { }

	internal void Clear() { }

	public void Kill() { }

	public int GetAmount(int itemid, bool onlyUsableAmounts) { }

	public Item FindItemByItemID(int itemid) { }

	public Item FindItemsByItemName(string name) { }

	public Item FindBySubEntityID(uint subEntityID) { }

	public List<Item> FindItemsByItemID(int itemid) { }

	public ItemContainer Save() { }

	public void Load(ItemContainer container) { }

	public BasePlayer GetOwnerPlayer() { }

	public int ContainerMaxStackSize() { }

	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	public bool HasAmmo(AmmoTypes ammoType) { }

	public int GetAmmoAmount(AmmoTypes ammoType) { }

	public int TotalItemAmount() { }

	public uint ContentsHash() { }

	internal ItemContainer FindContainer(uint id) { }

	public ItemContainer.CanAcceptResult CanAcceptItem(Item item, int targetPos) { }

	public void .ctor() { }

}

public enum ItemContainer.Flag // TypeDefIndex: 11786
{
	public int value__; 
	public const ItemContainer.Flag IsPlayer = 1;
	public const ItemContainer.Flag Clothing = 2;
	public const ItemContainer.Flag Belt = 4;
	public const ItemContainer.Flag SingleType = 8;
	public const ItemContainer.Flag IsLocked = 16;
	public const ItemContainer.Flag ShowSlotsOnIcon = 32;
	public const ItemContainer.Flag NoBrokenItems = 64;
	public const ItemContainer.Flag NoItemInput = 128;
	public const ItemContainer.Flag ContentsHidden = 256;

}

public enum ItemContainer.ContentsType // TypeDefIndex: 11787
{
	public int value__; 
	public const ItemContainer.ContentsType Generic = 1;
	public const ItemContainer.ContentsType Liquid = 2;

}

public enum ItemContainer.CanAcceptResult // TypeDefIndex: 11788
{
	public int value__; 
	public const ItemContainer.CanAcceptResult CanAccept = 0;
	public const ItemContainer.CanAcceptResult CannotAccept = 1;
	public const ItemContainer.CanAcceptResult CannotAcceptRightNow = 2;

}

private sealed class ItemContainer.<>c__DisplayClass41_0 // TypeDefIndex: 11789
{
	public int itemid; 


	public void .ctor() { }

	internal bool <FindItemsByItemID>b__0(Item x) { }

}

public class ItemBlueprint : MonoBehaviour // TypeDefIndex: 11790
{
	public List<ItemAmount> ingredients; 
	public List<ItemDefinition> additionalUnlocks; 
	public bool defaultBlueprint; 
	public bool userCraftable; 
	public bool isResearchable; 
	public Rarity rarity; 
	[HeaderAttribute] 
	public int workbenchLevelRequired; 
	[HeaderAttribute] 
	public int scrapRequired; 
	public int scrapFromRecycle; 
	[HeaderAttribute] 
	[TooltipAttribute] 
	public bool NeedsSteamItem; 
	public int blueprintStackSize; 
	public float time; 
	public int amountToCreate; 
	public string UnlockAchievment; 
	public string RecycleStat; 

	public ItemDefinition targetItem { get; }
	public bool NeedsSteamDLC { get; }


	public ItemDefinition get_targetItem() { }

	public bool get_NeedsSteamDLC() { }

	public string GetIngredientString(bool colorMissing) { }

	public void .ctor() { }

}

public class ItemDefinition : MonoBehaviour // TypeDefIndex: 11791
{
	[HeaderAttribute] 
	[ReadOnlyAttribute] 
	public int itemid; 
	[TooltipAttribute] 
	public string shortname; 
	[HeaderAttribute] 
	public Translate.Phrase displayName; 
	public Translate.Phrase displayDescription; 
	public Sprite iconSprite; 
	public ItemCategory category; 
	public ItemSelectionPanel selectionPanel; 
	[HeaderAttribute] 
	public int maxDraggable; 
	public ItemContainer.ContentsType itemType; 
	public ItemDefinition.AmountType amountType; 
	[InspectorFlagsAttribute] 
	public ItemSlot occupySlots; 
	public int stackable; 
	public bool quickDespawn; 
	[HeaderAttribute] 
	[TooltipAttribute] 
	public Rarity rarity; 
	public bool spawnAsBlueprint; 
	[HeaderAttribute] 
	public SoundDefinition inventorySelectSound; 
	public SoundDefinition inventoryGrabSound; 
	public SoundDefinition inventoryDropSound; 
	public SoundDefinition physImpactSoundDef; 
	public ItemDefinition.Condition condition; 
	[HeaderAttribute] 
	public bool hidden; 
	[InspectorFlagsAttribute] 
	public ItemDefinition.Flag flags; 
	[TooltipAttribute] 
	public SteamInventoryItem steamItem; 
	[TooltipAttribute] 
	public SteamDLCItem steamDlc; 
	[TooltipAttribute] 
	public ItemDefinition Parent; 
	public GameObjectRef worldModelPrefab; 
	public ItemDefinition isRedirectOf; 
	public ItemDefinition.RedirectVendingBehaviour redirectVendingBehaviour; 
	public ItemMod[] itemMods; 
	public BaseEntity.TraitFlag Traits; 
	public ItemSkinDirectory.Skin[] skins; 
	private IPlayerItemDefinition[] _skins2; 
	[TooltipAttribute] 
	public GameObject panel; 
	[CompilerGeneratedAttribute] 
	private ItemModWearable <ItemModWearable>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <isHoldable>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <isUsable>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <CraftableWithSkin>k__BackingField; 
	public ItemDefinition[] Children; 

	public IPlayerItemDefinition[] skins2 { get; }
	public ItemBlueprint Blueprint { get; }
	public int craftingStackable { get; }
	public bool isWearable { get; }
	public ItemModWearable ItemModWearable { get; set; }
	public bool isHoldable { get; set; }
	public bool isUsable { get; set; }
	public bool HasSkins { get; }
	public bool CraftableWithSkin { get; set; }


	public IPlayerItemDefinition[] get_skins2() { }

	public void InvalidateWorkshopSkinCache() { }

	public ItemBlueprint get_Blueprint() { }

	public int get_craftingStackable() { }

	public bool HasFlag(ItemDefinition.Flag f) { }

	public void Initialize(List<ItemDefinition> itemList) { }

	public virtual string GetDisplayName(Item item) { }

	public virtual string GetDescriptionText(Item item) { }

	public virtual string GetDescriptionText() { }

	public Sprite FindIconSprite(int skinid) { }

	public bool get_isWearable() { }

	[CompilerGeneratedAttribute] 
	public ItemModWearable get_ItemModWearable() { }

	[CompilerGeneratedAttribute] 
	private void set_ItemModWearable(ItemModWearable value) { }

	[CompilerGeneratedAttribute] 
	public bool get_isHoldable() { }

	[CompilerGeneratedAttribute] 
	private void set_isHoldable(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_isUsable() { }

	[CompilerGeneratedAttribute] 
	private void set_isUsable(bool value) { }

	public bool get_HasSkins() { }

	[CompilerGeneratedAttribute] 
	public bool get_CraftableWithSkin() { }

	[CompilerGeneratedAttribute] 
	private void set_CraftableWithSkin(bool value) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private bool <Initialize>b__45_0(ItemDefinition x) { }

}

public struct ItemDefinition.Condition // TypeDefIndex: 11792
{
	public bool enabled; 
	[TooltipAttribute] 
	public float max; 
	[TooltipAttribute] 
	public bool repairable; 
	[TooltipAttribute] 
	public bool maintainMaxCondition; 
	public ItemDefinition.Condition.WorldSpawnCondition foundCondition; 

}

public class ItemDefinition.Condition.WorldSpawnCondition // TypeDefIndex: 11793
{
	public float fractionMin; 
	public float fractionMax; 


	public void .ctor() { }

}

public enum ItemDefinition.RedirectVendingBehaviour // TypeDefIndex: 11794
{
	public int value__; 
	public const ItemDefinition.RedirectVendingBehaviour NoListing = 0;
	public const ItemDefinition.RedirectVendingBehaviour ListAsUniqueItem = 1;

}

public enum ItemDefinition.Flag // TypeDefIndex: 11795
{
	public int value__; 
	public const ItemDefinition.Flag NoDropping = 1;
	public const ItemDefinition.Flag NotStraightToBelt = 2;

}

public enum ItemDefinition.AmountType // TypeDefIndex: 11796
{
	public int value__; 
	public const ItemDefinition.AmountType Count = 0;
	public const ItemDefinition.AmountType Millilitre = 1;
	public const ItemDefinition.AmountType Feet = 2;
	public const ItemDefinition.AmountType Genetics = 3;
	public const ItemDefinition.AmountType OxygenSeconds = 4;
	public const ItemDefinition.AmountType Frequency = 5;
	public const ItemDefinition.AmountType Generic = 6;

}

private sealed class ItemDefinition.<>c__DisplayClass35_0 // TypeDefIndex: 11797
{
	public string prefabname; 
	public ItemDefinition <>4__this; 


	public void .ctor() { }

	internal bool <get_skins2>b__0(IPlayerItemDefinition x) { }

}

public enum ItemCategory // TypeDefIndex: 11798
{
	public int value__; 
	public const ItemCategory Weapon = 0;
	public const ItemCategory Construction = 1;
	public const ItemCategory Items = 2;
	public const ItemCategory Resources = 3;
	public const ItemCategory Attire = 4;
	public const ItemCategory Tool = 5;
	public const ItemCategory Medical = 6;
	public const ItemCategory Food = 7;
	public const ItemCategory Ammunition = 8;
	public const ItemCategory Traps = 9;
	public const ItemCategory Misc = 10;
	public const ItemCategory All = 11;
	public const ItemCategory Common = 12;
	public const ItemCategory Component = 13;
	public const ItemCategory Search = 14;
	public const ItemCategory Favourite = 15;
	public const ItemCategory Electrical = 16;
	public const ItemCategory Fun = 17;

}

public enum ItemSlot // TypeDefIndex: 11799
{
	public int value__; 
	public const ItemSlot None = 1;
	public const ItemSlot Barrel = 2;
	public const ItemSlot Silencer = 4;
	public const ItemSlot Scope = 8;
	public const ItemSlot UnderBarrel = 16;
	public const ItemSlot Magazine = 32;

}

public enum ItemSelectionPanel // TypeDefIndex: 11800
{
	public int value__; 
	public const ItemSelectionPanel None = 0;
	public const ItemSelectionPanel Vessel = 1;
	public const ItemSelectionPanel Modifications = 2;
	public const ItemSelectionPanel GunInformation = 3;

}

public class ItemSelector : PropertyAttribute // TypeDefIndex: 11801
{
	public ItemCategory category; 


	public void .ctor(ItemCategory category = 11) { }

}

public class ItemMod : MonoBehaviour // TypeDefIndex: 11802
{
	protected ItemMod[] siblingMods; 


	public virtual void ModInit() { }

	public virtual void OnChanged(Item item) { }

	public virtual void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public virtual bool BeltSelect(Item item, BasePlayer player) { }

	public virtual void CL_DoAction(Item item, BasePlayer player) { }

	public virtual void OnObjectSetup(Item item, GameObject obj) { }

	public virtual int GetTotalUISlots(Item item) { }

	public virtual int GetFilledUISlots(Item item) { }

	public virtual bool CanDoAction(Item item, BasePlayer player) { }

	public virtual bool Passes(Item item) { }

	public virtual void OnRemovedFromWorld(Item item) { }

	public virtual void OnMovedToWorld(Item item) { }

	public void .ctor() { }

}

public class ItemModActionChange : ItemMod // TypeDefIndex: 11803
{
	public ItemMod[] actions; 


	private void OnValidate() { }

	public void .ctor() { }

}

public class ItemModActionContainerChange : ItemMod // TypeDefIndex: 11804
{
	public ItemMod[] actions; 


	private void OnValidate() { }

	public void .ctor() { }

}

public class ItemModAlterCondition : ItemMod // TypeDefIndex: 11805
{
	public float conditionChange; 


	public void .ctor() { }

}

public class ItemModAnimalEquipment : ItemMod // TypeDefIndex: 11806
{
	public BaseEntity.Flags WearableFlag; 
	public bool hideHair; 
	public ProtectionProperties animalProtection; 
	public ProtectionProperties riderProtection; 
	public int additionalInventorySlots; 
	public float speedModifier; 
	public float staminaUseModifier; 
	public ItemModAnimalEquipment.SlotType slot; 


	public void .ctor() { }

}

public enum ItemModAnimalEquipment.SlotType // TypeDefIndex: 11807
{
	public int value__; 
	public const ItemModAnimalEquipment.SlotType Basic = 0;
	public const ItemModAnimalEquipment.SlotType Armor = 1;
	public const ItemModAnimalEquipment.SlotType Saddle = 2;
	public const ItemModAnimalEquipment.SlotType Bit = 3;
	public const ItemModAnimalEquipment.SlotType Feet = 4;

}

public abstract class ItemModAssociatedEntity<T> : ItemMod // TypeDefIndex: 11808
{
	public GameObjectRef entityPrefab; 

	protected virtual bool AllowNullParenting { get; }
	protected virtual bool AllowHeldEntityParenting { get; }


	protected virtual bool get_AllowNullParenting() { }
	/* GenericInstMethod :
	|
	|-ItemModAssociatedEntity<PagerEntity>.get_AllowNullParenting
	|-ItemModAssociatedEntity<object>.get_AllowNullParenting
	*/

	protected virtual bool get_AllowHeldEntityParenting() { }
	/* GenericInstMethod :
	|
	|-ItemModAssociatedEntity<MobileInventoryEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<PagerEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<PaintedItemStorageEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<PhotoEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<SignContent>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<object>.get_AllowHeldEntityParenting
	*/

	public static T GetAssociatedEntity(Item item, bool isServer = True) { }
	/* GenericInstMethod :
	|
	|-ItemModAssociatedEntity<MobileInventoryEntity>.GetAssociatedEntity
	|-ItemModAssociatedEntity<PagerEntity>.GetAssociatedEntity
	|-ItemModAssociatedEntity<PaintedItemStorageEntity>.GetAssociatedEntity
	|-ItemModAssociatedEntity<SignContent>.GetAssociatedEntity
	|-ItemModAssociatedEntity<object>.GetAssociatedEntity
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-ItemModAssociatedEntity<Cassette>..ctor
	|-ItemModAssociatedEntity<MobileInventoryEntity>..ctor
	|-ItemModAssociatedEntity<PagerEntity>..ctor
	|-ItemModAssociatedEntity<PaintedItemStorageEntity>..ctor
	|-ItemModAssociatedEntity<PhotoEntity>..ctor
	|-ItemModAssociatedEntity<SignContent>..ctor
	|-ItemModAssociatedEntity<object>..ctor
	*/

}

public class ItemModBaitContainer : ItemModContainer // TypeDefIndex: 11809
{

	public void .ctor() { }

}

public class ItemModBlueprintCraft : ItemMod // TypeDefIndex: 11810
{
	public GameObjectRef successEffect; 


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModBurnable : ItemMod // TypeDefIndex: 11811
{
	public float fuelAmount; 
	[ItemSelector] 
	public ItemDefinition byproductItem; 
	public int byproductAmount; 
	public float byproductChance; 


	public void .ctor() { }

}

public class ItemModCassetteContainer : ItemModContainer // TypeDefIndex: 11812
{
	public ItemDefinition[] CassetteItems; 


	public void .ctor() { }

}

public class ItemModChildIO : ItemMod // TypeDefIndex: 11813
{
	public GameObjectRef TargetChildIO; 


	public void .ctor() { }

}

public class ItemModCompostable : MonoBehaviour // TypeDefIndex: 11814
{
	public float TotalFertilizerProduced; 
	public float BaitValue; 


	public void .ctor() { }

}

public class ItemModConditionContainerFlag : ItemMod // TypeDefIndex: 11815
{
	public ItemContainer.Flag flag; 
	public bool requiredState; 


	public override bool Passes(Item item) { }

	public void .ctor() { }

}

public class ItemModConditionHasCondition : ItemMod // TypeDefIndex: 11816
{
	public float conditionTarget; 
	[TooltipAttribute] 
	public float conditionFractionTarget; 
	public bool lessThan; 


	public override bool Passes(Item item) { }

	public void .ctor() { }

}

public class ItemModConditionHasContents : ItemMod // TypeDefIndex: 11817
{
	[TooltipAttribute] 
	public ItemDefinition itemDef; 
	public bool requiredState; 


	public override bool Passes(Item item) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private bool <Passes>b__2_0(Item x) { }

}

public class ItemModConditionHasFlag : ItemMod // TypeDefIndex: 11818
{
	public Item.Flag flag; 
	public bool requiredState; 


	public override bool Passes(Item item) { }

	public void .ctor() { }

}

public class ItemModConditionInWater : ItemMod // TypeDefIndex: 11819
{
	public bool requiredState; 


	public override bool Passes(Item item) { }

	public void .ctor() { }

}

public class ItemModConditionIsSleeping : ItemMod // TypeDefIndex: 11820
{
	public bool requiredState; 


	public override bool Passes(Item item) { }

	public void .ctor() { }

}

public class ItemModConsumable : MonoBehaviour // TypeDefIndex: 11821
{
	public int amountToConsume; 
	public float conditionFractionToLose; 
	public string achievementWhenEaten; 
	public List<ItemModConsumable.ConsumableEffect> effects; 
	public List<ModifierDefintion> modifiers; 


	public float GetIfType(MetabolismAttribute.Type typeToPick) { }

	public void .ctor() { }

}

public class ItemModConsumable.ConsumableEffect // TypeDefIndex: 11822
{
	public MetabolismAttribute.Type type; 
	public float amount; 
	public float time; 
	public float onlyIfHealthLessThan; 


	public void .ctor() { }

}

public class ItemModConsume : ItemMod // TypeDefIndex: 11823
{
	public GameObjectRef consumeEffect; 
	public string eatGesture; 
	[TooltipAttribute] 
	public ItemAmountRandom[] product; 
	public ItemModConsumable primaryConsumable; 


	public override void CL_DoAction(Item item, BasePlayer player) { }

	public override bool CanDoAction(Item item, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModConsumeChance : ItemModConsume // TypeDefIndex: 11824
{
	public float chanceForSecondaryConsume; 
	public GameObjectRef secondaryConsumeEffect; 
	public ItemModConsumable secondaryConsumable; 


	public void .ctor() { }

}

public class ItemModConsumeContents : ItemMod // TypeDefIndex: 11825
{
	public GameObjectRef consumeEffect; 


	public override void CL_DoAction(Item item, BasePlayer player) { }

	public override bool CanDoAction(Item item, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModContainer : ItemMod // TypeDefIndex: 11826
{
	public int capacity; 
	public int maxStackSize; 
	[InspectorFlagsAttribute] 
	public ItemContainer.Flag containerFlags; 
	public ItemContainer.ContentsType onlyAllowedContents; 
	public ItemDefinition onlyAllowedItemType; 
	public List<ItemSlot> availableSlots; 
	public ItemDefinition[] validItemWhitelist; 
	public bool openInDeployed; 
	public bool openInInventory; 
	public List<ItemAmount> defaultContents; 


	public override int GetTotalUISlots(Item item) { }

	public override int GetFilledUISlots(Item item) { }

	public void .ctor() { }

}

public class ItemModContainerRestriction : ItemMod // TypeDefIndex: 11827
{
	[InspectorFlagsAttribute] 
	public ItemModContainerRestriction.SlotFlags slotFlags; 


	public bool CanExistWith(ItemModContainerRestriction other) { }

	public void .ctor() { }

}

public enum ItemModContainerRestriction.SlotFlags // TypeDefIndex: 11828
{
	public int value__; 
	public const ItemModContainerRestriction.SlotFlags Map = 1;

}

public class ItemModCookable : ItemMod // TypeDefIndex: 11829
{
	[ItemSelector] 
	public ItemDefinition becomeOnCooked; 
	public float cookTime; 
	public int amountOfBecome; 
	public int lowTemp; 
	public int highTemp; 
	public bool setCookingFlag; 


	public void OnValidate() { }

	public bool CanBeCookedByAtTemperature(float temperature) { }

	public void .ctor() { }

}

public class ItemModCycle : ItemMod // TypeDefIndex: 11830
{
	public ItemMod[] actions; 
	public float timeBetweenCycles; 
	public float timerStart; 
	public bool onlyAdvanceTimerWhenPass; 


	private void OnValidate() { }

	public void .ctor() { }

}

public class ItemModDeployable : MonoBehaviour // TypeDefIndex: 11831
{
	public GameObjectRef entityPrefab; 
	[HeaderAttribute] 
	public bool showCrosshair; 
	public string UnlockAchievement; 


	public Deployable GetDeployable(BaseEntity entity) { }

	public void .ctor() { }

}

public class ItemModEntity : ItemMod // TypeDefIndex: 11832
{
	public GameObjectRef entityPrefab; 
	public string defaultBone; 


	public void .ctor() { }

}

public class ItemModEntityReference : MonoBehaviour // TypeDefIndex: 11833
{
	public GameObjectRef entityPrefab; 


	public void .ctor() { }

}

public class ItemModFishable : ItemMod // TypeDefIndex: 11834
{
	public bool CanBeFished; 
	[HeaderAttribute] 
	public float StrainModifier; 
	public float MoveMultiplier; 
	public float ReelInSpeedMultiplier; 
	public float CatchWaitTimeMultiplier; 
	[HeaderAttribute] 
	public float MinimumBaitLevel; 
	public float MaximumBaitLevel; 
	public float MinimumWaterDepth; 
	public float MaximumWaterDepth; 
	[InspectorFlagsAttribute] 
	public WaterBody.FishingTag RequiredTag; 
	[RangeAttribute] 
	public float Chance; 
	public string SteamStatName; 


	public void .ctor() { }

}

public class ItemModGiveOxygen : ItemMod, IAirSupply // TypeDefIndex: 11836
{
	public ItemModGiveOxygen.AirSupplyType airType; 
	public int amountToConsume; 
	public GameObjectRef inhaleEffect; 
	public GameObjectRef exhaleEffect; 
	public GameObjectRef bubblesEffect; 
	private float timeRemaining; 
	private float cycleTime; 

	public ItemModGiveOxygen.AirSupplyType AirType { get; }


	public ItemModGiveOxygen.AirSupplyType get_AirType() { }

	public float GetAirTimeRemaining() { }

	public override void ModInit() { }

	public override void OnChanged(Item item) { }

	public void .ctor() { }

}

public enum ItemModGiveOxygen.AirSupplyType // TypeDefIndex: 11837
{
	public int value__; 
	public const ItemModGiveOxygen.AirSupplyType Lungs = 0;
	public const ItemModGiveOxygen.AirSupplyType ScubaTank = 1;
	public const ItemModGiveOxygen.AirSupplyType Submarine = 2;

}

public class ItemModKeycard : ItemMod // TypeDefIndex: 11838
{
	public int accessLevel; 


	public void .ctor() { }

}

public class ItemModMenuOption : ItemMod // TypeDefIndex: 11839
{
	public string commandName; 
	public ItemMod actionTarget; 
	public BaseEntity.Menu.Option option; 
	[TooltipAttribute] 
	public bool isPrimaryOption; 


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public override bool BeltSelect(Item item, BasePlayer player) { }

	private void OnValidate() { }

	public void .ctor() { }

}

public class ItemModPaintable : ItemModAssociatedEntity<PaintedItemStorageEntity> // TypeDefIndex: 11840
{
	public GameObjectRef ChangeSignTextDialog; 
	public MeshPaintableSource[] PaintableSources; 
	private EntityRef<PaintedItemStorageEntity> _paintStorage; 

	protected override bool AllowNullParenting { get; }


	protected override bool get_AllowNullParenting() { }

	public override void OnObjectSetup(Item item, GameObject obj) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator DeferredSetup(Item item, PaintableItem paintable) { }

	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	private void PaintClicked(BasePlayer player) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator OpenPaintUI(EntityRef<PaintedItemStorageEntity> paintStorage) { }

	public void .ctor() { }

}

private sealed class ItemModPaintable.<DeferredSetup>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11841
{
	private int <>1__state; 
	private object <>2__current; 
	public Item item; 
	public PaintableItem paintable; 
	public ItemModPaintable <>4__this; 
	private int <count>5__2; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemModPaintable.<>c__DisplayClass9_0 // TypeDefIndex: 11842
{
	public PaintedItemStorageEntity entity; 


	public void .ctor() { }

	internal void <OpenPaintUI>b__0(int frame, Texture2D texture) { }

}

private sealed class ItemModPaintable.<OpenPaintUI>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11843
{
	private int <>1__state; 
	private object <>2__current; 
	public EntityRef<PaintedItemStorageEntity> paintStorage; 
	public ItemModPaintable <>4__this; 
	private int <i>5__2; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

public class ItemModPetStats : ItemMod // TypeDefIndex: 11844
{
	[TooltipAttribute] 
	public float SpeedModifier; 
	[TooltipAttribute] 
	public float MaxHealthModifier; 
	[TooltipAttribute] 
	public float AttackDamageModifier; 
	[TooltipAttribute] 
	public float AttackRateModifier; 


	public void .ctor() { }

}

public class ItemModProjectile : MonoBehaviour // TypeDefIndex: 11845
{
	public GameObjectRef projectileObject; 
	public ItemModProjectileMod[] mods; 
	public AmmoTypes ammoType; 
	public int numProjectiles; 
	public float projectileSpread; 
	public float projectileVelocity; 
	public float projectileVelocitySpread; 
	public bool useCurve; 
	public AnimationCurve spreadScalar; 
	public GameObjectRef attackEffectOverride; 
	public float barrelConditionLoss; 
	public string category; 


	public float GetRandomVelocity() { }

	public float GetSpreadScalar() { }

	public float GetIndexedSpreadScalar(int shotIndex, int maxShots) { }

	public float GetAverageVelocity() { }

	public float GetMinVelocity() { }

	public float GetMaxVelocity() { }

	public bool IsAmmo(AmmoTypes ammo) { }

	public virtual void ServerProjectileHit(HitInfo info) { }

	public void .ctor() { }

}

public class ItemModProjectileMod : MonoBehaviour // TypeDefIndex: 11846
{

	public virtual void ServerProjectileHit(HitInfo info) { }

	public void .ctor() { }

}

public class ItemModProjectileRadialDamage : ItemModProjectileMod // TypeDefIndex: 11847
{
	public float radius; 
	public DamageTypeEntry damage; 
	public GameObjectRef effect; 
	public bool ignoreHitObject; 


	public void .ctor() { }

}

public class ItemModProjectileSpawn : ItemModProjectile // TypeDefIndex: 11848
{
	public float createOnImpactChance; 
	public GameObjectRef createOnImpact; 
	public float spreadAngle; 
	public float spreadVelocityMin; 
	public float spreadVelocityMax; 
	public int numToCreateChances; 


	public void .ctor() { }

}

public class ItemModRecycleInto : ItemMod // TypeDefIndex: 11849
{
	public ItemDefinition recycleIntoItem; 
	public int numRecycledItemMin; 
	public int numRecycledItemMax; 
	public GameObjectRef successEffect; 


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModRepair : ItemMod // TypeDefIndex: 11850
{
	public float conditionLost; 
	public GameObjectRef successEffect; 
	public int workbenchLvlRequired; 


	public bool HasCraftLevel(BasePlayer player) { }

	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModReveal : ItemMod // TypeDefIndex: 11851
{
	public int numForReveal; 
	public ItemDefinition revealedItemOverride; 
	public int revealedItemAmount; 
	public LootSpawn revealList; 
	public GameObjectRef successEffect; 


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModSound : ItemMod // TypeDefIndex: 11852
{
	public GameObjectRef effect; 
	public ItemModSound.Type actionType; 


	public void .ctor() { }

}

public enum ItemModSound.Type // TypeDefIndex: 11853
{
	public int value__; 
	public const ItemModSound.Type OnAttachToWeapon = 0;

}

public class ItemModStudyBlueprint : ItemMod // TypeDefIndex: 11854
{
	public GameObjectRef studyEffect; 


	public void .ctor() { }

}

public class ItemModSummerSunglassesEquip : ItemMod // TypeDefIndex: 11855
{
	public float SunsetTime; 
	public float SunriseTime; 
	public string AchivementName; 


	public void .ctor() { }

}

public class ItemModSwap : ItemMod // TypeDefIndex: 11856
{
	public GameObjectRef actionEffect; 
	public ItemAmount[] becomeItem; 
	public bool sendPlayerPickupNotification; 
	public bool sendPlayerDropNotification; 
	public float xpScale; 
	public ItemAmount[] RandomOptions; 


	public void .ctor() { }

}

public class ItemModSwitchFlag : ItemMod // TypeDefIndex: 11857
{
	public Item.Flag flag; 
	public bool state; 


	public void .ctor() { }

}

public class ItemModUpgrade : ItemMod // TypeDefIndex: 11858
{
	public int numForUpgrade; 
	public float upgradeSuccessChance; 
	public int numToLoseOnFail; 
	public ItemDefinition upgradedItem; 
	public int numUpgradedItem; 
	public GameObjectRef successEffect; 
	public GameObjectRef failEffect; 


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModUseContent : ItemMod // TypeDefIndex: 11859
{
	public int amountToConsume; 


	public void .ctor() { }

}

public class ItemModWearable : ItemMod // TypeDefIndex: 11860
{
	public GameObjectRef entityPrefab; 
	public GameObjectRef entityPrefabFemale; 
	public ProtectionProperties protectionProperties; 
	public ArmorProperties armorProperties; 
	public ClothingMovementProperties movementProperties; 
	public UIBlackoutOverlay.blackoutType occlusionType; 
	public bool blocksAiming; 
	public bool emissive; 
	public float accuracyBonus; 
	public bool blocksEquipping; 
	public float eggVision; 
	public float weight; 
	public bool equipOnRightClick; 
	public bool npcOnly; 
	public GameObjectRef breakEffect; 
	public GameObjectRef viewmodelAddition; 

	public Wearable targetWearable { get; }


	public Wearable get_targetWearable() { }

	private void DoPrepare() { }

	public override void ModInit() { }

	public bool ProtectsArea(HitArea area) { }

	public bool HasProtections() { }

	internal float GetProtection(Item item, DamageType damageType) { }

	public float ConditionProtectionScale(Item item) { }

	public void CollectProtection(Item item, ProtectionProperties protection) { }

	private bool IsHeadgear() { }

	public bool IsFootwear() { }

	public void OnDressModel(Item item, PlayerModel model) { }

	public override void OnObjectSetup(Item item, GameObject obj) { }

	public bool CanExistWith(ItemModWearable wearable) { }

	public void .ctor() { }

}

private sealed class ItemModWearable.<>c__DisplayClass28_0 // TypeDefIndex: 11861
{
	public Item item; 


	public void .ctor() { }

	internal bool <OnObjectSetup>b__0(ItemSkinDirectory.Skin x) { }

}

public class ItemModXPWhenUsed : ItemMod // TypeDefIndex: 11862
{
	public float xpPerUnit; 
	public int unitSize; 


	public void GiveConsumeXP(Item item) { }

	public void .ctor() { }

}

public class ItemFootstepSounds : MonoBehaviour // TypeDefIndex: 11863
{
	public string effectFolder; 


	public void .ctor() { }

}

public class ItemAmount : ISerializationCallbackReceiver // TypeDefIndex: 11864
{
	[ItemSelector] 
	public ItemDefinition itemDef; 
	public float amount; 
	public float startAmount; 

	public int itemid { get; }


	public void .ctor(ItemDefinition item, float amt = 0) { }

	public int get_itemid() { }

	public virtual float GetAmount() { }

	public virtual void OnAfterDeserialize() { }

	public virtual void OnBeforeSerialize() { }

	public static ItemAmountList SerialiseList(List<ItemAmount> list) { }

	public static void DeserialiseList(List<ItemAmount> target, ItemAmountList source) { }

}

public class ItemAmountRandom // TypeDefIndex: 11865
{
	[ItemSelector] 
	public ItemDefinition itemDef; 
	public AnimationCurve amount; 


	public int RandomAmount() { }

	public void .ctor() { }

}

public class ItemAmountRanged : ItemAmount // TypeDefIndex: 11866
{
	public float maxAmount; 


	public override void OnAfterDeserialize() { }

	public void .ctor(ItemDefinition item, float amt = 0, float max = -1) { }

	public override float GetAmount() { }

}

public class ItemManager // TypeDefIndex: 11867
{
	public static List<ItemDefinition> itemList; 
	public static Dictionary<int, ItemDefinition> itemDictionary; 
	public static Dictionary<string, ItemDefinition> itemDictionaryByName; 
	public static List<ItemBlueprint> bpList; 
	public static int[] defaultBlueprints; 
	public static ItemDefinition blueprintBaseDef; 


	public static void InvalidateWorkshopSkinCache() { }

	public static void Initialize() { }

	public static void UpdateUnlockedSkins() { }

	public static Item Load(Item load, Item created, bool isServer) { }

	public static ItemDefinition FindItemDefinition(int itemID) { }

	public static ItemDefinition FindItemDefinition(string shortName) { }

	public static ItemBlueprint FindBlueprint(ItemDefinition item) { }

	public static List<ItemDefinition> GetItemDefinitions() { }

	public static List<ItemBlueprint> GetBlueprints() { }

	public void .ctor() { }

}

private sealed class ItemManager.<>c // TypeDefIndex: 11868
{
	public static readonly ItemManager.<>c <>9; 
	public static Func<GameObject, ItemDefinition> <>9__7_0; 
	public static Func<ItemDefinition, bool> <>9__7_1; 
	public static Func<GameObject, ItemBlueprint> <>9__7_2; 
	public static Func<ItemBlueprint, bool> <>9__7_3; 
	public static Func<ItemBlueprint, bool> <>9__7_4; 
	public static Func<ItemBlueprint, int> <>9__7_5; 


	private static void .cctor() { }

	public void .ctor() { }

	internal ItemDefinition <Initialize>b__7_0(GameObject x) { }

	internal bool <Initialize>b__7_1(ItemDefinition x) { }

	internal ItemBlueprint <Initialize>b__7_2(GameObject x) { }

	internal bool <Initialize>b__7_3(ItemBlueprint x) { }

	internal bool <Initialize>b__7_4(ItemBlueprint x) { }

	internal int <Initialize>b__7_5(ItemBlueprint x) { }

}

public class ItemSkin : SteamInventoryItem // TypeDefIndex: 12416
{
	public Skinnable Skinnable; 
	public Material[] Materials; 
	[TooltipAttribute] 
	public ItemDefinition Redirect; 
	public SteamInventoryItem UnlockedViaSteamItem; 


	public void ApplySkin(GameObject obj) { }

	public override bool HasUnlocked(ulong playerId) { }

	public void .ctor() { }

}

public class ItemSkinDirectory : ScriptableObject // TypeDefIndex: 12417
{
	private static ItemSkinDirectory _Instance; 
	public ItemSkinDirectory.Skin[] skins; 

	public static ItemSkinDirectory Instance { get; }


	public static ItemSkinDirectory get_Instance() { }

	public static ItemSkinDirectory.Skin[] ForItem(ItemDefinition item) { }

	public static ItemSkinDirectory.Skin FindByInventoryDefinitionId(int id) { }

	public void .ctor() { }

}

public struct ItemSkinDirectory.Skin // TypeDefIndex: 12418
{
	public int id; 
	public int itemid; 
	public string name; 
	public bool isSkin; 
	private SteamInventoryItem _invItem; 

	public SteamInventoryItem invItem { get; }


	public SteamInventoryItem get_invItem() { }

}

private sealed class ItemSkinDirectory.<>c__DisplayClass5_0 // TypeDefIndex: 12419
{
	public ItemDefinition item; 


	public void .ctor() { }

	internal bool <ForItem>b__0(ItemSkinDirectory.Skin x) { }

}

private sealed class ItemSkinDirectory.<>c__DisplayClass6_0 // TypeDefIndex: 12420
{
	public int id; 


	public void .ctor() { }

	internal bool <FindByInventoryDefinitionId>b__0(ItemSkinDirectory.Skin x) { }

}

public abstract class ItemContainerSource : MonoBehaviour // TypeDefIndex: 12530
{

	public abstract ItemContainer GetItemContainer();

	protected void .ctor() { }

}

public class ItemDropCommand : MonoBehaviour // TypeDefIndex: 12690
{
	public string command; 


	private void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	public void .ctor() { }

}

public class ItemIcon : BaseMonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IDraggable, IInventoryChanged, IItemAmountChanged, IItemIconChanged // TypeDefIndex: 12691
{
	private Color backgroundColor; 
	public Color selectedBackgroundColor; 
	public float unoccupiedAlpha; 
	public Color unoccupiedColor; 
	public ItemContainerSource containerSource; 
	public int slotOffset; 
	[RangeAttribute] 
	public int slot; 
	public bool setSlotFromSiblingIndex; 
	public GameObject slots; 
	public CanvasGroup iconContents; 
	public CanvasGroup canvasGroup; 
	public Image iconImage; 
	public Image underlayImage; 
	public Text amountText; 
	public Text hoverText; 
	public Image hoverOutline; 
	public Image cornerIcon; 
	public Image lockedImage; 
	public Image progressImage; 
	public Image backgroundImage; 
	public Image backgroundUnderlayImage; 
	public Sprite emptySlotBackgroundSprite; 
	public CanvasGroup conditionObject; 
	public Image conditionFill; 
	public Image maxConditionFill; 
	public bool allowSelection; 
	public bool allowDropping; 
	public bool allowMove; 
	public Item item; 
	public bool invalidSlot; 
	public SoundDefinition hoverSound; 
	internal Image[] slotImages; 
	private static Dictionary<uint, float> containerLootStartTimes; 
	private bool queuedForLooting; 
	private const float processLootQueueInterval = 0,2;
	private const float lootItemDuration = 0,2;
	private uint queuedQuickLootContainerID; 
	private float queuedLootAtTime; 
	private bool visible; 
	private bool hovering; 
	private CanvasGroup canvasGroupParent; 
	private Coroutine currentCouroutine; 
	private bool isSelected; 
	public Action timedAction; 
	public Nullable<Vector2> timedActionTime; 

	private Item iconValue { get; }


	protected void Awake() { }

	protected void OnEnable() { }

	public static void ClearLootTimers() { }

	public void ClearProgressImage() { }

	protected void OnDisable() { }

	public void OnShow() { }

	public void OnHide() { }

	public void ClearLooting() { }

	private void Update() { }

	public Sprite GetItemSprite(out Color tint) { }

	public void OnItemAmountChanged() { }

	public void OnItemIconChanged() { }

	public void OnInventoryChanged() { }

	private void UpdateHoverText() { }

	private void UpdateItemIcon() { }

	private void SetBackgroundUnderlayVisible(bool flag) { }

	private void UpdateCornerIcon() { }

	private void UpdateSlots() { }

	private Item get_iconValue() { }

	public void Select() { }

	public void SelectSilent() { }

	private void InternalSelect(bool silent = False) { }

	public void Deselect() { }

	public void SetActive(bool active) { }

	private void UpdateBackgroundColor() { }

	public virtual void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	private bool TryToDropInsideItem(ItemIcon.DragInfo dropInfo, Item item) { }

	public void SetTimedLootAction(uint sourceContainer, Action action) { }

	private float CalculateLootDelay(uint sourceContainer) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator StartTimedLootAction(float delay) { }

	public void RunTimedAction() { }

	public void ClearTimedAction() { }

	private void RemoveFromLootQueue() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator UpdateTimedActionIcon() { }

	public void TryToQuickMove() { }

	public virtual void TryToMove() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OnPointerExit(PointerEventData eventData) { }

	public object GetDragData() { }

	public string GetDragType() { }

	public Sprite GetDragSprite() { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	private void <TryToMove>b__82_0() { }

}

public class ItemIcon.DragInfo // TypeDefIndex: 12692
{
	public Item item; 
	public int amount; 
	public bool canDrop; 


	public void .ctor() { }

}

private sealed class ItemIcon.<StartTimedLootAction>d__76 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12693
{
	private int <>1__state; 
	private object <>2__current; 
	public ItemIcon <>4__this; 
	public float delay; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemIcon.<UpdateTimedActionIcon>d__80 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12694
{
	private int <>1__state; 
	private object <>2__current; 
	public ItemIcon <>4__this; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

public class ItemInformationPanel : MonoBehaviour // TypeDefIndex: 12695
{

	public virtual bool EligableForDisplay(ItemDefinition info) { }

	public virtual void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

public class ItemOptionButton : MonoBehaviour // TypeDefIndex: 12696
{
	public TextMeshProUGUI name; 
	public Image icon; 
	internal Item item; 
	internal Option option; 


	public void Setup(Item item, Option option) { }

	public void Pressed() { }

	public void .ctor() { }

}

public class ItemPanel : SingletonComponent<ItemPanel> // TypeDefIndex: 12697
{
	private ItemIcon item; 


	private void Start() { }

	public void Update() { }

	private void OnChanged() { }

	public void .ctor() { }

}

public class ItemPickupNotice : MonoBehaviour // TypeDefIndex: 12698
{
	public TextMeshProUGUI Text; 
	public TextMeshProUGUI Amount; 
	private TimeSince enabledTime; 
	private RectTransform targetRect; 
	private CanvasGroup targetCanvas; 
	private ItemDefinition def; 
	private bool isReuse; 
	private int cachedAmount; 
	private const float pickupNoticeTime = 4;
	private int scheduledTotal; 

	public ItemDefinition itemInfo { get; set; }
	public int amount { get; set; }


	public void set_itemInfo(ItemDefinition value) { }

	public ItemDefinition get_itemInfo() { }

	public void set_amount(int value) { }

	public int get_amount() { }

	public void AppendTotal(int amount) { }

	public void OnEnable() { }

	public void BlockLayoutUpdates() { }

	public void AllowLayoutUpdates() { }

	public bool ProcessAnimation(AnimationCurve sizeCurve, AnimationCurve alphaCurve, AnimationCurve reuseSizeCurve, AnimationCurve reuseAlphaCurve) { }

	public void PopupNoticeEnd() { }

	public void UpdateItemCount(int amountAdded, int totalAmount) { }

	public void ScheduleTotalUpdate(int currentTotal) { }

	private void ProcessTotalUpdate() { }

	public void .ctor() { }

}

public class ItemPreviewIcon : BaseMonoBehaviour, IInventoryChanged, IItemAmountChanged, IItemIconChanged // TypeDefIndex: 12699
{
	public ItemContainerSource containerSource; 
	[RangeAttribute] 
	public int slot; 
	public bool setSlotFromSiblingIndex; 
	public CanvasGroup iconContents; 
	public Image iconImage; 
	public Text amountText; 
	public Item item; 
	private bool invalidSlot; 

	private Item iconValue { get; }


	protected void OnEnable() { }

	protected void OnDisable() { }

	public Sprite GetItemSprite() { }

	public void OnItemAmountChanged() { }

	public void OnItemIconChanged() { }

	public void OnInventoryChanged() { }

	private void UpdateItemIcon() { }

	private Item get_iconValue() { }

	public void .ctor() { }

}

public class ItemSplitter : MonoBehaviour // TypeDefIndex: 12700
{
	public Slider slider; 
	public TextMeshProUGUI textValue; 
	public TextMeshProUGUI splitAmountText; 
	public TMP_InputField amountInputField; 
	private static bool isInputFieldOpen; 
	private float oldAmount; 

	public ItemIcon.DragInfo dragInfo { get; }


	public static bool IsInputFieldOpen() { }

	private void Start() { }

	public ItemIcon.DragInfo get_dragInfo() { }

	public void RefreshValue() { }

	public void Update() { }

	private string FormatValueString(float value) { }

	private void OnAmountInputFieldValueChanged() { }

	public void OnSliderLeftMouseDown() { }

	public void OnSliderRightMouseUp() { }

	public void OnSliderMiddleMouseDown() { }

	private void SetAmountInputFieldVisible(bool flag) { }

	public static int GetSplitAmount(int itemAmount) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	private void <Start>b__6_0(string <p0>) { }

	[CompilerGeneratedAttribute] 
	private void <Start>b__6_1(string <p0>) { }

}

public class ItemSplitterDragOut : MonoBehaviour, IDraggable // TypeDefIndex: 12701
{
	public ItemSplitter rootSplitter; 


	public object GetDragData() { }

	public string GetDragType() { }

	public Sprite GetDragSprite() { }

	public void .ctor() { }

}

public class ItemSplitterSlider : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler // TypeDefIndex: 12702
{
	public ItemSplitter Splitter; 


	public void OnPointerDown(PointerEventData eventData) { }

	public void OnPointerUp(PointerEventData eventData) { }

	public void .ctor() { }

}

public class ItemStatValue : MonoBehaviour // TypeDefIndex: 12703
{
	public Text text; 
	public Slider slider; 
	public bool selectedItem; 
	public bool smallerIsBetter; 
	public bool asPercentage; 


	private void OnEnable() { }

	private void OnDisable() { }

	public void SetValue(float val, int numDecimals = 0, string overrideText = "") { }

	public void .ctor() { }

}

public class ItemSubmitPanel : LootPanel // TypeDefIndex: 12704
{

	public void SubmitClicked() { }

	public void .ctor() { }

}

public class ItemTextValue : MonoBehaviour // TypeDefIndex: 12705
{
	public Text text; 
	public Color bad; 
	public Color good; 
	public bool negativestat; 
	public bool asPercentage; 
	public bool useColors; 
	public bool signed; 
	public string suffix; 
	public float multiplier; 


	public void SetValue(float val, int numDecimals = 0, string overrideText = "") { }

	public void .ctor() { }

}

public class ItemStore : SingletonComponent<ItemStore>, VirtualScroll.IDataSource // TypeDefIndex: 12798
{
	public static readonly Translate.Phrase CartEmptyPhrase; 
	public static readonly Translate.Phrase CartSingularPhrase; 
	public static readonly Translate.Phrase CartPluralPhrase; 
	public GameObject ItemPrefab; 
	[FormerlySerializedAsAttribute] 
	public RectTransform LimitedItemParent; 
	public RectTransform GeneralItemParent; 
	public List<IPlayerItemDefinition> Cart; 
	public ItemStoreItemInfoModal ItemStoreInfoModal; 
	public GameObject BuyingModal; 
	public ItemStoreBuyFailedModal ItemStoreBuyFailedModal; 
	public ItemStoreBuySuccessModal ItemStoreBuySuccessModal; 
	public SoundDefinition AddToCartSound; 
	public RustText CartButtonLabel; 
	public RustText QuantityValue; 
	public RustText TotalValue; 


	protected override void Awake() { }

	private void OnPurchaseFinished(AppId appid, ulong orderid, bool success) { }

	[AsyncStateMachineAttribute] 
	private void RefreshList() { }

	private void AddItem(IPlayerItemDefinition item) { }

	internal void ShowModal(IPlayerItemDefinition item) { }

	internal void AddToCart(IPlayerItemDefinition item) { }

	public void EmptyCart() { }

	private void UpdateShoppingList() { }

	public void RemoveFromCart(int index) { }

	[AsyncStateMachineAttribute] 
	public void Checkout() { }

	public int GetItemCount() { }

	public void SetItemData(int i, GameObject obj) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class ItemStore.<>c // TypeDefIndex: 12799
{
	public static readonly ItemStore.<>c <>9; 
	public static Func<IPlayerItemDefinition, int> <>9__16_0; 
	public static Func<IPlayerItemDefinition, int> <>9__17_0; 
	public static Func<IPlayerItemDefinition, int> <>9__22_0; 
	public static Func<SteamItemDefinition, InventoryDef> <>9__24_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <OnPurchaseFinished>b__16_0(IPlayerItemDefinition x) { }

	internal int <RefreshList>b__17_0(IPlayerItemDefinition x) { }

	internal int <UpdateShoppingList>b__22_0(IPlayerItemDefinition x) { }

	internal InventoryDef <Checkout>b__24_0(SteamItemDefinition i) { }

}

private struct ItemStore.<RefreshList>d__17 : IAsyncStateMachine // TypeDefIndex: 12800
{
	public int <>1__state; 
	public AsyncVoidMethodBuilder <>t__builder; 
	public ItemStore <>4__this; 
	private TaskAwaiter<List<IPlayerItemDefinition>> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ItemStore.<Checkout>d__24 : IAsyncStateMachine // TypeDefIndex: 12801
{
	public int <>1__state; 
	public AsyncVoidMethodBuilder <>t__builder; 
	public ItemStore <>4__this; 
	private TaskAwaiter<Nullable<InventoryPurchaseResult>> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class ItemStoreBuyFailedModal : MonoBehaviour // TypeDefIndex: 12802
{

	public void Show(ulong orderid) { }

	public void Hide() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <Hide>b__1_0() { }

}

public class ItemStoreBuySuccessModal : MonoBehaviour // TypeDefIndex: 12803
{

	public void Show(ulong orderId) { }

	public void Hide() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <Hide>b__1_0() { }

}

public class ItemStoreCartItem : MonoBehaviour // TypeDefIndex: 12804
{
	public int Index; 
	public TextMeshProUGUI Name; 
	public TextMeshProUGUI Price; 


	public void Init(int index, IPlayerItemDefinition def) { }

	public void RemoveFromCart() { }

	public void .ctor() { }

}

public class ItemStoreItem : MonoBehaviour // TypeDefIndex: 12805
{
	public HttpImage Icon; 
	public RustText Name; 
	public TextMeshProUGUI Price; 
	public RustText ItemName; 
	public GameObject InCartTag; 
	private IPlayerItemDefinition item; 


	internal void Init(IPlayerItemDefinition item, bool inCart) { }

	public void ShowModal() { }

	public void AddToCart() { }

	public void .ctor() { }

}

public class ItemStoreItemInfoModal : MonoBehaviour // TypeDefIndex: 12806
{
	public HttpImage Icon; 
	public TextMeshProUGUI Name; 
	public TextMeshProUGUI Price; 
	public TextMeshProUGUI Description; 
	private IPlayerItemDefinition item; 


	public void Show(IPlayerItemDefinition item) { }

	public void AddToCart() { }

	public void Hide() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <Hide>b__7_0() { }

}

public class ItemModEngineItem : ItemMod // TypeDefIndex: 13804
{
	public EngineStorage.EngineItemTypes engineItemType; 
	[RangeAttribute] 
	public int tier; 


	public void .ctor() { }

}

public class ItemModVehicleChassis : ItemMod, VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 13805
{
	public GameObjectRef entityPrefab; 
	[RangeAttribute] 
	public int socketsTaken; 

	public int SocketsTaken { get; }


	public int get_SocketsTaken() { }

	public override int GetTotalUISlots(Item item) { }

	public override int GetFilledUISlots(Item item) { }

	public void .ctor() { }

}

public class ItemModVehicleModule : ItemMod, VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 13806
{
	public GameObjectRef entityPrefab; 
	[RangeAttribute] 
	public int socketsTaken; 
	public bool doNonUserSpawn; 

	public int SocketsTaken { get; }


	public int get_SocketsTaken() { }

	public override int GetTotalUISlots(Item item) { }

	public override int GetFilledUISlots(Item item) { }

	public void .ctor() { }

}

