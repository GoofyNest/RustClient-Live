public class RainEffect : WeatherEffect // TypeDefIndex: 10070
{	// Fields
	public int FadeStartDistance; // 0x48
	public int FadeEndDistance; // 0x4C
	public int FadeFalloff; // 0x50
	public bool Stormy; // 0x54

	// Methods

	// RVA: 0x6A5580 Offset: 0x6A4980 VA: 0x1806A5580 Slot: 6
	protected override float GetCurrentIntensity() { }

	// RVA: 0x5CA9D0 Offset: 0x5C9DD0 VA: 0x1805CA9D0 Slot: 7
	protected override float GetUpdateInterval(float intensity) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	protected override void UpdatePosition(float intensity) { }

	// RVA: 0x5CAA10 Offset: 0x5C9E10 VA: 0x1805CAA10
	public void .ctor() { }

}

