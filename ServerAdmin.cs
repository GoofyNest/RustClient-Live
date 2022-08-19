public class ServerAdminConvarInfo : MonoBehaviour // TypeDefIndex: 12073
{	// Fields
	public RustText InfoName; // 0x18
	public RustText InfoValue; // 0x20
	public RustInput VariableInput; // 0x28
	public Tooltip TooltipComponent; // 0x30

	// Methods

	// RVA: 0x4C5A00 Offset: 0x4C4E00 VA: 0x1804C5A00
	public void Populate(Admin.ServerConvarInfo convarInfo) { }

	// RVA: 0x4C5830 Offset: 0x4C4C30 VA: 0x1804C5830
	public void OnSubmitVariable() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ServerAdminPlayerEntry : MonoBehaviour // TypeDefIndex: 12074
{	// Fields
	public RustText PlayerName; // 0x18
	public RustText Ping; // 0x20
	public RustButton Button; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Admin.PlayerInfo <CachedInfo>k__BackingField; // 0x30
	private Action selectedAction; // 0x70
	private Action deselectedAction; // 0x78

	// Properties
	public Admin.PlayerInfo CachedInfo { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4C5C20 Offset: 0x4C5020 VA: 0x1804C5C20
	public Admin.PlayerInfo get_CachedInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4C5C50 Offset: 0x4C5050 VA: 0x1804C5C50
	private void set_CachedInfo(Admin.PlayerInfo value) { }

	// RVA: 0x4C5B50 Offset: 0x4C4F50 VA: 0x1804C5B50
	public void Populate(Admin.PlayerInfo info, Action onSelected, Action onDeselected) { }

	// RVA: 0x4C5B00 Offset: 0x4C4F00 VA: 0x1804C5B00
	public void OnToggled() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ServerAdminPlayerId : MonoBehaviour // TypeDefIndex: 12075
{	// Fields
	public RustText PlayerName; // 0x18
	public RustText PlayerId; // 0x20

	// Methods

	// RVA: 0x4C5C80 Offset: 0x4C5080 VA: 0x1804C5C80
	public void Populate(ulong playerId) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ServerAdminPlayerInfo : MonoBehaviour // TypeDefIndex: 12076
{	// Fields
	public RustText PlayerName; // 0x18
	public RustText SteamID; // 0x20
	public RustText OwnerSteamID; // 0x28
	public RustText Ping; // 0x30
	public RustText Address; // 0x38
	public RustText ConnectedTime; // 0x40
	public RustText ViolationLevel; // 0x48
	public RustText Health; // 0x50
	public RustInput KickReasonInput; // 0x58
	public RustInput BanReasonInput; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Admin.PlayerInfo <CachedInfo>k__BackingField; // 0x68

	// Properties
	public Admin.PlayerInfo CachedInfo { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4C61B0 Offset: 0x4C55B0 VA: 0x1804C61B0
	public Admin.PlayerInfo get_CachedInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4C61E0 Offset: 0x4C55E0 VA: 0x1804C61E0
	public void set_CachedInfo(Admin.PlayerInfo value) { }

	// RVA: 0x4C5FC0 Offset: 0x4C53C0 VA: 0x1804C5FC0
	public void Populate(Admin.PlayerInfo info) { }

	// RVA: 0x4C5E50 Offset: 0x4C5250 VA: 0x1804C5E50
	public void OnClickedKick() { }

	// RVA: 0x4C5DB0 Offset: 0x4C51B0 VA: 0x1804C5DB0
	public void OnClickedBan() { }

	// RVA: 0x4C5EF0 Offset: 0x4C52F0 VA: 0x1804C5EF0
	public void OnClickedSpectate() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ServerAdminServerInfo : MonoBehaviour // TypeDefIndex: 12077
{	// Fields
	public RustText InfoName; // 0x18
	public RustText InfoValue; // 0x20

	// Methods

	// RVA: 0x4C6210 Offset: 0x4C5610 VA: 0x1804C6210
	public void Populate(string variableName, string variableValue) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ServerAdminUGCEntry : MonoBehaviour // TypeDefIndex: 12078
{	// Fields
	protected Admin.ServerUGCInfo cachedInfo; // 0x18
	private Action<byte[]> receivedCallback; // 0x40

	// Methods

	// RVA: 0x4C7D50 Offset: 0x4C7150 VA: 0x1804C7D50
	public void Populate(Admin.ServerUGCInfo info) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	protected virtual void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4C7990 Offset: 0x4C6D90 VA: 0x1804C7990
	protected void GetData(Action<byte[]> callback, int index = 0) { }

	// RVA: 0x4C7980 Offset: 0x4C6D80 VA: 0x1804C7980
	public bool EntityMatches(uint entityId) { }

	// RVA: 0x4C7850 Offset: 0x4C6C50 VA: 0x1804C7850
	public bool DataMatches(uint crc) { }

	// RVA: 0x4C7DD0 Offset: 0x4C71D0 VA: 0x1804C7DD0
	public void ReceivedDataFromServer(byte[] data) { }

	// RVA: 0x4C78B0 Offset: 0x4C6CB0 VA: 0x1804C78B0
	public void DeleteUGC() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ServerAdminUGCEntryAudio : ServerAdminUGCEntry // TypeDefIndex: 12079
{	// Fields
	public AudioSource AudioSpeaker; // 0x48
	public RustText DurationText; // 0x50
	public RustSlider ProgressSlider; // 0x58
	public RustIcon PlayIcon; // 0x60
	private bool blockSeek; // 0x68

	// Methods

	// RVA: 0x4C6390 Offset: 0x4C5790 VA: 0x1804C6390 Slot: 4
	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4C66E0 Offset: 0x4C5AE0 VA: 0x1804C66E0
	protected void Update() { }

	// RVA: 0x4C6300 Offset: 0x4C5700 VA: 0x1804C6300
	public void OnClickedPlay() { }

	// RVA: 0x4C6400 Offset: 0x4C5800 VA: 0x1804C6400
	public void SeekToAudioPosition(float val) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4C6560 Offset: 0x4C5960 VA: 0x1804C6560
	private void <OnVisible>b__5_0(byte[] bytes) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4C6600 Offset: 0x4C5A00 VA: 0x1804C6600
	private void <OnVisible>b__5_1(AudioClip clip, bool b) { }

}

public class ServerAdminUGCEntryImage : ServerAdminUGCEntry // TypeDefIndex: 12080
{	// Fields
	public RawImage Image; // 0x48
	public RectTransform Backing; // 0x50
	public GameObject MultiImageRoot; // 0x58
	public RustText ImageIndex; // 0x60
	public Vector2 OriginalImageSize; // 0x68
	private int currentIndex; // 0x70

	// Methods

	// RVA: 0x4C6C70 Offset: 0x4C6070 VA: 0x1804C6C70 Slot: 4
	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4C67C0 Offset: 0x4C5BC0 VA: 0x1804C67C0
	private void GetDataForCurrentIndex() { }

	// RVA: 0x4C6A80 Offset: 0x4C5E80 VA: 0x1804C6A80
	private void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x4C6840 Offset: 0x4C5C40 VA: 0x1804C6840
	public void IncrementImage(int direction) { }

	// RVA: 0x4C6970 Offset: 0x4C5D70 VA: 0x1804C6970
	public void OnClickedExpand() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4C6D00 Offset: 0x4C6100 VA: 0x1804C6D00
	private void <GetDataForCurrentIndex>b__7_0(byte[] bytes) { }

}

public class ServerAdminUGCEntryPattern : ServerAdminUGCEntry // TypeDefIndex: 12081
{	// Fields
	public GameObjectRef StarPrefab; // 0x48
	public RectTransform StarRoot; // 0x50

	// Methods

	// RVA: 0x4C7030 Offset: 0x4C6430 VA: 0x1804C7030 Slot: 4
	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4C6DF0 Offset: 0x4C61F0 VA: 0x1804C6DF0
	public void OnLoadedPattern(List<PatternFirework.Star> stars) { }

	// RVA: 0x4C6D80 Offset: 0x4C6180 VA: 0x1804C6D80
	private void ClearStars() { }

	// RVA: 0x4C71A0 Offset: 0x4C65A0 VA: 0x1804C71A0
	private void PlaceStar(Vector2 localPosition, Color color) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ServerAdminUGCEntryStub : MonoBehaviour // TypeDefIndex: 12082
{	// Fields
	public ServerAdminUGCEntryAudio AudioWidget; // 0x18
	public ServerAdminUGCEntryImage ImageWidget; // 0x20
	public ServerAdminUGCEntryPattern PatternWidget; // 0x28
	public RustText PrefabName; // 0x30
	public RustButton HistoryButton; // 0x38
	public ServerAdminPlayerId[] HistoryIds; // 0x40
	protected Admin.ServerUGCInfo cachedInfo; // 0x48

	// Methods

	// RVA: 0x4C7340 Offset: 0x4C6740 VA: 0x1804C7340
	public void Populate(Admin.ServerUGCInfo info) { }

	// RVA: 0x4C7800 Offset: 0x4C6C00 VA: 0x1804C7800
	public void .ctor() { }

}

public class ServerAdminUI : SingletonComponent<ServerAdminUI> // TypeDefIndex: 12083
{	// Fields
	public GameObjectRef PlayerEntry; // 0x18
	public RectTransform PlayerInfoParent; // 0x20
	public RustText PlayerCount; // 0x28
	public RustInput PlayerNameFilter; // 0x30
	public GameObjectRef ServerInfoEntry; // 0x38
	public RectTransform ServerInfoParent; // 0x40
	public GameObjectRef ConvarInfoEntry; // 0x48
	public GameObjectRef ConvarInfoLongEntry; // 0x50
	public RectTransform ConvarInfoParent; // 0x58
	public ServerAdminPlayerInfo PlayerInfo; // 0x60
	public RustInput UgcNameFilter; // 0x68
	public GameObjectRef ImageEntry; // 0x70
	public GameObjectRef PatternEntry; // 0x78
	public GameObjectRef SoundEntry; // 0x80
	public VirtualScroll UgcVirtualScroll; // 0x88
	public GameObject ExpandedUgcRoot; // 0x90
	public RawImage ExpandedImage; // 0x98
	public RectTransform ExpandedImageBacking; // 0xA0
	private Vector2 initialExpandedImageSize; // 0xA8
	private List<ServerAdminPlayerEntry> playerEntries; // 0xB0
	private List<ServerAdminUGCEntry> ugcEntries; // 0xB8
	private ServerAdminUI.UGCDataSource UgcSource; // 0xC0

	// Properties
	public static bool ShouldReceiveMessages { get; }

	// Methods

	// RVA: 0x4CA0B0 Offset: 0x4C94B0 VA: 0x1804CA0B0
	public static bool get_ShouldReceiveMessages() { }

	// RVA: 0x4C7E20 Offset: 0x4C7220 VA: 0x1804C7E20 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4C85B0 Offset: 0x4C79B0 VA: 0x1804C85B0
	private void OnEnable() { }

	// RVA: 0x4C8520 Offset: 0x4C7920 VA: 0x1804C8520
	private void OnDisable() { }

	// RVA: 0x4C9620 Offset: 0x4C8A20 VA: 0x1804C9620
	public void RefreshPlayerList() { }

	// RVA: 0x4C9690 Offset: 0x4C8A90 VA: 0x1804C9690
	public void RefreshServerInfo() { }

	// RVA: 0x4C95B0 Offset: 0x4C89B0 VA: 0x1804C95B0
	public void RefreshConvars() { }

	// RVA: 0x4C9700 Offset: 0x4C8B00 VA: 0x1804C9700
	public void RefreshUGC() { }

	// RVA: 0x4C9180 Offset: 0x4C8580 VA: 0x1804C9180
	public void ReceivePlayerList(string result) { }

	// RVA: 0x4C9380 Offset: 0x4C8780 VA: 0x1804C9380
	public void ReceiveServerInfo(string result) { }

	// RVA: 0x4C91F0 Offset: 0x4C85F0 VA: 0x1804C91F0
	public void ReceiveServerConvars(string result) { }

	// RVA: 0x4C94B0 Offset: 0x4C88B0 VA: 0x1804C94B0
	public void ReceiveUGCList(string result) { }

	// RVA: 0x4C89B0 Offset: 0x4C7DB0 VA: 0x1804C89B0
	private void PopulatePlayerInfo(List<Admin.PlayerInfo> info) { }

	// RVA: 0x4C9D30 Offset: 0x4C9130 VA: 0x1804C9D30
	public void UpdatePlayerFilter(string newFilter) { }

	// RVA: 0x4C9770 Offset: 0x4C8B70 VA: 0x1804C9770
	private bool ShouldShowPlayer(ServerAdminPlayerEntry entry, string filter) { }

	// RVA: -1 Offset: -1
	private void PopulateInfo<T, U>(List<T> contentArray, Func<T, GameObjectRef> getContent, RectTransform contentParent, Action<T, U> populateCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF9B70 Offset: 0xCF8F70 VA: 0x180CF9B70
	|-ServerAdminUI.PopulateInfo<Admin.PlayerInfo, ServerAdminPlayerEntry>
	|-ServerAdminUI.PopulateInfo<Admin.PlayerInfo, object>
	|
	|-RVA: 0xCFA2A0 Offset: 0xCF96A0 VA: 0x180CFA2A0
	|-ServerAdminUI.PopulateInfo<Admin.ServerConvarInfo, ServerAdminConvarInfo>
	|-ServerAdminUI.PopulateInfo<Admin.ServerConvarInfo, object>
	|
	|-RVA: 0xCF9F70 Offset: 0xCF9370 VA: 0x180CF9F70
	|-ServerAdminUI.PopulateInfo<object, object>
	*/

	// RVA: 0x4C8BC0 Offset: 0x4C7FC0 VA: 0x1804C8BC0
	private void PopulateServerInfo(Admin.ServerInfoOutput info) { }

	// RVA: 0x4C8860 Offset: 0x4C7C60 VA: 0x1804C8860
	private void PopulateConvarInfo(List<Admin.ServerConvarInfo> info) { }

	// RVA: 0x4C9870 Offset: 0x4C8C70 VA: 0x1804C9870
	private static bool ShouldShowUGC(string filter, Admin.ServerUGCInfo info) { }

	// RVA: 0x4C8EF0 Offset: 0x4C82F0 VA: 0x1804C8EF0
	private void PopulateUgcInfo(List<Admin.ServerUGCInfo> info) { }

	// RVA: 0x4C8160 Offset: 0x4C7560 VA: 0x1804C8160
	public void KickPlayer(string playerName, string kickReason) { }

	// RVA: 0x4C7EE0 Offset: 0x4C72E0 VA: 0x1804C7EE0
	public void BanPlayer(string playerName, string banReason) { }

	// RVA: 0x4C9C50 Offset: 0x4C9050 VA: 0x1804C9C50
	public void SpectatePlayer(string playerName) { }

	// RVA: 0x4C83E0 Offset: 0x4C77E0 VA: 0x1804C83E0
	public void ModifyConvar(string convar, string newValue) { }

	// RVA: 0x4C8650 Offset: 0x4C7A50 VA: 0x1804C8650
	public void OnReceivedAdminUGC(uint crc, byte[] data) { }

	// RVA: 0x4C8FB0 Offset: 0x4C83B0 VA: 0x1804C8FB0
	public void ReceiveFireworkPattern(uint entityId, PatternFirework.Design design) { }

	// RVA: 0x4C9F40 Offset: 0x4C9340 VA: 0x1804C9F40
	public void UpdateUGCFilter(string newFilter) { }

	// RVA: 0x4C9A50 Offset: 0x4C8E50 VA: 0x1804C9A50
	public void ShowExpandedImage(Texture2D tex, Admin.ServerUGCInfo forInfo) { }

	// RVA: 0x4C9F80 Offset: 0x4C9380 VA: 0x1804C9F80
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4C9CB0 Offset: 0x4C90B0 VA: 0x1804C9CB0
	private GameObjectRef <PopulateConvarInfo>b__38_0(Admin.ServerConvarInfo convarInfo) { }

}

private class ServerAdminUI.UGCDataSource : VirtualScroll.IDataSource // TypeDefIndex: 12084
{	// Fields
	private List<Admin.ServerUGCInfo> rawInfo; // 0x10
	private List<Admin.ServerUGCInfo> filteredInfo; // 0x18

	// Methods

	// RVA: 0x4CF220 Offset: 0x4CE620 VA: 0x1804CF220 Slot: 4
	public int GetItemCount() { }

	// RVA: 0x4CF470 Offset: 0x4CE870 VA: 0x1804CF470 Slot: 5
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void SetInfo(List<Admin.ServerUGCInfo> newInfo) { }

	// RVA: 0x4CF270 Offset: 0x4CE670 VA: 0x1804CF270
	public void SetFilter(string filter) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class ServerAdminUI.<>c__DisplayClass33_0 // TypeDefIndex: 12085
{	// Fields
	public ServerAdminUI <>4__this; // 0x10
	public string oldSelectedPlayer; // 0x18
	public Action <>9__3; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4CEC00 Offset: 0x4CE000 VA: 0x1804CEC00
	internal GameObjectRef <PopulatePlayerInfo>b__0(Admin.PlayerInfo playerInfo) { }

	// RVA: 0x4CEC20 Offset: 0x4CE020 VA: 0x1804CEC20
	internal void <PopulatePlayerInfo>b__1(Admin.PlayerInfo playerInfo, ServerAdminPlayerEntry entry) { }

	// RVA: 0x4CEEE0 Offset: 0x4CE2E0 VA: 0x1804CEEE0
	internal void <PopulatePlayerInfo>b__3() { }

}

private sealed class ServerAdminUI.<>c__DisplayClass33_1 // TypeDefIndex: 12086
{	// Fields
	public Admin.PlayerInfo playerInfo; // 0x10
	public ServerAdminUI.<>c__DisplayClass33_0 CS$<>8__locals1; // 0x50

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4CEF20 Offset: 0x4CE320 VA: 0x1804CEF20
	internal void <PopulatePlayerInfo>b__2() { }

}

private sealed class ServerAdminUI.<>c // TypeDefIndex: 12087
{	// Fields
	public static readonly ServerAdminUI.<>c <>9; // 0x0
	public static Action<Admin.ServerConvarInfo, ServerAdminConvarInfo> <>9__38_1; // 0x8

	// Methods

	// RVA: 0x4CF0A0 Offset: 0x4CE4A0 VA: 0x1804CF0A0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4CE960 Offset: 0x4CDD60 VA: 0x1804CE960
	internal void <PopulateConvarInfo>b__38_1(Admin.ServerConvarInfo convarInfo, ServerAdminConvarInfo adminConvarInfo) { }

}

