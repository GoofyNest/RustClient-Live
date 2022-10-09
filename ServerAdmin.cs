public class ServerAdminConvarInfo : MonoBehaviour // TypeDefIndex: 13814
{
	public RustText InfoName; 
	public RustText InfoValue; 
	public RustInput VariableInput; 
	public Tooltip TooltipComponent; 


	public void Populate(Admin.ServerConvarInfo convarInfo) { }

	public void OnSubmitVariable() { }

	public void .ctor() { }

}

public class ServerAdminPlayerEntry : MonoBehaviour // TypeDefIndex: 13815
{
	public RustText PlayerName; 
	public RustText Ping; 
	public RustButton Button; 
	[CompilerGeneratedAttribute] 
	private Admin.PlayerInfo <CachedInfo>k__BackingField; 
	private Action selectedAction; 
	private Action deselectedAction; 

	public Admin.PlayerInfo CachedInfo { get; set; }


	[CompilerGeneratedAttribute] 
	public Admin.PlayerInfo get_CachedInfo() { }

	[CompilerGeneratedAttribute] 
	private void set_CachedInfo(Admin.PlayerInfo value) { }

	public void Populate(Admin.PlayerInfo info, Action onSelected, Action onDeselected) { }

	public void OnToggled() { }

	public void .ctor() { }

}

public class ServerAdminPlayerId : MonoBehaviour // TypeDefIndex: 13816
{
	public RustText PlayerName; 
	public RustText PlayerId; 


	public void Populate(ulong playerId) { }

	public void .ctor() { }

}

public class ServerAdminPlayerInfo : MonoBehaviour // TypeDefIndex: 13817
{
	public RustText PlayerName; 
	public RustText SteamID; 
	public RustText OwnerSteamID; 
	public RustText Ping; 
	public RustText Address; 
	public RustText ConnectedTime; 
	public RustText ViolationLevel; 
	public RustText Health; 
	public RustInput KickReasonInput; 
	public RustInput BanReasonInput; 
	[CompilerGeneratedAttribute] 
	private Admin.PlayerInfo <CachedInfo>k__BackingField; 

	public Admin.PlayerInfo CachedInfo { get; set; }


	[CompilerGeneratedAttribute] 
	public Admin.PlayerInfo get_CachedInfo() { }

	[CompilerGeneratedAttribute] 
	public void set_CachedInfo(Admin.PlayerInfo value) { }

	public void Populate(Admin.PlayerInfo info) { }

	public void OnClickedKick() { }

	public void OnClickedBan() { }

	public void OnClickedSpectate() { }

	public void .ctor() { }

}

public class ServerAdminServerInfo : MonoBehaviour // TypeDefIndex: 13818
{
	public RustText InfoName; 
	public RustText InfoValue; 


	public void Populate(string variableName, string variableValue) { }

	public void .ctor() { }

}

public class ServerAdminUGCEntry : MonoBehaviour // TypeDefIndex: 13819
{
	protected Admin.ServerUGCInfo cachedInfo; 
	private Action<byte[]> receivedCallback; 


	public void Populate(Admin.ServerUGCInfo info) { }

	protected virtual void OnVisible(Admin.ServerUGCInfo info) { }

	protected void GetData(Action<byte[]> callback, int index = 0) { }

	public bool EntityMatches(uint entityId) { }

	public bool DataMatches(uint crc) { }

	public void ReceivedDataFromServer(byte[] data) { }

	public void .ctor() { }

}

public class ServerAdminUGCEntryAudio : ServerAdminUGCEntry // TypeDefIndex: 13820
{
	public AudioSource AudioSpeaker; 
	public RustText DurationText; 
	public RustSlider ProgressSlider; 
	public RustIcon PlayIcon; 
	private bool blockSeek; 


	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	protected void Update() { }

	public void OnClickedPlay() { }

	public void SeekToAudioPosition(float val) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <OnVisible>b__5_0(byte[] bytes) { }

	[CompilerGeneratedAttribute] 
	private void <OnVisible>b__5_1(AudioClip clip, bool b) { }

}

public class ServerAdminUGCEntryImage : ServerAdminUGCEntry // TypeDefIndex: 13821
{
	public RawImage Image; 
	public RectTransform Backing; 
	public GameObject MultiImageRoot; 
	public RustText ImageIndex; 
	public Vector2 OriginalImageSize; 
	private int currentIndex; 


	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	private void GetDataForCurrentIndex() { }

	private void OnImageLoaded(Texture2D texture) { }

	public void IncrementImage(int direction) { }

	public void OnClickedExpand() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <GetDataForCurrentIndex>b__7_0(byte[] bytes) { }

}

public class ServerAdminUGCEntryPattern : ServerAdminUGCEntry // TypeDefIndex: 13822
{
	public GameObjectRef StarPrefab; 
	public RectTransform StarRoot; 


	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	public void OnLoadedPattern(List<PatternFirework.Star> stars) { }

	private void ClearStars() { }

	private void PlaceStar(Vector2 localPosition, Color color) { }

	public void .ctor() { }

}

public class ServerAdminUGCEntryStub : MonoBehaviour // TypeDefIndex: 13823
{
	public ServerAdminUGCEntryAudio AudioWidget; 
	public ServerAdminUGCEntryImage ImageWidget; 
	public ServerAdminUGCEntryPattern PatternWidget; 
	public RustText PrefabName; 
	public RustButton HistoryButton; 
	public ServerAdminPlayerId[] HistoryIds; 
	protected Admin.ServerUGCInfo cachedInfo; 


	public void Populate(Admin.ServerUGCInfo info) { }

	public void DeleteUGC() { }

	public void .ctor() { }

}

public class ServerAdminUI : SingletonComponent<ServerAdminUI> // TypeDefIndex: 13824
{
	public GameObjectRef PlayerEntry; 
	public RectTransform PlayerInfoParent; 
	public RustText PlayerCount; 
	public RustInput PlayerNameFilter; 
	public GameObjectRef ServerInfoEntry; 
	public RectTransform ServerInfoParent; 
	public GameObjectRef ConvarInfoEntry; 
	public GameObjectRef ConvarInfoLongEntry; 
	public RectTransform ConvarInfoParent; 
	public ServerAdminPlayerInfo PlayerInfo; 
	public RustInput UgcNameFilter; 
	public GameObjectRef ImageEntry; 
	public GameObjectRef PatternEntry; 
	public GameObjectRef SoundEntry; 
	public VirtualScroll UgcVirtualScroll; 
	public GameObject ExpandedUgcRoot; 
	public RawImage ExpandedImage; 
	public RectTransform ExpandedImageBacking; 
	private Vector2 initialExpandedImageSize; 
	private List<ServerAdminPlayerEntry> playerEntries; 
	private List<ServerAdminUGCEntry> ugcEntries; 
	private ServerAdminUI.UGCDataSource UgcSource; 

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

	public void OnUGCDeleted(Admin.ServerUGCInfo info) { }

	public void ShowExpandedImage(Texture2D tex, Admin.ServerUGCInfo forInfo) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private GameObjectRef <PopulateConvarInfo>b__38_0(Admin.ServerConvarInfo convarInfo) { }

}

private class ServerAdminUI.UGCDataSource : VirtualScroll.IDataSource // TypeDefIndex: 13825
{
	private List<Admin.ServerUGCInfo> rawInfo; 
	private List<Admin.ServerUGCInfo> filteredInfo; 
	private string lastFilter; 


	public int GetItemCount() { }

	public void SetItemData(int i, GameObject obj) { }

	public void SetInfo(List<Admin.ServerUGCInfo> newInfo) { }

	public void SetFilter(string filter) { }

	public void RemoveEntry(Admin.ServerUGCInfo info) { }

	public void .ctor() { }

}

private sealed class ServerAdminUI.<>c__DisplayClass33_0 // TypeDefIndex: 13826
{
	public ServerAdminUI <>4__this; 
	public string oldSelectedPlayer; 
	public Action <>9__3; 


	public void .ctor() { }

	internal GameObjectRef <PopulatePlayerInfo>b__0(Admin.PlayerInfo playerInfo) { }

	internal void <PopulatePlayerInfo>b__1(Admin.PlayerInfo playerInfo, ServerAdminPlayerEntry entry) { }

	internal void <PopulatePlayerInfo>b__3() { }

}

private sealed class ServerAdminUI.<>c__DisplayClass33_1 // TypeDefIndex: 13827
{
	public Admin.PlayerInfo playerInfo; 
	public ServerAdminUI.<>c__DisplayClass33_0 CS$<>8__locals1; 


	public void .ctor() { }

	internal void <PopulatePlayerInfo>b__2() { }

}

private sealed class ServerAdminUI.<>c // TypeDefIndex: 13828
{
	public static readonly ServerAdminUI.<>c <>9; 
	public static Action<Admin.ServerConvarInfo, ServerAdminConvarInfo> <>9__38_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <PopulateConvarInfo>b__38_1(Admin.ServerConvarInfo convarInfo, ServerAdminConvarInfo adminConvarInfo) { }

}

