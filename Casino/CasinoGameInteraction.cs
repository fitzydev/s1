using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x020007D3 RID: 2003
	[Token(Token = "0x20007D3")]
	public class CasinoGameInteraction : MonoBehaviour
	{
		// Token: 0x06003635 RID: 13877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003635")]
		[Address(RVA = "0x7C7610", Offset = "0x7C6010", VA = "0x1807C7610")]
		private void Awake()
		{
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003636")]
		[Address(RVA = "0x7C7700", Offset = "0x7C6100", VA = "0x1807C7700")]
		private void Hovered()
		{
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003637")]
		[Address(RVA = "0x7C77E0", Offset = "0x7C61E0", VA = "0x1807C77E0")]
		private void Interacted()
		{
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003638")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CasinoGameInteraction()
		{
		}

		// Token: 0x040025C7 RID: 9671
		[Token(Token = "0x40025C7")]
		[FieldOffset(Offset = "0x20")]
		public string GameName;

		// Token: 0x040025C8 RID: 9672
		[Token(Token = "0x40025C8")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public CasinoGamePlayers Players;

		// Token: 0x040025C9 RID: 9673
		[Token(Token = "0x40025C9")]
		[FieldOffset(Offset = "0x30")]
		public InteractableObject IntObj;

		// Token: 0x040025CA RID: 9674
		[Token(Token = "0x40025CA")]
		[FieldOffset(Offset = "0x38")]
		public Action<Player> onLocalPlayerRequestJoin;
	}
}
