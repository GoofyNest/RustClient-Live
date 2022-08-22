public class TimeBasedSoundSpread : SoundModifier // TypeDefIndex: 9046
{	public AnimationCurve spreadCurve; // 0x20
	public AnimationCurve wanderIntensityCurve; // 0x28
	private float startTime; // 0x30
	private float wanderTime; // 0x34
	private SoundModulation.Modulator modulator; // 0x38


	public override void Init(Sound targetSound) { }

	public override void OnSoundPlay() { }

	public override void ApplyModification() { }

	public void .ctor() { }

}

