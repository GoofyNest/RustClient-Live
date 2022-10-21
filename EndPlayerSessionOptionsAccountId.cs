public struct EndPlayerSessionOptionsAccountId // TypeDefIndex: 9038
{
	private MetricsAccountIdType m_AccountIdType; 
	private EpicAccountId m_Epic; 
	private Utf8String m_External; 

	public MetricsAccountIdType AccountIdType { get; set; }
	public EpicAccountId Epic { get; set; }
	public Utf8String External { get; set; }


	public MetricsAccountIdType get_AccountIdType() { }

	private void set_AccountIdType(MetricsAccountIdType value) { }

	public EpicAccountId get_Epic() { }

	public void set_Epic(EpicAccountId value) { }

	public Utf8String get_External() { }

	public void set_External(Utf8String value) { }

	public static EndPlayerSessionOptionsAccountId op_Implicit(EpicAccountId value) { }

	public static EndPlayerSessionOptionsAccountId op_Implicit(Utf8String value) { }

	public static EndPlayerSessionOptionsAccountId op_Implicit(string value) { }

	internal void Set(ref EndPlayerSessionOptionsAccountIdInternal other) { }

}

