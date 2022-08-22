public class VoicemailEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6415
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint audioId; // 0x14
	public string userName; // 0x18
	public long timestamp; // 0x20


	public static void ResetToPool(VoicemailEntry instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(VoicemailEntry instance) { }

	public VoicemailEntry Copy() { }

	public static VoicemailEntry Deserialize(Stream stream) { }

	public static VoicemailEntry DeserializeLengthDelimited(Stream stream) { }

	public static VoicemailEntry DeserializeLength(Stream stream, int length) { }

	public static VoicemailEntry Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, VoicemailEntry previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static VoicemailEntry Deserialize(byte[] buffer, VoicemailEntry instance, bool isDelta = False) { }

	public static VoicemailEntry Deserialize(Stream stream, VoicemailEntry instance, bool isDelta) { }

	public static VoicemailEntry DeserializeLengthDelimited(Stream stream, VoicemailEntry instance, bool isDelta) { }

	public static VoicemailEntry DeserializeLength(Stream stream, int length, VoicemailEntry instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, VoicemailEntry instance, VoicemailEntry previous) { }

	public static void Serialize(Stream stream, VoicemailEntry instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(VoicemailEntry instance) { }

	public static void SerializeLengthDelimited(Stream stream, VoicemailEntry instance) { }

	public void .ctor() { }

}

public class VoicemailEntry : MonoBehaviour // TypeDefIndex: 10901
{	public GameObject PlayingRoot; // 0x18
	public RustText DisplayName; // 0x20
	public RustIcon PlayIcon; // 0x28
	public RustSlider ProgressSlider; // 0x30
	private bool playingState; // 0x38
	private uint cachedId; // 0x3C
	private VoicemailDialog parentDialog; // 0x40
	private float lastTime; // 0x48


	public void Populate(VoicemailEntry entry, VoicemailDialog dialog) { }

	public void OnClickedPlay() { }

	public void CancelPlay() { }

	private void UpdateIcon() { }

	public void OnClickedDelete() { }

	private void Update() { }

	public void .ctor() { }

}

