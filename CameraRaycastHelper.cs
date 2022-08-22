internal class CameraRaycastHelper // TypeDefIndex: 4074
{
	[FreeFunctionAttribute] // RVA: 0xE9770 Offset: 0xE8B70 VA: 0x1800E9770
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunctionAttribute] // RVA: 0xE9A40 Offset: 0xE8E40 VA: 0x1800E9A40
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

}

