public class CommunityEntity : PointEntity // TypeDefIndex: 8551
{	// Fields
	private static Dictionary<uint, List<MaskableGraphic>> requestingTextureImages; // 0x0
	private static Dictionary<uint, CommunityEntity.CachedTexture> _textureCache; // 0x8
	private static List<GameObject> AllUi; // 0x10
	private static Dictionary<string, GameObject> UiDict; // 0x18
	public static CommunityEntity ServerInstance; // 0x20
	public static CommunityEntity ClientInstance; // 0x28

	// Methods

	// RVA: 0x59A450 Offset: 0x599850 VA: 0x18059A450 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x598520 Offset: 0x597920 VA: 0x180598520
	public void CL_ReceiveFilePng(BaseEntity.RPCMessage msg) { }

	// RVA: 0x59A1C0 Offset: 0x5995C0 VA: 0x18059A1C0
	private static CommunityEntity.CachedTexture GetCachedTexture(uint textureId) { }

	// RVA: 0x59B050 Offset: 0x59A450 VA: 0x18059B050
	private CommunityEntity.CachedTexture StoreCachedTexture(uint textureId, byte[] bytes) { }

	// RVA: 0x598280 Offset: 0x597680 VA: 0x180598280
	private void ApplyTextureToImage(MaskableGraphic component, uint textureID) { }

	// RVA: 0x598000 Offset: 0x597400 VA: 0x180598000
	private void ApplyCachedTextureToImage(MaskableGraphic component, CommunityEntity.CachedTexture texture) { }

	// RVA: 0x59B1D0 Offset: 0x59A5D0 VA: 0x18059B1D0
	private static void UnloadTextureCache() { }

	// RVA: 0x599DA0 Offset: 0x5991A0 VA: 0x180599DA0
	public static void DestroyServerCreatedUI() { }

	// RVA: 0x59AFA0 Offset: 0x59A3A0 VA: 0x18059AFA0
	public void SetVisible(bool b) { }

	// RVA: 0x59AEE0 Offset: 0x59A2E0 VA: 0x18059AEE0
	private static void RegisterUi(GameObject go) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x597860 Offset: 0x596C60 VA: 0x180597860
	public void AddUI(BaseEntity.RPCMessage msg) { }

	// RVA: 0x59A0B0 Offset: 0x5994B0 VA: 0x18059A0B0
	private GameObject FindPanel(string name) { }

	// RVA: 0x5987E0 Offset: 0x597BE0 VA: 0x1805987E0
	private void CreateComponents(GameObject go, Object obj) { }

	// RVA: -1 Offset: -1
	private static T ParseEnum<T>(string value, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4BF0 Offset: 0x5E3FF0 VA: 0x1805E4BF0
	|-CommunityEntity.ParseEnum<Int32Enum>
	|-CommunityEntity.ParseEnum<TextAnchor>
	|-CommunityEntity.ParseEnum<Image.Type>
	|-CommunityEntity.ParseEnum<InputField.LineType>
	|-CommunityEntity.ParseEnum<VerticalWrapMode>
	*/

	// RVA: 0x59A250 Offset: 0x599650 VA: 0x18059A250
	private void GraphicComponentCreated(Graphic c, Object obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xAA050 Offset: 0xA9450 VA: 0x1800AA050
	// RVA: 0x59A3C0 Offset: 0x5997C0 VA: 0x18059A3C0
	private IEnumerator LoadTextureFromWWW(RawImage c, string p) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x59A060 Offset: 0x599460 VA: 0x18059A060
	public void DestroyUI(BaseEntity.RPCMessage msg) { }

	// RVA: 0x599C00 Offset: 0x599000 VA: 0x180599C00
	private void DestroyPanel(string pnlName) { }

	// RVA: 0x59A310 Offset: 0x599710 VA: 0x18059A310 Slot: 28
	public override void InitShared() { }

	// RVA: 0x599FB0 Offset: 0x5993B0 VA: 0x180599FB0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x59B4B0 Offset: 0x59A8B0 VA: 0x18059B4B0
	public void .ctor() { }

	// RVA: 0x59B360 Offset: 0x59A760 VA: 0x18059B360
	private static void .cctor() { }

}

private class CommunityEntity.Countdown : MonoBehaviour // TypeDefIndex: 8552
{	// Fields
	public string command; // 0x18
	public int endTime; // 0x20
	public int startTime; // 0x24
	public int step; // 0x28
	private int sign; // 0x2C
	private string tempText; // 0x30
	private Text textComponent; // 0x38

	// Methods

	// RVA: 0x59D200 Offset: 0x59C600 VA: 0x18059D200
	private void Start() { }

	// RVA: 0x59D370 Offset: 0x59C770 VA: 0x18059D370
	private void UpdateCountdown() { }

	// RVA: 0x59D120 Offset: 0x59C520 VA: 0x18059D120
	private void End() { }

	// RVA: 0x59D470 Offset: 0x59C870 VA: 0x18059D470
	public void .ctor() { }

}

private class CommunityEntity.FadeOut : MonoBehaviour // TypeDefIndex: 8553
{	// Fields
	public float duration; // 0x18

	// Methods

	// RVA: 0x59D540 Offset: 0x59C940 VA: 0x18059D540
	public void FadeOutAndDestroy() { }

	// RVA: 0x59D620 Offset: 0x59CA20 VA: 0x18059D620
	public void Kill() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private class CommunityEntity.CachedTexture // TypeDefIndex: 8554
{	// Fields
	public Texture2D Texture; // 0x10
	public Sprite Sprite; // 0x18

	// Methods

	// RVA: 0x589350 Offset: 0x588750 VA: 0x180589350
	public void Destroy() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_0 // TypeDefIndex: 8555
{	// Fields
	public Image c; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_1 // TypeDefIndex: 8556
{	// Fields
	public ulong requestedSkin; // 0x10
	public CommunityEntity.<>c__DisplayClass19_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0A30 Offset: 0x4AFE30 VA: 0x1804B0A30
	internal bool <CreateComponents>b__0(ItemSkinDirectory.Skin x) { }

	// RVA: 0x5A33D0 Offset: 0x5A27D0 VA: 0x1805A33D0
	internal void <CreateComponents>b__1() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_2 // TypeDefIndex: 8557
{	// Fields
	public string cmd; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5A3480 Offset: 0x5A2880 VA: 0x1805A3480
	internal void <CreateComponents>b__2() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_3 // TypeDefIndex: 8558
{	// Fields
	public string pnlName; // 0x10
	public CommunityEntity <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5A3490 Offset: 0x5A2890 VA: 0x1805A3490
	internal void <CreateComponents>b__3() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_4 // TypeDefIndex: 8559
{	// Fields
	public string cmd; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5A34C0 Offset: 0x5A28C0 VA: 0x1805A34C0
	internal void <CreateComponents>b__4(string value) { }

}

private sealed class CommunityEntity.<LoadTextureFromWWW>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8560
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string p; // 0x20
	public RawImage c; // 0x28
	private WWW <www>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x5A0E10 Offset: 0x5A0210 VA: 0x1805A0E10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5A1230 Offset: 0x5A0630 VA: 0x1805A1230 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

