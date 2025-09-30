using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x02000A24 RID: 2596
	[Token(Token = "0x2000A24")]
	public class AvatarImpostor : MonoBehaviour
	{
		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06004738 RID: 18232 RVA: 0x00012B58 File Offset: 0x00010D58
		// (set) Token: 0x06004739 RID: 18233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A09")]
		public bool HasTexture
		{
			[Token(Token = "0x6004738")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004739")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x0600473A RID: 18234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A0A")]
		private Transform Camera
		{
			[Token(Token = "0x600473A")]
			[Address(RVA = "0x8EEE80", Offset = "0x8ED880", VA = "0x1808EEE80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600473B")]
		[Address(RVA = "0x8EEA80", Offset = "0x8ED480", VA = "0x1808EEA80")]
		private void Awake()
		{
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600473C")]
		[Address(RVA = "0x8EED80", Offset = "0x8ED780", VA = "0x1808EED80")]
		public void SetAvatarSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600473D")]
		[Address(RVA = "0x8EEB40", Offset = "0x8ED540", VA = "0x1808EEB40")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600473E")]
		[Address(RVA = "0x8EEB50", Offset = "0x8ED550", VA = "0x1808EEB50")]
		private void Realign()
		{
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600473F")]
		[Address(RVA = "0x8EEB00", Offset = "0x8ED500", VA = "0x1808EEB00")]
		public void EnableImpostor()
		{
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004740")]
		[Address(RVA = "0x6FE5D0", Offset = "0x6FCFD0", VA = "0x1806FE5D0")]
		public void DisableImpostor()
		{
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004741")]
		[Address(RVA = "0x8EEE20", Offset = "0x8ED820", VA = "0x1808EEE20")]
		public AvatarImpostor()
		{
		}

		// Token: 0x0400320F RID: 12815
		[Token(Token = "0x400320F")]
		[FieldOffset(Offset = "0x28")]
		public MeshRenderer meshRenderer;

		// Token: 0x04003210 RID: 12816
		[Token(Token = "0x4003210")]
		[FieldOffset(Offset = "0x30")]
		public Transform AnchorBone;

		// Token: 0x04003211 RID: 12817
		[Token(Token = "0x4003211")]
		[FieldOffset(Offset = "0x38")]
		private Transform cachedCamera;

		// Token: 0x04003212 RID: 12818
		[Token(Token = "0x4003212")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 anchorBoneOffset;
	}
}
