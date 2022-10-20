public class WeatherPreset : ScriptableObject // TypeDefIndex: 11801
{
	public WeatherPresetType Type; 
	public float Wind; 
	public float Rain; 
	public float Thunder; 
	public float Rainbow; 
	public TOD_AtmosphereParameters Atmosphere; 
	public TOD_CloudParameters Clouds; 


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

