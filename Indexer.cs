public class Indexer // TypeDefIndex: 6641
{	// Fields
	private List<Indexer.Keyframe> keyframes; // 0x10
	private long LastPacketTime; // 0x18
	private long PacketCount; // 0x20
	private Dictionary<uint, Indexer.Entity> currentEnts; // 0x28
	private long NextKeyframe; // 0x30
	private List<uint> Updated; // 0x38

	// Properties
	public TimeSpan TotalLength { get; }
	public long Interval { get; }

	// Methods

	// RVA: 0x22C4EE0 Offset: 0x22C42E0 VA: 0x1822C4EE0
	public TimeSpan get_TotalLength() { }

	// RVA: 0x8C8B90 Offset: 0x8C7F90 VA: 0x1808C8B90
	public long get_Interval() { }

	// RVA: 0x22C4B40 Offset: 0x22C3F40 VA: 0x1822C4B40
	internal void .ctor(Reader reader) { }

	// RVA: 0x22C4520 Offset: 0x22C3920 VA: 0x1822C4520
	private void ProcessPacket(Packet packet) { }

	// RVA: 0x22C40B0 Offset: 0x22C34B0 VA: 0x1822C40B0
	private void EntityUpdated(uint ent) { }

	// RVA: 0x22C3EA0 Offset: 0x22C32A0 VA: 0x1822C3EA0
	private void EntityPosition(BinaryReader reader) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void RpcMessage(BinaryReader reader) { }

	// RVA: 0x22C4490 Offset: 0x22C3890 VA: 0x1822C4490
	internal Indexer.Keyframe LookupKeyframeForTime(long time) { }

	// RVA: 0x22C43F0 Offset: 0x22C37F0 VA: 0x1822C43F0
	internal Indexer.Keyframe GetKeyframe(int index) { }

	// RVA: 0x22C4120 Offset: 0x22C3520 VA: 0x1822C4120
	internal HashSet<uint> GetChangedEntities(long from, long to) { }

	// RVA: 0x22C3DE0 Offset: 0x22C31E0 VA: 0x1822C3DE0
	private void EntityDestroy(BinaryReader reader) { }

	// RVA: 0x22C3C30 Offset: 0x22C3030 VA: 0x1822C3C30
	private void Entities(BinaryReader reader) { }

	// RVA: 0x22C47D0 Offset: 0x22C3BD0 VA: 0x1822C47D0
	private void TryCreateKeyframe(Packet packet) { }

}

public class Indexer.Entity // TypeDefIndex: 6642
{	// Fields
	public Entity Init; // 0x10
	public Entity Data; // 0x18
	public Vector3 Position; // 0x20
	public Vector3 Rotation; // 0x2C

	// Properties
	public uint UId { get; }

	// Methods

	// RVA: 0x22C3C00 Offset: 0x22C3000 VA: 0x1822C3C00
	public uint get_UId() { }

	// RVA: 0x22C3B60 Offset: 0x22C2F60 VA: 0x1822C3B60
	public Indexer.Entity Copy() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Indexer.Keyframe // TypeDefIndex: 6643
{	// Fields
	public long Position; // 0x10
	public Indexer.Entity[] Entities; // 0x18
	public uint[] Updated; // 0x20
	public Dictionary<uint, Indexer.Entity> EntityDict; // 0x28

	// Methods

	// RVA: 0x22C4FA0 Offset: 0x22C43A0 VA: 0x1822C4FA0
	public void Init() { }

	// RVA: 0x22C4F40 Offset: 0x22C4340 VA: 0x1822C4F40
	public bool HasEntity(uint iD) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class Indexer.Keyframe.<>c // TypeDefIndex: 6644
{	// Fields
	public static readonly Indexer.Keyframe.<>c <>9; // 0x0
	public static Func<Indexer.Entity, uint> <>9__4_0; // 0x8
	public static Func<Indexer.Entity, Indexer.Entity> <>9__4_1; // 0x10

	// Methods

	// RVA: 0x22C5F80 Offset: 0x22C5380 VA: 0x1822C5F80
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22C5E80 Offset: 0x22C5280 VA: 0x1822C5E80
	internal uint <Init>b__4_0(Indexer.Entity x) { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	internal Indexer.Entity <Init>b__4_1(Indexer.Entity x) { }

}

private sealed class Indexer.<>c // TypeDefIndex: 6645
{	// Fields
	public static readonly Indexer.<>c <>9; // 0x0
	public static Func<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity> <>9__21_0; // 0x8

	// Methods

	// RVA: 0x22C5FE0 Offset: 0x22C53E0 VA: 0x1822C5FE0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22C5EB0 Offset: 0x22C52B0 VA: 0x1822C5EB0
	internal Indexer.Entity <TryCreateKeyframe>b__21_0(KeyValuePair<uint, Indexer.Entity> x) { }

}

