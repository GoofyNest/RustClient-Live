public static class MeshGenerator // TypeDefIndex: 11546
{	// Fields
	private const float kMinTruncatedRadius = 0,001;

	// Properties
	private static bool duplicateBackFaces { get; }

	// Methods

	// RVA: 0xAC45A0 Offset: 0xAC39A0 VA: 0x180AC45A0
	private static bool get_duplicateBackFaces() { }

	// RVA: 0xAC32A0 Offset: 0xAC26A0 VA: 0x180AC32A0
	public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC3160 Offset: 0xAC2560 VA: 0x180AC3160
	public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC33F0 Offset: 0xAC27F0 VA: 0x180AC33F0
	public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC44B0 Offset: 0xAC38B0 VA: 0x180AC44B0
	public static int GetVertexCount(int numSides, int numSegments, bool geomCap) { }

	// RVA: 0xAC42C0 Offset: 0xAC36C0 VA: 0x180AC42C0
	public static int GetIndicesCount(int numSides, int numSegments, bool geomCap) { }

	// RVA: 0xAC4430 Offset: 0xAC3830 VA: 0x180AC4430
	public static int GetSharedMeshVertexCount() { }

	// RVA: 0xAC43B0 Offset: 0xAC37B0 VA: 0x180AC43B0
	public static int GetSharedMeshIndicesCount() { }

}

