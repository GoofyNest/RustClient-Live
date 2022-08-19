internal class CompositeLoadAssetsResult : LoadAssetsResult // TypeDefIndex: 6657
{	// Fields
	private readonly List<LoadAssetsResult> _loads; // 0x20

	// Properties
	public override int TotalCount { get; }
	public override int CompletedCount { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x22B7AD0 Offset: 0x22B6ED0 VA: 0x1822B7AD0
	public void .ctor(List<LoadAssetsResult> loads) { }

	// RVA: 0x22B7EC0 Offset: 0x22B72C0 VA: 0x1822B7EC0 Slot: 8
	public override int get_TotalCount() { }

	// RVA: 0x22B7DC0 Offset: 0x22B71C0 VA: 0x1822B7DC0 Slot: 9
	public override int get_CompletedCount() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected override void set_CompletedCount(int value) { }

	// RVA: 0x22B7FC0 Offset: 0x22B73C0 VA: 0x1822B7FC0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22B7810 Offset: 0x22B6C10 VA: 0x1822B7810 Slot: 11
	public override Dictionary<string, Object> GetResult() { }

	// RVA: 0x22B7770 Offset: 0x22B6B70 VA: 0x1822B7770
	private void AssetLoadedHandler(string assetPath, Object obj) { }

}

private sealed class CompositeLoadAssetsResult.<>c // TypeDefIndex: 6658
{	// Fields
	public static readonly CompositeLoadAssetsResult.<>c <>9; // 0x0
	public static Func<LoadAssetsResult, int> <>9__3_0; // 0x8
	public static Func<LoadAssetsResult, int> <>9__5_0; // 0x10
	public static Func<LoadAssetsResult, bool> <>9__8_0; // 0x18

	// Methods

	// RVA: 0x22B90D0 Offset: 0x22B84D0 VA: 0x1822B90D0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x180F980 Offset: 0x180ED80 VA: 0x18180F980
	internal int <get_TotalCount>b__3_0(LoadAssetsResult l) { }

	// RVA: 0x22B8C90 Offset: 0x22B8090 VA: 0x1822B8C90
	internal int <get_CompletedCount>b__5_0(LoadAssetsResult l) { }

	// RVA: 0x22B8CC0 Offset: 0x22B80C0 VA: 0x1822B8CC0
	internal bool <get_keepWaiting>b__8_0(LoadAssetsResult l) { }

}

