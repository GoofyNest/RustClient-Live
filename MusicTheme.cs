public class MusicTheme : ScriptableObject // TypeDefIndex: 9007
{	[HeaderAttribute] // RVA: 0xCA4C0 Offset: 0xC98C0 VA: 0x1800CA4C0
	public float tempo; // 0x18
	public int intensityHoldBars; // 0x1C
	public int lengthInBars; // 0x20
	[HeaderAttribute] // RVA: 0xCA520 Offset: 0xC9920 VA: 0x1800CA520
	public bool canPlayInMenus; // 0x24
	[HorizontalAttribute] // RVA: 0xC8DE0 Offset: 0xC81E0 VA: 0x1800C8DE0
	public MusicTheme.ValueRange rain; // 0x28
	[HorizontalAttribute] // RVA: 0xC8DE0 Offset: 0xC81E0 VA: 0x1800C8DE0
	public MusicTheme.ValueRange wind; // 0x30
	[HorizontalAttribute] // RVA: 0xC8DE0 Offset: 0xC81E0 VA: 0x1800C8DE0
	public MusicTheme.ValueRange snow; // 0x38
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainBiome.Enum biomes; // 0x40
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainTopology.Enum topologies; // 0x44
	public AnimationCurve time; // 0x48
	[HeaderAttribute] // RVA: 0xCA9B0 Offset: 0xC9DB0 VA: 0x1800CA9B0
	public List<MusicTheme.PositionedClip> clips; // 0x50
	public List<MusicTheme.Layer> layers; // 0x58
	private Dictionary<int, List<MusicTheme.PositionedClip>> activeClips; // 0x60
	private List<AudioClip> firstAudioClips; // 0x68
	private Dictionary<AudioClip, bool> audioClipDict; // 0x70

	public int layerCount { get; }
	public int samplesPerBar { get; }


	public int get_layerCount() { }

	public int get_samplesPerBar() { }

	private void OnValidate() { }

	public List<MusicTheme.PositionedClip> GetActiveClipsForBar(int bar) { }

	private int ActiveClipCollectionID(int bar) { }

	public MusicTheme.Layer LayerById(int id) { }

	public void AddLayer() { }

	private void UpdateLengthInBars() { }

	public bool CanPlayInEnvironment(int currentBiome, int currentTopology, float currentRain, float currentSnow, float currentWind) { }

	public bool FirstClipsLoaded() { }

	public bool ContainsAudioClip(AudioClip clip) { }

	public void .ctor() { }

}

public class MusicTheme.Layer // TypeDefIndex: 9008
{	public string name; // 0x10


	public void .ctor() { }

}

public class MusicTheme.PositionedClip // TypeDefIndex: 9009
{	public MusicTheme theme; // 0x10
	public MusicClip musicClip; // 0x18
	public int startingBar; // 0x20
	public int layerId; // 0x24
	public float minIntensity; // 0x28
	public float maxIntensity; // 0x2C
	public bool allowFadeIn; // 0x30
	public bool allowFadeOut; // 0x31
	public float fadeInTime; // 0x34
	public float fadeOutTime; // 0x38
	public float intensityReduction; // 0x3C
	public int jumpBarCount; // 0x40
	public float jumpMinimumIntensity; // 0x44
	public float jumpMaximumIntensity; // 0x48

	public int endingBar { get; }
	public bool isControlClip { get; }


	public int get_endingBar() { }

	public bool CanPlay(float intensity) { }

	public bool get_isControlClip() { }

	public void CopySettingsFrom(MusicTheme.PositionedClip otherClip) { }

	public void .ctor() { }

}

public class MusicTheme.ValueRange // TypeDefIndex: 9010
{	public float min; // 0x10
	public float max; // 0x14


	public void .ctor(float min, float max) { }

}

