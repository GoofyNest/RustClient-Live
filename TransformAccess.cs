public struct TransformAccess // TypeDefIndex: 3589
{	private IntPtr hierarchy; // 0x0
	private int index; // 0x8

	public Vector3 position { get; }
	public Quaternion rotation { get; }
	public Vector3 localPosition { set; }
	public Quaternion localRotation { set; }


	public Vector3 get_position() { }

	public Quaternion get_rotation() { }

	public void set_localPosition(Vector3 value) { }

	public void set_localRotation(Quaternion value) { }

	[NativeMethodAttribute] // RVA: 0xD8BF0 Offset: 0xD7FF0 VA: 0x1800D8BF0
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD8D30 Offset: 0xD8130 VA: 0x1800D8D30
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethodAttribute] // RVA: 0xD8DD0 Offset: 0xD81D0 VA: 0x1800D8DD0
	private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

}

