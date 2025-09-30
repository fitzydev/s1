using System;
using System.Collections;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x02000517 RID: 1303
	[Token(Token = "0x2000517")]
	public class PoliceLight : MonoBehaviour
	{
		// Token: 0x06001A80 RID: 6784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
		public void SetIsOn(bool isOn)
		{
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x64A290", Offset = "0x648C90", VA = "0x18064A290")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x64A220", Offset = "0x648C20", VA = "0x18064A220")]
		protected IEnumerator CycleCoroutine()
		{
			return null;
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x64A390", Offset = "0x648D90", VA = "0x18064A390")]
		public PoliceLight()
		{
		}

		// Token: 0x040016D2 RID: 5842
		[Token(Token = "0x40016D2")]
		[FieldOffset(Offset = "0x20")]
		public bool IsOn;

		// Token: 0x040016D3 RID: 5843
		[Token(Token = "0x40016D3")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public MeshRenderer[] RedMeshes;

		// Token: 0x040016D4 RID: 5844
		[Token(Token = "0x40016D4")]
		[FieldOffset(Offset = "0x30")]
		public MeshRenderer[] BlueMeshes;

		// Token: 0x040016D5 RID: 5845
		[Token(Token = "0x40016D5")]
		[FieldOffset(Offset = "0x38")]
		public OptimizedLight[] RedLights;

		// Token: 0x040016D6 RID: 5846
		[Token(Token = "0x40016D6")]
		[FieldOffset(Offset = "0x40")]
		public OptimizedLight[] BlueLights;

		// Token: 0x040016D7 RID: 5847
		[Token(Token = "0x40016D7")]
		[FieldOffset(Offset = "0x48")]
		public AudioSourceController Siren;

		// Token: 0x040016D8 RID: 5848
		[Token(Token = "0x40016D8")]
		[FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		public float CycleDuration;

		// Token: 0x040016D9 RID: 5849
		[Token(Token = "0x40016D9")]
		[FieldOffset(Offset = "0x58")]
		public Material RedOffMat;

		// Token: 0x040016DA RID: 5850
		[Token(Token = "0x40016DA")]
		[FieldOffset(Offset = "0x60")]
		public Material RedOnMat;

		// Token: 0x040016DB RID: 5851
		[Token(Token = "0x40016DB")]
		[FieldOffset(Offset = "0x68")]
		public Material BlueOffMat;

		// Token: 0x040016DC RID: 5852
		[Token(Token = "0x40016DC")]
		[FieldOffset(Offset = "0x70")]
		public Material BlueOnMat;

		// Token: 0x040016DD RID: 5853
		[Token(Token = "0x40016DD")]
		[FieldOffset(Offset = "0x78")]
		public AnimationCurve RedBrightnessCurve;

		// Token: 0x040016DE RID: 5854
		[Token(Token = "0x40016DE")]
		[FieldOffset(Offset = "0x80")]
		public AnimationCurve BlueBrightnessCurve;

		// Token: 0x040016DF RID: 5855
		[Token(Token = "0x40016DF")]
		[FieldOffset(Offset = "0x88")]
		public float LightBrightness;

		// Token: 0x040016E0 RID: 5856
		[Token(Token = "0x40016E0")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine cycleRoutine;
	}
}
