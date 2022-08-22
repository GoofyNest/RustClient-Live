public struct TransformAccessArray : IDisposable // TypeDefIndex: 3590
{	private IntPtr m_TransformArray; // 0x0

	public bool isCreated { get; }


	public void .ctor(int capacity, int desiredJobCount = -1) { }

	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	public bool get_isCreated() { }

	public void Dispose() { }

	internal IntPtr GetTransformAccessArrayForSchedule() { }

	public void Add(Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD9230 Offset: 0xD8630 VA: 0x1800D9230
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[NativeMethodAttribute] // RVA: 0xD93E0 Offset: 0xD87E0 VA: 0x1800D93E0
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[NativeMethodAttribute] // RVA: 0xD94D0 Offset: 0xD88D0 VA: 0x1800D94D0
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD95E0 Offset: 0xD89E0 VA: 0x1800D95E0
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[NativeMethodAttribute] // RVA: 0xD9840 Offset: 0xD8C40 VA: 0x1800D9840
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

}

