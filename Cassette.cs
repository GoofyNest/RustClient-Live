public class Cassette : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6389
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint audioId; // 0x14
	public uint holder; // 0x18
	public ulong creatorSteamId; // 0x20
	public int preloadAudioId; // 0x28


	public static void ResetToPool(Cassette instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Cassette instance) { }

	public Cassette Copy() { }

	public static Cassette Deserialize(Stream stream) { }

	public static Cassette DeserializeLengthDelimited(Stream stream) { }

	public static Cassette DeserializeLength(Stream stream, int length) { }

	public static Cassette Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Cassette previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Cassette Deserialize(byte[] buffer, Cassette instance, bool isDelta = False) { }

	public static Cassette Deserialize(Stream stream, Cassette instance, bool isDelta) { }

	public static Cassette DeserializeLengthDelimited(Stream stream, Cassette instance, bool isDelta) { }

	public static Cassette DeserializeLength(Stream stream, int length, Cassette instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Cassette instance, Cassette previous) { }

	public static void Serialize(Stream stream, Cassette instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Cassette instance) { }

	public static void SerializeLengthDelimited(Stream stream, Cassette instance) { }

	public void .ctor() { }

}

public class Cassette : BaseEntity, IUGCBrowserEntity // TypeDefIndex: 8544
{	private static List<Cassette.LoadRequest> loadQueue; // 0x0
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

	public uint AudioId { get; set; }
	public SoundDefinition PreloadedAudio { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public static void RequestAudioLoad(byte[] data, Action<AudioClip, bool> onComplete, BaseEntity targetEntity) { }

	public static void RunCassetteQueue() { }

	public static void LoadAudio(byte[] data, Action<AudioClip, bool> onComplete) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint get_AudioId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_AudioId(uint value) { }

	public SoundDefinition get_PreloadedAudio() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void OnParentChangingClient(Transform oldParent, Transform newParent) { }

	private void ForceLoadNotify() { }

	public void WriteNewAudio(byte[] data, Action<AudioClip> onAudioReady, ulong userSteamId) { }

	public void RequestFileUpdate(Action<AudioClip> onAudioReady) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_ReceiveAudio(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void FailedNetworkFileRequest(BaseEntity.RPCMessage msg) { }

	public static bool IsOggValid(byte[] data, Cassette c) { }

	private static bool IsOggValid(byte[] data, float maxLength) { }

	private static float ByteToMegabyte(int byteSize) { }

	private static double GetOggLength(byte[] t) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Client_ReceiveAudio>b__32_0(AudioClip clip, bool success) { }

}

private struct Cassette.LoadRequest // TypeDefIndex: 8545
{	public byte[] Data; // 0x0
	public Action<AudioClip, bool> Callback; // 0x8
	public BaseEntity ForEntity; // 0x10

}

private sealed class Cassette.<>c__DisplayClass29_0 // TypeDefIndex: 8546
{	public Cassette <>4__this; // 0x10
	public Action<AudioClip> onAudioReady; // 0x18


	public void .ctor() { }

	internal void <WriteNewAudio>b__0(AudioClip clip, bool success) { }

}

private sealed class Cassette.<>c__DisplayClass31_0 // TypeDefIndex: 8547
{	public Cassette <>4__this; // 0x10
	public byte[] data; // 0x18
	public Action<AudioClip> onAudioReady; // 0x20


	public void .ctor() { }

	internal void <RequestFileUpdate>b__0(AudioClip clip, bool success) { }

}

