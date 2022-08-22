public class SoundFade : MonoBehaviour, IClientComponent // TypeDefIndex: 9028
{	public SoundFadeHQAudioFilter hqFadeFilter; // 0x18
	public float currentGain; // 0x20
	public float startingGain; // 0x24
	public float finalGain; // 0x28
	public int sampleRate; // 0x2C
	public bool highQualityFadeCompleted; // 0x30
	public float length; // 0x34
	public SoundFade.Direction currentDirection; // 0x38
	private Sound _sound; // 0x40
	public SoundModulation.Modulator fadeGainModulator; // 0x48
	private float startTime; // 0x50
	private float fadeOutTimeFinished; // 0x54
	private float fadeOutTimeBuffer; // 0x58

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

public enum SoundFade.Direction // TypeDefIndex: 9029
{	public int value__; // 0x0
	public const SoundFade.Direction In = 0;
	public const SoundFade.Direction Out = 1;

}

