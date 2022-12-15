public class Climate : SingletonComponent<Climate> // TypeDefIndex: 11582
{
	private const float fadeAngle = 20;
	private const float defaultTemp = 15;
	private const int weatherDurationHours = 18;
	private const int weatherFadeHours = 6;
	[RangeAttribute]
	public float BlendingSpeed;
	[RangeAttribute]
	public float FogMultiplier;
	public float FogDarknessDistance;
	public bool DebugLUTBlending;
	public Climate.WeatherParameters Weather;
	public WeatherPreset[] WeatherPresets;
	public Climate.ClimateParameters Arid;
	public Climate.ClimateParameters Temperate;
	public Climate.ClimateParameters Tundra;
	public Climate.ClimateParameters Arctic;
	[CompilerGeneratedAttribute]
	private float <WeatherStateBlend>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <WeatherSeedPrevious>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <WeatherSeedTarget>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <WeatherSeedNext>k__BackingField;
	[CompilerGeneratedAttribute]
	private WeatherPreset <WeatherStatePrevious>k__BackingField;
	[CompilerGeneratedAttribute]
	private WeatherPreset <WeatherStateTarget>k__BackingField;
	[CompilerGeneratedAttribute]
	private WeatherPreset <WeatherStateNext>k__BackingField;
	[CompilerGeneratedAttribute]
	private WeatherPreset <WeatherState>k__BackingField;
	[CompilerGeneratedAttribute]
	private WeatherPreset <WeatherClampsMin>k__BackingField;
	[CompilerGeneratedAttribute]
	private WeatherPreset <WeatherClampsMax>k__BackingField;
	[CompilerGeneratedAttribute]
	private WeatherPreset <WeatherOverrides>k__BackingField;
	[CompilerGeneratedAttribute]
	private LegacyWeatherState <Overrides>k__BackingField;
	private Camera cam;
	private TOD_Scattering scattering;
	private WindZone windZone;
	private Climate.ClimateParameters currentClimate;
	private Climate.ClimateParameters prevClimate;
	private Dictionary<WeatherPresetType, WeatherPreset[]> presetLookup;
	private Climate.ClimateParameters[] climateLookup;

	public float WeatherStateBlend { get; set; }
	public uint WeatherSeedPrevious { get; set; }
	public uint WeatherSeedTarget { get; set; }
	public uint WeatherSeedNext { get; set; }
	public WeatherPreset WeatherStatePrevious { get; set; }
	public WeatherPreset WeatherStateTarget { get; set; }
	public WeatherPreset WeatherStateNext { get; set; }
	public WeatherPreset WeatherState { get; set; }
	public WeatherPreset WeatherClampsMin { get; set; }
	public WeatherPreset WeatherClampsMax { get; set; }
	public WeatherPreset WeatherOverrides { get; set; }
	public LegacyWeatherState Overrides { get; set; }


	[CompilerGeneratedAttribute]
	public float get_WeatherStateBlend() { }

	[CompilerGeneratedAttribute]
	private void set_WeatherStateBlend(float value) { }

	[CompilerGeneratedAttribute]
	public uint get_WeatherSeedPrevious() { }

	[CompilerGeneratedAttribute]
	private void set_WeatherSeedPrevious(uint value) { }

	[CompilerGeneratedAttribute]
	public uint get_WeatherSeedTarget() { }

	[CompilerGeneratedAttribute]
	private void set_WeatherSeedTarget(uint value) { }

	[CompilerGeneratedAttribute]
	public uint get_WeatherSeedNext() { }

	[CompilerGeneratedAttribute]
	private void set_WeatherSeedNext(uint value) { }

	[CompilerGeneratedAttribute]
	public WeatherPreset get_WeatherStatePrevious() { }

	[CompilerGeneratedAttribute]
	private void set_WeatherStatePrevious(WeatherPreset value) { }

	[CompilerGeneratedAttribute]
	public WeatherPreset get_WeatherStateTarget() { }

	[CompilerGeneratedAttribute]
	private void set_WeatherStateTarget(WeatherPreset value) { }

	[CompilerGeneratedAttribute]
	public WeatherPreset get_WeatherStateNext() { }

	[CompilerGeneratedAttribute]
	private void set_WeatherStateNext(WeatherPreset value) { }

	[CompilerGeneratedAttribute]
	public WeatherPreset get_WeatherState() { }

	[CompilerGeneratedAttribute]
	private void set_WeatherState(WeatherPreset value) { }

	[CompilerGeneratedAttribute]
	public WeatherPreset get_WeatherClampsMin() { }

	[CompilerGeneratedAttribute]
	private void set_WeatherClampsMin(WeatherPreset value) { }

	[CompilerGeneratedAttribute]
	public WeatherPreset get_WeatherClampsMax() { }

	[CompilerGeneratedAttribute]
	private void set_WeatherClampsMax(WeatherPreset value) { }

	[CompilerGeneratedAttribute]
	public WeatherPreset get_WeatherOverrides() { }

	[CompilerGeneratedAttribute]
	private void set_WeatherOverrides(WeatherPreset value) { }

	[CompilerGeneratedAttribute]
	public LegacyWeatherState get_Overrides() { }

	[CompilerGeneratedAttribute]
	private void set_Overrides(LegacyWeatherState value) { }

	protected override void Awake() { }

	protected override void OnDestroy() { }

	protected void Start() { }

	protected void Update() { }

	private static bool Initialized() { }

	public static float GetClouds(Vector3 position) { }

	public static float GetFog(Vector3 position) { }

	public static float GetWind(Vector3 position) { }

	public static float GetThunder(Vector3 position) { }

	public static float GetRainbow(Vector3 position) { }

	public static float GetAurora(Vector3 position) { }

	public static float GetRain(Vector3 position) { }

	public static float GetSnow(Vector3 position) { }

	public static float GetTemperature(Vector3 position) { }

	private uint GetSeedFromLong(long val) { }

	private WeatherPreset GetWeatherPreset(uint seed) { }

	private WeatherPreset GetWeatherPreset(uint seed, WeatherPresetType type) { }

	private WeatherPreset[] CacheWeatherPresets(WeatherPresetType type) { }

	private float FindBlendParameters(Vector3 pos, out Climate.ClimateParameters src, out Climate.ClimateParameters dst) { }

	public void .ctor() { }

}

public class Climate.ClimateParameters // TypeDefIndex: 11583
{
	public AnimationCurve Temperature;
	[HorizontalAttribute]
	public Climate.Float4 AerialDensity;
	[HorizontalAttribute]
	public Climate.Float4 FogDensity;
	[HorizontalAttribute]
	public Climate.Texture2D4 LUT;


	public void .ctor() { }

}

public class Climate.WeatherParameters // TypeDefIndex: 11584
{
	[RangeAttribute]
	public float ClearChance;
	[RangeAttribute]
	public float DustChance;
	[RangeAttribute]
	public float FogChance;
	[RangeAttribute]
	public float OvercastChance;
	[RangeAttribute]
	public float StormChance;
	[RangeAttribute]
	public float RainChance;


	public void .ctor() { }

}

public class Climate.Value4<T> // TypeDefIndex: 11585
{
	public T Dawn;
	public T Noon;
	public T Dusk;
	public T Night;


	public float FindBlendParameters(TOD_Sky sky, out T src, out T dst) { }
	/* GenericInstMethod :
	|
	|-Climate.Value4<object>.FindBlendParameters
	|
	|-Climate.Value4<float>.FindBlendParameters
	|
	|-Climate.Value4<Color>.FindBlendParameters
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Climate.Value4<object>..ctor
	|-Climate.Value4<float>..ctor
	|-Climate.Value4<Color>..ctor
	|-Climate.Value4<Texture2D>..ctor
	*/

}

public class Climate.Float4 : Climate.Value4<float> // TypeDefIndex: 11586
{

	public void .ctor() { }

}

public class Climate.Color4 : Climate.Value4<Color> // TypeDefIndex: 11587
{

	public void .ctor() { }

}

public class Climate.Texture2D4 : Climate.Value4<Texture2D> // TypeDefIndex: 11588
{

	public void .ctor() { }

}

private sealed class Climate.<>c__DisplayClass87_0 // TypeDefIndex: 11589
{
	public WeatherPresetType type;


	public void .ctor() { }

	internal bool <CacheWeatherPresets>

}

