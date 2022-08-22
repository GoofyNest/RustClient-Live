public sealed class Camera : Behaviour // TypeDefIndex: 3360
{	public static Camera.CameraCallback onPreCull; // 0x0
	public static Camera.CameraCallback onPreRender; // 0x8
	public static Camera.CameraCallback onPostRender; // 0x10

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


	public float get_nearClipPlane() { }

	public void set_nearClipPlane(float value) { }

	public float get_farClipPlane() { }

	public void set_farClipPlane(float value) { }

	public float get_fieldOfView() { }

	public void set_fieldOfView(float value) { }

	public void set_renderingPath(RenderingPath value) { }

	[NativeNameAttribute] // RVA: 0x760C0 Offset: 0x754C0 VA: 0x1800760C0
	public RenderingPath get_actualRenderingPath() { }

	public bool get_allowHDR() { }

	public void set_allowHDR(bool value) { }

	public bool get_allowMSAA() { }

	public void set_allowMSAA(bool value) { }

	public void set_forceIntoRenderTexture(bool value) { }

	public float get_orthographicSize() { }

	public void set_orthographicSize(float value) { }

	public bool get_orthographic() { }

	public void set_orthographic(bool value) { }

	public float get_depth() { }

	public float get_aspect() { }

	public void set_aspect(float value) { }

	public int get_cullingMask() { }

	public void set_cullingMask(int value) { }

	public int get_eventMask() { }

	public CameraType get_cameraType() { }

	[FreeFunctionAttribute] // RVA: 0x761A0 Offset: 0x755A0 VA: 0x1800761A0
	private float[] GetLayerCullDistances() { }

	[FreeFunctionAttribute] // RVA: 0x762D0 Offset: 0x756D0 VA: 0x1800762D0
	private void SetLayerCullDistances(float[] d) { }

	public float[] get_layerCullDistances() { }

	public void set_layerCullDistances(float[] value) { }

	public Color get_backgroundColor() { }

	public void set_backgroundColor(Color value) { }

	public CameraClearFlags get_clearFlags() { }

	public void set_clearFlags(CameraClearFlags value) { }

	public DepthTextureMode get_depthTextureMode() { }

	public void set_depthTextureMode(DepthTextureMode value) { }

	public void SetReplacementShader(Shader shader, string replacementTag) { }

	public bool get_usePhysicalProperties() { }

	public void set_usePhysicalProperties(bool value) { }

	public Vector2 get_sensorSize() { }

	public void set_sensorSize(Vector2 value) { }

	public float get_focalLength() { }

	public void set_focalLength(float value) { }

	public Rect get_rect() { }

	public void set_rect(Rect value) { }

	public Rect get_pixelRect() { }

	public void set_pixelRect(Rect value) { }

	[FreeFunctionAttribute] // RVA: 0x76510 Offset: 0x75910 VA: 0x180076510
	public int get_pixelWidth() { }

	[FreeFunctionAttribute] // RVA: 0x76650 Offset: 0x75A50 VA: 0x180076650
	public int get_pixelHeight() { }

	public RenderTexture get_targetTexture() { }

	public void set_targetTexture(RenderTexture value) { }

	public int get_targetDisplay() { }

	public Matrix4x4 get_worldToCameraMatrix() { }

	public Matrix4x4 get_projectionMatrix() { }

	public void set_projectionMatrix(Matrix4x4 value) { }

	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	public void ResetProjectionMatrix() { }

	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	public Vector3 WorldToScreenPoint(Vector3 position) { }

	public Vector3 WorldToViewportPoint(Vector3 position) { }

	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	private Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	public Ray ViewportPointToRay(Vector3 pos) { }

	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunctionAttribute] // RVA: 0x767B0 Offset: 0x75BB0 VA: 0x1800767B0
	private void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[FreeFunctionAttribute] // RVA: 0x76910 Offset: 0x75D10 VA: 0x180076910
	public static Camera get_main() { }

	[FreeFunctionAttribute] // RVA: 0x769F0 Offset: 0x75DF0 VA: 0x1800769F0
	public static Camera get_current() { }

	public bool get_stereoEnabled() { }

	public StereoTargetEyeMask get_stereoTargetEye() { }

	[FreeFunctionAttribute] // RVA: 0x76BD0 Offset: 0x75FD0 VA: 0x180076BD0
	public Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }

	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye) { }

	public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye) { }

	public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye) { }

	public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye) { }

	public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	public void ResetStereoProjectionMatrices() { }

	[FreeFunctionAttribute] // RVA: 0x76D20 Offset: 0x76120 VA: 0x180076D20
	private static int GetAllCamerasCount() { }

	[FreeFunctionAttribute] // RVA: 0x76E30 Offset: 0x76230 VA: 0x180076E30
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	public static int get_allCamerasCount() { }

	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunctionAttribute] // RVA: 0x77040 Offset: 0x76440 VA: 0x180077040
	public void Render() { }

	[FreeFunctionAttribute] // RVA: 0x771D0 Offset: 0x765D0 VA: 0x1800771D0
	public void RenderWithShader(Shader shader, string replacementTag) { }

	[FreeFunctionAttribute] // RVA: 0x77280 Offset: 0x76680 VA: 0x180077280
	public void CopyFrom(Camera other) { }

	public void RemoveCommandBuffers(CameraEvent evt) { }

	public void RemoveAllCommandBuffers() { }

	[NativeNameAttribute] // RVA: 0x773D0 Offset: 0x767D0 VA: 0x1800773D0
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[NativeNameAttribute] // RVA: 0x77660 Offset: 0x76A60 VA: 0x180077660
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x77810 Offset: 0x76C10 VA: 0x180077810
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void FireOnPostRender(Camera cam) { }

	public void .ctor() { }

	private void get_backgroundColor_Injected(out Color ret) { }

	private void set_backgroundColor_Injected(ref Color value) { }

	private void get_sensorSize_Injected(out Vector2 ret) { }

	private void set_sensorSize_Injected(ref Vector2 value) { }

	private void get_rect_Injected(out Rect ret) { }

	private void set_rect_Injected(ref Rect value) { }

	private void get_pixelRect_Injected(out Rect ret) { }

	private void set_pixelRect_Injected(ref Rect value) { }

	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	private void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	private void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	private void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	private void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	private void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	private void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	private void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	private void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }

}

public enum Camera.StereoscopicEye // TypeDefIndex: 3361
{	public int value__; // 0x0
	public const Camera.StereoscopicEye Left = 0;
	public const Camera.StereoscopicEye Right = 1;

}

public enum Camera.MonoOrStereoscopicEye // TypeDefIndex: 3362
{	public int value__; // 0x0
	public const Camera.MonoOrStereoscopicEye Left = 0;
	public const Camera.MonoOrStereoscopicEye Right = 1;
	public const Camera.MonoOrStereoscopicEye Mono = 2;

}

public sealed class Camera.CameraCallback : MulticastDelegate // TypeDefIndex: 3363
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(Camera cam) { }

	public virtual IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

