public class VoicemailEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6415
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint audioId; 
	public string userName; 
	public long timestamp; 


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
{
	public GameObject PlayingRoot; 
	public RustText DisplayName; 
	public RustIcon PlayIcon; 
	public RustSlider ProgressSlider; 
	private bool playingState; 
	private uint cachedId; 
	private VoicemailDialog parentDialog; 
	private float lastTime; 


public void Populate(VoicemailEntry entry, VoicemailDialog dialog) { }

public void OnClickedPlay() { }

public void CancelPlay() { }

private void UpdateIcon() { }

public void OnClickedDelete() { }

private void Update() { }

public void .ctor() { }

}

