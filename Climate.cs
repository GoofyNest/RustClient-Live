public class Climate : SingletonComponent<Climate> // TypeDefIndex: 9828
{	// Fields
	private const float fadeAngle = 20;
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

	// Properties
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

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC20 Offset: 0x58D020 VA: 0x18058DC20
	public float get_WeatherStateBlend() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCB0 Offset: 0x58D0B0 VA: 0x18058DCB0
	private void set_WeatherStateBlend(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC00 Offset: 0x58D000 VA: 0x18058DC00
	public uint get_WeatherSeedPrevious() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC90 Offset: 0x58D090 VA: 0x18058DC90
	private void set_WeatherSeedPrevious(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC10 Offset: 0x58D010 VA: 0x18058DC10
	public uint get_WeatherSeedTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCA0 Offset: 0x58D0A0 VA: 0x18058DCA0
	private void set_WeatherSeedTarget(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBF0 Offset: 0x58CFF0 VA: 0x18058DBF0
	public uint get_WeatherSeedNext() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC80 Offset: 0x58D080 VA: 0x18058DC80
	private void set_WeatherSeedNext(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public WeatherPreset get_WeatherStatePrevious() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	private void set_WeatherStatePrevious(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public WeatherPreset get_WeatherStateTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	private void set_WeatherStateTarget(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public WeatherPreset get_WeatherStateNext() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0
	private void set_WeatherStateNext(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public WeatherPreset get_WeatherState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	private void set_WeatherState(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	public WeatherPreset get_WeatherClampsMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC60 Offset: 0x58D060 VA: 0x18058DC60
	private void set_WeatherClampsMin(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public WeatherPreset get_WeatherClampsMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E0A00 Offset: 0x4DFE00 VA: 0x1804E0A00
	private void set_WeatherClampsMax(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public WeatherPreset get_WeatherOverrides() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC70 Offset: 0x58D070 VA: 0x18058DC70
	private void set_WeatherOverrides(WeatherPreset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0
	public LegacyWeatherState get_Overrides() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC50 Offset: 0x58D050 VA: 0x18058DC50
	private void set_Overrides(LegacyWeatherState value) { }

	// RVA: 0x58B1D0 Offset: 0x58A5D0 VA: 0x18058B1D0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x58CDD0 Offset: 0x58C1D0 VA: 0x18058CDD0 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x58CFE0 Offset: 0x58C3E0 VA: 0x18058CFE0
	protected void Start() { }

	// RVA: 0x58D1D0 Offset: 0x58C5D0 VA: 0x18058D1D0
	protected void Update() { }

	// RVA: 0x58CAA0 Offset: 0x58BEA0 VA: 0x18058CAA0
	private static bool Initialized() { }

	// RVA: 0x58BBC0 Offset: 0x58AFC0 VA: 0x18058BBC0
	public static float GetClouds(Vector3 position) { }

	// RVA: 0x58BC50 Offset: 0x58B050 VA: 0x18058BC50
	public static float GetFog(Vector3 position) { }

	// RVA: 0x58CA10 Offset: 0x58BE10 VA: 0x18058CA10
	public static float GetWind(Vector3 position) { }

	// RVA: 0x58C630 Offset: 0x58BA30 VA: 0x18058C630
	public static float GetThunder(Vector3 position) { }

	// RVA: 0x58BF70 Offset: 0x58B370 VA: 0x18058BF70
	public static float GetRainbow(Vector3 position) { }

	// RVA: 0x58B9B0 Offset: 0x58ADB0 VA: 0x18058B9B0
	public static float GetAurora(Vector3 position) { }

	// RVA: 0x58BCE0 Offset: 0x58B0E0 VA: 0x18058BCE0
	public static float GetRain(Vector3 position) { }

	// RVA: 0x58C2B0 Offset: 0x58B6B0 VA: 0x18058C2B0
	public static float GetSnow(Vector3 position) { }

	// RVA: 0x58C420 Offset: 0x58B820 VA: 0x18058C420
	public static float GetTemperature(Vector3 position) { }

	// RVA: 0x58C250 Offset: 0x58B650 VA: 0x18058C250
	private uint GetSeedFromLong(long val) { }

	// RVA: 0x58C760 Offset: 0x58BB60 VA: 0x18058C760
	private WeatherPreset GetWeatherPreset(uint seed) { }

	// RVA: 0x58C870 Offset: 0x58BC70 VA: 0x18058C870
	private WeatherPreset GetWeatherPreset(uint seed, WeatherPresetType type) { }

	// RVA: 0x58B490 Offset: 0x58A890 VA: 0x18058B490
	private WeatherPreset[] CacheWeatherPresets(WeatherPresetType type) { }

	// RVA: 0x58B550 Offset: 0x58A950 VA: 0x18058B550
	private float FindBlendParameters(Vector3 pos, out Climate.ClimateParameters src, out Climate.ClimateParameters dst) { }

	// RVA: 0x58DB50 Offset: 0x58CF50 VA: 0x18058DB50
	public void .ctor() { }

}

public class Climate.ClimateParameters // TypeDefIndex: 9829
{	// Fields
	public AnimationCurve Temperature; // 0x10
	[HorizontalAttribute] // RVA: 0x9EA80 Offset: 0x9DE80 VA: 0x18009EA80
	public Climate.Float4 AerialDensity; // 0x18
	[HorizontalAttribute] // RVA: 0x9EA80 Offset: 0x9DE80 VA: 0x18009EA80
	public Climate.Float4 FogDensity; // 0x20
	[HorizontalAttribute] // RVA: 0x9EA80 Offset: 0x9DE80 VA: 0x18009EA80
	public Climate.Texture2D4 LUT; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Climate.WeatherParameters // TypeDefIndex: 9830
{	// Fields
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
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

	// Methods

	// RVA: 0x5A3AC0 Offset: 0x5A2EC0 VA: 0x1805A3AC0
	public void .ctor() { }

}

public class Climate.Value4<T> // TypeDefIndex: 9831
{	// Fields
	public T Dawn; // 0x0
	public T Noon; // 0x0
	public T Dusk; // 0x0
	public T Night; // 0x0

	// Methods

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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
{	// Methods

	// RVA: 0x59DA70 Offset: 0x59CE70 VA: 0x18059DA70
	public void .ctor() { }

}

public class Climate.Color4 : Climate.Value4<Color> // TypeDefIndex: 9833
{	// Methods

	// RVA: 0x596150 Offset: 0x595550 VA: 0x180596150
	public void .ctor() { }

}

public class Climate.Texture2D4 : Climate.Value4<Texture2D> // TypeDefIndex: 9834
{	// Methods

	// RVA: 0x59DAB0 Offset: 0x59CEB0 VA: 0x18059DAB0
	public void .ctor() { }

}

private sealed class Climate.<>c__DisplayClass87_0 // TypeDefIndex: 9835
{	// Fields
	public WeatherPresetType type; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5A3560 Offset: 0x5A2960 VA: 0x1805A3560
	internal bool <CacheWeatherPresets>b__0(WeatherPreset x) { }

}

