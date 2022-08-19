public struct BoneWeight : IEquatable<BoneWeight> // TypeDefIndex: 3443
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Weight0; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Weight1; // 0x4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Weight2; // 0x8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Weight3; // 0xC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_BoneIndex0; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_BoneIndex1; // 0x14
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_BoneIndex2; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_BoneIndex3; // 0x1C

	// Properties
	public float weight0 { get; }
	public float weight1 { get; }
	public float weight2 { get; }
	public float weight3 { get; }
	public int boneIndex0 { get; }
	public int boneIndex1 { get; }
	public int boneIndex2 { get; }
	public int boneIndex3 { get; }

	// Methods

	// RVA: 0x13A270 Offset: 0x139670 VA: 0x18013A270
	public float get_weight0() { }

	// RVA: 0x2121C0 Offset: 0x2115C0 VA: 0x1802121C0
	public float get_weight1() { }

	// RVA: 0x2121D0 Offset: 0x2115D0 VA: 0x1802121D0
	public float get_weight2() { }

	// RVA: 0x2121E0 Offset: 0x2115E0 VA: 0x1802121E0
	public float get_weight3() { }

	// RVA: 0x212180 Offset: 0x211580 VA: 0x180212180
	public int get_boneIndex0() { }

	// RVA: 0x212190 Offset: 0x211590 VA: 0x180212190
	public int get_boneIndex1() { }

	// RVA: 0x2121A0 Offset: 0x2115A0 VA: 0x1802121A0
	public int get_boneIndex2() { }

	// RVA: 0x2121B0 Offset: 0x2115B0 VA: 0x1802121B0
	public int get_boneIndex3() { }

	// RVA: 0x212070 Offset: 0x211470 VA: 0x180212070 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211FA0 Offset: 0x2113A0 VA: 0x180211FA0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x212040 Offset: 0x211440 VA: 0x180212040 Slot: 4
	public bool Equals(BoneWeight other) { }

}

