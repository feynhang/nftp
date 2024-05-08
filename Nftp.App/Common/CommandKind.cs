namespace Nftp.App.Common;

public enum CommandKind
{
	/// <summary>
	/// Specified user to login server
	/// </summary>
	User,
	/// <summary>
	/// Send password to server
	/// </summary>
	Pass,
	/// <summary>
	/// account
	/// </summary>
	Acct,
	Cwd,
	Cdup,
	Smnt,

}


public enum TypeKind
{
	A, // ASCII
	E, // EBCDIC
	N, // Non-print
	T, // Telnet format effectors
	C, // Carriage Control (ASA)
	I, // Image
	L  // with byte size argument, represent local-byte Byte size.
}