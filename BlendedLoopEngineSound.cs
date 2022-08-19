public class BlendedLoopEngineSound : MonoBehaviour, IClientComponent // TypeDefIndex: 8983
{	// Fields
	public BlendedEngineLoopDefinition loopDefinition; // 0x18
	public bool engineOn; // 0x20
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float RPMControl; // 0x24
	public float smoothedRPMControl; // 0x28
	private BlendedLoopEngineSound.EngineLoop[] engineLoops; // 0x30

	// Properties
	public float maxDistance { get; }

	// Methods

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public BlendedLoopEngineSound.EngineLoop[] GetEngineLoops() { }

	// RVA: 0x52C770 Offset: 0x52BB70 VA: 0x18052C770
	public float GetLoopGain(int idx) { }

	// RVA: 0x52C7C0 Offset: 0x52BBC0 VA: 0x18052C7C0
	public float GetLoopPitch(int idx) { }

	// RVA: 0x52CC70 Offset: 0x52C070 VA: 0x18052CC70
	public float get_maxDistance() { }

	// RVA: 0x52C810 Offset: 0x52BC10 VA: 0x18052C810
	public void Init(BlendedEngineLoopDefinition definition) { }

	// RVA: 0x52CA50 Offset: 0x52BE50 VA: 0x18052CA50
	private void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class BlendedLoopEngineSound.EngineLoop // TypeDefIndex: 8984
{	// Fields
	public BlendedEngineLoopDefinition.EngineLoopDefinition definition; // 0x10
	public BlendedLoopEngineSound parent; // 0x18
	public Sound sound; // 0x20
	public SoundModulation.Modulator gainMod; // 0x28
	public SoundModulation.Modulator pitchMod; // 0x30

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(BlendedEngineLoopDefinition.EngineLoopDefinition definition, BlendedLoopEngineSound parent) { }

	// RVA: 0x53C140 Offset: 0x53B540 VA: 0x18053C140
	public void Update(float RPM, float cameraDistance) { }

	// RVA: 0x53BF10 Offset: 0x53B310 VA: 0x18053BF10
	public void CreateSound() { }

	// RVA: 0x53C060 Offset: 0x53B460 VA: 0x18053C060
	public void RecycleSound() { }

}

