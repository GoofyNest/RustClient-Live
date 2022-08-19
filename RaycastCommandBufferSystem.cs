public static class RaycastCommandBufferSystem // TypeDefIndex: 8880
{	// Fields
	private static CommandBuffer buffer; // 0x0
	private static Material depthmaterial; // 0x8
	private static ComputeBuffer computeBuffer; // 0x10
	private static float[] resultDataArray; // 0x18
	private static int dataLength; // 0x20

	// Methods

	// RVA: 0x6A8A50 Offset: 0x6A7E50 VA: 0x1806A8A50
	private static void SetupCommandBuffer() { }

	// RVA: 0x6A81A0 Offset: 0x6A75A0 VA: 0x1806A81A0
	public static bool RunRaycast(Renderer renderer, Ray r, out Vector3 hitPos) { }

	// RVA: 0x6A8BB0 Offset: 0x6A7FB0 VA: 0x1806A8BB0
	private static Matrix4x4 ViewMatrix(Vector3 position, Quaternion rotation) { }

	// RVA: 0x6A80C0 Offset: 0x6A74C0 VA: 0x1806A80C0
	private static Matrix4x4 ProjMatrix(float orthographicSize, float nearClipPlane, float farClipPlane) { }

	// RVA: 0x6A7FC0 Offset: 0x6A73C0 VA: 0x1806A7FC0
	public static void Cleanup() { }

	// RVA: 0x6A8F90 Offset: 0x6A8390 VA: 0x1806A8F90
	private static void .cctor() { }

}

