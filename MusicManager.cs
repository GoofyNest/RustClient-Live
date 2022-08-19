public class MusicManager : SingletonComponent<MusicManager>, IClientComponent // TypeDefIndex: 9004
{	// Fields
	public AudioMixerGroup mixerGroup; // 0x18
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

	// Properties
	public double currentThemeTime { get; }
	public int themeBar { get; }

	// Methods

	// RVA: 0x7BFA70 Offset: 0x7BEE70 VA: 0x1807BFA70
	public double get_currentThemeTime() { }

	// RVA: 0x7BFA90 Offset: 0x7BEE90 VA: 0x1807BFA90
	public int get_themeBar() { }

	// RVA: 0x7BC000 Offset: 0x7BB400 VA: 0x1807BC000 Slot: 6
	protected override void Awake() { }

	// RVA: 0x7BE5E0 Offset: 0x7BD9E0 VA: 0x1807BE5E0
	public void StartMusic() { }

	// RVA: 0x7BD440 Offset: 0x7BC840 VA: 0x1807BD440
	public MusicTheme GetThemeToPlay(MusicZone currentMusicZone) { }

	// RVA: 0x7BF440 Offset: 0x7BE840 VA: 0x1807BF440
	private void Update() { }

	// RVA: 0x7BF070 Offset: 0x7BE470 VA: 0x1807BF070
	private void UpdateCurrentBar() { }

	// RVA: 0x7BC490 Offset: 0x7BB890 VA: 0x1807BC490
	private void DoBarJump(int offset) { }

	// RVA: 0x7BD960 Offset: 0x7BCD60 VA: 0x1807BD960
	private void HandleMusicPlayback() { }

	// RVA: 0x7BC5F0 Offset: 0x7BB9F0 VA: 0x1807BC5F0
	private void DoClipFades() { }

	// RVA: 0x7BD020 Offset: 0x7BC420 VA: 0x1807BD020
	private AudioSource GetFreeAudioSource() { }

	// RVA: 0x7BCF90 Offset: 0x7BC390 VA: 0x1807BCF90
	public void ForceThemeChange(MusicTheme theme) { }

	// RVA: 0x7BC9B0 Offset: 0x7BBDB0 VA: 0x1807BC9B0
	private void DoForcedThemeChange() { }

	// RVA: 0x7BEDC0 Offset: 0x7BE1C0 VA: 0x1807BEDC0
	private void UpdateClips() { }

	// RVA: 0x7BEB10 Offset: 0x7BDF10 VA: 0x1807BEB10
	private void UpdateActiveClips() { }

	// RVA: 0x7BBE80 Offset: 0x7BB280 VA: 0x1807BBE80
	private void AddActiveClipsForBar(int bar) { }

	// RVA: 0x7BEF30 Offset: 0x7BE330 VA: 0x1807BEF30
	private void UpdateControlClips() { }

	// RVA: 0x7BECA0 Offset: 0x7BE0A0 VA: 0x1807BECA0
	private void UpdateBarJumpClips() { }

	// RVA: 0x7BF170 Offset: 0x7BE570 VA: 0x1807BF170
	private void UpdateMusicClips() { }

	// RVA: 0x7BE340 Offset: 0x7BD740 VA: 0x1807BE340
	private void ScheduleClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BCA50 Offset: 0x7BBE50 VA: 0x1807BCA50
	private void FadeInClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BCE20 Offset: 0x7BC220 VA: 0x1807BCE20
	private void FadeOutClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BD170 Offset: 0x7BC570 VA: 0x1807BD170
	private MusicManager.ClipPlaybackData GetPlaybackData(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BD290 Offset: 0x7BC690 VA: 0x1807BD290
	private MusicManager.ClipPlaybackData GetPlaybackData(AudioSource source) { }

	// RVA: 0x7BDF10 Offset: 0x7BD310 VA: 0x1807BDF10
	private void ResyncClips() { }

	// RVA: 0x7BC130 Offset: 0x7BB530 VA: 0x1807BC130
	private void CheckSyncSource() { }

	// RVA: 0x7BE4C0 Offset: 0x7BD8C0 VA: 0x1807BE4C0
	public void ShuffleThemes() { }

	// RVA: 0x7BDB00 Offset: 0x7BCF00 VA: 0x1807BDB00
	public void MusicZoneEntered(MusicZone zone) { }

	// RVA: 0x7BDB60 Offset: 0x7BCF60 VA: 0x1807BDB60
	public void MusicZoneExited(MusicZone zone) { }

	// RVA: 0x7BC310 Offset: 0x7BB710 VA: 0x1807BC310
	public MusicZone CurrentMusicZone() { }

	// RVA: 0x7BDBC0 Offset: 0x7BCFC0 VA: 0x1807BDBC0
	public static void RaiseIntensityTo(float amount, int holdLengthBars = 0) { }

	// RVA: 0x7BE9B0 Offset: 0x7BDDB0 VA: 0x1807BE9B0
	public void StopMusic() { }

	// RVA: 0x7BF790 Offset: 0x7BEB90 VA: 0x1807BF790
	public void .ctor() { }

}

public class MusicManager.ClipPlaybackData // TypeDefIndex: 9005
{	// Fields
	public AudioSource source; // 0x10
	public MusicTheme.PositionedClip positionedClip; // 0x18
	public bool isActive; // 0x20
	public bool fadingIn; // 0x21
	public bool fadingOut; // 0x22
	public double fadeStarted; // 0x28
	public bool needsSync; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class MusicManager.<>c // TypeDefIndex: 9006
{	// Fields
	public static readonly MusicManager.<>c <>9; // 0x0
	public static Func<MusicTheme, float> <>9__60_0; // 0x8

	// Methods

	// RVA: 0x7CDE50 Offset: 0x7CD250 VA: 0x1807CDE50
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7CCE10 Offset: 0x7CC210 VA: 0x1807CCE10
	internal float <ShuffleThemes>b__60_0(MusicTheme x) { }

}

