public class ModelState : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6274
{
// Namespace: 
public class ModelState : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6274
	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float waterLevel; // 0x14
	public Vector3 lookDir; // 0x18
	public int flags; // 0x24
	public int poseType; // 0x28
	public Vector3 inheritedVelocity; // 0x2C

	// Properties
	public bool ducked { get; set; }
	public bool jumped { get; set; }
	public bool onground { get; set; }
	public bool sleeping { get; set; }
	public bool sprinting { get; set; }
	public bool onLadder { get; set; }
	public bool flying { get; set; }
	public bool aiming { get; set; }
	public bool prone { get; set; }
	public bool mounted { get; set; }
	public bool relaxed { get; set; }
	public bool crawling { get; set; }
	public bool onPhone { get; set; }
	public bool headLook { get; set; }

	// Methods

	// RVA: 0x201A030 Offset: 0x2019430 VA: 0x18201A030
	public void .ctor() { }

	// RVA: 0x2019510 Offset: 0x2018910 VA: 0x182019510
	public bool HasFlag(ModelState.Flag f) { }

	// RVA: 0x2019FC0 Offset: 0x20193C0 VA: 0x182019FC0
	public void SetFlag(ModelState.Flag f, bool b) { }

	// RVA: 0x201A080 Offset: 0x2019480 VA: 0x18201A080
	public bool get_ducked() { }

	// RVA: 0x201A180 Offset: 0x2019580 VA: 0x18201A180
	public void set_ducked(bool value) { }

	// RVA: 0x201A0B0 Offset: 0x20194B0 VA: 0x18201A0B0
	public bool get_jumped() { }

	// RVA: 0x201A1E0 Offset: 0x20195E0 VA: 0x18201A1E0
	public void set_jumped(bool value) { }

	// RVA: 0x201A0F0 Offset: 0x20194F0 VA: 0x18201A0F0
	public bool get_onground() { }

	// RVA: 0x201A260 Offset: 0x2019660 VA: 0x18201A260
	public void set_onground(bool value) { }

	// RVA: 0x201A120 Offset: 0x2019520 VA: 0x18201A120
	public bool get_sleeping() { }

	// RVA: 0x201A2C0 Offset: 0x20196C0 VA: 0x18201A2C0
	public void set_sleeping(bool value) { }

	// RVA: 0x201A130 Offset: 0x2019530 VA: 0x18201A130
	public bool get_sprinting() { }

	// RVA: 0x201A2E0 Offset: 0x20196E0 VA: 0x18201A2E0
	public void set_sprinting(bool value) { }

	// RVA: 0x201A0D0 Offset: 0x20194D0 VA: 0x18201A0D0
	public bool get_onLadder() { }

	// RVA: 0x201A220 Offset: 0x2019620 VA: 0x18201A220
	public void set_onLadder(bool value) { }

	// RVA: 0x201A090 Offset: 0x2019490 VA: 0x18201A090
	public bool get_flying() { }

	// RVA: 0x201A1A0 Offset: 0x20195A0 VA: 0x18201A1A0
	public void set_flying(bool value) { }

	// RVA: 0x201A060 Offset: 0x2019460 VA: 0x18201A060
	public bool get_aiming() { }

	// RVA: 0x201A140 Offset: 0x2019540 VA: 0x18201A140
	public void set_aiming(bool value) { }

	// RVA: 0x201A100 Offset: 0x2019500 VA: 0x18201A100
	public bool get_prone() { }

	// RVA: 0x201A280 Offset: 0x2019680 VA: 0x18201A280
	public void set_prone(bool value) { }

	// RVA: 0x201A0C0 Offset: 0x20194C0 VA: 0x18201A0C0
	public bool get_mounted() { }

	// RVA: 0x201A200 Offset: 0x2019600 VA: 0x18201A200
	public void set_mounted(bool value) { }

	// RVA: 0x201A110 Offset: 0x2019510 VA: 0x18201A110
	public bool get_relaxed() { }

	// RVA: 0x201A2A0 Offset: 0x20196A0 VA: 0x18201A2A0
	public void set_relaxed(bool value) { }

	// RVA: 0x201A070 Offset: 0x2019470 VA: 0x18201A070
	public bool get_crawling() { }

	// RVA: 0x201A160 Offset: 0x2019560 VA: 0x18201A160
	public void set_crawling(bool value) { }

	// RVA: 0x201A0E0 Offset: 0x20194E0 VA: 0x18201A0E0
	public bool get_onPhone() { }

	// RVA: 0x201A240 Offset: 0x2019640 VA: 0x18201A240
	public void set_onPhone(bool value) { }

	// RVA: 0x201A0A0 Offset: 0x20194A0 VA: 0x18201A0A0
	public bool get_headLook() { }

	// RVA: 0x201A1C0 Offset: 0x20195C0 VA: 0x18201A1C0
	public void set_headLook(bool value) { }

	// RVA: 0x20191B0 Offset: 0x20185B0 VA: 0x1820191B0
	public static bool Equal(ModelState a, ModelState b) { }

	// RVA: 0x20195F0 Offset: 0x20189F0 VA: 0x1820195F0
	public static void ResetToPool(ModelState instance) { }

	// RVA: 0x2019540 Offset: 0x2018940 VA: 0x182019540
	public void ResetToPool() { }

	// RVA: 0x2019130 Offset: 0x2018530 VA: 0x182019130 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2017E10 Offset: 0x2017210 VA: 0x182017E10
	public void CopyTo(ModelState instance) { }

	// RVA: 0x2017E60 Offset: 0x2017260 VA: 0x182017E60
	public ModelState Copy() { }

	// RVA: 0x2018EB0 Offset: 0x20182B0 VA: 0x182018EB0
	public static ModelState Deserialize(Stream stream) { }

	// RVA: 0x2017F00 Offset: 0x2017300 VA: 0x182017F00
	public static ModelState DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2018590 Offset: 0x2017990 VA: 0x182018590
	public static ModelState DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2018B80 Offset: 0x2017F80 VA: 0x182018B80
	public static ModelState Deserialize(byte[] buffer) { }

	// RVA: 0x20192C0 Offset: 0x20186C0 VA: 0x1820192C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2019FF0 Offset: 0x20193F0 VA: 0x182019FF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201A010 Offset: 0x2019410 VA: 0x18201A010 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModelState previous) { }

	// RVA: 0x2019520 Offset: 0x2018920 VA: 0x182019520 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2018620 Offset: 0x2017A20 VA: 0x182018620
	public static ModelState Deserialize(byte[] buffer, ModelState instance, bool isDelta = False) { }

	// RVA: 0x2018930 Offset: 0x2017D30 VA: 0x182018930
	public static ModelState Deserialize(Stream stream, ModelState instance, bool isDelta) { }

	// RVA: 0x2017F80 Offset: 0x2017380 VA: 0x182017F80
	public static ModelState DeserializeLengthDelimited(Stream stream, ModelState instance, bool isDelta) { }

	// RVA: 0x20182A0 Offset: 0x20176A0 VA: 0x1820182A0
	public static ModelState DeserializeLength(Stream stream, int length, ModelState instance, bool isDelta) { }

	// RVA: 0x20196A0 Offset: 0x2018AA0 VA: 0x1820196A0
	public static void SerializeDelta(Stream stream, ModelState instance, ModelState previous) { }

	// RVA: 0x2019D00 Offset: 0x2019100 VA: 0x182019D00
	public static void Serialize(Stream stream, ModelState instance) { }

	// RVA: 0x2019FE0 Offset: 0x20193E0 VA: 0x182019FE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2019FF0 Offset: 0x20193F0 VA: 0x182019FF0
	public void ToProto(Stream stream) { }

	// RVA: 0x2019BF0 Offset: 0x2018FF0 VA: 0x182019BF0
	public static byte[] SerializeToBytes(ModelState instance) { }

	// RVA: 0x2019B40 Offset: 0x2018F40 VA: 0x182019B40
	public static void SerializeLengthDelimited(Stream stream, ModelState instance) { }

}

public enum ModelState.Flag // TypeDefIndex: 6275
{	// Fields
	public int value__; // 0x0
	public const ModelState.Flag Ducked = 1;
	public const ModelState.Flag Jumped = 2;
	public const ModelState.Flag OnGround = 4;
	public const ModelState.Flag Sleeping = 8;
	public const ModelState.Flag Sprinting = 16;
	public const ModelState.Flag OnLadder = 32;
	public const ModelState.Flag Flying = 64;
	public const ModelState.Flag Aiming = 128;
	public const ModelState.Flag Prone = 256;
	public const ModelState.Flag Mounted = 512;
	public const ModelState.Flag Relaxed = 1024;
	public const ModelState.Flag OnPhone = 2048;
	public const ModelState.Flag Crawling = 4096;
	public const ModelState.Flag HeadLook = 16384;

}

