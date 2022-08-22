public class WeatherPreset : ScriptableObject // TypeDefIndex: 10077
{	public WeatherPresetType Type; // 0x18
	public float Wind; // 0x1C
	public float Rain; // 0x20
	public float Thunder; // 0x24
	public float Rainbow; // 0x28
	public TOD_AtmosphereParameters Atmosphere; // 0x30
	public TOD_CloudParameters Clouds; // 0x38


	public void Apply(TOD_Sky sky) { }

	public void Copy(TOD_Sky sky) { }

	public void Reset() { }

	public void Set(WeatherPreset other) { }

	public override string ToString() { }

	public void Fade(WeatherPreset a, WeatherPreset b, float t) { }

	public void Override(WeatherPreset other) { }

	public void Max(WeatherPreset other) { }

	public void Min(WeatherPreset other) { }

	private void Fade(ref float x, float a, float b, float t) { }

	private void Override(ref float x, float other) { }

	private void Max(ref float x, float other) { }

	private void Min(ref float x, float other) { }

	public void .ctor() { }

}

