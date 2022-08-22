public class UnreadMessages : SingletonComponent<UnreadMessages> // TypeDefIndex: 11171
{	public StyleAsset AllRead; // 0x18
	public StyleAsset Unread; // 0x20
	public RustButton Button; // 0x28
	public GameObject UnreadTextObject; // 0x30
	public RustText UnreadText; // 0x38
	public GameObject MessageList; // 0x40
	public GameObject MessageListContainer; // 0x48
	public GameObject MessageListEmpty; // 0x50
	private int lastCount; // 0x58
	private List<RustButton> createdButtons; // 0x60


	protected override void Awake() { }

	public void Frame() { }

	private void UpdateForAmount(int count) { }

	public void OpenList() { }

	public void CloseList() { }

	public void .ctor() { }

}

private sealed class UnreadMessages.<>c__DisplayClass13_0 // TypeDefIndex: 11172
{	public NoticeData info; // 0x10


	public void .ctor() { }

	internal void <OpenList>b__2() { }

}

private sealed class UnreadMessages.<>c // TypeDefIndex: 11173
{	public static readonly UnreadMessages.<>c <>9; // 0x0
	public static Func<AccountNotice, bool> <>9__13_0; // 0x8
	public static Func<AccountNotice, DateTime> <>9__13_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <OpenList>b__13_0(AccountNotice x) { }

	internal DateTime <OpenList>b__13_1(AccountNotice x) { }

}

