public static class TransformUtil // TypeDefIndex: 11405
{	// Methods

	// RVA: 0x9F6430 Offset: 0x9F5830 VA: 0x1809F6430
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hit, Transform ignoreTransform) { }

	// RVA: 0x9F63B0 Offset: 0x9F57B0 VA: 0x1809F63B0
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hit, float range, Transform ignoreTransform) { }

	// RVA: 0x9F5B40 Offset: 0x9F4F40 VA: 0x1809F5B40
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hitOut, float range, LayerMask mask, Transform ignoreTransform) { }

	// RVA: 0x9F64A0 Offset: 0x9F58A0 VA: 0x1809F64A0
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, Transform ignoreTransform) { }

	// RVA: 0x9F6330 Offset: 0x9F5730 VA: 0x1809F6330
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, Transform ignoreTransform) { }

	// RVA: 0x9F5E40 Offset: 0x9F5240 VA: 0x1809F5E40
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, LayerMask mask, Transform ignoreTransform) { }

	// RVA: 0x9F58C0 Offset: 0x9F4CC0 VA: 0x1809F58C0
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal) { }

	// RVA: 0x9F5850 Offset: 0x9F4C50 VA: 0x1809F5850
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range) { }

	// RVA: 0x9F5930 Offset: 0x9F4D30 VA: 0x1809F5930
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, LayerMask mask) { }

	// RVA: 0x9F6520 Offset: 0x9F5920 VA: 0x1809F6520
	public static Transform[] GetRootObjects() { }

}

private sealed class TransformUtil.<>c // TypeDefIndex: 11406
{	// Fields
	public static readonly TransformUtil.<>c <>9; // 0x0
	public static Func<Transform, bool> <>9__9_0; // 0x8

	// Methods

	// RVA: 0xA01DA0 Offset: 0xA011A0 VA: 0x180A01DA0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA01C60 Offset: 0xA01060 VA: 0x180A01C60
	internal bool <GetRootObjects>b__9_0(Transform x) { }

}

