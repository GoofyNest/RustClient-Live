public static class RaycastCommandBufferSystem // TypeDefIndex: 10596
{
	private static CommandBuffer buffer; 
	private static Material depthmaterial; 
	private static ComputeBuffer computeBuffer; 
	private static float[] resultDataArray; 
	private static int dataLength; 


	private static void SetupCommandBuffer() { }

	public static bool RunRaycast(Renderer renderer, Ray r, out Vector3 hitPos) { }

	private static Matrix4x4 ViewMatrix(Vector3 position, Quaternion rotation) { }

	private static Matrix4x4 ProjMatrix(float orthographicSize, float nearClipPlane, float farClipPlane) { }

	public static void Cleanup() { }

	private static void .cctor() { }

}

