using System;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Misc;
using ScheduleOne.UI.Management;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x020008E0 RID: 2272
	[Token(Token = "0x20008E0")]
	public class ManagementClipboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06003F20 RID: 16160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F20")]
		[Address(RVA = "0x866270", Offset = "0x864C70", VA = "0x180866270", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F21")]
		[Address(RVA = "0x8669F0", Offset = "0x8653F0", VA = "0x1808669F0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F22")]
		[Address(RVA = "0x866D00", Offset = "0x865700", VA = "0x180866D00", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F23")]
		[Address(RVA = "0x866680", Offset = "0x865080", VA = "0x180866680")]
		private void FullscreenEnter()
		{
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F24")]
		[Address(RVA = "0x866800", Offset = "0x865200", VA = "0x180866800")]
		private void FullscreenExit()
		{
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F25")]
		[Address(RVA = "0x866970", Offset = "0x865370", VA = "0x180866970")]
		public void OverrideClipboardText(string overriddenText)
		{
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F26")]
		[Address(RVA = "0x866210", Offset = "0x864C10", VA = "0x180866210")]
		public void EndOverride()
		{
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F27")]
		[Address(RVA = "0x850250", Offset = "0x84EC50", VA = "0x180850250")]
		public ManagementClipboard_Equippable()
		{
		}

		// Token: 0x04002C29 RID: 11305
		[Token(Token = "0x4002C29")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public Transform Clipboard;

		// Token: 0x04002C2A RID: 11306
		[Token(Token = "0x4002C2A")]
		[FieldOffset(Offset = "0x70")]
		public Transform LoweredPosition;

		// Token: 0x04002C2B RID: 11307
		[Token(Token = "0x4002C2B")]
		[FieldOffset(Offset = "0x78")]
		public Transform RaisedPosition;

		// Token: 0x04002C2C RID: 11308
		[Token(Token = "0x4002C2C")]
		[FieldOffset(Offset = "0x80")]
		public ToggleableLight Light;

		// Token: 0x04002C2D RID: 11309
		[Token(Token = "0x4002C2D")]
		[FieldOffset(Offset = "0x88")]
		public SelectionInfoUI SelectionInfo;

		// Token: 0x04002C2E RID: 11310
		[Token(Token = "0x4002C2E")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI OverrideText;

		// Token: 0x04002C2F RID: 11311
		[Token(Token = "0x4002C2F")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine moveRoutine;
	}
}
