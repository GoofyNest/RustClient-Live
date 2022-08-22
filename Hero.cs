public class Hero // TypeDefIndex: 6202
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Ident>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <MediaUrl>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <TitleText>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <ActionText>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <TargetUrl>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Conditions>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private double <Chance>k__BackingField; // 0x40

	public string Ident { get; set; }
	public string MediaUrl { get; set; }
	public string TitleText { get; set; }
	public string ActionText { get; set; }
	public string TargetUrl { get; set; }
	public string Conditions { get; set; }
	public double Chance { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Ident() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Ident(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_MediaUrl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_MediaUrl(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_TitleText() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_TitleText(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_ActionText() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_ActionText(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_TargetUrl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_TargetUrl(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Conditions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Conditions(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public double get_Chance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Chance(double value) { }

	public void .ctor() { }

}

public class Hero : ConsoleSystem // TypeDefIndex: 11930
{	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static string ident; // 0x0
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static string video; // 0x8
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static string title; // 0x10
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static string action; // 0x18
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static string url; // 0x20

	public static string CookieName { get; }


	public static string get_CookieName() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void Show(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class Hero : SingletonComponent<Hero> // TypeDefIndex: 12088
{	public CanvasGroup CanvasGroup; // 0x18
	public Video VideoPlayer; // 0x20
	public RustText TitleText; // 0x28
	public RustText ButtonText; // 0x30
	public HttpImage TitleImage; // 0x38
	[HeaderAttribute] // RVA: 0xD7200 Offset: 0xD6600 VA: 0x1800D7200
	public RustButton ItemStoreButton; // 0x40
	public RustButton LimitedTabButton; // 0x48
	public RustButton GeneralTabButton; // 0x50
	private bool canShowHero; // 0x58


	public void Roll() { }

	[AsyncStateMachineAttribute] // RVA: 0xD7300 Offset: 0xD6700 VA: 0x1800D7300
	public Task ShowAsync() { }

	public void ClickHide() { }

	public void MarkAsSeen() { }

	public void ClickEnter() { }

	public void Hide() { }

	public void OnMenuHidden() { }

	public void .ctor() { }

}

private sealed class Hero.<>c // TypeDefIndex: 12089
{	public static readonly Hero.<>c <>9; // 0x0
	public static Func<Hero, Guid> <>9__9_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal Guid <Roll>b__9_0(Hero x) { }

}

private struct Hero.<ShowAsync>d__10 : IAsyncStateMachine // TypeDefIndex: 12090
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Hero <>4__this; // 0x20
	private string <filename>5__2; // 0x28
	private bool <hasImageTitle>5__3; // 0x30
	private TaskAwaiter<string> <>u__1; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

