public struct SubsurfaceProfileData // TypeDefIndex: 10661
{	[RangeAttribute] // RVA: 0xEF200 Offset: 0xEE600 VA: 0x1800EF200
	public float ScatterRadius; // 0x0
	[ColorUsageAttribute] // RVA: 0xEF4E0 Offset: 0xEE8E0 VA: 0x1800EF4E0
	public Color SubsurfaceColor; // 0x4
	[ColorUsageAttribute] // RVA: 0xEF4E0 Offset: 0xEE8E0 VA: 0x1800EF4E0
	public Color FalloffColor; // 0x14

	public static SubsurfaceProfileData Default { get; }
	public static SubsurfaceProfileData Invalid { get; }


	public static SubsurfaceProfileData get_Default() { }

	public static SubsurfaceProfileData get_Invalid() { }

}

