public class CommunityEntity : PointEntity // TypeDefIndex: 10258
{
	private static Dictionary<uint, List<MaskableGraphic>> requestingTextureImages; 
	private static Dictionary<uint, CommunityEntity.CachedTexture> _textureCache; 
	private static List<GameObject> AllUi; 
	private static Dictionary<string, GameObject> UiDict; 
	public static CommunityEntity ServerInstance; 
	public static CommunityEntity ClientInstance; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] 
	public void CL_ReceiveFilePng(BaseEntity.RPCMessage msg) { }

	private static CommunityEntity.CachedTexture GetCachedTexture(uint textureId) { }

	private CommunityEntity.CachedTexture StoreCachedTexture(uint textureId, byte[] bytes) { }

	private void ApplyTextureToImage(MaskableGraphic component, uint textureID) { }

	private void ApplyCachedTextureToImage(MaskableGraphic component, CommunityEntity.CachedTexture texture) { }

	private static void UnloadTextureCache() { }

	public static void DestroyServerCreatedUI() { }

	public void SetVisible(bool b) { }

	private static void RegisterUi(GameObject go) { }

	[BaseEntity.RPC_Client] 
	public void AddUI(BaseEntity.RPCMessage msg) { }

	private GameObject FindPanel(string name) { }

	private void CreateComponents(GameObject go, Object obj) { }

	private static T ParseEnum<T>(string value, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-CommunityEntity.ParseEnum<Int32Enum>
	|-CommunityEntity.ParseEnum<TextAnchor>
	|-CommunityEntity.ParseEnum<Image.Type>
	|-CommunityEntity.ParseEnum<InputField.LineType>
	|-CommunityEntity.ParseEnum<VerticalWrapMode>
	*/

	private void GraphicComponentCreated(Graphic c, Object obj) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator LoadTextureFromWWW(RawImage c, string p) { }

	[BaseEntity.RPC_Client] 
	public void DestroyUI(BaseEntity.RPCMessage msg) { }

	private void DestroyPanel(string pnlName) { }

	public override void InitShared() { }

	public override void DestroyShared() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class CommunityEntity.Countdown : MonoBehaviour // TypeDefIndex: 10259
{
	public string command; 
	public int endTime; 
	public int startTime; 
	public int step; 
	private int sign; 
	private string tempText; 
	private Text textComponent; 


	private void Start() { }

	private void UpdateCountdown() { }

	private void End() { }

	public void .ctor() { }

}

private class CommunityEntity.FadeOut : MonoBehaviour // TypeDefIndex: 10260
{
	public float duration; 


	public void FadeOutAndDestroy() { }

	public void Kill() { }

	public void .ctor() { }

}

private class CommunityEntity.CachedTexture // TypeDefIndex: 10261
{
	public Texture2D Texture; 
	public Sprite Sprite; 


	public void Destroy() { }

	public void .ctor() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_0 // TypeDefIndex: 10262
{
	public Image c; 


	public void .ctor() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_1 // TypeDefIndex: 10263
{
	public ulong requestedSkin; 
	public CommunityEntity.<>c__DisplayClass19_0 CS$<>8__locals1; 


	public void .ctor() { }

	internal bool <CreateComponents>b__0(ItemSkinDirectory.Skin x) { }

	internal void <CreateComponents>b__1() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_2 // TypeDefIndex: 10264
{
	public string cmd; 


	public void .ctor() { }

	internal void <CreateComponents>b__2() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_3 // TypeDefIndex: 10265
{
	public string pnlName; 
	public CommunityEntity <>4__this; 


	public void .ctor() { }

	internal void <CreateComponents>b__3() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_4 // TypeDefIndex: 10266
{
	public string cmd; 


	public void .ctor() { }

	internal void <CreateComponents>b__4(string value) { }

}

private sealed class CommunityEntity.<LoadTextureFromWWW>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10267
{
	private int <>1__state; 
	private object <>2__current; 
	public string p; 
	public RawImage c; 
	private WWW <www>5__2; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

