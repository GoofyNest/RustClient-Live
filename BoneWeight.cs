public struct BoneWeight : IEquatable<BoneWeight> // TypeDefIndex: 3443
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	public float weight0 { get; }
	public float weight1 { get; }
	public float weight2 { get; }
	public float weight3 { get; }
	public int boneIndex0 { get; }
	public int boneIndex1 { get; }
	public int boneIndex2 { get; }
	public int boneIndex3 { get; }


	public float get_weight0() { }

	public float get_weight1() { }

	public float get_weight2() { }

	public float get_weight3() { }

	public int get_boneIndex0() { }

	public int get_boneIndex1() { }

	public int get_boneIndex2() { }

	public int get_boneIndex3() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(BoneWeight other) { }

}

