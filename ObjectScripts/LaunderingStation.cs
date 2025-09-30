using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CB5 RID: 3253
	[Token(Token = "0x2000CB5")]
	public class LaunderingStation : GridItem
	{
		// Token: 0x06005AB7 RID: 23223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB7")]
		[Address(RVA = "0xA33750", Offset = "0xA32150", VA = "0x180A33750", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB8")]
		[Address(RVA = "0xA338A0", Offset = "0xA322A0", VA = "0x180A338A0")]
		private void Update()
		{
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x000162A8 File Offset: 0x000144A8
		[Token(Token = "0x6005AB9")]
		[Address(RVA = "0xA33700", Offset = "0xA32100", VA = "0x180A33700", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABA")]
		[Address(RVA = "0x9C5880", Offset = "0x9C4280", VA = "0x1809C5880")]
		public LaunderingStation()
		{
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABB")]
		[Address(RVA = "0xA33880", Offset = "0xA32280", VA = "0x180A33880", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABC")]
		[Address(RVA = "0xA33860", Offset = "0xA32260", VA = "0x180A33860", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABD")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABE")]
		[Address(RVA = "0x9C4910", Offset = "0x9C3310", VA = "0x1809C4910", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04004271 RID: 17009
		[Token(Token = "0x4004271")]
		[FieldOffset(Offset = "0x218")]
		[Header("References")]
		public LaunderingInterface Interface;

		// Token: 0x04004272 RID: 17010
		[Token(Token = "0x4004272")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		protected CashCounter CashCounter;

		// Token: 0x04004273 RID: 17011
		[Token(Token = "0x4004273")]
		[FieldOffset(Offset = "0x228")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.LaunderingStationAssembly-CSharp.dll_Excuted;

		// Token: 0x04004274 RID: 17012
		[Token(Token = "0x4004274")]
		[FieldOffset(Offset = "0x229")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.LaunderingStationAssembly-CSharp.dll_Excuted;
	}
}
