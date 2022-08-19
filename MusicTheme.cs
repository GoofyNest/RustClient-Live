public class MusicTheme : ScriptableObject // TypeDefIndex: 9007
{	// Fields
	[HeaderAttribute] // RVA: 0xCA4C0 Offset: 0xC98C0 VA: 0x1800CA4C0
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

	// Properties
	public int layerCount { get; }
	public int samplesPerBar { get; }

	// Methods

	// RVA: 0x7C0870 Offset: 0x7BFC70 VA: 0x1807C0870
	public int get_layerCount() { }

	// RVA: 0x7C08B0 Offset: 0x7BFCB0 VA: 0x1807C08B0
	public int get_samplesPerBar() { }

	// RVA: 0x7C0030 Offset: 0x7BF430 VA: 0x1807C0030
	private void OnValidate() { }

	// RVA: 0x7BFEE0 Offset: 0x7BF2E0 VA: 0x1807BFEE0
	public List<MusicTheme.PositionedClip> GetActiveClipsForBar(int bar) { }

	// RVA: 0x7BFAA0 Offset: 0x7BEEA0 VA: 0x1807BFAA0
	private int ActiveClipCollectionID(int bar) { }

	// RVA: 0x7BFFC0 Offset: 0x7BF3C0 VA: 0x1807BFFC0
	public MusicTheme.Layer LayerById(int id) { }

	// RVA: 0x7BFB10 Offset: 0x7BEF10 VA: 0x1807BFB10
	public void AddLayer() { }

	// RVA: 0x7C0560 Offset: 0x7BF960 VA: 0x1807C0560
	private void UpdateLengthInBars() { }

	// RVA: 0x7BFC00 Offset: 0x7BF000 VA: 0x1807BFC00
	public bool CanPlayInEnvironment(int currentBiome, int currentTopology, float currentRain, float currentSnow, float currentWind) { }

	// RVA: 0x7BFE30 Offset: 0x7BF230 VA: 0x1807BFE30
	public bool FirstClipsLoaded() { }

	// RVA: 0x7BFDD0 Offset: 0x7BF1D0 VA: 0x1807BFDD0
	public bool ContainsAudioClip(AudioClip clip) { }

	// RVA: 0x7C0660 Offset: 0x7BFA60 VA: 0x1807C0660
	public void .ctor() { }

}

public class MusicTheme.Layer // TypeDefIndex: 9008
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x7B3480 Offset: 0x7B2880 VA: 0x1807B3480
	public void .ctor() { }

}

public class MusicTheme.PositionedClip // TypeDefIndex: 9009
{	// Fields
	public MusicTheme theme; // 0x10
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

	// Properties
	public int endingBar { get; }
	public bool isControlClip { get; }

	// Methods

	// RVA: 0x7CC9B0 Offset: 0x7CBDB0 VA: 0x1807CC9B0
	public int get_endingBar() { }

	// RVA: 0x7CC840 Offset: 0x7CBC40 VA: 0x1807CC840
	public bool CanPlay(float intensity) { }

	// RVA: 0x7CCA40 Offset: 0x7CBE40 VA: 0x1807CCA40
	public bool get_isControlClip() { }

	// RVA: 0x7CC870 Offset: 0x7CBC70 VA: 0x1807CC870
	public void CopySettingsFrom(MusicTheme.PositionedClip otherClip) { }

	// RVA: 0x7CC980 Offset: 0x7CBD80 VA: 0x1807CC980
	public void .ctor() { }

}

public class MusicTheme.ValueRange // TypeDefIndex: 9010
{	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x7CDEB0 Offset: 0x7CD2B0 VA: 0x1807CDEB0
	public void .ctor(float min, float max) { }

}

