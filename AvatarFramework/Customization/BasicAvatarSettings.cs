using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A5A RID: 2650
	[Token(Token = "0x2000A5A")]
	[CreateAssetMenu(fileName = "BasicAvatarSettings", menuName = "ScriptableObjects/BasicAvatarSettings", order = 1)]
	[Serializable]
	public class BasicAvatarSettings : ScriptableObject
	{
		// Token: 0x0600484A RID: 18506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600484A")]
		public T SetValue<T>(string fieldName, T value)
		{
			return null;
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600484B")]
		public T GetValue<T>(string fieldName)
		{
			return null;
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600484C")]
		[Address(RVA = "0x8FC480", Offset = "0x8FAE80", VA = "0x1808FC480")]
		public AvatarSettings GetAvatarSettings()
		{
			return null;
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600484D")]
		[Address(RVA = "0x8F31A0", Offset = "0x8F1BA0", VA = "0x1808F31A0", Slot = "4")]
		public virtual string GetJson(bool prettyPrint = true)
		{
			return null;
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484E")]
		[Address(RVA = "0x8FD290", Offset = "0x8FBC90", VA = "0x1808FD290")]
		public BasicAvatarSettings()
		{
		}

		// Token: 0x0400333E RID: 13118
		[Token(Token = "0x400333E")]
		public const float GENDER_MULTIPLIER = 0.7f;

		// Token: 0x0400333F RID: 13119
		[Token(Token = "0x400333F")]
		public const string MaleUnderwearPath = "Avatar/Layers/Bottom/MaleUnderwear";

		// Token: 0x04003340 RID: 13120
		[Token(Token = "0x4003340")]
		public const string FemaleUnderwearPath = "Avatar/Layers/Bottom/FemaleUnderwear";

		// Token: 0x04003341 RID: 13121
		[Token(Token = "0x4003341")]
		[FieldOffset(Offset = "0x18")]
		public int Gender;

		// Token: 0x04003342 RID: 13122
		[Token(Token = "0x4003342")]
		[FieldOffset(Offset = "0x1C")]
		public float Weight;

		// Token: 0x04003343 RID: 13123
		[Token(Token = "0x4003343")]
		[FieldOffset(Offset = "0x20")]
		public Color SkinColor;

		// Token: 0x04003344 RID: 13124
		[Token(Token = "0x4003344")]
		[FieldOffset(Offset = "0x30")]
		public string HairStyle;

		// Token: 0x04003345 RID: 13125
		[Token(Token = "0x4003345")]
		[FieldOffset(Offset = "0x38")]
		public Color HairColor;

		// Token: 0x04003346 RID: 13126
		[Token(Token = "0x4003346")]
		[FieldOffset(Offset = "0x48")]
		public string Mouth;

		// Token: 0x04003347 RID: 13127
		[Token(Token = "0x4003347")]
		[FieldOffset(Offset = "0x50")]
		public string FacialHair;

		// Token: 0x04003348 RID: 13128
		[Token(Token = "0x4003348")]
		[FieldOffset(Offset = "0x58")]
		public string FacialDetails;

		// Token: 0x04003349 RID: 13129
		[Token(Token = "0x4003349")]
		[FieldOffset(Offset = "0x60")]
		public float FacialDetailsIntensity;

		// Token: 0x0400334A RID: 13130
		[Token(Token = "0x400334A")]
		[FieldOffset(Offset = "0x64")]
		public Color EyeballColor;

		// Token: 0x0400334B RID: 13131
		[Token(Token = "0x400334B")]
		[FieldOffset(Offset = "0x74")]
		public float UpperEyeLidRestingPosition;

		// Token: 0x0400334C RID: 13132
		[Token(Token = "0x400334C")]
		[FieldOffset(Offset = "0x78")]
		public float LowerEyeLidRestingPosition;

		// Token: 0x0400334D RID: 13133
		[Token(Token = "0x400334D")]
		[FieldOffset(Offset = "0x7C")]
		public float PupilDilation;

		// Token: 0x0400334E RID: 13134
		[Token(Token = "0x400334E")]
		[FieldOffset(Offset = "0x80")]
		public float EyebrowScale;

		// Token: 0x0400334F RID: 13135
		[Token(Token = "0x400334F")]
		[FieldOffset(Offset = "0x84")]
		public float EyebrowThickness;

		// Token: 0x04003350 RID: 13136
		[Token(Token = "0x4003350")]
		[FieldOffset(Offset = "0x88")]
		public float EyebrowRestingHeight;

		// Token: 0x04003351 RID: 13137
		[Token(Token = "0x4003351")]
		[FieldOffset(Offset = "0x8C")]
		public float EyebrowRestingAngle;

		// Token: 0x04003352 RID: 13138
		[Token(Token = "0x4003352")]
		[FieldOffset(Offset = "0x90")]
		public string Top;

		// Token: 0x04003353 RID: 13139
		[Token(Token = "0x4003353")]
		[FieldOffset(Offset = "0x98")]
		public Color TopColor;

		// Token: 0x04003354 RID: 13140
		[Token(Token = "0x4003354")]
		[FieldOffset(Offset = "0xA8")]
		public string Bottom;

		// Token: 0x04003355 RID: 13141
		[Token(Token = "0x4003355")]
		[FieldOffset(Offset = "0xB0")]
		public Color BottomColor;

		// Token: 0x04003356 RID: 13142
		[Token(Token = "0x4003356")]
		[FieldOffset(Offset = "0xC0")]
		public string Shoes;

		// Token: 0x04003357 RID: 13143
		[Token(Token = "0x4003357")]
		[FieldOffset(Offset = "0xC8")]
		public Color ShoesColor;

		// Token: 0x04003358 RID: 13144
		[Token(Token = "0x4003358")]
		[FieldOffset(Offset = "0xD8")]
		public string Headwear;

		// Token: 0x04003359 RID: 13145
		[Token(Token = "0x4003359")]
		[FieldOffset(Offset = "0xE0")]
		public Color HeadwearColor;

		// Token: 0x0400335A RID: 13146
		[Token(Token = "0x400335A")]
		[FieldOffset(Offset = "0xF0")]
		public string Eyewear;

		// Token: 0x0400335B RID: 13147
		[Token(Token = "0x400335B")]
		[FieldOffset(Offset = "0xF8")]
		public Color EyewearColor;

		// Token: 0x0400335C RID: 13148
		[Token(Token = "0x400335C")]
		[FieldOffset(Offset = "0x108")]
		public List<string> Tattoos;
	}
}
