using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000A28 RID: 2600
	[Token(Token = "0x2000A28")]
	public class AvatarEmotionManager : MonoBehaviour
	{
		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06004744 RID: 18244 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004745 RID: 18245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A0B")]
		public string CurrentEmotion
		{
			[Token(Token = "0x6004744")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004745")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06004746 RID: 18246 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004747 RID: 18247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A0C")]
		public AvatarEmotionPreset CurrentEmotionPreset
		{
			[Token(Token = "0x6004746")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004747")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06004748 RID: 18248 RVA: 0x00012B70 File Offset: 0x00010D70
		[Token(Token = "0x17000A0D")]
		public bool IsSwitchingEmotion
		{
			[Token(Token = "0x6004748")]
			[Address(RVA = "0x8ECA80", Offset = "0x8EB480", VA = "0x1808ECA80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004749")]
		[Address(RVA = "0x8EC2F0", Offset = "0x8EACF0", VA = "0x1808EC2F0")]
		private void Start()
		{
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600474A")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void Update()
		{
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600474B")]
		[Address(RVA = "0x8EC4B0", Offset = "0x8EAEB0", VA = "0x1808EC4B0")]
		public void UpdateEmotion()
		{
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600474C")]
		[Address(RVA = "0x8EB9B0", Offset = "0x8EA3B0", VA = "0x1808EB9B0")]
		public void ConfigureNeutralFace(Texture2D faceTex, float restingBrowHeight, float restingBrowAngle, Eye.EyeLidConfiguration leftEyelidConfig, Eye.EyeLidConfiguration rightEyelidConfig)
		{
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600474D")]
		[Address(RVA = "0x8EB4B0", Offset = "0x8E9EB0", VA = "0x1808EB4B0", Slot = "4")]
		public virtual void AddEmotionOverride(string emotionName, string overrideLabel, float duration = 0f, int priority = 0)
		{
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600474E")]
		[Address(RVA = "0x8EC010", Offset = "0x8EAA10", VA = "0x1808EC010")]
		public void RemoveEmotionOverride(string label)
		{
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600474F")]
		[Address(RVA = "0x8EB7E0", Offset = "0x8EA1E0", VA = "0x1808EB7E0")]
		public void ClearOverrides()
		{
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004750")]
		[Address(RVA = "0x8EB8C0", Offset = "0x8EA2C0", VA = "0x1808EB8C0")]
		private void ClearRemovalRoutine(string label)
		{
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004751")]
		[Address(RVA = "0x8EBD00", Offset = "0x8EA700", VA = "0x1808EBD00")]
		public EmotionOverride GetHighestPriorityOverride()
		{
			return null;
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004752")]
		[Address(RVA = "0x8EBE70", Offset = "0x8EA870", VA = "0x1808EBE70")]
		private void LerpEmotion(AvatarEmotionPreset preset, float animationTime = 0.2f)
		{
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004753")]
		[Address(RVA = "0x8EC130", Offset = "0x8EAB30", VA = "0x1808EC130")]
		private void SetEmotion(AvatarEmotionPreset preset)
		{
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x00012B88 File Offset: 0x00010D88
		[Token(Token = "0x6004754")]
		[Address(RVA = "0x8EBE50", Offset = "0x8EA850", VA = "0x1808EBE50")]
		public bool HasEmotion(string emotion)
		{
			return default(bool);
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004755")]
		[Address(RVA = "0x8EBC20", Offset = "0x8EA620", VA = "0x1808EBC20")]
		public AvatarEmotionPreset GetEmotion(string emotion)
		{
			return null;
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004756")]
		[Address(RVA = "0x8EC950", Offset = "0x8EB350", VA = "0x1808EC950")]
		public AvatarEmotionManager()
		{
		}

		// Token: 0x04003226 RID: 12838
		[Token(Token = "0x4003226")]
		public const float MAX_UPDATE_DISTANCE = 30f;

		// Token: 0x04003229 RID: 12841
		[Token(Token = "0x4003229")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public List<AvatarEmotionPreset> EmotionPresetList;

		// Token: 0x0400322A RID: 12842
		[Token(Token = "0x400322A")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Avatar Avatar;

		// Token: 0x0400322B RID: 12843
		[Token(Token = "0x400322B")]
		[FieldOffset(Offset = "0x40")]
		public EyeController EyeController;

		// Token: 0x0400322C RID: 12844
		[Token(Token = "0x400322C")]
		[FieldOffset(Offset = "0x48")]
		public EyebrowController EyebrowController;

		// Token: 0x0400322D RID: 12845
		[Token(Token = "0x400322D")]
		[FieldOffset(Offset = "0x50")]
		private EmotionOverride activeEmotionOverride;

		// Token: 0x0400322E RID: 12846
		[Token(Token = "0x400322E")]
		[FieldOffset(Offset = "0x58")]
		private List<EmotionOverride> overrideStack;

		// Token: 0x0400322F RID: 12847
		[Token(Token = "0x400322F")]
		[FieldOffset(Offset = "0x60")]
		private AvatarEmotionPreset neutralPreset;

		// Token: 0x04003230 RID: 12848
		[Token(Token = "0x4003230")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine emotionLerpRoutine;

		// Token: 0x04003231 RID: 12849
		[Token(Token = "0x4003231")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, Coroutine> emotionRemovalRoutines;

		// Token: 0x04003232 RID: 12850
		[Token(Token = "0x4003232")]
		[FieldOffset(Offset = "0x78")]
		private int tempIndex;
	}
}
