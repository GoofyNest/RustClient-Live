public sealed class ColorUsageAttribute : PropertyAttribute // TypeDefIndex: 3484
{
	public readonly bool showAlpha; 
	public readonly bool hdr; 
	[ObsoleteAttribute] 
	public readonly float minBrightness; 
	[ObsoleteAttribute] 
	public readonly float maxBrightness; 
	[ObsoleteAttribute] 
	public readonly float minExposureValue; 
	[ObsoleteAttribute] 
	public readonly float maxExposureValue; 


public void .ctor(bool showAlpha) { }

public void .ctor(bool showAlpha, bool hdr) { }

	[ObsoleteAttribute] 
public void .ctor(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue) { }

}

