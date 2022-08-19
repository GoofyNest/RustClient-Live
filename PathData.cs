public class PathData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6510
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public bool spline; // 0x20
	public bool start; // 0x21
	public bool end; // 0x22
	public float width; // 0x24
	public float innerPadding; // 0x28
	public float outerPadding; // 0x2C
	public float innerFade; // 0x30
	public float outerFade; // 0x34
	public float randomScale; // 0x38
	public float meshOffset; // 0x3C
	public float terrainOffset; // 0x40
	public int splat; // 0x44
	public int topology; // 0x48
	public List<VectorData> nodes; // 0x50
	public int hierarchy; // 0x58

	// Methods

	// RVA: 0x1F919F0 Offset: 0x1F90DF0 VA: 0x181F919F0
	public static void ResetToPool(PathData instance) { }

	// RVA: 0x1F91800 Offset: 0x1F90C00 VA: 0x181F91800
	public void ResetToPool() { }

	// RVA: 0x1F91550 Offset: 0x1F90950 VA: 0x181F91550 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F8FAC0 Offset: 0x1F8EEC0 VA: 0x181F8FAC0
	public void CopyTo(PathData instance) { }

	// RVA: 0x1F8FC90 Offset: 0x1F8F090 VA: 0x181F8FC90
	public PathData Copy() { }

	// RVA: 0x1F90CE0 Offset: 0x1F900E0 VA: 0x181F90CE0
	public static PathData Deserialize(Stream stream) { }

	// RVA: 0x1F90550 Offset: 0x1F8F950 VA: 0x181F90550
	public static PathData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F90C50 Offset: 0x1F90050 VA: 0x181F90C50
	public static PathData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F91330 Offset: 0x1F90730 VA: 0x181F91330
	public static PathData Deserialize(byte[] buffer) { }

	// RVA: 0x1F917C0 Offset: 0x1F90BC0 VA: 0x181F917C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F92990 Offset: 0x1F91D90 VA: 0x181F92990 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F929B0 Offset: 0x1F91DB0 VA: 0x181F929B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PathData previous) { }

	// RVA: 0x1F917E0 Offset: 0x1F90BE0 VA: 0x181F917E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F91450 Offset: 0x1F90850 VA: 0x181F91450
	public static PathData Deserialize(byte[] buffer, PathData instance, bool isDelta = False) { }

	// RVA: 0x1F90D60 Offset: 0x1F90160 VA: 0x181F90D60
	public static PathData Deserialize(Stream stream, PathData instance, bool isDelta) { }

	// RVA: 0x1F8FEB0 Offset: 0x1F8F2B0 VA: 0x181F8FEB0
	public static PathData DeserializeLengthDelimited(Stream stream, PathData instance, bool isDelta) { }

	// RVA: 0x1F905D0 Offset: 0x1F8F9D0 VA: 0x181F905D0
	public static PathData DeserializeLength(Stream stream, int length, PathData instance, bool isDelta) { }

	// RVA: 0x1F91BE0 Offset: 0x1F90FE0 VA: 0x181F91BE0
	public static void SerializeDelta(Stream stream, PathData instance, PathData previous) { }

	// RVA: 0x1F924B0 Offset: 0x1F918B0 VA: 0x181F924B0
	public static void Serialize(Stream stream, PathData instance) { }

	// RVA: 0x1F92980 Offset: 0x1F91D80 VA: 0x181F92980
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F92990 Offset: 0x1F91D90 VA: 0x181F92990
	public void ToProto(Stream stream) { }

	// RVA: 0x1F923A0 Offset: 0x1F917A0 VA: 0x181F923A0
	public static byte[] SerializeToBytes(PathData instance) { }

	// RVA: 0x1F922F0 Offset: 0x1F916F0 VA: 0x181F922F0
	public static void SerializeLengthDelimited(Stream stream, PathData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

