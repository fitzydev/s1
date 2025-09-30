using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000968 RID: 2408
	[Token(Token = "0x2000968")]
	public class Fillable : MonoBehaviour
	{
		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004229 RID: 16937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000943")]
		public List<Fillable.Content> contents
		{
			[Token(Token = "0x6004228")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004229")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422A")]
		[Address(RVA = "0x87BA80", Offset = "0x87A480", VA = "0x18087BA80")]
		private void Awake()
		{
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422B")]
		[Address(RVA = "0x87B890", Offset = "0x87A290", VA = "0x18087B890")]
		public void AddLiquid(string label, float volume, Color color)
		{
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422C")]
		[Address(RVA = "0x87BCD0", Offset = "0x87A6D0", VA = "0x18087BCD0")]
		public void ResetContents()
		{
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422D")]
		[Address(RVA = "0x87BD40", Offset = "0x87A740", VA = "0x18087BD40")]
		private void UpdateLiquid()
		{
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x000115E0 File Offset: 0x0000F7E0
		[Token(Token = "0x600422E")]
		[Address(RVA = "0x87BAB0", Offset = "0x87A4B0", VA = "0x18087BAB0")]
		public float GetLiquidVolume(string label)
		{
			return 0f;
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x000115F8 File Offset: 0x0000F7F8
		[Token(Token = "0x600422F")]
		[Address(RVA = "0x87BBB0", Offset = "0x87A5B0", VA = "0x18087BBB0")]
		public float GetTotalLiquidVolume()
		{
			return 0f;
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004230")]
		[Address(RVA = "0x87BFB0", Offset = "0x87A9B0", VA = "0x18087BFB0")]
		public Fillable()
		{
		}

		// Token: 0x04002E57 RID: 11863
		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public LiquidContainer LiquidContainer;

		// Token: 0x04002E58 RID: 11864
		[Token(Token = "0x4002E58")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public bool FillableEnabled;

		// Token: 0x04002E59 RID: 11865
		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0x34")]
		public float LiquidCapacity_L;

		// Token: 0x02000969 RID: 2409
		[Token(Token = "0x2000969")]
		public class Content
		{
			// Token: 0x06004231 RID: 16945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004231")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Content()
			{
			}

			// Token: 0x04002E5A RID: 11866
			[Token(Token = "0x4002E5A")]
			[FieldOffset(Offset = "0x10")]
			public string Label;

			// Token: 0x04002E5B RID: 11867
			[Token(Token = "0x4002E5B")]
			[FieldOffset(Offset = "0x18")]
			public float Volume_L;

			// Token: 0x04002E5C RID: 11868
			[Token(Token = "0x4002E5C")]
			[FieldOffset(Offset = "0x1C")]
			public Color Color;
		}
	}
}
