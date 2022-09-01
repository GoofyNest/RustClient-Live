public static class MeshGenerator // TypeDefIndex: 11574
{
	private const float kMinTruncatedRadius = 0,001;

	private static bool duplicateBackFaces { get; }


	private static bool get_duplicateBackFaces() { }

	public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap) { }

	public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap) { }

	public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap) { }

	public static int GetVertexCount(int numSides, int numSegments, bool geomCap) { }

	public static int GetIndicesCount(int numSides, int numSegments, bool geomCap) { }

	public static int GetSharedMeshVertexCount() { }

	public static int GetSharedMeshIndicesCount() { }

}

