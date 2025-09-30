using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A5F RID: 2655
	[Token(Token = "0x2000A5F")]
	public class CustomizationManager : Singleton<CustomizationManager>
	{
		// Token: 0x06004869 RID: 18537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004869")]
		[Address(RVA = "0x907700", Offset = "0x906100", VA = "0x180907700", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486A")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		public void CreateSettings(string assetName, string assetPath)
		{
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486B")]
		[Address(RVA = "0x906B00", Offset = "0x905500", VA = "0x180906B00")]
		public void CreateSettings()
		{
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486C")]
		[Address(RVA = "0x907490", Offset = "0x905E90", VA = "0x180907490")]
		public void LoadSettings(AvatarSettings loadedSettings)
		{
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486D")]
		[Address(RVA = "0x907180", Offset = "0x905B80", VA = "0x180907180")]
		public void LoadSettings(string path, bool editOriginal = false)
		{
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486E")]
		[Address(RVA = "0x9065F0", Offset = "0x904FF0", VA = "0x1809065F0")]
		private void ApplyDefaultSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486F")]
		[Address(RVA = "0x9072B0", Offset = "0x905CB0", VA = "0x1809072B0")]
		public void LoadSettings()
		{
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004870")]
		[Address(RVA = "0x907000", Offset = "0x905A00", VA = "0x180907000")]
		public void GenderChanged(float genderScale)
		{
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004871")]
		[Address(RVA = "0x9077D0", Offset = "0x9061D0", VA = "0x1809077D0")]
		public void WeightChanged(float weightScale)
		{
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004872")]
		[Address(RVA = "0x907140", Offset = "0x905B40", VA = "0x180907140")]
		public void HeightChanged(float height)
		{
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004873")]
		[Address(RVA = "0x907670", Offset = "0x906070", VA = "0x180907670")]
		public void SkinColorChanged(Color col)
		{
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004874")]
		[Address(RVA = "0x907040", Offset = "0x905A40", VA = "0x180907040")]
		public void HairChanged(Accessory newHair)
		{
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004875")]
		[Address(RVA = "0x907100", Offset = "0x905B00", VA = "0x180907100")]
		public void HairColorChanged(Color newCol)
		{
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004876")]
		[Address(RVA = "0x906C00", Offset = "0x905600", VA = "0x180906C00")]
		public void EyeBallTintChanged(Color col)
		{
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004877")]
		[Address(RVA = "0x907790", Offset = "0x906190", VA = "0x180907790")]
		public void UpperEyeLidRestingPositionChanged(float newVal)
		{
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004878")]
		[Address(RVA = "0x9075F0", Offset = "0x905FF0", VA = "0x1809075F0")]
		public void LowerEyeLidRestingPositionChanged(float newVal)
		{
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004879")]
		[Address(RVA = "0x906CC0", Offset = "0x9056C0", VA = "0x180906CC0")]
		public void EyebrowScaleChanged(float newVal)
		{
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487A")]
		[Address(RVA = "0x906D00", Offset = "0x905700", VA = "0x180906D00")]
		public void EyebrowThicknessChanged(float newVal)
		{
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487B")]
		[Address(RVA = "0x906C80", Offset = "0x905680", VA = "0x180906C80")]
		public void EyebrowRestingHeightChanged(float newVal)
		{
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487C")]
		[Address(RVA = "0x906C40", Offset = "0x905640", VA = "0x180906C40")]
		public void EyebrowRestingAngleChanged(float newVal)
		{
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487D")]
		[Address(RVA = "0x907630", Offset = "0x906030", VA = "0x180907630")]
		public void PupilDilationChanged(float dilation)
		{
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487E")]
		[Address(RVA = "0x906D40", Offset = "0x905740", VA = "0x180906D40")]
		public void FaceLayerChanged(FaceLayer layer, int index)
		{
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487F")]
		[Address(RVA = "0x906ED0", Offset = "0x9058D0", VA = "0x180906ED0")]
		public void FaceLayerColorChanged(Color col, int index)
		{
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004880")]
		[Address(RVA = "0x906830", Offset = "0x905230", VA = "0x180906830")]
		public void BodyLayerChanged(AvatarLayer layer, int index)
		{
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004881")]
		[Address(RVA = "0x9069C0", Offset = "0x9053C0", VA = "0x1809069C0")]
		public void BodyLayerColorChanged(Color col, int index)
		{
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004882")]
		[Address(RVA = "0x906200", Offset = "0x904C00", VA = "0x180906200")]
		public void AccessoryChanged(Accessory acc, int index)
		{
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004883")]
		[Address(RVA = "0x9064C0", Offset = "0x904EC0", VA = "0x1809064C0")]
		public void AccessoryColorChanged(Color col, int index)
		{
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004884")]
		[Address(RVA = "0x907810", Offset = "0x906210", VA = "0x180907810")]
		public CustomizationManager()
		{
		}

		// Token: 0x04003379 RID: 13177
		[Token(Token = "0x4003379")]
		public const string CHARACTER_SETTINGS_PATH = "Assets/Resources/CharacterSettings";

		// Token: 0x0400337A RID: 13178
		[Token(Token = "0x400337A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AvatarSettings ActiveSettings;

		// Token: 0x0400337B RID: 13179
		[Token(Token = "0x400337B")]
		[FieldOffset(Offset = "0x30")]
		public Avatar TemplateAvatar;

		// Token: 0x0400337C RID: 13180
		[Token(Token = "0x400337C")]
		[FieldOffset(Offset = "0x38")]
		public TMP_InputField SaveInputField;

		// Token: 0x0400337D RID: 13181
		[Token(Token = "0x400337D")]
		[FieldOffset(Offset = "0x40")]
		public TMP_InputField LoadInputField;

		// Token: 0x0400337E RID: 13182
		[Token(Token = "0x400337E")]
		[FieldOffset(Offset = "0x48")]
		public CustomizationManager.AvatarSettingsChanged OnAvatarSettingsChanged;

		// Token: 0x0400337F RID: 13183
		[Token(Token = "0x400337F")]
		[FieldOffset(Offset = "0x50")]
		public AvatarSettings DefaultSettings;

		// Token: 0x04003380 RID: 13184
		[Token(Token = "0x4003380")]
		[FieldOffset(Offset = "0x58")]
		private bool isEditingOriginal;

		// Token: 0x04003381 RID: 13185
		[Token(Token = "0x4003381")]
		[FieldOffset(Offset = "0x60")]
		private string loadedSettingsAssetPath;

		// Token: 0x02000A60 RID: 2656
		// (Invoke) Token: 0x06004886 RID: 18566
		[Token(Token = "0x2000A60")]
		public delegate void AvatarSettingsChanged(AvatarSettings settings);
	}
}
