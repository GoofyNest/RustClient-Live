public sealed class ColorUsageAttribute : PropertyAttribute // TypeDefIndex: 3484
{	// Fields
	public readonly bool showAlpha; // 0x10
	public readonly bool hdr; // 0x11
	[ObsoleteAttribute] // RVA: 0xB2F10 Offset: 0xB2310 VA: 0x1800B2F10
	public readonly float minBrightness; // 0x14
	[ObsoleteAttribute] // RVA: 0xB2F10 Offset: 0xB2310 VA: 0x1800B2F10
	public readonly float maxBrightness; // 0x18
	[ObsoleteAttribute] // RVA: 0xB2F10 Offset: 0xB2310 VA: 0x1800B2F10
	public readonly float minExposureValue; // 0x1C
	[ObsoleteAttribute] // RVA: 0xB2F10 Offset: 0xB2310 VA: 0x1800B2F10
	public readonly float maxExposureValue; // 0x20

	// Methods

	// RVA: 0x181EA40 Offset: 0x181DE40 VA: 0x18181EA40
	public void .ctor(bool showAlpha) { }

	// RVA: 0x181E9E0 Offset: 0x181DDE0 VA: 0x18181E9E0
	public void .ctor(bool showAlpha, bool hdr) { }

	[ObsoleteAttribute] // RVA: 0xB3290 Offset: 0xB2690 VA: 0x1800B3290
	// RVA: 0x181EA90 Offset: 0x181DE90 VA: 0x18181EA90
	public void .ctor(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue) { }

}

