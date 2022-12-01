internal enum AsnDecodeStatus // TypeDefIndex: 2796
{
	public int value__;
	public const AsnDecodeStatus NotDecoded = -1;
	public const AsnDecodeStatus Ok = 0;
	public const AsnDecodeStatus BadAsn = 1;
	public const AsnDecodeStatus BadTag = 2;
	public const AsnDecodeStatus BadLength = 3;
	public const AsnDecodeStatus InformationNotAvailable = 4;

}

