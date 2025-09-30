using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Lighting;
using ScheduleOne.Misc;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C79 RID: 3193
	[Token(Token = "0x2000C79")]
	public class GrowLight : ProceduralGridItem
	{
		// Token: 0x0600566B RID: 22123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566B")]
		[Address(RVA = "0x9C5B10", Offset = "0x9C4510", VA = "0x1809C5B10", Slot = "66")]
		public override void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566C")]
		[Address(RVA = "0x9C5DC0", Offset = "0x9C47C0", VA = "0x1809C5DC0")]
		public void SetIsOn(bool isOn)
		{
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566D")]
		[Address(RVA = "0x9C58E0", Offset = "0x9C42E0", VA = "0x1809C58E0", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566E")]
		[Address(RVA = "0x9C5DF0", Offset = "0x9C47F0", VA = "0x1809C5DF0")]
		public GrowLight()
		{
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566F")]
		[Address(RVA = "0x9C5DA0", Offset = "0x9C47A0", VA = "0x1809C5DA0", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005670")]
		[Address(RVA = "0x9C5D80", Offset = "0x9C4780", VA = "0x1809C5D80", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005671")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005672")]
		[Address(RVA = "0x9C5890", Offset = "0x9C4290", VA = "0x1809C5890", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x0400400C RID: 16396
		[Token(Token = "0x400400C")]
		[FieldOffset(Offset = "0x200")]
		[Header("References")]
		public ToggleableLight Light;

		// Token: 0x0400400D RID: 16397
		[Token(Token = "0x400400D")]
		[FieldOffset(Offset = "0x208")]
		public UsableLightSource usableLightSource;

		// Token: 0x0400400E RID: 16398
		[Token(Token = "0x400400E")]
		[FieldOffset(Offset = "0x210")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted;

		// Token: 0x0400400F RID: 16399
		[Token(Token = "0x400400F")]
		[FieldOffset(Offset = "0x211")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted;
	}
}
