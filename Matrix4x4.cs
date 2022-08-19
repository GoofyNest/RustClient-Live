public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 3466
{	// Fields
	[NativeNameAttribute] // RVA: 0xAA0A0 Offset: 0xA94A0 VA: 0x1800AA0A0
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

	// Properties
	public Quaternion rotation { get; }
	public Vector3 lossyScale { get; }
	public FrustumPlanes decomposeProjection { get; }
	public Matrix4x4 inverse { get; }
	public Matrix4x4 transpose { get; }
	public float Item { get; set; }
	public float Item { get; set; }
	public static Matrix4x4 identity { get; }

	// Methods

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x215CF0 Offset: 0x2150F0 VA: 0x180215CF0
	private Quaternion GetRotation() { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x215CD0 Offset: 0x2150D0 VA: 0x180215CD0
	private Vector3 GetLossyScale() { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2159C0 Offset: 0x214DC0 VA: 0x1802159C0
	private FrustumPlanes DecomposeProjection() { }

	// RVA: 0x216770 Offset: 0x215B70 VA: 0x180216770
	public Quaternion get_rotation() { }

	// RVA: 0x2166C0 Offset: 0x215AC0 VA: 0x1802166C0
	public Vector3 get_lossyScale() { }

	// RVA: 0x216490 Offset: 0x215890 VA: 0x180216490
	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunctionAttribute] // RVA: 0xAB240 Offset: 0xAA640 VA: 0x1800AB240
	// RVA: 0x18EBB20 Offset: 0x18EAF20 VA: 0x1818EBB20
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0x216240 Offset: 0x215640 VA: 0x180216240
	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunctionAttribute] // RVA: 0xAB3B0 Offset: 0xAA7B0 VA: 0x1800AB3B0
	// RVA: 0x18EB1E0 Offset: 0x18EA5E0 VA: 0x1818EB1E0
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x216540 Offset: 0x215940 VA: 0x180216540
	public Matrix4x4 get_inverse() { }

	[FreeFunctionAttribute] // RVA: 0xAB470 Offset: 0xAA870 VA: 0x1800AB470
	// RVA: 0x18EC470 Offset: 0x18EB870 VA: 0x1818EC470
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	// RVA: 0x216810 Offset: 0x215C10 VA: 0x180216810
	public Matrix4x4 get_transpose() { }

	[FreeFunctionAttribute] // RVA: 0xAB5D0 Offset: 0xAA9D0 VA: 0x1800AB5D0
	// RVA: 0x18EB590 Offset: 0x18EA990 VA: 0x1818EB590
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB660 Offset: 0xAAA60 VA: 0x1800AB660
	// RVA: 0x18EB6F0 Offset: 0x18EAAF0 VA: 0x1818EB6F0
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0xAB7A0 Offset: 0xAABA0 VA: 0x1800AB7A0
	// RVA: 0x18EAAD0 Offset: 0x18E9ED0 VA: 0x1818EAAD0
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	// RVA: 0x18EA950 Offset: 0x18E9D50 VA: 0x1818EA950
	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	// RVA: 0x2163B0 Offset: 0x2157B0 VA: 0x1802163B0
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x216460 Offset: 0x215860 VA: 0x180216460
	public float get_Item(int row, int column) { }

	// RVA: 0x2169A0 Offset: 0x215DA0 VA: 0x1802169A0
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x216480 Offset: 0x215880 VA: 0x180216480
	public float get_Item(int index) { }

	// RVA: 0x216990 Offset: 0x215D90 VA: 0x180216990
	public void set_Item(int index, float value) { }

	// RVA: 0x215AF0 Offset: 0x214EF0 VA: 0x180215AF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2159E0 Offset: 0x214DE0 VA: 0x1802159E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x215A90 Offset: 0x214E90 VA: 0x180215A90 Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x18ED150 Offset: 0x18EC550 VA: 0x1818ED150
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x18ECFB0 Offset: 0x18EC3B0 VA: 0x1818ECFB0
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x215AD0 Offset: 0x214ED0 VA: 0x180215AD0
	public Vector4 GetColumn(int index) { }

	// RVA: 0x215D10 Offset: 0x215110 VA: 0x180215D10
	public Vector4 GetRow(int index) { }

	// RVA: 0x216140 Offset: 0x215540 VA: 0x180216140
	public void SetColumn(int index, Vector4 column) { }

	// RVA: 0x2161C0 Offset: 0x2155C0 VA: 0x1802161C0
	public void SetRow(int index, Vector4 row) { }

	// RVA: 0x215F60 Offset: 0x215360 VA: 0x180215F60
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x215EA0 Offset: 0x2152A0 VA: 0x180215EA0
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x216090 Offset: 0x215490 VA: 0x180216090
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x18EB7B0 Offset: 0x18EABB0 VA: 0x1818EB7B0
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x18EC380 Offset: 0x18EB780 VA: 0x1818EC380
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x18ECAD0 Offset: 0x18EBED0 VA: 0x1818ECAD0
	public static Matrix4x4 get_identity() { }

	// RVA: 0x2163A0 Offset: 0x2157A0 VA: 0x1802163A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18EC500 Offset: 0x18EB900 VA: 0x1818EC500
	private static void .cctor() { }

	// RVA: 0x18EAF90 Offset: 0x18EA390 VA: 0x1818EAF90
	private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	// RVA: 0x18EAEB0 Offset: 0x18EA2B0 VA: 0x1818EAEB0
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	// RVA: 0x18EA420 Offset: 0x18E9820 VA: 0x1818EA420
	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	// RVA: 0x18EBAB0 Offset: 0x18EAEB0 VA: 0x1818EBAB0
	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x18EB190 Offset: 0x18EA590 VA: 0x1818EB190
	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x18EC420 Offset: 0x18EB820 VA: 0x1818EC420
	private static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x18EB510 Offset: 0x18EA910 VA: 0x1818EB510
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x18EB670 Offset: 0x18EAA70 VA: 0x1818EB670
	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x18EA8D0 Offset: 0x18E9CD0 VA: 0x1818EA8D0
	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

}

