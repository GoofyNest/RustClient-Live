public struct TransformAccess // TypeDefIndex: 3589
{	// Fields
	private IntPtr hierarchy; // 0x0
	private int index; // 0x8

	// Properties
	public Vector3 position { get; }
	public Quaternion rotation { get; }
	public Vector3 localPosition { set; }
	public Quaternion localRotation { set; }

	// Methods

	// RVA: 0x218580 Offset: 0x217980 VA: 0x180218580
	public Vector3 get_position() { }

	// RVA: 0x2185F0 Offset: 0x2179F0 VA: 0x1802185F0
	public Quaternion get_rotation() { }

	// RVA: 0x218650 Offset: 0x217A50 VA: 0x180218650
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x2186A0 Offset: 0x217AA0 VA: 0x1802186A0
	public void set_localRotation(Quaternion value) { }

	[NativeMethodAttribute] // RVA: 0xD8BF0 Offset: 0xD7FF0 VA: 0x1800D8BF0
	// RVA: 0x18FBF90 Offset: 0x18FB390 VA: 0x1818FBF90
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD8D30 Offset: 0xD8130 VA: 0x1800D8D30
	// RVA: 0x18FBFE0 Offset: 0x18FB3E0 VA: 0x1818FBFE0
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethodAttribute] // RVA: 0xD8DD0 Offset: 0xD81D0 VA: 0x1800D8DD0
	// RVA: 0x18FC030 Offset: 0x18FB430 VA: 0x1818FC030
	private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	// RVA: 0x18FC080 Offset: 0x18FB480 VA: 0x1818FC080
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

}

