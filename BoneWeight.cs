public struct BoneWeight : IEquatable<BoneWeight> // TypeDefIndex: 3443
{
	[SerializeField] 
	private float m_Weight0; 
	[SerializeField] 
	private float m_Weight1; 
	[SerializeField] 
	private float m_Weight2; 
	[SerializeField] 
	private float m_Weight3; 
	[SerializeField] 
	private int m_BoneIndex0; 
	[SerializeField] 
	private int m_BoneIndex1; 
	[SerializeField] 
	private int m_BoneIndex2; 
	[SerializeField] 
	private int m_BoneIndex3; 

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

