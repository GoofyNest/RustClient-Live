public struct GCHandle // TypeDefIndex: 1353
{	// Fields
	private int handle; // 0x0

	// Properties
	public bool IsAllocated { get; }
	public object Target { get; set; }

	// Methods

	// RVA: 0x14C3D0 Offset: 0x14B7D0 VA: 0x18014C3D0
	private void .ctor(IntPtr h) { }

	// RVA: 0x14C370 Offset: 0x14B770 VA: 0x18014C370
	private void .ctor(object obj) { }

	// RVA: 0x14C3A0 Offset: 0x14B7A0 VA: 0x18014C3A0
	internal void .ctor(object value, GCHandleType type) { }

	// RVA: 0x14C3F0 Offset: 0x14B7F0 VA: 0x18014C3F0
	public bool get_IsAllocated() { }

	// RVA: 0x14C400 Offset: 0x14B800 VA: 0x18014C400
	public object get_Target() { }

	// RVA: 0x14C480 Offset: 0x14B880 VA: 0x18014C480
	public void set_Target(object value) { }

	// RVA: 0x14C170 Offset: 0x14B570 VA: 0x18014C170
	public IntPtr AddrOfPinnedObject() { }

	// RVA: 0xFE2540 Offset: 0xFE1940 VA: 0x180FE2540
	public static GCHandle Alloc(object value) { }

	// RVA: 0xFE2520 Offset: 0xFE1920 VA: 0x180FE2520
	public static GCHandle Alloc(object value, GCHandleType type) { }

	// RVA: 0x14C2D0 Offset: 0x14B6D0 VA: 0x18014C2D0
	public void Free() { }

	// RVA: 0xFE2770 Offset: 0xFE1B70 VA: 0x180FE2770
	public static IntPtr op_Explicit(GCHandle value) { }

	// RVA: 0xFE2680 Offset: 0xFE1A80 VA: 0x180FE2680
	public static GCHandle op_Explicit(IntPtr value) { }

	// RVA: 0xFE2550 Offset: 0xFE1950 VA: 0x180FE2550
	private static bool CheckCurrentDomain(int handle) { }

	// RVA: 0xFE2760 Offset: 0xFE1B60 VA: 0x180FE2760
	private static object GetTarget(int handle) { }

	// RVA: 0xFE2750 Offset: 0xFE1B50 VA: 0x180FE2750
	private static int GetTargetHandle(object obj, int handle, GCHandleType type) { }

	// RVA: 0xFE25E0 Offset: 0xFE19E0 VA: 0x180FE25E0
	private static void FreeHandle(int handle) { }

	// RVA: 0xFE2740 Offset: 0xFE1B40 VA: 0x180FE2740
	private static IntPtr GetAddrOfPinnedObject(int handle) { }

	// RVA: 0xFE2840 Offset: 0xFE1C40 VA: 0x180FE2840
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	// RVA: 0x14C250 Offset: 0x14B650 VA: 0x18014C250 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x14C360 Offset: 0x14B760 VA: 0x18014C360 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFE2680 Offset: 0xFE1A80 VA: 0x180FE2680
	public static GCHandle FromIntPtr(IntPtr value) { }

	// RVA: 0xFE2770 Offset: 0xFE1B70 VA: 0x180FE2770
	public static IntPtr ToIntPtr(GCHandle value) { }

}

