public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 3467
{
	[NativeNameAttribute] 
	public float m00; 
	[NativeNameAttribute] 
	public float m10; 
	[NativeNameAttribute] 
	public float m20; 
	[NativeNameAttribute] 
	public float m30; 
	[NativeNameAttribute] 
	public float m01; 
	[NativeNameAttribute] 
	public float m11; 
	[NativeNameAttribute] 
	public float m21; 
	[NativeNameAttribute] 
	public float m31; 
	[NativeNameAttribute] 
	public float m02; 
	[NativeNameAttribute] 
	public float m12; 
	[NativeNameAttribute] 
	public float m22; 
	[NativeNameAttribute] 
	public float m32; 
	[NativeNameAttribute] 
	public float m03; 
	[NativeNameAttribute] 
	public float m13; 
	[NativeNameAttribute] 
	public float m23; 
	[NativeNameAttribute] 
	public float m33; 
	private static readonly Matrix4x4 zeroMatrix; 
	private static readonly Matrix4x4 identityMatrix; 

	public Quaternion rotation { get; }
	public Vector3 lossyScale { get; }
	public FrustumPlanes decomposeProjection { get; }
	public Matrix4x4 inverse { get; }
	public Matrix4x4 transpose { get; }
	public float Item { get; set; }
	public float Item { get; set; }
	public static Matrix4x4 identity { get; }


	[ThreadSafeAttribute] 
	private Quaternion GetRotation() { }

	[ThreadSafeAttribute] 
	private Vector3 GetLossyScale() { }

	[ThreadSafeAttribute] 
	private FrustumPlanes DecomposeProjection() { }

	public Quaternion get_rotation() { }

	public Vector3 get_lossyScale() { }

	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunctionAttribute] 
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunctionAttribute] 
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	public Matrix4x4 get_inverse() { }

	[FreeFunctionAttribute] 
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	public Matrix4x4 get_transpose() { }

	[FreeFunctionAttribute] 
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunctionAttribute] 
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[FreeFunctionAttribute] 
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

