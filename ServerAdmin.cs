public class ServerAdminConvarInfo : MonoBehaviour // TypeDefIndex: 12073
{	public RustText InfoName; // 0x18
	public RustText InfoValue; // 0x20
	public RustInput VariableInput; // 0x28
	public Tooltip TooltipComponent; // 0x30


	public void Populate(Admin.ServerConvarInfo convarInfo) { }

	public void OnSubmitVariable() { }

	public void .ctor() { }

}

public class ServerAdminPlayerEntry : MonoBehaviour // TypeDefIndex: 12074
{	public RustText PlayerName; // 0x18
	public RustText Ping; // 0x20
	public RustButton Button; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Admin.PlayerInfo <CachedInfo>k__BackingField; // 0x30
	private Action selectedAction; // 0x70
	private Action deselectedAction; // 0x78

	public Admin.PlayerInfo CachedInfo { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Admin.PlayerInfo get_CachedInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_CachedInfo(Admin.PlayerInfo value) { }

	public void Populate(Admin.PlayerInfo info, Action onSelected, Action onDeselected) { }

	public void OnToggled() { }

	public void .ctor() { }

}

public class ServerAdminPlayerId : MonoBehaviour // TypeDefIndex: 12075
{	public RustText PlayerName; // 0x18
	public RustText PlayerId; // 0x20


	public void Populate(ulong playerId) { }

	public void .ctor() { }

}

public class ServerAdminPlayerInfo : MonoBehaviour // TypeDefIndex: 12076
{	public RustText PlayerName; // 0x18
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

	public Admin.PlayerInfo CachedInfo { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Admin.PlayerInfo get_CachedInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_CachedInfo(Admin.PlayerInfo value) { }

	public void Populate(Admin.PlayerInfo info) { }

	public void OnClickedKick() { }

	public void OnClickedBan() { }

	public void OnClickedSpectate() { }

	public void .ctor() { }

}

public class ServerAdminServerInfo : MonoBehaviour // TypeDefIndex: 12077
{	public RustText InfoName; // 0x18
	public RustText InfoValue; // 0x20


	public void Populate(string variableName, string variableValue) { }

	public void .ctor() { }

}

public class ServerAdminUGCEntry : MonoBehaviour // TypeDefIndex: 12078
{	protected Admin.ServerUGCInfo cachedInfo; // 0x18
	private Action<byte[]> receivedCallback; // 0x40


	public void Populate(Admin.ServerUGCInfo info) { }

	protected virtual void OnVisible(Admin.ServerUGCInfo info) { }

	protected void GetData(Action<byte[]> callback, int index = 0) { }

	public bool EntityMatches(uint entityId) { }

	public bool DataMatches(uint crc) { }

	public void ReceivedDataFromServer(byte[] data) { }

	public void DeleteUGC() { }

	public void .ctor() { }

}

public class ServerAdminUGCEntryAudio : ServerAdminUGCEntry // TypeDefIndex: 12079
{	public AudioSource AudioSpeaker; // 0x48
	public RustText DurationText; // 0x50
	public RustSlider ProgressSlider; // 0x58
	public RustIcon PlayIcon; // 0x60
	private bool blockSeek; // 0x68


	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	protected void Update() { }

	public void OnClickedPlay() { }

	public void SeekToAudioPosition(float val) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <OnVisible>b__5_0(byte[] bytes) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <OnVisible>b__5_1(AudioClip clip, bool b) { }

}

public class ServerAdminUGCEntryImage : ServerAdminUGCEntry // TypeDefIndex: 12080
{	public RawImage Image; // 0x48
	public RectTransform Backing; // 0x50
	public GameObject MultiImageRoot; // 0x58
	public RustText ImageIndex; // 0x60
	public Vector2 OriginalImageSize; // 0x68
	private int currentIndex; // 0x70


	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	private void GetDataForCurrentIndex() { }

	private void OnImageLoaded(Texture2D texture) { }

	public void IncrementImage(int direction) { }

	public void OnClickedExpand() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <GetDataForCurrentIndex>b__7_0(byte[] bytes) { }

}

public class ServerAdminUGCEntryPattern : ServerAdminUGCEntry // TypeDefIndex: 12081
{	public GameObjectRef StarPrefab; // 0x48
	public RectTransform StarRoot; // 0x50


	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	public void OnLoadedPattern(List<PatternFirework.Star> stars) { }

	private void ClearStars() { }

	private void PlaceStar(Vector2 localPosition, Color color) { }

	public void .ctor() { }

}

public class ServerAdminUGCEntryStub : MonoBehaviour // TypeDefIndex: 12082
{	public ServerAdminUGCEntryAudio AudioWidget; // 0x18
	public ServerAdminUGCEntryImage ImageWidget; // 0x20
	public ServerAdminUGCEntryPattern PatternWidget; // 0x28
	public RustText PrefabName; // 0x30
	public RustButton HistoryButton; // 0x38
	public ServerAdminPlayerId[] HistoryIds; // 0x40
	protected Admin.ServerUGCInfo cachedInfo; // 0x48


	public void Populate(Admin.ServerUGCInfo info) { }

	public void .ctor() { }

}

public class ServerAdminUI : SingletonComponent<ServerAdminUI> // TypeDefIndex: 12083
{	public GameObjectRef PlayerEntry; // 0x18
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

	public static bool ShouldReceiveMessages { get; }


	public static bool get_ShouldReceiveMessages() { }

	protected override void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void RefreshPlayerList() { }

	public void RefreshServerInfo() { }

	public void RefreshConvars() { }

	public void RefreshUGC() { }

	public void ReceivePlayerList(string result) { }

	public void ReceiveServerInfo(string result) { }

	public void ReceiveServerConvars(string result) { }

	public void ReceiveUGCList(string result) { }

	private void PopulatePlayerInfo(List<Admin.PlayerInfo> info) { }

	public void UpdatePlayerFilter(string newFilter) { }

	private bool ShouldShowPlayer(ServerAdminPlayerEntry entry, string filter) { }

	private void PopulateInfo<T, U>(List<T> contentArray, Func<T, GameObjectRef> getContent, RectTransform contentParent, Action<T, U> populateCallback) { }
	/* GenericInstMethod :
	|
	|-ServerAdminUI.PopulateInfo<Admin.PlayerInfo, ServerAdminPlayerEntry>
	|-ServerAdminUI.PopulateInfo<Admin.PlayerInfo, object>
	|
	|-ServerAdminUI.PopulateInfo<Admin.ServerConvarInfo, ServerAdminConvarInfo>
	|-ServerAdminUI.PopulateInfo<Admin.ServerConvarInfo, object>
	|
	|-ServerAdminUI.PopulateInfo<object, object>
	*/

	private void PopulateServerInfo(Admin.ServerInfoOutput info) { }

	private void PopulateConvarInfo(List<Admin.ServerConvarInfo> info) { }

	private static bool ShouldShowUGC(string filter, Admin.ServerUGCInfo info) { }

	private void PopulateUgcInfo(List<Admin.ServerUGCInfo> info) { }

	public void KickPlayer(string playerName, string kickReason) { }

	public void BanPlayer(string playerName, string banReason) { }

	public void SpectatePlayer(string playerName) { }

	public void ModifyConvar(string convar, string newValue) { }

	public void OnReceivedAdminUGC(uint crc, byte[] data) { }

	public void ReceiveFireworkPattern(uint entityId, PatternFirework.Design design) { }

	public void UpdateUGCFilter(string newFilter) { }

	public void ShowExpandedImage(Texture2D tex, Admin.ServerUGCInfo forInfo) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef <PopulateConvarInfo>b__38_0(Admin.ServerConvarInfo convarInfo) { }

}

private class ServerAdminUI.UGCDataSource : VirtualScroll.IDataSource // TypeDefIndex: 12084
{	private List<Admin.ServerUGCInfo> rawInfo; // 0x10
	private List<Admin.ServerUGCInfo> filteredInfo; // 0x18


	public int GetItemCount() { }

	public void SetItemData(int i, GameObject obj) { }

	public void SetInfo(List<Admin.ServerUGCInfo> newInfo) { }

	public void SetFilter(string filter) { }

	public void .ctor() { }

}

private sealed class ServerAdminUI.<>c__DisplayClass33_0 // TypeDefIndex: 12085
{	public ServerAdminUI <>4__this; // 0x10
	public string oldSelectedPlayer; // 0x18
	public Action <>9__3; // 0x20


	public void .ctor() { }

	internal GameObjectRef <PopulatePlayerInfo>b__0(Admin.PlayerInfo playerInfo) { }

	internal void <PopulatePlayerInfo>b__1(Admin.PlayerInfo playerInfo, ServerAdminPlayerEntry entry) { }

	internal void <PopulatePlayerInfo>b__3() { }

}

private sealed class ServerAdminUI.<>c__DisplayClass33_1 // TypeDefIndex: 12086
{	public Admin.PlayerInfo playerInfo; // 0x10
	public ServerAdminUI.<>c__DisplayClass33_0 CS$<>8__locals1; // 0x50


	public void .ctor() { }

	internal void <PopulatePlayerInfo>b__2() { }

}

private sealed class ServerAdminUI.<>c // TypeDefIndex: 12087
{	public static readonly ServerAdminUI.<>c <>9; // 0x0
	public static Action<Admin.ServerConvarInfo, ServerAdminConvarInfo> <>9__38_1; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal void <PopulateConvarInfo>b__38_1(Admin.ServerConvarInfo convarInfo, ServerAdminConvarInfo adminConvarInfo) { }

}

