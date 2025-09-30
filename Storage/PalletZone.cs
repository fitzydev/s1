using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x0200094E RID: 2382
	[Token(Token = "0x200094E")]
	public class PalletZone : MonoBehaviour
	{
		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x00011268 File Offset: 0x0000F468
		[Token(Token = "0x17000919")]
		public bool isClear
		{
			[Token(Token = "0x6004125")]
			[Address(RVA = "0x880C20", Offset = "0x87F620", VA = "0x180880C20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004126")]
		[Address(RVA = "0x880A70", Offset = "0x87F470", VA = "0x180880A70")]
		protected void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004127")]
		[Address(RVA = "0x8808C0", Offset = "0x87F2C0", VA = "0x1808808C0")]
		protected void FixedUpdate()
		{
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004128")]
		[Address(RVA = "0x606F50", Offset = "0x605950", VA = "0x180606F50")]
		protected void LateUpdate()
		{
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004129")]
		[Address(RVA = "0x880920", Offset = "0x87F320", VA = "0x180880920")]
		public Pallet GeneratePallet()
		{
			return null;
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x00011280 File Offset: 0x0000F480
		[Token(Token = "0x600412A")]
		[Address(RVA = "0x880820", Offset = "0x87F220", VA = "0x180880820")]
		private bool AreAllPalletsClear()
		{
			return default(bool);
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412B")]
		[Address(RVA = "0x880BA0", Offset = "0x87F5A0", VA = "0x180880BA0")]
		public PalletZone()
		{
		}

		// Token: 0x04002DD5 RID: 11733
		[Token(Token = "0x4002DD5")]
		[FieldOffset(Offset = "0x20")]
		private List<Pallet> pallets;

		// Token: 0x04002DD6 RID: 11734
		[Token(Token = "0x4002DD6")]
		[FieldOffset(Offset = "0x28")]
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject palletPrefab;

		// Token: 0x04002DD7 RID: 11735
		[Token(Token = "0x4002DD7")]
		[FieldOffset(Offset = "0x30")]
		private bool orderReceivedThisFrame;
	}
}
