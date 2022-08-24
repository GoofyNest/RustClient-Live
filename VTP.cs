public class VTP : MonoBehaviour // TypeDefIndex: 11523
{

	public static Color getSingleVertexColorAtHit(Transform transform, RaycastHit hit) { }

	public static Color getFaceVerticesColorAtHit(Transform transform, RaycastHit hit) { }

	public static void paintSingleVertexOnHit(Transform transform, RaycastHit hit, Color color, float strength) { }

	public static void paintFaceVerticesOnHit(Transform transform, RaycastHit hit, Color color, float strength) { }

	public static void deformSingleVertexOnHit(Transform transform, RaycastHit hit, bool up, float strength, bool recalculateNormals, bool recalculateCollider, bool recalculateFlow) { }

	public static void deformFaceVerticesOnHit(Transform transform, RaycastHit hit, bool up, float strength, bool recalculateNormals, bool recalculateCollider, bool recalculateFlow) { }

	private static void recalculateMeshForFlow(Transform transform, Vector3[] currentVertices, Vector3[] currentNormals, Vector4[] currentTangents) { }

	private static Vector4[] calculateMeshTangents(int[] triangles, Vector3[] vertices, Vector2[] uv, Vector3[] normals) { }

	public static Color VertexColorLerp(Color colorA, Color colorB, float value) { }

	public void .ctor() { }

}

