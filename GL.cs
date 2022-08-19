public sealed class GL // TypeDefIndex: 3390
{	// Properties
	public static bool sRGBWrite { get; set; }

	// Methods

	[NativeNameAttribute] // RVA: 0x8AA80 Offset: 0x89E80 VA: 0x18008AA80
	// RVA: 0x1825900 Offset: 0x1824D00 VA: 0x181825900
	public static void Vertex3(float x, float y, float z) { }

	// RVA: 0x1825960 Offset: 0x1824D60 VA: 0x181825960
	public static void Vertex(Vector3 v) { }

	[NativeNameAttribute] // RVA: 0x8AB20 Offset: 0x89F20 VA: 0x18008AB20
	// RVA: 0x18258A0 Offset: 0x1824CA0 VA: 0x1818258A0
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x1825850 Offset: 0x1824C50 VA: 0x181825850
	public static void TexCoord2(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8AC30 Offset: 0x8A030 VA: 0x18008AC30
	// RVA: 0x1825780 Offset: 0x1824B80 VA: 0x181825780
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	// RVA: 0x1825720 Offset: 0x1824B20 VA: 0x181825720
	public static void MultiTexCoord2(int unit, float x, float y) { }

	[NativeNameAttribute] // RVA: 0x8ACD0 Offset: 0x8A0D0 VA: 0x18008ACD0
	// RVA: 0x1825460 Offset: 0x1824860 VA: 0x181825460
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x1825130 Offset: 0x1824530 VA: 0x181825130
	public static void Color(Color c) { }

	// RVA: 0x18259C0 Offset: 0x1824DC0 VA: 0x1818259C0
	public static bool get_sRGBWrite() { }

	// RVA: 0x18259F0 Offset: 0x1824DF0 VA: 0x1818259F0
	public static void set_sRGBWrite(bool value) { }

	// RVA: 0x18251C0 Offset: 0x18245C0 VA: 0x1818251C0
	public static void Flush() { }

	[NativeNameAttribute] // RVA: 0x8ADC0 Offset: 0x8A1C0 VA: 0x18008ADC0
	// RVA: 0x18256E0 Offset: 0x1824AE0 VA: 0x1818256E0
	public static void MultMatrix(Matrix4x4 m) { }

	[FreeFunctionAttribute] // RVA: 0x8AE30 Offset: 0x8A230 VA: 0x18008AE30
	// RVA: 0x1825820 Offset: 0x1824C20 VA: 0x181825820
	public static void PushMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8AEA0 Offset: 0x8A2A0 VA: 0x18008AEA0
	// RVA: 0x18257F0 Offset: 0x1824BF0 VA: 0x1818257F0
	public static void PopMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8AF10 Offset: 0x8A310 VA: 0x18008AF10
	// RVA: 0x1825590 Offset: 0x1824990 VA: 0x181825590
	public static void LoadIdentity() { }

	[FreeFunctionAttribute] // RVA: 0x8AF80 Offset: 0x8A380 VA: 0x18008AF80
	// RVA: 0x18255C0 Offset: 0x18249C0 VA: 0x1818255C0
	public static void LoadOrtho() { }

	[FreeFunctionAttribute] // RVA: 0x8B060 Offset: 0x8A460 VA: 0x18008B060
	// RVA: 0x18255F0 Offset: 0x18249F0 VA: 0x1818255F0
	public static void LoadPixelMatrix() { }

	[FreeFunctionAttribute] // RVA: 0x8B110 Offset: 0x8A510 VA: 0x18008B110
	// RVA: 0x1825660 Offset: 0x1824A60 VA: 0x181825660
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunctionAttribute] // RVA: 0x8B280 Offset: 0x8A680 VA: 0x18008B280
	// RVA: 0x18253F0 Offset: 0x18247F0 VA: 0x1818253F0
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x1825310 Offset: 0x1824710 VA: 0x181825310
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x1825310 Offset: 0x1824710 VA: 0x181825310
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18252D0 Offset: 0x18246D0 VA: 0x1818252D0
	private static void GLIssuePluginEvent(IntPtr callback, int eventID) { }

	// RVA: 0x18254E0 Offset: 0x18248E0 VA: 0x1818254E0
	public static void IssuePluginEvent(IntPtr callback, int eventID) { }

	[FreeFunctionAttribute] // RVA: 0x8C630 Offset: 0x8BA30 VA: 0x18008C630
	// RVA: 0x1825040 Offset: 0x1824440 VA: 0x181825040
	public static void Begin(int mode) { }

	[FreeFunctionAttribute] // RVA: 0x8C830 Offset: 0x8BC30 VA: 0x18008C830
	// RVA: 0x1825190 Offset: 0x1824590 VA: 0x181825190
	public static void End() { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x1825260 Offset: 0x1824660 VA: 0x181825260
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x18250D0 Offset: 0x18244D0 VA: 0x1818250D0
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x8C970 Offset: 0x8BD70 VA: 0x18008C970
	// RVA: 0x1825080 Offset: 0x1824480 VA: 0x181825080
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	// RVA: 0x18256A0 Offset: 0x1824AA0 VA: 0x1818256A0
	private static void MultMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x1825620 Offset: 0x1824A20 VA: 0x181825620
	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	// RVA: 0x1825390 Offset: 0x1824790 VA: 0x181825390
	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	// RVA: 0x18251F0 Offset: 0x18245F0 VA: 0x1818251F0
	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

}

