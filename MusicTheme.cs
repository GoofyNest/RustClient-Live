public class MusicTheme : ScriptableObject // TypeDefIndex: 9007
{
	[HeaderAttribute] 
	public float tempo; 
	public int intensityHoldBars; 
	public int lengthInBars; 
	[HeaderAttribute] 
	public bool canPlayInMenus; 
	[HorizontalAttribute] 
	public MusicTheme.ValueRange rain; 
	[HorizontalAttribute] 
	public MusicTheme.ValueRange wind; 
	[HorizontalAttribute] 
	public MusicTheme.ValueRange snow; 
	[InspectorFlagsAttribute] 
	public TerrainBiome.Enum biomes; 
	[InspectorFlagsAttribute] 
	public TerrainTopology.Enum topologies; 
	public AnimationCurve time; 
	[HeaderAttribute] 
	public List<MusicTheme.PositionedClip> clips; 
	public List<MusicTheme.Layer> layers; 
	private Dictionary<int, List<MusicTheme.PositionedClip>> activeClips; 
	private List<AudioClip> firstAudioClips; 
	private Dictionary<AudioClip, bool> audioClipDict; 

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
{
	public string name; 


	public void .ctor() { }

}

public class MusicTheme.PositionedClip // TypeDefIndex: 9009
{
	public MusicTheme theme; 
	public MusicClip musicClip; 
	public int startingBar; 
	public int layerId; 
	public float minIntensity; 
	public float maxIntensity; 
	public bool allowFadeIn; 
	public bool allowFadeOut; 
	public float fadeInTime; 
	public float fadeOutTime; 
	public float intensityReduction; 
	public int jumpBarCount; 
	public float jumpMinimumIntensity; 
	public float jumpMaximumIntensity; 

	public int endingBar { get; }
	public bool isControlClip { get; }


	public int get_endingBar() { }

	public bool CanPlay(float intensity) { }

	public bool get_isControlClip() { }

	public void CopySettingsFrom(MusicTheme.PositionedClip otherClip) { }

	public void .ctor() { }

}

public class MusicTheme.ValueRange // TypeDefIndex: 9010
{
	public float min; 
	public float max; 


	public void .ctor(float min, float max) { }

}

