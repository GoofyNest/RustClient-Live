public static class RuntimeUtilities // TypeDefIndex: 13602
{
	private static Texture2D m_WhiteTexture; 
	private static Texture3D m_WhiteTexture3D; 
	private static Texture2D m_BlackTexture; 
	private static Texture3D m_BlackTexture3D; 
	private static Texture2D m_TransparentTexture; 
	private static Texture3D m_TransparentTexture3D; 
	private static Dictionary<int, Texture2D> m_LutStrips; 
	internal static PostProcessResources s_Resources; 
	private static Mesh s_FullscreenTriangle; 
	private static Material s_CopyStdMaterial; 
	private static Material s_CopyStdFromDoubleWideMaterial; 
	private static Material s_CopyMaterial; 
	private static Material s_CopyFromTexArrayMaterial; 
	private static PropertySheet s_CopySheet; 
	private static PropertySheet s_CopyFromTexArraySheet; 
	private static IEnumerable<Type> m_AssemblyTypes; 

	public static Texture2D whiteTexture { get; }
	public static Texture3D whiteTexture3D { get; }
	public static Texture2D blackTexture { get; }
	public static Texture3D blackTexture3D { get; }
	public static Texture2D transparentTexture { get; }
	public static Texture3D transparentTexture3D { get; }
	public static Mesh fullscreenTriangle { get; }
	public static Material copyStdMaterial { get; }
	public static Material copyStdFromDoubleWideMaterial { get; }
	public static Material copyMaterial { get; }
	public static Material copyFromTexArrayMaterial { get; }
	public static PropertySheet copySheet { get; }
	public static PropertySheet copyFromTexArraySheet { get; }
	public static bool scriptableRenderPipelineActive { get; }
	public static bool supportsDeferredShading { get; }
	public static bool supportsDepthNormals { get; }
	public static bool isSinglePassStereoEnabled { get; }
	public static bool isVREnabled { get; }
	public static bool isAndroidOpenGL { get; }
	public static RenderTextureFormat defaultHDRRenderTextureFormat { get; }
	public static bool isLinearColorSpace { get; }


	public static Texture2D get_whiteTexture() { }

	public static Texture3D get_whiteTexture3D() { }

	public static Texture2D get_blackTexture() { }

	public static Texture3D get_blackTexture3D() { }

	public static Texture2D get_transparentTexture() { }

	public static Texture3D get_transparentTexture3D() { }

	public static Texture2D GetLutStrip(int size) { }

	public static Mesh get_fullscreenTriangle() { }

	public static Material get_copyStdMaterial() { }

	public static Material get_copyStdFromDoubleWideMaterial() { }

	public static Material get_copyMaterial() { }

	public static Material get_copyFromTexArrayMaterial() { }

	public static PropertySheet get_copySheet() { }

	public static PropertySheet get_copyFromTexArraySheet() { }

	[ExtensionAttribute] 
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[ExtensionAttribute] 
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[ExtensionAttribute] 
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] 
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable<Rect> viewport) { }

	[ExtensionAttribute] 
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] 
	public static void BlitFullscreenTriangleFromDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye) { }

	[ExtensionAttribute] 
	public static void BlitFullscreenTriangleToDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye) { }

	[ExtensionAttribute] 
	public static void BlitFullscreenTriangleFromTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] 
	public static void BlitFullscreenTriangleToTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] 
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] 
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] 
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	[ExtensionAttribute] 
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0) { }

	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	public static bool get_scriptableRenderPipelineActive() { }

	public static bool get_supportsDeferredShading() { }

	public static bool get_supportsDepthNormals() { }

	public static bool get_isSinglePassStereoEnabled() { }

	public static bool get_isVREnabled() { }

	public static bool get_isAndroidOpenGL() { }

	public static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	public static bool isFloatingPointFormat(RenderTextureFormat format) { }

	public static void Destroy(Object obj) { }

	public static bool get_isLinearColorSpace() { }

	public static bool IsResolvedDepthAvailable(Camera camera) { }

	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) { }

	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = False) { }

	public static bool IsPostProcessingActive(PostProcessLayer layer) { }

	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer) { }

	[IteratorStateMachineAttribute] 
	public static IEnumerable<T> GetAllSceneObjects<T>() { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.GetAllSceneObjects<object>
	*/

	public static void CreateIfNull<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.CreateIfNull<List<PostProcessLayer.SerializedBundleRef>>
	|-RuntimeUtilities.CreateIfNull<object>
	|-RuntimeUtilities.CreateIfNull<Dithering>
	|-RuntimeUtilities.CreateIfNull<FastApproximateAntialiasing>
	|-RuntimeUtilities.CreateIfNull<Fog>
	|-RuntimeUtilities.CreateIfNull<HistogramMonitor>
	|-RuntimeUtilities.CreateIfNull<LightMeterMonitor>
	|-RuntimeUtilities.CreateIfNull<PostProcessDebugLayer.OverlaySettings>
	|-RuntimeUtilities.CreateIfNull<PostProcessDebugLayer>
	|-RuntimeUtilities.CreateIfNull<SubpixelMorphologicalAntialiasing>
	|-RuntimeUtilities.CreateIfNull<TemporalAntialiasing>
	|-RuntimeUtilities.CreateIfNull<VectorscopeMonitor>
	|-RuntimeUtilities.CreateIfNull<WaveformMonitor>
	*/

	public static float Exp2(float x) { }

	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) { }

	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) { }

	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) { }

	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	[ExtensionAttribute] 
	public static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.GetAttribute<object>
	|-RuntimeUtilities.GetAttribute<PostProcessAttribute>
	*/

	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.GetMemberAttributes<object, object>
	*/

	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.GetFieldPath<object, object>
	*/

	private static void .cctor() { }

}

private sealed class RuntimeUtilities.<GetAllSceneObjects>d__79<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 13603
{
	private int <>1__state; 
	private T <>2__current; 
	private int <>l__initialThreadId; 
	private Queue<Transform> <queue>5__2; 
	private GameObject[] <>7__wrap2; 
	private int <>7__wrap3; 
	private IEnumerator <>7__wrap4; 

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>..ctor
	*/

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] 
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] 
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class RuntimeUtilities.<>c // TypeDefIndex: 13604
{
	public static readonly RuntimeUtilities.<>c <>9; 
	public static Func<Assembly, IEnumerable<Type>> <>9__86_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal IEnumerable<Type> <GetAllAssemblyTypes>b__86_0(Assembly t) { }

}

