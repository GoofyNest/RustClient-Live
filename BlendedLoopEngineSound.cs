public class BlendedLoopEngineSound : MonoBehaviour, IClientComponent // TypeDefIndex: 8983
{	public BlendedEngineLoopDefinition loopDefinition; // 0x18
	public bool engineOn; // 0x20
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float RPMControl; // 0x24
	public float smoothedRPMControl; // 0x28
	private BlendedLoopEngineSound.EngineLoop[] engineLoops; // 0x30

	public float maxDistance { get; }


	public BlendedLoopEngineSound.EngineLoop[] GetEngineLoops() { }

	public float GetLoopGain(int idx) { }

	public float GetLoopPitch(int idx) { }

	public float get_maxDistance() { }

	public void Init(BlendedEngineLoopDefinition definition) { }

	private void Update() { }

	public void .ctor() { }

}

public class BlendedLoopEngineSound.EngineLoop // TypeDefIndex: 8984
{	public BlendedEngineLoopDefinition.EngineLoopDefinition definition; // 0x10
	public BlendedLoopEngineSound parent; // 0x18
	public Sound sound; // 0x20
	public SoundModulation.Modulator gainMod; // 0x28
	public SoundModulation.Modulator pitchMod; // 0x30


	public void .ctor(BlendedEngineLoopDefinition.EngineLoopDefinition definition, BlendedLoopEngineSound parent) { }

	public void Update(float RPM, float cameraDistance) { }

	public void CreateSound() { }

	public void RecycleSound() { }

}

