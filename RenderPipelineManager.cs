public static class RenderPipelineManager // TypeDefIndex: 3851
{	// Fields
	private static RenderPipelineAsset s_CurrentPipelineAsset; // 0x0
	private static Camera[] s_Cameras; // 0x8
	private static int s_CameraCapacity; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static RenderPipeline <currentPipeline>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action<ScriptableRenderContext, Camera> beginCameraRendering; // 0x28

	// Properties
	public static RenderPipeline currentPipeline { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AA270 Offset: 0x19A9670 VA: 0x1819AA270
	public static RenderPipeline get_currentPipeline() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AA4D0 Offset: 0x19A98D0 VA: 0x1819AA4D0
	private static void set_currentPipeline(RenderPipeline value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AA170 Offset: 0x19A9570 VA: 0x1819AA170
	public static void add_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AA3D0 Offset: 0x19A97D0 VA: 0x1819AA3D0
	public static void remove_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AA070 Offset: 0x19A9470 VA: 0x1819AA070
	public static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AA2D0 Offset: 0x19A96D0 VA: 0x1819AA2D0
	public static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19A94E0 Offset: 0x19A88E0 VA: 0x1819A94E0
	internal static void CleanupRenderPipeline() { }

	// RVA: 0x19A9BC0 Offset: 0x19A8FC0 VA: 0x1819A9BC0
	private static void GetCameras(ScriptableRenderContext context) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19A9820 Offset: 0x19A8C20 VA: 0x1819A9820
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr) { }

	// RVA: 0x19A9D70 Offset: 0x19A9170 VA: 0x1819A9D70
	private static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x19AA000 Offset: 0x19A9400 VA: 0x1819AA000
	private static void .cctor() { }

}

