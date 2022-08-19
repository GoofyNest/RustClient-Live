public class VTP : MonoBehaviour // TypeDefIndex: 11523
{	// Methods

	// RVA: 0xAC7D40 Offset: 0xAC7140 VA: 0x180AC7D40
	public static Color getSingleVertexColorAtHit(Transform transform, RaycastHit hit) { }

	// RVA: 0xAC7B40 Offset: 0xAC6F40 VA: 0x180AC7B40
	public static Color getFaceVerticesColorAtHit(Transform transform, RaycastHit hit) { }

	// RVA: 0xAC8320 Offset: 0xAC7720 VA: 0x180AC8320
	public static void paintSingleVertexOnHit(Transform transform, RaycastHit hit, Color color, float strength) { }

	// RVA: 0xAC8060 Offset: 0xAC7460 VA: 0x180AC8060
	public static void paintFaceVerticesOnHit(Transform transform, RaycastHit hit, Color color, float strength) { }

	// RVA: 0xAC75B0 Offset: 0xAC69B0 VA: 0x180AC75B0
	public static void deformSingleVertexOnHit(Transform transform, RaycastHit hit, bool up, float strength, bool recalculateNormals, bool recalculateCollider, bool recalculateFlow) { }

	// RVA: 0xAC7140 Offset: 0xAC6540 VA: 0x180AC7140
	public static void deformFaceVerticesOnHit(Transform transform, RaycastHit hit, bool up, float strength, bool recalculateNormals, bool recalculateCollider, bool recalculateFlow) { }

	// RVA: 0xAC86E0 Offset: 0xAC7AE0 VA: 0x180AC86E0
	private static void recalculateMeshForFlow(Transform transform, Vector3[] currentVertices, Vector3[] currentNormals, Vector4[] currentTangents) { }

	// RVA: 0xAC66E0 Offset: 0xAC5AE0 VA: 0x180AC66E0
	private static Vector4[] calculateMeshTangents(int[] triangles, Vector3[] vertices, Vector2[] uv, Vector3[] normals) { }

	// RVA: 0xAC65D0 Offset: 0xAC59D0 VA: 0x180AC65D0
	public static Color VertexColorLerp(Color colorA, Color colorB, float value) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

