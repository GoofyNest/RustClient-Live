public struct TransformAccess // TypeDefIndex: 3592
{
	private IntPtr hierarchy;
	private int index;

	public Vector3 position { get; }
	public Quaternion rotation { get; }
	public Vector3 localPosition { set; }
	public Quaternion localRotation { set; }


	public Vector3 get_position() { }

	public Quaternion get_rotation() { }

	public void set_localPosition(Vector3 value) { }

	public void set_localRotation(Quaternion value) { }

	[NativeMethodAttribute]
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethodAttribute]
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethodAttribute]
	private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	[NativeMethodAttribute]
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

}

