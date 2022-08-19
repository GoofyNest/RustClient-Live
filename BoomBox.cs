public class BoomBox : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6391
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string radioIp; // 0x18
	public ulong assignedRadioBy; // 0x20

	// Methods

	// RVA: 0x1F671A0 Offset: 0x1F665A0 VA: 0x181F671A0
	public static void ResetToPool(BoomBox instance) { }

	// RVA: 0x1F670F0 Offset: 0x1F664F0 VA: 0x181F670F0
	public void ResetToPool() { }

	// RVA: 0x1F66F90 Offset: 0x1F66390 VA: 0x181F66F90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DA81B0 Offset: 0x1DA75B0 VA: 0x181DA81B0
	public void CopyTo(BoomBox instance) { }

	// RVA: 0x1F66290 Offset: 0x1F65690 VA: 0x181F66290
	public BoomBox Copy() { }

	// RVA: 0x1F66DD0 Offset: 0x1F661D0 VA: 0x181F66DD0
	public static BoomBox Deserialize(Stream stream) { }

	// RVA: 0x1F66580 Offset: 0x1F65980 VA: 0x181F66580
	public static BoomBox DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F66600 Offset: 0x1F65A00 VA: 0x181F66600
	public static BoomBox DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F668D0 Offset: 0x1F65CD0 VA: 0x181F668D0
	public static BoomBox Deserialize(byte[] buffer) { }

	// RVA: 0x1F670B0 Offset: 0x1F664B0 VA: 0x181F670B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F67700 Offset: 0x1F66B00 VA: 0x181F67700 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F67720 Offset: 0x1F66B20 VA: 0x181F67720 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BoomBox previous) { }

	// RVA: 0x1F670D0 Offset: 0x1F664D0 VA: 0x181F670D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F66CD0 Offset: 0x1F660D0 VA: 0x181F66CD0
	public static BoomBox Deserialize(byte[] buffer, BoomBox instance, bool isDelta = False) { }

	// RVA: 0x1F66B50 Offset: 0x1F65F50 VA: 0x181F66B50
	public static BoomBox Deserialize(Stream stream, BoomBox instance, bool isDelta) { }

	// RVA: 0x1F66320 Offset: 0x1F65720 VA: 0x181F66320
	public static BoomBox DeserializeLengthDelimited(Stream stream, BoomBox instance, bool isDelta) { }

	// RVA: 0x1F66690 Offset: 0x1F65A90 VA: 0x181F66690
	public static BoomBox DeserializeLength(Stream stream, int length, BoomBox instance, bool isDelta) { }

	// RVA: 0x1F67250 Offset: 0x1F66650 VA: 0x181F67250
	public static void SerializeDelta(Stream stream, BoomBox instance, BoomBox previous) { }

	// RVA: 0x1F675A0 Offset: 0x1F669A0 VA: 0x181F675A0
	public static void Serialize(Stream stream, BoomBox instance) { }

	// RVA: 0x1F676F0 Offset: 0x1F66AF0 VA: 0x181F676F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F67700 Offset: 0x1F66B00 VA: 0x181F67700
	public void ToProto(Stream stream) { }

	// RVA: 0x1F67490 Offset: 0x1F66890 VA: 0x181F67490
	public static byte[] SerializeToBytes(BoomBox instance) { }

	// RVA: 0x1F673E0 Offset: 0x1F667E0 VA: 0x181F673E0
	public static void SerializeLengthDelimited(Stream stream, BoomBox instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class BoomBox : EntityComponent<BaseEntity>, INotifyLOD // TypeDefIndex: 9436
{	// Fields
	public static Dictionary<string, string> ValidStations; // 0x0
	public static Dictionary<string, string> ServerValidStations; // 0x8
	[ReplicatedVar] // RVA: 0xF0130 Offset: 0xEF530 VA: 0x1800F0130
	public static string ServerUrlList; // 0x10
	private static string lastParsedServerList; // 0x18
	public ShoutcastStreamer ShoutcastStreamer; // 0x20
	public GameObjectRef RadioIpDialog; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <CurrentRadioIp>k__BackingField; // 0x30
	public ulong AssignedRadioBy; // 0x38
	public AudioSource SoundSource; // 0x40
	public float ConditionLossRate; // 0x48
	public ItemDefinition[] ValidCassettes; // 0x50
	public SoundDefinition PlaySfx; // 0x58
	public SoundDefinition StopSfx; // 0x60
	public const BaseEntity.Flags HasCassette = 128;
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Cassette <CurrentCassette>k__BackingField; // 0x68
	private float localPlayerAchievementTime; // 0x70
	private bool hasAwardedLocalPlayerAchievement; // 0x74

	// Properties
	public string CurrentRadioIp { get; set; }
	private bool IsLocalPlayer { get; }
	public BaseEntity BaseEntity { get; }
	public Cassette CurrentCassette { get; set; }
	private bool isClient { get; }

	// Methods

	// RVA: 0x531C00 Offset: 0x531000 VA: 0x180531C00
	public static void LoadStations() { }

	// RVA: 0x531680 Offset: 0x530A80 VA: 0x180531680
	private static string GetStationData() { }

	// RVA: 0x531AD0 Offset: 0x530ED0 VA: 0x180531AD0
	private static bool IsStationValid(string url) { }

	// RVA: 0x532990 Offset: 0x531D90 VA: 0x180532990
	public static void ParseServerUrlList() { }

	// RVA: 0x532F60 Offset: 0x532360 VA: 0x180532F60
	public static void ResetServerValidStations() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_CurrentRadioIp() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	private void set_CurrentRadioIp(string value) { }

	// RVA: 0x531310 Offset: 0x530710 VA: 0x180531310
	public void ChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x5321E0 Offset: 0x5315E0 VA: 0x1805321E0
	public void OnChangedBoomBoxSettings(string newIP) { }

	// RVA: 0x531110 Offset: 0x530510 VA: 0x180531110
	public bool CanChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x532940 Offset: 0x531D40 VA: 0x180532940
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	// RVA: 0x533500 Offset: 0x532900 VA: 0x180533500
	private bool get_IsLocalPlayer() { }

	// RVA: 0x531E60 Offset: 0x531260 VA: 0x180531E60
	public void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5334B0 Offset: 0x5328B0 VA: 0x1805334B0
	public BaseEntity get_BaseEntity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public Cassette get_CurrentCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	private void set_CurrentCassette(Cassette value) { }

	// RVA: 0x532D10 Offset: 0x532110 VA: 0x180532D10
	public void Play(BasePlayer forPlayer) { }

	// RVA: 0x533180 Offset: 0x532580 VA: 0x180533180
	public void Stop(BasePlayer forPlayer) { }

	// RVA: 0x531270 Offset: 0x530670 VA: 0x180531270
	public bool CanStop(BasePlayer forPlayer) { }

	// RVA: 0x5311C0 Offset: 0x5305C0 VA: 0x1805311C0
	public bool CanStart(BasePlayer forPlayer) { }

	// RVA: 0x5317C0 Offset: 0x530BC0 VA: 0x1805317C0
	private bool HasTape() { }

	// RVA: 0x533310 Offset: 0x532710 VA: 0x180533310
	private void UpdateAudioClip(AudioClip clip) { }

	// RVA: 0x531490 Offset: 0x530890 VA: 0x180531490
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	// RVA: 0x531630 Offset: 0x530A30 VA: 0x180531630
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	// RVA: 0x532250 Offset: 0x531650 VA: 0x180532250
	public void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next, DeployableBoomBox deployable) { }

	// RVA: 0x531EC0 Offset: 0x5312C0 VA: 0x180531EC0
	private void LocalPlayerRadioTick() { }

	// RVA: 0x532EA0 Offset: 0x5322A0 VA: 0x180532EA0
	public void RequestCassetteAudioUpdate() { }

	// RVA: 0x5328B0 Offset: 0x531CB0 VA: 0x1805328B0
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x532120 Offset: 0x531520 VA: 0x180532120
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x5330A0 Offset: 0x5324A0 VA: 0x1805330A0 Slot: 10
	public void Show() { }

	// RVA: 0x531820 Offset: 0x530C20 VA: 0x180531820 Slot: 11
	public void Hide() { }

	// RVA: 0x531990 Offset: 0x530D90 VA: 0x180531990
	private bool IsPowered() { }

	// RVA: 0x5318E0 Offset: 0x530CE0 VA: 0x1805318E0
	private bool IsOn() { }

	// RVA: 0x531700 Offset: 0x530B00 VA: 0x180531700
	private bool HasFlag(BaseEntity.Flags f) { }

	// RVA: 0x532FD0 Offset: 0x5323D0 VA: 0x180532FD0
	private void SetFlag(BaseEntity.Flags f, bool state) { }

	// RVA: 0x533640 Offset: 0x532A40 VA: 0x180533640
	private bool get_isClient() { }

	// RVA: 0x533450 Offset: 0x532850 VA: 0x180533450
	public void .ctor() { }

	// RVA: 0x533400 Offset: 0x532800 VA: 0x180533400
	private static void .cctor() { }

}

