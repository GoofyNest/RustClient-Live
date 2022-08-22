public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 3466
{	[NativeNameAttribute] // RVA: 0xAA0A0 Offset: 0xA94A0 VA: 0x1800AA0A0
	public float m00; // 0x0
	[NativeNameAttribute] // RVA: 0xAA120 Offset: 0xA9520 VA: 0x1800AA120
	public float m10; // 0x4
	[NativeNameAttribute] // RVA: 0xAA1D0 Offset: 0xA95D0 VA: 0x1800AA1D0
	public float m20; // 0x8
	[NativeNameAttribute] // RVA: 0xAA270 Offset: 0xA9670 VA: 0x1800AA270
	public float m30; // 0xC
	[NativeNameAttribute] // RVA: 0xAA350 Offset: 0xA9750 VA: 0x1800AA350
	public float m01; // 0x10
	[NativeNameAttribute] // RVA: 0xAA420 Offset: 0xA9820 VA: 0x1800AA420
	public float m11; // 0x14
	[NativeNameAttribute] // RVA: 0xAA490 Offset: 0xA9890 VA: 0x1800AA490
	public float m21; // 0x18
	[NativeNameAttribute] // RVA: 0xAA5A0 Offset: 0xA99A0 VA: 0x1800AA5A0
	public float m31; // 0x1C
	[NativeNameAttribute] // RVA: 0xAA730 Offset: 0xA9B30 VA: 0x1800AA730
	public float m02; // 0x20
	[NativeNameAttribute] // RVA: 0xAA7E0 Offset: 0xA9BE0 VA: 0x1800AA7E0
	public float m12; // 0x24
	[NativeNameAttribute] // RVA: 0xAA900 Offset: 0xA9D00 VA: 0x1800AA900
	public float m22; // 0x28
	[NativeNameAttribute] // RVA: 0xAA9A0 Offset: 0xA9DA0 VA: 0x1800AA9A0
	public float m32; // 0x2C
	[NativeNameAttribute] // RVA: 0xAAAD0 Offset: 0xA9ED0 VA: 0x1800AAAD0
	public float m03; // 0x30
	[NativeNameAttribute] // RVA: 0xAAC60 Offset: 0xAA060 VA: 0x1800AAC60
	public float m13; // 0x34
	[NativeNameAttribute] // RVA: 0xAACD0 Offset: 0xAA0D0 VA: 0x1800AACD0
	public float m23; // 0x38
	[NativeNameAttribute] // RVA: 0xAAEF0 Offset: 0xAA2F0 VA: 0x1800AAEF0
	public float m33; // 0x3C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	public Quaternion rotation { get; }
	public Vector3 lossyScale { get; }
	public FrustumPlanes decomposeProjection { get; }
	public Matrix4x4 inverse { get; }
	public Matrix4x4 transpose { get; }
	public float Item { get; set; }
	public float Item { get; set; }
	public static Matrix4x4 identity { get; }


	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	private Quaternion GetRotation() { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	private Vector3 GetLossyScale() { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	private FrustumPlanes DecomposeProjection() { }

	public Quaternion get_rotation() { }

	public Vector3 get_lossyScale() { }

	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunctionAttribute] // RVA: 0xAB240 Offset: 0xAA640 VA: 0x1800AB240
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunctionAttribute] // RVA: 0xAB3B0 Offset: 0xAA7B0 VA: 0x1800AB3B0
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	public Matrix4x4 get_inverse() { }

	[FreeFunctionAttribute] // RVA: 0xAB470 Offset: 0xAA870 VA: 0x1800AB470
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	public Matrix4x4 get_transpose() { }

	[FreeFunctionAttribute] // RVA: 0xAB5D0 Offset: 0xAA9D0 VA: 0x1800AB5D0
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB660 Offset: 0xAAA60 VA: 0x1800AB660
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB7A0 Offset: 0xAABA0 VA: 0x1800AB7A0
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	public float get_Item(int row, int column) { }

	public void set_Item(int row, int column, float value) { }

	public float get_Item(int index) { }

	public void set_Item(int index, float value) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(Matrix4x4 other) { }

	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	public Vector4 GetColumn(int index) { }

	public Vector4 GetRow(int index) { }

	public void SetColumn(int index, Vector4 column) { }

	public void SetRow(int index, Vector4 row) { }

	public Vector3 MultiplyPoint(Vector3 point) { }

	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	public Vector3 MultiplyVector(Vector3 vector) { }

	public static Matrix4x4 Scale(Vector3 vector) { }

	public static Matrix4x4 Translate(Vector3 vector) { }

	public static Matrix4x4 get_identity() { }

	public override string ToString() { }

	private static void .cctor() { }

	private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	private static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }

	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

}

