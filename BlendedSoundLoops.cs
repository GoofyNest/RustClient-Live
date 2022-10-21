public class BlendedSoundLoops : MonoBehaviour, IClientComponent // TypeDefIndex: 10701
{
	[RangeAttribute] 
	public float blend; 
	public float blendSmoothing; 
	public float loopFadeOutTime; 
	public float loopFadeInTime; 
	public float gainModSmoothing; 
	public float pitchModSmoothing; 
	public bool shouldPlay; 
	public float gain; 
	public List<BlendedSoundLoops.Loop> loops; 
	public float maxDistance; 
	private float smoothedBlend; 


	private void Update() { }

	public void .ctor() { }

}

public class BlendedSoundLoops.Loop // TypeDefIndex: 10702
{
	public SoundDefinition soundDef; 
	public AnimationCurve gainCurve; 
	public AnimationCurve pitchCurve; 
	[HideInInspector] 
	public Sound sound; 
	[HideInInspector] 
	public SoundModulation.Modulator gainMod; 
	[HideInInspector] 
	public SoundModulation.Modulator pitchMod; 


	public void .ctor() { }

}

