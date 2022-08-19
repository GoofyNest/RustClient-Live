public class WeatherPreset : ScriptableObject // TypeDefIndex: 10077
{	// Fields
	public WeatherPresetType Type; // 0x18
	public float Wind; // 0x1C
	public float Rain; // 0x20
	public float Thunder; // 0x24
	public float Rainbow; // 0x28
	public TOD_AtmosphereParameters Atmosphere; // 0x30
	public TOD_CloudParameters Clouds; // 0x38

	// Methods

	// RVA: 0x89C8A0 Offset: 0x89BCA0 VA: 0x18089C8A0
	public void Apply(TOD_Sky sky) { }

	// RVA: 0x89CA80 Offset: 0x89BE80 VA: 0x18089CA80
	public void Copy(TOD_Sky sky) { }

	// RVA: 0x89E550 Offset: 0x89D950 VA: 0x18089E550
	public void Reset() { }

	// RVA: 0x89E720 Offset: 0x89DB20 VA: 0x18089E720
	public void Set(WeatherPreset other) { }

	// RVA: 0x89E920 Offset: 0x89DD20 VA: 0x18089E920 Slot: 3
	public override string ToString() { }

	// RVA: 0x89CC60 Offset: 0x89C060 VA: 0x18089CC60
	public void Fade(WeatherPreset a, WeatherPreset b, float t) { }

	// RVA: 0x89E2A0 Offset: 0x89D6A0 VA: 0x18089E2A0
	public void Override(WeatherPreset other) { }

	// RVA: 0x89D650 Offset: 0x89CA50 VA: 0x18089D650
	public void Max(WeatherPreset other) { }

	// RVA: 0x89DF80 Offset: 0x89D380 VA: 0x18089DF80
	public void Min(WeatherPreset other) { }

	// RVA: 0x89D5D0 Offset: 0x89C9D0 VA: 0x18089D5D0
	private void Fade(ref float x, float a, float b, float t) { }

	// RVA: 0x89E290 Offset: 0x89D690 VA: 0x18089E290
	private void Override(ref float x, float other) { }

	// RVA: 0x89DE80 Offset: 0x89D280 VA: 0x18089DE80
	private void Max(ref float x, float other) { }

	// RVA: 0x89DF00 Offset: 0x89D300 VA: 0x18089DF00
	private void Min(ref float x, float other) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

