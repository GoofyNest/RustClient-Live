public class BlendedEngineLoopDefinition : ScriptableObject // TypeDefIndex: 8981
{	public BlendedEngineLoopDefinition.EngineLoopDefinition[] engineLoops; // 0x18
	public float minRPM; // 0x20
	public float maxRPM; // 0x24
	public float RPMChangeRateUp; // 0x28
	public float RPMChangeRateDown; // 0x2C


	public void .ctor() { }

}

public class BlendedEngineLoopDefinition.EngineLoopDefinition // TypeDefIndex: 8982
{	public SoundDefinition soundDefinition; // 0x10
	public float RPM; // 0x18
	public float startRPM; // 0x1C
	public float startFullRPM; // 0x20
	public float stopFullRPM; // 0x24
	public float stopRPM; // 0x28


	public float GetPitchForRPM(float targetRPM) { }

	public void .ctor() { }

}

