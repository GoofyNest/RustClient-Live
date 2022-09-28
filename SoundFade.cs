public class SoundFade : MonoBehaviour, IClientComponent // TypeDefIndex: 10700
{
	public SoundFadeHQAudioFilter hqFadeFilter; 
	public float currentGain; 
	public float startingGain; 
	public float finalGain; 
	public int sampleRate; 
	public bool highQualityFadeCompleted; 
	public float length; 
	public SoundFade.Direction currentDirection; 
	private Sound _sound; 
	public SoundModulation.Modulator fadeGainModulator; 
	private float startTime; 
	private float fadeOutTimeFinished; 
	private float fadeOutTimeBuffer; 

	public Sound sound { get; }
	public bool isFading { get; }
	public bool isFadingOut { get; }
	public bool isFadingIn { get; }
	public float fadeTimeLeft { get; }


	public Sound get_sound() { }

	public bool get_isFading() { }

	public bool get_isFadingOut() { }

	public bool get_isFadingIn() { }

	public float get_fadeTimeLeft() { }

	public void FadeIn(float time) { }

	public void FadeOut(float time) { }

	public void DoUpdate() { }

	private void HQFadeComplete() { }

	public void Init() { }

	private void DoFade(float time, SoundFade.Direction direction) { }

	public bool isGainLevelAudible() { }

	public void .ctor() { }

}

public enum SoundFade.Direction // TypeDefIndex: 10701
{
	public int value__; 
	public const SoundFade.Direction In = 0;
	public const SoundFade.Direction Out = 1;

}

