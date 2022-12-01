public class Tree : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6508
{
	public bool ShouldPool;
	private bool _disposed;
	public uint netId;
	public uint prefabId;
	public Half3 position;
	public float scale;


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

internal sealed class Tree // TypeDefIndex: 6993
{
	private static readonly int HEAP_SIZE;
	internal static readonly int[] ExtraLengthBits;
	internal static readonly int[] ExtraDistanceBits;
	internal static readonly int[] extra_blbits;
	internal static readonly sbyte[] bl_order;
	private static readonly sbyte[] _dist_code;
	internal static readonly sbyte[] LengthCode;
	internal static readonly int[] LengthBase;
	internal static readonly int[] DistanceBase;
	internal short[] dyn_tree;
	internal int max_code;
	internal StaticTree staticTree;


	internal static int DistanceCode(int dist) { }

	internal void gen_bitlen(DeflateManager s) { }

	internal void build_tree(DeflateManager s) { }

	internal static void gen_codes(short[] tree, int max_code, short[] bl_count) { }

	internal static int bi_reverse(int code, int len) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class Tree : ConsoleSystem // TypeDefIndex: 13774
{
	private static float m_quality;
	private static int m_meshes;

	[ClientVar]
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }
	[ClientVar]
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

