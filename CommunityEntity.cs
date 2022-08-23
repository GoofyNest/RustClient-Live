public class CommunityEntity : PointEntity // TypeDefIndex: 8551
{	private static Dictionary<uint, List<MaskableGraphic>> requestingTextureImages; // 0x0
	private static Dictionary<uint, CommunityEntity.CachedTexture> _textureCache; // 0x8
	private static List<GameObject> AllUi; // 0x10
	private static Dictionary<string, GameObject> UiDict; // 0x18
	public static CommunityEntity ServerInstance; // 0x20
	public static CommunityEntity ClientInstance; // 0x28


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CL_ReceiveFilePng(BaseEntity.RPCMessage msg) { }

	private static CommunityEntity.CachedTexture GetCachedTexture(uint textureId) { }

	private CommunityEntity.CachedTexture StoreCachedTexture(uint textureId, byte[] bytes) { }

	private void ApplyTextureToImage(MaskableGraphic component, uint textureID) { }

	private void ApplyCachedTextureToImage(MaskableGraphic component, CommunityEntity.CachedTexture texture) { }

	private static void UnloadTextureCache() { }

	public static void DestroyServerCreatedUI() { }

	public void SetVisible(bool b) { }

	private static void RegisterUi(GameObject go) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[IteratorStateMachineAttribute] // RVA: 0xAA050 Offset: 0xA9450 VA: 0x1800AA050
	private IEnumerator LoadTextureFromWWW(RawImage c, string p) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void DestroyUI(BaseEntity.RPCMessage msg) { }

	private void DestroyPanel(string pnlName) { }

	public override void InitShared() { }

	public override void DestroyShared() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class CommunityEntity.Countdown : MonoBehaviour // TypeDefIndex: 8552
{	public string command; // 0x18
	public int endTime; // 0x20
	public int startTime; // 0x24
	public int step; // 0x28
	private int sign; // 0x2C
	private string tempText; // 0x30
	private Text textComponent; // 0x38


	private void Start() { }

	private void UpdateCountdown() { }

	private void End() { }

	public void .ctor() { }

}

private class CommunityEntity.FadeOut : MonoBehaviour // TypeDefIndex: 8553
{	public float duration; // 0x18


	public void FadeOutAndDestroy() { }

	public void Kill() { }

	public void .ctor() { }

}

private class CommunityEntity.CachedTexture // TypeDefIndex: 8554
{	public Texture2D Texture; // 0x10
	public Sprite Sprite; // 0x18


	public void Destroy() { }

	public void .ctor() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_0 // TypeDefIndex: 8555
{	public Image c; // 0x10


	public void .ctor() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_1 // TypeDefIndex: 8556
{	public ulong requestedSkin; // 0x10
	public CommunityEntity.<>c__DisplayClass19_0 CS$<>8__locals1; // 0x18


	public void .ctor() { }

	internal bool <CreateComponents>b__0(ItemSkinDirectory.Skin x) { }

	internal void <CreateComponents>b__1() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_2 // TypeDefIndex: 8557
{	public string cmd; // 0x10


	public void .ctor() { }

	internal void <CreateComponents>b__2() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_3 // TypeDefIndex: 8558
{	public string pnlName; // 0x10
	public CommunityEntity <>4__this; // 0x18


	public void .ctor() { }

	internal void <CreateComponents>b__3() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_4 // TypeDefIndex: 8559
{	public string cmd; // 0x10


	public void .ctor() { }

	internal void <CreateComponents>b__4(string value) { }

}

private sealed class CommunityEntity.<LoadTextureFromWWW>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8560
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string p; // 0x20
	public RawImage c; // 0x28
	private WWW <www>5__2; // 0x30

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

