public static class RenderPipelineManager // TypeDefIndex: 3851
{
	private static RenderPipelineAsset s_CurrentPipelineAsset; 
	private static Camera[] s_Cameras; 
	private static int s_CameraCapacity; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static RenderPipeline <currentPipeline>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<ScriptableRenderContext, Camera> beginCameraRendering; 

	public static RenderPipeline currentPipeline { get; set; }


	[CompilerGeneratedAttribute] 
	public static RenderPipeline get_currentPipeline() { }

	[CompilerGeneratedAttribute] 
	private static void set_currentPipeline(RenderPipeline value) { }

	[CompilerGeneratedAttribute] 
	public static void add_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] 
	public static void remove_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] 
	public static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGeneratedAttribute] 
	public static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value) { }

	[RequiredByNativeCodeAttribute] 
	internal static void CleanupRenderPipeline() { }

	private static void GetCameras(ScriptableRenderContext context) { }

	[RequiredByNativeCodeAttribute] 
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr) { }

	private static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	private static void .cctor() { }

}

