public class Weather : ConsoleSystem // TypeDefIndex: 11972
{	// Fields
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float wetness_rain; // 0x0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float wetness_snow; // 0x4

	// Properties
	[ReplicatedVar] // RVA: 0xC5730 Offset: 0xC4B30 VA: 0x1800C5730
	public static float clear_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9A910 Offset: 0x99D10 VA: 0x18009A910
	public static float dust_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9A910 Offset: 0x99D10 VA: 0x18009A910
	public static float fog_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9A910 Offset: 0x99D10 VA: 0x18009A910
	public static float overcast_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9A910 Offset: 0x99D10 VA: 0x18009A910
	public static float storm_chance { get; set; }
	[ReplicatedVar] // RVA: 0x9A910 Offset: 0x99D10 VA: 0x18009A910
	public static float rain_chance { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float rain { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float wind { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float thunder { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float rainbow { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float fog { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float atmosphere_rayleigh { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float atmosphere_mie { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float atmosphere_brightness { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float atmosphere_contrast { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float atmosphere_directionality { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float cloud_size { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float cloud_opacity { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float cloud_coverage { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float cloud_sharpness { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float cloud_coloring { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float cloud_attenuation { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float cloud_saturation { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float cloud_scattering { get; set; }
	[ReplicatedVar] // RVA: 0xC5C40 Offset: 0xC5040 VA: 0x1800C5C40
	public static float cloud_brightness { get; set; }

	// Methods

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x36DB90 Offset: 0x36CF90 VA: 0x18036DB90
	public static void load(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x36E6A0 Offset: 0x36DAA0 VA: 0x18036E6A0
	public static void reset(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x36DEA0 Offset: 0x36D2A0 VA: 0x18036DEA0
	public static void report(ConsoleSystem.Arg args) { }

	// RVA: 0x36C930 Offset: 0x36BD30 VA: 0x18036C930
	public static float get_clear_chance() { }

	// RVA: 0x36ED00 Offset: 0x36E100 VA: 0x18036ED00
	public static void set_clear_chance(float value) { }

	// RVA: 0x36D280 Offset: 0x36C680 VA: 0x18036D280
	public static float get_dust_chance() { }

	// RVA: 0x36F680 Offset: 0x36EA80 VA: 0x18036F680
	public static void set_dust_chance(float value) { }

	// RVA: 0x36D360 Offset: 0x36C760 VA: 0x18036D360
	public static float get_fog_chance() { }

	// RVA: 0x36F790 Offset: 0x36EB90 VA: 0x18036F790
	public static void set_fog_chance(float value) { }

	// RVA: 0x36D530 Offset: 0x36C930 VA: 0x18036D530
	public static float get_overcast_chance() { }

	// RVA: 0x36F990 Offset: 0x36ED90 VA: 0x18036F990
	public static void set_overcast_chance(float value) { }

	// RVA: 0x36D8D0 Offset: 0x36CCD0 VA: 0x18036D8D0
	public static float get_storm_chance() { }

	// RVA: 0x36FD70 Offset: 0x36F170 VA: 0x18036FD70
	public static void set_storm_chance(float value) { }

	// RVA: 0x36D610 Offset: 0x36CA10 VA: 0x18036D610
	public static float get_rain_chance() { }

	// RVA: 0x36FAA0 Offset: 0x36EEA0 VA: 0x18036FAA0
	public static void set_rain_chance(float value) { }

	// RVA: 0x36D6F0 Offset: 0x36CAF0 VA: 0x18036D6F0
	public static float get_rain() { }

	// RVA: 0x36FBB0 Offset: 0x36EFB0 VA: 0x18036FBB0
	public static void set_rain(float value) { }

	// RVA: 0x36DAA0 Offset: 0x36CEA0 VA: 0x18036DAA0
	public static float get_wind() { }

	// RVA: 0x36FF60 Offset: 0x36F360 VA: 0x18036FF60
	public static void set_wind(float value) { }

	// RVA: 0x36D9B0 Offset: 0x36CDB0 VA: 0x18036D9B0
	public static float get_thunder() { }

	// RVA: 0x36FE80 Offset: 0x36F280 VA: 0x18036FE80
	public static void set_thunder(float value) { }

	// RVA: 0x36D7E0 Offset: 0x36CBE0 VA: 0x18036D7E0
	public static float get_rainbow() { }

	// RVA: 0x36FC90 Offset: 0x36F090 VA: 0x18036FC90
	public static void set_rainbow(float value) { }

	// RVA: 0x36D440 Offset: 0x36C840 VA: 0x18036D440
	public static float get_fog() { }

	// RVA: 0x36F8A0 Offset: 0x36ECA0 VA: 0x18036F8A0
	public static void set_fog(float value) { }

	// RVA: 0x36C840 Offset: 0x36BC40 VA: 0x18036C840
	public static float get_atmosphere_rayleigh() { }

	// RVA: 0x36EC10 Offset: 0x36E010 VA: 0x18036EC10
	public static void set_atmosphere_rayleigh(float value) { }

	// RVA: 0x36C750 Offset: 0x36BB50 VA: 0x18036C750
	public static float get_atmosphere_mie() { }

	// RVA: 0x36EB20 Offset: 0x36DF20 VA: 0x18036EB20
	public static void set_atmosphere_mie(float value) { }

	// RVA: 0x36C480 Offset: 0x36B880 VA: 0x18036C480
	public static float get_atmosphere_brightness() { }

	// RVA: 0x36E850 Offset: 0x36DC50 VA: 0x18036E850
	public static void set_atmosphere_brightness(float value) { }

	// RVA: 0x36C570 Offset: 0x36B970 VA: 0x18036C570
	public static float get_atmosphere_contrast() { }

	// RVA: 0x36E940 Offset: 0x36DD40 VA: 0x18036E940
	public static void set_atmosphere_contrast(float value) { }

	// RVA: 0x36C660 Offset: 0x36BA60 VA: 0x18036C660
	public static float get_atmosphere_directionality() { }

	// RVA: 0x36EA30 Offset: 0x36DE30 VA: 0x18036EA30
	public static void set_atmosphere_directionality(float value) { }

	// RVA: 0x36D190 Offset: 0x36C590 VA: 0x18036D190
	public static float get_cloud_size() { }

	// RVA: 0x36F590 Offset: 0x36E990 VA: 0x18036F590
	public static void set_cloud_size(float value) { }

	// RVA: 0x36CDD0 Offset: 0x36C1D0 VA: 0x18036CDD0
	public static float get_cloud_opacity() { }

	// RVA: 0x36F1D0 Offset: 0x36E5D0 VA: 0x18036F1D0
	public static void set_cloud_opacity(float value) { }

	// RVA: 0x36CCE0 Offset: 0x36C0E0 VA: 0x18036CCE0
	public static float get_cloud_coverage() { }

	// RVA: 0x36F0E0 Offset: 0x36E4E0 VA: 0x18036F0E0
	public static void set_cloud_coverage(float value) { }

	// RVA: 0x36D0A0 Offset: 0x36C4A0 VA: 0x18036D0A0
	public static float get_cloud_sharpness() { }

	// RVA: 0x36F4A0 Offset: 0x36E8A0 VA: 0x18036F4A0
	public static void set_cloud_sharpness(float value) { }

	// RVA: 0x36CBF0 Offset: 0x36BFF0 VA: 0x18036CBF0
	public static float get_cloud_coloring() { }

	// RVA: 0x36EFF0 Offset: 0x36E3F0 VA: 0x18036EFF0
	public static void set_cloud_coloring(float value) { }

	// RVA: 0x36CA10 Offset: 0x36BE10 VA: 0x18036CA10
	public static float get_cloud_attenuation() { }

	// RVA: 0x36EE10 Offset: 0x36E210 VA: 0x18036EE10
	public static void set_cloud_attenuation(float value) { }

	// RVA: 0x36CEC0 Offset: 0x36C2C0 VA: 0x18036CEC0
	public static float get_cloud_saturation() { }

	// RVA: 0x36F2C0 Offset: 0x36E6C0 VA: 0x18036F2C0
	public static void set_cloud_saturation(float value) { }

	// RVA: 0x36CFB0 Offset: 0x36C3B0 VA: 0x18036CFB0
	public static float get_cloud_scattering() { }

	// RVA: 0x36F3B0 Offset: 0x36E7B0 VA: 0x18036F3B0
	public static void set_cloud_scattering(float value) { }

	// RVA: 0x36CB00 Offset: 0x36BF00 VA: 0x18036CB00
	public static float get_cloud_brightness() { }

	// RVA: 0x36EF00 Offset: 0x36E300 VA: 0x18036EF00
	public static void set_cloud_brightness(float value) { }

	// RVA: 0x36C420 Offset: 0x36B820 VA: 0x18036C420
	public void .ctor() { }

	// RVA: 0x36C3D0 Offset: 0x36B7D0 VA: 0x18036C3D0
	private static void .cctor() { }

}

private sealed class Weather.<>c__DisplayClass0_0 // TypeDefIndex: 11973
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x36BF50 Offset: 0x36B350 VA: 0x18036BF50
	internal bool <load>b__0(WeatherPreset x) { }

}

