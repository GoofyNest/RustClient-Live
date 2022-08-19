public sealed class Camera : Behaviour // TypeDefIndex: 3360
{	// Fields
	public static Camera.CameraCallback onPreCull; // 0x0
	public static Camera.CameraCallback onPreRender; // 0x8
	public static Camera.CameraCallback onPostRender; // 0x10

	// Properties
	[NativePropertyAttribute] // RVA: 0x77BF0 Offset: 0x76FF0 VA: 0x180077BF0
	public float nearClipPlane { get; set; }
	[NativePropertyAttribute] // RVA: 0x77D50 Offset: 0x77150 VA: 0x180077D50
	public float farClipPlane { get; set; }
	[NativePropertyAttribute] // RVA: 0x77F00 Offset: 0x77300 VA: 0x180077F00
	public float fieldOfView { get; set; }
	public RenderingPath renderingPath { set; }
	public RenderingPath actualRenderingPath { get; }
	public bool allowHDR { get; set; }
	public bool allowMSAA { get; set; }
	[NativePropertyAttribute] // RVA: 0x78080 Offset: 0x77480 VA: 0x180078080
	public bool forceIntoRenderTexture { set; }
	public float orthographicSize { get; set; }
	public bool orthographic { get; set; }
	public float depth { get; }
	public float aspect { get; set; }
	public int cullingMask { get; set; }
	public int eventMask { get; }
	public CameraType cameraType { get; }
	public float[] layerCullDistances { get; set; }
	public Color backgroundColor { get; set; }
	public CameraClearFlags clearFlags { get; set; }
	public DepthTextureMode depthTextureMode { get; set; }
	public bool usePhysicalProperties { get; set; }
	public Vector2 sensorSize { get; set; }
	public float focalLength { get; set; }
	[NativePropertyAttribute] // RVA: 0x78150 Offset: 0x77550 VA: 0x180078150
	public Rect rect { get; set; }
	[NativePropertyAttribute] // RVA: 0x78320 Offset: 0x77720 VA: 0x180078320
	public Rect pixelRect { get; set; }
	public int pixelWidth { get; }
	public int pixelHeight { get; }
	public RenderTexture targetTexture { get; set; }
	public int targetDisplay { get; }
	public Matrix4x4 worldToCameraMatrix { get; }
	public Matrix4x4 projectionMatrix { get; set; }
	public Matrix4x4 nonJitteredProjectionMatrix { get; set; }
	[NativePropertyAttribute] // RVA: 0x783F0 Offset: 0x777F0 VA: 0x1800783F0
	public bool useJitteredProjectionMatrixForTransparentRendering { set; }
	public static Camera main { get; }
	public static Camera current { get; }
	public bool stereoEnabled { get; }
	public StereoTargetEyeMask stereoTargetEye { get; }
	public Camera.MonoOrStereoscopicEye stereoActiveEye { get; }
	public static int allCamerasCount { get; }

	// Methods

	// RVA: 0x181D5F0 Offset: 0x181C9F0 VA: 0x18181D5F0
	public float get_nearClipPlane() { }

	// RVA: 0x181E0D0 Offset: 0x181D4D0 VA: 0x18181E0D0
	public void set_nearClipPlane(float value) { }

	// RVA: 0x181D500 Offset: 0x181C900 VA: 0x18181D500
	public float get_farClipPlane() { }

	// RVA: 0x181DEF0 Offset: 0x181D2F0 VA: 0x18181DEF0
	public void set_farClipPlane(float value) { }

	// RVA: 0x181D540 Offset: 0x181C940 VA: 0x18181D540
	public float get_fieldOfView() { }

	// RVA: 0x181DF40 Offset: 0x181D340 VA: 0x18181DF40
	public void set_fieldOfView(float value) { }

	// RVA: 0x181E440 Offset: 0x181D840 VA: 0x18181E440
	public void set_renderingPath(RenderingPath value) { }

	[NativeNameAttribute] // RVA: 0x760C0 Offset: 0x754C0 VA: 0x1800760C0
	// RVA: 0x181D1B0 Offset: 0x181C5B0 VA: 0x18181D1B0
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x181D1F0 Offset: 0x181C5F0 VA: 0x18181D1F0
	public bool get_allowHDR() { }

	// RVA: 0x181DCA0 Offset: 0x181D0A0 VA: 0x18181DCA0
	public void set_allowHDR(bool value) { }

	// RVA: 0x181D230 Offset: 0x181C630 VA: 0x18181D230
	public bool get_allowMSAA() { }

	// RVA: 0x181DCF0 Offset: 0x181D0F0 VA: 0x18181DCF0
	public void set_allowMSAA(bool value) { }

	// RVA: 0x181DFE0 Offset: 0x181D3E0 VA: 0x18181DFE0
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x181D6E0 Offset: 0x181CAE0 VA: 0x18181D6E0
	public float get_orthographicSize() { }

	// RVA: 0x181E1C0 Offset: 0x181D5C0 VA: 0x18181E1C0
	public void set_orthographicSize(float value) { }

	// RVA: 0x181D720 Offset: 0x181CB20 VA: 0x18181D720
	public bool get_orthographic() { }

	// RVA: 0x181E210 Offset: 0x181D610 VA: 0x18181E210
	public void set_orthographic(bool value) { }

	// RVA: 0x181D480 Offset: 0x181C880 VA: 0x18181D480
	public float get_depth() { }

	// RVA: 0x181D270 Offset: 0x181C670 VA: 0x18181D270
	public float get_aspect() { }

	// RVA: 0x181DD40 Offset: 0x181D140 VA: 0x18181DD40
	public void set_aspect(float value) { }

	// RVA: 0x181D3D0 Offset: 0x181C7D0 VA: 0x18181D3D0
	public int get_cullingMask() { }

	// RVA: 0x181DE70 Offset: 0x181D270 VA: 0x18181DE70
	public void set_cullingMask(int value) { }

	// RVA: 0x181D4C0 Offset: 0x181C8C0 VA: 0x18181D4C0
	public int get_eventMask() { }

	// RVA: 0x181D350 Offset: 0x181C750 VA: 0x18181D350
	public CameraType get_cameraType() { }

	[FreeFunctionAttribute] // RVA: 0x761A0 Offset: 0x755A0 VA: 0x1800761A0
	// RVA: 0x181C0E0 Offset: 0x181B4E0 VA: 0x18181C0E0
	private float[] GetLayerCullDistances() { }

	[FreeFunctionAttribute] // RVA: 0x762D0 Offset: 0x756D0 VA: 0x1800762D0
	// RVA: 0x181C9F0 Offset: 0x181BDF0 VA: 0x18181C9F0
	private void SetLayerCullDistances(float[] d) { }

	// RVA: 0x181C0E0 Offset: 0x181B4E0 VA: 0x18181C0E0
	public float[] get_layerCullDistances() { }

	// RVA: 0x181E030 Offset: 0x181D430 VA: 0x18181E030
	public void set_layerCullDistances(float[] value) { }

	// RVA: 0x181D300 Offset: 0x181C700 VA: 0x18181D300
	public Color get_backgroundColor() { }

	// RVA: 0x181DDE0 Offset: 0x181D1E0 VA: 0x18181DDE0
	public void set_backgroundColor(Color value) { }

	// RVA: 0x181D390 Offset: 0x181C790 VA: 0x18181D390
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x181DE30 Offset: 0x181D230 VA: 0x18181DE30
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x181D440 Offset: 0x181C840 VA: 0x18181D440
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x181DEB0 Offset: 0x181D2B0 VA: 0x18181DEB0
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x181CA40 Offset: 0x181BE40 VA: 0x18181CA40
	public void SetReplacementShader(Shader shader, string replacementTag) { }

	// RVA: 0x181DBB0 Offset: 0x181CFB0 VA: 0x18181DBB0
	public bool get_usePhysicalProperties() { }

	// RVA: 0x181E5B0 Offset: 0x181D9B0 VA: 0x18181E5B0
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x181DA20 Offset: 0x181CE20 VA: 0x18181DA20
	public Vector2 get_sensorSize() { }

	// RVA: 0x181E4D0 Offset: 0x181D8D0 VA: 0x18181E4D0
	public void set_sensorSize(Vector2 value) { }

	// RVA: 0x181D580 Offset: 0x181C980 VA: 0x18181D580
	public float get_focalLength() { }

	// RVA: 0x181DF90 Offset: 0x181D390 VA: 0x18181DF90
	public void set_focalLength(float value) { }

	// RVA: 0x181D980 Offset: 0x181CD80 VA: 0x18181D980
	public Rect get_rect() { }

	// RVA: 0x181E3F0 Offset: 0x181D7F0 VA: 0x18181E3F0
	public void set_rect(Rect value) { }

	// RVA: 0x181D7F0 Offset: 0x181CBF0 VA: 0x18181D7F0
	public Rect get_pixelRect() { }

	// RVA: 0x181E2B0 Offset: 0x181D6B0 VA: 0x18181E2B0
	public void set_pixelRect(Rect value) { }

	[FreeFunctionAttribute] // RVA: 0x76510 Offset: 0x75910 VA: 0x180076510
	// RVA: 0x181D840 Offset: 0x181CC40 VA: 0x18181D840
	public int get_pixelWidth() { }

	[FreeFunctionAttribute] // RVA: 0x76650 Offset: 0x75A50 VA: 0x180076650
	// RVA: 0x181D760 Offset: 0x181CB60 VA: 0x18181D760
	public int get_pixelHeight() { }

	// RVA: 0x181DB70 Offset: 0x181CF70 VA: 0x18181DB70
	public RenderTexture get_targetTexture() { }

	// RVA: 0x181E510 Offset: 0x181D910 VA: 0x18181E510
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x181DB30 Offset: 0x181CF30 VA: 0x18181DB30
	public int get_targetDisplay() { }

	// RVA: 0x181DC40 Offset: 0x181D040 VA: 0x18181DC40
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x181D8D0 Offset: 0x181CCD0 VA: 0x18181D8D0
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x181E350 Offset: 0x181D750 VA: 0x18181E350
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x181D680 Offset: 0x181CA80 VA: 0x18181D680
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0x181E170 Offset: 0x181D570 VA: 0x18181E170
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x181E560 Offset: 0x181D960 VA: 0x18181E560
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x181C5E0 Offset: 0x181B9E0 VA: 0x18181C5E0
	public void ResetProjectionMatrix() { }

	// RVA: 0x181CF40 Offset: 0x181C340 VA: 0x18181CF40
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x181D0B0 Offset: 0x181C4B0 VA: 0x18181D0B0
	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x181CFB0 Offset: 0x181C3B0 VA: 0x18181CFB0
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x181D120 Offset: 0x181C520 VA: 0x18181D120
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x181C990 Offset: 0x181BD90 VA: 0x18181C990
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x181CE70 Offset: 0x181C270 VA: 0x18181CE70
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0x181CCB0 Offset: 0x181C0B0 VA: 0x18181CCB0
	private Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x181CBB0 Offset: 0x181BFB0 VA: 0x18181CBB0
	public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x181CD20 Offset: 0x181C120 VA: 0x18181CD20
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x181C8C0 Offset: 0x181BCC0 VA: 0x18181C8C0
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x181C7C0 Offset: 0x181BBC0 VA: 0x18181C7C0
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x181C6D0 Offset: 0x181BAD0 VA: 0x18181C6D0
	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunctionAttribute] // RVA: 0x767B0 Offset: 0x75BB0 VA: 0x1800767B0
	// RVA: 0x181BC20 Offset: 0x181B020 VA: 0x18181BC20
	private void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x181BC90 Offset: 0x181B090 VA: 0x18181BC90
	public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[FreeFunctionAttribute] // RVA: 0x76910 Offset: 0x75D10 VA: 0x180076910
	// RVA: 0x181D5C0 Offset: 0x181C9C0 VA: 0x18181D5C0
	public static Camera get_main() { }

	[FreeFunctionAttribute] // RVA: 0x769F0 Offset: 0x75DF0 VA: 0x1800769F0
	// RVA: 0x181D410 Offset: 0x181C810 VA: 0x18181D410
	public static Camera get_current() { }

	// RVA: 0x181DAB0 Offset: 0x181CEB0 VA: 0x18181DAB0
	public bool get_stereoEnabled() { }

	// RVA: 0x181DAF0 Offset: 0x181CEF0 VA: 0x18181DAF0
	public StereoTargetEyeMask get_stereoTargetEye() { }

	[FreeFunctionAttribute] // RVA: 0x76BD0 Offset: 0x75FD0 VA: 0x180076BD0
	// RVA: 0x181DA70 Offset: 0x181CE70 VA: 0x18181DA70
	public Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x181C170 Offset: 0x181B570 VA: 0x18181C170
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x181C2F0 Offset: 0x181B6F0 VA: 0x18181C2F0
	public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x181BE00 Offset: 0x181B200 VA: 0x18181BE00
	public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye) { }

	// RVA: 0x181C230 Offset: 0x181B630 VA: 0x18181C230
	public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x181CAF0 Offset: 0x181BEF0 VA: 0x18181CAF0
	public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x181C620 Offset: 0x181BA20 VA: 0x18181C620
	public void ResetStereoProjectionMatrices() { }

	[FreeFunctionAttribute] // RVA: 0x76D20 Offset: 0x76120 VA: 0x180076D20
	// RVA: 0x181BF50 Offset: 0x181B350 VA: 0x18181BF50
	private static int GetAllCamerasCount() { }

	[FreeFunctionAttribute] // RVA: 0x76E30 Offset: 0x76230 VA: 0x180076E30
	// RVA: 0x181BF80 Offset: 0x181B380 VA: 0x18181BF80
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x181BF50 Offset: 0x181B350 VA: 0x18181BF50
	public static int get_allCamerasCount() { }

	// RVA: 0x181BFC0 Offset: 0x181B3C0 VA: 0x18181BFC0
	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunctionAttribute] // RVA: 0x77040 Offset: 0x76440 VA: 0x180077040
	// RVA: 0x181C5A0 Offset: 0x181B9A0 VA: 0x18181C5A0
	public void Render() { }

	[FreeFunctionAttribute] // RVA: 0x771D0 Offset: 0x765D0 VA: 0x1800771D0
	// RVA: 0x181C540 Offset: 0x181B940 VA: 0x18181C540
	public void RenderWithShader(Shader shader, string replacementTag) { }

	[FreeFunctionAttribute] // RVA: 0x77280 Offset: 0x76680 VA: 0x180077280
	// RVA: 0x181BDB0 Offset: 0x181B1B0 VA: 0x18181BDB0
	public void CopyFrom(Camera other) { }

	// RVA: 0x181C500 Offset: 0x181B900 VA: 0x18181C500
	public void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0x181C360 Offset: 0x181B760 VA: 0x18181C360
	public void RemoveAllCommandBuffers() { }

	[NativeNameAttribute] // RVA: 0x773D0 Offset: 0x767D0 VA: 0x1800773D0
	// RVA: 0x181BA50 Offset: 0x181AE50 VA: 0x18181BA50
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[NativeNameAttribute] // RVA: 0x77660 Offset: 0x76A60 VA: 0x180077660
	// RVA: 0x181C3A0 Offset: 0x181B7A0 VA: 0x18181C3A0
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x181BAA0 Offset: 0x181AEA0 VA: 0x18181BAA0
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x181C3F0 Offset: 0x181B7F0 VA: 0x18181C3F0
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x77810 Offset: 0x76C10 VA: 0x180077810
	// RVA: 0x181C0A0 Offset: 0x181B4A0 VA: 0x18181C0A0
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x181BEA0 Offset: 0x181B2A0 VA: 0x18181BEA0
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x181BEF0 Offset: 0x181B2F0 VA: 0x18181BEF0
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x181BE40 Offset: 0x181B240 VA: 0x18181BE40
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x181A730 Offset: 0x1819B30 VA: 0x18181A730
	public void .ctor() { }

	// RVA: 0x181D2B0 Offset: 0x181C6B0 VA: 0x18181D2B0
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x181DD90 Offset: 0x181D190 VA: 0x18181DD90
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x181D9D0 Offset: 0x181CDD0 VA: 0x18181D9D0
	private void get_sensorSize_Injected(out Vector2 ret) { }

	// RVA: 0x181E480 Offset: 0x181D880 VA: 0x18181E480
	private void set_sensorSize_Injected(ref Vector2 value) { }

	// RVA: 0x181D930 Offset: 0x181CD30 VA: 0x18181D930
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x181E3A0 Offset: 0x181D7A0 VA: 0x18181E3A0
	private void set_rect_Injected(ref Rect value) { }

	// RVA: 0x181D7A0 Offset: 0x181CBA0 VA: 0x18181D7A0
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x181E260 Offset: 0x181D660 VA: 0x18181E260
	private void set_pixelRect_Injected(ref Rect value) { }

	// RVA: 0x181DBF0 Offset: 0x181CFF0 VA: 0x18181DBF0
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x181D880 Offset: 0x181CC80 VA: 0x18181D880
	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x181E300 Offset: 0x181D700 VA: 0x18181E300
	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x181D630 Offset: 0x181CA30 VA: 0x18181D630
	private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x181E120 Offset: 0x181D520 VA: 0x18181E120
	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x181CED0 Offset: 0x181C2D0 VA: 0x18181CED0
	private void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x181D040 Offset: 0x181C440 VA: 0x18181D040
	private void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x181C930 Offset: 0x181BD30 VA: 0x18181C930
	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x181CE10 Offset: 0x181C210 VA: 0x18181CE10
	private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x181CB40 Offset: 0x181BF40 VA: 0x18181CB40
	private void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x181C660 Offset: 0x181BA60 VA: 0x18181C660
	private void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x181BBB0 Offset: 0x181AFB0 VA: 0x18181BBB0
	private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x181C120 Offset: 0x181B520 VA: 0x18181C120
	private void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x181C2A0 Offset: 0x181B6A0 VA: 0x18181C2A0
	private void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x181C1E0 Offset: 0x181B5E0 VA: 0x18181C1E0
	private void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x181CAA0 Offset: 0x181BEA0 VA: 0x18181CAA0
	private void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }

}

public enum Camera.StereoscopicEye // TypeDefIndex: 3361
{	// Fields
	public int value__; // 0x0
	public const Camera.StereoscopicEye Left = 0;
	public const Camera.StereoscopicEye Right = 1;

}

public enum Camera.MonoOrStereoscopicEye // TypeDefIndex: 3362
{	// Fields
	public int value__; // 0x0
	public const Camera.MonoOrStereoscopicEye Left = 0;
	public const Camera.MonoOrStereoscopicEye Right = 1;
	public const Camera.MonoOrStereoscopicEye Mono = 2;

}

public sealed class Camera.CameraCallback : MulticastDelegate // TypeDefIndex: 3363
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497240 Offset: 0x496640 VA: 0x180497240 Slot: 12
	public virtual void Invoke(Camera cam) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

