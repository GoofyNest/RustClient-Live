public class BlendedLoopEngineSound : MonoBehaviour, IClientComponent // TypeDefIndex: 10655
{
	public BlendedEngineLoopDefinition loopDefinition; 
	public bool engineOn; 
	[RangeAttribute] 
	public float RPMControl; 
	public float smoothedRPMControl; 
	private BlendedLoopEngineSound.EngineLoop[] engineLoops; 

	public float maxDistance { get; }


	public BlendedLoopEngineSound.EngineLoop[] GetEngineLoops() { }

	public float GetLoopGain(int idx) { }

	public float GetLoopPitch(int idx) { }

	public float get_maxDistance() { }

	public void Init(BlendedEngineLoopDefinition definition) { }

	private void Update() { }

	public void .ctor() { }

}

public class BlendedLoopEngineSound.EngineLoop // TypeDefIndex: 10656
{
	public BlendedEngineLoopDefinition.EngineLoopDefinition definition; 
	public BlendedLoopEngineSound parent; 
	public Sound sound; 
	public SoundModulation.Modulator gainMod; 
	public SoundModulation.Modulator pitchMod; 


	public void .ctor(BlendedEngineLoopDefinition.EngineLoopDefinition definition, BlendedLoopEngineSound parent) { }

	public void Update(float RPM, float cameraDistance) { }

	public void CreateSound() { }

	public void RecycleSound() { }

}

