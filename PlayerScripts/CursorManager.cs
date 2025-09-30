using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000545 RID: 1349
	[Token(Token = "0x2000545")]
	public class CursorManager : Singleton<CursorManager>
	{
		// Token: 0x06001B9D RID: 7069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x633840", Offset = "0x632240", VA = "0x180633840", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x633D80", Offset = "0x632780", VA = "0x180633D80")]
		public void SetCursorAppearance(CursorManager.ECursorType type)
		{
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x633F20", Offset = "0x632920", VA = "0x180633F20")]
		public CursorManager()
		{
		}

		// Token: 0x0400179B RID: 6043
		[Token(Token = "0x400179B")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public List<CursorManager.CursorConfig> Cursors;

		// Token: 0x02000546 RID: 1350
		[Token(Token = "0x2000546")]
		public enum ECursorType
		{
			// Token: 0x0400179D RID: 6045
			[Token(Token = "0x400179D")]
			Default,
			// Token: 0x0400179E RID: 6046
			[Token(Token = "0x400179E")]
			Finger,
			// Token: 0x0400179F RID: 6047
			[Token(Token = "0x400179F")]
			OpenHand,
			// Token: 0x040017A0 RID: 6048
			[Token(Token = "0x40017A0")]
			Grab,
			// Token: 0x040017A1 RID: 6049
			[Token(Token = "0x40017A1")]
			Scissors,
			// Token: 0x040017A2 RID: 6050
			[Token(Token = "0x40017A2")]
			Spray
		}

		// Token: 0x02000547 RID: 1351
		[Token(Token = "0x2000547")]
		[Serializable]
		public class CursorConfig
		{
			// Token: 0x06001BA0 RID: 7072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001BA0")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public CursorConfig()
			{
			}

			// Token: 0x040017A3 RID: 6051
			[Token(Token = "0x40017A3")]
			[FieldOffset(Offset = "0x10")]
			public CursorManager.ECursorType CursorType;

			// Token: 0x040017A4 RID: 6052
			[Token(Token = "0x40017A4")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D Texture;

			// Token: 0x040017A5 RID: 6053
			[Token(Token = "0x40017A5")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 HotSpot;
		}
	}
}
