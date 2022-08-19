public abstract class BaseIntegration // TypeDefIndex: 6177
{	// Properties
	public abstract string PublicKey { get; }
	public virtual string Bucket { get; }
	public virtual string UserId { get; }
	public virtual string UserName { get; }
	public virtual string ServerAddress { get; }
	public virtual string ServerName { get; }
	public virtual string LevelName { get; }
	public virtual int MinutesPlayed { get; }
	public virtual Auth Auth { get; }
	public virtual bool RestrictEditorFunctionality { get; }
	public virtual bool LocalApi { get; }
	public virtual string ApiUrl { get; }
	public virtual bool DebugOutput { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_PublicKey();

	// RVA: 0x14E0E90 Offset: 0x14E0290 VA: 0x1814E0E90 Slot: 5
	public virtual string get_Bucket() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	public virtual void OnManifestFile(Manifest manifest) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	public virtual void OnServerMetadata(Dictionary<IPEndPoint, int> metadata) { }

	// RVA: 0x14E0F80 Offset: 0x14E0380 VA: 0x1814E0F80 Slot: 8
	public virtual string get_UserId() { }

	// RVA: 0x14E0FC0 Offset: 0x14E03C0 VA: 0x1814E0FC0 Slot: 9
	public virtual string get_UserName() { }

	// RVA: 0x14E0F00 Offset: 0x14E0300 VA: 0x1814E0F00 Slot: 10
	public virtual string get_ServerAddress() { }

	// RVA: 0x14E0F40 Offset: 0x14E0340 VA: 0x1814E0F40 Slot: 11
	public virtual string get_ServerName() { }

	// RVA: 0x14E0EE0 Offset: 0x14E02E0 VA: 0x1814E0EE0 Slot: 12
	public virtual string get_LevelName() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 13
	public virtual int get_MinutesPlayed() { }

	// RVA: 0x14E0DC0 Offset: 0x14E01C0 VA: 0x1814E0DC0 Slot: 14
	public virtual Auth get_Auth() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 15
	public virtual bool get_RestrictEditorFunctionality() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 16
	public virtual bool get_LocalApi() { }

	// RVA: 0x14E0D60 Offset: 0x14E0160 VA: 0x1814E0D60 Slot: 17
	public virtual string get_ApiUrl() { }

	// RVA: 0x14E0ED0 Offset: 0x14E02D0 VA: 0x1814E0ED0 Slot: 18
	public virtual bool get_DebugOutput() { }

	// RVA: 0x14E0D30 Offset: 0x14E0130 VA: 0x1814E0D30 Slot: 19
	public virtual bool ShouldReportException(string message, string stackTrace, LogType type) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

