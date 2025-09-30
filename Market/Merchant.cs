using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.Market
{
	// Token: 0x020004C5 RID: 1221
	[Token(Token = "0x20004C5")]
	public class Merchant : MonoBehaviour
	{
		// Token: 0x0600181B RID: 6171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181B")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181C")]
		[Address(RVA = "0x60C890", Offset = "0x60B290", VA = "0x18060C890")]
		public void Hovered()
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181D")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "5")]
		public virtual void Interacted()
		{
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181E")]
		[Address(RVA = "0x6072A0", Offset = "0x605CA0", VA = "0x1806072A0")]
		public Merchant()
		{
		}

		// Token: 0x040015C0 RID: 5568
		[Token(Token = "0x40015C0")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		[SerializeField]
		protected string shopName;

		// Token: 0x040015C1 RID: 5569
		[Token(Token = "0x40015C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected int openTime;

		// Token: 0x040015C2 RID: 5570
		[Token(Token = "0x40015C2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected int closeTime;

		// Token: 0x040015C3 RID: 5571
		[Token(Token = "0x40015C3")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;
	}
}
