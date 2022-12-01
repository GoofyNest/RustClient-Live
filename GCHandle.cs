public struct GCHandle // TypeDefIndex: 1353
{
	private int handle;

	public bool IsAllocated { get; }
	public object Target { get; set; }


	private void .ctor(IntPtr h) { }

	private void .ctor(object obj) { }

	internal void .ctor(object value, GCHandleType type) { }

	public bool get_IsAllocated() { }

	public object get_Target() { }

	public void set_Target(object value) { }

	public IntPtr AddrOfPinnedObject() { }

	public static GCHandle Alloc(object value) { }

	public static GCHandle Alloc(object value, GCHandleType type) { }

	public void Free() { }

	public static IntPtr op_Explicit(GCHandle value) { }

	public static GCHandle op_Explicit(IntPtr value) { }

	private static bool CheckCurrentDomain(int handle) { }

	private static object GetTarget(int handle) { }

	private static int GetTargetHandle(object obj, int handle, GCHandleType type) { }

	private static void FreeHandle(int handle) { }

	private static IntPtr GetAddrOfPinnedObject(int handle) { }

	public static bool op_Equality(GCHandle a, GCHandle b) { }

	public override bool Equals(object o) { }

	public override int GetHashCode() { }

	public static GCHandle FromIntPtr(IntPtr value) { }

	public static IntPtr ToIntPtr(GCHandle value) { }

}

