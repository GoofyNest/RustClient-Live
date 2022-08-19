public class Crane : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6413
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float yaw; // 0x14
	public float arm1; // 0x18
	public float arm2; // 0x1C
	public float magnet; // 0x20
	public float time; // 0x24
	public int treadInput; // 0x28

	// Methods

	// RVA: 0x20B04C0 Offset: 0x20AF8C0 VA: 0x1820B04C0
	public static void ResetToPool(Crane instance) { }

	// RVA: 0x20B0580 Offset: 0x20AF980 VA: 0x1820B0580
	public void ResetToPool() { }

	// RVA: 0x20B00C0 Offset: 0x20AF4C0 VA: 0x1820B00C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF5DF0 Offset: 0x1BF51F0 VA: 0x181BF5DF0
	public void CopyTo(Crane instance) { }

	// RVA: 0x20AEBC0 Offset: 0x20ADFC0 VA: 0x1820AEBC0
	public Crane Copy() { }

	// RVA: 0x20AF420 Offset: 0x20AE820 VA: 0x1820AF420
	public static Crane Deserialize(Stream stream) { }

	// RVA: 0x20AEC50 Offset: 0x20AE050 VA: 0x1820AEC50
	public static Crane DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AF040 Offset: 0x20AE440 VA: 0x1820AF040
	public static Crane DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AFD20 Offset: 0x20AF120 VA: 0x1820AFD20
	public static Crane Deserialize(byte[] buffer) { }

	// RVA: 0x20B0200 Offset: 0x20AF600 VA: 0x1820B0200
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B0C90 Offset: 0x20B0090 VA: 0x1820B0C90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B0CB0 Offset: 0x20B00B0 VA: 0x1820B0CB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Crane previous) { }

	// RVA: 0x20B04A0 Offset: 0x20AF8A0 VA: 0x1820B04A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AF9A0 Offset: 0x20AEDA0 VA: 0x1820AF9A0
	public static Crane Deserialize(byte[] buffer, Crane instance, bool isDelta = False) { }

	// RVA: 0x20AF700 Offset: 0x20AEB00 VA: 0x1820AF700
	public static Crane Deserialize(Stream stream, Crane instance, bool isDelta) { }

	// RVA: 0x20AECD0 Offset: 0x20AE0D0 VA: 0x1820AECD0
	public static Crane DeserializeLengthDelimited(Stream stream, Crane instance, bool isDelta) { }

	// RVA: 0x20AF0D0 Offset: 0x20AE4D0 VA: 0x1820AF0D0
	public static Crane DeserializeLength(Stream stream, int length, Crane instance, bool isDelta) { }

	// RVA: 0x20B0640 Offset: 0x20AFA40 VA: 0x1820B0640
	public static void SerializeDelta(Stream stream, Crane instance, Crane previous) { }

	// RVA: 0x20B0AE0 Offset: 0x20AFEE0 VA: 0x1820B0AE0
	public static void Serialize(Stream stream, Crane instance) { }

	// RVA: 0x20B0C80 Offset: 0x20B0080 VA: 0x1820B0C80
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B0C90 Offset: 0x20B0090 VA: 0x1820B0C90
	public void ToProto(Stream stream) { }

	// RVA: 0x20B09D0 Offset: 0x20AFDD0 VA: 0x1820B09D0
	public static byte[] SerializeToBytes(Crane instance) { }

	// RVA: 0x20B0920 Offset: 0x20AFD20 VA: 0x1820B0920
	public static void SerializeLengthDelimited(Stream stream, Crane instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

