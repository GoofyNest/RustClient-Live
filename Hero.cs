public class Hero // TypeDefIndex: 6211
{
	[CompilerGeneratedAttribute]
	private string <Ident>k__BackingField;
	[CompilerGeneratedAttribute]
	private string <MediaUrl>k__BackingField;
	[CompilerGeneratedAttribute]
	private string <TitleText>k__BackingField;
	[CompilerGeneratedAttribute]
	private string <ActionText>k__BackingField;
	[CompilerGeneratedAttribute]
	private string <TargetUrl>k__BackingField;
	[CompilerGeneratedAttribute]
	private string <Conditions>k__BackingField;
	[CompilerGeneratedAttribute]
	private double <Chance>k__BackingField;

	public string Ident { get; set; }
	public string MediaUrl { get; set; }
	public string TitleText { get; set; }
	public string ActionText { get; set; }
	public string TargetUrl { get; set; }
	public string Conditions { get; set; }
	public double Chance { get; set; }


	[CompilerGeneratedAttribute]
	public string get_Ident() { }

	[CompilerGeneratedAttribute]
	public void set_Ident(string value) { }

	[CompilerGeneratedAttribute]
	public string get_MediaUrl() { }

	[CompilerGeneratedAttribute]
	public void set_MediaUrl(string value) { }

	[CompilerGeneratedAttribute]
	public string get_TitleText() { }

	[CompilerGeneratedAttribute]
	public void set_TitleText(string value) { }

	[CompilerGeneratedAttribute]
	public string get_ActionText() { }

	[CompilerGeneratedAttribute]
	public void set_ActionText(string value) { }

	[CompilerGeneratedAttribute]
	public string get_TargetUrl() { }

	[CompilerGeneratedAttribute]
	public void set_TargetUrl(string value) { }

	[CompilerGeneratedAttribute]
	public string get_Conditions() { }

	[CompilerGeneratedAttribute]
	public void set_Conditions(string value) { }

	[CompilerGeneratedAttribute]
	public double get_Chance() { }

	[CompilerGeneratedAttribute]
	public void set_Chance(double value) { }

	public void .ctor() { }

}

public class Hero : ConsoleSystem // TypeDefIndex: 13749
{
	[ClientVar]
	public static string ident;
	[ClientVar]
	public static string video;
	[ClientVar]
	public static string title;
	[ClientVar]
	public static string action;
	[ClientVar]
	public static string url;

	public static string CookieName { get; }


	public static string get_CookieName() { }

	[ClientVar]
	public static void Show(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class Hero : SingletonComponent<Hero> // TypeDefIndex: 13918
{
	public CanvasGroup CanvasGroup;
	public Video VideoPlayer;
	public RustText TitleText;
	public RustText ButtonText;
	public HttpImage TitleImage;
	[HeaderAttribute]
	public RustButton ItemStoreButton;
	public RustButton LimitedTabButton;
	public RustButton GeneralTabButton;
	private bool canShowHero;


	public void Roll() { }

	[AsyncStateMachineAttribute]
	public Task ShowAsync() { }

	public void ClickHide() { }

	public void MarkAsSeen() { }

	public void ClickEnter() { }

	public void Hide() { }

	public void OnMenuHidden() { }

	public void .ctor() { }

}

private sealed class Hero.<>c // TypeDefIndex: 13919
{
	public static readonly Hero.<>c <>9;
	public static Func<Hero, Guid> <>9__9_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal Guid <Roll>

}

private struct Hero.<ShowAsync>d__10 : IAsyncStateMachine // TypeDefIndex: 13920
{
	public int <>1__state;
	public AsyncTaskMethodBuilder <>t__builder;
	public Hero <>4__this;
	private string <filename>5__2;
	private bool <hasImageTitle>5__3;
	private TaskAwaiter<string> <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

