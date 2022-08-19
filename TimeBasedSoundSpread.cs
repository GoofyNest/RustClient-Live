public class TimeBasedSoundSpread : SoundModifier // TypeDefIndex: 9046
{	// Fields
	public AnimationCurve spreadCurve; // 0x20
	public AnimationCurve wanderIntensityCurve; // 0x28
	private float startTime; // 0x30
	private float wanderTime; // 0x34
	private SoundModulation.Modulator modulator; // 0x38

	// Methods

	// RVA: 0x84E920 Offset: 0x84DD20 VA: 0x18084E920 Slot: 4
	public override void Init(Sound targetSound) { }

	// RVA: 0x84E9A0 Offset: 0x84DDA0 VA: 0x18084E9A0 Slot: 6
	public override void OnSoundPlay() { }

	// RVA: 0x84E770 Offset: 0x84DB70 VA: 0x18084E770 Slot: 5
	public override void ApplyModification() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

