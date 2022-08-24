public sealed class GL // TypeDefIndex: 3390
{
	public static bool sRGBWrite { get; set; }


	[NativeNameAttribute] 
	public static void Vertex3(float x, float y, float z) { }

	public static void Vertex(Vector3 v) { }

	[NativeNameAttribute] 
	public static void TexCoord3(float x, float y, float z) { }

	public static void TexCoord2(float x, float y) { }

	[NativeNameAttribute] 
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	public static void MultiTexCoord2(int unit, float x, float y) { }

	[NativeNameAttribute] 
	private static void ImmediateColor(float r, float g, float b, float a) { }

	public static void Color(Color c) { }

	public static bool get_sRGBWrite() { }

	public static void set_sRGBWrite(bool value) { }

	public static void Flush() { }

	[NativeNameAttribute] 
	public static void MultMatrix(Matrix4x4 m) { }

	[FreeFunctionAttribute] 
	public static void PushMatrix() { }

	[FreeFunctionAttribute] 
	public static void PopMatrix() { }

	[FreeFunctionAttribute] 
	public static void LoadIdentity() { }

	[FreeFunctionAttribute] 
	public static void LoadOrtho() { }

	[FreeFunctionAttribute] 
	public static void LoadPixelMatrix() { }

	[FreeFunctionAttribute] 
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunctionAttribute] 
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunctionAttribute] 
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunctionAttribute] 
	private static void GLIssuePluginEvent(IntPtr callback, int eventID) { }

	public static void IssuePluginEvent(IntPtr callback, int eventID) { }

	[FreeFunctionAttribute] 
	public static void Begin(int mode) { }

	[FreeFunctionAttribute] 
	public static void End() { }

	[FreeFunctionAttribute] 
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] 
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	private static void MultMatrix_Injected(ref Matrix4x4 m) { }

	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

}

