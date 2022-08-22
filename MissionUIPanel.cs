public class MissionUIPanel : MonoBehaviour // TypeDefIndex: 10217
{	public GameObject activeMissionParent; // 0x18
	public RustText missionTitleText; // 0x20
	public RustText missionDescText; // 0x28
	public VirtualItemIcon[] rewardIcons; // 0x30
	public Translate.Phrase noMissionText; // 0x38
	private static MissionUIPanel instance; // 0x0
	private bool dirty; // 0x40


	public void Awake() { }

	public void OnDestroy() { }

	public static void MissionsUpdated() { }

	public bool IsOpen() { }

	public void Open() { }

	public void Close() { }

	public void Clear() { }

	public void AbandonMission() { }

	public void DoUpdate() { }

	public void .ctor() { }

}

