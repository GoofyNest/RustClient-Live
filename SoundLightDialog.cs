public class SoundLightDialog : UIDialog // TypeDefIndex: 10907
{	// Fields
	public RustOption ColourOption; // 0x30
	public RustOption VolumeOption; // 0x38
	public RustOption SpeedOption; // 0x40
	public RustOption PatternOption; // 0x48
	public RustOption GradientOption; // 0x50
	private AudioVisualisationEntity targetEntity; // 0x58

	// Methods

	// RVA: 0xA717B0 Offset: 0xA70BB0 VA: 0x180A717B0
	public void SetLight(AudioVisualisationEntity entity) { }

	// RVA: 0xA71520 Offset: 0xA70920 VA: 0x180A71520 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0xA71750 Offset: 0xA70B50 VA: 0x180A71750
	private int GetValueFromOption(RustOption option, int defaultValue = 0) { }

	// RVA: 0x4BE840 Offset: 0x4BDC40 VA: 0x1804BE840
	public void .ctor() { }

}

