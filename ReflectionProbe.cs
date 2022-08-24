public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 3368
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static Action<Cubemap> defaultReflectionSet; 

	[NativeNameAttribute] 
	public Vector3 size { set; }
	[NativeNameAttribute] 
	public float nearClipPlane { get; set; }
	[NativeNameAttribute] 
	public float farClipPlane { get; set; }
	[NativeNameAttribute] 
	public float intensity { get; set; }
	[NativeNameAttribute] 
	public bool hdr { get; }
	public float shadowDistance { get; }
	public int resolution { get; set; }
	public int cullingMask { set; }
	public ReflectionProbeClearFlags clearFlags { get; set; }
	public Color backgroundColor { get; set; }
	public ReflectionProbeMode mode { get; set; }
	public int importance { set; }
	public ReflectionProbeRefreshMode refreshMode { get; set; }
	public ReflectionProbeTimeSlicingMode timeSlicingMode { get; set; }
	public Texture customBakedTexture { get; set; }
	public RenderTexture realtimeTexture { get; }
	public Texture texture { get; }


	public void set_size(Vector3 value) { }

	public float get_nearClipPlane() { }

	public void set_nearClipPlane(float value) { }

	public float get_farClipPlane() { }

	public void set_farClipPlane(float value) { }

	public float get_intensity() { }

	public void set_intensity(float value) { }

	public bool get_hdr() { }

	public float get_shadowDistance() { }

	public int get_resolution() { }

	public void set_resolution(int value) { }

	public void set_cullingMask(int value) { }

	public ReflectionProbeClearFlags get_clearFlags() { }

	public void set_clearFlags(ReflectionProbeClearFlags value) { }

	public Color get_backgroundColor() { }

	public void set_backgroundColor(Color value) { }

	public ReflectionProbeMode get_mode() { }

	public void set_mode(ReflectionProbeMode value) { }

	public void set_importance(int value) { }

	public ReflectionProbeRefreshMode get_refreshMode() { }

	public void set_refreshMode(ReflectionProbeRefreshMode value) { }

	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	public void set_timeSlicingMode(ReflectionProbeTimeSlicingMode value) { }

	public Texture get_customBakedTexture() { }

	public void set_customBakedTexture(Texture value) { }

	public RenderTexture get_realtimeTexture() { }

	public Texture get_texture() { }

	public int RenderProbe() { }

	public int RenderProbe(RenderTexture targetTexture) { }

	public bool IsFinishedRendering(int renderId) { }

	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	[FreeFunctionAttribute] 
	[NativeHeaderAttribute] 
	public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target) { }

	[RequiredByNativeCodeAttribute] 
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCodeAttribute] 
	private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

	private void set_size_Injected(ref Vector3 value) { }

	private void get_backgroundColor_Injected(out Color ret) { }

	private void set_backgroundColor_Injected(ref Color value) { }

}

public enum ReflectionProbe.ReflectionProbeEvent // TypeDefIndex: 3369
{
	public int value__; 
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeAdded = 0;
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeRemoved = 1;

}

