public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 3368
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action<Cubemap> defaultReflectionSet; // 0x8

	// Properties
	[NativeNameAttribute] // RVA: 0x7B120 Offset: 0x7A520 VA: 0x18007B120
	public Vector3 size { set; }
	[NativeNameAttribute] // RVA: 0x7B1D0 Offset: 0x7A5D0 VA: 0x18007B1D0
	public float nearClipPlane { get; set; }
	[NativeNameAttribute] // RVA: 0x7B300 Offset: 0x7A700 VA: 0x18007B300
	public float farClipPlane { get; set; }
	[NativeNameAttribute] // RVA: 0x7B4E0 Offset: 0x7A8E0 VA: 0x18007B4E0
	public float intensity { get; set; }
	[NativeNameAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
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

	// Methods

	// RVA: 0x19A9190 Offset: 0x19A8590 VA: 0x1819A9190
	public void set_size(Vector3 value) { }

	// RVA: 0x19A8C20 Offset: 0x19A8020 VA: 0x1819A8C20
	public float get_nearClipPlane() { }

	// RVA: 0x19A9070 Offset: 0x19A8470 VA: 0x1819A9070
	public void set_nearClipPlane(float value) { }

	// RVA: 0x19A8B20 Offset: 0x19A7F20 VA: 0x1819A8B20
	public float get_farClipPlane() { }

	// RVA: 0x19A8F50 Offset: 0x19A8350 VA: 0x1819A8F50
	public void set_farClipPlane(float value) { }

	// RVA: 0x19A8BA0 Offset: 0x19A7FA0 VA: 0x1819A8BA0
	public float get_intensity() { }

	// RVA: 0x19A8FE0 Offset: 0x19A83E0 VA: 0x1819A8FE0
	public void set_intensity(float value) { }

	// RVA: 0x19A8B60 Offset: 0x19A7F60 VA: 0x1819A8B60
	public bool get_hdr() { }

	// RVA: 0x19A8D20 Offset: 0x19A8120 VA: 0x1819A8D20
	public float get_shadowDistance() { }

	// RVA: 0x19A8CE0 Offset: 0x19A80E0 VA: 0x1819A8CE0
	public int get_resolution() { }

	// RVA: 0x19A9100 Offset: 0x19A8500 VA: 0x1819A9100
	public void set_resolution(int value) { }

	// RVA: 0x19A8EC0 Offset: 0x19A82C0 VA: 0x1819A8EC0
	public void set_cullingMask(int value) { }

	// RVA: 0x19A8AA0 Offset: 0x19A7EA0 VA: 0x1819A8AA0
	public ReflectionProbeClearFlags get_clearFlags() { }

	// RVA: 0x19A8E80 Offset: 0x19A8280 VA: 0x1819A8E80
	public void set_clearFlags(ReflectionProbeClearFlags value) { }

	// RVA: 0x19A8A50 Offset: 0x19A7E50 VA: 0x1819A8A50
	public Color get_backgroundColor() { }

	// RVA: 0x19A8E30 Offset: 0x19A8230 VA: 0x1819A8E30
	public void set_backgroundColor(Color value) { }

	// RVA: 0x19A8BE0 Offset: 0x19A7FE0 VA: 0x1819A8BE0
	public ReflectionProbeMode get_mode() { }

	// RVA: 0x19A9030 Offset: 0x19A8430 VA: 0x1819A9030
	public void set_mode(ReflectionProbeMode value) { }

	// RVA: 0x19A8FA0 Offset: 0x19A83A0 VA: 0x1819A8FA0
	public void set_importance(int value) { }

	// RVA: 0x19A8CA0 Offset: 0x19A80A0 VA: 0x1819A8CA0
	public ReflectionProbeRefreshMode get_refreshMode() { }

	// RVA: 0x19A90C0 Offset: 0x19A84C0 VA: 0x1819A90C0
	public void set_refreshMode(ReflectionProbeRefreshMode value) { }

	// RVA: 0x19A8DA0 Offset: 0x19A81A0 VA: 0x1819A8DA0
	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	// RVA: 0x19A91E0 Offset: 0x19A85E0 VA: 0x1819A91E0
	public void set_timeSlicingMode(ReflectionProbeTimeSlicingMode value) { }

	// RVA: 0x19A8AE0 Offset: 0x19A7EE0 VA: 0x1819A8AE0
	public Texture get_customBakedTexture() { }

	// RVA: 0x19A8F00 Offset: 0x19A8300 VA: 0x1819A8F00
	public void set_customBakedTexture(Texture value) { }

	// RVA: 0x19A8C60 Offset: 0x19A8060 VA: 0x1819A8C60
	public RenderTexture get_realtimeTexture() { }

	// RVA: 0x19A8D60 Offset: 0x19A8160 VA: 0x1819A8D60
	public Texture get_texture() { }

	// RVA: 0x19A8940 Offset: 0x19A7D40 VA: 0x1819A8940
	public int RenderProbe() { }

	// RVA: 0x19A88C0 Offset: 0x19A7CC0 VA: 0x1819A88C0
	public int RenderProbe(RenderTexture targetTexture) { }

	// RVA: 0x19A8880 Offset: 0x19A7C80 VA: 0x1819A8880
	public bool IsFinishedRendering(int renderId) { }

	// RVA: 0x19A89B0 Offset: 0x19A7DB0 VA: 0x1819A89B0
	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	[FreeFunctionAttribute] // RVA: 0x7AA70 Offset: 0x79E70 VA: 0x18007AA70
	[NativeHeaderAttribute] // RVA: 0x7AA70 Offset: 0x79E70 VA: 0x18007AA70
	// RVA: 0x19A8750 Offset: 0x19A7B50 VA: 0x1819A8750
	public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19A87C0 Offset: 0x19A7BC0 VA: 0x1819A87C0
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19A8820 Offset: 0x19A7C20 VA: 0x1819A8820
	private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

	// RVA: 0x19A9140 Offset: 0x19A8540 VA: 0x1819A9140
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x19A8A00 Offset: 0x19A7E00 VA: 0x1819A8A00
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x19A8DE0 Offset: 0x19A81E0 VA: 0x1819A8DE0
	private void set_backgroundColor_Injected(ref Color value) { }

}

public enum ReflectionProbe.ReflectionProbeEvent // TypeDefIndex: 3369
{	// Fields
	public int value__; // 0x0
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeAdded = 0;
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeRemoved = 1;

}

