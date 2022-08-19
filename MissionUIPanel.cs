public class MissionUIPanel : MonoBehaviour // TypeDefIndex: 10217
{	// Fields
	public GameObject activeMissionParent; // 0x18
	public RustText missionTitleText; // 0x20
	public RustText missionDescText; // 0x28
	public VirtualItemIcon[] rewardIcons; // 0x30
	public Translate.Phrase noMissionText; // 0x38
	private static MissionUIPanel instance; // 0x0
	private bool dirty; // 0x40

	// Methods

	// RVA: 0x766230 Offset: 0x765630 VA: 0x180766230
	public void Awake() { }

	// RVA: 0x766A40 Offset: 0x765E40 VA: 0x180766A40
	public void OnDestroy() { }

	// RVA: 0x7667F0 Offset: 0x765BF0 VA: 0x1807667F0
	public static void MissionsUpdated() { }

	// RVA: 0x7667C0 Offset: 0x765BC0 VA: 0x1807667C0
	public bool IsOpen() { }

	// RVA: 0x766AD0 Offset: 0x765ED0 VA: 0x180766AD0
	public void Open() { }

	// RVA: 0x4E2D90 Offset: 0x4E2190 VA: 0x1804E2D90
	public void Close() { }

	// RVA: 0x766280 Offset: 0x765680 VA: 0x180766280
	public void Clear() { }

	// RVA: 0x766120 Offset: 0x765520 VA: 0x180766120
	public void AbandonMission() { }

	// RVA: 0x766390 Offset: 0x765790 VA: 0x180766390
	public void DoUpdate() { }

	// RVA: 0x766C20 Offset: 0x766020 VA: 0x180766C20
	public void .ctor() { }

}

