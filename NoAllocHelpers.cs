internal sealed class NoAllocHelpers // TypeDefIndex: 3519
{	// Methods

	// RVA: -1 Offset: -1
	public static void ResizeList<T>(List<T> list, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EC5A0 Offset: 0x5EB9A0 VA: 0x1805EC5A0
	|-NoAllocHelpers.ResizeList<object>
	*/

	// RVA: -1 Offset: -1
	public static void EnsureListElemCount<T>(List<T> list, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EC520 Offset: 0x5EB920 VA: 0x1805EC520
	|-NoAllocHelpers.EnsureListElemCount<object>
	|-NoAllocHelpers.EnsureListElemCount<Material>
	*/

	// RVA: 0x18F2960 Offset: 0x18F1D60 VA: 0x1818F2960
	public static int SafeLength(Array values) { }

	// RVA: -1 Offset: -1
	public static int SafeLength<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE821D0 Offset: 0xE815D0 VA: 0x180E821D0
	|-NoAllocHelpers.SafeLength<int>
	|-NoAllocHelpers.SafeLength<object>
	|-NoAllocHelpers.SafeLength<Color32>
	|-NoAllocHelpers.SafeLength<Color>
	|-NoAllocHelpers.SafeLength<Vector2>
	|-NoAllocHelpers.SafeLength<Vector3>
	|-NoAllocHelpers.SafeLength<Vector4>
	*/

	// RVA: -1 Offset: -1
	public static T[] ExtractArrayFromListT<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA28E0 Offset: 0x1AA1CE0 VA: 0x181AA28E0
	|-NoAllocHelpers.ExtractArrayFromListT<object>
	|-NoAllocHelpers.ExtractArrayFromListT<Material>
	*/

	[FreeFunctionAttribute] // RVA: 0xC1F60 Offset: 0xC1360 VA: 0x1800C1F60
	// RVA: 0x18F2920 Offset: 0x18F1D20 VA: 0x1818F2920
	internal static void Internal_ResizeList(object list, int size) { }

	[FreeFunctionAttribute] // RVA: 0xC2030 Offset: 0xC1430 VA: 0x1800C2030
	// RVA: 0x18F28E0 Offset: 0x18F1CE0 VA: 0x1818F28E0
	public static Array ExtractArrayFromList(object list) { }

}

