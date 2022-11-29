public class UnreadMessages : SingletonComponent<UnreadMessages> // TypeDefIndex: 12953
{
	public StyleAsset AllRead; 
	public StyleAsset Unread; 
	public RustButton Button; 
	public GameObject UnreadTextObject; 
	public RustText UnreadText; 
	public GameObject MessageList; 
	public GameObject MessageListContainer; 
	public GameObject MessageListEmpty; 
	private int lastCount; 
	private List<RustButton> createdButtons; 


	protected override void Awake() { }

	public void Frame() { }

	private void UpdateForAmount(int count) { }

	public void OpenList() { }

	public void CloseList() { }

	public void .ctor() { }

}

private sealed class UnreadMessages.<>c__DisplayClass13_0 // TypeDefIndex: 12954
{
	public NoticeData info; 


	public void .ctor() { }

	internal void <OpenList>

}

private sealed class UnreadMessages.<>c // TypeDefIndex: 12955
{
	public static readonly UnreadMessages.<>c <>9; 
	public static Func<AccountNotice, bool> <>9__13_0; 
	public static Func<AccountNotice, DateTime> <>9__13_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <OpenList>

	internal DateTime <OpenList>

}

