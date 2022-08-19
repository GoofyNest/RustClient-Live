public struct TransformAccessArray : IDisposable // TypeDefIndex: 3590
{	// Fields
	private IntPtr m_TransformArray; // 0x0

	// Properties
	public bool isCreated { get; }

	// Methods

	// RVA: 0x2184F0 Offset: 0x2178F0 VA: 0x1802184F0
	public void .ctor(int capacity, int desiredJobCount = -1) { }

	// RVA: 0x18FBD40 Offset: 0x18FB140 VA: 0x1818FBD40
	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	// RVA: 0x218540 Offset: 0x217940 VA: 0x180218540
	public bool get_isCreated() { }

	// RVA: 0x218480 Offset: 0x217880 VA: 0x180218480 Slot: 4
	public void Dispose() { }

	// RVA: 0x1FB940 Offset: 0x1FAD40 VA: 0x1801FB940
	internal IntPtr GetTransformAccessArrayForSchedule() { }

	// RVA: 0x218430 Offset: 0x217830 VA: 0x180218430
	public void Add(Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD9230 Offset: 0xD8630 VA: 0x1800D9230
	// RVA: 0x18FBD90 Offset: 0x18FB190 VA: 0x1818FBD90
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[NativeMethodAttribute] // RVA: 0xD93E0 Offset: 0xD87E0 VA: 0x1800D93E0
	// RVA: 0x18FBDD0 Offset: 0x18FB1D0 VA: 0x1818FBDD0
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[NativeMethodAttribute] // RVA: 0xD94D0 Offset: 0xD88D0 VA: 0x1800D94D0
	// RVA: 0x18FBCA0 Offset: 0x18FB0A0 VA: 0x1818FBCA0
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD95E0 Offset: 0xD89E0 VA: 0x1800D95E0
	// RVA: 0x18FBEC0 Offset: 0x18FB2C0 VA: 0x1818FBEC0
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[NativeMethodAttribute] // RVA: 0xD9840 Offset: 0xD8C40 VA: 0x1800D9840
	// RVA: 0x18FBE80 Offset: 0x18FB280 VA: 0x1818FBE80
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

}

