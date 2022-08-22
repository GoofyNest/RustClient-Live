public class Tree : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6496
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint netId; // 0x14
	public uint prefabId; // 0x18
	public Half3 position; // 0x1C
	public float scale; // 0x28


	public static void ResetToPool(Tree instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Tree instance) { }

	public Tree Copy() { }

	public static Tree Deserialize(Stream stream) { }

	public static Tree DeserializeLengthDelimited(Stream stream) { }

	public static Tree DeserializeLength(Stream stream, int length) { }

	public static Tree Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Tree previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Tree Deserialize(byte[] buffer, Tree instance, bool isDelta = False) { }

	public static Tree Deserialize(Stream stream, Tree instance, bool isDelta) { }

	public static Tree DeserializeLengthDelimited(Stream stream, Tree instance, bool isDelta) { }

	public static Tree DeserializeLength(Stream stream, int length, Tree instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Tree instance, Tree previous) { }

	public static void Serialize(Stream stream, Tree instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Tree instance) { }

	public static void SerializeLengthDelimited(Stream stream, Tree instance) { }

	public void .ctor() { }

}

internal sealed class Tree // TypeDefIndex: 6953
{	private static readonly int HEAP_SIZE; // 0x0
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


	internal static int DistanceCode(int dist) { }

	internal void gen_bitlen(DeflateManager s) { }

	internal void build_tree(DeflateManager s) { }

	internal static void gen_codes(short[] tree, int max_code, short[] bl_count) { }

	internal static int bi_reverse(int code, int len) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class Tree : ConsoleSystem // TypeDefIndex: 11966
{	private static float m_quality; // 0x0
	private static int m_meshes; // 0x4

	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int meshes { get; set; }


	public static float get_quality() { }

	public static void set_quality(float value) { }

	public static float get_lod() { }

	public static float get_cull() { }

	public static int get_meshes() { }

	public static void set_meshes(int value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

