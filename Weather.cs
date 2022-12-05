public class Weather : ConsoleSystem // TypeDefIndex: 13781
{
	[ServerVar]
	public static float wetness_rain;
	[ServerVar]
	public static float wetness_snow;

	[ReplicatedVar]
	public static float clear_chance { get; set; }
	[ReplicatedVar]
	public static float dust_chance { get; set; }
	[ReplicatedVar]
	public static float fog_chance { get; set; }
	[ReplicatedVar]
	public static float overcast_chance { get; set; }
	[ReplicatedVar]
	public static float storm_chance { get; set; }
	[ReplicatedVar]
	public static float rain_chance { get; set; }
	[ReplicatedVar]
	public static float rain { get; set; }
	[ReplicatedVar]
	public static float wind { get; set; }
	[ReplicatedVar]
	public static float thunder { get; set; }
	[ReplicatedVar]
	public static float rainbow { get; set; }
	[ReplicatedVar]
	public static float fog { get; set; }
	[ReplicatedVar]
	public static float atmosphere_rayleigh { get; set; }
	[ReplicatedVar]
	public static float atmosphere_mie { get; set; }
	[ReplicatedVar]
	public static float atmosphere_brightness { get; set; }
	[ReplicatedVar]
	public static float atmosphere_contrast { get; set; }
	[ReplicatedVar]
	public static float atmosphere_directionality { get; set; }
	[ReplicatedVar]
	public static float cloud_size { get; set; }
	[ReplicatedVar]
	public static float cloud_opacity { get; set; }
	[ReplicatedVar]
	public static float cloud_coverage { get; set; }
	[ReplicatedVar]
	public static float cloud_sharpness { get; set; }
	[ReplicatedVar]
	public static float cloud_coloring { get; set; }
	[ReplicatedVar]
	public static float cloud_attenuation { get; set; }
	[ReplicatedVar]
	public static float cloud_saturation { get; set; }
	[ReplicatedVar]
	public static float cloud_scattering { get; set; }
	[ReplicatedVar]
	public static float cloud_brightness { get; set; }


	[ClientVar]
	[ServerVar]
	public static void load(ConsoleSystem.Arg args) { }

	[ClientVar]
	[ServerVar]
	public static void reset(ConsoleSystem.Arg args) { }

	[ClientVar]
	[ServerVar]
	public static void report(ConsoleSystem.Arg args) { }

	public static float get_clear_chance() { }

	public static void set_clear_chance(float value) { }

	public static float get_dust_chance() { }

	public static void set_dust_chance(float value) { }

	public static float get_fog_chance() { }

	public static void set_fog_chance(float value) { }

	public static float get_overcast_chance() { }

	public static void set_overcast_chance(float value) { }

	public static float get_storm_chance() { }

	public static void set_storm_chance(float value) { }

	public static float get_rain_chance() { }

	public static void set_rain_chance(float value) { }

	public static float get_rain() { }

	public static void set_rain(float value) { }

	public static float get_wind() { }

	public static void set_wind(float value) { }

	public static float get_thunder() { }

	public static void set_thunder(float value) { }

	public static float get_rainbow() { }

	public static void set_rainbow(float value) { }

	public static float get_fog() { }

	public static void set_fog(float value) { }

	public static float get_atmosphere_rayleigh() { }

	public static void set_atmosphere_rayleigh(float value) { }

	public static float get_atmosphere_mie() { }

	public static void set_atmosphere_mie(float value) { }

	public static float get_atmosphere_brightness() { }

	public static void set_atmosphere_brightness(float value) { }

	public static float get_atmosphere_contrast() { }

	public static void set_atmosphere_contrast(float value) { }

	public static float get_atmosphere_directionality() { }

	public static void set_atmosphere_directionality(float value) { }

	public static float get_cloud_size() { }

	public static void set_cloud_size(float value) { }

	public static float get_cloud_opacity() { }

	public static void set_cloud_opacity(float value) { }

	public static float get_cloud_coverage() { }

	public static void set_cloud_coverage(float value) { }

	public static float get_cloud_sharpness() { }

	public static void set_cloud_sharpness(float value) { }

	public static float get_cloud_coloring() { }

	public static void set_cloud_coloring(float value) { }

	public static float get_cloud_attenuation() { }

	public static void set_cloud_attenuation(float value) { }

	public static float get_cloud_saturation() { }

	public static void set_cloud_saturation(float value) { }

	public static float get_cloud_scattering() { }

	public static void set_cloud_scattering(float value) { }

	public static float get_cloud_brightness() { }

	public static void set_cloud_brightness(float value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Weather.<>c__DisplayClass0_0 // TypeDefIndex: 13782
{
	public string name;


	public void .ctor() { }

	internal bool <load>

}

