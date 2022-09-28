public class ConnectedSpeaker : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6415
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint connectedTo; 


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

public class ConnectedSpeaker : IOEntity // TypeDefIndex: 10235
{
	public AudioSource SoundSource; 
	private EntityRef<IOEntity> connectedTo; 
	public VoiceProcessor VoiceProcessor; 
	private ShoutcastStreamer connectedToStreamer; 
	private VoiceProcessor connectedToProcessor; 
	private bool isPlayingStreamedAudio; 
	private uint currentReadIndex; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	public void SetAudio(Sound sound) { }

	public void StopPlaying() { }

	private void OnAudioRead(float[] data) { }

	[BaseEntity.RPC_Client] 
	private void Client_PlayAudioFrom(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
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

