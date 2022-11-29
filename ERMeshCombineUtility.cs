public class ERMeshCombineUtility // TypeDefIndex: 7251
{

	public static Mesh Combine(Transform container, ERMeshCombineUtility.MeshInstance[] combines, bool generateStrips) { }

	private static void Copy(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform) { }

	private static void CopyNormal(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform) { }

	private static void Copy(int vertexcount, Vector2[] src, Vector2[] dst, ref int offset) { }

	private static void CopyTangents(int vertexcount, Vector4[] src, Vector4[] dst, ref int offset, Matrix4x4 transform) { }

	public static void CombineMesh(GameObject go, Mesh mesh, Transform container, bool isSideObject) { }

	public static List<ERMeshCombineUtility.MeshInstance> GetCombinedInstances(List<CombineClass> mToMesh, Material m) { }

	public void .ctor() { }

}

public struct ERMeshCombineUtility.MeshInstance // TypeDefIndex: 7252
{
	public Mesh mesh; 
	public int subMeshIndex; 
	public Matrix4x4 transform; 
	public int vertexCount; 
	public bool flipTriangles; 

}

