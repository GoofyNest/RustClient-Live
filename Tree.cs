public class Tree : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6496
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint netId; // 0x14
	public uint prefabId; // 0x18
	public Half3 position; // 0x1C
	public float scale; // 0x28

	// Methods

	// RVA: 0x1EF00C0 Offset: 0x1EEF4C0 VA: 0x181EF00C0
	public static void ResetToPool(Tree instance) { }

	// RVA: 0x1EF0160 Offset: 0x1EEF560 VA: 0x181EF0160
	public void ResetToPool() { }

	// RVA: 0x1EEFE00 Offset: 0x1EEF200 VA: 0x181EEFE00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EEEC60 Offset: 0x1EEE060 VA: 0x181EEEC60
	public void CopyTo(Tree instance) { }

	// RVA: 0x1EEECA0 Offset: 0x1EEE0A0 VA: 0x181EEECA0
	public Tree Copy() { }

	// RVA: 0x1EEFBB0 Offset: 0x1EEEFB0 VA: 0x181EEFBB0
	public static Tree Deserialize(Stream stream) { }

	// RVA: 0x1EEF010 Offset: 0x1EEE410 VA: 0x181EEF010
	public static Tree DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEF090 Offset: 0x1EEE490 VA: 0x181EEF090
	public static Tree DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEF8C0 Offset: 0x1EEECC0 VA: 0x181EEF8C0
	public static Tree Deserialize(byte[] buffer) { }

	// RVA: 0x1EEFE80 Offset: 0x1EEF280 VA: 0x181EEFE80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF0890 Offset: 0x1EEFC90 VA: 0x181EF0890 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF08B0 Offset: 0x1EEFCB0 VA: 0x181EF08B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Tree previous) { }

	// RVA: 0x1EF00A0 Offset: 0x1EEF4A0 VA: 0x181EF00A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEF3D0 Offset: 0x1EEE7D0 VA: 0x181EEF3D0
	public static Tree Deserialize(byte[] buffer, Tree instance, bool isDelta = False) { }

	// RVA: 0x1EEF6A0 Offset: 0x1EEEAA0 VA: 0x181EEF6A0
	public static Tree Deserialize(Stream stream, Tree instance, bool isDelta) { }

	// RVA: 0x1EEED30 Offset: 0x1EEE130 VA: 0x181EEED30
	public static Tree DeserializeLengthDelimited(Stream stream, Tree instance, bool isDelta) { }

	// RVA: 0x1EEF120 Offset: 0x1EEE520 VA: 0x181EEF120
	public static Tree DeserializeLength(Stream stream, int length, Tree instance, bool isDelta) { }

	// RVA: 0x1EF0200 Offset: 0x1EEF600 VA: 0x181EF0200
	public static void SerializeDelta(Stream stream, Tree instance, Tree previous) { }

	// RVA: 0x1EF0690 Offset: 0x1EEFA90 VA: 0x181EF0690
	public static void Serialize(Stream stream, Tree instance) { }

	// RVA: 0x1EF0880 Offset: 0x1EEFC80 VA: 0x181EF0880
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF0890 Offset: 0x1EEFC90 VA: 0x181EF0890
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF0580 Offset: 0x1EEF980 VA: 0x181EF0580
	public static byte[] SerializeToBytes(Tree instance) { }

	// RVA: 0x1EF04D0 Offset: 0x1EEF8D0 VA: 0x181EF04D0
	public static void SerializeLengthDelimited(Stream stream, Tree instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

internal sealed class Tree // TypeDefIndex: 6953
{	// Fields
	private static readonly int HEAP_SIZE; // 0x0
	internal static readonly int[] ExtraLengthBits; // 0x8
	internal static readonly int[] ExtraDistanceBits; // 0x10
	internal static readonly int[] extra_blbits; // 0x18
	internal static readonly sbyte[] bl_order; // 0x20
	private static readonly sbyte[] _dist_code; // 0x28
	internal static readonly sbyte[] LengthCode; // 0x30
	internal static readonly int[] LengthBase; // 0x38
	internal static readonly int[] DistanceBase; // 0x40
	internal short[] dyn_tree; // 0x10
	internal int max_code; // 0x18
	internal StaticTree staticTree; // 0x20

	// Methods

	// RVA: 0x21CFCD0 Offset: 0x21CF0D0 VA: 0x1821CFCD0
	internal static int DistanceCode(int dist) { }

	// RVA: 0x21D0750 Offset: 0x21CFB50 VA: 0x1821D0750
	internal void gen_bitlen(DeflateManager s) { }

	// RVA: 0x21D0080 Offset: 0x21CF480 VA: 0x1821D0080
	internal void build_tree(DeflateManager s) { }

	// RVA: 0x21D0C60 Offset: 0x21D0060 VA: 0x1821D0C60
	internal static void gen_codes(short[] tree, int max_code, short[] bl_count) { }

	// RVA: 0x21D0050 Offset: 0x21CF450 VA: 0x1821D0050
	internal static int bi_reverse(int code, int len) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x21CFDC0 Offset: 0x21CF1C0 VA: 0x1821CFDC0
	private static void .cctor() { }

}

public class Tree : ConsoleSystem // TypeDefIndex: 11966
{	// Fields
	private static float m_quality; // 0x0
	private static int m_meshes; // 0x4

	// Properties
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int meshes { get; set; }

	// Methods

	// RVA: 0x36ADB0 Offset: 0x36A1B0 VA: 0x18036ADB0
	public static float get_quality() { }

	// RVA: 0x36AF80 Offset: 0x36A380 VA: 0x18036AF80
	public static void set_quality(float value) { }

	// RVA: 0x36ACA0 Offset: 0x36A0A0 VA: 0x18036ACA0
	public static float get_lod() { }

	// RVA: 0x36ABC0 Offset: 0x369FC0 VA: 0x18036ABC0
	public static float get_cull() { }

	// RVA: 0x36AD50 Offset: 0x36A150 VA: 0x18036AD50
	public static int get_meshes() { }

	// RVA: 0x36AE10 Offset: 0x36A210 VA: 0x18036AE10
	public static void set_meshes(int value) { }

	// RVA: 0x36AB60 Offset: 0x369F60 VA: 0x18036AB60
	public void .ctor() { }

	// RVA: 0x36AB10 Offset: 0x369F10 VA: 0x18036AB10
	private static void .cctor() { }

}

