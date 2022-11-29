public struct TransformAccessArray : IDisposable // TypeDefIndex: 3593
{
	private IntPtr m_TransformArray; 

	public bool isCreated { get; }


	public void .ctor(int capacity, int desiredJobCount = -1) { }

	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	public bool get_isCreated() { }

	public void Dispose() { }

	internal IntPtr GetTransformAccessArrayForSchedule() { }

	public void Add(Transform transform) { }

	[NativeMethodAttribute] 
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[NativeMethodAttribute] 
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[NativeMethodAttribute] 
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[NativeMethodAttribute] 
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[NativeMethodAttribute] 
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

}

