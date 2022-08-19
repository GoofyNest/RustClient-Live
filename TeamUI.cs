public class TeamUI : MonoBehaviour // TypeDefIndex: 11231
{	// Fields
	public static Translate.Phrase invitePhrase; // 0x0
	public RectTransform MemberPanel; // 0x18
	public GameObject memberEntryPrefab; // 0x20
	public TeamMemberElement[] elements; // 0x28
	public GameObject NoTeamPanel; // 0x30
	public GameObject TeamPanel; // 0x38
	public GameObject LeaveTeamButton; // 0x40
	public GameObject InviteAcceptPanel; // 0x48
	public TextMeshProUGUI inviteText; // 0x50
	public static bool dirty; // 0x8
	public static ulong pendingTeamID; // 0x10
	public static string pendingTeamLeaderName; // 0x18

	// Methods

	// RVA: 0x7A7700 Offset: 0x7A6B00 VA: 0x1807A7700
	public void Update() { }

	// RVA: 0x7A7510 Offset: 0x7A6910 VA: 0x1807A7510
	public void LeaveTeamClicked() { }

	// RVA: 0x7A7480 Offset: 0x7A6880 VA: 0x1807A7480
	public void CreateTeam() { }

	// RVA: 0x7A7320 Offset: 0x7A6720 VA: 0x1807A7320
	public void AcceptJoin() { }

	// RVA: 0x7A75A0 Offset: 0x7A69A0 VA: 0x1807A75A0
	public void RejectJoin() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x7A7D70 Offset: 0x7A7170 VA: 0x1807A7D70
	private static void .cctor() { }

}

