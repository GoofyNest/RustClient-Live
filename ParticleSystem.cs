public sealed class ParticleSystem : Component // TypeDefIndex: 4527
{

[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[RequireComponent] 
[UsedByNativeCodeAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
public sealed class ParticleSystem : Component 
	[ObsoleteAttribute] 
public bool playOnAwake { get; }
	[ObsoleteAttribute] 
public float duration { get; }
	[ObsoleteAttribute] 
public bool enableEmission { get; set; }
	[ObsoleteAttribute] 
public float emissionRate { get; set; }
	[ObsoleteAttribute] 
public float startSpeed { get; set; }
	[ObsoleteAttribute] 
public float startSize { get; set; }
	[ObsoleteAttribute] 
public float startLifetime { get; set; }
	[ObsoleteAttribute] 
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


	[ObsoleteAttribute] 
public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[ObsoleteAttribute] 
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

	[NativeNameAttribute] 
public bool get_isPlaying() { }

	[NativeNameAttribute] 
public bool get_isStopped() { }

	[NativeNameAttribute] 
public int get_particleCount() { }

	[NativeNameAttribute] 
public void set_useAutoRandomSeed(bool value) { }

	[FreeFunctionAttribute] 
public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

public void Simulate(float t, bool withChildren, bool restart) { }

public void Simulate(float t, bool withChildren) { }

public void Simulate(float t) { }

	[FreeFunctionAttribute] 
public void Play(bool withChildren) { }

public void Play() { }

	[FreeFunctionAttribute] 
public void Pause(bool withChildren) { }

public void Pause() { }

	[FreeFunctionAttribute] 
public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

public void Stop(bool withChildren) { }

public void Stop() { }

	[FreeFunctionAttribute] 
public void Clear(bool withChildren) { }

public void Clear() { }

	[RequiredByNativeCodeAttribute] 
public void Emit(int count) { }

	[NativeNameAttribute] 
private void Emit_Internal(int count) { }

	[NativeNameAttribute] 
public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeNameAttribute] 
private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

internal void* GetManagedJobData() { }

internal JobHandle GetManagedJobHandle() { }

internal void SetManagedJobHandle(JobHandle handle) { }

	[FreeFunctionAttribute] 
internal static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) { }

	[ThreadSafeAttribute] 
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
{
	internal ParticleSystem m_ParticleSystem; 

public float duration { get; }
public ParticleSystem.MinMaxCurve startLifetime { get; set; }
public float startLifetimeMultiplier { get; set; }
public ParticleSystem.MinMaxCurve startSpeed { get; set; }
public float startSpeedMultiplier { get; set; }
	[NativeNameAttribute] 
public ParticleSystem.MinMaxCurve startSize { get; set; }
	[NativeNameAttribute] 
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
{
	internal ParticleSystem m_ParticleSystem; 

	[ObsoleteAttribute] 
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
{
	internal ParticleSystem m_ParticleSystem; 

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
{
	private Vector3 m_Position; 
	private Vector3 m_Velocity; 
	private Vector3 m_AnimatedVelocity; 
	private Vector3 m_InitialVelocity; 
	private Vector3 m_AxisOfRotation; 
	private Vector3 m_Rotation; 
	private Vector3 m_AngularVelocity; 
	private Vector3 m_StartSize; 
	private Color32 m_StartColor; 
	private uint m_RandomSeed; 
	private uint m_ParentRandomSeed; 
	private float m_Lifetime; 
	private float m_StartLifetime; 
	private int m_MeshIndex; 
	private float m_EmitAccumulator0; 
	private float m_EmitAccumulator1; 
	private uint m_Flags; 

	[ObsoleteAttribute] 
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
{
	private float m_Time; 
	private ParticleSystem.MinMaxCurve m_Count; 
	private int m_RepeatCount; 
	private float m_RepeatInterval; 
	private float m_InvProbability; 

public float probability { set; }


public void set_probability(float value) { }

}

public struct ParticleSystem.MinMaxCurve // TypeDefIndex: 4533
{
	[SerializeField] 
	private ParticleSystemCurveMode m_Mode; 
	[SerializeField] 
	private float m_CurveMultiplier; 
	[SerializeField] 
	private AnimationCurve m_CurveMin; 
	[SerializeField] 
	private AnimationCurve m_CurveMax; 
	[SerializeField] 
	private float m_ConstantMin; 
	[SerializeField] 
	private float m_ConstantMax; 

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
{
	[SerializeField] 
	private ParticleSystemGradientMode m_Mode; 
	[SerializeField] 
	private Gradient m_GradientMin; 
	[SerializeField] 
	private Gradient m_GradientMax; 
	[SerializeField] 
	private Color m_ColorMin; 
	[SerializeField] 
	private Color m_ColorMax; 

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
{
	[NativeNameAttribute] 
	private ParticleSystem.Particle m_Particle; 
	[NativeNameAttribute] 
	private bool m_PositionSet; 
	[NativeNameAttribute] 
	private bool m_VelocitySet; 
	[NativeNameAttribute] 
	private bool m_AxisOfRotationSet; 
	[NativeNameAttribute] 
	private bool m_RotationSet; 
	[NativeNameAttribute] 
	private bool m_AngularVelocitySet; 
	[NativeNameAttribute] 
	private bool m_StartSizeSet; 
	[NativeNameAttribute] 
	private bool m_StartColorSet; 
	[NativeNameAttribute] 
	private bool m_RandomSeedSet; 
	[NativeNameAttribute] 
	private bool m_StartLifetimeSet; 
	[NativeNameAttribute] 
	private bool m_MeshIndexSet; 
	[NativeNameAttribute] 
	private bool m_ApplyShapeToPosition; 

public Vector3 position { set; }
public float startSize { set; }
public Color32 startColor { set; }


public void set_position(Vector3 value) { }

public void set_startSize(float value) { }

public void set_startColor(Color32 value) { }

}

public struct ParticleSystem.ColorOverLifetimeModule // TypeDefIndex: 4536
{
	internal ParticleSystem m_ParticleSystem; 

public ParticleSystem.MinMaxGradient color { set; }


internal void .ctor(ParticleSystem particleSystem) { }

public void set_color(ParticleSystem.MinMaxGradient value) { }

private static void set_color_Injected(ref ParticleSystem.ColorOverLifetimeModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

}

public struct ParticleSystem.CollisionModule // TypeDefIndex: 4537
{
	internal ParticleSystem m_ParticleSystem; 

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

