public class VoicemailDialog : MonoBehaviour // TypeDefIndex: 10900
{	public GameObject RecordingRoot; // 0x18
	public RustSlider RecordingProgress; // 0x20
	public GameObject BrowsingRoot; // 0x28
	public PhoneDialler ParentDialler; // 0x30
	public GameObjectRef VoicemailEntry; // 0x38
	public Transform VoicemailEntriesRoot; // 0x40
	public GameObject NoVoicemailRoot; // 0x48
	public GameObject NoCassetteRoot; // 0x50
	private static float endTime; // 0x0
	private float duration; // 0x58
	private List<VoicemailEntry> toRetire; // 0x60

	public static bool IsRecordingVoicemail { get; }


	public static bool get_IsRecordingVoicemail() { }

	public void ShowRecordingDialog(float recordingTime) { }

	public void ShowBrowsingDialog(List<VoicemailEntry> ids, int maxVoicemail) { }

	private void Update() { }

	public void CloseDialog() { }

	public void StopPlayingAllVoicemails(VoicemailEntry exceptFor) { }

	public void OnDeletedVoicemail(VoicemailEntry entry) { }

	public void .ctor() { }

	private static void .cctor() { }

}

