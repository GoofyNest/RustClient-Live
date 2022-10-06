public class BoomBox : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6395
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string radioIp; 
	public ulong assignedRadioBy; 


	public static void ResetToPool(BoomBox instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BoomBox instance) { }

	public BoomBox Copy() { }

	public static BoomBox Deserialize(Stream stream) { }

	public static BoomBox DeserializeLengthDelimited(Stream stream) { }

	public static BoomBox DeserializeLength(Stream stream, int length) { }

	public static BoomBox Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BoomBox previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BoomBox Deserialize(byte[] buffer, BoomBox instance, bool isDelta = False) { }

	public static BoomBox Deserialize(Stream stream, BoomBox instance, bool isDelta) { }

	public static BoomBox DeserializeLengthDelimited(Stream stream, BoomBox instance, bool isDelta) { }

	public static BoomBox DeserializeLength(Stream stream, int length, BoomBox instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BoomBox instance, BoomBox previous) { }

	public static void Serialize(Stream stream, BoomBox instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BoomBox instance) { }

	public static void SerializeLengthDelimited(Stream stream, BoomBox instance) { }

	public void .ctor() { }

}

public class BoomBox : EntityComponent<BaseEntity>, INotifyLOD // TypeDefIndex: 11146
{
	public static Dictionary<string, string> ValidStations; 
	public static Dictionary<string, string> ServerValidStations; 
	[ReplicatedVar] 
	public static string ServerUrlList; 
	private static string lastParsedServerList; 
	public ShoutcastStreamer ShoutcastStreamer; 
	public GameObjectRef RadioIpDialog; 
	[CompilerGeneratedAttribute] 
	private string <CurrentRadioIp>k__BackingField; 
	public ulong AssignedRadioBy; 
	public AudioSource SoundSource; 
	public float ConditionLossRate; 
	public ItemDefinition[] ValidCassettes; 
	public SoundDefinition PlaySfx; 
	public SoundDefinition StopSfx; 
	public const BaseEntity.Flags HasCassette = 128;
	[CompilerGeneratedAttribute] 
	private Cassette <CurrentCassette>k__BackingField; 
	private float localPlayerAchievementTime; 
	private bool hasAwardedLocalPlayerAchievement; 

	public string CurrentRadioIp { get; set; }
	private bool IsLocalPlayer { get; }
	public BaseEntity BaseEntity { get; }
	public Cassette CurrentCassette { get; set; }
	private bool isClient { get; }


	public static void LoadStations() { }

	private static Dictionary<string, string> GetStationData() { }

	private static bool IsStationValid(string url) { }

	public static void ParseServerUrlList() { }

	public static void ResetServerValidStations() { }

	[CompilerGeneratedAttribute] 
	public string get_CurrentRadioIp() { }

	[CompilerGeneratedAttribute] 
	private void set_CurrentRadioIp(string value) { }

	public void ChangeRadioSettings(BasePlayer player) { }

	public void OnChangedBoomBoxSettings(string newIP) { }

	public bool CanChangeRadioSettings(BasePlayer player) { }

	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	private bool get_IsLocalPlayer() { }

	public void Load(BaseNetworkable.LoadInfo info) { }

	public BaseEntity get_BaseEntity() { }

	[CompilerGeneratedAttribute] 
	public Cassette get_CurrentCassette() { }

	[CompilerGeneratedAttribute] 
	private void set_CurrentCassette(Cassette value) { }

	public void Play(BasePlayer forPlayer) { }

	public void Stop(BasePlayer forPlayer) { }

	public bool CanStop(BasePlayer forPlayer) { }

	public bool CanStart(BasePlayer forPlayer) { }

	private bool HasTape() { }

	private void UpdateAudioClip(AudioClip clip) { }

	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	public void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next, DeployableBoomBox deployable) { }

	private void LocalPlayerRadioTick() { }

	public void RequestCassetteAudioUpdate() { }

	public void OnLoadedWithCassette(Cassette c) { }

	public void OnCensorRecordingsChanged() { }

	public void Show() { }

	public void Hide() { }

	private bool IsPowered() { }

	private bool IsOn() { }

	private bool HasFlag(BaseEntity.Flags f) { }

	private void SetFlag(BaseEntity.Flags f, bool state) { }

	private bool get_isClient() { }

	public void .ctor() { }

	private static void .cctor() { }

}

