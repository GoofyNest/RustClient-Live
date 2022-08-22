public class SnowEffect : WeatherEffect // TypeDefIndex: 10072
{	public int FadeStartDistance; // 0x48
	public int FadeEndDistance; // 0x4C
	public int FadeFalloff; // 0x50
	public bool Stormy; // 0x54


	protected override float GetCurrentIntensity() { }

	protected override float GetUpdateInterval(float intensity) { }

	protected override void UpdatePosition(float intensity) { }

	public void .ctor() { }

}

