public class ConnectedSpeaker : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6414
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint connectedTo; // 0x14

	// Methods

	// RVA: 0x20AD170 Offset: 0x20AC570 VA: 0x1820AD170
	public static void ResetToPool(ConnectedSpeaker instance) { }

	// RVA: 0x20AD1F0 Offset: 0x20AC5F0 VA: 0x1820AD1F0
	public void ResetToPool() { }

	// RVA: 0x20AD040 Offset: 0x20AC440 VA: 0x1820AD040 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(ConnectedSpeaker instance) { }

	// RVA: 0x20AC6C0 Offset: 0x20ABAC0 VA: 0x1820AC6C0
	public ConnectedSpeaker Copy() { }

	// RVA: 0x20ACEC0 Offset: 0x20AC2C0 VA: 0x1820ACEC0
	public static ConnectedSpeaker Deserialize(Stream stream) { }

	// RVA: 0x20AC730 Offset: 0x20ABB30 VA: 0x1820AC730
	public static ConnectedSpeaker DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20ACBD0 Offset: 0x20ABFD0 VA: 0x1820ACBD0
	public static ConnectedSpeaker DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20ACC60 Offset: 0x20AC060 VA: 0x1820ACC60
	public static ConnectedSpeaker Deserialize(byte[] buffer) { }

	// RVA: 0x20AD130 Offset: 0x20AC530 VA: 0x1820AD130
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AD6C0 Offset: 0x20ACAC0 VA: 0x1820AD6C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AD790 Offset: 0x20ACB90 VA: 0x1820AD790 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ConnectedSpeaker previous) { }

	// RVA: 0x20AD150 Offset: 0x20AC550 VA: 0x1820AD150 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20ACF40 Offset: 0x20AC340 VA: 0x1820ACF40
	public static ConnectedSpeaker Deserialize(byte[] buffer, ConnectedSpeaker instance, bool isDelta = False) { }

	// RVA: 0x20ACD80 Offset: 0x20AC180 VA: 0x1820ACD80
	public static ConnectedSpeaker Deserialize(Stream stream, ConnectedSpeaker instance, bool isDelta) { }

	// RVA: 0x20AC7B0 Offset: 0x20ABBB0 VA: 0x1820AC7B0
	public static ConnectedSpeaker DeserializeLengthDelimited(Stream stream, ConnectedSpeaker instance, bool isDelta) { }

	// RVA: 0x20AC9D0 Offset: 0x20ABDD0 VA: 0x1820AC9D0
	public static ConnectedSpeaker DeserializeLength(Stream stream, int length, ConnectedSpeaker instance, bool isDelta) { }

	// RVA: 0x20AD270 Offset: 0x20AC670 VA: 0x1820AD270
	public static void SerializeDelta(Stream stream, ConnectedSpeaker instance, ConnectedSpeaker previous) { }

	// RVA: 0x20AD5E0 Offset: 0x20AC9E0 VA: 0x1820AD5E0
	public static void Serialize(Stream stream, ConnectedSpeaker instance) { }

	// RVA: 0x20AD6B0 Offset: 0x20ACAB0 VA: 0x1820AD6B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AD6C0 Offset: 0x20ACAC0 VA: 0x1820AD6C0
	public void ToProto(Stream stream) { }

	// RVA: 0x20AD430 Offset: 0x20AC830 VA: 0x1820AD430
	public static byte[] SerializeToBytes(ConnectedSpeaker instance) { }

	// RVA: 0x20AD380 Offset: 0x20AC780 VA: 0x1820AD380
	public static void SerializeLengthDelimited(Stream stream, ConnectedSpeaker instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ConnectedSpeaker : IOEntity // TypeDefIndex: 8563
{	// Fields
	public AudioSource SoundSource; // 0x288
	private EntityRef<IOEntity> connectedTo; // 0x290
	public VoiceProcessor VoiceProcessor; // 0x2A0
	private ShoutcastStreamer connectedToStreamer; // 0x2A8
	private VoiceProcessor connectedToProcessor; // 0x2B0
	private bool isPlayingStreamedAudio; // 0x2B8
	private uint currentReadIndex; // 0x2BC

	// Methods

	// RVA: 0x2F9C50 Offset: 0x2F9050 VA: 0x1802F9C50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x2FA650 Offset: 0x2F9A50 VA: 0x1802FA650 Slot: 27
	public override void ResetState() { }

	// RVA: 0x2FAA00 Offset: 0x2F9E00 VA: 0x1802FAA00
	public void SetAudio(Sound sound) { }

	// RVA: 0x2FAC70 Offset: 0x2FA070 VA: 0x1802FAC70
	public void StopPlaying() { }

	// RVA: 0x2F9AB0 Offset: 0x2F8EB0 VA: 0x1802F9AB0
	private void OnAudioRead(float[] data) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2F96C0 Offset: 0x2F8AC0 VA: 0x1802F96C0
	private void Client_PlayAudioFrom(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2F9830 Offset: 0x2F8C30 VA: 0x1802F9830
	private void Client_StopPlayingAudio(BaseEntity.RPCMessage msg) { }

	// RVA: 0x2F95D0 Offset: 0x2F89D0 VA: 0x1802F95D0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x2FA740 Offset: 0x2F9B40 VA: 0x1802FA740
	public void SetAudio(AudioClip clip, float time) { }

	// RVA: 0x2FA7B0 Offset: 0x2F9BB0 VA: 0x1802FA7B0
	public void SetAudio(ShoutcastStreamer streamer, AudioClip clip, float time) { }

	// RVA: 0x2FAE60 Offset: 0x2FA260 VA: 0x1802FAE60
	private void UpdatePlaylist() { }

	// RVA: 0x2FAB80 Offset: 0x2F9F80 VA: 0x1802FAB80
	public void SetAudio(VoiceProcessor processor) { }

	// RVA: 0x2FB050 Offset: 0x2FA450 VA: 0x1802FB050
	private void VoiceUpdate() { }

	// RVA: 0x2F99E0 Offset: 0x2F8DE0 VA: 0x1802F99E0
	public Vector3 GetWorldPosition() { }

	// RVA: 0x2F99A0 Offset: 0x2F8DA0 VA: 0x1802F99A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x2F9B90 Offset: 0x2F8F90 VA: 0x1802F9B90 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x2F9A30 Offset: 0x2F8E30 VA: 0x1802F9A30 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x2FB080 Offset: 0x2FA480 VA: 0x1802FB080
	public void .ctor() { }

}

