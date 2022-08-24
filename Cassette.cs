public class Cassette : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6389
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint audioId; 
	public uint holder; 
	public ulong creatorSteamId; 
	public int preloadAudioId; 


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
{
	private static List<Cassette.LoadRequest> loadQueue; 
	private static bool isLoading; 
	public float MaxCassetteLength; 
	[ReplicatedVar] 
	public static float MaxCassetteFileSizeMB; 
	[CompilerGeneratedAttribute] 
	private uint <AudioId>k__BackingField; 
	public ulong CreatorSteamId; 
	public PreloadedCassetteContent.PreloadType PreloadType; 
	public PreloadedCassetteContent PreloadContent; 
	public SoundDefinition InsertCassetteSfx; 
	public int ViewmodelIndex; 
	public Sprite HudSprite; 
	public int MaximumVoicemailSlots; 
	private int preloadedAudioId; 
	private uint cachedId; 
	private AudioClip cachedClip; 
	private bool notifyOnLoad; 
	private Action<AudioClip> audioLoadFromServerCallback; 

	public uint AudioId { get; set; }
	public SoundDefinition PreloadedAudio { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public static void RequestAudioLoad(byte[] data, Action<AudioClip, bool> onComplete, BaseEntity targetEntity) { }

	public static void RunCassetteQueue() { }

	public static void LoadAudio(byte[] data, Action<AudioClip, bool> onComplete) { }

	[CompilerGeneratedAttribute] 
	public uint get_AudioId() { }

	[CompilerGeneratedAttribute] 
	private void set_AudioId(uint value) { }

	public SoundDefinition get_PreloadedAudio() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void OnParentChangingClient(Transform oldParent, Transform newParent) { }

	private void ForceLoadNotify() { }

	public void WriteNewAudio(byte[] data, Action<AudioClip> onAudioReady, ulong userSteamId) { }

	public void RequestFileUpdate(Action<AudioClip> onAudioReady) { }

	[BaseEntity.RPC_Client] 
	public void Client_ReceiveAudio(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void FailedNetworkFileRequest(BaseEntity.RPCMessage msg) { }

	public static bool IsOggValid(byte[] data, Cassette c) { }

	private static bool IsOggValid(byte[] data, float maxLength) { }

	private static float ByteToMegabyte(int byteSize) { }

	private static double GetOggLength(byte[] t) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	private void <Client_ReceiveAudio>b__32_0(AudioClip clip, bool success) { }

}

private struct Cassette.LoadRequest // TypeDefIndex: 8545
{
	public byte[] Data; 
	public Action<AudioClip, bool> Callback; 
	public BaseEntity ForEntity; 

}

private sealed class Cassette.<>c__DisplayClass29_0 // TypeDefIndex: 8546
{
	public Cassette <>4__this; 
	public Action<AudioClip> onAudioReady; 


	public void .ctor() { }

	internal void <WriteNewAudio>b__0(AudioClip clip, bool success) { }

}

private sealed class Cassette.<>c__DisplayClass31_0 // TypeDefIndex: 8547
{
	public Cassette <>4__this; 
	public byte[] data; 
	public Action<AudioClip> onAudioReady; 


	public void .ctor() { }

	internal void <RequestFileUpdate>b__0(AudioClip clip, bool success) { }

}

