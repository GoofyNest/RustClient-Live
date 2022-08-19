public class Claim // TypeDefIndex: 934
{	// Fields
	private string m_issuer; // 0x10
	private string m_originalIssuer; // 0x18
	private string m_type; // 0x20
	private string m_value; // 0x28
	private string m_valueType; // 0x30
	private byte[] m_userSerializationData; // 0x38
	private Dictionary<string, string> m_properties; // 0x40
	private object m_propertyLock; // 0x48
	private ClaimsIdentity m_subject; // 0x50

	// Properties
	public IDictionary<string, string> Properties { get; }
	public ClaimsIdentity Subject { get; set; }
	public string Type { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x128D040 Offset: 0x128C440 VA: 0x18128D040
	public void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	// RVA: 0x128D1F0 Offset: 0x128C5F0 VA: 0x18128D1F0
	internal void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	// RVA: 0x128D440 Offset: 0x128C840 VA: 0x18128D440
	protected void .ctor(Claim other, ClaimsIdentity subject) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x128CF70 Offset: 0x128C370 VA: 0x18128CF70
	private void OnDeserializedMethod(StreamingContext context) { }

	// RVA: 0x128D710 Offset: 0x128CB10 VA: 0x18128D710
	public IDictionary<string, string> get_Properties() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public ClaimsIdentity get_Subject() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	internal void set_Subject(ClaimsIdentity value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Type() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Value() { }

	// RVA: 0x128CF00 Offset: 0x128C300 VA: 0x18128CF00 Slot: 4
	public virtual Claim Clone(ClaimsIdentity identity) { }

	// RVA: 0x128CFD0 Offset: 0x128C3D0 VA: 0x18128CFD0 Slot: 3
	public override string ToString() { }

}

