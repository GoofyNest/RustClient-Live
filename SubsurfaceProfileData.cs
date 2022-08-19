public struct SubsurfaceProfileData // TypeDefIndex: 10661
{	// Fields
	[RangeAttribute] // RVA: 0xEF200 Offset: 0xEE600 VA: 0x1800EF200
	public float ScatterRadius; // 0x0
	[ColorUsageAttribute] // RVA: 0xEF4E0 Offset: 0xEE8E0 VA: 0x1800EF4E0
	public Color SubsurfaceColor; // 0x4
	[ColorUsageAttribute] // RVA: 0xEF4E0 Offset: 0xEE8E0 VA: 0x1800EF4E0
	public Color FalloffColor; // 0x14

	// Properties
	public static SubsurfaceProfileData Default { get; }
	public static SubsurfaceProfileData Invalid { get; }

	// Methods

	// RVA: 0x7A1CC0 Offset: 0x7A10C0 VA: 0x1807A1CC0
	public static SubsurfaceProfileData get_Default() { }

	// RVA: 0x7A1D70 Offset: 0x7A1170 VA: 0x1807A1D70
	public static SubsurfaceProfileData get_Invalid() { }

}

