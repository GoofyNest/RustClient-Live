public class MusicManager : SingletonComponent<MusicManager>, IClientComponent // TypeDefIndex: 10736
{
	public AudioMixerGroup mixerGroup;
	public List<MusicTheme> themes;
	public MusicTheme currentTheme;
	public List<AudioSource> sources;
	public double nextMusic;
	public double nextMusicFromIntensityRaise;
	[RangeAttribute]
	public float intensity;
	public Dictionary<MusicTheme.PositionedClip, MusicManager.ClipPlaybackData> clipPlaybackData;
	public int holdIntensityUntilBar;
	public bool musicPlaying;
	public bool loadingFirstClips;
	public MusicTheme nextTheme;
	public double lastClipUpdate;
	public float clipUpdateInterval;
	public double themeStartTime;
	public int lastActiveClipRefresh;
	public int activeClipRefreshInterval;
	public bool forceThemeChange;
	public float randomIntensityJumpChance;
	public int clipScheduleBarsEarly;
	public List<MusicTheme.PositionedClip> activeClips;
	public List<MusicTheme.PositionedClip> activeMusicClips;
	public List<MusicTheme.PositionedClip> activeControlClips;
	public List<MusicZone> currentMusicZones;
	public int currentBar;
	public int barOffset;
	private AudioSource syncSource;
	private bool needsResync;
	private int fadingClipCount;
	private MusicClipLoader clipLoader;
	private List<MusicTheme> validThemes;

	public double currentThemeTime { get; }
	public int themeBar { get; }


	public double get_currentThemeTime() { }

	public int get_themeBar() { }

	protected override void Awake() { }

	public void StartMusic() { }

	public MusicTheme GetThemeToPlay(MusicZone currentMusicZone) { }

	private void Update() { }

	private void UpdateCurrentBar() { }

	private void DoBarJump(int offset) { }

	private void HandleMusicPlayback() { }

	private void DoClipFades() { }

	private AudioSource GetFreeAudioSource() { }

	public void ForceThemeChange(MusicTheme theme) { }

	private void DoForcedThemeChange() { }

	private void UpdateClips() { }

	private void UpdateActiveClips() { }

	private void AddActiveClipsForBar(int bar) { }

	private void UpdateControlClips() { }

	private void UpdateBarJumpClips() { }

	private void UpdateMusicClips() { }

	private void ScheduleClip(MusicTheme.PositionedClip clip) { }

	private void FadeInClip(MusicTheme.PositionedClip clip) { }

	private void FadeOutClip(MusicTheme.PositionedClip clip) { }

	private MusicManager.ClipPlaybackData GetPlaybackData(MusicTheme.PositionedClip clip) { }

	private MusicManager.ClipPlaybackData GetPlaybackData(AudioSource source) { }

	private void ResyncClips() { }

	private void CheckSyncSource() { }

	public void ShuffleThemes() { }

	public void MusicZoneEntered(MusicZone zone) { }

	public void MusicZoneExited(MusicZone zone) { }

	public MusicZone CurrentMusicZone() { }

	public static void RaiseIntensityTo(float amount, int holdLengthBars = 0) { }

	public void StopMusic() { }

	public void .ctor() { }

}

public class MusicManager.ClipPlaybackData // TypeDefIndex: 10737
{
	public AudioSource source;
	public MusicTheme.PositionedClip positionedClip;
	public bool isActive;
	public bool fadingIn;
	public bool fadingOut;
	public double fadeStarted;
	public bool needsSync;


	public void .ctor() { }

}

private sealed class MusicManager.<>c // TypeDefIndex: 10738
{
	public static readonly MusicManager.<>c <>9;
	public static Func<MusicTheme, float> <>9__60_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal float <ShuffleThemes>

}

