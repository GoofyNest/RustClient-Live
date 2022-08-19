public class SoundFade : MonoBehaviour, IClientComponent // TypeDefIndex: 9028
{	// Fields
	public SoundFadeHQAudioFilter hqFadeFilter; // 0x18
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

	// Properties
	public Sound sound { get; }
	public bool isFading { get; }
	public bool isFadingOut { get; }
	public bool isFadingIn { get; }
	public float fadeTimeLeft { get; }

	// Methods

	// RVA: 0xA710E0 Offset: 0xA704E0 VA: 0x180A710E0
	public Sound get_sound() { }

	// RVA: 0xA710D0 Offset: 0xA704D0 VA: 0x180A710D0
	public bool get_isFading() { }

	// RVA: 0xA710B0 Offset: 0xA704B0 VA: 0x180A710B0
	public bool get_isFadingOut() { }

	// RVA: 0xA71090 Offset: 0xA70490 VA: 0x180A71090
	public bool get_isFadingIn() { }

	// RVA: 0xA71050 Offset: 0xA70450 VA: 0x180A71050
	public float get_fadeTimeLeft() { }

	// RVA: 0xA70E30 Offset: 0xA70230 VA: 0x180A70E30
	public void FadeIn(float time) { }

	// RVA: 0xA70E40 Offset: 0xA70240 VA: 0x180A70E40
	public void FadeOut(float time) { }

	// RVA: 0xA70B70 Offset: 0xA6FF70 VA: 0x180A70B70
	public void DoUpdate() { }

	// RVA: 0xA70E50 Offset: 0xA70250 VA: 0x180A70E50
	private void HQFadeComplete() { }

	// RVA: 0xA70E80 Offset: 0xA70280 VA: 0x180A70E80
	public void Init() { }

	// RVA: 0xA70990 Offset: 0xA6FD90 VA: 0x180A70990
	private void DoFade(float time, SoundFade.Direction direction) { }

	// RVA: 0xA71180 Offset: 0xA70580 VA: 0x180A71180
	public bool isGainLevelAudible() { }

	// RVA: 0xA71010 Offset: 0xA70410 VA: 0x180A71010
	public void .ctor() { }

}

public enum SoundFade.Direction // TypeDefIndex: 9029
{	// Fields
	public int value__; // 0x0
	public const SoundFade.Direction In = 0;
	public const SoundFade.Direction Out = 1;

}

