internal class CompositeLoadAssetsResult : LoadAssetsResult // TypeDefIndex: 6657
{
	private readonly List<LoadAssetsResult> _loads; 

public override int TotalCount { get; }
public override int CompletedCount { get; set; }
public override bool keepWaiting { get; }


public void .ctor(List<LoadAssetsResult> loads) { }

public override int get_TotalCount() { }

public override int get_CompletedCount() { }

protected override void set_CompletedCount(int value) { }

public override bool get_keepWaiting() { }

public override Dictionary<string, Object> GetResult() { }

private void AssetLoadedHandler(string assetPath, Object obj) { }

}

private sealed class CompositeLoadAssetsResult.<>c // TypeDefIndex: 6658
{
	public static readonly CompositeLoadAssetsResult.<>c <>9; 
	public static Func<LoadAssetsResult, int> <>9__3_0; 
	public static Func<LoadAssetsResult, int> <>9__5_0; 
	public static Func<LoadAssetsResult, bool> <>9__8_0; 


private static void .cctor() { }

public void .ctor() { }

internal int <get_TotalCount>b__3_0(LoadAssetsResult l) { }

internal int <get_CompletedCount>b__5_0(LoadAssetsResult l) { }

internal bool <get_keepWaiting>b__8_0(LoadAssetsResult l) { }

}

