public class MicrophoneStand : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6418
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int microphoneMode; 
	public uint IORef; 


	public static void ResetToPool(MicrophoneStand instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MicrophoneStand instance) { }

	public MicrophoneStand Copy() { }

	public static MicrophoneStand Deserialize(Stream stream) { }

	public static MicrophoneStand DeserializeLengthDelimited(Stream stream) { }

	public static MicrophoneStand DeserializeLength(Stream stream, int length) { }

	public static MicrophoneStand Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MicrophoneStand previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MicrophoneStand Deserialize(byte[] buffer, MicrophoneStand instance, bool isDelta = False) { }

	public static MicrophoneStand Deserialize(Stream stream, MicrophoneStand instance, bool isDelta) { }

	public static MicrophoneStand DeserializeLengthDelimited(Stream stream, MicrophoneStand instance, bool isDelta) { }

	public static MicrophoneStand DeserializeLength(Stream stream, int length, MicrophoneStand instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MicrophoneStand instance, MicrophoneStand previous) { }

	public static void Serialize(Stream stream, MicrophoneStand instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MicrophoneStand instance) { }

	public static void SerializeLengthDelimited(Stream stream, MicrophoneStand instance) { }

	public void .ctor() { }

}

public class MicrophoneStand : BaseMountable // TypeDefIndex: 10277
{
	public VoiceProcessor VoiceProcessor; 
	public AudioSource VoiceSource; 
	private MicrophoneStand.SpeechMode currentSpeechMode; 
	public AudioMixerGroup NormalMix; 
	public AudioMixerGroup HighPitchMix; 
	public AudioMixerGroup LowPitchMix; 
	public Translate.Phrase NormalPhrase; 
	public Translate.Phrase NormalDescPhrase; 
	public Translate.Phrase HighPitchPhrase; 
	public Translate.Phrase HighPitchDescPhrase; 
	public Translate.Phrase LowPitchPhrase; 
	public Translate.Phrase LowPitchDescPhrase; 
	public GameObjectRef IOSubEntity; 
	public Transform IOSubEntitySpawnPos; 
	public bool IsStatic; 
	public EntityRef<IOEntity> ioEntity; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private void Update() { }

	public override void OnClientInput(BasePlayer player) { }

	public bool Receive(byte[] data) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <OnClientInput>b__19_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] 
	private void <OnClientInput>b__19_1(BasePlayer ply) { }

	[CompilerGeneratedAttribute] 
	private void <OnClientInput>b__19_2(BasePlayer ply) { }

}

public enum MicrophoneStand.SpeechMode // TypeDefIndex: 10278
{
	public int value__; 
	public const MicrophoneStand.SpeechMode Normal = 0;
	public const MicrophoneStand.SpeechMode HighPitch = 1;
	public const MicrophoneStand.SpeechMode LowPitch = 2;

}

