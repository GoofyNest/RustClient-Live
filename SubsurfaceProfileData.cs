public struct SubsurfaceProfileData // TypeDefIndex: 12412
{
	[RangeAttribute] 
	public float ScatterRadius; 
	[ColorUsageAttribute] 
	public Color SubsurfaceColor; 
	[ColorUsageAttribute] 
	public Color FalloffColor; 

	public static SubsurfaceProfileData Default { get; }
	public static SubsurfaceProfileData Invalid { get; }


	public static SubsurfaceProfileData get_Default() { }

	public static SubsurfaceProfileData get_Invalid() { }

}

