public class Climate : SingletonComponent<Climate> // TypeDefIndex: 9828
{	private const float fadeAngle = 20;
	private const float defaultTemp = 15;
	private const int weatherDurationHours = 18;
	private const int weatherFadeHours = 6;
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float BlendingSpeed; // 0x18
	[RangeAttribute] // RVA: 0x9C840 Offset: 0x9BC40 VA: 0x18009C840
	public float FogMultiplier; // 0x1C
	public float FogDarknessDistance; // 0x20
	public bool DebugLUTBlending; // 0x24
	public Climate.WeatherParameters Weather; // 0x28
	public WeatherPreset[] WeatherPresets; // 0x30
	public Climate.ClimateParameters Arid; // 0x38
	public Climate.ClimateParameters Temperate; // 0x40
	public Climate.ClimateParameters Tundra; // 0x48
	public Climate.ClimateParameters Arctic; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <WeatherStateBlend>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <WeatherSeedPrevious>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <WeatherSeedTarget>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <WeatherSeedNext>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WeatherPreset <WeatherStatePrevious>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WeatherPreset <WeatherStateTarget>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WeatherPreset <WeatherStateNext>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WeatherPreset <WeatherState>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WeatherPreset <WeatherClampsMin>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WeatherPreset <WeatherClampsMax>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WeatherPreset <WeatherOverrides>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private LegacyWeatherState <Overrides>k__BackingField; // 0xA0
	private Camera cam; // 0xA8
	private TOD_Scattering scattering; // 0xB0
	private WindZone windZone; // 0xB8
	private Climate.ClimateParameters currentClimate; // 0xC0
	private Climate.ClimateParameters prevClimate; // 0xC8
	private Dictionary<WeatherPresetType, WeatherPreset[]> presetLookup; // 0xD0
	private Climate.ClimateParameters[] climateLookup; // 0xD8

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


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_WeatherStateBlend() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WeatherStateBlend(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint get_WeatherSeedPrevious() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WeatherSeedPrevious(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint get_WeatherSeedTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WeatherSeedTarget(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint get_WeatherSeedNext() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WeatherSeedNext(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public WeatherPreset get_WeatherStatePrevious() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WeatherStatePrevious(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public WeatherPreset get_WeatherStateTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WeatherStateTarget(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public WeatherPreset get_WeatherStateNext() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WeatherStateNext(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public WeatherPreset get_WeatherState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WeatherState(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public WeatherPreset get_WeatherClampsMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WeatherClampsMin(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public WeatherPreset get_WeatherClampsMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WeatherClampsMax(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public WeatherPreset get_WeatherOverrides() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WeatherOverrides(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public LegacyWeatherState get_Overrides() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public class Climate.ClimateParameters // TypeDefIndex: 9829
{	public AnimationCurve Temperature; // 0x10
	[HorizontalAttribute] // RVA: 0x9EA80 Offset: 0x9DE80 VA: 0x18009EA80
	public Climate.Float4 AerialDensity; // 0x18
	[HorizontalAttribute] // RVA: 0x9EA80 Offset: 0x9DE80 VA: 0x18009EA80
	public Climate.Float4 FogDensity; // 0x20
	[HorizontalAttribute] // RVA: 0x9EA80 Offset: 0x9DE80 VA: 0x18009EA80
	public Climate.Texture2D4 LUT; // 0x28


	public void .ctor() { }

}

public class Climate.WeatherParameters // TypeDefIndex: 9830
{	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float ClearChance; // 0x10
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float DustChance; // 0x14
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float FogChance; // 0x18
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float OvercastChance; // 0x1C
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float StormChance; // 0x20
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float RainChance; // 0x24


	public void .ctor() { }

}

public class Climate.Value4<T> // TypeDefIndex: 9831
{	public T Dawn; // 0x0
	public T Noon; // 0x0
	public T Dusk; // 0x0
	public T Night; // 0x0


	public float FindBlendParameters(TOD_Sky sky, out T src, out T dst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E4F40 Offset: 0x15E4340 VA: 0x1815E4F40
	|-Climate.Value4<object>.FindBlendParameters
	|
	|-RVA: 0x15E5190 Offset: 0x15E4590 VA: 0x1815E5190
	|-Climate.Value4<float>.FindBlendParameters
	|
	|-RVA: 0x15E4D20 Offset: 0x15E4120 VA: 0x1815E4D20
	|-Climate.Value4<Color>.FindBlendParameters
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-Climate.Value4<object>..ctor
	|-Climate.Value4<float>..ctor
	|-Climate.Value4<Color>..ctor
	|-Climate.Value4<Texture2D>..ctor
	*/

}

public class Climate.Float4 : Climate.Value4<float> // TypeDefIndex: 9832
{
	public void .ctor() { }

}

public class Climate.Color4 : Climate.Value4<Color> // TypeDefIndex: 9833
{
	public void .ctor() { }

}

public class Climate.Texture2D4 : Climate.Value4<Texture2D> // TypeDefIndex: 9834
{
	public void .ctor() { }

}

private sealed class Climate.<>c__DisplayClass87_0 // TypeDefIndex: 9835
{	public WeatherPresetType type; // 0x10


	public void .ctor() { }

	internal bool <CacheWeatherPresets>b__0(WeatherPreset x) { }

}

