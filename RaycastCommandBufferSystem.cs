public static class RaycastCommandBufferSystem // TypeDefIndex: 8880
{	private static CommandBuffer buffer; // 0x0
	private static Material depthmaterial; // 0x8
	private static ComputeBuffer computeBuffer; // 0x10
	private static float[] resultDataArray; // 0x18
	private static int dataLength; // 0x20


	private static void SetupCommandBuffer() { }

	public static bool RunRaycast(Renderer renderer, Ray r, out Vector3 hitPos) { }

	private static Matrix4x4 ViewMatrix(Vector3 position, Quaternion rotation) { }

	private static Matrix4x4 ProjMatrix(float orthographicSize, float nearClipPlane, float farClipPlane) { }

	public static void Cleanup() { }

	private static void .cctor() { }

}

