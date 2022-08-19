public class VoicemailDialog : MonoBehaviour // TypeDefIndex: 10900
{	// Fields
	public GameObject RecordingRoot; // 0x18
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

	// Properties
	public static bool IsRecordingVoicemail { get; }

	// Methods

	// RVA: 0x7E2C90 Offset: 0x7E2090 VA: 0x1807E2C90
	public static bool get_IsRecordingVoicemail() { }

	// RVA: 0x7E2860 Offset: 0x7E1C60 VA: 0x1807E2860
	public void ShowRecordingDialog(float recordingTime) { }

	// RVA: 0x7E2490 Offset: 0x7E1890 VA: 0x1807E2490
	public void ShowBrowsingDialog(List<VoicemailEntry> ids, int maxVoicemail) { }

	// RVA: 0x7E2A90 Offset: 0x7E1E90 VA: 0x1807E2A90
	private void Update() { }

	// RVA: 0x7E2310 Offset: 0x7E1710 VA: 0x1807E2310
	public void CloseDialog() { }

	// RVA: 0x7E2940 Offset: 0x7E1D40 VA: 0x1807E2940
	public void StopPlayingAllVoicemails(VoicemailEntry exceptFor) { }

	// RVA: 0x7E23B0 Offset: 0x7E17B0 VA: 0x1807E23B0
	public void OnDeletedVoicemail(VoicemailEntry entry) { }

	// RVA: 0x7E2C20 Offset: 0x7E2020 VA: 0x1807E2C20
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

