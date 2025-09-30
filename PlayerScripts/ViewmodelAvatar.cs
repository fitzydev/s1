using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000572 RID: 1394
	[Token(Token = "0x2000572")]
	public class ViewmodelAvatar : Singleton<ViewmodelAvatar>
	{
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x0000A368 File Offset: 0x00008568
		// (set) Token: 0x06001F12 RID: 7954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000561")]
		public bool IsVisible
		{
			[Token(Token = "0x6001F11")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F12")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F13")]
		[Address(RVA = "0x667100", Offset = "0x665B00", VA = "0x180667100", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F14")]
		[Address(RVA = "0x667680", Offset = "0x666080", VA = "0x180667680")]
		public void SetVisibility(bool isVisible)
		{
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F15")]
		[Address(RVA = "0x6672A0", Offset = "0x665CA0", VA = "0x1806672A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x6672A0", Offset = "0x665CA0", VA = "0x1806672A0")]
		private void ResetHipTransform()
		{
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x6673A0", Offset = "0x665DA0", VA = "0x1806673A0")]
		public void SetAppearance(AvatarSettings settings)
		{
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x667380", Offset = "0x665D80", VA = "0x180667380")]
		public void SetAnimatorController(RuntimeAnimatorController controller)
		{
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F19")]
		[Address(RVA = "0x667590", Offset = "0x665F90", VA = "0x180667590")]
		public void SetOffset(Vector3 offset)
		{
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0x6675E0", Offset = "0x665FE0", VA = "0x1806675E0")]
		public void SetRotationOffset(Vector3 eulerAngles)
		{
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0x667770", Offset = "0x666170", VA = "0x180667770")]
		public ViewmodelAvatar()
		{
		}

		// Token: 0x04001963 RID: 6499
		[Token(Token = "0x4001963")]
		[FieldOffset(Offset = "0x30")]
		public ScheduleOne.AvatarFramework.Avatar ParentAvatar;

		// Token: 0x04001964 RID: 6500
		[Token(Token = "0x4001964")]
		[FieldOffset(Offset = "0x38")]
		public Animator Animator;

		// Token: 0x04001965 RID: 6501
		[Token(Token = "0x4001965")]
		[FieldOffset(Offset = "0x40")]
		public ScheduleOne.AvatarFramework.Avatar Avatar;

		// Token: 0x04001966 RID: 6502
		[Token(Token = "0x4001966")]
		[FieldOffset(Offset = "0x48")]
		public Transform RightHandContainer;
	}
}
