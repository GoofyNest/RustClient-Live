public static class RuntimeUtilities // TypeDefIndex: 11863
{	// Fields
	private static Texture2D m_WhiteTexture; // 0x0
	private static Texture3D m_WhiteTexture3D; // 0x8
	private static Texture2D m_BlackTexture; // 0x10
	private static Texture3D m_BlackTexture3D; // 0x18
	private static Texture2D m_TransparentTexture; // 0x20
	private static Texture3D m_TransparentTexture3D; // 0x28
	private static Dictionary<int, Texture2D> m_LutStrips; // 0x30
	internal static PostProcessResources s_Resources; // 0x38
	private static Mesh s_FullscreenTriangle; // 0x40
	private static Material s_CopyStdMaterial; // 0x48
	private static Material s_CopyStdFromDoubleWideMaterial; // 0x50
	private static Material s_CopyMaterial; // 0x58
	private static Material s_CopyFromTexArrayMaterial; // 0x60
	private static PropertySheet s_CopySheet; // 0x68
	private static PropertySheet s_CopyFromTexArraySheet; // 0x70
	private static IEnumerable<Type> m_AssemblyTypes; // 0x78

	// Properties
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

	// Methods

	// RVA: 0x11D5CB0 Offset: 0x11D50B0 VA: 0x1811D5CB0
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x11D5AC0 Offset: 0x11D4EC0 VA: 0x1811D5AC0
	public static Texture3D get_whiteTexture3D() { }

	// RVA: 0x11D4480 Offset: 0x11D3880 VA: 0x1811D4480
	public static Texture2D get_blackTexture() { }

	// RVA: 0x11D4290 Offset: 0x11D3690 VA: 0x1811D4290
	public static Texture3D get_blackTexture3D() { }

	// RVA: 0x11D5900 Offset: 0x11D4D00 VA: 0x1811D5900
	public static Texture2D get_transparentTexture() { }

	// RVA: 0x11D5710 Offset: 0x11D4B10 VA: 0x1811D5710
	public static Texture3D get_transparentTexture3D() { }

	// RVA: 0x11D3B30 Offset: 0x11D2F30 VA: 0x1811D3B30
	public static Texture2D GetLutStrip(int size) { }

	// RVA: 0x11D5180 Offset: 0x11D4580 VA: 0x1811D5180
	public static Mesh get_fullscreenTriangle() { }

	// RVA: 0x11D4FA0 Offset: 0x11D43A0 VA: 0x1811D4FA0
	public static Material get_copyStdMaterial() { }

	// RVA: 0x11D4DC0 Offset: 0x11D41C0 VA: 0x1811D4DC0
	public static Material get_copyStdFromDoubleWideMaterial() { }

	// RVA: 0x11D4AD0 Offset: 0x11D3ED0 VA: 0x1811D4AD0
	public static Material get_copyMaterial() { }

	// RVA: 0x11D4640 Offset: 0x11D3A40 VA: 0x1811D4640
	public static Material get_copyFromTexArrayMaterial() { }

	// RVA: 0x11D4CB0 Offset: 0x11D40B0 VA: 0x1811D4CB0
	public static PropertySheet get_copySheet() { }

	// RVA: 0x11D4820 Offset: 0x11D3C20 VA: 0x1811D4820
	public static PropertySheet get_copyFromTexArraySheet() { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D41D0 Offset: 0x11D35D0 VA: 0x1811D41D0
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D4140 Offset: 0x11D3540 VA: 0x1811D4140
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D27D0 Offset: 0x11D1BD0 VA: 0x1811D27D0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D2560 Offset: 0x11D1960 VA: 0x1811D2560
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D2130 Offset: 0x11D1530 VA: 0x1811D2130
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D18C0 Offset: 0x11D0CC0 VA: 0x1811D18C0
	public static void BlitFullscreenTriangleFromDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D1CD0 Offset: 0x11D10D0 VA: 0x1811D1CD0
	public static void BlitFullscreenTriangleToDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D1AA0 Offset: 0x11D0EA0 VA: 0x1811D1AA0
	public static void BlitFullscreenTriangleFromTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D1F10 Offset: 0x11D1310 VA: 0x1811D1F10
	public static void BlitFullscreenTriangleToTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D2260 Offset: 0x11D1660 VA: 0x1811D2260
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D2A70 Offset: 0x11D1E70 VA: 0x1811D2A70
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D2D90 Offset: 0x11D2190 VA: 0x1811D2D90
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D2C90 Offset: 0x11D2090 VA: 0x1811D2C90
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0) { }

	// RVA: 0x11D2E70 Offset: 0x11D2270 VA: 0x1811D2E70
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	// RVA: 0x11D5550 Offset: 0x11D4950 VA: 0x1811D5550
	public static bool get_scriptableRenderPipelineActive() { }

	// RVA: 0x11D55B0 Offset: 0x11D49B0 VA: 0x1811D55B0
	public static bool get_supportsDeferredShading() { }

	// RVA: 0x11D5660 Offset: 0x11D4A60 VA: 0x1811D5660
	public static bool get_supportsDepthNormals() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	public static bool get_isSinglePassStereoEnabled() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	public static bool get_isVREnabled() { }

	// RVA: 0x11D5500 Offset: 0x11D4900 VA: 0x1811D5500
	public static bool get_isAndroidOpenGL() { }

	// RVA: 0xE61370 Offset: 0xE60770 VA: 0x180E61370
	public static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	// RVA: 0x11D5E60 Offset: 0x11D5260 VA: 0x1811D5E60
	public static bool isFloatingPointFormat(RenderTextureFormat format) { }

	// RVA: 0x11D32A0 Offset: 0x11D26A0 VA: 0x1811D32A0
	public static void Destroy(Object obj) { }

	// RVA: 0x11D5530 Offset: 0x11D4930 VA: 0x1811D5530
	public static bool get_isLinearColorSpace() { }

	// RVA: 0x11D3FE0 Offset: 0x11D33E0 VA: 0x1811D3FE0
	public static bool IsResolvedDepthAvailable(Camera camera) { }

	// RVA: 0x11D2FE0 Offset: 0x11D23E0 VA: 0x1811D2FE0
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) { }

	// RVA: 0x11D3150 Offset: 0x11D2550 VA: 0x1811D3150
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = False) { }

	// RVA: 0x11D3F60 Offset: 0x11D3360 VA: 0x1811D3F60
	public static bool IsPostProcessingActive(PostProcessLayer layer) { }

	// RVA: 0x11D4050 Offset: 0x11D3450 VA: 0x1811D4050
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer) { }

	[IteratorStateMachineAttribute] // RVA: 0x7FB90 Offset: 0x7EF90 VA: 0x18007FB90
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAllSceneObjects<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFE290 Offset: 0xCFD690 VA: 0x180CFE290
	|-RuntimeUtilities.GetAllSceneObjects<object>
	*/

	// RVA: -1 Offset: -1
	public static void CreateIfNull<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5ED3F0 Offset: 0x5EC7F0 VA: 0x1805ED3F0
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

	// RVA: 0x11D3330 Offset: 0x11D2730 VA: 0x1811D3330
	public static float Exp2(float x) { }

	// RVA: 0x11D3930 Offset: 0x11D2D30 VA: 0x1811D3930
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x11D3740 Offset: 0x11D2B40 VA: 0x1811D3740
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x11D3390 Offset: 0x11D2790 VA: 0x1811D3390
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) { }

	// RVA: 0x11D3570 Offset: 0x11D2970 VA: 0x1811D3570
	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C0410 Offset: 0x14BF810 VA: 0x1814C0410
	|-RuntimeUtilities.GetAttribute<object>
	|-RuntimeUtilities.GetAttribute<PostProcessAttribute>
	*/

	// RVA: -1 Offset: -1
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12597B0 Offset: 0x1258BB0 VA: 0x1812597B0
	|-RuntimeUtilities.GetMemberAttributes<object, object>
	*/

	// RVA: -1 Offset: -1
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE83BA0 Offset: 0xE82FA0 VA: 0x180E83BA0
	|-RuntimeUtilities.GetFieldPath<object, object>
	*/

	// RVA: 0x11D4220 Offset: 0x11D3620 VA: 0x1811D4220
	private static void .cctor() { }

}

private sealed class RuntimeUtilities.<GetAllSceneObjects>d__79<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 11864
{	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Queue<Transform> <queue>5__2; // 0x0
	private GameObject[] <>7__wrap2; // 0x0
	private int <>7__wrap3; // 0x0
	private IEnumerator <>7__wrap4; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C1D90 Offset: 0x19C1190 VA: 0x1819C1D90
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C18A0 Offset: 0x19C0CA0 VA: 0x1819C18A0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C1E10 Offset: 0x19C1210 VA: 0x1819C1E10
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C1D40 Offset: 0x19C1140 VA: 0x1819C1D40
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C1C70 Offset: 0x19C1070 VA: 0x1819C1C70
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C1D10 Offset: 0x19C1110 VA: 0x1819C1D10
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class RuntimeUtilities.<>c // TypeDefIndex: 11865
{	// Fields
	public static readonly RuntimeUtilities.<>c <>9; // 0x0
	public static Func<Assembly, IEnumerable<Type>> <>9__86_0; // 0x8

	// Methods

	// RVA: 0x11E22F0 Offset: 0x11E16F0 VA: 0x1811E22F0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x11E2180 Offset: 0x11E1580 VA: 0x1811E2180
	internal IEnumerable<Type> <GetAllAssemblyTypes>b__86_0(Assembly t) { }

}

