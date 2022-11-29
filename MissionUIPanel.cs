public class MissionUIPanel : MonoBehaviour // TypeDefIndex: 11964
{
	public GameObject activeMissionParent; 
	public RustText missionTitleText; 
	public RustText missionDescText; 
	public VirtualItemIcon[] rewardIcons; 
	public Translate.Phrase noMissionText; 
	private static MissionUIPanel instance; 
	private bool dirty; 


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

