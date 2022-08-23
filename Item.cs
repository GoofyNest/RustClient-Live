internal enum ItemUpdateStatus // TypeDefIndex: 5163
{	public int value__; // 0x0
	public const ItemUpdateStatus Invalid = 0;
	public const ItemUpdateStatus PreparingConfig = 1;
	public const ItemUpdateStatus PreparingContent = 2;
	public const ItemUpdateStatus UploadingContent = 3;
	public const ItemUpdateStatus UploadingPreviewFile = 4;
	public const ItemUpdateStatus CommittingChanges = 5;

}

internal enum ItemState // TypeDefIndex: 5164
{	public int value__; // 0x0
	public const ItemState None = 0;
	public const ItemState Subscribed = 1;
	public const ItemState LegacyItem = 2;
	public const ItemState Installed = 4;
	public const ItemState NeedsUpdate = 8;
	public const ItemState Downloading = 16;
	public const ItemState DownloadPending = 32;

}

internal enum ItemStatistic // TypeDefIndex: 5165
{	public int value__; // 0x0
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

public enum ItemPreviewType // TypeDefIndex: 5166
{	public int value__; // 0x0
	public const ItemPreviewType Image = 0;
	public const ItemPreviewType YouTubeVideo = 1;
	public const ItemPreviewType Sketchfab = 2;
	public const ItemPreviewType EnvironmentMap_HorizontalCross = 3;
	public const ItemPreviewType EnvironmentMap_LatLong = 4;
	public const ItemPreviewType ReservedMax = 255;

}

public struct Item // TypeDefIndex: 5277
{	internal SteamUGCDetails_t details; // 0x0
	internal PublishedFileId _id; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Title>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Description>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string[] <Tags>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Dictionary<string, string> <KeyValueTags>k__BackingField; // 0xA8
	public PublishedFileId[] Children; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UgcAdditionalPreview[] <AdditionalPreviews>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumSubscriptions>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumFavorites>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumFollowers>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumUniqueSubscriptions>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumUniqueFavorites>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumUniqueFollowers>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumUniqueWebsiteViews>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <ReportScore>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumSecondsPlayed>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumPlaytimeSessions>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumComments>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumSecondsPlayedDuringTimePeriod>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <NumPlaytimeSessionsDuringTimePeriod>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <PreviewImageUrl>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Metadata>k__BackingField; // 0x130

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

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public string get_Title() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Title(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Description(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public string[] get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Tags(string[] value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public Dictionary<string, string> get_KeyValueTags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_KeyValueTags(Dictionary<string, string> value) { }

	public Friend get_Owner() { }

	public DateTime get_Updated() { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public UgcAdditionalPreview[] get_AdditionalPreviews() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_AdditionalPreviews(UgcAdditionalPreview[] value) { }

	public bool get_IsInstalled() { }

	public bool get_IsDownloading() { }

	public bool get_IsDownloadPending() { }

	public string get_Directory() { }

	public bool Download(bool highPriority = False) { }

	private ItemState get_State() { }

	internal static Item From(SteamUGCDetails_t details) { }

	[AsyncStateMachineAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	public Task<Nullable<Result>> Vote(bool up) { }

	public string get_Url() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumFavorites(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumFollowers(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumUniqueSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumUniqueFavorites(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumUniqueFollowers(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumUniqueWebsiteViews(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_ReportScore(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumSecondsPlayed(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumPlaytimeSessions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumComments(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumSecondsPlayedDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_NumPlaytimeSessionsDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public string get_PreviewImageUrl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_PreviewImageUrl(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Metadata(string value) { }

}

private struct Item.<Vote>d__83 : IAsyncStateMachine // TypeDefIndex: 5278
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<Result>> <>t__builder; // 0x8
	public Item <>4__this; // 0x20
	public bool up; // 0x158
	private CallResult<SetUserItemVoteResult_t> <>u__1; // 0x160


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

internal struct ItemInstalled_t : ICallbackData // TypeDefIndex: 5434
{	internal AppId AppID; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

public class ItemContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6439
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint UID; // 0x14
	public int slots; // 0x18
	public float temperature; // 0x1C
	public int flags; // 0x20
	public int allowedContents; // 0x24
	public int maxStackSize; // 0x28
	public List<int> allowedItems; // 0x30
	public List<int> availableSlots; // 0x38
	public List<Item> contents; // 0x40


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

public class Item : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6440
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint UID; // 0x14
	public int itemid; // 0x18
	public int slot; // 0x1C
	public int amount; // 0x20
	public int flags; // 0x24
	public float removetime; // 0x28
	public float locktime; // 0x2C
	public uint worldEntity; // 0x30
	public Item.InstanceData instanceData; // 0x38
	public uint heldEntity; // 0x40
	public Item.ConditionData conditionData; // 0x48
	public string name; // 0x50
	public string text; // 0x58
	public ulong skinid; // 0x60
	public ItemContainer contents; // 0x68


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

public class Item.InstanceData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6441
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int dataInt; // 0x14
	public int blueprintTarget; // 0x18
	public int blueprintAmount; // 0x1C
	public uint subEntity; // 0x20


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

public class Item.ConditionData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6442
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float condition; // 0x14
	public float maxCondition; // 0x18


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

public class ItemAmountList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6506
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> itemID; // 0x18
	public List<float> amount; // 0x20


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

public class ItemSchema // TypeDefIndex: 7740
{	public int appid; // 0x10
	public ItemSchema.Item[] items; // 0x18


	public void .ctor() { }

}

public class ItemSchema.Item // TypeDefIndex: 7741
{	public string name; // 0x10
	public uint itemdefid; // 0x18
	public string type; // 0x20
	public string price_category; // 0x28
	public string icon_url; // 0x30
	public string icon_url_large; // 0x38
	public bool marketable; // 0x40
	public bool tradable; // 0x41
	public bool commodity; // 0x42
	public string market_hash_name; // 0x48
	public string market_name; // 0x50
	public string bundle; // 0x58
	public string description; // 0x60
	public string workshopid; // 0x68
	public string itemshortname; // 0x70
	public string tags; // 0x78
	public string store_tags; // 0x80
	public string exchange; // 0x88
	public bool store_hidden; // 0x90
	public string background_color; // 0x98
	public string name_color; // 0xA0
	public DropChance dropChance; // 0xA8
	public Price priceCategory; // 0xAC
	public string workshopdownload; // 0xB0

	[JsonIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public double Price { get; }


	public double get_Price() { }

	public void .ctor() { }

}

public class ItemBasedFlowRestrictor : IOEntity, IContainerSounds // TypeDefIndex: 8400
{	private Option __menuOption_Menu_Open; // 0x288
	public ItemDefinition passthroughItem; // 0x2E0
	public ItemContainer.ContentsType allowedContents; // 0x2E8
	public int maxStackSize; // 0x2EC
	public int numSlots; // 0x2F0
	public string lootPanelName; // 0x2F8
	public const BaseEntity.Flags HasPassthrough = 128;
	public const BaseEntity.Flags Sparks = 256;
	public float passthroughItemConditionLossPerSec; // 0x300
	public SoundDefinition openSound; // 0x308
	public SoundDefinition closeSound; // 0x310

	public override bool HasMenuOptions { get; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Description] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Icon] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	public SoundDefinition get_OpenSound() { }

	public SoundDefinition get_CloseSound() { }

	public void .ctor() { }

}

public class ItemSearchEntry : MonoBehaviour // TypeDefIndex: 8731
{	public Button button; // 0x18
	public Text text; // 0x20
	public RawImage image; // 0x28
	public RawImage bpImage; // 0x30
	private ItemDefinition itemInfo; // 0x38
	private AddSellOrderManager manager; // 0x40


	public void Setup(ItemDefinition info, AddSellOrderManager mgr) { }

	public void Clicked() { }

	public void ClickedBP() { }

	public void .ctor() { }

}

public class ItemModCrackOpen : ItemModUnwrap // TypeDefIndex: 8785
{
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModOpenLootBag : ItemModUnwrap // TypeDefIndex: 8793
{
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModPhoto : ItemModAssociatedEntity<PhotoEntity> // TypeDefIndex: 8814
{	protected override bool AllowNullParenting { get; }


	protected override bool get_AllowNullParenting() { }

	public void .ctor() { }

}

public class ItemModUnwrap : ItemMod // TypeDefIndex: 8823
{	public LootSpawn revealList; // 0x20
	public GameObjectRef successEffect; // 0x28
	public int minTries; // 0x30
	public int maxTries; // 0x34


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModOpenWrapped : ItemMod // TypeDefIndex: 8829
{	public GameObjectRef successEffect; // 0x20
	public static Translate.Phrase open_wrapped_gift; // 0x0
	public static Translate.Phrase open_wrapped_gift_desc; // 0x8


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class ItemModWrap : ItemMod // TypeDefIndex: 8830
{	public GameObjectRef successEffect; // 0x20
	public ItemDefinition wrappedDefinition; // 0x28
	public static Translate.Phrase wrap_gift; // 0x0
	public static Translate.Phrase wrap_gift_desc; // 0x8


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class ItemModXMasTreeDecoration : ItemMod // TypeDefIndex: 8832
{	public ItemModXMasTreeDecoration.xmasFlags flagsToChange; // 0x20


	public void .ctor() { }

}

public enum ItemModXMasTreeDecoration.xmasFlags // TypeDefIndex: 8833
{	public int value__; // 0x0
	public const ItemModXMasTreeDecoration.xmasFlags pineCones = 128;
	public const ItemModXMasTreeDecoration.xmasFlags candyCanes = 256;
	public const ItemModXMasTreeDecoration.xmasFlags gingerbreadMen = 512;
	public const ItemModXMasTreeDecoration.xmasFlags Tinsel = 1024;
	public const ItemModXMasTreeDecoration.xmasFlags Balls = 2048;
	public const ItemModXMasTreeDecoration.xmasFlags Star = 16384;
	public const ItemModXMasTreeDecoration.xmasFlags Lights = 32768;

}

public class ItemModRFListener : ItemModAssociatedEntity<PagerEntity> // TypeDefIndex: 8874
{	public GameObjectRef frequencyPanelPrefab; // 0x28
	private uint pendingPagerID; // 0x30


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void ConfigureClicked(BasePlayer player) { }

	public void .ctor() { }

}

public class ItemButtonTools : MonoBehaviour // TypeDefIndex: 9281
{	public Image image; // 0x18
	public ItemDefinition itemDef; // 0x20


	public void GiveSelf(int amount) { }

	public void GiveArmed() { }

	public void GiveBlueprint() { }

	public void .ctor() { }

}

public class ItemListTools : MonoBehaviour // TypeDefIndex: 9282
{	public GameObject categoryButton; // 0x18
	public GameObject itemButton; // 0x20
	public RustInput searchInputText; // 0x28
	internal Button lastCategory; // 0x30
	private IOrderedEnumerable<ItemDefinition> currentItems; // 0x38
	private IOrderedEnumerable<ItemDefinition> allItems; // 0x40


	public void OnPanelOpened() { }

	private void OnOpenDevTools() { }

	private void CacheAllItems() { }

	public void Refresh() { }

	private void RebuildCategories() { }

	private void SwitchItemCategory(ItemDefinition[] defs) { }

	public void FilterItems(string searchText) { }

	public void .ctor() { }

}

private sealed class ItemListTools.<>c // TypeDefIndex: 9283
{	public static readonly ItemListTools.<>c <>9; // 0x0
	public static Func<ItemDefinition, string> <>9__8_0; // 0x8
	public static Func<ItemDefinition, ItemCategory> <>9__10_0; // 0x10
	public static Func<IGrouping<ItemCategory, ItemDefinition>, ItemCategory> <>9__10_1; // 0x18
	public static Func<ItemDefinition, string> <>9__11_0; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal string <CacheAllItems>b__8_0(ItemDefinition x) { }

	internal ItemCategory <RebuildCategories>b__10_0(ItemDefinition x) { }

	internal ItemCategory <RebuildCategories>b__10_1(IGrouping<ItemCategory, ItemDefinition> x) { }

	internal string <SwitchItemCategory>b__11_0(ItemDefinition x) { }

}

private sealed class ItemListTools.<>c__DisplayClass10_0 // TypeDefIndex: 9284
{	public Button btn; // 0x10
	public ItemDefinition[] itemArray; // 0x18
	public ItemListTools <>4__this; // 0x20


	public void .ctor() { }

	internal void <RebuildCategories>b__2() { }

}

public class ItemTools : MonoBehaviour // TypeDefIndex: 9311
{
public class ItemTools : MonoBehaviour // TypeDefIndex: 9311

	public void .ctor() { }

}

public class ItemModAssociatedEntityMobile : ItemModAssociatedEntity<MobileInventoryEntity> // TypeDefIndex: 9444
{	protected override bool AllowNullParenting { get; }


	protected override bool get_AllowNullParenting() { }

	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModCassette : ItemModAssociatedEntity<Cassette> // TypeDefIndex: 9445
{	public int noteSpriteIndex; // 0x28
	public PreloadedCassetteContent PreloadedContent; // 0x30

	protected override bool AllowNullParenting { get; }
	protected override bool AllowHeldEntityParenting { get; }


	protected override bool get_AllowNullParenting() { }

	protected override bool get_AllowHeldEntityParenting() { }

	public void .ctor() { }

}

public class ItemModSign : ItemModAssociatedEntity<SignContent> // TypeDefIndex: 9513
{	protected override bool AllowNullParenting { get; }


	protected override bool get_AllowNullParenting() { }

	public void .ctor() { }

}

public class ItemPickup : DroppedItem // TypeDefIndex: 9791
{	public ItemDefinition itemDef; // 0x188
	public int amount; // 0x190
	public ulong skinOverride; // 0x198


	public void .ctor() { }

}

public class ItemCraftTask // TypeDefIndex: 10102
{	public ItemBlueprint blueprint; // 0x10
	public float endTime; // 0x18
	public int taskUID; // 0x1C
	public BasePlayer owner; // 0x20
	public bool cancelled; // 0x28
	public Item.InstanceData instanceData; // 0x30
	public int amount; // 0x38
	public int skinID; // 0x3C
	public List<ulong> potentialOwners; // 0x40
	public List<Item> takenItems; // 0x48
	public int numCrafted; // 0x50
	public float conditionScale; // 0x54
	public float workSecondsComplete; // 0x58
	public float worksecondsRequired; // 0x5C


	public void .ctor() { }

}

public class ItemCrafter : EntityComponent<BasePlayer> // TypeDefIndex: 10103
{	public List<ItemContainer> containers; // 0x20
	public LinkedList<ItemCraftTask> queue; // 0x28
	public int taskUID; // 0x30


	public void AddContainer(ItemContainer container) { }

	public static float GetScaledDuration(ItemBlueprint bp, float workbenchLevel) { }

	private bool DoesHaveUsableItem(int item, int iAmount) { }

	public bool CanCraft(ItemBlueprint bp, int amount = 1, bool free = False) { }

	public bool CanCraft(ItemDefinition def, int amount = 1, bool free = False) { }

	public void .ctor() { }

}

public class ItemEventFlag : MonoBehaviour, IItemUpdate // TypeDefIndex: 10104
{	public Item.Flag flag; // 0x18
	public UnityEvent onEnabled; // 0x20
	public UnityEvent onDisable; // 0x28
	internal bool firstRun; // 0x30
	internal bool lastState; // 0x31


	public virtual void OnItemUpdate(Item item) { }

	public void .ctor() { }

}

public class Item // TypeDefIndex: 10105
{	public Nullable<int> amountOverride; // 0x10
	private static readonly Memoized<string, ValueTuple<ItemDefinition.AmountType, int>> FormatAmountMemoized; // 0x0
	private static string DefaultArmourBreakEffectPath; // 0x8
	private float _condition; // 0x18
	private float _maxCondition; // 0x1C
	public ItemDefinition info; // 0x20
	public uint uid; // 0x28
	public bool dirty; // 0x2C
	public int amount; // 0x30
	public int position; // 0x34
	public float busyTime; // 0x38
	public float removeTime; // 0x3C
	public float fuel; // 0x40
	public bool isServer; // 0x44
	public Item.InstanceData instanceData; // 0x48
	public ulong skin; // 0x50
	public string name; // 0x58
	public string text; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action<Item> OnDirty; // 0x68
	public Item.Flag flags; // 0x70
	public ItemContainer contents; // 0x78
	public ItemContainer parent; // 0x80
	private EntityRef worldEnt; // 0x88
	private EntityRef heldEntity; // 0x98

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_OnDirty(Action<Item> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <get_iconSprite>b__95_0(ItemSkinDirectory.Skin x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <get_isLoadingIconSprite>b__97_0(ItemSkinDirectory.Skin x) { }

}

public enum Item.Flag // TypeDefIndex: 10106
{	public int value__; // 0x0
	public const Item.Flag None = 0;
	public const Item.Flag Placeholder = 1;
	public const Item.Flag IsOn = 2;
	public const Item.Flag OnFire = 4;
	public const Item.Flag IsLocked = 8;
	public const Item.Flag Cooking = 16;

}

private sealed class Item.<>c // TypeDefIndex: 10107
{	public static readonly Item.<>c <>9; // 0x21F5


	private static void .cctor() { }

	public void .ctor() { }

	internal string <.cctor>b__103_0(ValueTuple<ItemDefinition.AmountType, int> t) { }

}

public sealed class ItemContainer // TypeDefIndex: 10110
{	public ItemContainer.Flag flags; // 0x10
	public ItemContainer.ContentsType allowedContents; // 0x14
	public ItemDefinition[] onlyAllowedItems; // 0x18
	public List<ItemSlot> availableSlots; // 0x20
	public int capacity; // 0x28
	public uint uid; // 0x2C
	public bool dirty; // 0x30
	public List<Item> itemList; // 0x38
	public float temperature; // 0x40
	public Item parent; // 0x48
	public BasePlayer playerOwner; // 0x50
	public BaseEntity entityOwner; // 0x58
	public bool isServer; // 0x60
	public int maxStackSize; // 0x64

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

public enum ItemContainer.Flag // TypeDefIndex: 10111
{	public int value__; // 0x0
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

public enum ItemContainer.ContentsType // TypeDefIndex: 10112
{	public int value__; // 0x0
	public const ItemContainer.ContentsType Generic = 1;
	public const ItemContainer.ContentsType Liquid = 2;

}

public enum ItemContainer.CanAcceptResult // TypeDefIndex: 10113
{	public int value__; // 0x0
	public const ItemContainer.CanAcceptResult CanAccept = 0;
	public const ItemContainer.CanAcceptResult CannotAccept = 1;
	public const ItemContainer.CanAcceptResult CannotAcceptRightNow = 2;

}

private sealed class ItemContainer.<>c__DisplayClass41_0 // TypeDefIndex: 10114
{	public int itemid; // 0x10


	public void .ctor() { }

	internal bool <FindItemsByItemID>b__0(Item x) { }

}

public class ItemBlueprint : MonoBehaviour // TypeDefIndex: 10115
{	public List<ItemAmount> ingredients; // 0x18
	public List<ItemDefinition> additionalUnlocks; // 0x20
	public bool defaultBlueprint; // 0x28
	public bool userCraftable; // 0x29
	public bool isResearchable; // 0x2A
	public Rarity rarity; // 0x2C
	[HeaderAttribute] // RVA: 0xB6180 Offset: 0xB5580 VA: 0x1800B6180
	public int workbenchLevelRequired; // 0x30
	[HeaderAttribute] // RVA: 0xB6350 Offset: 0xB5750 VA: 0x1800B6350
	public int scrapRequired; // 0x34
	public int scrapFromRecycle; // 0x38
	[HeaderAttribute] // RVA: 0xB64E0 Offset: 0xB58E0 VA: 0x1800B64E0
	[TooltipAttribute] // RVA: 0xB64E0 Offset: 0xB58E0 VA: 0x1800B64E0
	public bool NeedsSteamItem; // 0x3C
	public int blueprintStackSize; // 0x40
	public float time; // 0x44
	public int amountToCreate; // 0x48
	public string UnlockAchievment; // 0x50
	public string RecycleStat; // 0x58

	public ItemDefinition targetItem { get; }
	public bool NeedsSteamDLC { get; }


	public ItemDefinition get_targetItem() { }

	public bool get_NeedsSteamDLC() { }

	public string GetIngredientString(bool colorMissing) { }

	public void .ctor() { }

}

public class ItemDefinition : MonoBehaviour // TypeDefIndex: 10116
{	[HeaderAttribute] // RVA: 0xB6670 Offset: 0xB5A70 VA: 0x1800B6670
	[ReadOnlyAttribute] // RVA: 0xB6670 Offset: 0xB5A70 VA: 0x1800B6670
	public int itemid; // 0x18
	[TooltipAttribute] // RVA: 0xB6740 Offset: 0xB5B40 VA: 0x1800B6740
	public string shortname; // 0x20
	[HeaderAttribute] // RVA: 0xB68F0 Offset: 0xB5CF0 VA: 0x1800B68F0
	public Translate.Phrase displayName; // 0x28
	public Translate.Phrase displayDescription; // 0x30
	public Sprite iconSprite; // 0x38
	public ItemCategory category; // 0x40
	public ItemSelectionPanel selectionPanel; // 0x44
	[HeaderAttribute] // RVA: 0xB6A10 Offset: 0xB5E10 VA: 0x1800B6A10
	public int maxDraggable; // 0x48
	public ItemContainer.ContentsType itemType; // 0x4C
	public ItemDefinition.AmountType amountType; // 0x50
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public ItemSlot occupySlots; // 0x54
	public int stackable; // 0x58
	public bool quickDespawn; // 0x5C
	[HeaderAttribute] // RVA: 0xB6C30 Offset: 0xB6030 VA: 0x1800B6C30
	[TooltipAttribute] // RVA: 0xB6C30 Offset: 0xB6030 VA: 0x1800B6C30
	public Rarity rarity; // 0x60
	public bool spawnAsBlueprint; // 0x64
	[HeaderAttribute] // RVA: 0xA9E90 Offset: 0xA9290 VA: 0x1800A9E90
	public SoundDefinition inventorySelectSound; // 0x68
	public SoundDefinition inventoryGrabSound; // 0x70
	public SoundDefinition inventoryDropSound; // 0x78
	public SoundDefinition physImpactSoundDef; // 0x80
	public ItemDefinition.Condition condition; // 0x88
	[HeaderAttribute] // RVA: 0x71D40 Offset: 0x71140 VA: 0x180071D40
	public bool hidden; // 0xA0
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public ItemDefinition.Flag flags; // 0xA4
	[TooltipAttribute] // RVA: 0x7B540 Offset: 0x7A940 VA: 0x18007B540
	public SteamInventoryItem steamItem; // 0xA8
	[TooltipAttribute] // RVA: 0x7B650 Offset: 0x7AA50 VA: 0x18007B650
	public SteamDLCItem steamDlc; // 0xB0
	[TooltipAttribute] // RVA: 0xB71B0 Offset: 0xB65B0 VA: 0x1800B71B0
	public ItemDefinition Parent; // 0xB8
	public GameObjectRef worldModelPrefab; // 0xC0
	public ItemDefinition isRedirectOf; // 0xC8
	public ItemDefinition.RedirectVendingBehaviour redirectVendingBehaviour; // 0xD0
	public ItemMod[] itemMods; // 0xD8
	public BaseEntity.TraitFlag Traits; // 0xE0
	public ItemSkinDirectory.Skin[] skins; // 0xE8
	private IPlayerItemDefinition[] _skins2; // 0xF0
	[TooltipAttribute] // RVA: 0xB8600 Offset: 0xB7A00 VA: 0x1800B8600
	public GameObject panel; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ItemModWearable <ItemModWearable>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <isHoldable>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <isUsable>k__BackingField; // 0x109
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <CraftableWithSkin>k__BackingField; // 0x10A
	public ItemDefinition[] Children; // 0x110

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ItemModWearable get_ItemModWearable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_ItemModWearable(ItemModWearable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_isHoldable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_isHoldable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_isUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_isUsable(bool value) { }

	public bool get_HasSkins() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_CraftableWithSkin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_CraftableWithSkin(bool value) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Initialize>b__45_0(ItemDefinition x) { }

}

public struct ItemDefinition.Condition // TypeDefIndex: 10117
{	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0xB8E30 Offset: 0xB8230 VA: 0x1800B8E30
	public float max; // 0x4
	[TooltipAttribute] // RVA: 0xB8F40 Offset: 0xB8340 VA: 0x1800B8F40
	public bool repairable; // 0x8
	[TooltipAttribute] // RVA: 0xB8FF0 Offset: 0xB83F0 VA: 0x1800B8FF0
	public bool maintainMaxCondition; // 0x9
	public ItemDefinition.Condition.WorldSpawnCondition foundCondition; // 0x10

}

public class ItemDefinition.Condition.WorldSpawnCondition // TypeDefIndex: 10118
{	public float fractionMin; // 0x10
	public float fractionMax; // 0x14


	public void .ctor() { }

}

public enum ItemDefinition.RedirectVendingBehaviour // TypeDefIndex: 10119
{	public int value__; // 0x0
	public const ItemDefinition.RedirectVendingBehaviour NoListing = 0;
	public const ItemDefinition.RedirectVendingBehaviour ListAsUniqueItem = 1;

}

public enum ItemDefinition.Flag // TypeDefIndex: 10120
{	public int value__; // 0x0
	public const ItemDefinition.Flag NoDropping = 1;
	public const ItemDefinition.Flag NotStraightToBelt = 2;

}

public enum ItemDefinition.AmountType // TypeDefIndex: 10121
{	public int value__; // 0x0
	public const ItemDefinition.AmountType Count = 0;
	public const ItemDefinition.AmountType Millilitre = 1;
	public const ItemDefinition.AmountType Feet = 2;
	public const ItemDefinition.AmountType Genetics = 3;
	public const ItemDefinition.AmountType OxygenSeconds = 4;
	public const ItemDefinition.AmountType Frequency = 5;
	public const ItemDefinition.AmountType Generic = 6;

}

private sealed class ItemDefinition.<>c__DisplayClass35_0 // TypeDefIndex: 10122
{	public string prefabname; // 0x10
	public ItemDefinition <>4__this; // 0x18


	public void .ctor() { }

	internal bool <get_skins2>b__0(IPlayerItemDefinition x) { }

}

public enum ItemCategory // TypeDefIndex: 10123
{	public int value__; // 0x0
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

public enum ItemSlot // TypeDefIndex: 10124
{	public int value__; // 0x0
	public const ItemSlot None = 1;
	public const ItemSlot Barrel = 2;
	public const ItemSlot Silencer = 4;
	public const ItemSlot Scope = 8;
	public const ItemSlot UnderBarrel = 16;
	public const ItemSlot Magazine = 32;

}

public enum ItemSelectionPanel // TypeDefIndex: 10125
{	public int value__; // 0x0
	public const ItemSelectionPanel None = 0;
	public const ItemSelectionPanel Vessel = 1;
	public const ItemSelectionPanel Modifications = 2;
	public const ItemSelectionPanel GunInformation = 3;

}

public class ItemSelector : PropertyAttribute // TypeDefIndex: 10126
{	public ItemCategory category; // 0x10


	public void .ctor(ItemCategory category = 11) { }

}

public class ItemMod : MonoBehaviour // TypeDefIndex: 10127
{	protected ItemMod[] siblingMods; // 0x18


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

public class ItemModActionChange : ItemMod // TypeDefIndex: 10128
{	public ItemMod[] actions; // 0x20


	private void OnValidate() { }

	public void .ctor() { }

}

public class ItemModActionContainerChange : ItemMod // TypeDefIndex: 10129
{	public ItemMod[] actions; // 0x20


	private void OnValidate() { }

	public void .ctor() { }

}

public class ItemModAlterCondition : ItemMod // TypeDefIndex: 10130
{	public float conditionChange; // 0x20


	public void .ctor() { }

}

public class ItemModAnimalEquipment : ItemMod // TypeDefIndex: 10131
{	public BaseEntity.Flags WearableFlag; // 0x20
	public bool hideHair; // 0x24
	public ProtectionProperties animalProtection; // 0x28
	public ProtectionProperties riderProtection; // 0x30
	public int additionalInventorySlots; // 0x38
	public float speedModifier; // 0x3C
	public float staminaUseModifier; // 0x40
	public ItemModAnimalEquipment.SlotType slot; // 0x44


	public void .ctor() { }

}

public enum ItemModAnimalEquipment.SlotType // TypeDefIndex: 10132
{	public int value__; // 0x0
	public const ItemModAnimalEquipment.SlotType Basic = 0;
	public const ItemModAnimalEquipment.SlotType Armor = 1;
	public const ItemModAnimalEquipment.SlotType Saddle = 2;
	public const ItemModAnimalEquipment.SlotType Bit = 3;
	public const ItemModAnimalEquipment.SlotType Feet = 4;

}

public abstract class ItemModAssociatedEntity<T> : ItemMod // TypeDefIndex: 10133
{	public GameObjectRef entityPrefab; // 0x0

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

public class ItemModBaitContainer : ItemModContainer // TypeDefIndex: 10134
{
	public void .ctor() { }

}

public class ItemModBlueprintCraft : ItemMod // TypeDefIndex: 10135
{	public GameObjectRef successEffect; // 0x20


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModBurnable : ItemMod // TypeDefIndex: 10136
{	public float fuelAmount; // 0x20
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition byproductItem; // 0x28
	public int byproductAmount; // 0x30
	public float byproductChance; // 0x34


	public void .ctor() { }

}

public class ItemModCassetteContainer : ItemModContainer // TypeDefIndex: 10137
{	public ItemDefinition[] CassetteItems; // 0x58


	public void .ctor() { }

}

public class ItemModChildIO : ItemMod // TypeDefIndex: 10138
{	public GameObjectRef TargetChildIO; // 0x20


	public void .ctor() { }

}

public class ItemModCompostable : MonoBehaviour // TypeDefIndex: 10139
{	public float TotalFertilizerProduced; // 0x18
	public float BaitValue; // 0x1C


	public void .ctor() { }

}

public class ItemModConditionContainerFlag : ItemMod // TypeDefIndex: 10140
{	public ItemContainer.Flag flag; // 0x20
	public bool requiredState; // 0x24


	public override bool Passes(Item item) { }

	public void .ctor() { }

}

public class ItemModConditionHasCondition : ItemMod // TypeDefIndex: 10141
{	public float conditionTarget; // 0x20
	[TooltipAttribute] // RVA: 0xB9190 Offset: 0xB8590 VA: 0x1800B9190
	public float conditionFractionTarget; // 0x24
	public bool lessThan; // 0x28


	public override bool Passes(Item item) { }

	public void .ctor() { }

}

public class ItemModConditionHasContents : ItemMod // TypeDefIndex: 10142
{	[TooltipAttribute] // RVA: 0xB9520 Offset: 0xB8920 VA: 0x1800B9520
	public ItemDefinition itemDef; // 0x20
	public bool requiredState; // 0x28


	public override bool Passes(Item item) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Passes>b__2_0(Item x) { }

}

public class ItemModConditionHasFlag : ItemMod // TypeDefIndex: 10143
{	public Item.Flag flag; // 0x20
	public bool requiredState; // 0x24


	public override bool Passes(Item item) { }

	public void .ctor() { }

}

public class ItemModConditionInWater : ItemMod // TypeDefIndex: 10144
{	public bool requiredState; // 0x20


	public override bool Passes(Item item) { }

	public void .ctor() { }

}

public class ItemModConditionIsSleeping : ItemMod // TypeDefIndex: 10145
{	public bool requiredState; // 0x20


	public override bool Passes(Item item) { }

	public void .ctor() { }

}

public class ItemModConsumable : MonoBehaviour // TypeDefIndex: 10146
{	public int amountToConsume; // 0x18
	public float conditionFractionToLose; // 0x1C
	public string achievementWhenEaten; // 0x20
	public List<ItemModConsumable.ConsumableEffect> effects; // 0x28
	public List<ModifierDefintion> modifiers; // 0x30


	public float GetIfType(MetabolismAttribute.Type typeToPick) { }

	public void .ctor() { }

}

public class ItemModConsumable.ConsumableEffect // TypeDefIndex: 10147
{	public MetabolismAttribute.Type type; // 0x10
	public float amount; // 0x14
	public float time; // 0x18
	public float onlyIfHealthLessThan; // 0x1C


	public void .ctor() { }

}

public class ItemModConsume : ItemMod // TypeDefIndex: 10148
{	public GameObjectRef consumeEffect; // 0x20
	public string eatGesture; // 0x28
	[TooltipAttribute] // RVA: 0xB9870 Offset: 0xB8C70 VA: 0x1800B9870
	public ItemAmountRandom[] product; // 0x30
	public ItemModConsumable primaryConsumable; // 0x38


	public override void CL_DoAction(Item item, BasePlayer player) { }

	public override bool CanDoAction(Item item, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModConsumeChance : ItemModConsume // TypeDefIndex: 10149
{	public float chanceForSecondaryConsume; // 0x40
	public GameObjectRef secondaryConsumeEffect; // 0x48
	public ItemModConsumable secondaryConsumable; // 0x50


	public void .ctor() { }

}

public class ItemModConsumeContents : ItemMod // TypeDefIndex: 10150
{	public GameObjectRef consumeEffect; // 0x20


	public override void CL_DoAction(Item item, BasePlayer player) { }

	public override bool CanDoAction(Item item, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModContainer : ItemMod // TypeDefIndex: 10151
{	public int capacity; // 0x20
	public int maxStackSize; // 0x24
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public ItemContainer.Flag containerFlags; // 0x28
	public ItemContainer.ContentsType onlyAllowedContents; // 0x2C
	public ItemDefinition onlyAllowedItemType; // 0x30
	public List<ItemSlot> availableSlots; // 0x38
	public ItemDefinition[] validItemWhitelist; // 0x40
	public bool openInDeployed; // 0x48
	public bool openInInventory; // 0x49
	public List<ItemAmount> defaultContents; // 0x50


	public override int GetTotalUISlots(Item item) { }

	public override int GetFilledUISlots(Item item) { }

	public void .ctor() { }

}

public class ItemModContainerRestriction : ItemMod // TypeDefIndex: 10152
{	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public ItemModContainerRestriction.SlotFlags slotFlags; // 0x20


	public bool CanExistWith(ItemModContainerRestriction other) { }

	public void .ctor() { }

}

public enum ItemModContainerRestriction.SlotFlags // TypeDefIndex: 10153
{	public int value__; // 0x0
	public const ItemModContainerRestriction.SlotFlags Map = 1;

}

public class ItemModCookable : ItemMod // TypeDefIndex: 10154
{	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition becomeOnCooked; // 0x20
	public float cookTime; // 0x28
	public int amountOfBecome; // 0x2C
	public int lowTemp; // 0x30
	public int highTemp; // 0x34
	public bool setCookingFlag; // 0x38


	public void OnValidate() { }

	public void .ctor() { }

}

public class ItemModCycle : ItemMod // TypeDefIndex: 10155
{	public ItemMod[] actions; // 0x20
	public float timeBetweenCycles; // 0x28
	public float timerStart; // 0x2C
	public bool onlyAdvanceTimerWhenPass; // 0x30


	private void OnValidate() { }

	public void .ctor() { }

}

public class ItemModDeployable : MonoBehaviour // TypeDefIndex: 10156
{	public GameObjectRef entityPrefab; // 0x18
	[HeaderAttribute] // RVA: 0xB9BF0 Offset: 0xB8FF0 VA: 0x1800B9BF0
	public bool showCrosshair; // 0x20
	public string UnlockAchievement; // 0x28


	public Deployable GetDeployable(BaseEntity entity) { }

	public void .ctor() { }

}

public class ItemModEntity : ItemMod // TypeDefIndex: 10157
{	public GameObjectRef entityPrefab; // 0x20
	public string defaultBone; // 0x28


	public void .ctor() { }

}

public class ItemModEntityReference : MonoBehaviour // TypeDefIndex: 10158
{	public GameObjectRef entityPrefab; // 0x18


	public void .ctor() { }

}

public class ItemModFishable : ItemMod // TypeDefIndex: 10159
{	public bool CanBeFished; // 0x20
	[HeaderAttribute] // RVA: 0xB9C60 Offset: 0xB9060 VA: 0x1800B9C60
	public float StrainModifier; // 0x24
	public float MoveMultiplier; // 0x28
	public float ReelInSpeedMultiplier; // 0x2C
	public float CatchWaitTimeMultiplier; // 0x30
	[HeaderAttribute] // RVA: 0xB9D60 Offset: 0xB9160 VA: 0x1800B9D60
	public float MinimumBaitLevel; // 0x34
	public float MaximumBaitLevel; // 0x38
	public float MinimumWaterDepth; // 0x3C
	public float MaximumWaterDepth; // 0x40
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public WaterBody.FishingTag RequiredTag; // 0x44
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float Chance; // 0x48
	public string SteamStatName; // 0x50


	public void .ctor() { }

}

public class ItemModGiveOxygen : ItemMod, IAirSupply // TypeDefIndex: 10161
{	public ItemModGiveOxygen.AirSupplyType airType; // 0x20
	public int amountToConsume; // 0x24
	public GameObjectRef inhaleEffect; // 0x28
	public GameObjectRef exhaleEffect; // 0x30
	public GameObjectRef bubblesEffect; // 0x38
	private float timeRemaining; // 0x40
	private float cycleTime; // 0x44

	public ItemModGiveOxygen.AirSupplyType AirType { get; }


	public ItemModGiveOxygen.AirSupplyType get_AirType() { }

	public float GetAirTimeRemaining() { }

	public override void ModInit() { }

	public override void OnChanged(Item item) { }

	public void .ctor() { }

}

public enum ItemModGiveOxygen.AirSupplyType // TypeDefIndex: 10162
{	public int value__; // 0x0
	public const ItemModGiveOxygen.AirSupplyType Lungs = 0;
	public const ItemModGiveOxygen.AirSupplyType ScubaTank = 1;
	public const ItemModGiveOxygen.AirSupplyType Submarine = 2;

}

public class ItemModKeycard : ItemMod // TypeDefIndex: 10163
{	public int accessLevel; // 0x20


	public void .ctor() { }

}

public class ItemModMenuOption : ItemMod // TypeDefIndex: 10164
{	public string commandName; // 0x20
	public ItemMod actionTarget; // 0x28
	public BaseEntity.Menu.Option option; // 0x30
	[TooltipAttribute] // RVA: 0xBB2E0 Offset: 0xBA6E0 VA: 0x1800BB2E0
	public bool isPrimaryOption; // 0x50


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public override bool BeltSelect(Item item, BasePlayer player) { }

	private void OnValidate() { }

	public void .ctor() { }

}

public class ItemModPaintable : ItemModAssociatedEntity<PaintedItemStorageEntity> // TypeDefIndex: 10165
{	public GameObjectRef ChangeSignTextDialog; // 0x28
	public MeshPaintableSource[] PaintableSources; // 0x30
	private EntityRef<PaintedItemStorageEntity> _paintStorage; // 0x38

	protected override bool AllowNullParenting { get; }


	protected override bool get_AllowNullParenting() { }

	public override void OnObjectSetup(Item item, GameObject obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB570 Offset: 0xBA970 VA: 0x1800BB570
	private IEnumerator DeferredSetup(Item item, PaintableItem paintable) { }

	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	private void PaintClicked(BasePlayer player) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB6D0 Offset: 0xBAAD0 VA: 0x1800BB6D0
	private IEnumerator OpenPaintUI(EntityRef<PaintedItemStorageEntity> paintStorage) { }

	public void .ctor() { }

}

private sealed class ItemModPaintable.<DeferredSetup>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10166
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Item item; // 0x20
	public PaintableItem paintable; // 0x28
	public ItemModPaintable <>4__this; // 0x30
	private int <count>5__2; // 0x38

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemModPaintable.<>c__DisplayClass9_0 // TypeDefIndex: 10167
{	public PaintedItemStorageEntity entity; // 0x10


	public void .ctor() { }

	internal void <OpenPaintUI>b__0(int frame, Texture2D texture) { }

}

private sealed class ItemModPaintable.<OpenPaintUI>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10168
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EntityRef<PaintedItemStorageEntity> paintStorage; // 0x20
	public ItemModPaintable <>4__this; // 0x30
	private int <i>5__2; // 0x38

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

public class ItemModPetStats : ItemMod // TypeDefIndex: 10169
{	[TooltipAttribute] // RVA: 0xBC080 Offset: 0xBB480 VA: 0x1800BC080
	public float SpeedModifier; // 0x20
	[TooltipAttribute] // RVA: 0xBC120 Offset: 0xBB520 VA: 0x1800BC120
	public float MaxHealthModifier; // 0x24
	[TooltipAttribute] // RVA: 0xBC340 Offset: 0xBB740 VA: 0x1800BC340
	public float AttackDamageModifier; // 0x28
	[TooltipAttribute] // RVA: 0xBC450 Offset: 0xBB850 VA: 0x1800BC450
	public float AttackRateModifier; // 0x2C


	public void .ctor() { }

}

public class ItemModProjectile : MonoBehaviour // TypeDefIndex: 10170
{	public GameObjectRef projectileObject; // 0x18
	public ItemModProjectileMod[] mods; // 0x20
	public AmmoTypes ammoType; // 0x28
	public int numProjectiles; // 0x2C
	public float projectileSpread; // 0x30
	public float projectileVelocity; // 0x34
	public float projectileVelocitySpread; // 0x38
	public bool useCurve; // 0x3C
	public AnimationCurve spreadScalar; // 0x40
	public GameObjectRef attackEffectOverride; // 0x48
	public float barrelConditionLoss; // 0x50
	public string category; // 0x58


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

public class ItemModProjectileMod : MonoBehaviour // TypeDefIndex: 10171
{
	public virtual void ServerProjectileHit(HitInfo info) { }

	public void .ctor() { }

}

public class ItemModProjectileRadialDamage : ItemModProjectileMod // TypeDefIndex: 10172
{	public float radius; // 0x18
	public DamageTypeEntry damage; // 0x20
	public GameObjectRef effect; // 0x28
	public bool ignoreHitObject; // 0x30


	public void .ctor() { }

}

public class ItemModProjectileSpawn : ItemModProjectile // TypeDefIndex: 10173
{	public float createOnImpactChance; // 0x60
	public GameObjectRef createOnImpact; // 0x68
	public float spreadAngle; // 0x70
	public float spreadVelocityMin; // 0x74
	public float spreadVelocityMax; // 0x78
	public int numToCreateChances; // 0x7C


	public void .ctor() { }

}

public class ItemModRecycleInto : ItemMod // TypeDefIndex: 10174
{	public ItemDefinition recycleIntoItem; // 0x20
	public int numRecycledItemMin; // 0x28
	public int numRecycledItemMax; // 0x2C
	public GameObjectRef successEffect; // 0x30


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModRepair : ItemMod // TypeDefIndex: 10175
{	public float conditionLost; // 0x20
	public GameObjectRef successEffect; // 0x28
	public int workbenchLvlRequired; // 0x30


	public bool HasCraftLevel(BasePlayer player) { }

	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModReveal : ItemMod // TypeDefIndex: 10176
{	public int numForReveal; // 0x20
	public ItemDefinition revealedItemOverride; // 0x28
	public int revealedItemAmount; // 0x30
	public LootSpawn revealList; // 0x38
	public GameObjectRef successEffect; // 0x40


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModSound : ItemMod // TypeDefIndex: 10177
{	public GameObjectRef effect; // 0x20
	public ItemModSound.Type actionType; // 0x28


	public void .ctor() { }

}

public enum ItemModSound.Type // TypeDefIndex: 10178
{	public int value__; // 0x0
	public const ItemModSound.Type OnAttachToWeapon = 0;

}

public class ItemModStudyBlueprint : ItemMod // TypeDefIndex: 10179
{	public GameObjectRef studyEffect; // 0x20


	public void .ctor() { }

}

public class ItemModSummerSunglassesEquip : ItemMod // TypeDefIndex: 10180
{	public float SunsetTime; // 0x20
	public float SunriseTime; // 0x24
	public string AchivementName; // 0x28


	public void .ctor() { }

}

public class ItemModSwap : ItemMod // TypeDefIndex: 10181
{	public GameObjectRef actionEffect; // 0x20
	public ItemAmount[] becomeItem; // 0x28
	public bool sendPlayerPickupNotification; // 0x30
	public bool sendPlayerDropNotification; // 0x31
	public float xpScale; // 0x34
	public ItemAmount[] RandomOptions; // 0x38


	public void .ctor() { }

}

public class ItemModSwitchFlag : ItemMod // TypeDefIndex: 10182
{	public Item.Flag flag; // 0x20
	public bool state; // 0x24


	public void .ctor() { }

}

public class ItemModUpgrade : ItemMod // TypeDefIndex: 10183
{	public int numForUpgrade; // 0x20
	public float upgradeSuccessChance; // 0x24
	public int numToLoseOnFail; // 0x28
	public ItemDefinition upgradedItem; // 0x30
	public int numUpgradedItem; // 0x38
	public GameObjectRef successEffect; // 0x40
	public GameObjectRef failEffect; // 0x48


	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	public void .ctor() { }

}

public class ItemModUseContent : ItemMod // TypeDefIndex: 10184
{	public int amountToConsume; // 0x20


	public void .ctor() { }

}

public class ItemModWearable : ItemMod // TypeDefIndex: 10185
{	public GameObjectRef entityPrefab; // 0x20
	public GameObjectRef entityPrefabFemale; // 0x28
	public ProtectionProperties protectionProperties; // 0x30
	public ArmorProperties armorProperties; // 0x38
	public ClothingMovementProperties movementProperties; // 0x40
	public UIBlackoutOverlay.blackoutType occlusionType; // 0x48
	public bool blocksAiming; // 0x4C
	public bool emissive; // 0x4D
	public float accuracyBonus; // 0x50
	public bool blocksEquipping; // 0x54
	public float eggVision; // 0x58
	public float weight; // 0x5C
	public bool equipOnRightClick; // 0x60
	public bool npcOnly; // 0x61
	public GameObjectRef breakEffect; // 0x68
	public GameObjectRef viewmodelAddition; // 0x70

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

private sealed class ItemModWearable.<>c__DisplayClass28_0 // TypeDefIndex: 10186
{	public Item item; // 0x10


	public void .ctor() { }

	internal bool <OnObjectSetup>b__0(ItemSkinDirectory.Skin x) { }

}

public class ItemModXPWhenUsed : ItemMod // TypeDefIndex: 10187
{	public float xpPerUnit; // 0x20
	public int unitSize; // 0x24


	public void GiveConsumeXP(Item item) { }

	public void .ctor() { }

}

public class ItemFootstepSounds : MonoBehaviour // TypeDefIndex: 10188
{	public string effectFolder; // 0x18


	public void .ctor() { }

}

public class ItemAmount : ISerializationCallbackReceiver // TypeDefIndex: 10189
{	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition itemDef; // 0x10
	public float amount; // 0x18
	public float startAmount; // 0x1C

	public int itemid { get; }


	public void .ctor(ItemDefinition item, float amt = 0) { }

	public int get_itemid() { }

	public virtual float GetAmount() { }

	public virtual void OnAfterDeserialize() { }

	public virtual void OnBeforeSerialize() { }

	public static ItemAmountList SerialiseList(List<ItemAmount> list) { }

	public static void DeserialiseList(List<ItemAmount> target, ItemAmountList source) { }

}

public class ItemAmountRandom // TypeDefIndex: 10190
{	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition itemDef; // 0x10
	public AnimationCurve amount; // 0x18


	public int RandomAmount() { }

	public void .ctor() { }

}

public class ItemAmountRanged : ItemAmount // TypeDefIndex: 10191
{	public float maxAmount; // 0x20


	public override void OnAfterDeserialize() { }

	public void .ctor(ItemDefinition item, float amt = 0, float max = -1) { }

	public override float GetAmount() { }

}

public class ItemManager // TypeDefIndex: 10192
{	public static List<ItemDefinition> itemList; // 0x0
	public static Dictionary<int, ItemDefinition> itemDictionary; // 0x8
	public static Dictionary<string, ItemDefinition> itemDictionaryByName; // 0x10
	public static List<ItemBlueprint> bpList; // 0x18
	public static int[] defaultBlueprints; // 0x20
	public static ItemDefinition blueprintBaseDef; // 0x28


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

private sealed class ItemManager.<>c // TypeDefIndex: 10193
{	public static readonly ItemManager.<>c <>9; // 0x0
	public static Func<GameObject, ItemDefinition> <>9__7_0; // 0x8
	public static Func<ItemDefinition, bool> <>9__7_1; // 0x10
	public static Func<GameObject, ItemBlueprint> <>9__7_2; // 0x18
	public static Func<ItemBlueprint, bool> <>9__7_3; // 0x20
	public static Func<ItemBlueprint, bool> <>9__7_4; // 0x28
	public static Func<ItemBlueprint, int> <>9__7_5; // 0x30


	private static void .cctor() { }

	public void .ctor() { }

	internal ItemDefinition <Initialize>b__7_0(GameObject x) { }

	internal bool <Initialize>b__7_1(ItemDefinition x) { }

	internal ItemBlueprint <Initialize>b__7_2(GameObject x) { }

	internal bool <Initialize>b__7_3(ItemBlueprint x) { }

	internal bool <Initialize>b__7_4(ItemBlueprint x) { }

	internal int <Initialize>b__7_5(ItemBlueprint x) { }

}

public class ItemSkin : SteamInventoryItem // TypeDefIndex: 10737
{	public Skinnable Skinnable; // 0x70
	public Material[] Materials; // 0x78
	[TooltipAttribute] // RVA: 0x77010 Offset: 0x76410 VA: 0x180077010
	public ItemDefinition Redirect; // 0x80
	public SteamInventoryItem UnlockedViaSteamItem; // 0x88


	public void ApplySkin(GameObject obj) { }

	public override bool HasUnlocked(ulong playerId) { }

	public void .ctor() { }

}

public class ItemSkinDirectory : ScriptableObject // TypeDefIndex: 10738
{	private static ItemSkinDirectory _Instance; // 0x0
	public ItemSkinDirectory.Skin[] skins; // 0x18

	public static ItemSkinDirectory Instance { get; }


	public static ItemSkinDirectory get_Instance() { }

	public static ItemSkinDirectory.Skin[] ForItem(ItemDefinition item) { }

	public static ItemSkinDirectory.Skin FindByInventoryDefinitionId(int id) { }

	public void .ctor() { }

}

public struct ItemSkinDirectory.Skin // TypeDefIndex: 10739
{	public int id; // 0x0
	public int itemid; // 0x4
	public string name; // 0x8
	public bool isSkin; // 0x10
	private SteamInventoryItem _invItem; // 0x18

	public SteamInventoryItem invItem { get; }


	public SteamInventoryItem get_invItem() { }

}

private sealed class ItemSkinDirectory.<>c__DisplayClass5_0 // TypeDefIndex: 10740
{	public ItemDefinition item; // 0x10


	public void .ctor() { }

	internal bool <ForItem>b__0(ItemSkinDirectory.Skin x) { }

}

private sealed class ItemSkinDirectory.<>c__DisplayClass6_0 // TypeDefIndex: 10741
{	public int id; // 0x10


	public void .ctor() { }

	internal bool <FindByInventoryDefinitionId>b__0(ItemSkinDirectory.Skin x) { }

}

public abstract class ItemContainerSource : MonoBehaviour // TypeDefIndex: 10851
{
	public abstract ItemContainer GetItemContainer();

	protected void .ctor() { }

}

public class ItemDropCommand : MonoBehaviour // TypeDefIndex: 11007
{	public string command; // 0x18


	private void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	public void .ctor() { }

}

public class ItemIcon : BaseMonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IDraggable, IInventoryChanged, IItemAmountChanged, IItemIconChanged // TypeDefIndex: 11008
{	public static Color defaultBackgroundColor; // 0x0
	public static Color selectedBackgroundColor; // 0x10
	public ItemContainerSource containerSource; // 0x18
	public int slotOffset; // 0x20
	[RangeAttribute] // RVA: 0x8E7C0 Offset: 0x8DBC0 VA: 0x18008E7C0
	public int slot; // 0x24
	public bool setSlotFromSiblingIndex; // 0x28
	public GameObject slots; // 0x30
	public CanvasGroup iconContents; // 0x38
	public Image iconImage; // 0x40
	public Image underlayImage; // 0x48
	public Text amountText; // 0x50
	public Text hoverText; // 0x58
	public Image hoverOutline; // 0x60
	public Image cornerIcon; // 0x68
	public Image lockedImage; // 0x70
	public Image progressImage; // 0x78
	public Image backgroundImage; // 0x80
	public Image backgroundUnderlayImage; // 0x88
	public Sprite emptySlotBackgroundSprite; // 0x90
	public CanvasGroup conditionObject; // 0x98
	public Image conditionFill; // 0xA0
	public Image maxConditionFill; // 0xA8
	public bool allowSelection; // 0xB0
	public bool allowDropping; // 0xB1
	public bool allowMove; // 0xB2
	public Item item; // 0xB8
	public bool invalidSlot; // 0xC0
	public SoundDefinition hoverSound; // 0xC8
	internal Image[] slotImages; // 0xD0
	private static Dictionary<uint, float> containerLootStartTimes; // 0x20
	private bool queuedForLooting; // 0xD8
	private const float processLootQueueInterval = 0,2;
	private const float lootItemDuration = 0,2;
	private uint queuedQuickLootContainerID; // 0xDC
	private float queuedLootAtTime; // 0xE0
	private bool visible; // 0xE4
	private bool hovering; // 0xE5
	private CanvasGroup canvasGroupParent; // 0xE8
	private Coroutine currentCouroutine; // 0xF0
	public Action timedAction; // 0xF8
	public Nullable<Vector2> timedActionTime; // 0x100

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

	public virtual void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	private bool TryToDropInsideItem(ItemIcon.DragInfo dropInfo, Item item) { }

	public void SetTimedLootAction(uint sourceContainer, Action action) { }

	private float CalculateLootDelay(uint sourceContainer) { }

	[IteratorStateMachineAttribute] // RVA: 0x8E810 Offset: 0x8DC10 VA: 0x18008E810
	private IEnumerator StartTimedLootAction(float delay) { }

	public void RunTimedAction() { }

	public void ClearTimedAction() { }

	private void RemoveFromLootQueue() { }

	[IteratorStateMachineAttribute] // RVA: 0x8EA80 Offset: 0x8DE80 VA: 0x18008EA80
	private IEnumerator UpdateTimedActionIcon() { }

	private void TryToQuickMove() { }

	public virtual void TryToMove() { }

	public void EquipAsClothingItem() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OnPointerExit(PointerEventData eventData) { }

	public object GetDragData() { }

	public string GetDragType() { }

	public Sprite GetDragSprite() { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <EquipAsClothingItem>b__78_0() { }

}

public class ItemIcon.DragInfo // TypeDefIndex: 11009
{	public Item item; // 0x10
	public int amount; // 0x18
	public bool canDrop; // 0x1C


	public void .ctor() { }

}

private sealed class ItemIcon.<StartTimedLootAction>d__71 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11010
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ItemIcon <>4__this; // 0x20
	public float delay; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemIcon.<UpdateTimedActionIcon>d__75 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11011
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ItemIcon <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemIcon.<>c__DisplayClass77_0 // TypeDefIndex: 11012
{	public ItemIcon <>4__this; // 0x10
	public PlayerLoot loot; // 0x18


	public void .ctor() { }

	internal void <TryToMove>b__0() { }

	internal void <TryToMove>b__1() { }

	internal void <TryToMove>b__2() { }

	internal void <TryToMove>b__3() { }

}

public class ItemInformationPanel : MonoBehaviour // TypeDefIndex: 11013
{
	public virtual bool EligableForDisplay(ItemDefinition info) { }

	public virtual void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

public class ItemOptionButton : MonoBehaviour // TypeDefIndex: 11014
{	public TextMeshProUGUI name; // 0x18
	public Image icon; // 0x20
	internal Item item; // 0x28
	internal Option option; // 0x30


	public void Setup(Item item, Option option) { }

	public void Pressed() { }

	public void .ctor() { }

}

public class ItemPanel : SingletonComponent<ItemPanel> // TypeDefIndex: 11015
{	private ItemIcon item; // 0x18


	private void Start() { }

	public void Update() { }

	private void OnChanged() { }

	public void .ctor() { }

}

public class ItemPickupNotice : MonoBehaviour // TypeDefIndex: 11016
{	public TextMeshProUGUI Text; // 0x18
	public TextMeshProUGUI Amount; // 0x20
	private TimeSince enabledTime; // 0x28
	private RectTransform targetRect; // 0x30
	private CanvasGroup targetCanvas; // 0x38
	private const float pickupNoticeTime = 4;

	public ItemDefinition itemInfo { set; }
	public int amount { set; }


	public void set_itemInfo(ItemDefinition value) { }

	public void set_amount(int value) { }

	public void AppendTotal(int amount) { }

	public void OnEnable() { }

	public void BlockLayoutUpdates() { }

	public void AllowLayoutUpdates() { }

	public bool ProcessAnimation(AnimationCurve sizeCurve, AnimationCurve alphaCurve) { }

	public void PopupNoticeEnd() { }

	public void .ctor() { }

}

public class ItemPreviewIcon : BaseMonoBehaviour, IInventoryChanged, IItemAmountChanged, IItemIconChanged // TypeDefIndex: 11017
{	public ItemContainerSource containerSource; // 0x18
	[RangeAttribute] // RVA: 0x8E7C0 Offset: 0x8DBC0 VA: 0x18008E7C0
	public int slot; // 0x20
	public bool setSlotFromSiblingIndex; // 0x24
	public CanvasGroup iconContents; // 0x28
	public Image iconImage; // 0x30
	public Text amountText; // 0x38
	public Item item; // 0x40
	private bool invalidSlot; // 0x48

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

public class ItemSplitter : MonoBehaviour // TypeDefIndex: 11018
{	public Slider slider; // 0x18
	public TextMeshProUGUI textValue; // 0x20
	public TextMeshProUGUI splitAmountText; // 0x28
	public TMP_InputField amountInputField; // 0x30
	private static bool isInputFieldOpen; // 0x0
	private float oldAmount; // 0x38

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Start>b__6_0(string <p0>) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Start>b__6_1(string <p0>) { }

}

public class ItemSplitterDragOut : MonoBehaviour, IDraggable // TypeDefIndex: 11019
{	public ItemSplitter rootSplitter; // 0x18


	public object GetDragData() { }

	public string GetDragType() { }

	public Sprite GetDragSprite() { }

	public void .ctor() { }

}

public class ItemSplitterSlider : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler // TypeDefIndex: 11020
{	public ItemSplitter Splitter; // 0x18


	public void OnPointerDown(PointerEventData eventData) { }

	public void OnPointerUp(PointerEventData eventData) { }

	public void .ctor() { }

}

public class ItemStatValue : MonoBehaviour // TypeDefIndex: 11021
{	public Text text; // 0x18
	public Slider slider; // 0x20
	public bool selectedItem; // 0x28
	public bool smallerIsBetter; // 0x29
	public bool asPercentage; // 0x2A


	private void OnEnable() { }

	private void OnDisable() { }

	public void SetValue(float val, int numDecimals = 0, string overrideText = "") { }

	public void .ctor() { }

}

public class ItemSubmitPanel : LootPanel // TypeDefIndex: 11022
{
	public void SubmitClicked() { }

	public void .ctor() { }

}

public class ItemTextValue : MonoBehaviour // TypeDefIndex: 11023
{	public Text text; // 0x18
	public Color bad; // 0x20
	public Color good; // 0x30
	public bool negativestat; // 0x40
	public bool asPercentage; // 0x41
	public bool useColors; // 0x42
	public bool signed; // 0x43
	public string suffix; // 0x48
	public float multiplier; // 0x50


	public void SetValue(float val, int numDecimals = 0, string overrideText = "") { }

	public void .ctor() { }

}

public class ItemStore : SingletonComponent<ItemStore>, VirtualScroll.IDataSource // TypeDefIndex: 11105
{	public static readonly Translate.Phrase CartEmptyPhrase; // 0x0
	public static readonly Translate.Phrase CartSingularPhrase; // 0x8
	public static readonly Translate.Phrase CartPluralPhrase; // 0x10
	public GameObject ItemPrefab; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x964A0 Offset: 0x958A0 VA: 0x1800964A0
	public RectTransform LimitedItemParent; // 0x20
	public RectTransform GeneralItemParent; // 0x28
	public List<IPlayerItemDefinition> Cart; // 0x30
	public ItemStoreItemInfoModal ItemStoreInfoModal; // 0x38
	public GameObject BuyingModal; // 0x40
	public ItemStoreBuyFailedModal ItemStoreBuyFailedModal; // 0x48
	public ItemStoreBuySuccessModal ItemStoreBuySuccessModal; // 0x50
	public SoundDefinition AddToCartSound; // 0x58
	public RustText CartButtonLabel; // 0x60
	public RustText QuantityValue; // 0x68
	public RustText TotalValue; // 0x70


	protected override void Awake() { }

	private void OnPurchaseFinished(AppId appid, ulong orderid, bool success) { }

	[AsyncStateMachineAttribute] // RVA: 0x96590 Offset: 0x95990 VA: 0x180096590
	private void RefreshList() { }

	private void AddItem(IPlayerItemDefinition item) { }

	internal void ShowModal(IPlayerItemDefinition item) { }

	internal void AddToCart(IPlayerItemDefinition item) { }

	public void EmptyCart() { }

	private void UpdateShoppingList() { }

	public void RemoveFromCart(int index) { }

	[AsyncStateMachineAttribute] // RVA: 0x96770 Offset: 0x95B70 VA: 0x180096770
	public void Checkout() { }

	public int GetItemCount() { }

	public void SetItemData(int i, GameObject obj) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class ItemStore.<>c // TypeDefIndex: 11106
{	public static readonly ItemStore.<>c <>9; // 0x0
	public static Func<IPlayerItemDefinition, int> <>9__16_0; // 0x8
	public static Func<IPlayerItemDefinition, int> <>9__17_0; // 0x10
	public static Func<IPlayerItemDefinition, int> <>9__22_0; // 0x18
	public static Func<SteamItemDefinition, InventoryDef> <>9__24_0; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal int <OnPurchaseFinished>b__16_0(IPlayerItemDefinition x) { }

	internal int <RefreshList>b__17_0(IPlayerItemDefinition x) { }

	internal int <UpdateShoppingList>b__22_0(IPlayerItemDefinition x) { }

	internal InventoryDef <Checkout>b__24_0(SteamItemDefinition i) { }

}

private struct ItemStore.<RefreshList>d__17 : IAsyncStateMachine // TypeDefIndex: 11107
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ItemStore <>4__this; // 0x28
	private TaskAwaiter<List<IPlayerItemDefinition>> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ItemStore.<Checkout>d__24 : IAsyncStateMachine // TypeDefIndex: 11108
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ItemStore <>4__this; // 0x28
	private TaskAwaiter<Nullable<InventoryPurchaseResult>> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class ItemStoreBuyFailedModal : MonoBehaviour // TypeDefIndex: 11109
{
	public void Show(ulong orderid) { }

	public void Hide() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Hide>b__1_0() { }

}

public class ItemStoreBuySuccessModal : MonoBehaviour // TypeDefIndex: 11110
{
	public void Show(ulong orderId) { }

	public void Hide() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Hide>b__1_0() { }

}

public class ItemStoreCartItem : MonoBehaviour // TypeDefIndex: 11111
{	public int Index; // 0x18
	public TextMeshProUGUI Name; // 0x20
	public TextMeshProUGUI Price; // 0x28


	public void Init(int index, IPlayerItemDefinition def) { }

	public void RemoveFromCart() { }

	public void .ctor() { }

}

public class ItemStoreItem : MonoBehaviour // TypeDefIndex: 11112
{	public HttpImage Icon; // 0x18
	public RustText Name; // 0x20
	public TextMeshProUGUI Price; // 0x28
	public RustText ItemName; // 0x30
	public GameObject InCartTag; // 0x38
	private IPlayerItemDefinition item; // 0x40


	internal void Init(IPlayerItemDefinition item, bool inCart) { }

	public void ShowModal() { }

	public void AddToCart() { }

	public void .ctor() { }

}

public class ItemStoreItemInfoModal : MonoBehaviour // TypeDefIndex: 11113
{	public HttpImage Icon; // 0x18
	public TextMeshProUGUI Name; // 0x20
	public TextMeshProUGUI Price; // 0x28
	public TextMeshProUGUI Description; // 0x30
	private IPlayerItemDefinition item; // 0x38


	public void Show(IPlayerItemDefinition item) { }

	public void AddToCart() { }

	public void Hide() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Hide>b__7_0() { }

}

public class ItemModEngineItem : ItemMod // TypeDefIndex: 12108
{	public EngineStorage.EngineItemTypes engineItemType; // 0x20
	[RangeAttribute] // RVA: 0xDBAD0 Offset: 0xDAED0 VA: 0x1800DBAD0
	public int tier; // 0x24


	public void .ctor() { }

}

public class ItemModVehicleChassis : ItemMod, VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 12109
{	public GameObjectRef entityPrefab; // 0x20
	[RangeAttribute] // RVA: 0xDBBB0 Offset: 0xDAFB0 VA: 0x1800DBBB0
	public int socketsTaken; // 0x28

	public int SocketsTaken { get; }


	public int get_SocketsTaken() { }

	public override int GetTotalUISlots(Item item) { }

	public override int GetFilledUISlots(Item item) { }

	public void .ctor() { }

}

public class ItemModVehicleModule : ItemMod, VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 12110
{	public GameObjectRef entityPrefab; // 0x20
	[RangeAttribute] // RVA: 0xA42D0 Offset: 0xA36D0 VA: 0x1800A42D0
	public int socketsTaken; // 0x28
	public bool doNonUserSpawn; // 0x2C

	public int SocketsTaken { get; }


	public int get_SocketsTaken() { }

	public override int GetTotalUISlots(Item item) { }

	public override int GetFilledUISlots(Item item) { }

	public void .ctor() { }

}

