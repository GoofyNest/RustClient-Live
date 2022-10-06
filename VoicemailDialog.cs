public class VoicemailDialog : MonoBehaviour // TypeDefIndex: 12619
{
	public GameObject RecordingRoot; 
	public RustSlider RecordingProgress; 
	public GameObject BrowsingRoot; 
	public PhoneDialler ParentDialler; 
	public GameObjectRef VoicemailEntry; 
	public Transform VoicemailEntriesRoot; 
	public GameObject NoVoicemailRoot; 
	public GameObject NoCassetteRoot; 
	private static float endTime; 
	private float duration; 
	private List<VoicemailEntry> toRetire; 

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

