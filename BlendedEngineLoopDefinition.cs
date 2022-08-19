public class BlendedEngineLoopDefinition : ScriptableObject // TypeDefIndex: 8981
{	// Fields
	public BlendedEngineLoopDefinition.EngineLoopDefinition[] engineLoops; // 0x18
	public float minRPM; // 0x20
	public float maxRPM; // 0x24
	public float RPMChangeRateUp; // 0x28
	public float RPMChangeRateDown; // 0x2C

	// Methods

	// RVA: 0x52C750 Offset: 0x52BB50 VA: 0x18052C750
	public void .ctor() { }

}

public class BlendedEngineLoopDefinition.EngineLoopDefinition // TypeDefIndex: 8982
{	// Fields
	public SoundDefinition soundDefinition; // 0x10
	public float RPM; // 0x18
	public float startRPM; // 0x1C
	public float startFullRPM; // 0x20
	public float stopFullRPM; // 0x24
	public float stopRPM; // 0x28

	// Methods

	// RVA: 0x53BF00 Offset: 0x53B300 VA: 0x18053BF00
	public float GetPitchForRPM(float targetRPM) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

