public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 2902
{	// Fields
	private static readonly HeaderInfoTable HInfo; // 0x0
	private string[] m_CommonHeaders; // 0x60
	private int m_NumCommonHeaders; // 0x68
	private static readonly string[] s_CommonHeaderNames; // 0x8
	private static readonly sbyte[] s_CommonHeaderHints; // 0x10
	private NameValueCollection m_InnerCollection; // 0x70
	private WebHeaderCollectionType m_Type; // 0x78
	private static readonly char[] HttpTrimCharacters; // 0x18
	private static WebHeaderCollection.RfcChar[] RfcCharMap; // 0x20

	// Properties
	private NameValueCollection InnerCollection { get; }
	private bool AllowHttpRequestHeader { get; }
	public string Item { get; set; }
	public override int Count { get; }
	public override string[] AllKeys { get; }

	// Methods

	// RVA: 0x1184DA0 Offset: 0x11841A0 VA: 0x181184DA0
	private void NormalizeCommonHeaders() { }

	// RVA: 0x1186480 Offset: 0x1185880 VA: 0x181186480
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x1183BD0 Offset: 0x1182FD0 VA: 0x181183BD0
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x1186410 Offset: 0x1185810 VA: 0x181186410
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x1186530 Offset: 0x1185930 VA: 0x181186530
	public string get_Item(HttpRequestHeader header) { }

	// RVA: 0x1186600 Offset: 0x1185A00 VA: 0x181186600
	public void set_Item(HttpRequestHeader header, string value) { }

	// RVA: 0x1184F90 Offset: 0x1184390 VA: 0x181184F90
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x1183740 Offset: 0x1182B40 VA: 0x181183740
	internal void AddInternal(string name, string value) { }

	// RVA: 0x1183C70 Offset: 0x1183070 VA: 0x181183C70
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x1184F30 Offset: 0x1184330 VA: 0x181184F30
	internal void RemoveInternal(string name) { }

	// RVA: 0x1184160 Offset: 0x1183560 VA: 0x181184160
	internal void CheckUpdate(string name, string value) { }

	// RVA: 0x1183CE0 Offset: 0x11830E0 VA: 0x181183CE0
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x1184220 Offset: 0x1183620 VA: 0x181184220
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x1185570 Offset: 0x1184970 VA: 0x181185570
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x1183A40 Offset: 0x1182E40 VA: 0x181183A40 Slot: 14
	public override void Add(string name, string value) { }

	// RVA: 0x11837B0 Offset: 0x1182BB0 VA: 0x1811837B0
	public void Add(string header) { }

	// RVA: 0x1185370 Offset: 0x1184770 VA: 0x181185370 Slot: 17
	public override void Set(string name, string value) { }

	// RVA: 0x1185180 Offset: 0x1184580 VA: 0x181185180
	internal void SetInternal(string name, string value) { }

	// RVA: 0x1185070 Offset: 0x1184470 VA: 0x181185070 Slot: 18
	public override void Remove(string name) { }

	// RVA: 0x1184710 Offset: 0x1183B10 VA: 0x181184710 Slot: 16
	public override string[] GetValues(string header) { }

	// RVA: 0x1185770 Offset: 0x1184B70 VA: 0x181185770 Slot: 3
	public override string ToString() { }

	// RVA: 0x1184290 Offset: 0x1183690 VA: 0x181184290
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x1186360 Offset: 0x1185760 VA: 0x181186360
	public void .ctor() { }

	// RVA: 0x1186280 Offset: 0x1185680 VA: 0x181186280
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x11860C0 Offset: 0x11854C0 VA: 0x1811860C0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 11
	public override void OnDeserialization(object sender) { }

	// RVA: 0x11845A0 Offset: 0x11839A0 VA: 0x1811845A0 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11832E0 Offset: 0x11826E0 VA: 0x1811832E0 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11849D0 Offset: 0x1183DD0 VA: 0x1811849D0 Slot: 15
	public override string Get(string name) { }

	// RVA: 0x11844E0 Offset: 0x11838E0 VA: 0x1811844E0 Slot: 12
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1186440 Offset: 0x1185840 VA: 0x181186440 Slot: 13
	public override int get_Count() { }

	// RVA: 0x1184980 Offset: 0x1183D80 VA: 0x181184980 Slot: 19
	public override string Get(int index) { }

	// RVA: 0x1184930 Offset: 0x1183D30 VA: 0x181184930 Slot: 20
	public override string[] GetValues(int index) { }

	// RVA: 0x1184550 Offset: 0x1183950 VA: 0x181184550 Slot: 21
	public override string GetKey(int index) { }

	// RVA: 0x11863D0 Offset: 0x11857D0 VA: 0x1811863D0 Slot: 22
	public override string[] get_AllKeys() { }

	// RVA: 0x11857D0 Offset: 0x1184BD0 VA: 0x1811857D0
	private static void .cctor() { }

}

private enum WebHeaderCollection.RfcChar // TypeDefIndex: 2903
{	// Fields
	public byte value__; // 0x0
	public const WebHeaderCollection.RfcChar High = 0;
	public const WebHeaderCollection.RfcChar Reg = 1;
	public const WebHeaderCollection.RfcChar Ctl = 2;
	public const WebHeaderCollection.RfcChar CR = 3;
	public const WebHeaderCollection.RfcChar LF = 4;
	public const WebHeaderCollection.RfcChar WS = 5;
	public const WebHeaderCollection.RfcChar Colon = 6;
	public const WebHeaderCollection.RfcChar Delim = 7;

}

