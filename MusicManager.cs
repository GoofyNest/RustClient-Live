public class MusicManager : SingletonComponent<MusicManager>, IClientComponent // TypeDefIndex: 9004
{	public AudioMixerGroup mixerGroup; // 0x18
	public List<MusicTheme> themes; // 0x20
	public MusicTheme currentTheme; // 0x28
	public List<AudioSource> sources; // 0x30
	public double nextMusic; // 0x38
	public double nextMusicFromIntensityRaise; // 0x40
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float intensity; // 0x48
	public Dictionary<MusicTheme.PositionedClip, MusicManager.ClipPlaybackData> clipPlaybackData; // 0x50
	public int holdIntensityUntilBar; // 0x58
	public bool musicPlaying; // 0x5C
	public bool loadingFirstClips; // 0x5D
	public MusicTheme nextTheme; // 0x60
	public double lastClipUpdate; // 0x68
	public float clipUpdateInterval; // 0x70
	public double themeStartTime; // 0x78
	public int lastActiveClipRefresh; // 0x80
	public int activeClipRefreshInterval; // 0x84
	public bool forceThemeChange; // 0x88
	public float randomIntensityJumpChance; // 0x8C
	public int clipScheduleBarsEarly; // 0x90
	public List<MusicTheme.PositionedClip> activeClips; // 0x98
	public List<MusicTheme.PositionedClip> activeMusicClips; // 0xA0
	public List<MusicTheme.PositionedClip> activeControlClips; // 0xA8
	public List<MusicZone> currentMusicZones; // 0xB0
	public int currentBar; // 0xB8
	public int barOffset; // 0xBC
	private AudioSource syncSource; // 0xC0
	private bool needsResync; // 0xC8
	private int fadingClipCount; // 0xCC
	private MusicClipLoader clipLoader; // 0xD0
	private List<MusicTheme> validThemes; // 0xD8

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

public class MusicManager.ClipPlaybackData // TypeDefIndex: 9005
{	public AudioSource source; // 0x10
	public MusicTheme.PositionedClip positionedClip; // 0x18
	public bool isActive; // 0x20
	public bool fadingIn; // 0x21
	public bool fadingOut; // 0x22
	public double fadeStarted; // 0x28
	public bool needsSync; // 0x30


	public void .ctor() { }

}

private sealed class MusicManager.<>c // TypeDefIndex: 9006
{	public static readonly MusicManager.<>c <>9; // 0x0
	public static Func<MusicTheme, float> <>9__60_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal float <ShuffleThemes>b__60_0(MusicTheme x) { }

}

