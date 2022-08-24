public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 2902
{
	private static readonly HeaderInfoTable HInfo; 
	private string[] m_CommonHeaders; 
	private int m_NumCommonHeaders; 
	private static readonly string[] s_CommonHeaderNames; 
	private static readonly sbyte[] s_CommonHeaderHints; 
	private NameValueCollection m_InnerCollection; 
	private WebHeaderCollectionType m_Type; 
	private static readonly char[] HttpTrimCharacters; 
	private static WebHeaderCollection.RfcChar[] RfcCharMap; 

private NameValueCollection InnerCollection { get; }
private bool AllowHttpRequestHeader { get; }
public string Item { get; set; }
public override int Count { get; }
public override string[] AllKeys { get; }


private void NormalizeCommonHeaders() { }

private NameValueCollection get_InnerCollection() { }

internal static bool AllowMultiValues(string name) { }

private bool get_AllowHttpRequestHeader() { }

public string get_Item(HttpRequestHeader header) { }

public void set_Item(HttpRequestHeader header, string value) { }

public void Remove(HttpRequestHeader header) { }

internal void AddInternal(string name, string value) { }

internal void ChangeInternal(string name, string value) { }

internal void RemoveInternal(string name) { }

internal void CheckUpdate(string name, string value) { }

internal static string CheckBadChars(string name, bool isHeaderValue) { }

internal static bool ContainsNonAsciiChars(string token) { }

internal void ThrowOnRestrictedHeader(string headerName) { }

public override void Add(string name, string value) { }

public void Add(string header) { }

public override void Set(string name, string value) { }

internal void SetInternal(string name, string value) { }

public override void Remove(string name) { }

public override string[] GetValues(string header) { }

public override string ToString() { }

internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

public void .ctor() { }

internal void .ctor(WebHeaderCollectionType type) { }

protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

public override void OnDeserialization(object sender) { }

public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

public override string Get(string name) { }

public override IEnumerator GetEnumerator() { }

public override int get_Count() { }

public override string Get(int index) { }

public override string[] GetValues(int index) { }

public override string GetKey(int index) { }

public override string[] get_AllKeys() { }

private static void .cctor() { }

}

private enum WebHeaderCollection.RfcChar // TypeDefIndex: 2903
{
	public byte value__; 
public const WebHeaderCollection.RfcChar High = 0;
public const WebHeaderCollection.RfcChar Reg = 1;
public const WebHeaderCollection.RfcChar Ctl = 2;
public const WebHeaderCollection.RfcChar CR = 3;
public const WebHeaderCollection.RfcChar LF = 4;
public const WebHeaderCollection.RfcChar WS = 5;
public const WebHeaderCollection.RfcChar Colon = 6;
public const WebHeaderCollection.RfcChar Delim = 7;

}

