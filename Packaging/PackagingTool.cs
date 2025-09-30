using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x0200093A RID: 2362
	[Token(Token = "0x200093A")]
	public class PackagingTool : MonoBehaviour
	{
		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x00011130 File Offset: 0x0000F330
		// (set) Token: 0x06004081 RID: 16513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000908")]
		public bool ReceiveInput
		{
			[Token(Token = "0x6004080")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004081")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004082")]
		[Address(RVA = "0x869D80", Offset = "0x868780", VA = "0x180869D80")]
		public void Initialize(Task _task, FunctionalPackaging packaging, int packagingQuantity, ProductItemInstance product, int productQuantity)
		{
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004083")]
		[Address(RVA = "0x868F10", Offset = "0x867910", VA = "0x180868F10")]
		public void Deinitialize()
		{
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004084")]
		[Address(RVA = "0x86A000", Offset = "0x868A00", VA = "0x18086A000")]
		private void LoadPackaging(FunctionalPackaging prefab, int quantity)
		{
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004085")]
		[Address(RVA = "0x86A340", Offset = "0x868D40", VA = "0x18086A340")]
		private void UnloadPackaging()
		{
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004086")]
		[Address(RVA = "0x86A040", Offset = "0x868A40", VA = "0x18086A040")]
		private void LoadProduct(ProductItemInstance product, int quantity)
		{
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004087")]
		[Address(RVA = "0x86A380", Offset = "0x868D80", VA = "0x18086A380")]
		private void UnloadProduct()
		{
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004088")]
		[Address(RVA = "0x86A780", Offset = "0x869180", VA = "0x18086A780")]
		public void Update()
		{
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004089")]
		[Address(RVA = "0x86A4F0", Offset = "0x868EF0", VA = "0x18086A4F0")]
		private void UpdateInput()
		{
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408A")]
		[Address(RVA = "0x86A700", Offset = "0x869100", VA = "0x18086A700")]
		private void UpdateScreen()
		{
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408B")]
		[Address(RVA = "0x86A420", Offset = "0x868E20", VA = "0x18086A420")]
		private void UpdateConveyor()
		{
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408C")]
		[Address(RVA = "0x86A130", Offset = "0x868B30", VA = "0x18086A130")]
		private void Rotate(float angle)
		{
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408D")]
		[Address(RVA = "0x868AC0", Offset = "0x8674C0", VA = "0x180868AC0")]
		private void CheckDeployPackaging()
		{
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408E")]
		[Address(RVA = "0x868B80", Offset = "0x867580", VA = "0x180868B80")]
		private void CheckFinalize()
		{
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408F")]
		[Address(RVA = "0x869C70", Offset = "0x868670", VA = "0x180869C70")]
		private void Finalize(PackagingTool.PackagingInstance instance)
		{
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004090")]
		[Address(RVA = "0x8699A0", Offset = "0x8683A0", VA = "0x1808699A0")]
		private void DropProduct()
		{
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004091")]
		[Address(RVA = "0x868CF0", Offset = "0x8676F0", VA = "0x180868CF0")]
		private void CheckInsertions()
		{
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004092")]
		[Address(RVA = "0x869F30", Offset = "0x868930", VA = "0x180869F30")]
		private void InsertIntoHopper(FunctionalProduct product)
		{
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004093")]
		[Address(RVA = "0x869380", Offset = "0x867D80", VA = "0x180869380")]
		private void DeployPackaging()
		{
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004094")]
		[Address(RVA = "0x86AB40", Offset = "0x869540", VA = "0x18086AB40")]
		public PackagingTool()
		{
		}

		// Token: 0x04002D57 RID: 11607
		[Token(Token = "0x4002D57")]
		private const float FinalizeRange_Min = 255f;

		// Token: 0x04002D58 RID: 11608
		[Token(Token = "0x4002D58")]
		private const float FinalizeRange_Max = 270f;

		// Token: 0x04002D59 RID: 11609
		[Token(Token = "0x4002D59")]
		[FieldOffset(Offset = "0x24")]
		[Header("Settings")]
		public float ConveyorSpeed;

		// Token: 0x04002D5A RID: 11610
		[Token(Token = "0x4002D5A")]
		[FieldOffset(Offset = "0x28")]
		public float ConveyorAcceleration;

		// Token: 0x04002D5B RID: 11611
		[Token(Token = "0x4002D5B")]
		[FieldOffset(Offset = "0x2C")]
		public float BaggieRadius;

		// Token: 0x04002D5C RID: 11612
		[Token(Token = "0x4002D5C")]
		[FieldOffset(Offset = "0x30")]
		public float JarRadius;

		// Token: 0x04002D5D RID: 11613
		[Token(Token = "0x4002D5D")]
		[FieldOffset(Offset = "0x34")]
		public float DeployAngle;

		// Token: 0x04002D5E RID: 11614
		[Token(Token = "0x4002D5E")]
		[FieldOffset(Offset = "0x38")]
		public float ProductInitialForce;

		// Token: 0x04002D5F RID: 11615
		[Token(Token = "0x4002D5F")]
		[FieldOffset(Offset = "0x3C")]
		public float ProductRandomTorque;

		// Token: 0x04002D60 RID: 11616
		[Token(Token = "0x4002D60")]
		[FieldOffset(Offset = "0x40")]
		public float KickForce;

		// Token: 0x04002D61 RID: 11617
		[Token(Token = "0x4002D61")]
		[FieldOffset(Offset = "0x44")]
		public float DropCooldown;

		// Token: 0x04002D62 RID: 11618
		[Token(Token = "0x4002D62")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public PackagingStation Station;

		// Token: 0x04002D63 RID: 11619
		[Token(Token = "0x4002D63")]
		[FieldOffset(Offset = "0x50")]
		public Transform ConveyorModel;

		// Token: 0x04002D64 RID: 11620
		[Token(Token = "0x4002D64")]
		[FieldOffset(Offset = "0x58")]
		public Animation DoorAnim;

		// Token: 0x04002D65 RID: 11621
		[Token(Token = "0x4002D65")]
		[FieldOffset(Offset = "0x60")]
		public Animation CapAnim;

		// Token: 0x04002D66 RID: 11622
		[Token(Token = "0x4002D66")]
		[FieldOffset(Offset = "0x68")]
		public Animation SealAnim;

		// Token: 0x04002D67 RID: 11623
		[Token(Token = "0x4002D67")]
		[FieldOffset(Offset = "0x70")]
		public Animation KickAnim;

		// Token: 0x04002D68 RID: 11624
		[Token(Token = "0x4002D68")]
		[FieldOffset(Offset = "0x78")]
		public Clickable LeftButton;

		// Token: 0x04002D69 RID: 11625
		[Token(Token = "0x4002D69")]
		[FieldOffset(Offset = "0x80")]
		public Clickable RightButton;

		// Token: 0x04002D6A RID: 11626
		[Token(Token = "0x4002D6A")]
		[FieldOffset(Offset = "0x88")]
		public Clickable DropButton;

		// Token: 0x04002D6B RID: 11627
		[Token(Token = "0x4002D6B")]
		[FieldOffset(Offset = "0x90")]
		public Transform PackagingContainer;

		// Token: 0x04002D6C RID: 11628
		[Token(Token = "0x4002D6C")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshPro ProductCountText;

		// Token: 0x04002D6D RID: 11629
		[Token(Token = "0x4002D6D")]
		[FieldOffset(Offset = "0xA0")]
		public Transform HopperDropPoint;

		// Token: 0x04002D6E RID: 11630
		[Token(Token = "0x4002D6E")]
		[FieldOffset(Offset = "0xA8")]
		public Transform BaggieStartPoint;

		// Token: 0x04002D6F RID: 11631
		[Token(Token = "0x4002D6F")]
		[FieldOffset(Offset = "0xB0")]
		public Transform JarStartPoint;

		// Token: 0x04002D70 RID: 11632
		[Token(Token = "0x4002D70")]
		[FieldOffset(Offset = "0xB8")]
		public Transform ProductContainer;

		// Token: 0x04002D71 RID: 11633
		[Token(Token = "0x4002D71")]
		[FieldOffset(Offset = "0xC0")]
		public Transform KickOrigin;

		// Token: 0x04002D72 RID: 11634
		[Token(Token = "0x4002D72")]
		[FieldOffset(Offset = "0xC8")]
		public SphereCollider HopperInputCollider;

		// Token: 0x04002D73 RID: 11635
		[Token(Token = "0x4002D73")]
		[FieldOffset(Offset = "0xD0")]
		public AudioSourceController KickSound;

		// Token: 0x04002D74 RID: 11636
		[Token(Token = "0x4002D74")]
		[FieldOffset(Offset = "0xD8")]
		public AudioSourceController MotorSound;

		// Token: 0x04002D75 RID: 11637
		[Token(Token = "0x4002D75")]
		[FieldOffset(Offset = "0xE0")]
		public AudioSourceController DropSound;

		// Token: 0x04002D76 RID: 11638
		[Token(Token = "0x4002D76")]
		[FieldOffset(Offset = "0xE8")]
		private FunctionalPackaging PackagingPrefab;

		// Token: 0x04002D77 RID: 11639
		[Token(Token = "0x4002D77")]
		[FieldOffset(Offset = "0xF0")]
		private int ConcealedPackaging;

		// Token: 0x04002D78 RID: 11640
		[Token(Token = "0x4002D78")]
		[FieldOffset(Offset = "0xF8")]
		private ProductItemInstance ProductItem;

		// Token: 0x04002D79 RID: 11641
		[Token(Token = "0x4002D79")]
		[FieldOffset(Offset = "0x100")]
		private FunctionalProduct ProductPrefab;

		// Token: 0x04002D7A RID: 11642
		[Token(Token = "0x4002D7A")]
		[FieldOffset(Offset = "0x108")]
		private int ProductInHopper;

		// Token: 0x04002D7B RID: 11643
		[Token(Token = "0x4002D7B")]
		[FieldOffset(Offset = "0x110")]
		private List<PackagingTool.PackagingInstance> PackagingInstances;

		// Token: 0x04002D7C RID: 11644
		[Token(Token = "0x4002D7C")]
		[FieldOffset(Offset = "0x118")]
		private List<FunctionalProduct> ProductInstances;

		// Token: 0x04002D7D RID: 11645
		[Token(Token = "0x4002D7D")]
		[FieldOffset(Offset = "0x120")]
		private List<FunctionalPackaging> FinalizedPackaging;

		// Token: 0x04002D7E RID: 11646
		[Token(Token = "0x4002D7E")]
		[FieldOffset(Offset = "0x128")]
		private float conveyorVelocity;

		// Token: 0x04002D7F RID: 11647
		[Token(Token = "0x4002D7F")]
		[FieldOffset(Offset = "0x12C")]
		private int directionInput;

		// Token: 0x04002D80 RID: 11648
		[Token(Token = "0x4002D80")]
		[FieldOffset(Offset = "0x130")]
		private Task task;

		// Token: 0x04002D81 RID: 11649
		[Token(Token = "0x4002D81")]
		[FieldOffset(Offset = "0x138")]
		private PackagingTool.PackagingInstance finalizeInstance;

		// Token: 0x04002D82 RID: 11650
		[Token(Token = "0x4002D82")]
		[FieldOffset(Offset = "0x140")]
		private Coroutine finalizeCoroutine;

		// Token: 0x04002D83 RID: 11651
		[Token(Token = "0x4002D83")]
		[FieldOffset(Offset = "0x148")]
		private bool leftDown;

		// Token: 0x04002D84 RID: 11652
		[Token(Token = "0x4002D84")]
		[FieldOffset(Offset = "0x149")]
		private bool rightDown;

		// Token: 0x04002D85 RID: 11653
		[Token(Token = "0x4002D85")]
		[FieldOffset(Offset = "0x14A")]
		private bool dropDown;

		// Token: 0x04002D86 RID: 11654
		[Token(Token = "0x4002D86")]
		[FieldOffset(Offset = "0x14C")]
		private float timeSinceLastDrop;

		// Token: 0x0200093B RID: 2363
		[Token(Token = "0x200093B")]
		public class PackagingInstance
		{
			// Token: 0x06004095 RID: 16533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004095")]
			[Address(RVA = "0x868630", Offset = "0x867030", VA = "0x180868630")]
			public void ChangePosition(float angleDelta)
			{
			}

			// Token: 0x06004096 RID: 16534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004096")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public PackagingInstance()
			{
			}

			// Token: 0x04002D87 RID: 11655
			[Token(Token = "0x4002D87")]
			[FieldOffset(Offset = "0x10")]
			public Transform Container;

			// Token: 0x04002D88 RID: 11656
			[Token(Token = "0x4002D88")]
			[FieldOffset(Offset = "0x18")]
			public Rigidbody ContainerRb;

			// Token: 0x04002D89 RID: 11657
			[Token(Token = "0x4002D89")]
			[FieldOffset(Offset = "0x20")]
			public FunctionalPackaging Packaging;

			// Token: 0x04002D8A RID: 11658
			[Token(Token = "0x4002D8A")]
			[FieldOffset(Offset = "0x28")]
			public float AnglePosition;
		}
	}
}
