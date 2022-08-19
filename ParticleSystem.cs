public sealed class ParticleSystem : Component // TypeDefIndex: 4527
{
// Namespace: UnityEngine
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
	// Properties
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

	// Methods

	[ObsoleteAttribute] // RVA: 0xED060 Offset: 0xEC460 VA: 0x1800ED060
	// RVA: 0x22C1940 Offset: 0x22C0D40 VA: 0x1822C1940
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[ObsoleteAttribute] // RVA: 0xED1C0 Offset: 0xEC5C0 VA: 0x1800ED1C0
	// RVA: 0x22C18F0 Offset: 0x22C0CF0 VA: 0x1822C18F0
	public void Emit(ParticleSystem.Particle particle) { }

	// RVA: 0x22C23D0 Offset: 0x22C17D0 VA: 0x1822C23D0
	public bool get_playOnAwake() { }

	// RVA: 0x22C21D0 Offset: 0x22C15D0 VA: 0x1822C21D0
	public float get_duration() { }

	// RVA: 0x22C2270 Offset: 0x22C1670 VA: 0x1822C2270
	public bool get_enableEmission() { }

	// RVA: 0x22C25E0 Offset: 0x22C19E0 VA: 0x1822C25E0
	public void set_enableEmission(bool value) { }

	// RVA: 0x22C2220 Offset: 0x22C1620 VA: 0x1822C2220
	public float get_emissionRate() { }

	// RVA: 0x22C2510 Offset: 0x22C1910 VA: 0x1822C2510
	public void set_emissionRate(float value) { }

	// RVA: 0x22C24C0 Offset: 0x22C18C0 VA: 0x1822C24C0
	public float get_startSpeed() { }

	// RVA: 0x22C2760 Offset: 0x22C1B60 VA: 0x1822C2760
	public void set_startSpeed(float value) { }

	// RVA: 0x22C2470 Offset: 0x22C1870 VA: 0x1822C2470
	public float get_startSize() { }

	// RVA: 0x22C2700 Offset: 0x22C1B00 VA: 0x1822C2700
	public void set_startSize(float value) { }

	// RVA: 0x22C2420 Offset: 0x22C1820 VA: 0x1822C2420
	public float get_startLifetime() { }

	// RVA: 0x22C26A0 Offset: 0x22C1AA0 VA: 0x1822C26A0
	public void set_startLifetime(float value) { }

	// RVA: 0x22C22C0 Offset: 0x22C16C0 VA: 0x1822C22C0
	public float get_gravityModifier() { }

	// RVA: 0x22C2640 Offset: 0x22C1A40 VA: 0x1822C2640
	public void set_gravityModifier(float value) { }

	[NativeNameAttribute] // RVA: 0xED280 Offset: 0xEC680 VA: 0x1800ED280
	// RVA: 0x22C2310 Offset: 0x22C1710 VA: 0x1822C2310
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xED3A0 Offset: 0xEC7A0 VA: 0x1800ED3A0
	// RVA: 0x22C2350 Offset: 0x22C1750 VA: 0x1822C2350
	public bool get_isStopped() { }

	[NativeNameAttribute] // RVA: 0xED3F0 Offset: 0xEC7F0 VA: 0x1800ED3F0
	// RVA: 0x22C2390 Offset: 0x22C1790 VA: 0x1822C2390
	public int get_particleCount() { }

	[NativeNameAttribute] // RVA: 0xED520 Offset: 0xEC920 VA: 0x1800ED520
	// RVA: 0x22C27C0 Offset: 0x22C1BC0 VA: 0x1822C27C0
	public void set_useAutoRandomSeed(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xED780 Offset: 0xECB80 VA: 0x1800ED780
	// RVA: 0x22C2070 Offset: 0x22C1470 VA: 0x1822C2070
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x22C2000 Offset: 0x22C1400 VA: 0x1822C2000
	public void Simulate(float t, bool withChildren, bool restart) { }

	// RVA: 0x22C1F50 Offset: 0x22C1350 VA: 0x1822C1F50
	public void Simulate(float t, bool withChildren) { }

	// RVA: 0x22C1FB0 Offset: 0x22C13B0 VA: 0x1822C1FB0
	public void Simulate(float t) { }

	[FreeFunctionAttribute] // RVA: 0xED880 Offset: 0xECC80 VA: 0x1800ED880
	// RVA: 0x22C1DA0 Offset: 0x22C11A0 VA: 0x1822C1DA0
	public void Play(bool withChildren) { }

	// RVA: 0x22C1D60 Offset: 0x22C1160 VA: 0x1822C1D60
	public void Play() { }

	[FreeFunctionAttribute] // RVA: 0xED930 Offset: 0xECD30 VA: 0x1800ED930
	// RVA: 0x22C1CD0 Offset: 0x22C10D0 VA: 0x1822C1CD0
	public void Pause(bool withChildren) { }

	// RVA: 0x22C1D20 Offset: 0x22C1120 VA: 0x1822C1D20
	public void Pause() { }

	[FreeFunctionAttribute] // RVA: 0xED9D0 Offset: 0xECDD0 VA: 0x1800ED9D0
	// RVA: 0x22C2120 Offset: 0x22C1520 VA: 0x1822C2120
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x22C2180 Offset: 0x22C1580 VA: 0x1822C2180
	public void Stop(bool withChildren) { }

	// RVA: 0x22C20E0 Offset: 0x22C14E0 VA: 0x1822C20E0
	public void Stop() { }

	[FreeFunctionAttribute] // RVA: 0xEDB60 Offset: 0xECF60 VA: 0x1800EDB60
	// RVA: 0x22C1720 Offset: 0x22C0B20 VA: 0x1822C1720
	public void Clear(bool withChildren) { }

	// RVA: 0x22C1770 Offset: 0x22C0B70 VA: 0x1822C1770
	public void Clear() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22C18B0 Offset: 0x22C0CB0 VA: 0x1822C18B0
	public void Emit(int count) { }

	[NativeNameAttribute] // RVA: 0xEDCD0 Offset: 0xED0D0 VA: 0x1800EDCD0
	// RVA: 0x22C18B0 Offset: 0x22C0CB0 VA: 0x1822C18B0
	private void Emit_Internal(int count) { }

	[NativeNameAttribute] // RVA: 0xEDD50 Offset: 0xED150 VA: 0x1800EDD50
	// RVA: 0x22C1B90 Offset: 0x22C0F90 VA: 0x1822C1B90
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeNameAttribute] // RVA: 0xEDF90 Offset: 0xED390 VA: 0x1800EDF90
	// RVA: 0x22C1800 Offset: 0x22C0C00 VA: 0x1822C1800
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	// RVA: 0x22C1BF0 Offset: 0x22C0FF0 VA: 0x1822C1BF0
	internal void* GetManagedJobData() { }

	// RVA: 0x22C1C80 Offset: 0x22C1080 VA: 0x1822C1C80
	internal JobHandle GetManagedJobHandle() { }

	// RVA: 0x22C1F00 Offset: 0x22C1300 VA: 0x1822C1F00
	internal void SetManagedJobHandle(JobHandle handle) { }

	[FreeFunctionAttribute] // RVA: 0xEA990 Offset: 0xE9D90 VA: 0x1800EA990
	// RVA: 0x22C1E50 Offset: 0x22C1250 VA: 0x1822C1E50
	internal static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22C17B0 Offset: 0x22C0BB0 VA: 0x1822C17B0
	internal static void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData) { }

	// RVA: 0x149ACC0 Offset: 0x149A0C0 VA: 0x18149ACC0
	public ParticleSystem.MainModule get_main() { }

	// RVA: 0x149ACC0 Offset: 0x149A0C0 VA: 0x18149ACC0
	public ParticleSystem.EmissionModule get_emission() { }

	// RVA: 0x149ACC0 Offset: 0x149A0C0 VA: 0x18149ACC0
	public ParticleSystem.ShapeModule get_shape() { }

	// RVA: 0x149ACC0 Offset: 0x149A0C0 VA: 0x18149ACC0
	public ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime() { }

	// RVA: 0x149ACC0 Offset: 0x149A0C0 VA: 0x18149ACC0
	public ParticleSystem.CollisionModule get_collision() { }

	// RVA: 0x22C1850 Offset: 0x22C0C50 VA: 0x1822C1850
	private void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count) { }

	// RVA: 0x22C1C30 Offset: 0x22C1030 VA: 0x1822C1C30
	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	// RVA: 0x22C1EB0 Offset: 0x22C12B0 VA: 0x1822C1EB0
	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	// RVA: 0x22C1DF0 Offset: 0x22C11F0 VA: 0x1822C1DF0
	private static void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret) { }

}

public struct ParticleSystem.MainModule // TypeDefIndex: 4528
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
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

	// Methods

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23B610 Offset: 0x23AA10 VA: 0x18023B610
	public float get_duration() { }

	// RVA: 0x23B7B0 Offset: 0x23ABB0 VA: 0x18023B7B0
	public ParticleSystem.MinMaxCurve get_startLifetime() { }

	// RVA: 0x23BB10 Offset: 0x23AF10 VA: 0x18023BB10
	public void set_startLifetime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23B770 Offset: 0x23AB70 VA: 0x18023B770
	public float get_startLifetimeMultiplier() { }

	// RVA: 0x23BAC0 Offset: 0x23AEC0 VA: 0x18023BAC0
	public void set_startLifetimeMultiplier(float value) { }

	// RVA: 0x23B8D0 Offset: 0x23ACD0 VA: 0x18023B8D0
	public ParticleSystem.MinMaxCurve get_startSpeed() { }

	// RVA: 0x23BC50 Offset: 0x23B050 VA: 0x18023BC50
	public void set_startSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23B890 Offset: 0x23AC90 VA: 0x18023B890
	public float get_startSpeedMultiplier() { }

	// RVA: 0x23BC00 Offset: 0x23B000 VA: 0x18023BC00
	public void set_startSpeedMultiplier(float value) { }

	// RVA: 0x23B840 Offset: 0x23AC40 VA: 0x18023B840
	public ParticleSystem.MinMaxCurve get_startSize() { }

	// RVA: 0x23BBB0 Offset: 0x23AFB0 VA: 0x18023BBB0
	public void set_startSize(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23B800 Offset: 0x23AC00 VA: 0x18023B800
	public float get_startSizeMultiplier() { }

	// RVA: 0x23BB60 Offset: 0x23AF60 VA: 0x18023BB60
	public void set_startSizeMultiplier(float value) { }

	// RVA: 0x23B710 Offset: 0x23AB10 VA: 0x18023B710
	public ParticleSystem.MinMaxGradient get_startColor() { }

	// RVA: 0x23BA60 Offset: 0x23AE60 VA: 0x18023BA60
	public void set_startColor(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x23B650 Offset: 0x23AA50 VA: 0x18023B650
	public float get_gravityModifierMultiplier() { }

	// RVA: 0x23B970 Offset: 0x23AD70 VA: 0x18023B970
	public void set_gravityModifierMultiplier(float value) { }

	// RVA: 0x23BA10 Offset: 0x23AE10 VA: 0x18023BA10
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x23B6D0 Offset: 0x23AAD0 VA: 0x18023B6D0
	public bool get_playOnAwake() { }

	// RVA: 0x23B690 Offset: 0x23AA90 VA: 0x18023B690
	public int get_maxParticles() { }

	// RVA: 0x23B9C0 Offset: 0x23ADC0 VA: 0x18023B9C0
	public void set_maxParticles(int value) { }

	// RVA: 0x23B920 Offset: 0x23AD20 VA: 0x18023B920
	public void set_cullingMode(ParticleSystemCullingMode value) { }

	// RVA: 0x22C0670 Offset: 0x22BFA70 VA: 0x1822C0670
	private static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C0860 Offset: 0x22BFC60 VA: 0x1822C0860
	private static void get_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C0CC0 Offset: 0x22C00C0 VA: 0x1822C0CC0
	private static void set_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C0820 Offset: 0x22BFC20 VA: 0x1822C0820
	private static float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C0C70 Offset: 0x22C0070 VA: 0x1822C0C70
	private static void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C0A20 Offset: 0x22BFE20 VA: 0x1822C0A20
	private static void get_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C0EA0 Offset: 0x22C02A0 VA: 0x1822C0EA0
	private static void set_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C09E0 Offset: 0x22BFDE0 VA: 0x1822C09E0
	private static float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C0E50 Offset: 0x22C0250 VA: 0x1822C0E50
	private static void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C0940 Offset: 0x22BFD40 VA: 0x1822C0940
	private static void get_startSize_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C0DB0 Offset: 0x22C01B0 VA: 0x1822C0DB0
	private static void set_startSize_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C0900 Offset: 0x22BFD00 VA: 0x1822C0900
	private static float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C0D60 Offset: 0x22C0160 VA: 0x1822C0D60
	private static void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C0770 Offset: 0x22BFB70 VA: 0x1822C0770
	private static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret) { }

	// RVA: 0x22C0BD0 Offset: 0x22BFFD0 VA: 0x1822C0BD0
	private static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x22C06B0 Offset: 0x22BFAB0 VA: 0x1822C06B0
	private static float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C0B00 Offset: 0x22BFF00 VA: 0x1822C0B00
	private static void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C0B90 Offset: 0x22BFF90 VA: 0x1822C0B90
	private static void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value) { }

	// RVA: 0x22C0730 Offset: 0x22BFB30 VA: 0x1822C0730
	private static bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C06F0 Offset: 0x22BFAF0 VA: 0x1822C06F0
	private static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C0B50 Offset: 0x22BFF50 VA: 0x1822C0B50
	private static void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value) { }

	// RVA: 0x22C0AC0 Offset: 0x22BFEC0 VA: 0x1822C0AC0
	private static void set_cullingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemCullingMode value) { }

}

public struct ParticleSystem.EmissionModule // TypeDefIndex: 4529
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	[ObsoleteAttribute] // RVA: 0xEF220 Offset: 0xEE620 VA: 0x1800EF220
	public ParticleSystem.MinMaxCurve rate { set; }
	public bool enabled { get; set; }
	public ParticleSystem.MinMaxCurve rateOverTime { get; set; }
	public float rateOverTimeMultiplier { get; set; }

	// Methods

	// RVA: 0x23B300 Offset: 0x23A700 VA: 0x18023B300
	public void set_rate(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23B190 Offset: 0x23A590 VA: 0x18023B190
	public bool get_enabled() { }

	// RVA: 0x23B260 Offset: 0x23A660 VA: 0x18023B260
	public void set_enabled(bool value) { }

	// RVA: 0x23B210 Offset: 0x23A610 VA: 0x18023B210
	public ParticleSystem.MinMaxCurve get_rateOverTime() { }

	// RVA: 0x23B300 Offset: 0x23A700 VA: 0x18023B300
	public void set_rateOverTime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23B1D0 Offset: 0x23A5D0 VA: 0x18023B1D0
	public float get_rateOverTimeMultiplier() { }

	// RVA: 0x23B2B0 Offset: 0x23A6B0 VA: 0x18023B2B0
	public void set_rateOverTimeMultiplier(float value) { }

	// RVA: 0x23B120 Offset: 0x23A520 VA: 0x18023B120
	public void SetBurst(int index, ParticleSystem.Burst burst) { }

	// RVA: 0x23B0B0 Offset: 0x23A4B0 VA: 0x18023B0B0
	public ParticleSystem.Burst GetBurst(int index) { }

	// RVA: 0x22C0340 Offset: 0x22BF740 VA: 0x1822C0340
	private static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x22C0460 Offset: 0x22BF860 VA: 0x1822C0460
	private static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value) { }

	// RVA: 0x22C03C0 Offset: 0x22BF7C0 VA: 0x1822C03C0
	private static void get_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C0500 Offset: 0x22BF900 VA: 0x1822C0500
	private static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C0380 Offset: 0x22BF780 VA: 0x1822C0380
	private static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x22C04B0 Offset: 0x22BF8B0 VA: 0x1822C04B0
	private static void set_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self, float value) { }

	// RVA: 0x22C02A0 Offset: 0x22BF6A0 VA: 0x1822C02A0
	private static void SetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, ref ParticleSystem.Burst burst) { }

	// RVA: 0x22C01E0 Offset: 0x22BF5E0 VA: 0x1822C01E0
	private static void GetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, out ParticleSystem.Burst ret) { }

}

public struct ParticleSystem.ShapeModule // TypeDefIndex: 4530
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
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

	// Methods

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23C350 Offset: 0x23B750 VA: 0x18023C350
	public void set_shapeType(ParticleSystemShapeType value) { }

	// RVA: 0x23C2B0 Offset: 0x23B6B0 VA: 0x18023C2B0
	public void set_randomDirectionAmount(float value) { }

	// RVA: 0x23C040 Offset: 0x23B440 VA: 0x18023C040
	public float get_radius() { }

	// RVA: 0x23C260 Offset: 0x23B660 VA: 0x18023C260
	public void set_radius(float value) { }

	// RVA: 0x23C0D0 Offset: 0x23B4D0 VA: 0x18023C0D0
	public void set_angle(float value) { }

	// RVA: 0x23C170 Offset: 0x23B570 VA: 0x18023C170
	public void set_length(float value) { }

	// RVA: 0x23C1C0 Offset: 0x23B5C0 VA: 0x18023C1C0
	public void set_meshRenderer(MeshRenderer value) { }

	// RVA: 0x23C120 Offset: 0x23B520 VA: 0x18023C120
	public void set_arc(float value) { }

	// RVA: 0x23C210 Offset: 0x23B610 VA: 0x18023C210
	public void set_position(Vector3 value) { }

	// RVA: 0x23C080 Offset: 0x23B480 VA: 0x18023C080
	public Vector3 get_rotation() { }

	// RVA: 0x23C300 Offset: 0x23B700 VA: 0x18023C300
	public void set_scale(Vector3 value) { }

	// RVA: 0x22C2C10 Offset: 0x22C2010 VA: 0x1822C2C10
	private static void set_shapeType_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeType value) { }

	// RVA: 0x22C2B20 Offset: 0x22C1F20 VA: 0x1822C2B20
	private static void set_randomDirectionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C2810 Offset: 0x22C1C10 VA: 0x1822C2810
	private static float get_radius_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x22C2AD0 Offset: 0x22C1ED0 VA: 0x1822C2AD0
	private static void set_radius_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C28F0 Offset: 0x22C1CF0 VA: 0x1822C28F0
	private static void set_angle_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C2990 Offset: 0x22C1D90 VA: 0x1822C2990
	private static void set_length_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C29E0 Offset: 0x22C1DE0 VA: 0x1822C29E0
	private static void set_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, MeshRenderer value) { }

	// RVA: 0x22C2940 Offset: 0x22C1D40 VA: 0x1822C2940
	private static void set_arc_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C2A30 Offset: 0x22C1E30 VA: 0x1822C2A30
	private static void set_position_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

	// RVA: 0x22C2850 Offset: 0x22C1C50 VA: 0x1822C2850
	private static void get_rotation_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret) { }

	// RVA: 0x22C2B70 Offset: 0x22C1F70 VA: 0x1822C2B70
	private static void set_scale_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

}

public struct ParticleSystem.Particle // TypeDefIndex: 4531
{	// Fields
	private Vector3 m_Position; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0x23BF10 Offset: 0x23B310 VA: 0x18023BF10
	public void set_lifetime(float value) { }

	// RVA: 0x204DC0 Offset: 0x2041C0 VA: 0x180204DC0
	public void set_position(Vector3 value) { }

	// RVA: 0x212B50 Offset: 0x211F50 VA: 0x180212B50
	public void set_velocity(Vector3 value) { }

	// RVA: 0x23BF10 Offset: 0x23B310 VA: 0x18023BF10
	public void set_remainingLifetime(float value) { }

	// RVA: 0x23BFE0 Offset: 0x23B3E0 VA: 0x18023BFE0
	public void set_startLifetime(float value) { }

	// RVA: 0x23BFD0 Offset: 0x23B3D0 VA: 0x18023BFD0
	public void set_startColor(Color32 value) { }

	// RVA: 0x23BF20 Offset: 0x23B320 VA: 0x18023BF20
	public void set_randomSeed(uint value) { }

	// RVA: 0x23BFF0 Offset: 0x23B3F0 VA: 0x18023BFF0
	public void set_startSize(float value) { }

	// RVA: 0x23BF30 Offset: 0x23B330 VA: 0x18023BF30
	public void set_rotation3D(Vector3 value) { }

	// RVA: 0x23BE70 Offset: 0x23B270 VA: 0x18023BE70
	public void set_angularVelocity3D(Vector3 value) { }

}

public struct ParticleSystem.Burst // TypeDefIndex: 4532
{	// Fields
	private float m_Time; // 0x0
	private ParticleSystem.MinMaxCurve m_Count; // 0x8
	private int m_RepeatCount; // 0x28
	private float m_RepeatInterval; // 0x2C
	private float m_InvProbability; // 0x30

	// Properties
	public float probability { set; }

	// Methods

	// RVA: 0x23AE60 Offset: 0x23A260 VA: 0x18023AE60
	public void set_probability(float value) { }

}

public struct ParticleSystem.MinMaxCurve // TypeDefIndex: 4533
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	public ParticleSystemCurveMode mode { set; }
	public float constantMax { get; set; }
	public float constantMin { set; }
	public float constant { get; set; }

	// Methods

	// RVA: 0x23BCC0 Offset: 0x23B0C0 VA: 0x18023BCC0
	public void .ctor(float constant) { }

	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_mode(ParticleSystemCurveMode value) { }

	// RVA: 0x239460 Offset: 0x238860 VA: 0x180239460
	public float get_constantMax() { }

	// RVA: 0x2396C0 Offset: 0x238AC0 VA: 0x1802396C0
	public void set_constantMax(float value) { }

	// RVA: 0x239430 Offset: 0x238830 VA: 0x180239430
	public void set_constantMin(float value) { }

	// RVA: 0x239460 Offset: 0x238860 VA: 0x180239460
	public float get_constant() { }

	// RVA: 0x2396C0 Offset: 0x238AC0 VA: 0x1802396C0
	public void set_constant(float value) { }

	// RVA: 0x22C0F40 Offset: 0x22C0340 VA: 0x1822C0F40
	public static ParticleSystem.MinMaxCurve op_Implicit(float constant) { }

}

public struct ParticleSystem.MinMaxGradient // TypeDefIndex: 4534
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemGradientMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Gradient m_GradientMin; // 0x8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Gradient m_GradientMax; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_ColorMin; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_ColorMax; // 0x28

	// Properties
	public ParticleSystemGradientMode mode { set; }
	public Color color { get; set; }
	public Gradient gradient { set; }

	// Methods

	// RVA: 0x23BD10 Offset: 0x23B110 VA: 0x18023BD10
	public void .ctor(Color color) { }

	// RVA: 0x23BD70 Offset: 0x23B170 VA: 0x18023BD70
	public void .ctor(Gradient gradient) { }

	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_mode(ParticleSystemGradientMode value) { }

	// RVA: 0x23BD80 Offset: 0x23B180 VA: 0x18023BD80
	public Color get_color() { }

	// RVA: 0x23BD90 Offset: 0x23B190 VA: 0x18023BD90
	public void set_color(Color value) { }

	// RVA: 0xF1360 Offset: 0xF0760 VA: 0x1800F1360
	public void set_gradient(Gradient value) { }

	// RVA: 0x22C10B0 Offset: 0x22C04B0 VA: 0x1822C10B0
	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }

	// RVA: 0x22C1170 Offset: 0x22C0570 VA: 0x1822C1170
	public static ParticleSystem.MinMaxGradient op_Implicit(Gradient gradient) { }

}

public struct ParticleSystem.EmitParams // TypeDefIndex: 4535
{	// Fields
	[NativeNameAttribute] // RVA: 0xF0210 Offset: 0xEF610 VA: 0x1800F0210
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

	// Properties
	public Vector3 position { set; }
	public float startSize { set; }
	public Color32 startColor { set; }

	// Methods

	// RVA: 0x23B370 Offset: 0x23A770 VA: 0x18023B370
	public void set_position(Vector3 value) { }

	// RVA: 0x23B3A0 Offset: 0x23A7A0 VA: 0x18023B3A0
	public void set_startSize(float value) { }

	// RVA: 0x23B390 Offset: 0x23A790 VA: 0x18023B390
	public void set_startColor(Color32 value) { }

}

public struct ParticleSystem.ColorOverLifetimeModule // TypeDefIndex: 4536
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public ParticleSystem.MinMaxGradient color { set; }

	// Methods

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23B030 Offset: 0x23A430 VA: 0x18023B030
	public void set_color(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x22C0140 Offset: 0x22BF540 VA: 0x1822C0140
	private static void set_color_Injected(ref ParticleSystem.ColorOverLifetimeModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

}

public struct ParticleSystem.CollisionModule // TypeDefIndex: 4537
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; set; }
	public ParticleSystemCollisionQuality quality { set; }

	// Methods

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23AF30 Offset: 0x23A330 VA: 0x18023AF30
	public bool get_enabled() { }

	// RVA: 0x23AF70 Offset: 0x23A370 VA: 0x18023AF70
	public void set_enabled(bool value) { }

	// RVA: 0x23AFC0 Offset: 0x23A3C0 VA: 0x18023AFC0
	public void set_quality(ParticleSystemCollisionQuality value) { }

	// RVA: 0x22C0070 Offset: 0x22BF470 VA: 0x1822C0070
	private static bool get_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self) { }

	// RVA: 0x22C00B0 Offset: 0x22BF4B0 VA: 0x1822C00B0
	private static void set_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self, bool value) { }

	// RVA: 0x22C0100 Offset: 0x22BF500 VA: 0x1822C0100
	private static void set_quality_Injected(ref ParticleSystem.CollisionModule _unity_self, ParticleSystemCollisionQuality value) { }

}

