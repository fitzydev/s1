using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Persistence
{
	// Token: 0x0200038B RID: 907
	[Token(Token = "0x200038B")]
	public interface ISaveable
	{
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600144B RID: 5195
		[Token(Token = "0x170003D2")]
		string SaveFolderName
		{
			[Token(Token = "0x600144B")]
			get;
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600144C RID: 5196
		[Token(Token = "0x170003D3")]
		string SaveFileName
		{
			[Token(Token = "0x600144C")]
			get;
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600144D RID: 5197
		[Token(Token = "0x170003D4")]
		Loader Loader
		{
			[Token(Token = "0x600144D")]
			get;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600144E RID: 5198
		[Token(Token = "0x170003D5")]
		bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x600144E")]
			get;
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x0600144F RID: 5199
		// (set) Token: 0x06001450 RID: 5200
		[Token(Token = "0x170003D6")]
		List<string> LocalExtraFiles
		{
			[Token(Token = "0x600144F")]
			get;
			[Token(Token = "0x6001450")]
			set;
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001451 RID: 5201
		// (set) Token: 0x06001452 RID: 5202
		[Token(Token = "0x170003D7")]
		List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001451")]
			get;
			[Token(Token = "0x6001452")]
			set;
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001453 RID: 5203
		// (set) Token: 0x06001454 RID: 5204
		[Token(Token = "0x170003D8")]
		bool HasChanged
		{
			[Token(Token = "0x6001453")]
			get;
			[Token(Token = "0x6001454")]
			set;
		}

		// Token: 0x06001455 RID: 5205
		[Token(Token = "0x6001455")]
		void InitializeSaveable();

		// Token: 0x06001456 RID: 5206
		[Token(Token = "0x6001456")]
		string GetSaveString();

		// Token: 0x06001457 RID: 5207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x5AF560", Offset = "0x5ADF60", VA = "0x1805AF560", Slot = "12")]
		string Save(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x5AF9B0", Offset = "0x5AE3B0", VA = "0x1805AF9B0", Slot = "13")]
		void WriteBaseData(string parentFolderPath, string saveString)
		{
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x5AF4A0", Offset = "0x5ADEA0", VA = "0x1805AF4A0", Slot = "14")]
		string GetLocalPath(out bool isFolder)
		{
			return null;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x5AE9F0", Offset = "0x5AD3F0", VA = "0x1805AE9F0", Slot = "15")]
		void CompleteSave(string parentFolderPath, bool writeDataFile)
		{
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x5AFD50", Offset = "0x5AE750", VA = "0x1805AFD50", Slot = "16")]
		List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "17")]
		void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x5AF350", Offset = "0x5ADD50", VA = "0x1805AF350", Slot = "18")]
		string GetContainerFolder(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145E")]
		[Address(RVA = "0x5B01F0", Offset = "0x5AEBF0", VA = "0x1805B01F0", Slot = "19")]
		string WriteSubfile(string parentPath, string localPath_NoExtensions, string contents)
		{
			return null;
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145F")]
		[Address(RVA = "0x5AFDB0", Offset = "0x5AE7B0", VA = "0x1805AFDB0", Slot = "20")]
		string WriteFolder(string parentPath, string localPath_NoExtensions)
		{
			return null;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000083E8 File Offset: 0x000065E8
		[Token(Token = "0x6001460")]
		[Address(RVA = "0x5AF8A0", Offset = "0x5AE2A0", VA = "0x1805AF8A0", Slot = "21")]
		bool TryLoadFile(string parentPath, string fileName, out string contents)
		{
			return default(bool);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00008400 File Offset: 0x00006600
		[Token(Token = "0x6001461")]
		[Address(RVA = "0x5AF6C0", Offset = "0x5AE0C0", VA = "0x1805AF6C0", Slot = "22")]
		bool TryLoadFile(string path, out string contents, bool autoAddExtension = true)
		{
			return default(bool);
		}
	}
}
