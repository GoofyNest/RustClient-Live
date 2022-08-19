public class VoicemailEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6415
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint audioId; // 0x14
	public string userName; // 0x18
	public long timestamp; // 0x20

	// Methods

	// RVA: 0x1E4ACA0 Offset: 0x1E4A0A0 VA: 0x181E4ACA0
	public static void ResetToPool(VoicemailEntry instance) { }

	// RVA: 0x1E4ABF0 Offset: 0x1E49FF0 VA: 0x181E4ABF0
	public void ResetToPool() { }

	// RVA: 0x1E4A8E0 Offset: 0x1E49CE0 VA: 0x181E4A8E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E498F0 Offset: 0x1E48CF0 VA: 0x181E498F0
	public void CopyTo(VoicemailEntry instance) { }

	// RVA: 0x1E49940 Offset: 0x1E48D40 VA: 0x181E49940
	public VoicemailEntry Copy() { }

	// RVA: 0x1E4A6E0 Offset: 0x1E49AE0 VA: 0x181E4A6E0
	public static VoicemailEntry Deserialize(Stream stream) { }

	// RVA: 0x1E49C60 Offset: 0x1E49060 VA: 0x181E49C60
	public static VoicemailEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E49CE0 Offset: 0x1E490E0 VA: 0x181E49CE0
	public static VoicemailEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4A270 Offset: 0x1E49670 VA: 0x181E4A270
	public static VoicemailEntry Deserialize(byte[] buffer) { }

	// RVA: 0x1E4AA10 Offset: 0x1E49E10 VA: 0x181E4AA10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E4B430 Offset: 0x1E4A830 VA: 0x181E4B430 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E4B450 Offset: 0x1E4A850 VA: 0x181E4B450 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VoicemailEntry previous) { }

	// RVA: 0x1E4ABD0 Offset: 0x1E49FD0 VA: 0x181E4ABD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E49FE0 Offset: 0x1E493E0 VA: 0x181E49FE0
	public static VoicemailEntry Deserialize(byte[] buffer, VoicemailEntry instance, bool isDelta = False) { }

	// RVA: 0x1E4A520 Offset: 0x1E49920 VA: 0x181E4A520
	public static VoicemailEntry Deserialize(Stream stream, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E499D0 Offset: 0x1E48DD0 VA: 0x181E499D0
	public static VoicemailEntry DeserializeLengthDelimited(Stream stream, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E49D70 Offset: 0x1E49170 VA: 0x181E49D70
	public static VoicemailEntry DeserializeLength(Stream stream, int length, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E4AD50 Offset: 0x1E4A150 VA: 0x181E4AD50
	public static void SerializeDelta(Stream stream, VoicemailEntry instance, VoicemailEntry previous) { }

	// RVA: 0x1E4B1F0 Offset: 0x1E4A5F0 VA: 0x181E4B1F0
	public static void Serialize(Stream stream, VoicemailEntry instance) { }

	// RVA: 0x1E4B420 Offset: 0x1E4A820 VA: 0x181E4B420
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E4B430 Offset: 0x1E4A830 VA: 0x181E4B430
	public void ToProto(Stream stream) { }

	// RVA: 0x1E4B0E0 Offset: 0x1E4A4E0 VA: 0x181E4B0E0
	public static byte[] SerializeToBytes(VoicemailEntry instance) { }

	// RVA: 0x1E4AFF0 Offset: 0x1E4A3F0 VA: 0x181E4AFF0
	public static void SerializeLengthDelimited(Stream stream, VoicemailEntry instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class VoicemailEntry : MonoBehaviour // TypeDefIndex: 10901
{	// Fields
	public GameObject PlayingRoot; // 0x18
	public RustText DisplayName; // 0x20
	public RustIcon PlayIcon; // 0x28
	public RustSlider ProgressSlider; // 0x30
	private bool playingState; // 0x38
	private uint cachedId; // 0x3C
	private VoicemailDialog parentDialog; // 0x40
	private float lastTime; // 0x48

	// Methods

	// RVA: 0x7E2F30 Offset: 0x7E2330 VA: 0x1807E2F30
	public void Populate(VoicemailEntry entry, VoicemailDialog dialog) { }

	// RVA: 0x7E2EA0 Offset: 0x7E22A0 VA: 0x1807E2EA0
	public void OnClickedPlay() { }

	// RVA: 0x7E2D10 Offset: 0x7E2110 VA: 0x1807E2D10
	public void CancelPlay() { }

	// RVA: 0x7E3290 Offset: 0x7E2690 VA: 0x1807E3290
	private void UpdateIcon() { }

	// RVA: 0x7E2D60 Offset: 0x7E2160 VA: 0x1807E2D60
	public void OnClickedDelete() { }

	// RVA: 0x7E3320 Offset: 0x7E2720 VA: 0x1807E3320
	private void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

