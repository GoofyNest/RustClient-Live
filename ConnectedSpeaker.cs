public class ConnectedSpeaker : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6414
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint connectedTo; // 0x14


	public static void ResetToPool(ConnectedSpeaker instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ConnectedSpeaker instance) { }

	public ConnectedSpeaker Copy() { }

	public static ConnectedSpeaker Deserialize(Stream stream) { }

	public static ConnectedSpeaker DeserializeLengthDelimited(Stream stream) { }

	public static ConnectedSpeaker DeserializeLength(Stream stream, int length) { }

	public static ConnectedSpeaker Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ConnectedSpeaker previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ConnectedSpeaker Deserialize(byte[] buffer, ConnectedSpeaker instance, bool isDelta = False) { }

	public static ConnectedSpeaker Deserialize(Stream stream, ConnectedSpeaker instance, bool isDelta) { }

	public static ConnectedSpeaker DeserializeLengthDelimited(Stream stream, ConnectedSpeaker instance, bool isDelta) { }

	public static ConnectedSpeaker DeserializeLength(Stream stream, int length, ConnectedSpeaker instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ConnectedSpeaker instance, ConnectedSpeaker previous) { }

	public static void Serialize(Stream stream, ConnectedSpeaker instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ConnectedSpeaker instance) { }

	public static void SerializeLengthDelimited(Stream stream, ConnectedSpeaker instance) { }

	public void .ctor() { }

}

public class ConnectedSpeaker : IOEntity // TypeDefIndex: 8563
{	public AudioSource SoundSource; // 0x288
	private EntityRef<IOEntity> connectedTo; // 0x290
	public VoiceProcessor VoiceProcessor; // 0x2A0
	private ShoutcastStreamer connectedToStreamer; // 0x2A8
	private VoiceProcessor connectedToProcessor; // 0x2B0
	private bool isPlayingStreamedAudio; // 0x2B8
	private uint currentReadIndex; // 0x2BC


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	public void SetAudio(Sound sound) { }

	public void StopPlaying() { }

	private void OnAudioRead(float[] data) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_PlayAudioFrom(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_StopPlayingAudio(BaseEntity.RPCMessage msg) { }

	public override void ClientOnEnable() { }

	public void SetAudio(AudioClip clip, float time) { }

	public void SetAudio(ShoutcastStreamer streamer, AudioClip clip, float time) { }

	private void UpdatePlaylist() { }

	public void SetAudio(VoiceProcessor processor) { }

	private void VoiceUpdate() { }

	public Vector3 GetWorldPosition() { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

