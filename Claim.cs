public class Claim // TypeDefIndex: 934
{
	private string m_issuer; 
	private string m_originalIssuer; 
	private string m_type; 
	private string m_value; 
	private string m_valueType; 
	private byte[] m_userSerializationData; 
	private Dictionary<string, string> m_properties; 
	private object m_propertyLock; 
	private ClaimsIdentity m_subject; 

public IDictionary<string, string> Properties { get; }
public ClaimsIdentity Subject { get; set; }
public string Type { get; }
public string Value { get; }


public void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

internal void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

protected void .ctor(Claim other, ClaimsIdentity subject) { }

	[OnDeserializedAttribute] 
private void OnDeserializedMethod(StreamingContext context) { }

public IDictionary<string, string> get_Properties() { }

public ClaimsIdentity get_Subject() { }

internal void set_Subject(ClaimsIdentity value) { }

public string get_Type() { }

public string get_Value() { }

public virtual Claim Clone(ClaimsIdentity identity) { }

public override string ToString() { }

}

