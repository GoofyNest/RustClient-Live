public sealed class GL // TypeDefIndex: 3390
{	public static bool sRGBWrite { get; set; }


	[NativeNameAttribute] // RVA: 0x8AA80 Offset: 0x89E80 VA: 0x18008AA80
	public static void Vertex3(float x, float y, float z) { }

	public static void Vertex(Vector3 v) { }

	[NativeNameAttribute] // RVA: 0x8AB20 Offset: 0x89F20 VA: 0x18008AB20
	public static void TexCoord3(float x, float y, float z) { }

	public static void TexCoord2(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8AC30 Offset: 0x8A030 VA: 0x18008AC30
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	public static void MultiTexCoord2(int unit, float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8ACD0 Offset: 0x8A0D0 VA: 0x18008ACD0
	private static void ImmediateColor(float r, float g, float b, float a) { }

	public static void Color(Color c) { }

	public static bool get_sRGBWrite() { }

	public static void set_sRGBWrite(bool value) { }

	public static void Flush() { }

	[NativeNameAttribute] // RVA: 0x8ADC0 Offset: 0x8A1C0 VA: 0x18008ADC0
	public static void MultMatrix(Matrix4x4 m) { }

	[FreeFunctionAttribute] // RVA: 0x8AE30 Offset: 0x8A230 VA: 0x18008AE30
	public static void PushMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	public static void PopMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8AF10 Offset: 0x8A310 VA: 0x18008AF10
	public static void LoadIdentity() { }

	[FreeFunctionAttribute] // RVA: 0x8AF80 Offset: 0x8A380 VA: 0x18008AF80
	public static void LoadOrtho() { }

	[FreeFunctionAttribute] // RVA: 0x8B060 Offset: 0x8A460 VA: 0x18008B060
	public static void LoadPixelMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B110 Offset: 0x8A510 VA: 0x18008B110
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunctionAttribute] // RVA: 0x8B280 Offset: 0x8A680 VA: 0x18008B280
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	private static void GLIssuePluginEvent(IntPtr callback, int eventID) { }

	public static void IssuePluginEvent(IntPtr callback, int eventID) { }

	[FreeFunctionAttribute] // RVA: 0x8C630 Offset: 0x8BA30 VA: 0x18008C630
	public static void Begin(int mode) { }

	[FreeFunctionAttribute] // RVA: 0x8C830 Offset: 0x8BC30 VA: 0x18008C830
	public static void End() { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x8C970 Offset: 0x8BD70 VA: 0x18008C970
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	private static void MultMatrix_Injected(ref Matrix4x4 m) { }

	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

}

