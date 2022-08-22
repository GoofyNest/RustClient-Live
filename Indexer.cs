public class Indexer // TypeDefIndex: 6641
{	private List<Indexer.Keyframe> keyframes; // 0x10
	private long LastPacketTime; // 0x18
	private long PacketCount; // 0x20
	private Dictionary<uint, Indexer.Entity> currentEnts; // 0x28
	private long NextKeyframe; // 0x30
	private List<uint> Updated; // 0x38

	public TimeSpan TotalLength { get; }
	public long Interval { get; }


	public TimeSpan get_TotalLength() { }

	public long get_Interval() { }

	internal void .ctor(Reader reader) { }

	private void ProcessPacket(Packet packet) { }

	private void EntityUpdated(uint ent) { }

	private void EntityPosition(BinaryReader reader) { }

	private void RpcMessage(BinaryReader reader) { }

	internal Indexer.Keyframe LookupKeyframeForTime(long time) { }

	internal Indexer.Keyframe GetKeyframe(int index) { }

	internal HashSet<uint> GetChangedEntities(long from, long to) { }

	private void EntityDestroy(BinaryReader reader) { }

	private void Entities(BinaryReader reader) { }

	private void TryCreateKeyframe(Packet packet) { }

}

public class Indexer.Entity // TypeDefIndex: 6642
{	public Entity Init; // 0x10
	public Entity Data; // 0x18
	public Vector3 Position; // 0x20
	public Vector3 Rotation; // 0x2C

	public uint UId { get; }


	public uint get_UId() { }

	public Indexer.Entity Copy() { }

	public void .ctor() { }

}

public class Indexer.Keyframe // TypeDefIndex: 6643
{	public long Position; // 0x10
	public Indexer.Entity[] Entities; // 0x18
	public uint[] Updated; // 0x20
	public Dictionary<uint, Indexer.Entity> EntityDict; // 0x28


	public void Init() { }

	public bool HasEntity(uint iD) { }

	public void .ctor() { }

}

private sealed class Indexer.Keyframe.<>c // TypeDefIndex: 6644
{	public static readonly Indexer.Keyframe.<>c <>9; // 0x0
	public static Func<Indexer.Entity, uint> <>9__4_0; // 0x8
	public static Func<Indexer.Entity, Indexer.Entity> <>9__4_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <Init>b__4_0(Indexer.Entity x) { }

	internal Indexer.Entity <Init>b__4_1(Indexer.Entity x) { }

}

private sealed class Indexer.<>c // TypeDefIndex: 6645
{	public static readonly Indexer.<>c <>9; // 0x0
	public static Func<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity> <>9__21_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal Indexer.Entity <TryCreateKeyframe>b__21_0(KeyValuePair<uint, Indexer.Entity> x) { }

}

