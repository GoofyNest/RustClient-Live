public class UnreadMessages : SingletonComponent<UnreadMessages> // TypeDefIndex: 11171
{	// Fields
	public StyleAsset AllRead; // 0x18
	public StyleAsset Unread; // 0x20
	public RustButton Button; // 0x28
	public GameObject UnreadTextObject; // 0x30
	public RustText UnreadText; // 0x38
	public GameObject MessageList; // 0x40
	public GameObject MessageListContainer; // 0x48
	public GameObject MessageListEmpty; // 0x50
	private int lastCount; // 0x58
	private List<RustButton> createdButtons; // 0x60

	// Methods

	// RVA: 0x112DFF0 Offset: 0x112D3F0 VA: 0x18112DFF0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x112E070 Offset: 0x112D470 VA: 0x18112E070
	public void Frame() { }

	// RVA: 0x112ED20 Offset: 0x112E120 VA: 0x18112ED20
	private void UpdateForAmount(int count) { }

	// RVA: 0x112E230 Offset: 0x112D630 VA: 0x18112E230
	public void OpenList() { }

	// RVA: 0x112E040 Offset: 0x112D440 VA: 0x18112E040
	public void CloseList() { }

	// RVA: 0x112EE60 Offset: 0x112E260 VA: 0x18112EE60
	public void .ctor() { }

}

private sealed class UnreadMessages.<>c__DisplayClass13_0 // TypeDefIndex: 11172
{	// Fields
	public NoticeData info; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1122B30 Offset: 0x1121F30 VA: 0x181122B30
	internal void <OpenList>b__2() { }

}

private sealed class UnreadMessages.<>c // TypeDefIndex: 11173
{	// Fields
	public static readonly UnreadMessages.<>c <>9; // 0x0
	public static Func<AccountNotice, bool> <>9__13_0; // 0x8
	public static Func<AccountNotice, DateTime> <>9__13_1; // 0x10

	// Methods

	// RVA: 0x1122B80 Offset: 0x1121F80 VA: 0x181122B80
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1122B10 Offset: 0x1121F10 VA: 0x181122B10
	internal bool <OpenList>b__13_0(AccountNotice x) { }

	// RVA: 0x936440 Offset: 0x935840 VA: 0x180936440
	internal DateTime <OpenList>b__13_1(AccountNotice x) { }

}

