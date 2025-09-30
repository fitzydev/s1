using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using ScheduleOne.UI.Input;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x020004F2 RID: 1266
	[Token(Token = "0x20004F2")]
	public class ManagementMode : Singleton<ManagementMode>
	{
		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048E")]
		public Property CurrentProperty
		{
			[Token(Token = "0x60019C0")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C1")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00009228 File Offset: 0x00007428
		[Token(Token = "0x1700048F")]
		public bool isActive
		{
			[Token(Token = "0x60019C2")]
			[Address(RVA = "0x6406D0", Offset = "0x63F0D0", VA = "0x1806406D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019C3")]
		[Address(RVA = "0x63FFC0", Offset = "0x63E9C0", VA = "0x18063FFC0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x640580", Offset = "0x63EF80", VA = "0x180640580")]
		private void Update()
		{
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x640090", Offset = "0x63EA90", VA = "0x180640090")]
		private void UpdateInput()
		{
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x63FF20", Offset = "0x63E920", VA = "0x18063FF20")]
		private void Exit(ExitAction exitAction)
		{
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x63FCA0", Offset = "0x63E6A0", VA = "0x18063FCA0")]
		public void EnterManagementMode(Property property)
		{
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x63FDE0", Offset = "0x63E7E0", VA = "0x18063FDE0")]
		public void ExitManagementMode()
		{
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
		public static bool CanEnterManagementMode()
		{
			return default(bool);
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0")]
		public static bool CanExitManagementMode()
		{
			return default(bool);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019CB")]
		[Address(RVA = "0x640690", Offset = "0x63F090", VA = "0x180640690")]
		public ManagementMode()
		{
		}

		// Token: 0x04001663 RID: 5731
		[Token(Token = "0x4001663")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public InputPrompt ManagementModeInputPrompt;

		// Token: 0x04001664 RID: 5732
		[Token(Token = "0x4001664")]
		[FieldOffset(Offset = "0x38")]
		[Header("UI References")]
		public Canvas Canvas;

		// Token: 0x04001665 RID: 5733
		[Token(Token = "0x4001665")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent OnEnterManagementMode;

		// Token: 0x04001666 RID: 5734
		[Token(Token = "0x4001666")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onExitManagementMode;
	}
}
