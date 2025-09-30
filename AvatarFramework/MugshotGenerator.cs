using System;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A21 RID: 2593
	[Token(Token = "0x2000A21")]
	public class MugshotGenerator : Singleton<MugshotGenerator>
	{
		// Token: 0x06004729 RID: 18217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004729")]
		[Address(RVA = "0x8F7C70", Offset = "0x8F6670", VA = "0x1808F7C70", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600472A")]
		[Address(RVA = "0x8F8060", Offset = "0x8F6A60", VA = "0x1808F8060")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600472B")]
		[Address(RVA = "0x8F7CE0", Offset = "0x8F66E0", VA = "0x1808F7CE0")]
		private void FinalizeMugshot()
		{
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600472C")]
		[Address(RVA = "0x8F7D80", Offset = "0x8F6780", VA = "0x1808F7D80")]
		[Button]
		public void GenerateMugshot()
		{
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600472D")]
		[Address(RVA = "0x8F7DB0", Offset = "0x8F67B0", VA = "0x1808F7DB0")]
		public void GenerateMugshot(AvatarSettings settings, bool fileToFile, Action<Texture2D> callback)
		{
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600472E")]
		[Address(RVA = "0x8F8110", Offset = "0x8F6B10", VA = "0x1808F8110")]
		public MugshotGenerator()
		{
		}

		// Token: 0x040031FF RID: 12799
		[Token(Token = "0x40031FF")]
		[FieldOffset(Offset = "0x28")]
		public string OutputPath;

		// Token: 0x04003200 RID: 12800
		[Token(Token = "0x4003200")]
		[FieldOffset(Offset = "0x30")]
		public AvatarSettings Settings;

		// Token: 0x04003201 RID: 12801
		[Token(Token = "0x4003201")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Avatar MugshotRig;

		// Token: 0x04003202 RID: 12802
		[Token(Token = "0x4003202")]
		[FieldOffset(Offset = "0x40")]
		public IconGenerator Generator;

		// Token: 0x04003203 RID: 12803
		[Token(Token = "0x4003203")]
		[FieldOffset(Offset = "0x48")]
		public AvatarSettings DefaultSettings;

		// Token: 0x04003204 RID: 12804
		[Token(Token = "0x4003204")]
		[FieldOffset(Offset = "0x50")]
		public Transform LookAtPosition;

		// Token: 0x04003205 RID: 12805
		[Token(Token = "0x4003205")]
		[FieldOffset(Offset = "0x58")]
		private Texture2D finalTexture;

		// Token: 0x04003206 RID: 12806
		[Token(Token = "0x4003206")]
		[FieldOffset(Offset = "0x60")]
		private bool generate;
	}
}
