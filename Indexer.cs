public class Indexer // TypeDefIndex: 6655
{
	private List<Indexer.Keyframe> keyframes;
	private long LastPacketTime;
	private long PacketCount;
	private Dictionary<uint, Indexer.Entity> currentEnts;
	private long NextKeyframe;
	private List<uint> Updated;

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

public class Indexer.Entity // TypeDefIndex: 6656
{
	public Entity Init;
	public Entity Data;
	public Vector3 Position;
	public Vector3 Rotation;

	public uint UId { get; }


	public uint get_UId() { }

	public Indexer.Entity Copy() { }

	public void .ctor() { }

}

public class Indexer.Keyframe // TypeDefIndex: 6657
{
	public long Position;
	public Indexer.Entity[] Entities;
	public uint[] Updated;
	public Dictionary<uint, Indexer.Entity> EntityDict;


	public void Init() { }

	public bool HasEntity(uint iD) { }

	public void .ctor() { }

}

private sealed class Indexer.Keyframe.<>c // TypeDefIndex: 6658
{
	public static readonly Indexer.Keyframe.<>c <>9;
	public static Func<Indexer.Entity, uint> <>9__4_0;
	public static Func<Indexer.Entity, Indexer.Entity> <>9__4_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <Init>

	internal Indexer.Entity <Init>

}

private sealed class Indexer.<>c // TypeDefIndex: 6659
{
	public static readonly Indexer.<>c <>9;
	public static Func<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity> <>9__21_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal Indexer.Entity <TryCreateKeyframe>

}

