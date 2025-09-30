using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Casino
{
	// Token: 0x020007D4 RID: 2004
	[Token(Token = "0x20007D4")]
	public class CasinoGamePlayerData
	{
		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600363A RID: 13882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D2")]
		public CasinoGamePlayers Parent
		{
			[Token(Token = "0x6003639")]
			[Address(RVA = "0x42FFD0", Offset = "0x42E9D0", VA = "0x18042FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600363A")]
			[Address(RVA = "0x4A4990", Offset = "0x4A3390", VA = "0x1804A4990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600363C RID: 13884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D3")]
		public Player Player
		{
			[Token(Token = "0x600363B")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600363C")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363D")]
		[Address(RVA = "0x7C7880", Offset = "0x7C6280", VA = "0x1807C7880")]
		public CasinoGamePlayerData(CasinoGamePlayers parent, Player player)
		{
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363E")]
		public T GetData<T>(string key)
		{
			return null;
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363F")]
		public void SetData<T>(string key, T value, bool network = true)
		{
		}

		// Token: 0x040025CD RID: 9677
		[Token(Token = "0x40025CD")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, bool> bools;

		// Token: 0x040025CE RID: 9678
		[Token(Token = "0x40025CE")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, float> floats;
	}
}
