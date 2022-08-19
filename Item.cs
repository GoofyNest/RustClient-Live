internal enum ItemUpdateStatus // TypeDefIndex: 5163
{	// Fields
	public int value__; // 0x0
	public const ItemUpdateStatus Invalid = 0;
	public const ItemUpdateStatus PreparingConfig = 1;
	public const ItemUpdateStatus PreparingContent = 2;
	public const ItemUpdateStatus UploadingContent = 3;
	public const ItemUpdateStatus UploadingPreviewFile = 4;
	public const ItemUpdateStatus CommittingChanges = 5;

}

internal enum ItemState // TypeDefIndex: 5164
{	// Fields
	public int value__; // 0x0
	public const ItemState None = 0;
	public const ItemState Subscribed = 1;
	public const ItemState LegacyItem = 2;
	public const ItemState Installed = 4;
	public const ItemState NeedsUpdate = 8;
	public const ItemState Downloading = 16;
	public const ItemState DownloadPending = 32;

}

internal enum ItemStatistic // TypeDefIndex: 5165
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const ItemPreviewType Image = 0;
	public const ItemPreviewType YouTubeVideo = 1;
	public const ItemPreviewType Sketchfab = 2;
	public const ItemPreviewType EnvironmentMap_HorizontalCross = 3;
	public const ItemPreviewType EnvironmentMap_LatLong = 4;
	public const ItemPreviewType ReservedMax = 255;

}

public struct Item // TypeDefIndex: 5277
{	// Fields
	internal SteamUGCDetails_t details; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0x223FE0 Offset: 0x2233E0 VA: 0x180223FE0
	public void .ctor(PublishedFileId id) { }

	// RVA: 0x1D0EE0 Offset: 0x1D02E0 VA: 0x1801D0EE0
	public PublishedFileId get_Id() { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x2241B0 Offset: 0x2235B0 VA: 0x1802241B0
	public string get_Title() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2243F0 Offset: 0x2237F0 VA: 0x1802243F0
	internal void set_Title(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1E1270 Offset: 0x1E0670 VA: 0x1801E1270
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2242D0 Offset: 0x2236D0 VA: 0x1802242D0
	internal void set_Description(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0xFD2A0 Offset: 0xFC6A0 VA: 0x1800FD2A0
	public string[] get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2243E0 Offset: 0x2237E0 VA: 0x1802243E0
	internal void set_Tags(string[] value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0xF12A0 Offset: 0xF06A0 VA: 0x1800F12A0
	public Dictionary<string, string> get_KeyValueTags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2242E0 Offset: 0x2236E0 VA: 0x1802242E0
	internal void set_KeyValueTags(Dictionary<string, string> value) { }

	// RVA: 0x224150 Offset: 0x223550 VA: 0x180224150
	public Friend get_Owner() { }

	// RVA: 0x2241C0 Offset: 0x2235C0 VA: 0x1802241C0
	public DateTime get_Updated() { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1D1280 Offset: 0x1D0680 VA: 0x1801D1280
	public UgcAdditionalPreview[] get_AdditionalPreviews() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2242C0 Offset: 0x2236C0 VA: 0x1802242C0
	internal void set_AdditionalPreviews(UgcAdditionalPreview[] value) { }

	// RVA: 0x224110 Offset: 0x223510 VA: 0x180224110
	public bool get_IsInstalled() { }

	// RVA: 0x2240D0 Offset: 0x2234D0 VA: 0x1802240D0
	public bool get_IsDownloading() { }

	// RVA: 0x224090 Offset: 0x223490 VA: 0x180224090
	public bool get_IsDownloadPending() { }

	// RVA: 0x224020 Offset: 0x223420 VA: 0x180224020
	public string get_Directory() { }

	// RVA: 0x223E10 Offset: 0x223210 VA: 0x180223E10
	public bool Download(bool highPriority = False) { }

	// RVA: 0x224170 Offset: 0x223570 VA: 0x180224170
	private ItemState get_State() { }

	// RVA: 0x19D0700 Offset: 0x19CFB00 VA: 0x1819D0700
	internal static Item From(SteamUGCDetails_t details) { }

	[AsyncStateMachineAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	// RVA: 0x223E60 Offset: 0x223260 VA: 0x180223E60
	public Task<Nullable<Result>> Vote(bool up) { }

	// RVA: 0x224260 Offset: 0x223660 VA: 0x180224260
	public string get_Url() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224370 Offset: 0x223770 VA: 0x180224370
	internal void set_NumSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224310 Offset: 0x223710 VA: 0x180224310
	internal void set_NumFavorites(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224320 Offset: 0x223720 VA: 0x180224320
	internal void set_NumFollowers(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2243A0 Offset: 0x2237A0 VA: 0x1802243A0
	internal void set_NumUniqueSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224380 Offset: 0x223780 VA: 0x180224380
	internal void set_NumUniqueFavorites(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224390 Offset: 0x223790 VA: 0x180224390
	internal void set_NumUniqueFollowers(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2243B0 Offset: 0x2237B0 VA: 0x1802243B0
	internal void set_NumUniqueWebsiteViews(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2243D0 Offset: 0x2237D0 VA: 0x1802243D0
	internal void set_ReportScore(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224360 Offset: 0x223760 VA: 0x180224360
	internal void set_NumSecondsPlayed(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224340 Offset: 0x223740 VA: 0x180224340
	internal void set_NumPlaytimeSessions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224300 Offset: 0x223700 VA: 0x180224300
	internal void set_NumComments(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224350 Offset: 0x223750 VA: 0x180224350
	internal void set_NumSecondsPlayedDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224330 Offset: 0x223730 VA: 0x180224330
	internal void set_NumPlaytimeSessionsDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x224160 Offset: 0x223560 VA: 0x180224160
	public string get_PreviewImageUrl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2243C0 Offset: 0x2237C0 VA: 0x1802243C0
	internal void set_PreviewImageUrl(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2242F0 Offset: 0x2236F0 VA: 0x1802242F0
	internal void set_Metadata(string value) { }

}

private struct Item.<Vote>d__83 : IAsyncStateMachine // TypeDefIndex: 5278
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<Result>> <>t__builder; // 0x8
	public Item <>4__this; // 0x20
	public bool up; // 0x158
	private CallResult<SetUserItemVoteResult_t> <>u__1; // 0x160

	// Methods

	// RVA: 0x224E20 Offset: 0x224220 VA: 0x180224E20 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224E30 Offset: 0x224230 VA: 0x180224E30 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

internal struct ItemInstalled_t : ICallbackData // TypeDefIndex: 5434
{	// Fields
	internal AppId AppID; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EAD80 Offset: 0x1EA180 VA: 0x1801EAD80 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EAD70 Offset: 0x1EA170 VA: 0x1801EAD70 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136DC80 Offset: 0x136D080 VA: 0x18136DC80
	private static void .cctor() { }

}

public class ItemContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6439
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1F153C0 Offset: 0x1F147C0 VA: 0x181F153C0
	public static void ResetToPool(ItemContainer instance) { }

	// RVA: 0x1F156A0 Offset: 0x1F14AA0 VA: 0x181F156A0
	public void ResetToPool() { }

	// RVA: 0x1F15300 Offset: 0x1F14700 VA: 0x181F15300 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F13DA0 Offset: 0x1F131A0 VA: 0x181F13DA0
	public void CopyTo(ItemContainer instance) { }

	// RVA: 0x1F140A0 Offset: 0x1F134A0 VA: 0x181F140A0
	public ItemContainer Copy() { }

	// RVA: 0x1F15180 Offset: 0x1F14580 VA: 0x181F15180
	public static ItemContainer Deserialize(Stream stream) { }

	// RVA: 0x1F14630 Offset: 0x1F13A30 VA: 0x181F14630
	public static ItemContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F146B0 Offset: 0x1F13AB0 VA: 0x181F146B0
	public static ItemContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F15060 Offset: 0x1F14460 VA: 0x181F15060
	public static ItemContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1F15380 Offset: 0x1F14780 VA: 0x181F15380
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F164B0 Offset: 0x1F158B0 VA: 0x181F164B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F164D0 Offset: 0x1F158D0 VA: 0x181F164D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ItemContainer previous) { }

	// RVA: 0x1F153A0 Offset: 0x1F147A0 VA: 0x181F153A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F15200 Offset: 0x1F14600 VA: 0x181F15200
	public static ItemContainer Deserialize(byte[] buffer, ItemContainer instance, bool isDelta = False) { }

	// RVA: 0x1F14C30 Offset: 0x1F14030 VA: 0x181F14C30
	public static ItemContainer Deserialize(Stream stream, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F14120 Offset: 0x1F13520 VA: 0x181F14120
	public static ItemContainer DeserializeLengthDelimited(Stream stream, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F14740 Offset: 0x1F13B40 VA: 0x181F14740
	public static ItemContainer DeserializeLength(Stream stream, int length, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F15980 Offset: 0x1F14D80 VA: 0x181F15980
	public static void SerializeDelta(Stream stream, ItemContainer instance, ItemContainer previous) { }

	// RVA: 0x1F16090 Offset: 0x1F15490 VA: 0x181F16090
	public static void Serialize(Stream stream, ItemContainer instance) { }

	// RVA: 0x1F164A0 Offset: 0x1F158A0 VA: 0x181F164A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F164B0 Offset: 0x1F158B0 VA: 0x181F164B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F15F80 Offset: 0x1F15380 VA: 0x181F15F80
	public static byte[] SerializeToBytes(ItemContainer instance) { }

	// RVA: 0x1F15ED0 Offset: 0x1F152D0 VA: 0x181F15ED0
	public static void SerializeLengthDelimited(Stream stream, ItemContainer instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Item : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6440
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1C0A970 Offset: 0x1C09D70 VA: 0x181C0A970
	public static void ResetToPool(Item instance) { }

	// RVA: 0x1C0AB90 Offset: 0x1C09F90 VA: 0x181C0AB90
	public void ResetToPool() { }

	// RVA: 0x1C0A8B0 Offset: 0x1C09CB0 VA: 0x181C0A8B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C09210 Offset: 0x1C08610 VA: 0x181C09210
	public void CopyTo(Item instance) { }

	// RVA: 0x1C09360 Offset: 0x1C08760 VA: 0x181C09360
	public Item Copy() { }

	// RVA: 0x1C0A710 Offset: 0x1C09B10 VA: 0x181C0A710
	public static Item Deserialize(Stream stream) { }

	// RVA: 0x1C099E0 Offset: 0x1C08DE0 VA: 0x181C099E0
	public static Item DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0A040 Offset: 0x1C09440 VA: 0x181C0A040
	public static Item DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0A790 Offset: 0x1C09B90 VA: 0x181C0A790
	public static Item Deserialize(byte[] buffer) { }

	// RVA: 0x1C0A930 Offset: 0x1C09D30 VA: 0x181C0A930
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C0BD30 Offset: 0x1C0B130 VA: 0x181C0BD30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C0BD50 Offset: 0x1C0B150 VA: 0x181C0BD50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item previous) { }

	// RVA: 0x1C0A950 Offset: 0x1C09D50 VA: 0x181C0A950 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0A610 Offset: 0x1C09A10 VA: 0x181C0A610
	public static Item Deserialize(byte[] buffer, Item instance, bool isDelta = False) { }

	// RVA: 0x1C0A0D0 Offset: 0x1C094D0 VA: 0x181C0A0D0
	public static Item Deserialize(Stream stream, Item instance, bool isDelta) { }

	// RVA: 0x1C093E0 Offset: 0x1C087E0 VA: 0x181C093E0
	public static Item DeserializeLengthDelimited(Stream stream, Item instance, bool isDelta) { }

	// RVA: 0x1C09A60 Offset: 0x1C08E60 VA: 0x181C09A60
	public static Item DeserializeLength(Stream stream, int length, Item instance, bool isDelta) { }

	// RVA: 0x1C0ADB0 Offset: 0x1C0A1B0 VA: 0x181C0ADB0
	public static void SerializeDelta(Stream stream, Item instance, Item previous) { }

	// RVA: 0x1C0B750 Offset: 0x1C0AB50 VA: 0x181C0B750
	public static void Serialize(Stream stream, Item instance) { }

	// RVA: 0x1C0BD20 Offset: 0x1C0B120 VA: 0x181C0BD20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C0BD30 Offset: 0x1C0B130 VA: 0x181C0BD30
	public void ToProto(Stream stream) { }

	// RVA: 0x1C0B640 Offset: 0x1C0AA40 VA: 0x181C0B640
	public static byte[] SerializeToBytes(Item instance) { }

	// RVA: 0x1C0B590 Offset: 0x1C0A990 VA: 0x181C0B590
	public static void SerializeLengthDelimited(Stream stream, Item instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Item.InstanceData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6441
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int dataInt; // 0x14
	public int blueprintTarget; // 0x18
	public int blueprintAmount; // 0x1C
	public uint subEntity; // 0x20

	// Methods

	// RVA: 0x1F11E00 Offset: 0x1F11200 VA: 0x181F11E00
	public static void ResetToPool(Item.InstanceData instance) { }

	// RVA: 0x1F11D60 Offset: 0x1F11160 VA: 0x181F11D60
	public void ResetToPool() { }

	// RVA: 0x1F11A10 Offset: 0x1F10E10 VA: 0x181F11A10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C01DA0 Offset: 0x1C011A0 VA: 0x181C01DA0
	public void CopyTo(Item.InstanceData instance) { }

	// RVA: 0x1F10880 Offset: 0x1F0FC80 VA: 0x181F10880
	public Item.InstanceData Copy() { }

	// RVA: 0x1F114B0 Offset: 0x1F108B0 VA: 0x181F114B0
	public static Item.InstanceData Deserialize(Stream stream) { }

	// RVA: 0x1F10BE0 Offset: 0x1F0FFE0 VA: 0x181F10BE0
	public static Item.InstanceData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F10F20 Offset: 0x1F10320 VA: 0x181F10F20
	public static Item.InstanceData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F11700 Offset: 0x1F10B00 VA: 0x181F11700
	public static Item.InstanceData Deserialize(byte[] buffer) { }

	// RVA: 0x1F11B30 Offset: 0x1F10F30 VA: 0x181F11B30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F123E0 Offset: 0x1F117E0 VA: 0x181F123E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F12400 Offset: 0x1F11800 VA: 0x181F12400 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item.InstanceData previous) { }

	// RVA: 0x1F11D40 Offset: 0x1F11140 VA: 0x181F11D40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F111C0 Offset: 0x1F105C0 VA: 0x181F111C0
	public static Item.InstanceData Deserialize(byte[] buffer, Item.InstanceData instance, bool isDelta = False) { }

	// RVA: 0x1F10FB0 Offset: 0x1F103B0 VA: 0x181F10FB0
	public static Item.InstanceData Deserialize(Stream stream, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F10900 Offset: 0x1F0FD00 VA: 0x181F10900
	public static Item.InstanceData DeserializeLengthDelimited(Stream stream, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F10C60 Offset: 0x1F10060 VA: 0x181F10C60
	public static Item.InstanceData DeserializeLength(Stream stream, int length, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F11EA0 Offset: 0x1F112A0 VA: 0x181F11EA0
	public static void SerializeDelta(Stream stream, Item.InstanceData instance, Item.InstanceData previous) { }

	// RVA: 0x1F12280 Offset: 0x1F11680 VA: 0x181F12280
	public static void Serialize(Stream stream, Item.InstanceData instance) { }

	// RVA: 0x1F123D0 Offset: 0x1F117D0 VA: 0x181F123D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F123E0 Offset: 0x1F117E0 VA: 0x181F123E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F12170 Offset: 0x1F11570 VA: 0x181F12170
	public static byte[] SerializeToBytes(Item.InstanceData instance) { }

	// RVA: 0x1F120C0 Offset: 0x1F114C0 VA: 0x181F120C0
	public static void SerializeLengthDelimited(Stream stream, Item.InstanceData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Item.ConditionData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6442
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float condition; // 0x14
	public float maxCondition; // 0x18

	// Methods

	// RVA: 0x1F10180 Offset: 0x1F0F580 VA: 0x181F10180
	public static void ResetToPool(Item.ConditionData instance) { }

	// RVA: 0x1F10200 Offset: 0x1F0F600 VA: 0x181F10200
	public void ResetToPool() { }

	// RVA: 0x1F0FEE0 Offset: 0x1F0F2E0 VA: 0x181F0FEE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(Item.ConditionData instance) { }

	// RVA: 0x1F0F0E0 Offset: 0x1F0E4E0 VA: 0x181F0F0E0
	public Item.ConditionData Copy() { }

	// RVA: 0x1F0F6E0 Offset: 0x1F0EAE0 VA: 0x181F0F6E0
	public static Item.ConditionData Deserialize(Stream stream) { }

	// RVA: 0x1F0F150 Offset: 0x1F0E550 VA: 0x181F0F150
	public static Item.ConditionData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F0F420 Offset: 0x1F0E820 VA: 0x181F0F420
	public static Item.ConditionData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F0F8A0 Offset: 0x1F0ECA0 VA: 0x181F0F8A0
	public static Item.ConditionData Deserialize(byte[] buffer) { }

	// RVA: 0x1F0FFE0 Offset: 0x1F0F3E0 VA: 0x181F0FFE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F106D0 Offset: 0x1F0FAD0 VA: 0x181F106D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F106F0 Offset: 0x1F0FAF0 VA: 0x181F106F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item.ConditionData previous) { }

	// RVA: 0x1F10160 Offset: 0x1F0F560 VA: 0x181F10160 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F0FB10 Offset: 0x1F0EF10 VA: 0x181F0FB10
	public static Item.ConditionData Deserialize(byte[] buffer, Item.ConditionData instance, bool isDelta = False) { }

	// RVA: 0x1F0FD60 Offset: 0x1F0F160 VA: 0x181F0FD60
	public static Item.ConditionData Deserialize(Stream stream, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F0F1D0 Offset: 0x1F0E5D0 VA: 0x181F0F1D0
	public static Item.ConditionData DeserializeLengthDelimited(Stream stream, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F0F4B0 Offset: 0x1F0E8B0 VA: 0x181F0F4B0
	public static Item.ConditionData DeserializeLength(Stream stream, int length, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F10280 Offset: 0x1F0F680 VA: 0x181F10280
	public static void SerializeDelta(Stream stream, Item.ConditionData instance, Item.ConditionData previous) { }

	// RVA: 0x1F105C0 Offset: 0x1F0F9C0 VA: 0x181F105C0
	public static void Serialize(Stream stream, Item.ConditionData instance) { }

	// RVA: 0x1F106C0 Offset: 0x1F0FAC0 VA: 0x181F106C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F106D0 Offset: 0x1F0FAD0 VA: 0x181F106D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F104B0 Offset: 0x1F0F8B0 VA: 0x181F104B0
	public static byte[] SerializeToBytes(Item.ConditionData instance) { }

	// RVA: 0x1F10400 Offset: 0x1F0F800 VA: 0x181F10400
	public static void SerializeLengthDelimited(Stream stream, Item.ConditionData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ItemAmountList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6506
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> itemID; // 0x18
	public List<float> amount; // 0x20

	// Methods

	// RVA: 0x1F13640 Offset: 0x1F12A40 VA: 0x181F13640
	public static void ResetToPool(ItemAmountList instance) { }

	// RVA: 0x1F134F0 Offset: 0x1F128F0 VA: 0x181F134F0
	public void ResetToPool() { }

	// RVA: 0x1F132F0 Offset: 0x1F126F0 VA: 0x181F132F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F12420 Offset: 0x1F11820 VA: 0x181F12420
	public void CopyTo(ItemAmountList instance) { }

	// RVA: 0x1F12620 Offset: 0x1F11A20 VA: 0x181F12620
	public ItemAmountList Copy() { }

	// RVA: 0x1F12F00 Offset: 0x1F12300 VA: 0x181F12F00
	public static ItemAmountList Deserialize(Stream stream) { }

	// RVA: 0x1F126A0 Offset: 0x1F11AA0 VA: 0x181F126A0
	public static ItemAmountList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F12A50 Offset: 0x1F11E50 VA: 0x181F12A50
	public static ItemAmountList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F131D0 Offset: 0x1F125D0 VA: 0x181F131D0
	public static ItemAmountList Deserialize(byte[] buffer) { }

	// RVA: 0x1F134B0 Offset: 0x1F128B0 VA: 0x181F134B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F13D60 Offset: 0x1F13160 VA: 0x181F13D60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F13D80 Offset: 0x1F13180 VA: 0x181F13D80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ItemAmountList previous) { }

	// RVA: 0x1F134D0 Offset: 0x1F128D0 VA: 0x181F134D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F12E00 Offset: 0x1F12200 VA: 0x181F12E00
	public static ItemAmountList Deserialize(byte[] buffer, ItemAmountList instance, bool isDelta = False) { }

	// RVA: 0x1F12F80 Offset: 0x1F12380 VA: 0x181F12F80
	public static ItemAmountList Deserialize(Stream stream, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F12720 Offset: 0x1F11B20 VA: 0x181F12720
	public static ItemAmountList DeserializeLengthDelimited(Stream stream, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F12AE0 Offset: 0x1F11EE0 VA: 0x181F12AE0
	public static ItemAmountList DeserializeLength(Stream stream, int length, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F13790 Offset: 0x1F12B90 VA: 0x181F13790
	public static void SerializeDelta(Stream stream, ItemAmountList instance, ItemAmountList previous) { }

	// RVA: 0x1F13B50 Offset: 0x1F12F50 VA: 0x181F13B50
	public static void Serialize(Stream stream, ItemAmountList instance) { }

	// RVA: 0x1F13D50 Offset: 0x1F13150 VA: 0x181F13D50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F13D60 Offset: 0x1F13160 VA: 0x181F13D60
	public void ToProto(Stream stream) { }

	// RVA: 0x1F13A40 Offset: 0x1F12E40 VA: 0x181F13A40
	public static byte[] SerializeToBytes(ItemAmountList instance) { }

	// RVA: 0x1F13990 Offset: 0x1F12D90 VA: 0x181F13990
	public static void SerializeLengthDelimited(Stream stream, ItemAmountList instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ItemSchema // TypeDefIndex: 7740
{	// Fields
	public int appid; // 0x10
	public ItemSchema.Item[] items; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class ItemSchema.Item // TypeDefIndex: 7741
{	// Fields
	public string name; // 0x10
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

	// Properties
	[JsonIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public double Price { get; }

	// Methods

	// RVA: 0xE87940 Offset: 0xE86D40 VA: 0x180E87940
	public double get_Price() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class ItemBasedFlowRestrictor : IOEntity, IContainerSounds // TypeDefIndex: 8400
{	// Fields
	private Option __menuOption_Menu_Open; // 0x288
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

	// Properties
	public override bool HasMenuOptions { get; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }

	// Methods

	// RVA: 0xA04CA0 Offset: 0xA040A0 VA: 0x180A04CA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA05160 Offset: 0xA04560 VA: 0x180A05160 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA04FD0 Offset: 0xA043D0 VA: 0x180A04FD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Description] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Icon] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	// RVA: 0xA04F90 Offset: 0xA04390 VA: 0x180A04F90
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0xA051F0 Offset: 0xA045F0 VA: 0x180A051F0 Slot: 159
	public SoundDefinition get_OpenSound() { }

	// RVA: 0xA05150 Offset: 0xA04550 VA: 0x180A05150 Slot: 160
	public SoundDefinition get_CloseSound() { }

	// RVA: 0xA050C0 Offset: 0xA044C0 VA: 0x180A050C0
	public void .ctor() { }

}

public class ItemSearchEntry : MonoBehaviour // TypeDefIndex: 8731
{	// Fields
	public Button button; // 0x18
	public Text text; // 0x20
	public RawImage image; // 0x28
	public RawImage bpImage; // 0x30
	private ItemDefinition itemInfo; // 0x38
	private AddSellOrderManager manager; // 0x40

	// Methods

	// RVA: 0x6AE240 Offset: 0x6AD640 VA: 0x1806AE240
	public void Setup(ItemDefinition info, AddSellOrderManager mgr) { }

	// RVA: 0x6AE210 Offset: 0x6AD610 VA: 0x1806AE210
	public void Clicked() { }

	// RVA: 0x6AE1E0 Offset: 0x6AD5E0 VA: 0x1806AE1E0
	public void ClickedBP() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModCrackOpen : ItemModUnwrap // TypeDefIndex: 8785
{	// Methods

	// RVA: 0xA11AF0 Offset: 0xA10EF0 VA: 0x180A11AF0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA11C00 Offset: 0xA11000 VA: 0x180A11C00
	public void .ctor() { }

}

public class ItemModOpenLootBag : ItemModUnwrap // TypeDefIndex: 8793
{	// Methods

	// RVA: 0xA12460 Offset: 0xA11860 VA: 0x180A12460 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA11C00 Offset: 0xA11000 VA: 0x180A11C00
	public void .ctor() { }

}

public class ItemModPhoto : ItemModAssociatedEntity<PhotoEntity> // TypeDefIndex: 8814
{	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA12E00 Offset: 0xA12200 VA: 0x180A12E00
	public void .ctor() { }

}

public class ItemModUnwrap : ItemMod // TypeDefIndex: 8823
{	// Fields
	public LootSpawn revealList; // 0x20
	public GameObjectRef successEffect; // 0x28
	public int minTries; // 0x30
	public int maxTries; // 0x34

	// Methods

	// RVA: 0xA13F30 Offset: 0xA13330 VA: 0x180A13F30 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA11C00 Offset: 0xA11000 VA: 0x180A11C00
	public void .ctor() { }

}

public class ItemModOpenWrapped : ItemMod // TypeDefIndex: 8829
{	// Fields
	public GameObjectRef successEffect; // 0x20
	public static Translate.Phrase open_wrapped_gift; // 0x0
	public static Translate.Phrase open_wrapped_gift_desc; // 0x8

	// Methods

	// RVA: 0xA12570 Offset: 0xA11970 VA: 0x180A12570 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0xA126D0 Offset: 0xA11AD0 VA: 0x180A126D0
	private static void .cctor() { }

}

public class ItemModWrap : ItemMod // TypeDefIndex: 8830
{	// Fields
	public GameObjectRef successEffect; // 0x20
	public ItemDefinition wrappedDefinition; // 0x28
	public static Translate.Phrase wrap_gift; // 0x0
	public static Translate.Phrase wrap_gift_desc; // 0x8

	// Methods

	// RVA: 0xA152A0 Offset: 0xA146A0 VA: 0x180A152A0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0xA15430 Offset: 0xA14830 VA: 0x180A15430
	private static void .cctor() { }

}

public class ItemModXMasTreeDecoration : ItemMod // TypeDefIndex: 8832
{	// Fields
	public ItemModXMasTreeDecoration.xmasFlags flagsToChange; // 0x20

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public enum ItemModXMasTreeDecoration.xmasFlags // TypeDefIndex: 8833
{	// Fields
	public int value__; // 0x0
	public const ItemModXMasTreeDecoration.xmasFlags pineCones = 128;
	public const ItemModXMasTreeDecoration.xmasFlags candyCanes = 256;
	public const ItemModXMasTreeDecoration.xmasFlags gingerbreadMen = 512;
	public const ItemModXMasTreeDecoration.xmasFlags Tinsel = 1024;
	public const ItemModXMasTreeDecoration.xmasFlags Balls = 2048;
	public const ItemModXMasTreeDecoration.xmasFlags Star = 16384;
	public const ItemModXMasTreeDecoration.xmasFlags Lights = 32768;

}

public class ItemModRFListener : ItemModAssociatedEntity<PagerEntity> // TypeDefIndex: 8874
{	// Fields
	public GameObjectRef frequencyPanelPrefab; // 0x28
	private uint pendingPagerID; // 0x30

	// Methods

	// RVA: 0xA133C0 Offset: 0xA127C0 VA: 0x180A133C0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA13200 Offset: 0xA12600 VA: 0x180A13200
	public void ConfigureClicked(BasePlayer player) { }

	// RVA: 0xA13830 Offset: 0xA12C30 VA: 0x180A13830
	public void .ctor() { }

}

public class ItemButtonTools : MonoBehaviour // TypeDefIndex: 9281
{	// Fields
	public Image image; // 0x18
	public ItemDefinition itemDef; // 0x20

	// Methods

	// RVA: 0xA05910 Offset: 0xA04D10 VA: 0x180A05910
	public void GiveSelf(int amount) { }

	// RVA: 0xA057F0 Offset: 0xA04BF0 VA: 0x180A057F0
	public void GiveArmed() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void GiveBlueprint() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemListTools : MonoBehaviour // TypeDefIndex: 9282
{	// Fields
	public GameObject categoryButton; // 0x18
	public GameObject itemButton; // 0x20
	public RustInput searchInputText; // 0x28
	internal Button lastCategory; // 0x30
	private IOrderedEnumerable<ItemDefinition> currentItems; // 0x38
	private IOrderedEnumerable<ItemDefinition> allItems; // 0x40

	// Methods

	// RVA: 0xA0EAE0 Offset: 0xA0DEE0 VA: 0x180A0EAE0
	public void OnPanelOpened() { }

	// RVA: 0xA0EAB0 Offset: 0xA0DEB0 VA: 0x180A0EAB0
	private void OnOpenDevTools() { }

	// RVA: 0xA0E3E0 Offset: 0xA0D7E0 VA: 0x180A0E3E0
	private void CacheAllItems() { }

	// RVA: 0xA0F300 Offset: 0xA0E700 VA: 0x180A0F300
	public void Refresh() { }

	// RVA: 0xA0EC70 Offset: 0xA0E070 VA: 0x180A0EC70
	private void RebuildCategories() { }

	// RVA: 0xA0F310 Offset: 0xA0E710 VA: 0x180A0F310
	private void SwitchItemCategory(ItemDefinition[] defs) { }

	// RVA: 0xA0E530 Offset: 0xA0D930 VA: 0x180A0E530
	public void FilterItems(string searchText) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private sealed class ItemListTools.<>c // TypeDefIndex: 9283
{	// Fields
	public static readonly ItemListTools.<>c <>9; // 0x0
	public static Func<ItemDefinition, string> <>9__8_0; // 0x8
	public static Func<ItemDefinition, ItemCategory> <>9__10_0; // 0x10
	public static Func<IGrouping<ItemCategory, ItemDefinition>, ItemCategory> <>9__10_1; // 0x18
	public static Func<ItemDefinition, string> <>9__11_0; // 0x20

	// Methods

	// RVA: 0xA19E20 Offset: 0xA19220 VA: 0x180A19E20
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA188B0 Offset: 0xA17CB0 VA: 0x180A188B0
	internal string <CacheAllItems>b__8_0(ItemDefinition x) { }

	// RVA: 0xA18B60 Offset: 0xA17F60 VA: 0x180A18B60
	internal ItemCategory <RebuildCategories>b__10_0(ItemDefinition x) { }

	// RVA: 0xA18B80 Offset: 0xA17F80 VA: 0x180A18B80
	internal ItemCategory <RebuildCategories>b__10_1(IGrouping<ItemCategory, ItemDefinition> x) { }

	// RVA: 0xA188B0 Offset: 0xA17CB0 VA: 0x180A188B0
	internal string <SwitchItemCategory>b__11_0(ItemDefinition x) { }

}

private sealed class ItemListTools.<>c__DisplayClass10_0 // TypeDefIndex: 9284
{	// Fields
	public Button btn; // 0x10
	public ItemDefinition[] itemArray; // 0x18
	public ItemListTools <>4__this; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA18D50 Offset: 0xA18150 VA: 0x180A18D50
	internal void <RebuildCategories>b__2() { }

}

public class ItemTools : MonoBehaviour // TypeDefIndex: 9311
{
// Namespace: 
public class ItemTools : MonoBehaviour // TypeDefIndex: 9311
	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModAssociatedEntityMobile : ItemModAssociatedEntity<MobileInventoryEntity> // TypeDefIndex: 9444
{	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA109B0 Offset: 0xA0FDB0 VA: 0x180A109B0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA10BC0 Offset: 0xA0FFC0 VA: 0x180A10BC0
	public void .ctor() { }

}

public class ItemModCassette : ItemModAssociatedEntity<Cassette> // TypeDefIndex: 9445
{	// Fields
	public int noteSpriteIndex; // 0x28
	public PreloadedCassetteContent PreloadedContent; // 0x30

	// Properties
	protected override bool AllowNullParenting { get; }
	protected override bool AllowHeldEntityParenting { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 17
	protected override bool get_AllowHeldEntityParenting() { }

	// RVA: 0xA10E60 Offset: 0xA10260 VA: 0x180A10E60
	public void .ctor() { }

}

public class ItemModSign : ItemModAssociatedEntity<SignContent> // TypeDefIndex: 9513
{	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA13E70 Offset: 0xA13270 VA: 0x180A13E70
	public void .ctor() { }

}

public class ItemPickup : DroppedItem // TypeDefIndex: 9791
{	// Fields
	public ItemDefinition itemDef; // 0x188
	public int amount; // 0x190
	public ulong skinOverride; // 0x198

	// Methods

	// RVA: 0x6AD920 Offset: 0x6ACD20 VA: 0x1806AD920
	public void .ctor() { }

}

public class ItemCraftTask // TypeDefIndex: 10102
{	// Fields
	public ItemBlueprint blueprint; // 0x10
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

	// Methods

	// RVA: 0xA083F0 Offset: 0xA077F0 VA: 0x180A083F0
	public void .ctor() { }

}

public class ItemCrafter : EntityComponent<BasePlayer> // TypeDefIndex: 10103
{	// Fields
	public List<ItemContainer> containers; // 0x20
	public LinkedList<ItemCraftTask> queue; // 0x28
	public int taskUID; // 0x30

	// Methods

	// RVA: 0xA08410 Offset: 0xA07810 VA: 0x180A08410
	public void AddContainer(ItemContainer container) { }

	// RVA: 0xA08A90 Offset: 0xA07E90 VA: 0x180A08A90
	public static float GetScaledDuration(ItemBlueprint bp, float workbenchLevel) { }

	// RVA: 0xA08930 Offset: 0xA07D30 VA: 0x180A08930
	private bool DoesHaveUsableItem(int item, int iAmount) { }

	// RVA: 0xA08470 Offset: 0xA07870 VA: 0x180A08470
	public bool CanCraft(ItemBlueprint bp, int amount = 1, bool free = False) { }

	// RVA: 0xA088A0 Offset: 0xA07CA0 VA: 0x180A088A0
	public bool CanCraft(ItemDefinition def, int amount = 1, bool free = False) { }

	// RVA: 0xA08AF0 Offset: 0xA07EF0 VA: 0x180A08AF0
	public void .ctor() { }

}

public class ItemEventFlag : MonoBehaviour, IItemUpdate // TypeDefIndex: 10104
{	// Fields
	public Item.Flag flag; // 0x18
	public UnityEvent onEnabled; // 0x20
	public UnityEvent onDisable; // 0x28
	internal bool firstRun; // 0x30
	internal bool lastState; // 0x31

	// Methods

	// RVA: 0xA09A80 Offset: 0xA08E80 VA: 0x180A09A80 Slot: 5
	public virtual void OnItemUpdate(Item item) { }

	// RVA: 0xA09AE0 Offset: 0xA08EE0 VA: 0x180A09AE0
	public void .ctor() { }

}

public class Item // TypeDefIndex: 10105
{	// Fields
	public Nullable<int> amountOverride; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0xA16FF0 Offset: 0xA163F0 VA: 0x180A16FF0
	public void UpdateAmountDisplay(Text text) { }

	// RVA: 0xA17070 Offset: 0xA16470 VA: 0x180A17070
	public static void UpdateAmountDisplay(Text text, Item item, Nullable<int> amountOverride, ItemDefinition infoOverride) { }

	// RVA: 0xA15AB0 Offset: 0xA14EB0 VA: 0x180A15AB0
	private static string FormatAmount(ItemDefinition.AmountType type, int amount) { }

	// RVA: 0xA17FC0 Offset: 0xA173C0 VA: 0x180A17FC0
	public void set_condition(float value) { }

	// RVA: 0x772410 Offset: 0x771810 VA: 0x180772410
	public float get_condition() { }

	// RVA: 0xA18040 Offset: 0xA17440 VA: 0x180A18040
	public void set_maxCondition(float value) { }

	// RVA: 0x7723E0 Offset: 0x7717E0 VA: 0x1807723E0
	public float get_maxCondition() { }

	// RVA: 0xA17D70 Offset: 0xA17170 VA: 0x180A17D70
	public float get_maxConditionNormalized() { }

	// RVA: 0xA17900 Offset: 0xA16D00 VA: 0x180A17900
	public float get_conditionNormalized() { }

	// RVA: 0xA17F20 Offset: 0xA17320 VA: 0x180A17F20
	public void set_conditionNormalized(float value) { }

	// RVA: 0xA17A00 Offset: 0xA16E00 VA: 0x180A17A00
	public bool get_hasCondition() { }

	// RVA: 0xA17C40 Offset: 0xA17040 VA: 0x180A17C40
	public bool get_isBroken() { }

	// RVA: 0xA17940 Offset: 0xA16D40 VA: 0x180A17940
	public int get_despawnMultiplier() { }

	// RVA: 0xA178D0 Offset: 0xA16CD0 VA: 0x180A178D0
	public ItemDefinition get_blueprintTargetDef() { }

	// RVA: 0xA178F0 Offset: 0xA16CF0 VA: 0x180A178F0
	public int get_blueprintTarget() { }

	// RVA: 0xA17E90 Offset: 0xA17290 VA: 0x180A17E90
	public void set_blueprintTarget(int value) { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public int get_blueprintAmount() { }

	// RVA: 0xA17E80 Offset: 0xA17280 VA: 0x180A17E80
	public void set_blueprintAmount(int value) { }

	// RVA: 0xA15FE0 Offset: 0xA153E0 VA: 0x180A15FE0
	public bool IsBlueprint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA17800 Offset: 0xA16C00 VA: 0x180A17800
	public void add_OnDirty(Action<Item> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA17DE0 Offset: 0xA171E0 VA: 0x180A17DE0
	public void remove_OnDirty(Action<Item> value) { }

	// RVA: 0xA15FD0 Offset: 0xA153D0 VA: 0x180A15FD0
	public bool HasFlag(Item.Flag f) { }

	// RVA: 0xA16AF0 Offset: 0xA15EF0 VA: 0x180A16AF0
	public void SetFlag(Item.Flag f, bool b) { }

	// RVA: 0xA16210 Offset: 0xA15610 VA: 0x180A16210
	public bool IsOn() { }

	// RVA: 0xA16200 Offset: 0xA15600 VA: 0x180A16200
	public bool IsOnFire() { }

	// RVA: 0xA161C0 Offset: 0xA155C0 VA: 0x180A161C0
	public bool IsCooking() { }

	// RVA: 0xA161D0 Offset: 0xA155D0 VA: 0x180A161D0
	public bool IsLocked() { }

	// RVA: 0xA17DA0 Offset: 0xA171A0 VA: 0x180A17DA0
	public Item get_parentItem() { }

	// RVA: 0xA16640 Offset: 0xA15A40 VA: 0x180A16640
	public void MarkDirty() { }

	// RVA: 0xA16730 Offset: 0xA15B30 VA: 0x180A16730
	public void OnChanged() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void CollectedForCrafting(BasePlayer crafter) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void ReturnedFromCancelledCraft(BasePlayer crafter) { }

	// RVA: 0xA16030 Offset: 0xA15430 VA: 0x180A16030
	public bool IsChildContainer(ItemContainer c) { }

	// RVA: 0xA16000 Offset: 0xA15400 VA: 0x180A16000
	public bool IsBusy() { }

	// RVA: 0xA15660 Offset: 0xA14A60 VA: 0x180A15660
	public void BusyFor(float fTime) { }

	// RVA: 0xA168E0 Offset: 0xA15CE0 VA: 0x180A168E0
	public void Remove(float fTime = 0) { }

	// RVA: 0xA15910 Offset: 0xA14D10 VA: 0x180A15910
	internal void DoRemove() { }

	// RVA: 0xA16C80 Offset: 0xA16080 VA: 0x180A16C80
	public void SwitchOnOff(bool bNewState) { }

	// RVA: 0xA165C0 Offset: 0xA159C0 VA: 0x180A165C0
	public void LockUnlock(bool bNewState) { }

	// RVA: 0xA17DC0 Offset: 0xA171C0 VA: 0x180A17DC0
	public float get_temperature() { }

	// RVA: 0xA15DE0 Offset: 0xA151E0 VA: 0x180A15DE0
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0xA15690 Offset: 0xA14A90 VA: 0x180A15690
	public bool CanBeHeld() { }

	// RVA: 0xA156D0 Offset: 0xA14AD0 VA: 0x180A156D0
	public bool CanStack(Item item) { }

	// RVA: 0xA16220 Offset: 0xA15620 VA: 0x180A16220
	public bool IsValid() { }

	// RVA: 0xA16B10 Offset: 0xA15F10 VA: 0x180A16B10
	public void SetWorldEntity(BaseEntity ent) { }

	// RVA: 0xA16850 Offset: 0xA15C50 VA: 0x180A16850
	public void OnMovedToWorld() { }

	// RVA: 0xA15E90 Offset: 0xA15290 VA: 0x180A15E90
	public BaseEntity GetWorldEntity() { }

	// RVA: 0xA15DC0 Offset: 0xA151C0 VA: 0x180A15DC0
	public BaseEntity GetHeldEntity() { }

	// RVA: 0xA155C0 Offset: 0xA149C0 VA: 0x180A155C0
	public bool BeltBarSelect(BasePlayer player) { }

	// RVA: 0xA15E00 Offset: 0xA15200 VA: 0x180A15E00 Slot: 4
	public virtual int GetTotalUISlots() { }

	// RVA: 0xA15D30 Offset: 0xA15130 VA: 0x180A15D30 Slot: 5
	public virtual int GetFilledUISlots() { }

	// RVA: 0xA15EB0 Offset: 0xA152B0 VA: 0x180A15EB0
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xA15960 Offset: 0xA14D60 VA: 0x180A15960
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xA15C10 Offset: 0xA15010 VA: 0x180A15C10
	public int GetAmmoAmount(AmmoTypes ammoType) { }

	// RVA: 0xA16D00 Offset: 0xA16100 VA: 0x180A16D00 Slot: 3
	public override string ToString() { }

	// RVA: 0xA15A90 Offset: 0xA14E90 VA: 0x180A15A90
	public Item FindItem(uint iUID) { }

	// RVA: 0xA166A0 Offset: 0xA15AA0 VA: 0x180A166A0
	public int MaxStackable() { }

	// RVA: 0xA17AA0 Offset: 0xA16EA0 VA: 0x180A17AA0
	internal Sprite get_iconSprite() { }

	// RVA: 0xA17C70 Offset: 0xA17070 VA: 0x180A17C70
	internal bool get_isLoadingIconSprite() { }

	// RVA: 0xA178A0 Offset: 0xA16CA0 VA: 0x180A178A0
	public BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0xA16940 Offset: 0xA15D40 VA: 0x180A16940 Slot: 6
	public virtual Item Save(bool bIncludeContainer = False, bool bIncludeOwners = True) { }

	// RVA: 0xA16230 Offset: 0xA15630 VA: 0x180A16230 Slot: 7
	public virtual void Load(Item load) { }

	// RVA: 0xA177E0 Offset: 0xA16BE0 VA: 0x180A177E0
	public void .ctor() { }

	// RVA: 0xA176F0 Offset: 0xA16AF0 VA: 0x180A176F0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA16FE0 Offset: 0xA163E0 VA: 0x180A16FE0
	private bool <get_iconSprite>b__95_0(ItemSkinDirectory.Skin x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA16FE0 Offset: 0xA163E0 VA: 0x180A16FE0
	private bool <get_isLoadingIconSprite>b__97_0(ItemSkinDirectory.Skin x) { }

}

public enum Item.Flag // TypeDefIndex: 10106
{	// Fields
	public int value__; // 0x0
	public const Item.Flag None = 0;
	public const Item.Flag Placeholder = 1;
	public const Item.Flag IsOn = 2;
	public const Item.Flag OnFire = 4;
	public const Item.Flag IsLocked = 8;
	public const Item.Flag Cooking = 16;

}

private sealed class Item.<>c // TypeDefIndex: 10107
{	// Fields
	public static readonly Item.<>c <>9; // 0x21F5

	// Methods

	// RVA: 0xA19DC0 Offset: 0xA191C0 VA: 0x180A19DC0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA18BD0 Offset: 0xA17FD0 VA: 0x180A18BD0
	internal string <.cctor>b__103_0(ValueTuple<ItemDefinition.AmountType, int> t) { }

}

public sealed class ItemContainer // TypeDefIndex: 10110
{	// Fields
	public ItemContainer.Flag flags; // 0x10
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

	// Properties
	public bool HasLimitedAllowedItems { get; }

	// Methods

	// RVA: 0xA06F30 Offset: 0xA06330 VA: 0x180A06F30
	public bool HasFlag(ItemContainer.Flag f) { }

	// RVA: 0xA07FE0 Offset: 0xA073E0 VA: 0x180A07FE0
	public void SetFlag(ItemContainer.Flag f, bool b) { }

	// RVA: 0xA07100 Offset: 0xA06500 VA: 0x180A07100
	public bool IsLocked() { }

	// RVA: 0xA07C20 Offset: 0xA07020 VA: 0x180A07C20
	public bool PlayerItemInputBlocked() { }

	// RVA: 0xA083D0 Offset: 0xA077D0 VA: 0x180A083D0
	public bool get_HasLimitedAllowedItems() { }

	// RVA: 0xA07B80 Offset: 0xA06F80 VA: 0x180A07B80
	public void OnChanged() { }

	// RVA: 0xA06060 Offset: 0xA05460 VA: 0x180A06060
	public void ClientInitialize(Item parentItem, int iMaxCapacity) { }

	// RVA: 0xA06610 Offset: 0xA05A10 VA: 0x180A06610
	public Item FindItemByUID(uint iUID) { }

	// RVA: 0xA070B0 Offset: 0xA064B0 VA: 0x180A070B0
	public bool IsFull() { }

	// RVA: 0xA07070 Offset: 0xA06470 VA: 0x180A07070
	public bool IsEmpty() { }

	// RVA: 0xA05F30 Offset: 0xA05330 VA: 0x180A05F30
	public bool CanAccept(Item item) { }

	// RVA: 0xA06BD0 Offset: 0xA05FD0 VA: 0x180A06BD0
	public int GetMaxTransferAmount(ItemDefinition def) { }

	// RVA: 0xA08000 Offset: 0xA07400 VA: 0x180A08000
	public void SetOnlyAllowedItem(ItemDefinition def) { }

	// RVA: 0xA080C0 Offset: 0xA074C0 VA: 0x180A080C0
	public void SetOnlyAllowedItems(ItemDefinition[] defs) { }

	// RVA: 0xA06F40 Offset: 0xA06340 VA: 0x180A06F40
	internal bool Insert(Item item) { }

	// RVA: 0xA08250 Offset: 0xA07650 VA: 0x180A08250
	public bool SlotTaken(Item item, int i) { }

	// RVA: 0xA06D90 Offset: 0xA06190 VA: 0x180A06D90
	public Item GetSlot(int slot) { }

	// RVA: 0xA06900 Offset: 0xA05D00 VA: 0x180A06900
	internal bool FindPosition(Item item) { }

	// RVA: 0xA05F80 Offset: 0xA05380 VA: 0x180A05F80
	internal void Clear() { }

	// RVA: 0xA07110 Offset: 0xA06510 VA: 0x180A07110
	public void Kill() { }

	// RVA: 0xA06A50 Offset: 0xA05E50 VA: 0x180A06A50
	public int GetAmount(int itemid, bool onlyUsableAmounts) { }

	// RVA: 0xA064A0 Offset: 0xA058A0 VA: 0x180A064A0
	public Item FindItemByItemID(int itemid) { }

	// RVA: 0xA067B0 Offset: 0xA05BB0 VA: 0x180A067B0
	public Item FindItemsByItemName(string name) { }

	// RVA: 0xA06240 Offset: 0xA05640 VA: 0x180A06240
	public Item FindBySubEntityID(uint subEntityID) { }

	// RVA: 0xA06700 Offset: 0xA05B00 VA: 0x180A06700
	public List<Item> FindItemsByItemID(int itemid) { }

	// RVA: 0xA07C30 Offset: 0xA07030 VA: 0x180A07C30
	public ItemContainer Save() { }

	// RVA: 0xA073D0 Offset: 0xA067D0 VA: 0x180A073D0
	public void Load(ItemContainer container) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0xA060A0 Offset: 0xA054A0 VA: 0x180A060A0
	public int ContainerMaxStackSize() { }

	// RVA: 0xA06180 Offset: 0xA05580 VA: 0x180A06180
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xA06E60 Offset: 0xA06260 VA: 0x180A06E60
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xA06990 Offset: 0xA05D90 VA: 0x180A06990
	public int GetAmmoAmount(AmmoTypes ammoType) { }

	// RVA: 0xA08270 Offset: 0xA07670 VA: 0x180A08270
	public int TotalItemAmount() { }

	// RVA: 0xA060B0 Offset: 0xA054B0 VA: 0x180A060B0
	public uint ContentsHash() { }

	// RVA: 0xA063B0 Offset: 0xA057B0 VA: 0x180A063B0
	internal ItemContainer FindContainer(uint id) { }

	// RVA: 0xA05AC0 Offset: 0xA04EC0 VA: 0x180A05AC0
	public ItemContainer.CanAcceptResult CanAcceptItem(Item item, int targetPos) { }

	// RVA: 0xA08320 Offset: 0xA07720 VA: 0x180A08320
	public void .ctor() { }

}

public enum ItemContainer.Flag // TypeDefIndex: 10111
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const ItemContainer.ContentsType Generic = 1;
	public const ItemContainer.ContentsType Liquid = 2;

}

public enum ItemContainer.CanAcceptResult // TypeDefIndex: 10113
{	// Fields
	public int value__; // 0x0
	public const ItemContainer.CanAcceptResult CanAccept = 0;
	public const ItemContainer.CanAcceptResult CannotAccept = 1;
	public const ItemContainer.CanAcceptResult CannotAcceptRightNow = 2;

}

private sealed class ItemContainer.<>c__DisplayClass41_0 // TypeDefIndex: 10114
{	// Fields
	public int itemid; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA18F00 Offset: 0xA18300 VA: 0x180A18F00
	internal bool <FindItemsByItemID>b__0(Item x) { }

}

public class ItemBlueprint : MonoBehaviour // TypeDefIndex: 10115
{	// Fields
	public List<ItemAmount> ingredients; // 0x18
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

	// Properties
	public ItemDefinition targetItem { get; }
	public bool NeedsSteamDLC { get; }

	// Methods

	// RVA: 0xA057B0 Offset: 0xA04BB0 VA: 0x180A057B0
	public ItemDefinition get_targetItem() { }

	// RVA: 0xA05720 Offset: 0xA04B20 VA: 0x180A05720
	public bool get_NeedsSteamDLC() { }

	// RVA: 0xA05200 Offset: 0xA04600 VA: 0x180A05200
	public string GetIngredientString(bool colorMissing) { }

	// RVA: 0xA05660 Offset: 0xA04A60 VA: 0x180A05660
	public void .ctor() { }

}

public class ItemDefinition : MonoBehaviour // TypeDefIndex: 10116
{	// Fields
	[HeaderAttribute] // RVA: 0xB6670 Offset: 0xB5A70 VA: 0x1800B6670
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

	// Properties
	public IPlayerItemDefinition[] skins2 { get; }
	public ItemBlueprint Blueprint { get; }
	public int craftingStackable { get; }
	public bool isWearable { get; }
	public ItemModWearable ItemModWearable { get; set; }
	public bool isHoldable { get; set; }
	public bool isUsable { get; set; }
	public bool HasSkins { get; }
	public bool CraftableWithSkin { get; set; }

	// Methods

	// RVA: 0xA095F0 Offset: 0xA089F0 VA: 0x180A095F0
	public IPlayerItemDefinition[] get_skins2() { }

	// RVA: 0xA09340 Offset: 0xA08740 VA: 0x180A09340
	public void InvalidateWorkshopSkinCache() { }

	// RVA: 0xA09450 Offset: 0xA08850 VA: 0x180A09450
	public ItemBlueprint get_Blueprint() { }

	// RVA: 0xA09510 Offset: 0xA08910 VA: 0x180A09510
	public int get_craftingStackable() { }

	// RVA: 0xA090C0 Offset: 0xA084C0 VA: 0x180A090C0
	public bool HasFlag(ItemDefinition.Flag f) { }

	// RVA: 0xA090D0 Offset: 0xA084D0 VA: 0x180A090D0
	public void Initialize(List<ItemDefinition> itemList) { }

	// RVA: 0xA08FC0 Offset: 0xA083C0 VA: 0x180A08FC0 Slot: 4
	public virtual string GetDisplayName(Item item) { }

	// RVA: 0xA08EF0 Offset: 0xA082F0 VA: 0x180A08EF0 Slot: 5
	public virtual string GetDescriptionText(Item item) { }

	// RVA: 0xA08F80 Offset: 0xA08380 VA: 0x180A08F80 Slot: 6
	public virtual string GetDescriptionText() { }

	// RVA: 0xA08B90 Offset: 0xA07F90 VA: 0x180A08B90
	public Sprite FindIconSprite(int skinid) { }

	// RVA: 0xA09590 Offset: 0xA08990 VA: 0x180A09590
	public bool get_isWearable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA09500 Offset: 0xA08900 VA: 0x180A09500
	public ItemModWearable get_ItemModWearable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA09800 Offset: 0xA08C00 VA: 0x180A09800
	private void set_ItemModWearable(ItemModWearable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA09570 Offset: 0xA08970 VA: 0x180A09570
	public bool get_isHoldable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA09810 Offset: 0xA08C10 VA: 0x180A09810
	private void set_isHoldable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA09580 Offset: 0xA08980 VA: 0x180A09580
	public bool get_isUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA09820 Offset: 0xA08C20 VA: 0x180A09820
	private void set_isUsable(bool value) { }

	// RVA: 0xA094A0 Offset: 0xA088A0 VA: 0x180A094A0
	public bool get_HasSkins() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA09490 Offset: 0xA08890 VA: 0x180A09490
	public bool get_CraftableWithSkin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA097F0 Offset: 0xA08BF0 VA: 0x180A097F0
	private void set_CraftableWithSkin(bool value) { }

	// RVA: 0xA093E0 Offset: 0xA087E0 VA: 0x180A093E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA09360 Offset: 0xA08760 VA: 0x180A09360
	private bool <Initialize>b__45_0(ItemDefinition x) { }

}

public struct ItemDefinition.Condition // TypeDefIndex: 10117
{	// Fields
	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0xB8E30 Offset: 0xB8230 VA: 0x1800B8E30
	public float max; // 0x4
	[TooltipAttribute] // RVA: 0xB8F40 Offset: 0xB8340 VA: 0x1800B8F40
	public bool repairable; // 0x8
	[TooltipAttribute] // RVA: 0xB8FF0 Offset: 0xB83F0 VA: 0x1800B8FF0
	public bool maintainMaxCondition; // 0x9
	public ItemDefinition.Condition.WorldSpawnCondition foundCondition; // 0x10

}

public class ItemDefinition.Condition.WorldSpawnCondition // TypeDefIndex: 10118
{	// Fields
	public float fractionMin; // 0x10
	public float fractionMax; // 0x14

	// Methods

	// RVA: 0xA1A110 Offset: 0xA19510 VA: 0x180A1A110
	public void .ctor() { }

}

public enum ItemDefinition.RedirectVendingBehaviour // TypeDefIndex: 10119
{	// Fields
	public int value__; // 0x0
	public const ItemDefinition.RedirectVendingBehaviour NoListing = 0;
	public const ItemDefinition.RedirectVendingBehaviour ListAsUniqueItem = 1;

}

public enum ItemDefinition.Flag // TypeDefIndex: 10120
{	// Fields
	public int value__; // 0x0
	public const ItemDefinition.Flag NoDropping = 1;
	public const ItemDefinition.Flag NotStraightToBelt = 2;

}

public enum ItemDefinition.AmountType // TypeDefIndex: 10121
{	// Fields
	public int value__; // 0x0
	public const ItemDefinition.AmountType Count = 0;
	public const ItemDefinition.AmountType Millilitre = 1;
	public const ItemDefinition.AmountType Feet = 2;
	public const ItemDefinition.AmountType Genetics = 3;
	public const ItemDefinition.AmountType OxygenSeconds = 4;
	public const ItemDefinition.AmountType Frequency = 5;
	public const ItemDefinition.AmountType Generic = 6;

}

private sealed class ItemDefinition.<>c__DisplayClass35_0 // TypeDefIndex: 10122
{	// Fields
	public string prefabname; // 0x10
	public ItemDefinition <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA18E30 Offset: 0xA18230 VA: 0x180A18E30
	internal bool <get_skins2>b__0(IPlayerItemDefinition x) { }

}

public enum ItemCategory // TypeDefIndex: 10123
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const ItemSlot None = 1;
	public const ItemSlot Barrel = 2;
	public const ItemSlot Silencer = 4;
	public const ItemSlot Scope = 8;
	public const ItemSlot UnderBarrel = 16;
	public const ItemSlot Magazine = 32;

}

public enum ItemSelectionPanel // TypeDefIndex: 10125
{	// Fields
	public int value__; // 0x0
	public const ItemSelectionPanel None = 0;
	public const ItemSelectionPanel Vessel = 1;
	public const ItemSelectionPanel Modifications = 2;
	public const ItemSelectionPanel GunInformation = 3;

}

public class ItemSelector : PropertyAttribute // TypeDefIndex: 10126
{	// Fields
	public ItemCategory category; // 0x10

	// Methods

	// RVA: 0x6AE400 Offset: 0x6AD800 VA: 0x1806AE400
	public void .ctor(ItemCategory category = 11) { }

}

public class ItemMod : MonoBehaviour // TypeDefIndex: 10127
{	// Fields
	protected ItemMod[] siblingMods; // 0x18

	// Methods

	// RVA: 0xA15570 Offset: 0xA14970 VA: 0x180A15570 Slot: 4
	public virtual void ModInit() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public virtual void OnChanged(Item item) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	public virtual void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 7
	public virtual bool BeltSelect(Item item, BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void CL_DoAction(Item item, BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void OnObjectSetup(Item item, GameObject obj) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 10
	public virtual int GetTotalUISlots(Item item) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 11
	public virtual int GetFilledUISlots(Item item) { }

	// RVA: 0xA154E0 Offset: 0xA148E0 VA: 0x180A154E0 Slot: 12
	public virtual bool CanDoAction(Item item, BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 13
	public virtual bool Passes(Item item) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 14
	public virtual void OnRemovedFromWorld(Item item) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 15
	public virtual void OnMovedToWorld(Item item) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModActionChange : ItemMod // TypeDefIndex: 10128
{	// Fields
	public ItemMod[] actions; // 0x20

	// Methods

	// RVA: 0xA108B0 Offset: 0xA0FCB0 VA: 0x180A108B0
	private void OnValidate() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModActionContainerChange : ItemMod // TypeDefIndex: 10129
{	// Fields
	public ItemMod[] actions; // 0x20

	// Methods

	// RVA: 0xA10930 Offset: 0xA0FD30 VA: 0x180A10930
	private void OnValidate() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModAlterCondition : ItemMod // TypeDefIndex: 10130
{	// Fields
	public float conditionChange; // 0x20

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModAnimalEquipment : ItemMod // TypeDefIndex: 10131
{	// Fields
	public BaseEntity.Flags WearableFlag; // 0x20
	public bool hideHair; // 0x24
	public ProtectionProperties animalProtection; // 0x28
	public ProtectionProperties riderProtection; // 0x30
	public int additionalInventorySlots; // 0x38
	public float speedModifier; // 0x3C
	public float staminaUseModifier; // 0x40
	public ItemModAnimalEquipment.SlotType slot; // 0x44

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public enum ItemModAnimalEquipment.SlotType // TypeDefIndex: 10132
{	// Fields
	public int value__; // 0x0
	public const ItemModAnimalEquipment.SlotType Basic = 0;
	public const ItemModAnimalEquipment.SlotType Armor = 1;
	public const ItemModAnimalEquipment.SlotType Saddle = 2;
	public const ItemModAnimalEquipment.SlotType Bit = 3;
	public const ItemModAnimalEquipment.SlotType Feet = 4;

}

public abstract class ItemModAssociatedEntity<T> : ItemMod // TypeDefIndex: 10133
{	// Fields
	public GameObjectRef entityPrefab; // 0x0

	// Properties
	protected virtual bool AllowNullParenting { get; }
	protected virtual bool AllowHeldEntityParenting { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual bool get_AllowNullParenting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	|-ItemModAssociatedEntity<PagerEntity>.get_AllowNullParenting
	|-ItemModAssociatedEntity<object>.get_AllowNullParenting
	*/

	// RVA: -1 Offset: -1 Slot: 17
	protected virtual bool get_AllowHeldEntityParenting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	|-ItemModAssociatedEntity<MobileInventoryEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<PagerEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<PaintedItemStorageEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<PhotoEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<SignContent>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<object>.get_AllowHeldEntityParenting
	*/

	// RVA: -1 Offset: -1
	public static T GetAssociatedEntity(Item item, bool isServer = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EE850 Offset: 0x17EDC50 VA: 0x1817EE850
	|-ItemModAssociatedEntity<MobileInventoryEntity>.GetAssociatedEntity
	|-ItemModAssociatedEntity<PagerEntity>.GetAssociatedEntity
	|-ItemModAssociatedEntity<PaintedItemStorageEntity>.GetAssociatedEntity
	|-ItemModAssociatedEntity<SignContent>.GetAssociatedEntity
	|-ItemModAssociatedEntity<object>.GetAssociatedEntity
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E0870 Offset: 0x15DFC70 VA: 0x1815E0870
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
{	// Methods

	// RVA: 0xA10C00 Offset: 0xA10000 VA: 0x180A10C00
	public void .ctor() { }

}

public class ItemModBlueprintCraft : ItemMod // TypeDefIndex: 10135
{	// Fields
	public GameObjectRef successEffect; // 0x20

	// Methods

	// RVA: 0xA10C10 Offset: 0xA10010 VA: 0x180A10C10 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModBurnable : ItemMod // TypeDefIndex: 10136
{	// Fields
	public float fuelAmount; // 0x20
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition byproductItem; // 0x28
	public int byproductAmount; // 0x30
	public float byproductChance; // 0x34

	// Methods

	// RVA: 0xA10E40 Offset: 0xA10240 VA: 0x180A10E40
	public void .ctor() { }

}

public class ItemModCassetteContainer : ItemModContainer // TypeDefIndex: 10137
{	// Fields
	public ItemDefinition[] CassetteItems; // 0x58

	// Methods

	// RVA: 0xA10C00 Offset: 0xA10000 VA: 0x180A10C00
	public void .ctor() { }

}

public class ItemModChildIO : ItemMod // TypeDefIndex: 10138
{	// Fields
	public GameObjectRef TargetChildIO; // 0x20

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModCompostable : MonoBehaviour // TypeDefIndex: 10139
{	// Fields
	public float TotalFertilizerProduced; // 0x18
	public float BaitValue; // 0x1C

	// Methods

	// RVA: 0xA10EA0 Offset: 0xA102A0 VA: 0x180A10EA0
	public void .ctor() { }

}

public class ItemModConditionContainerFlag : ItemMod // TypeDefIndex: 10140
{	// Fields
	public ItemContainer.Flag flag; // 0x20
	public bool requiredState; // 0x24

	// Methods

	// RVA: 0xA10EC0 Offset: 0xA102C0 VA: 0x180A10EC0 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModConditionHasCondition : ItemMod // TypeDefIndex: 10141
{	// Fields
	public float conditionTarget; // 0x20
	[TooltipAttribute] // RVA: 0xB9190 Offset: 0xB8590 VA: 0x1800B9190
	public float conditionFractionTarget; // 0x24
	public bool lessThan; // 0x28

	// Methods

	// RVA: 0xA10F10 Offset: 0xA10310 VA: 0x180A10F10 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0xA11020 Offset: 0xA10420 VA: 0x180A11020
	public void .ctor() { }

}

public class ItemModConditionHasContents : ItemMod // TypeDefIndex: 10142
{	// Fields
	[TooltipAttribute] // RVA: 0xB9520 Offset: 0xB8920 VA: 0x1800B9520
	public ItemDefinition itemDef; // 0x20
	public bool requiredState; // 0x28

	// Methods

	// RVA: 0xA11040 Offset: 0xA10440 VA: 0x180A11040 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA11150 Offset: 0xA10550 VA: 0x180A11150
	private bool <Passes>b__2_0(Item x) { }

}

public class ItemModConditionHasFlag : ItemMod // TypeDefIndex: 10143
{	// Fields
	public Item.Flag flag; // 0x20
	public bool requiredState; // 0x24

	// Methods

	// RVA: 0xA111D0 Offset: 0xA105D0 VA: 0x180A111D0 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModConditionInWater : ItemMod // TypeDefIndex: 10144
{	// Fields
	public bool requiredState; // 0x20

	// Methods

	// RVA: 0xA11200 Offset: 0xA10600 VA: 0x180A11200 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModConditionIsSleeping : ItemMod // TypeDefIndex: 10145
{	// Fields
	public bool requiredState; // 0x20

	// Methods

	// RVA: 0xA112B0 Offset: 0xA106B0 VA: 0x180A112B0 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModConsumable : MonoBehaviour // TypeDefIndex: 10146
{	// Fields
	public int amountToConsume; // 0x18
	public float conditionFractionToLose; // 0x1C
	public string achievementWhenEaten; // 0x20
	public List<ItemModConsumable.ConsumableEffect> effects; // 0x28
	public List<ModifierDefintion> modifiers; // 0x30

	// Methods

	// RVA: 0xA11360 Offset: 0xA10760 VA: 0x180A11360
	public float GetIfType(MetabolismAttribute.Type typeToPick) { }

	// RVA: 0xA11440 Offset: 0xA10840 VA: 0x180A11440
	public void .ctor() { }

}

public class ItemModConsumable.ConsumableEffect // TypeDefIndex: 10147
{	// Fields
	public MetabolismAttribute.Type type; // 0x10
	public float amount; // 0x14
	public float time; // 0x18
	public float onlyIfHealthLessThan; // 0x1C

	// Methods

	// RVA: 0xA01E00 Offset: 0xA01200 VA: 0x180A01E00
	public void .ctor() { }

}

public class ItemModConsume : ItemMod // TypeDefIndex: 10148
{	// Fields
	public GameObjectRef consumeEffect; // 0x20
	public string eatGesture; // 0x28
	[TooltipAttribute] // RVA: 0xB9870 Offset: 0xB8C70 VA: 0x1800B9870
	public ItemAmountRandom[] product; // 0x30
	public ItemModConsumable primaryConsumable; // 0x38

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public override void CL_DoAction(Item item, BasePlayer player) { }

	// RVA: 0xA11760 Offset: 0xA10B60 VA: 0x180A11760 Slot: 12
	public override bool CanDoAction(Item item, BasePlayer player) { }

	// RVA: 0xA11790 Offset: 0xA10B90 VA: 0x180A11790
	public void .ctor() { }

}

public class ItemModConsumeChance : ItemModConsume // TypeDefIndex: 10149
{	// Fields
	public float chanceForSecondaryConsume; // 0x40
	public GameObjectRef secondaryConsumeEffect; // 0x48
	public ItemModConsumable secondaryConsumable; // 0x50

	// Methods

	// RVA: 0xA114E0 Offset: 0xA108E0 VA: 0x180A114E0
	public void .ctor() { }

}

public class ItemModConsumeContents : ItemMod // TypeDefIndex: 10150
{	// Fields
	public GameObjectRef consumeEffect; // 0x20

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public override void CL_DoAction(Item item, BasePlayer player) { }

	// RVA: 0xA11530 Offset: 0xA10930 VA: 0x180A11530 Slot: 12
	public override bool CanDoAction(Item item, BasePlayer player) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModContainer : ItemMod // TypeDefIndex: 10151
{	// Fields
	public int capacity; // 0x20
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

	// Methods

	// RVA: 0xA118E0 Offset: 0xA10CE0 VA: 0x180A118E0 Slot: 10
	public override int GetTotalUISlots(Item item) { }

	// RVA: 0xA11870 Offset: 0xA10C70 VA: 0x180A11870 Slot: 11
	public override int GetFilledUISlots(Item item) { }

	// RVA: 0xA11920 Offset: 0xA10D20 VA: 0x180A11920
	public void .ctor() { }

}

public class ItemModContainerRestriction : ItemMod // TypeDefIndex: 10152
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public ItemModContainerRestriction.SlotFlags slotFlags; // 0x20

	// Methods

	// RVA: 0xA117E0 Offset: 0xA10BE0 VA: 0x180A117E0
	public bool CanExistWith(ItemModContainerRestriction other) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public enum ItemModContainerRestriction.SlotFlags // TypeDefIndex: 10153
{	// Fields
	public int value__; // 0x0
	public const ItemModContainerRestriction.SlotFlags Map = 1;

}

public class ItemModCookable : ItemMod // TypeDefIndex: 10154
{	// Fields
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition becomeOnCooked; // 0x20
	public float cookTime; // 0x28
	public int amountOfBecome; // 0x2C
	public int lowTemp; // 0x30
	public int highTemp; // 0x34
	public bool setCookingFlag; // 0x38

	// Methods

	// RVA: 0xA119F0 Offset: 0xA10DF0 VA: 0x180A119F0
	public void OnValidate() { }

	// RVA: 0xA11AD0 Offset: 0xA10ED0 VA: 0x180A11AD0
	public void .ctor() { }

}

public class ItemModCycle : ItemMod // TypeDefIndex: 10155
{	// Fields
	public ItemMod[] actions; // 0x20
	public float timeBetweenCycles; // 0x28
	public float timerStart; // 0x2C
	public bool onlyAdvanceTimerWhenPass; // 0x30

	// Methods

	// RVA: 0xA11C20 Offset: 0xA11020 VA: 0x180A11C20
	private void OnValidate() { }

	// RVA: 0xA11CA0 Offset: 0xA110A0 VA: 0x180A11CA0
	public void .ctor() { }

}

public class ItemModDeployable : MonoBehaviour // TypeDefIndex: 10156
{	// Fields
	public GameObjectRef entityPrefab; // 0x18
	[HeaderAttribute] // RVA: 0xB9BF0 Offset: 0xB8FF0 VA: 0x1800B9BF0
	public bool showCrosshair; // 0x20
	public string UnlockAchievement; // 0x28

	// Methods

	// RVA: 0xA11CB0 Offset: 0xA110B0 VA: 0x180A11CB0
	public Deployable GetDeployable(BaseEntity entity) { }

	// RVA: 0xA11DC0 Offset: 0xA111C0 VA: 0x180A11DC0
	public void .ctor() { }

}

public class ItemModEntity : ItemMod // TypeDefIndex: 10157
{	// Fields
	public GameObjectRef entityPrefab; // 0x20
	public string defaultBone; // 0x28

	// Methods

	// RVA: 0xA11E30 Offset: 0xA11230 VA: 0x180A11E30
	public void .ctor() { }

}

public class ItemModEntityReference : MonoBehaviour // TypeDefIndex: 10158
{	// Fields
	public GameObjectRef entityPrefab; // 0x18

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModFishable : ItemMod // TypeDefIndex: 10159
{	// Fields
	public bool CanBeFished; // 0x20
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

	// Methods

	// RVA: 0xA11EA0 Offset: 0xA112A0 VA: 0x180A11EA0
	public void .ctor() { }

}

public class ItemModGiveOxygen : ItemMod, IAirSupply // TypeDefIndex: 10161
{	// Fields
	public ItemModGiveOxygen.AirSupplyType airType; // 0x20
	public int amountToConsume; // 0x24
	public GameObjectRef inhaleEffect; // 0x28
	public GameObjectRef exhaleEffect; // 0x30
	public GameObjectRef bubblesEffect; // 0x38
	private float timeRemaining; // 0x40
	private float cycleTime; // 0x44

	// Properties
	public ItemModGiveOxygen.AirSupplyType AirType { get; }

	// Methods

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170 Slot: 16
	public ItemModGiveOxygen.AirSupplyType get_AirType() { }

	// RVA: 0x54D6A0 Offset: 0x54CAA0 VA: 0x18054D6A0 Slot: 17
	public float GetAirTimeRemaining() { }

	// RVA: 0xA11ED0 Offset: 0xA112D0 VA: 0x180A11ED0 Slot: 4
	public override void ModInit() { }

	// RVA: 0xA11FE0 Offset: 0xA113E0 VA: 0x180A11FE0 Slot: 5
	public override void OnChanged(Item item) { }

	// RVA: 0xA12040 Offset: 0xA11440 VA: 0x180A12040
	public void .ctor() { }

}

public enum ItemModGiveOxygen.AirSupplyType // TypeDefIndex: 10162
{	// Fields
	public int value__; // 0x0
	public const ItemModGiveOxygen.AirSupplyType Lungs = 0;
	public const ItemModGiveOxygen.AirSupplyType ScubaTank = 1;
	public const ItemModGiveOxygen.AirSupplyType Submarine = 2;

}

public class ItemModKeycard : ItemMod // TypeDefIndex: 10163
{	// Fields
	public int accessLevel; // 0x20

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModMenuOption : ItemMod // TypeDefIndex: 10164
{	// Fields
	public string commandName; // 0x20
	public ItemMod actionTarget; // 0x28
	public BaseEntity.Menu.Option option; // 0x30
	[TooltipAttribute] // RVA: 0xBB2E0 Offset: 0xBA6E0 VA: 0x1800BB2E0
	public bool isPrimaryOption; // 0x50

	// Methods

	// RVA: 0xA12150 Offset: 0xA11550 VA: 0x180A12150 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA12060 Offset: 0xA11460 VA: 0x180A12060 Slot: 7
	public override bool BeltSelect(Item item, BasePlayer player) { }

	// RVA: 0xA122C0 Offset: 0xA116C0 VA: 0x180A122C0
	private void OnValidate() { }

	// RVA: 0xA12450 Offset: 0xA11850 VA: 0x180A12450
	public void .ctor() { }

}

public class ItemModPaintable : ItemModAssociatedEntity<PaintedItemStorageEntity> // TypeDefIndex: 10165
{	// Fields
	public GameObjectRef ChangeSignTextDialog; // 0x28
	public MeshPaintableSource[] PaintableSources; // 0x30
	private EntityRef<PaintedItemStorageEntity> _paintStorage; // 0x38

	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA12AC0 Offset: 0xA11EC0 VA: 0x180A12AC0 Slot: 9
	public override void OnObjectSetup(Item item, GameObject obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB570 Offset: 0xBA970 VA: 0x1800BB570
	// RVA: 0xA12780 Offset: 0xA11B80 VA: 0x180A12780
	private IEnumerator DeferredSetup(Item item, PaintableItem paintable) { }

	// RVA: 0xA12820 Offset: 0xA11C20 VA: 0x180A12820 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA12D10 Offset: 0xA12110 VA: 0x180A12D10
	private void PaintClicked(BasePlayer player) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB6D0 Offset: 0xBAAD0 VA: 0x1800BB6D0
	// RVA: 0xA12C80 Offset: 0xA12080 VA: 0x180A12C80
	private IEnumerator OpenPaintUI(EntityRef<PaintedItemStorageEntity> paintStorage) { }

	// RVA: 0xA12DC0 Offset: 0xA121C0 VA: 0x180A12DC0
	public void .ctor() { }

}

private sealed class ItemModPaintable.<DeferredSetup>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10166
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Item item; // 0x20
	public PaintableItem paintable; // 0x28
	public ItemModPaintable <>4__this; // 0x30
	private int <count>5__2; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xA180D0 Offset: 0xA174D0 VA: 0x180A180D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA18250 Offset: 0xA17650 VA: 0x180A18250 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemModPaintable.<>c__DisplayClass9_0 // TypeDefIndex: 10167
{	// Fields
	public PaintedItemStorageEntity entity; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA19D30 Offset: 0xA19130 VA: 0x180A19D30
	internal void <OpenPaintUI>b__0(int frame, Texture2D texture) { }

}

private sealed class ItemModPaintable.<OpenPaintUI>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10168
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EntityRef<PaintedItemStorageEntity> paintStorage; // 0x20
	public ItemModPaintable <>4__this; // 0x30
	private int <i>5__2; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xA182A0 Offset: 0xA176A0 VA: 0x180A182A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA18590 Offset: 0xA17990 VA: 0x180A18590 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class ItemModPetStats : ItemMod // TypeDefIndex: 10169
{	// Fields
	[TooltipAttribute] // RVA: 0xBC080 Offset: 0xBB480 VA: 0x1800BC080
	public float SpeedModifier; // 0x20
	[TooltipAttribute] // RVA: 0xBC120 Offset: 0xBB520 VA: 0x1800BC120
	public float MaxHealthModifier; // 0x24
	[TooltipAttribute] // RVA: 0xBC340 Offset: 0xBB740 VA: 0x1800BC340
	public float AttackDamageModifier; // 0x28
	[TooltipAttribute] // RVA: 0xBC450 Offset: 0xBB850 VA: 0x1800BC450
	public float AttackRateModifier; // 0x2C

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModProjectile : MonoBehaviour // TypeDefIndex: 10170
{	// Fields
	public GameObjectRef projectileObject; // 0x18
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

	// Methods

	// RVA: 0xA12FF0 Offset: 0xA123F0 VA: 0x180A12FF0
	public float GetRandomVelocity() { }

	// RVA: 0xA13030 Offset: 0xA12430 VA: 0x180A13030
	public float GetSpreadScalar() { }

	// RVA: 0xA12F60 Offset: 0xA12360 VA: 0x180A12F60
	public float GetIndexedSpreadScalar(int shotIndex, int maxShots) { }

	// RVA: 0xA12F50 Offset: 0xA12350 VA: 0x180A12F50
	public float GetAverageVelocity() { }

	// RVA: 0xA12FE0 Offset: 0xA123E0 VA: 0x180A12FE0
	public float GetMinVelocity() { }

	// RVA: 0xA12FD0 Offset: 0xA123D0 VA: 0x180A12FD0
	public float GetMaxVelocity() { }

	// RVA: 0xA13090 Offset: 0xA12490 VA: 0x180A13090
	public bool IsAmmo(AmmoTypes ammo) { }

	// RVA: 0xA130A0 Offset: 0xA124A0 VA: 0x180A130A0 Slot: 4
	public virtual void ServerProjectileHit(HitInfo info) { }

	// RVA: 0xA13170 Offset: 0xA12570 VA: 0x180A13170
	public void .ctor() { }

}

public class ItemModProjectileMod : MonoBehaviour // TypeDefIndex: 10171
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public virtual void ServerProjectileHit(HitInfo info) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModProjectileRadialDamage : ItemModProjectileMod // TypeDefIndex: 10172
{	// Fields
	public float radius; // 0x18
	public DamageTypeEntry damage; // 0x20
	public GameObjectRef effect; // 0x28
	public bool ignoreHitObject; // 0x30

	// Methods

	// RVA: 0xA12E40 Offset: 0xA12240 VA: 0x180A12E40
	public void .ctor() { }

}

public class ItemModProjectileSpawn : ItemModProjectile // TypeDefIndex: 10173
{	// Fields
	public float createOnImpactChance; // 0x60
	public GameObjectRef createOnImpact; // 0x68
	public float spreadAngle; // 0x70
	public float spreadVelocityMin; // 0x74
	public float spreadVelocityMax; // 0x78
	public int numToCreateChances; // 0x7C

	// Methods

	// RVA: 0xA12E60 Offset: 0xA12260 VA: 0x180A12E60
	public void .ctor() { }

}

public class ItemModRecycleInto : ItemMod // TypeDefIndex: 10174
{	// Fields
	public ItemDefinition recycleIntoItem; // 0x20
	public int numRecycledItemMin; // 0x28
	public int numRecycledItemMax; // 0x2C
	public GameObjectRef successEffect; // 0x30

	// Methods

	// RVA: 0xA13870 Offset: 0xA12C70 VA: 0x180A13870 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA13980 Offset: 0xA12D80 VA: 0x180A13980
	public void .ctor() { }

}

public class ItemModRepair : ItemMod // TypeDefIndex: 10175
{	// Fields
	public float conditionLost; // 0x20
	public GameObjectRef successEffect; // 0x28
	public int workbenchLvlRequired; // 0x30

	// Methods

	// RVA: 0xA13BF0 Offset: 0xA12FF0 VA: 0x180A13BF0
	public bool HasCraftLevel(BasePlayer player) { }

	// RVA: 0xA139A0 Offset: 0xA12DA0 VA: 0x180A139A0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA13D00 Offset: 0xA13100 VA: 0x180A13D00
	public void .ctor() { }

}

public class ItemModReveal : ItemMod // TypeDefIndex: 10176
{	// Fields
	public int numForReveal; // 0x20
	public ItemDefinition revealedItemOverride; // 0x28
	public int revealedItemAmount; // 0x30
	public LootSpawn revealList; // 0x38
	public GameObjectRef successEffect; // 0x40

	// Methods

	// RVA: 0xA13D10 Offset: 0xA13110 VA: 0x180A13D10 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA13E50 Offset: 0xA13250 VA: 0x180A13E50
	public void .ctor() { }

}

public class ItemModSound : ItemMod // TypeDefIndex: 10177
{	// Fields
	public GameObjectRef effect; // 0x20
	public ItemModSound.Type actionType; // 0x28

	// Methods

	// RVA: 0xA13EB0 Offset: 0xA132B0 VA: 0x180A13EB0
	public void .ctor() { }

}

public enum ItemModSound.Type // TypeDefIndex: 10178
{	// Fields
	public int value__; // 0x0
	public const ItemModSound.Type OnAttachToWeapon = 0;

}

public class ItemModStudyBlueprint : ItemMod // TypeDefIndex: 10179
{	// Fields
	public GameObjectRef studyEffect; // 0x20

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModSummerSunglassesEquip : ItemMod // TypeDefIndex: 10180
{	// Fields
	public float SunsetTime; // 0x20
	public float SunriseTime; // 0x24
	public string AchivementName; // 0x28

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModSwap : ItemMod // TypeDefIndex: 10181
{	// Fields
	public GameObjectRef actionEffect; // 0x20
	public ItemAmount[] becomeItem; // 0x28
	public bool sendPlayerPickupNotification; // 0x30
	public bool sendPlayerDropNotification; // 0x31
	public float xpScale; // 0x34
	public ItemAmount[] RandomOptions; // 0x38

	// Methods

	// RVA: 0xA13F20 Offset: 0xA13320 VA: 0x180A13F20
	public void .ctor() { }

}

public class ItemModSwitchFlag : ItemMod // TypeDefIndex: 10182
{	// Fields
	public Item.Flag flag; // 0x20
	public bool state; // 0x24

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemModUpgrade : ItemMod // TypeDefIndex: 10183
{	// Fields
	public int numForUpgrade; // 0x20
	public float upgradeSuccessChance; // 0x24
	public int numToLoseOnFail; // 0x28
	public ItemDefinition upgradedItem; // 0x30
	public int numUpgradedItem; // 0x38
	public GameObjectRef successEffect; // 0x40
	public GameObjectRef failEffect; // 0x48

	// Methods

	// RVA: 0xA14040 Offset: 0xA13440 VA: 0x180A14040 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA14180 Offset: 0xA13580 VA: 0x180A14180
	public void .ctor() { }

}

public class ItemModUseContent : ItemMod // TypeDefIndex: 10184
{	// Fields
	public int amountToConsume; // 0x20

	// Methods

	// RVA: 0x7EEDC0 Offset: 0x7EE1C0 VA: 0x1807EEDC0
	public void .ctor() { }

}

public class ItemModWearable : ItemMod // TypeDefIndex: 10185
{	// Fields
	public GameObjectRef entityPrefab; // 0x20
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

	// Properties
	public Wearable targetWearable { get; }

	// Methods

	// RVA: 0xA15220 Offset: 0xA14620 VA: 0x180A15220
	public Wearable get_targetWearable() { }

	// RVA: 0xA14380 Offset: 0xA13780 VA: 0x180A14380
	private void DoPrepare() { }

	// RVA: 0xA147A0 Offset: 0xA13BA0 VA: 0x180A147A0 Slot: 4
	public override void ModInit() { }

	// RVA: 0xA150C0 Offset: 0xA144C0 VA: 0x180A150C0
	public bool ProtectsArea(HitArea area) { }

	// RVA: 0xA145F0 Offset: 0xA139F0 VA: 0x180A145F0
	public bool HasProtections() { }

	// RVA: 0xA14500 Offset: 0xA13900 VA: 0x180A14500
	internal float GetProtection(Item item, DamageType damageType) { }

	// RVA: 0xA14330 Offset: 0xA13730 VA: 0x180A14330
	public float ConditionProtectionScale(Item item) { }

	// RVA: 0xA14260 Offset: 0xA13660 VA: 0x180A14260
	public void CollectProtection(Item item, ProtectionProperties protection) { }

	// RVA: 0xA14700 Offset: 0xA13B00 VA: 0x180A14700
	private bool IsHeadgear() { }

	// RVA: 0xA14650 Offset: 0xA13A50 VA: 0x180A14650
	public bool IsFootwear() { }

	// RVA: 0xA14850 Offset: 0xA13C50 VA: 0x180A14850
	public void OnDressModel(Item item, PlayerModel model) { }

	// RVA: 0xA14EB0 Offset: 0xA142B0 VA: 0x180A14EB0 Slot: 9
	public override void OnObjectSetup(Item item, GameObject obj) { }

	// RVA: 0xA141B0 Offset: 0xA135B0 VA: 0x180A141B0
	public bool CanExistWith(ItemModWearable wearable) { }

	// RVA: 0xA15160 Offset: 0xA14560 VA: 0x180A15160
	public void .ctor() { }

}

private sealed class ItemModWearable.<>c__DisplayClass28_0 // TypeDefIndex: 10186
{	// Fields
	public Item item; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7CFE70 Offset: 0x7CF270 VA: 0x1807CFE70
	internal bool <OnObjectSetup>b__0(ItemSkinDirectory.Skin x) { }

}

public class ItemModXPWhenUsed : ItemMod // TypeDefIndex: 10187
{	// Fields
	public float xpPerUnit; // 0x20
	public int unitSize; // 0x24

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void GiveConsumeXP(Item item) { }

	// RVA: 0x4BB380 Offset: 0x4BA780 VA: 0x1804BB380
	public void .ctor() { }

}

public class ItemFootstepSounds : MonoBehaviour // TypeDefIndex: 10188
{	// Fields
	public string effectFolder; // 0x18

	// Methods

	// RVA: 0xA09B70 Offset: 0xA08F70 VA: 0x180A09B70
	public void .ctor() { }

}

public class ItemAmount : ISerializationCallbackReceiver // TypeDefIndex: 10189
{	// Fields
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition itemDef; // 0x10
	public float amount; // 0x18
	public float startAmount; // 0x1C

	// Properties
	public int itemid { get; }

	// Methods

	// RVA: 0xA04BC0 Offset: 0xA03FC0 VA: 0x180A04BC0
	public void .ctor(ItemDefinition item, float amt = 0) { }

	// RVA: 0xA04C10 Offset: 0xA04010 VA: 0x180A04C10
	public int get_itemid() { }

	// RVA: 0x772410 Offset: 0x771810 VA: 0x180772410 Slot: 6
	public virtual float GetAmount() { }

	// RVA: 0xA04950 Offset: 0xA03D50 VA: 0x180A04950 Slot: 7
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void OnBeforeSerialize() { }

	// RVA: 0xA04960 Offset: 0xA03D60 VA: 0x180A04960
	public static ItemAmountList SerialiseList(List<ItemAmount> list) { }

	// RVA: 0xA04770 Offset: 0xA03B70 VA: 0x180A04770
	public static void DeserialiseList(List<ItemAmount> target, ItemAmountList source) { }

}

public class ItemAmountRandom // TypeDefIndex: 10190
{	// Fields
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition itemDef; // 0x10
	public AnimationCurve amount; // 0x18

	// Methods

	// RVA: 0xA044E0 Offset: 0xA038E0 VA: 0x180A044E0
	public int RandomAmount() { }

	// RVA: 0xA04570 Offset: 0xA03970 VA: 0x180A04570
	public void .ctor() { }

}

public class ItemAmountRanged : ItemAmount // TypeDefIndex: 10191
{	// Fields
	public float maxAmount; // 0x20

	// Methods

	// RVA: 0xA046F0 Offset: 0xA03AF0 VA: 0x180A046F0 Slot: 7
	public override void OnAfterDeserialize() { }

	// RVA: 0xA04700 Offset: 0xA03B00 VA: 0x180A04700
	public void .ctor(ItemDefinition item, float amt = 0, float max = -1) { }

	// RVA: 0xA046C0 Offset: 0xA03AC0 VA: 0x180A046C0 Slot: 6
	public override float GetAmount() { }

}

public class ItemManager // TypeDefIndex: 10192
{	// Fields
	public static List<ItemDefinition> itemList; // 0x0
	public static Dictionary<int, ItemDefinition> itemDictionary; // 0x8
	public static Dictionary<string, ItemDefinition> itemDictionaryByName; // 0x10
	public static List<ItemBlueprint> bpList; // 0x18
	public static int[] defaultBlueprints; // 0x20
	public static ItemDefinition blueprintBaseDef; // 0x28

	// Methods

	// RVA: 0xA105D0 Offset: 0xA0F9D0 VA: 0x180A105D0
	public static void InvalidateWorkshopSkinCache() { }

	// RVA: 0xA0F620 Offset: 0xA0EA20 VA: 0x180A0F620
	public static void Initialize() { }

	// RVA: 0x534EF0 Offset: 0x5342F0 VA: 0x180534EF0
	public static void UpdateUnlockedSkins() { }

	// RVA: 0xA106F0 Offset: 0xA0FAF0 VA: 0x180A106F0
	public static Item Load(Item load, Item created, bool isServer) { }

	// RVA: 0xA0F4A0 Offset: 0xA0E8A0 VA: 0x180A0F4A0
	public static ItemDefinition FindItemDefinition(int itemID) { }

	// RVA: 0xA0F520 Offset: 0xA0E920 VA: 0x180A0F520
	public static ItemDefinition FindItemDefinition(string shortName) { }

	// RVA: 0xA0F450 Offset: 0xA0E850 VA: 0x180A0F450
	public static ItemBlueprint FindBlueprint(ItemDefinition item) { }

	// RVA: 0xA0F5E0 Offset: 0xA0E9E0 VA: 0x180A0F5E0
	public static List<ItemDefinition> GetItemDefinitions() { }

	// RVA: 0xA0F5A0 Offset: 0xA0E9A0 VA: 0x180A0F5A0
	public static List<ItemBlueprint> GetBlueprints() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class ItemManager.<>c // TypeDefIndex: 10193
{	// Fields
	public static readonly ItemManager.<>c <>9; // 0x0
	public static Func<GameObject, ItemDefinition> <>9__7_0; // 0x8
	public static Func<ItemDefinition, bool> <>9__7_1; // 0x10
	public static Func<GameObject, ItemBlueprint> <>9__7_2; // 0x18
	public static Func<ItemBlueprint, bool> <>9__7_3; // 0x20
	public static Func<ItemBlueprint, bool> <>9__7_4; // 0x28
	public static Func<ItemBlueprint, int> <>9__7_5; // 0x30

	// Methods

	// RVA: 0xA19E80 Offset: 0xA19280 VA: 0x180A19E80
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA188E0 Offset: 0xA17CE0 VA: 0x180A188E0
	internal ItemDefinition <Initialize>b__7_0(GameObject x) { }

	// RVA: 0xA18930 Offset: 0xA17D30 VA: 0x180A18930
	internal bool <Initialize>b__7_1(ItemDefinition x) { }

	// RVA: 0xA18990 Offset: 0xA17D90 VA: 0x180A18990
	internal ItemBlueprint <Initialize>b__7_2(GameObject x) { }

	// RVA: 0xA189E0 Offset: 0xA17DE0 VA: 0x180A189E0
	internal bool <Initialize>b__7_3(ItemBlueprint x) { }

	// RVA: 0xA18A50 Offset: 0xA17E50 VA: 0x180A18A50
	internal bool <Initialize>b__7_4(ItemBlueprint x) { }

	// RVA: 0xA18B10 Offset: 0xA17F10 VA: 0x180A18B10
	internal int <Initialize>b__7_5(ItemBlueprint x) { }

}

public class ItemSkin : SteamInventoryItem // TypeDefIndex: 10737
{	// Fields
	public Skinnable Skinnable; // 0x70
	public Material[] Materials; // 0x78
	[TooltipAttribute] // RVA: 0x77010 Offset: 0x76410 VA: 0x180077010
	public ItemDefinition Redirect; // 0x80
	public SteamInventoryItem UnlockedViaSteamItem; // 0x88

	// Methods

	// RVA: 0x6AE790 Offset: 0x6ADB90 VA: 0x1806AE790
	public void ApplySkin(GameObject obj) { }

	// RVA: 0x6AE820 Offset: 0x6ADC20 VA: 0x1806AE820 Slot: 4
	public override bool HasUnlocked(ulong playerId) { }

	// RVA: 0x6AEC00 Offset: 0x6AE000 VA: 0x1806AEC00
	public void .ctor() { }

}

public class ItemSkinDirectory : ScriptableObject // TypeDefIndex: 10738
{	// Fields
	private static ItemSkinDirectory _Instance; // 0x0
	public ItemSkinDirectory.Skin[] skins; // 0x18

	// Properties
	public static ItemSkinDirectory Instance { get; }

	// Methods

	// RVA: 0x6AE5F0 Offset: 0x6AD9F0 VA: 0x1806AE5F0
	public static ItemSkinDirectory get_Instance() { }

	// RVA: 0x6AE520 Offset: 0x6AD920 VA: 0x1806AE520
	public static ItemSkinDirectory.Skin[] ForItem(ItemDefinition item) { }

	// RVA: 0x6AE430 Offset: 0x6AD830 VA: 0x1806AE430
	public static ItemSkinDirectory.Skin FindByInventoryDefinitionId(int id) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public struct ItemSkinDirectory.Skin // TypeDefIndex: 10739
{	// Fields
	public int id; // 0x0
	public int itemid; // 0x4
	public string name; // 0x8
	public bool isSkin; // 0x10
	private SteamInventoryItem _invItem; // 0x18

	// Properties
	public SteamInventoryItem invItem { get; }

	// Methods

	// RVA: 0xF3AF0 Offset: 0xF2EF0 VA: 0x1800F3AF0
	public SteamInventoryItem get_invItem() { }

}

private sealed class ItemSkinDirectory.<>c__DisplayClass5_0 // TypeDefIndex: 10740
{	// Fields
	public ItemDefinition item; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6C6590 Offset: 0x6C5990 VA: 0x1806C6590
	internal bool <ForItem>b__0(ItemSkinDirectory.Skin x) { }

}

private sealed class ItemSkinDirectory.<>c__DisplayClass6_0 // TypeDefIndex: 10741
{	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0A30 Offset: 0x4AFE30 VA: 0x1804B0A30
	internal bool <FindByInventoryDefinitionId>b__0(ItemSkinDirectory.Skin x) { }

}

public abstract class ItemContainerSource : MonoBehaviour // TypeDefIndex: 10851
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ItemContainer GetItemContainer();

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

public class ItemDropCommand : MonoBehaviour // TypeDefIndex: 11007
{	// Fields
	public string command; // 0x18

	// Methods

	// RVA: 0xA09830 Offset: 0xA08C30 VA: 0x180A09830
	private void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	// RVA: 0xA09A30 Offset: 0xA08E30 VA: 0x180A09A30
	public void .ctor() { }

}

public class ItemIcon : BaseMonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IDraggable, IInventoryChanged, IItemAmountChanged, IItemIconChanged // TypeDefIndex: 11008
{	// Fields
	public static Color defaultBackgroundColor; // 0x0
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

	// Properties
	private Item iconValue { get; }

	// Methods

	// RVA: 0xA09BC0 Offset: 0xA08FC0 VA: 0x180A09BC0
	protected void Awake() { }

	// RVA: 0xA0B3E0 Offset: 0xA0A7E0 VA: 0x180A0B3E0
	protected void OnEnable() { }

	// RVA: 0xA09DF0 Offset: 0xA091F0 VA: 0x180A09DF0
	public static void ClearLootTimers() { }

	// RVA: 0xA09ED0 Offset: 0xA092D0 VA: 0x180A09ED0
	public void ClearProgressImage() { }

	// RVA: 0xA0AE30 Offset: 0xA0A230 VA: 0x180A0AE30
	protected void OnDisable() { }

	// RVA: 0xA0C4E0 Offset: 0xA0B8E0 VA: 0x180A0C4E0
	public void OnShow() { }

	// RVA: 0xA0B600 Offset: 0xA0AA00 VA: 0x180A0B600
	public void OnHide() { }

	// RVA: 0xA09EB0 Offset: 0xA092B0 VA: 0x180A09EB0
	public void ClearLooting() { }

	// RVA: 0xA0E0A0 Offset: 0xA0D4A0 VA: 0x180A0E0A0
	private void Update() { }

	// RVA: 0xA0A7A0 Offset: 0xA09BA0 VA: 0x180A0A7A0
	public Sprite GetItemSprite(out Color tint) { }

	// RVA: 0xA0BE10 Offset: 0xA0B210 VA: 0x180A0BE10 Slot: 13
	public void OnItemAmountChanged() { }

	// RVA: 0xA0BE50 Offset: 0xA0B250 VA: 0x180A0BE50 Slot: 14
	public void OnItemIconChanged() { }

	// RVA: 0xA0B6A0 Offset: 0xA0AAA0 VA: 0x180A0B6A0 Slot: 12
	public void OnInventoryChanged() { }

	// RVA: 0xA0DBE0 Offset: 0xA0CFE0 VA: 0x180A0DBE0
	private void UpdateHoverText() { }

	// RVA: 0xA0DDA0 Offset: 0xA0D1A0 VA: 0x180A0DDA0
	private void UpdateItemIcon() { }

	// RVA: 0xA0C7B0 Offset: 0xA0BBB0 VA: 0x180A0C7B0
	private void SetBackgroundUnderlayVisible(bool flag) { }

	// RVA: 0xA0DAD0 Offset: 0xA0CED0 VA: 0x180A0DAD0
	private void UpdateCornerIcon() { }

	// RVA: 0xA0DDE0 Offset: 0xA0D1E0 VA: 0x180A0DDE0
	private void UpdateSlots() { }

	// RVA: 0xA0E270 Offset: 0xA0D670 VA: 0x180A0E270
	private Item get_iconValue() { }

	// RVA: 0xA0C6D0 Offset: 0xA0BAD0 VA: 0x180A0C6D0
	public void Select() { }

	// RVA: 0xA0C6C0 Offset: 0xA0BAC0 VA: 0x180A0C6C0
	public void SelectSilent() { }

	// RVA: 0xA0ACE0 Offset: 0xA0A0E0 VA: 0x180A0ACE0
	private void InternalSelect(bool silent = False) { }

	// RVA: 0xA0A1D0 Offset: 0xA095D0 VA: 0x180A0A1D0
	public void Deselect() { }

	// RVA: 0xA0C6E0 Offset: 0xA0BAE0 VA: 0x180A0C6E0
	public void SetActive(bool active) { }

	// RVA: 0xA0AFC0 Offset: 0xA0A3C0 VA: 0x180A0AFC0 Slot: 15
	public virtual void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	// RVA: 0xA0CC60 Offset: 0xA0C060 VA: 0x180A0CC60
	private bool TryToDropInsideItem(ItemIcon.DragInfo dropInfo, Item item) { }

	// RVA: 0xA0C910 Offset: 0xA0BD10 VA: 0x180A0C910
	public void SetTimedLootAction(uint sourceContainer, Action action) { }

	// RVA: 0xA09C90 Offset: 0xA09090 VA: 0x180A09C90
	private float CalculateLootDelay(uint sourceContainer) { }

	[IteratorStateMachineAttribute] // RVA: 0x8E810 Offset: 0x8DC10 VA: 0x18008E810
	// RVA: 0xA0CBE0 Offset: 0xA0BFE0 VA: 0x180A0CBE0
	private IEnumerator StartTimedLootAction(float delay) { }

	// RVA: 0xA0C690 Offset: 0xA0BA90 VA: 0x180A0C690
	public void RunTimedAction() { }

	// RVA: 0xA09FA0 Offset: 0xA093A0 VA: 0x180A09FA0
	public void ClearTimedAction() { }

	// RVA: 0xA0C4F0 Offset: 0xA0B8F0 VA: 0x180A0C4F0
	private void RemoveFromLootQueue() { }

	[IteratorStateMachineAttribute] // RVA: 0x8EA80 Offset: 0x8DE80 VA: 0x18008EA80
	// RVA: 0xA0E030 Offset: 0xA0D430 VA: 0x180A0E030
	private IEnumerator UpdateTimedActionIcon() { }

	// RVA: 0xA0D530 Offset: 0xA0C930 VA: 0x180A0D530
	private void TryToQuickMove() { }

	// RVA: 0xA0CDE0 Offset: 0xA0C1E0 VA: 0x180A0CDE0 Slot: 16
	public virtual void TryToMove() { }

	// RVA: 0xA0A260 Offset: 0xA09660 VA: 0x180A0A260
	public void EquipAsClothingItem() { }

	// RVA: 0xA0BF60 Offset: 0xA0B360 VA: 0x180A0BF60 Slot: 17
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xA0C040 Offset: 0xA0B440 VA: 0x180A0C040 Slot: 7
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xA0C410 Offset: 0xA0B810 VA: 0x180A0C410 Slot: 8
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xA0A440 Offset: 0xA09840 VA: 0x180A0A440 Slot: 9
	public object GetDragData() { }

	// RVA: 0xA0A770 Offset: 0xA09B70 VA: 0x180A0A770 Slot: 10
	public string GetDragType() { }

	// RVA: 0xA0A740 Offset: 0xA09B40 VA: 0x180A0A740 Slot: 11
	public Sprite GetDragSprite() { }

	// RVA: 0xA0E250 Offset: 0xA0D650 VA: 0x180A0E250
	public void .ctor() { }

	// RVA: 0xA0E140 Offset: 0xA0D540 VA: 0x180A0E140
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA0D750 Offset: 0xA0CB50 VA: 0x180A0D750
	private void <EquipAsClothingItem>b__78_0() { }

}

public class ItemIcon.DragInfo // TypeDefIndex: 11009
{	// Fields
	public Item item; // 0x10
	public int amount; // 0x18
	public bool canDrop; // 0x1C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class ItemIcon.<StartTimedLootAction>d__71 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11010
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ItemIcon <>4__this; // 0x20
	public float delay; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xA185E0 Offset: 0xA179E0 VA: 0x180A185E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA18860 Offset: 0xA17C60 VA: 0x180A18860 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemIcon.<UpdateTimedActionIcon>d__75 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11011
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ItemIcon <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xA19EE0 Offset: 0xA192E0 VA: 0x180A19EE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA1A0C0 Offset: 0xA194C0 VA: 0x180A1A0C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemIcon.<>c__DisplayClass77_0 // TypeDefIndex: 11012
{	// Fields
	public ItemIcon <>4__this; // 0x10
	public PlayerLoot loot; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA18F30 Offset: 0xA18330 VA: 0x180A18F30
	internal void <TryToMove>b__0() { }

	// RVA: 0xA192A0 Offset: 0xA186A0 VA: 0x180A192A0
	internal void <TryToMove>b__1() { }

	// RVA: 0xA195D0 Offset: 0xA189D0 VA: 0x180A195D0
	internal void <TryToMove>b__2() { }

	// RVA: 0xA199C0 Offset: 0xA18DC0 VA: 0x180A199C0
	internal void <TryToMove>b__3() { }

}

public class ItemInformationPanel : MonoBehaviour // TypeDefIndex: 11013
{	// Methods

	// RVA: 0xA0E330 Offset: 0xA0D730 VA: 0x180A0E330 Slot: 4
	public virtual bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0xA0E390 Offset: 0xA0D790 VA: 0x180A0E390 Slot: 5
	public virtual void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemOptionButton : MonoBehaviour // TypeDefIndex: 11014
{	// Fields
	public TextMeshProUGUI name; // 0x18
	public Image icon; // 0x20
	internal Item item; // 0x28
	internal Option option; // 0x30

	// Methods

	// RVA: 0x6ACCE0 Offset: 0x6AC0E0 VA: 0x1806ACCE0
	public void Setup(Item item, Option option) { }

	// RVA: 0x6ACBC0 Offset: 0x6ABFC0 VA: 0x1806ACBC0
	public void Pressed() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemPanel : SingletonComponent<ItemPanel> // TypeDefIndex: 11015
{	// Fields
	private ItemIcon item; // 0x18

	// Methods

	// RVA: 0x6AD2B0 Offset: 0x6AC6B0 VA: 0x1806AD2B0
	private void Start() { }

	// RVA: 0x6AD2C0 Offset: 0x6AC6C0 VA: 0x1806AD2C0
	public void Update() { }

	// RVA: 0x6ACF50 Offset: 0x6AC350 VA: 0x1806ACF50
	private void OnChanged() { }

	// RVA: 0x6AD380 Offset: 0x6AC780 VA: 0x1806AD380
	public void .ctor() { }

}

public class ItemPickupNotice : MonoBehaviour // TypeDefIndex: 11016
{	// Fields
	public TextMeshProUGUI Text; // 0x18
	public TextMeshProUGUI Amount; // 0x20
	private TimeSince enabledTime; // 0x28
	private RectTransform targetRect; // 0x30
	private CanvasGroup targetCanvas; // 0x38
	private const float pickupNoticeTime = 4;

	// Properties
	public ItemDefinition itemInfo { set; }
	public int amount { set; }

	// Methods

	// RVA: 0x6AD8D0 Offset: 0x6ACCD0 VA: 0x1806AD8D0
	public void set_itemInfo(ItemDefinition value) { }

	// RVA: 0x6AD860 Offset: 0x6ACC60 VA: 0x1806AD860
	public void set_amount(int value) { }

	// RVA: 0x6AD410 Offset: 0x6AC810 VA: 0x1806AD410
	public void AppendTotal(int amount) { }

	// RVA: 0x6AD4D0 Offset: 0x6AC8D0 VA: 0x1806AD4D0
	public void OnEnable() { }

	// RVA: 0x6AD4A0 Offset: 0x6AC8A0 VA: 0x1806AD4A0
	public void BlockLayoutUpdates() { }

	// RVA: 0x6AD3E0 Offset: 0x6AC7E0 VA: 0x1806AD3E0
	public void AllowLayoutUpdates() { }

	// RVA: 0x6AD650 Offset: 0x6ACA50 VA: 0x1806AD650
	public bool ProcessAnimation(AnimationCurve sizeCurve, AnimationCurve alphaCurve) { }

	// RVA: 0x6AD5C0 Offset: 0x6AC9C0 VA: 0x1806AD5C0
	public void PopupNoticeEnd() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemPreviewIcon : BaseMonoBehaviour, IInventoryChanged, IItemAmountChanged, IItemIconChanged // TypeDefIndex: 11017
{	// Fields
	public ItemContainerSource containerSource; // 0x18
	[RangeAttribute] // RVA: 0x8E7C0 Offset: 0x8DBC0 VA: 0x18008E7C0
	public int slot; // 0x20
	public bool setSlotFromSiblingIndex; // 0x24
	public CanvasGroup iconContents; // 0x28
	public Image iconImage; // 0x30
	public Text amountText; // 0x38
	public Item item; // 0x40
	private bool invalidSlot; // 0x48

	// Properties
	private Item iconValue { get; }

	// Methods

	// RVA: 0x6ADD60 Offset: 0x6AD160 VA: 0x1806ADD60
	protected void OnEnable() { }

	// RVA: 0x6ADC60 Offset: 0x6AD060 VA: 0x1806ADC60
	protected void OnDisable() { }

	// RVA: 0x6AD940 Offset: 0x6ACD40 VA: 0x1806AD940
	public Sprite GetItemSprite() { }

	// RVA: 0x6ADFE0 Offset: 0x6AD3E0 VA: 0x1806ADFE0 Slot: 7
	public void OnItemAmountChanged() { }

	// RVA: 0x6AE000 Offset: 0x6AD400 VA: 0x1806AE000 Slot: 8
	public void OnItemIconChanged() { }

	// RVA: 0x6ADE90 Offset: 0x6AD290 VA: 0x1806ADE90 Slot: 6
	public void OnInventoryChanged() { }

	// RVA: 0x6AE0D0 Offset: 0x6AD4D0 VA: 0x1806AE0D0
	private void UpdateItemIcon() { }

	// RVA: 0x6AE120 Offset: 0x6AD520 VA: 0x1806AE120
	private Item get_iconValue() { }

	// RVA: 0x6AE110 Offset: 0x6AD510 VA: 0x1806AE110
	public void .ctor() { }

}

public class ItemSplitter : MonoBehaviour // TypeDefIndex: 11018
{	// Fields
	public Slider slider; // 0x18
	public TextMeshProUGUI textValue; // 0x20
	public TextMeshProUGUI splitAmountText; // 0x28
	public TMP_InputField amountInputField; // 0x30
	private static bool isInputFieldOpen; // 0x0
	private float oldAmount; // 0x38

	// Properties
	public ItemIcon.DragInfo dragInfo { get; }

	// Methods

	// RVA: 0x6AEFD0 Offset: 0x6AE3D0 VA: 0x1806AEFD0
	public static bool IsInputFieldOpen() { }

	// RVA: 0x6AF560 Offset: 0x6AE960 VA: 0x1806AF560
	private void Start() { }

	// RVA: 0x6AF770 Offset: 0x6AEB70 VA: 0x1806AF770
	public ItemIcon.DragInfo get_dragInfo() { }

	// RVA: 0x6AF340 Offset: 0x6AE740 VA: 0x1806AF340
	public void RefreshValue() { }

	// RVA: 0x6AF650 Offset: 0x6AEA50 VA: 0x1806AF650
	public void Update() { }

	// RVA: 0x6AEF10 Offset: 0x6AE310 VA: 0x1806AEF10
	private string FormatValueString(float value) { }

	// RVA: 0x6AF030 Offset: 0x6AE430 VA: 0x1806AF030
	private void OnAmountInputFieldValueChanged() { }

	// RVA: 0x6AF1A0 Offset: 0x6AE5A0 VA: 0x1806AF1A0
	public void OnSliderLeftMouseDown() { }

	// RVA: 0x6AF2D0 Offset: 0x6AE6D0 VA: 0x1806AF2D0
	public void OnSliderRightMouseUp() { }

	// RVA: 0x6AF1B0 Offset: 0x6AE5B0 VA: 0x1806AF1B0
	public void OnSliderMiddleMouseDown() { }

	// RVA: 0x6AF3E0 Offset: 0x6AE7E0 VA: 0x1806AF3E0
	private void SetAmountInputFieldVisible(bool flag) { }

	// RVA: 0x6AEF50 Offset: 0x6AE350 VA: 0x1806AEF50
	public static int GetSplitAmount(int itemAmount) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6AF030 Offset: 0x6AE430 VA: 0x1806AF030
	private void <Start>b__6_0(string <p0>) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6AF1A0 Offset: 0x6AE5A0 VA: 0x1806AF1A0
	private void <Start>b__6_1(string <p0>) { }

}

public class ItemSplitterDragOut : MonoBehaviour, IDraggable // TypeDefIndex: 11019
{	// Fields
	public ItemSplitter rootSplitter; // 0x18

	// Methods

	// RVA: 0x6AEC10 Offset: 0x6AE010 VA: 0x1806AEC10 Slot: 4
	public object GetDragData() { }

	// RVA: 0x6AECF0 Offset: 0x6AE0F0 VA: 0x1806AECF0 Slot: 5
	public string GetDragType() { }

	// RVA: 0x6AECB0 Offset: 0x6AE0B0 VA: 0x1806AECB0 Slot: 6
	public Sprite GetDragSprite() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemSplitterSlider : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler // TypeDefIndex: 11020
{	// Fields
	public ItemSplitter Splitter; // 0x18

	// Methods

	// RVA: 0x6AED20 Offset: 0x6AE120 VA: 0x1806AED20 Slot: 5
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x6AEE80 Offset: 0x6AE280 VA: 0x1806AEE80 Slot: 4
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemStatValue : MonoBehaviour // TypeDefIndex: 11021
{	// Fields
	public Text text; // 0x18
	public Slider slider; // 0x20
	public bool selectedItem; // 0x28
	public bool smallerIsBetter; // 0x29
	public bool asPercentage; // 0x2A

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void OnEnable() { }

	// RVA: 0x6AF810 Offset: 0x6AEC10 VA: 0x1806AF810
	private void OnDisable() { }

	// RVA: 0x6AF860 Offset: 0x6AEC60 VA: 0x1806AF860
	public void SetValue(float val, int numDecimals = 0, string overrideText = "") { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemSubmitPanel : LootPanel // TypeDefIndex: 11022
{	// Methods

	// RVA: 0x6B1610 Offset: 0x6B0A10 VA: 0x1806B1610
	public void SubmitClicked() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

public class ItemTextValue : MonoBehaviour // TypeDefIndex: 11023
{	// Fields
	public Text text; // 0x18
	public Color bad; // 0x20
	public Color good; // 0x30
	public bool negativestat; // 0x40
	public bool asPercentage; // 0x41
	public bool useColors; // 0x42
	public bool signed; // 0x43
	public string suffix; // 0x48
	public float multiplier; // 0x50

	// Methods

	// RVA: 0x6B16A0 Offset: 0x6B0AA0 VA: 0x1806B16A0
	public void SetValue(float val, int numDecimals = 0, string overrideText = "") { }

	// RVA: 0x6B18C0 Offset: 0x6B0CC0 VA: 0x1806B18C0
	public void .ctor() { }

}

public class ItemStore : SingletonComponent<ItemStore>, VirtualScroll.IDataSource // TypeDefIndex: 11105
{	// Fields
	public static readonly Translate.Phrase CartEmptyPhrase; // 0x0
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

	// Methods

	// RVA: 0x6B0720 Offset: 0x6AFB20 VA: 0x1806B0720 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6B09F0 Offset: 0x6AFDF0 VA: 0x1806B09F0
	private void OnPurchaseFinished(AppId appid, ulong orderid, bool success) { }

	[AsyncStateMachineAttribute] // RVA: 0x96590 Offset: 0x95990 VA: 0x180096590
	// RVA: 0x6B0EE0 Offset: 0x6B02E0 VA: 0x1806B0EE0
	private void RefreshList() { }

	// RVA: 0x6B0570 Offset: 0x6AF970 VA: 0x1806B0570
	private void AddItem(IPlayerItemDefinition item) { }

	// RVA: 0x6B1120 Offset: 0x6B0520 VA: 0x1806B1120
	internal void ShowModal(IPlayerItemDefinition item) { }

	// RVA: 0x6B0680 Offset: 0x6AFA80 VA: 0x1806B0680
	internal void AddToCart(IPlayerItemDefinition item) { }

	// RVA: 0x6B0960 Offset: 0x6AFD60 VA: 0x1806B0960
	public void EmptyCart() { }

	// RVA: 0x6B1140 Offset: 0x6B0540 VA: 0x1806B1140
	private void UpdateShoppingList() { }

	// RVA: 0x6B0FB0 Offset: 0x6B03B0 VA: 0x1806B0FB0
	public void RemoveFromCart(int index) { }

	[AsyncStateMachineAttribute] // RVA: 0x96770 Offset: 0x95B70 VA: 0x180096770
	// RVA: 0x6B0890 Offset: 0x6AFC90 VA: 0x1806B0890
	public void Checkout() { }

	// RVA: 0x6B09B0 Offset: 0x6AFDB0 VA: 0x1806B09B0 Slot: 8
	public int GetItemCount() { }

	// RVA: 0x6B1010 Offset: 0x6B0410 VA: 0x1806B1010 Slot: 9
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x6B1580 Offset: 0x6B0980 VA: 0x1806B1580
	public void .ctor() { }

	// RVA: 0x6B1480 Offset: 0x6B0880 VA: 0x1806B1480
	private static void .cctor() { }

}

private sealed class ItemStore.<>c // TypeDefIndex: 11106
{	// Fields
	public static readonly ItemStore.<>c <>9; // 0x0
	public static Func<IPlayerItemDefinition, int> <>9__16_0; // 0x8
	public static Func<IPlayerItemDefinition, int> <>9__17_0; // 0x10
	public static Func<IPlayerItemDefinition, int> <>9__22_0; // 0x18
	public static Func<SteamItemDefinition, InventoryDef> <>9__24_0; // 0x20

	// Methods

	// RVA: 0x6C65E0 Offset: 0x6C59E0 VA: 0x1806C65E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6C6350 Offset: 0x6C5750 VA: 0x1806C6350
	internal int <OnPurchaseFinished>b__16_0(IPlayerItemDefinition x) { }

	// RVA: 0x6C63A0 Offset: 0x6C57A0 VA: 0x1806C63A0
	internal int <RefreshList>b__17_0(IPlayerItemDefinition x) { }

	// RVA: 0x6C63F0 Offset: 0x6C57F0 VA: 0x1806C63F0
	internal int <UpdateShoppingList>b__22_0(IPlayerItemDefinition x) { }

	// RVA: 0x6C6330 Offset: 0x6C5730 VA: 0x1806C6330
	internal InventoryDef <Checkout>b__24_0(SteamItemDefinition i) { }

}

private struct ItemStore.<RefreshList>d__17 : IAsyncStateMachine // TypeDefIndex: 11107
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ItemStore <>4__this; // 0x28
	private TaskAwaiter<List<IPlayerItemDefinition>> <>u__1; // 0x30

	// Methods

	// RVA: 0xF3BF0 Offset: 0xF2FF0 VA: 0x1800F3BF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ItemStore.<Checkout>d__24 : IAsyncStateMachine // TypeDefIndex: 11108
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ItemStore <>4__this; // 0x28
	private TaskAwaiter<Nullable<InventoryPurchaseResult>> <>u__1; // 0x30

	// Methods

	// RVA: 0xF3BE0 Offset: 0xF2FE0 VA: 0x1800F3BE0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class ItemStoreBuyFailedModal : MonoBehaviour // TypeDefIndex: 11109
{	// Methods

	// RVA: 0x6AFAA0 Offset: 0x6AEEA0 VA: 0x1806AFAA0
	public void Show(ulong orderid) { }

	// RVA: 0x6AF9D0 Offset: 0x6AEDD0 VA: 0x1806AF9D0
	public void Hide() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E2D90 Offset: 0x4E2190 VA: 0x1804E2D90
	private void <Hide>b__1_0() { }

}

public class ItemStoreBuySuccessModal : MonoBehaviour // TypeDefIndex: 11110
{	// Methods

	// RVA: 0x6AFC30 Offset: 0x6AF030 VA: 0x1806AFC30
	public void Show(ulong orderId) { }

	// RVA: 0x6AFB60 Offset: 0x6AEF60 VA: 0x1806AFB60
	public void Hide() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E2D90 Offset: 0x4E2190 VA: 0x1804E2D90
	private void <Hide>b__1_0() { }

}

public class ItemStoreCartItem : MonoBehaviour // TypeDefIndex: 11111
{	// Fields
	public int Index; // 0x18
	public TextMeshProUGUI Name; // 0x20
	public TextMeshProUGUI Price; // 0x28

	// Methods

	// RVA: 0x6AFDA0 Offset: 0x6AF1A0 VA: 0x1806AFDA0
	public void Init(int index, IPlayerItemDefinition def) { }

	// RVA: 0x6AFE50 Offset: 0x6AF250 VA: 0x1806AFE50
	public void RemoveFromCart() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemStoreItem : MonoBehaviour // TypeDefIndex: 11112
{	// Fields
	public HttpImage Icon; // 0x18
	public RustText Name; // 0x20
	public TextMeshProUGUI Price; // 0x28
	public RustText ItemName; // 0x30
	public GameObject InCartTag; // 0x38
	private IPlayerItemDefinition item; // 0x40

	// Methods

	// RVA: 0x6B0330 Offset: 0x6AF730 VA: 0x1806B0330
	internal void Init(IPlayerItemDefinition item, bool inCart) { }

	// RVA: 0x6B04F0 Offset: 0x6AF8F0 VA: 0x1806B04F0
	public void ShowModal() { }

	// RVA: 0x6B02B0 Offset: 0x6AF6B0 VA: 0x1806B02B0
	public void AddToCart() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ItemStoreItemInfoModal : MonoBehaviour // TypeDefIndex: 11113
{	// Fields
	public HttpImage Icon; // 0x18
	public TextMeshProUGUI Name; // 0x20
	public TextMeshProUGUI Price; // 0x28
	public TextMeshProUGUI Description; // 0x30
	private IPlayerItemDefinition item; // 0x38

	// Methods

	// RVA: 0x6B0100 Offset: 0x6AF500 VA: 0x1806B0100
	public void Show(IPlayerItemDefinition item) { }

	// RVA: 0x6AFF00 Offset: 0x6AF300 VA: 0x1806AFF00
	public void AddToCart() { }

	// RVA: 0x6B0030 Offset: 0x6AF430 VA: 0x1806B0030
	public void Hide() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E2D90 Offset: 0x4E2190 VA: 0x1804E2D90
	private void <Hide>b__7_0() { }

}

public class ItemModEngineItem : ItemMod // TypeDefIndex: 12108
{	// Fields
	public EngineStorage.EngineItemTypes engineItemType; // 0x20
	[RangeAttribute] // RVA: 0xDBAD0 Offset: 0xDAED0 VA: 0x1800DBAD0
	public int tier; // 0x24

	// Methods

	// RVA: 0x4BB380 Offset: 0x4BA780 VA: 0x1804BB380
	public void .ctor() { }

}

public class ItemModVehicleChassis : ItemMod, VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 12109
{	// Fields
	public GameObjectRef entityPrefab; // 0x20
	[RangeAttribute] // RVA: 0xDBBB0 Offset: 0xDAFB0 VA: 0x1800DBBB0
	public int socketsTaken; // 0x28

	// Properties
	public int SocketsTaken { get; }

	// Methods

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390 Slot: 16
	public int get_SocketsTaken() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390 Slot: 10
	public override int GetTotalUISlots(Item item) { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390 Slot: 11
	public override int GetFilledUISlots(Item item) { }

	// RVA: 0x4BB3A0 Offset: 0x4BA7A0 VA: 0x1804BB3A0
	public void .ctor() { }

}

public class ItemModVehicleModule : ItemMod, VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 12110
{	// Fields
	public GameObjectRef entityPrefab; // 0x20
	[RangeAttribute] // RVA: 0xA42D0 Offset: 0xA36D0 VA: 0x1800A42D0
	public int socketsTaken; // 0x28
	public bool doNonUserSpawn; // 0x2C

	// Properties
	public int SocketsTaken { get; }

	// Methods

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390 Slot: 16
	public int get_SocketsTaken() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390 Slot: 10
	public override int GetTotalUISlots(Item item) { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390 Slot: 11
	public override int GetFilledUISlots(Item item) { }

	// RVA: 0x4BB3A0 Offset: 0x4BA7A0 VA: 0x1804BB3A0
	public void .ctor() { }

}

