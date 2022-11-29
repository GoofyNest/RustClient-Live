public struct MeshTrimSettings // TypeDefIndex: 7381
{

internal class <Module>

[Serializable]
public struct MeshTrimSettings
	public bool TrimBasedOnVisibility; 
	[RangeAttribute] 
	public int IterationsPerLoop; 
	public float StartHeight; 
	public float EndHeight; 
	[RangeAttribute] 
	public int HeightIterations; 
	public float Radius; 
	public float MinimumTriangleArea; 
	public float MinimumTriangleEdgeLength; 
	public Vector3 OriginOffset; 
	public static MeshTrimSettings Default; 


	private static void .cctor() { }

}

