public class Cassette : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6389
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint audioId; // 0x14
	public uint holder; // 0x18
	public ulong creatorSteamId; // 0x20
	public int preloadAudioId; // 0x28

	// Methods

	// RVA: 0x20A2EC0 Offset: 0x20A22C0 VA: 0x1820A2EC0
	public static void ResetToPool(Cassette instance) { }

	// RVA: 0x20A2E20 Offset: 0x20A2220 VA: 0x1820A2E20
	public void ResetToPool() { }

	// RVA: 0x20A2AD0 Offset: 0x20A1ED0 VA: 0x1820A2AD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20A1910 Offset: 0x20A0D10 VA: 0x1820A1910
	public void CopyTo(Cassette instance) { }

	// RVA: 0x20A1940 Offset: 0x20A0D40 VA: 0x1820A1940
	public Cassette Copy() { }

	// RVA: 0x20A2380 Offset: 0x20A1780 VA: 0x1820A2380
	public static Cassette Deserialize(Stream stream) { }

	// RVA: 0x20A1CA0 Offset: 0x20A10A0 VA: 0x1820A1CA0
	public static Cassette DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A1D20 Offset: 0x20A1120 VA: 0x1820A1D20
	public static Cassette DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A2070 Offset: 0x20A1470 VA: 0x1820A2070
	public static Cassette Deserialize(byte[] buffer) { }

	// RVA: 0x20A2BF0 Offset: 0x20A1FF0 VA: 0x1820A2BF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A34A0 Offset: 0x20A28A0 VA: 0x1820A34A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A34C0 Offset: 0x20A28C0 VA: 0x1820A34C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Cassette previous) { }

	// RVA: 0x20A2E00 Offset: 0x20A2200 VA: 0x1820A2E00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A25D0 Offset: 0x20A19D0 VA: 0x1820A25D0
	public static Cassette Deserialize(byte[] buffer, Cassette instance, bool isDelta = False) { }

	// RVA: 0x20A28C0 Offset: 0x20A1CC0 VA: 0x1820A28C0
	public static Cassette Deserialize(Stream stream, Cassette instance, bool isDelta) { }

	// RVA: 0x20A19C0 Offset: 0x20A0DC0 VA: 0x1820A19C0
	public static Cassette DeserializeLengthDelimited(Stream stream, Cassette instance, bool isDelta) { }

	// RVA: 0x20A1DB0 Offset: 0x20A11B0 VA: 0x1820A1DB0
	public static Cassette DeserializeLength(Stream stream, int length, Cassette instance, bool isDelta) { }

	// RVA: 0x20A2F60 Offset: 0x20A2360 VA: 0x1820A2F60
	public static void SerializeDelta(Stream stream, Cassette instance, Cassette previous) { }

	// RVA: 0x20A3340 Offset: 0x20A2740 VA: 0x1820A3340
	public static void Serialize(Stream stream, Cassette instance) { }

	// RVA: 0x20A3490 Offset: 0x20A2890 VA: 0x1820A3490
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A34A0 Offset: 0x20A28A0 VA: 0x1820A34A0
	public void ToProto(Stream stream) { }

	// RVA: 0x20A3230 Offset: 0x20A2630 VA: 0x1820A3230
	public static byte[] SerializeToBytes(Cassette instance) { }

	// RVA: 0x20A3180 Offset: 0x20A2580 VA: 0x1820A3180
	public static void SerializeLengthDelimited(Stream stream, Cassette instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Cassette : BaseEntity, IUGCBrowserEntity // TypeDefIndex: 8544
{	// Fields
	private static List<Cassette.LoadRequest> loadQueue; // 0x0
	private static bool isLoading; // 0x8
	public float MaxCassetteLength; // 0x168
	[ReplicatedVar] // RVA: 0xA98E0 Offset: 0xA8CE0 VA: 0x1800A98E0
	public static float MaxCassetteFileSizeMB; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <AudioId>k__BackingField; // 0x16C
	public ulong CreatorSteamId; // 0x170
	public PreloadedCassetteContent.PreloadType PreloadType; // 0x178
	public PreloadedCassetteContent PreloadContent; // 0x180
	public SoundDefinition InsertCassetteSfx; // 0x188
	public int ViewmodelIndex; // 0x190
	public Sprite HudSprite; // 0x198
	public int MaximumVoicemailSlots; // 0x1A0
	private int preloadedAudioId; // 0x1A4
	private uint cachedId; // 0x1A8
	private AudioClip cachedClip; // 0x1B0
	private bool notifyOnLoad; // 0x1B8
	private Action<AudioClip> audioLoadFromServerCallback; // 0x1C0

	// Properties
	public uint AudioId { get; set; }
	public SoundDefinition PreloadedAudio { get; }

	// Methods

	// RVA: 0x549D80 Offset: 0x549180 VA: 0x180549D80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x54A550 Offset: 0x549950 VA: 0x18054A550
	public static void RequestAudioLoad(byte[] data, Action<AudioClip, bool> onComplete, BaseEntity targetEntity) { }

	// RVA: 0x54A9C0 Offset: 0x549DC0 VA: 0x18054A9C0
	public static void RunCassetteQueue() { }

	// RVA: 0x549760 Offset: 0x548B60 VA: 0x180549760
	public static void LoadAudio(byte[] data, Action<AudioClip, bool> onComplete) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54AF70 Offset: 0x54A370 VA: 0x18054AF70
	public uint get_AudioId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54AFC0 Offset: 0x54A3C0 VA: 0x18054AFC0
	private void set_AudioId(uint value) { }

	// RVA: 0x54AF80 Offset: 0x54A380 VA: 0x18054AF80
	public SoundDefinition get_PreloadedAudio() { }

	// RVA: 0x549A60 Offset: 0x548E60 VA: 0x180549A60 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x549C60 Offset: 0x549060 VA: 0x180549C60 Slot: 81
	public override void OnParentChangingClient(Transform oldParent, Transform newParent) { }

	// RVA: 0x548D30 Offset: 0x548130 VA: 0x180548D30
	private void ForceLoadNotify() { }

	// RVA: 0x54ABF0 Offset: 0x549FF0 VA: 0x18054ABF0
	public void WriteNewAudio(byte[] data, Action<AudioClip> onAudioReady, ulong userSteamId) { }

	// RVA: 0x54A6F0 Offset: 0x549AF0 VA: 0x18054A6F0
	public void RequestFileUpdate(Action<AudioClip> onAudioReady) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5489F0 Offset: 0x547DF0 VA: 0x1805489F0
	public void Client_ReceiveAudio(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x548CA0 Offset: 0x5480A0 VA: 0x180548CA0
	private void FailedNetworkFileRequest(BaseEntity.RPCMessage msg) { }

	// RVA: 0x549420 Offset: 0x548820 VA: 0x180549420
	public static bool IsOggValid(byte[] data, Cassette c) { }

	// RVA: 0x5495F0 Offset: 0x5489F0 VA: 0x1805495F0
	private static bool IsOggValid(byte[] data, float maxLength) { }

	// RVA: 0x5489D0 Offset: 0x547DD0 VA: 0x1805489D0
	private static float ByteToMegabyte(int byteSize) { }

	// RVA: 0x548DE0 Offset: 0x5481E0 VA: 0x180548DE0
	private static double GetOggLength(byte[] t) { }

	// RVA: 0x54AF00 Offset: 0x54A300 VA: 0x18054AF00
	public void .ctor() { }

	// RVA: 0x54AE70 Offset: 0x54A270 VA: 0x18054AE70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54AB20 Offset: 0x549F20 VA: 0x18054AB20
	private void <Client_ReceiveAudio>b__32_0(AudioClip clip, bool success) { }

}

private struct Cassette.LoadRequest // TypeDefIndex: 8545
{	// Fields
	public byte[] Data; // 0x0
	public Action<AudioClip, bool> Callback; // 0x8
	public BaseEntity ForEntity; // 0x10

}

private sealed class Cassette.<>c__DisplayClass29_0 // TypeDefIndex: 8546
{	// Fields
	public Cassette <>4__this; // 0x10
	public Action<AudioClip> onAudioReady; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x560990 Offset: 0x55FD90 VA: 0x180560990
	internal void <WriteNewAudio>b__0(AudioClip clip, bool success) { }

}

private sealed class Cassette.<>c__DisplayClass31_0 // TypeDefIndex: 8547
{	// Fields
	public Cassette <>4__this; // 0x10
	public byte[] data; // 0x18
	public Action<AudioClip> onAudioReady; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x560A80 Offset: 0x55FE80 VA: 0x180560A80
	internal void <RequestFileUpdate>b__0(AudioClip clip, bool success) { }

}

