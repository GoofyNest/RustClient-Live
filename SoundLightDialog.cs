public class SoundLightDialog : UIDialog // TypeDefIndex: 10907
{	public RustOption ColourOption; // 0x30
	public RustOption VolumeOption; // 0x38
	public RustOption SpeedOption; // 0x40
	public RustOption PatternOption; // 0x48
	public RustOption GradientOption; // 0x50
	private AudioVisualisationEntity targetEntity; // 0x58


	public void SetLight(AudioVisualisationEntity entity) { }

	public override void CloseDialog() { }

	private int GetValueFromOption(RustOption option, int defaultValue = 0) { }

	public void .ctor() { }

}

