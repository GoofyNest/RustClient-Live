public class MicrophoneStand : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6417
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int microphoneMode; // 0x14
	public uint IORef; // 0x18

	// Methods

	// RVA: 0x1F41780 Offset: 0x1F40B80 VA: 0x181F41780
	public static void ResetToPool(MicrophoneStand instance) { }

	// RVA: 0x1F41800 Offset: 0x1F40C00 VA: 0x181F41800
	public void ResetToPool() { }

	// RVA: 0x1F414E0 Offset: 0x1F408E0 VA: 0x181F414E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(MicrophoneStand instance) { }

	// RVA: 0x1F406E0 Offset: 0x1F3FAE0 VA: 0x181F406E0
	public MicrophoneStand Copy() { }

	// RVA: 0x1F41320 Offset: 0x1F40720 VA: 0x181F41320
	public static MicrophoneStand Deserialize(Stream stream) { }

	// RVA: 0x1F40750 Offset: 0x1F3FB50 VA: 0x181F40750
	public static MicrophoneStand DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F40A20 Offset: 0x1F3FE20 VA: 0x181F40A20
	public static MicrophoneStand DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F410B0 Offset: 0x1F404B0 VA: 0x181F410B0
	public static MicrophoneStand Deserialize(byte[] buffer) { }

	// RVA: 0x1F415E0 Offset: 0x1F409E0 VA: 0x181F415E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F41CC0 Offset: 0x1F410C0 VA: 0x181F41CC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F41CE0 Offset: 0x1F410E0 VA: 0x181F41CE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MicrophoneStand previous) { }

	// RVA: 0x1F41760 Offset: 0x1F40B60 VA: 0x181F41760 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F40E60 Offset: 0x1F40260 VA: 0x181F40E60
	public static MicrophoneStand Deserialize(byte[] buffer, MicrophoneStand instance, bool isDelta = False) { }

	// RVA: 0x1F40CE0 Offset: 0x1F400E0 VA: 0x181F40CE0
	public static MicrophoneStand Deserialize(Stream stream, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F407D0 Offset: 0x1F3FBD0 VA: 0x181F407D0
	public static MicrophoneStand DeserializeLengthDelimited(Stream stream, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F40AB0 Offset: 0x1F3FEB0 VA: 0x181F40AB0
	public static MicrophoneStand DeserializeLength(Stream stream, int length, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F41880 Offset: 0x1F40C80 VA: 0x181F41880
	public static void SerializeDelta(Stream stream, MicrophoneStand instance, MicrophoneStand previous) { }

	// RVA: 0x1F41BB0 Offset: 0x1F40FB0 VA: 0x181F41BB0
	public static void Serialize(Stream stream, MicrophoneStand instance) { }

	// RVA: 0x1F41CB0 Offset: 0x1F410B0 VA: 0x181F41CB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F41CC0 Offset: 0x1F410C0 VA: 0x181F41CC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F41AA0 Offset: 0x1F40EA0 VA: 0x181F41AA0
	public static byte[] SerializeToBytes(MicrophoneStand instance) { }

	// RVA: 0x1F419F0 Offset: 0x1F40DF0 VA: 0x181F419F0
	public static void SerializeLengthDelimited(Stream stream, MicrophoneStand instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class MicrophoneStand : BaseMountable // TypeDefIndex: 8605
{	// Fields
	public VoiceProcessor VoiceProcessor; // 0x320
	public AudioSource VoiceSource; // 0x328
	private MicrophoneStand.SpeechMode currentSpeechMode; // 0x330
	public AudioMixerGroup NormalMix; // 0x338
	public AudioMixerGroup HighPitchMix; // 0x340
	public AudioMixerGroup LowPitchMix; // 0x348
	public Translate.Phrase NormalPhrase; // 0x350
	public Translate.Phrase NormalDescPhrase; // 0x358
	public Translate.Phrase HighPitchPhrase; // 0x360
	public Translate.Phrase HighPitchDescPhrase; // 0x368
	public Translate.Phrase LowPitchPhrase; // 0x370
	public Translate.Phrase LowPitchDescPhrase; // 0x378
	public GameObjectRef IOSubEntity; // 0x380
	public Transform IOSubEntitySpawnPos; // 0x388
	public bool IsStatic; // 0x390
	public EntityRef<IOEntity> ioEntity; // 0x398

	// Methods

	// RVA: 0x967910 Offset: 0x966D10 VA: 0x180967910 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x967C50 Offset: 0x967050 VA: 0x180967C50
	private void Update() { }

	// RVA: 0x9675E0 Offset: 0x9669E0 VA: 0x1809675E0 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x967A00 Offset: 0x966E00 VA: 0x180967A00
	public bool Receive(byte[] data) { }

	// RVA: 0x967480 Offset: 0x966880 VA: 0x180967480 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x9674B0 Offset: 0x9668B0 VA: 0x1809674B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x967CA0 Offset: 0x9670A0 VA: 0x180967CA0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x967B60 Offset: 0x966F60 VA: 0x180967B60
	private void <OnClientInput>b__19_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x967BB0 Offset: 0x966FB0 VA: 0x180967BB0
	private void <OnClientInput>b__19_1(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x967C00 Offset: 0x967000 VA: 0x180967C00
	private void <OnClientInput>b__19_2(BasePlayer ply) { }

}

public enum MicrophoneStand.SpeechMode // TypeDefIndex: 8606
{	// Fields
	public int value__; // 0x0
	public const MicrophoneStand.SpeechMode Normal = 0;
	public const MicrophoneStand.SpeechMode HighPitch = 1;
	public const MicrophoneStand.SpeechMode LowPitch = 2;

}

