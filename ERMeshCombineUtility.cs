public class ERMeshCombineUtility // TypeDefIndex: 7239
{	// Methods

	// RVA: 0x45C5D0 Offset: 0x45B9D0 VA: 0x18045C5D0
	public static Mesh Combine(Transform container, ERMeshCombineUtility.MeshInstance[] combines, bool generateStrips) { }

	// RVA: 0x45DE60 Offset: 0x45D260 VA: 0x18045DE60
	private static void Copy(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform) { }

	// RVA: 0x45DB80 Offset: 0x45CF80 VA: 0x18045DB80
	private static void CopyNormal(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform) { }

	// RVA: 0x45DF60 Offset: 0x45D360 VA: 0x18045DF60
	private static void Copy(int vertexcount, Vector2[] src, Vector2[] dst, ref int offset) { }

	// RVA: 0x45DCC0 Offset: 0x45D0C0 VA: 0x18045DCC0
	private static void CopyTangents(int vertexcount, Vector4[] src, Vector4[] dst, ref int offset, Matrix4x4 transform) { }

	// RVA: 0x45B790 Offset: 0x45AB90 VA: 0x18045B790
	public static void CombineMesh(GameObject go, Mesh mesh, Transform container, bool isSideObject) { }

	// RVA: 0x45DFF0 Offset: 0x45D3F0 VA: 0x18045DFF0
	public static List<ERMeshCombineUtility.MeshInstance> GetCombinedInstances(List<CombineClass> mToMesh, Material m) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public struct ERMeshCombineUtility.MeshInstance // TypeDefIndex: 7240
{	// Fields
	public Mesh mesh; // 0x0
	public int subMeshIndex; // 0x8
	public Matrix4x4 transform; // 0xC
	public int vertexCount; // 0x4C
	public bool flipTriangles; // 0x50

}

