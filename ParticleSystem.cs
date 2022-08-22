public sealed class ParticleSystem : Component // TypeDefIndex: 4527
{
[NativeHeaderAttribute] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
[NativeHeaderAttribute] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
[NativeHeaderAttribute] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
[NativeHeaderAttribute] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
[NativeHeaderAttribute] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
[RequireComponent] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
[UsedByNativeCodeAttribute] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
[NativeHeaderAttribute] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
[NativeHeaderAttribute] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
[NativeHeaderAttribute] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
public sealed class ParticleSystem : Component // TypeDefIndex: 4527
	[ObsoleteAttribute] // RVA: 0xEE450 Offset: 0xED850 VA: 0x1800EE450
	public bool playOnAwake { get; }
	[ObsoleteAttribute] // RVA: 0xEE500 Offset: 0xED900 VA: 0x1800EE500
	public float duration { get; }
	[ObsoleteAttribute] // RVA: 0xEE640 Offset: 0xEDA40 VA: 0x1800EE640
	public bool enableEmission { get; set; }
	[ObsoleteAttribute] // RVA: 0xEE6E0 Offset: 0xEDAE0 VA: 0x1800EE6E0
	public float emissionRate { get; set; }
	[ObsoleteAttribute] // RVA: 0xEE8D0 Offset: 0xEDCD0 VA: 0x1800EE8D0
	public float startSpeed { get; set; }
	[ObsoleteAttribute] // RVA: 0xEE9C0 Offset: 0xEDDC0 VA: 0x1800EE9C0
	public float startSize { get; set; }
	[ObsoleteAttribute] // RVA: 0xEEBB0 Offset: 0xEDFB0 VA: 0x1800EEBB0
	public float startLifetime { get; set; }
	[ObsoleteAttribute] // RVA: 0xEED70 Offset: 0xEE170 VA: 0x1800EED70
	public float gravityModifier { get; set; }
	public bool isPlaying { get; }
	public bool isStopped { get; }
	public int particleCount { get; }
	public bool useAutoRandomSeed { set; }
	public ParticleSystem.MainModule main { get; }
	public ParticleSystem.EmissionModule emission { get; }
	public ParticleSystem.ShapeModule shape { get; }
	public ParticleSystem.ColorOverLifetimeModule colorOverLifetime { get; }
	public ParticleSystem.CollisionModule collision { get; }


	[ObsoleteAttribute] // RVA: 0xED060 Offset: 0xEC460 VA: 0x1800ED060
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[ObsoleteAttribute] // RVA: 0xED1C0 Offset: 0xEC5C0 VA: 0x1800ED1C0
	public void Emit(ParticleSystem.Particle particle) { }

	public bool get_playOnAwake() { }

	public float get_duration() { }

	public bool get_enableEmission() { }

	public void set_enableEmission(bool value) { }

	public float get_emissionRate() { }

	public void set_emissionRate(float value) { }

	public float get_startSpeed() { }

	public void set_startSpeed(float value) { }

	public float get_startSize() { }

	public void set_startSize(float value) { }

	public float get_startLifetime() { }

	public void set_startLifetime(float value) { }

	public float get_gravityModifier() { }

	public void set_gravityModifier(float value) { }

	[NativeNameAttribute] // RVA: 0xED280 Offset: 0xEC680 VA: 0x1800ED280
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xED3A0 Offset: 0xEC7A0 VA: 0x1800ED3A0
	public bool get_isStopped() { }

	[NativeNameAttribute] // RVA: 0xED3F0 Offset: 0xEC7F0 VA: 0x1800ED3F0
	public int get_particleCount() { }

	[NativeNameAttribute] // RVA: 0xED520 Offset: 0xEC920 VA: 0x1800ED520
	public void set_useAutoRandomSeed(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xED780 Offset: 0xECB80 VA: 0x1800ED780
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	public void Simulate(float t, bool withChildren, bool restart) { }

	public void Simulate(float t, bool withChildren) { }

	public void Simulate(float t) { }

	[FreeFunctionAttribute] // RVA: 0xED880 Offset: 0xECC80 VA: 0x1800ED880
	public void Play(bool withChildren) { }

	public void Play() { }

	[FreeFunctionAttribute] // RVA: 0xED930 Offset: 0xECD30 VA: 0x1800ED930
	public void Pause(bool withChildren) { }

	public void Pause() { }

	[FreeFunctionAttribute] // RVA: 0xED9D0 Offset: 0xECDD0 VA: 0x1800ED9D0
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	public void Stop(bool withChildren) { }

	public void Stop() { }

	[FreeFunctionAttribute] // RVA: 0xEDB60 Offset: 0xECF60 VA: 0x1800EDB60
	public void Clear(bool withChildren) { }

	public void Clear() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Emit(int count) { }

	[NativeNameAttribute] // RVA: 0xEDCD0 Offset: 0xED0D0 VA: 0x1800EDCD0
	private void Emit_Internal(int count) { }

	[NativeNameAttribute] // RVA: 0xEDD50 Offset: 0xED150 VA: 0x1800EDD50
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeNameAttribute] // RVA: 0xEDF90 Offset: 0xED390 VA: 0x1800EDF90
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	internal void* GetManagedJobData() { }

	internal JobHandle GetManagedJobHandle() { }

	internal void SetManagedJobHandle(JobHandle handle) { }

	[FreeFunctionAttribute] // RVA: 0xEA990 Offset: 0xE9D90 VA: 0x1800EA990
	internal static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	internal static void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData) { }

	public ParticleSystem.MainModule get_main() { }

	public ParticleSystem.EmissionModule get_emission() { }

	public ParticleSystem.ShapeModule get_shape() { }

	public ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime() { }

	public ParticleSystem.CollisionModule get_collision() { }

	private void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count) { }

	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	private static void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret) { }

}

public struct ParticleSystem.MainModule // TypeDefIndex: 4528
{	internal ParticleSystem m_ParticleSystem; // 0x0

	public float duration { get; }
	public ParticleSystem.MinMaxCurve startLifetime { get; set; }
	public float startLifetimeMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startSpeed { get; set; }
	public float startSpeedMultiplier { get; set; }
	[NativeNameAttribute] // RVA: 0xEEF00 Offset: 0xEE300 VA: 0x1800EEF00
	public ParticleSystem.MinMaxCurve startSize { get; set; }
	[NativeNameAttribute] // RVA: 0xEF080 Offset: 0xEE480 VA: 0x1800EF080
	public float startSizeMultiplier { get; set; }
	public ParticleSystem.MinMaxGradient startColor { get; set; }
	public float gravityModifierMultiplier { get; set; }
	public ParticleSystemSimulationSpace simulationSpace { set; }
	public bool playOnAwake { get; }
	public int maxParticles { get; set; }
	public ParticleSystemCullingMode cullingMode { set; }


	internal void .ctor(ParticleSystem particleSystem) { }

	public float get_duration() { }

	public ParticleSystem.MinMaxCurve get_startLifetime() { }

	public void set_startLifetime(ParticleSystem.MinMaxCurve value) { }

	public float get_startLifetimeMultiplier() { }

	public void set_startLifetimeMultiplier(float value) { }

	public ParticleSystem.MinMaxCurve get_startSpeed() { }

	public void set_startSpeed(ParticleSystem.MinMaxCurve value) { }

	public float get_startSpeedMultiplier() { }

	public void set_startSpeedMultiplier(float value) { }

	public ParticleSystem.MinMaxCurve get_startSize() { }

	public void set_startSize(ParticleSystem.MinMaxCurve value) { }

	public float get_startSizeMultiplier() { }

	public void set_startSizeMultiplier(float value) { }

	public ParticleSystem.MinMaxGradient get_startColor() { }

	public void set_startColor(ParticleSystem.MinMaxGradient value) { }

	public float get_gravityModifierMultiplier() { }

	public void set_gravityModifierMultiplier(float value) { }

	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	public bool get_playOnAwake() { }

	public int get_maxParticles() { }

	public void set_maxParticles(int value) { }

	public void set_cullingMode(ParticleSystemCullingMode value) { }

	private static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void get_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	private static void set_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	private static float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	private static void get_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	private static void set_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	private static float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	private static void get_startSize_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	private static void set_startSize_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	private static float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	private static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret) { }

	private static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

	private static float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	private static void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value) { }

	private static bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self) { }

	private static void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value) { }

	private static void set_cullingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemCullingMode value) { }

}

public struct ParticleSystem.EmissionModule // TypeDefIndex: 4529
{	internal ParticleSystem m_ParticleSystem; // 0x0

	[ObsoleteAttribute] // RVA: 0xEF220 Offset: 0xEE620 VA: 0x1800EF220
	public ParticleSystem.MinMaxCurve rate { set; }
	public bool enabled { get; set; }
	public ParticleSystem.MinMaxCurve rateOverTime { get; set; }
	public float rateOverTimeMultiplier { get; set; }


	public void set_rate(ParticleSystem.MinMaxCurve value) { }

	internal void .ctor(ParticleSystem particleSystem) { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	public ParticleSystem.MinMaxCurve get_rateOverTime() { }

	public void set_rateOverTime(ParticleSystem.MinMaxCurve value) { }

	public float get_rateOverTimeMultiplier() { }

	public void set_rateOverTimeMultiplier(float value) { }

	public void SetBurst(int index, ParticleSystem.Burst burst) { }

	public ParticleSystem.Burst GetBurst(int index) { }

	private static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	private static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value) { }

	private static void get_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	private static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	private static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	private static void set_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self, float value) { }

	private static void SetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, ref ParticleSystem.Burst burst) { }

	private static void GetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, out ParticleSystem.Burst ret) { }

}

public struct ParticleSystem.ShapeModule // TypeDefIndex: 4530
{	internal ParticleSystem m_ParticleSystem; // 0x0

	public ParticleSystemShapeType shapeType { set; }
	public float randomDirectionAmount { set; }
	public float radius { get; set; }
	public float angle { set; }
	public float length { set; }
	public MeshRenderer meshRenderer { set; }
	public float arc { set; }
	public Vector3 position { set; }
	public Vector3 rotation { get; }
	public Vector3 scale { set; }


	internal void .ctor(ParticleSystem particleSystem) { }

	public void set_shapeType(ParticleSystemShapeType value) { }

	public void set_randomDirectionAmount(float value) { }

	public float get_radius() { }

	public void set_radius(float value) { }

	public void set_angle(float value) { }

	public void set_length(float value) { }

	public void set_meshRenderer(MeshRenderer value) { }

	public void set_arc(float value) { }

	public void set_position(Vector3 value) { }

	public Vector3 get_rotation() { }

	public void set_scale(Vector3 value) { }

	private static void set_shapeType_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeType value) { }

	private static void set_randomDirectionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	private static float get_radius_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	private static void set_radius_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	private static void set_angle_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	private static void set_length_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	private static void set_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, MeshRenderer value) { }

	private static void set_arc_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	private static void set_position_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

	private static void get_rotation_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret) { }

	private static void set_scale_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

}

public struct ParticleSystem.Particle // TypeDefIndex: 4531
{	private Vector3 m_Position; // 0x0
	private Vector3 m_Velocity; // 0xC
	private Vector3 m_AnimatedVelocity; // 0x18
	private Vector3 m_InitialVelocity; // 0x24
	private Vector3 m_AxisOfRotation; // 0x30
	private Vector3 m_Rotation; // 0x3C
	private Vector3 m_AngularVelocity; // 0x48
	private Vector3 m_StartSize; // 0x54
	private Color32 m_StartColor; // 0x60
	private uint m_RandomSeed; // 0x64
	private uint m_ParentRandomSeed; // 0x68
	private float m_Lifetime; // 0x6C
	private float m_StartLifetime; // 0x70
	private int m_MeshIndex; // 0x74
	private float m_EmitAccumulator0; // 0x78
	private float m_EmitAccumulator1; // 0x7C
	private uint m_Flags; // 0x80

	[ObsoleteAttribute] // RVA: 0xEF6B0 Offset: 0xEEAB0 VA: 0x1800EF6B0
	public float lifetime { set; }
	public Vector3 position { set; }
	public Vector3 velocity { set; }
	public float remainingLifetime { set; }
	public float startLifetime { set; }
	public Color32 startColor { set; }
	public uint randomSeed { set; }
	public float startSize { set; }
	public Vector3 rotation3D { set; }
	public Vector3 angularVelocity3D { set; }


	public void set_lifetime(float value) { }

	public void set_position(Vector3 value) { }

	public void set_velocity(Vector3 value) { }

	public void set_remainingLifetime(float value) { }

	public void set_startLifetime(float value) { }

	public void set_startColor(Color32 value) { }

	public void set_randomSeed(uint value) { }

	public void set_startSize(float value) { }

	public void set_rotation3D(Vector3 value) { }

	public void set_angularVelocity3D(Vector3 value) { }

}

public struct ParticleSystem.Burst // TypeDefIndex: 4532
{	private float m_Time; // 0x0
	private ParticleSystem.MinMaxCurve m_Count; // 0x8
	private int m_RepeatCount; // 0x28
	private float m_RepeatInterval; // 0x2C
	private float m_InvProbability; // 0x30

	public float probability { set; }


	public void set_probability(float value) { }

}

public struct ParticleSystem.MinMaxCurve // TypeDefIndex: 4533
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemCurveMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_CurveMultiplier; // 0x4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AnimationCurve m_CurveMin; // 0x8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AnimationCurve m_CurveMax; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_ConstantMin; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_ConstantMax; // 0x1C

	public ParticleSystemCurveMode mode { set; }
	public float constantMax { get; set; }
	public float constantMin { set; }
	public float constant { get; set; }


	public void .ctor(float constant) { }

	public void set_mode(ParticleSystemCurveMode value) { }

	public float get_constantMax() { }

	public void set_constantMax(float value) { }

	public void set_constantMin(float value) { }

	public float get_constant() { }

	public void set_constant(float value) { }

	public static ParticleSystem.MinMaxCurve op_Implicit(float constant) { }

}

public struct ParticleSystem.MinMaxGradient // TypeDefIndex: 4534
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemGradientMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Gradient m_GradientMin; // 0x8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Gradient m_GradientMax; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_ColorMin; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_ColorMax; // 0x28

	public ParticleSystemGradientMode mode { set; }
	public Color color { get; set; }
	public Gradient gradient { set; }


	public void .ctor(Color color) { }

	public void .ctor(Gradient gradient) { }

	public void set_mode(ParticleSystemGradientMode value) { }

	public Color get_color() { }

	public void set_color(Color value) { }

	public void set_gradient(Gradient value) { }

	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }

	public static ParticleSystem.MinMaxGradient op_Implicit(Gradient gradient) { }

}

public struct ParticleSystem.EmitParams // TypeDefIndex: 4535
{	[NativeNameAttribute] // RVA: 0xF0210 Offset: 0xEF610 VA: 0x1800F0210
	private ParticleSystem.Particle m_Particle; // 0x0
	[NativeNameAttribute] // RVA: 0xF0370 Offset: 0xEF770 VA: 0x1800F0370
	private bool m_PositionSet; // 0x84
	[NativeNameAttribute] // RVA: 0xF04E0 Offset: 0xEF8E0 VA: 0x1800F04E0
	private bool m_VelocitySet; // 0x85
	[NativeNameAttribute] // RVA: 0xF0670 Offset: 0xEFA70 VA: 0x1800F0670
	private bool m_AxisOfRotationSet; // 0x86
	[NativeNameAttribute] // RVA: 0xF0710 Offset: 0xEFB10 VA: 0x1800F0710
	private bool m_RotationSet; // 0x87
	[NativeNameAttribute] // RVA: 0xF0890 Offset: 0xEFC90 VA: 0x1800F0890
	private bool m_AngularVelocitySet; // 0x88
	[NativeNameAttribute] // RVA: 0xF0A60 Offset: 0xEFE60 VA: 0x1800F0A60
	private bool m_StartSizeSet; // 0x89
	[NativeNameAttribute] // RVA: 0xF0CE0 Offset: 0xF00E0 VA: 0x1800F0CE0
	private bool m_StartColorSet; // 0x8A
	[NativeNameAttribute] // RVA: 0xF0D50 Offset: 0xF0150 VA: 0x1800F0D50
	private bool m_RandomSeedSet; // 0x8B
	[NativeNameAttribute] // RVA: 0x6F310 Offset: 0x6E710 VA: 0x18006F310
	private bool m_StartLifetimeSet; // 0x8C
	[NativeNameAttribute] // RVA: 0x6F520 Offset: 0x6E920 VA: 0x18006F520
	private bool m_MeshIndexSet; // 0x8D
	[NativeNameAttribute] // RVA: 0x6F710 Offset: 0x6EB10 VA: 0x18006F710
	private bool m_ApplyShapeToPosition; // 0x8E

	public Vector3 position { set; }
	public float startSize { set; }
	public Color32 startColor { set; }


	public void set_position(Vector3 value) { }

	public void set_startSize(float value) { }

	public void set_startColor(Color32 value) { }

}

public struct ParticleSystem.ColorOverLifetimeModule // TypeDefIndex: 4536
{	internal ParticleSystem m_ParticleSystem; // 0x0

	public ParticleSystem.MinMaxGradient color { set; }


	internal void .ctor(ParticleSystem particleSystem) { }

	public void set_color(ParticleSystem.MinMaxGradient value) { }

	private static void set_color_Injected(ref ParticleSystem.ColorOverLifetimeModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

}

public struct ParticleSystem.CollisionModule // TypeDefIndex: 4537
{	internal ParticleSystem m_ParticleSystem; // 0x0

	public bool enabled { get; set; }
	public ParticleSystemCollisionQuality quality { set; }


	internal void .ctor(ParticleSystem particleSystem) { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	public void set_quality(ParticleSystemCollisionQuality value) { }

	private static bool get_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self) { }

	private static void set_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self, bool value) { }

	private static void set_quality_Injected(ref ParticleSystem.CollisionModule _unity_self, ParticleSystemCollisionQuality value) { }

}

