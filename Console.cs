using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x0200024B RID: 587
	[Token(Token = "0x200024B")]
	public class Console : Singleton<Console>
	{
		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026A")]
		private static Player player
		{
			[Token(Token = "0x6000C55")]
			[Address(RVA = "0xAA28D0", Offset = "0xAA12D0", VA = "0x180AA28D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0xAA1C40", Offset = "0xAA0640", VA = "0x180AA1C40")]
		private static void LogCommandError(string error)
		{
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0xAA1D20", Offset = "0xAA0720", VA = "0x180AA1D20")]
		private static void LogUnrecognizedFormat(string[] correctExamples)
		{
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0xAA0420", Offset = "0xA9EE20", VA = "0x180AA0420", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0xAA2050", Offset = "0xAA0A50", VA = "0x180AA2050")]
		private void RunStartupCommands()
		{
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0xAA1EE0", Offset = "0xAA08E0", VA = "0x180AA1EE0")]
		[HideInCallstack]
		public static void Log(object message, [Optional] global::UnityEngine.Object context)
		{
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0xAA1E80", Offset = "0xAA0880", VA = "0x180AA1E80")]
		[HideInCallstack]
		public static void LogWarning(object message, [Optional] global::UnityEngine.Object context)
		{
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0xAA1CC0", Offset = "0xAA06C0", VA = "0x180AA1CC0")]
		[HideInCallstack]
		public static void LogError(object message, [Optional] global::UnityEngine.Object context)
		{
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0xAA21D0", Offset = "0xAA0BD0", VA = "0x180AA21D0")]
		public static void SubmitCommand(List<string> args)
		{
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0xAA2420", Offset = "0xAA0E20", VA = "0x180AA2420")]
		public static void SubmitCommand(string args)
		{
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0xAA0290", Offset = "0xA9EC90", VA = "0x180AA0290")]
		public void AddBinding(KeyCode key, string command)
		{
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C60")]
		[Address(RVA = "0xAA1F40", Offset = "0xAA0940", VA = "0x180AA1F40")]
		public void RemoveBinding(KeyCode key)
		{
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0xAA1B80", Offset = "0xAA0580", VA = "0x180AA1B80")]
		public void ClearBindings()
		{
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C62")]
		[Address(RVA = "0xAA2510", Offset = "0xAA0F10", VA = "0x180AA2510")]
		private void Update()
		{
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C63")]
		[Address(RVA = "0xAA2800", Offset = "0xAA1200", VA = "0x180AA2800")]
		public Console()
		{
		}

		// Token: 0x04000D82 RID: 3458
		[Token(Token = "0x4000D82")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform TeleportPointsContainer;

		// Token: 0x04000D83 RID: 3459
		[Token(Token = "0x4000D83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Console.LabelledGameObject> LabelledGameObjectList;

		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Commands that run on startup (Editor only)")]
		public List<string> startupCommands;

		// Token: 0x04000D85 RID: 3461
		[Token(Token = "0x4000D85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<Console.ConsoleCommand> Commands;

		// Token: 0x04000D86 RID: 3462
		[Token(Token = "0x4000D86")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, Console.ConsoleCommand> commands;

		// Token: 0x04000D87 RID: 3463
		[Token(Token = "0x4000D87")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<KeyCode, string> keyBindings;

		// Token: 0x0200024C RID: 588
		[Token(Token = "0x200024C")]
		public abstract class ConsoleCommand
		{
			// Token: 0x1700026B RID: 619
			// (get) Token: 0x06000C65 RID: 3173
			[Token(Token = "0x1700026B")]
			public abstract string CommandWord
			{
				[Token(Token = "0x6000C65")]
				get;
			}

			// Token: 0x1700026C RID: 620
			// (get) Token: 0x06000C66 RID: 3174
			[Token(Token = "0x1700026C")]
			public abstract string CommandDescription
			{
				[Token(Token = "0x6000C66")]
				get;
			}

			// Token: 0x1700026D RID: 621
			// (get) Token: 0x06000C67 RID: 3175
			[Token(Token = "0x1700026D")]
			public abstract string ExampleUsage
			{
				[Token(Token = "0x6000C67")]
				get;
			}

			// Token: 0x06000C68 RID: 3176
			[Token(Token = "0x6000C68")]
			public abstract void Execute(List<string> args);

			// Token: 0x06000C69 RID: 3177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C69")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			protected ConsoleCommand()
			{
			}
		}

		// Token: 0x0200024D RID: 589
		[Token(Token = "0x200024D")]
		public class SetTimeCommand : Console.ConsoleCommand
		{
			// Token: 0x1700026E RID: 622
			// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700026E")]
			public override string CommandWord
			{
				[Token(Token = "0x6000C6A")]
				[Address(RVA = "0xAB3780", Offset = "0xAB2180", VA = "0x180AB3780", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700026F RID: 623
			// (get) Token: 0x06000C6B RID: 3179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700026F")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000C6B")]
				[Address(RVA = "0xAB3750", Offset = "0xAB2150", VA = "0x180AB3750", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000270 RID: 624
			// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000270")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000C6C")]
				[Address(RVA = "0xAB37B0", Offset = "0xAB21B0", VA = "0x180AB37B0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C6D RID: 3181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C6D")]
			[Address(RVA = "0xAB3520", Offset = "0xAB1F20", VA = "0x180AB3520", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000C6E RID: 3182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C6E")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetTimeCommand()
			{
			}
		}

		// Token: 0x0200024E RID: 590
		[Token(Token = "0x200024E")]
		public class SpawnVehicleCommand : Console.ConsoleCommand
		{
			// Token: 0x17000271 RID: 625
			// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000271")]
			public override string CommandWord
			{
				[Token(Token = "0x6000C6F")]
				[Address(RVA = "0xAB45A0", Offset = "0xAB2FA0", VA = "0x180AB45A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000272 RID: 626
			// (get) Token: 0x06000C70 RID: 3184 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000272")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000C70")]
				[Address(RVA = "0xAB4570", Offset = "0xAB2F70", VA = "0x180AB4570", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000273 RID: 627
			// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000273")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000C71")]
				[Address(RVA = "0xAB45D0", Offset = "0xAB2FD0", VA = "0x180AB45D0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C72 RID: 3186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C72")]
			[Address(RVA = "0xAB4080", Offset = "0xAB2A80", VA = "0x180AB4080", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000C73 RID: 3187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SpawnVehicleCommand()
			{
			}
		}

		// Token: 0x0200024F RID: 591
		[Token(Token = "0x200024F")]
		public class AddItemToInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x17000274 RID: 628
			// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000274")]
			public override string CommandWord
			{
				[Token(Token = "0x6000C74")]
				[Address(RVA = "0xA9BB60", Offset = "0xA9A560", VA = "0x180A9BB60", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000275 RID: 629
			// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000275")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000C75")]
				[Address(RVA = "0xA9BB30", Offset = "0xA9A530", VA = "0x180A9BB30", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000276 RID: 630
			// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000276")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000C76")]
				[Address(RVA = "0xA9BB90", Offset = "0xA9A590", VA = "0x180A9BB90", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C77 RID: 3191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C77")]
			[Address(RVA = "0xA9B590", Offset = "0xA99F90", VA = "0x180A9B590", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000C78 RID: 3192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public AddItemToInventoryCommand()
			{
			}
		}

		// Token: 0x02000250 RID: 592
		[Token(Token = "0x2000250")]
		public class ClearInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x17000277 RID: 631
			// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000277")]
			public override string CommandWord
			{
				[Token(Token = "0x6000C79")]
				[Address(RVA = "0xA9F610", Offset = "0xA9E010", VA = "0x180A9F610", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000278 RID: 632
			// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000278")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000C7A")]
				[Address(RVA = "0xA9F5E0", Offset = "0xA9DFE0", VA = "0x180A9F5E0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000279 RID: 633
			// (get) Token: 0x06000C7B RID: 3195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000279")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000C7B")]
				[Address(RVA = "0xA9F640", Offset = "0xA9E040", VA = "0x180A9F640", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C7C RID: 3196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C7C")]
			[Address(RVA = "0xA9F4F0", Offset = "0xA9DEF0", VA = "0x180A9F4F0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000C7D RID: 3197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C7D")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ClearInventoryCommand()
			{
			}
		}

		// Token: 0x02000251 RID: 593
		[Token(Token = "0x2000251")]
		public class ChangeCashCommand : Console.ConsoleCommand
		{
			// Token: 0x1700027A RID: 634
			// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700027A")]
			public override string CommandWord
			{
				[Token(Token = "0x6000C7E")]
				[Address(RVA = "0xA9CA50", Offset = "0xA9B450", VA = "0x180A9CA50", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700027B")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000C7F")]
				[Address(RVA = "0xA9CA20", Offset = "0xA9B420", VA = "0x180A9CA20", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700027C")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000C80")]
				[Address(RVA = "0xA9CA80", Offset = "0xA9B480", VA = "0x180A9CA80", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C81 RID: 3201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C81")]
			[Address(RVA = "0xA9C790", Offset = "0xA9B190", VA = "0x180A9C790", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000C82 RID: 3202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ChangeCashCommand()
			{
			}
		}

		// Token: 0x02000252 RID: 594
		[Token(Token = "0x2000252")]
		public class ChangeOnlineBalanceCommand : Console.ConsoleCommand
		{
			// Token: 0x1700027D RID: 637
			// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700027D")]
			public override string CommandWord
			{
				[Token(Token = "0x6000C83")]
				[Address(RVA = "0xA9CDA0", Offset = "0xA9B7A0", VA = "0x180A9CDA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700027E")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000C84")]
				[Address(RVA = "0xA9CD70", Offset = "0xA9B770", VA = "0x180A9CD70", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700027F")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000C85")]
				[Address(RVA = "0xA9CDD0", Offset = "0xA9B7D0", VA = "0x180A9CDD0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C86 RID: 3206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C86")]
			[Address(RVA = "0xA9CAB0", Offset = "0xA9B4B0", VA = "0x180A9CAB0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000C87 RID: 3207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ChangeOnlineBalanceCommand()
			{
			}
		}

		// Token: 0x02000253 RID: 595
		[Token(Token = "0x2000253")]
		public class SetMoveSpeedCommand : Console.ConsoleCommand
		{
			// Token: 0x17000280 RID: 640
			// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000280")]
			public override string CommandWord
			{
				[Token(Token = "0x6000C88")]
				[Address(RVA = "0xAB1960", Offset = "0xAB0360", VA = "0x180AB1960", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000281")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000C89")]
				[Address(RVA = "0xAB1930", Offset = "0xAB0330", VA = "0x180AB1930", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000282")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000C8A")]
				[Address(RVA = "0xAB1990", Offset = "0xAB0390", VA = "0x180AB1990", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C8B RID: 3211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C8B")]
			[Address(RVA = "0xAB1790", Offset = "0xAB0190", VA = "0x180AB1790", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000C8C RID: 3212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetMoveSpeedCommand()
			{
			}
		}

		// Token: 0x02000254 RID: 596
		[Token(Token = "0x2000254")]
		public class SetJumpMultiplier : Console.ConsoleCommand
		{
			// Token: 0x17000283 RID: 643
			// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000283")]
			public override string CommandWord
			{
				[Token(Token = "0x6000C8D")]
				[Address(RVA = "0xAB1470", Offset = "0xAAFE70", VA = "0x180AB1470", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000284")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000C8E")]
				[Address(RVA = "0xAB1440", Offset = "0xAAFE40", VA = "0x180AB1440", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000285")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000C8F")]
				[Address(RVA = "0xAB14A0", Offset = "0xAAFEA0", VA = "0x180AB14A0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C90 RID: 3216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C90")]
			[Address(RVA = "0xAB12A0", Offset = "0xAAFCA0", VA = "0x180AB12A0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000C91 RID: 3217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetJumpMultiplier()
			{
			}
		}

		// Token: 0x02000255 RID: 597
		[Token(Token = "0x2000255")]
		public class SetPropertyOwned : Console.ConsoleCommand
		{
			// Token: 0x17000286 RID: 646
			// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000286")]
			public override string CommandWord
			{
				[Token(Token = "0x6000C92")]
				[Address(RVA = "0xAB1E60", Offset = "0xAB0860", VA = "0x180AB1E60", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000287")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000C93")]
				[Address(RVA = "0xAB1E30", Offset = "0xAB0830", VA = "0x180AB1E30", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000288")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000C94")]
				[Address(RVA = "0xAB1E90", Offset = "0xAB0890", VA = "0x180AB1E90", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C95 RID: 3221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C95")]
			[Address(RVA = "0xAB19C0", Offset = "0xAB03C0", VA = "0x180AB19C0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000C96 RID: 3222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetPropertyOwned()
			{
			}
		}

		// Token: 0x02000257 RID: 599
		[Token(Token = "0x2000257")]
		public class Teleport : Console.ConsoleCommand
		{
			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000289")]
			public override string CommandWord
			{
				[Token(Token = "0x6000C9A")]
				[Address(RVA = "0xAB4E30", Offset = "0xAB3830", VA = "0x180AB4E30", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700028A")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000C9B")]
				[Address(RVA = "0xAB4E00", Offset = "0xAB3800", VA = "0x180AB4E00", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700028B")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000C9C")]
				[Address(RVA = "0xAB4E60", Offset = "0xAB3860", VA = "0x180AB4E60", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C9D RID: 3229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0xAB4600", Offset = "0xAB3000", VA = "0x180AB4600", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000C9E RID: 3230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Teleport()
			{
			}
		}

		// Token: 0x02000258 RID: 600
		[Token(Token = "0x2000258")]
		public class PackageProduct : Console.ConsoleCommand
		{
			// Token: 0x1700028C RID: 652
			// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700028C")]
			public override string CommandWord
			{
				[Token(Token = "0x6000C9F")]
				[Address(RVA = "0xAACEC0", Offset = "0xAAB8C0", VA = "0x180AACEC0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700028D")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CA0")]
				[Address(RVA = "0xAACE90", Offset = "0xAAB890", VA = "0x180AACE90", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700028E")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CA1")]
				[Address(RVA = "0xAACEF0", Offset = "0xAAB8F0", VA = "0x180AACEF0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CA2 RID: 3234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0xAACA60", Offset = "0xAAB460", VA = "0x180AACA60", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CA3 RID: 3235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public PackageProduct()
			{
			}
		}

		// Token: 0x02000259 RID: 601
		[Token(Token = "0x2000259")]
		public class SetStaminaReserve : Console.ConsoleCommand
		{
			// Token: 0x1700028F RID: 655
			// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700028F")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CA4")]
				[Address(RVA = "0xAB34C0", Offset = "0xAB1EC0", VA = "0x180AB34C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000290")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CA5")]
				[Address(RVA = "0xAB3490", Offset = "0xAB1E90", VA = "0x180AB3490", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000291")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CA6")]
				[Address(RVA = "0xAB34F0", Offset = "0xAB1EF0", VA = "0x180AB34F0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CA7 RID: 3239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0xAB32B0", Offset = "0xAB1CB0", VA = "0x180AB32B0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CA8 RID: 3240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetStaminaReserve()
			{
			}
		}

		// Token: 0x0200025A RID: 602
		[Token(Token = "0x200025A")]
		public class RaisedWanted : Console.ConsoleCommand
		{
			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000292")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CA9")]
				[Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000293")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CAA")]
				[Address(RVA = "0xAAE0F0", Offset = "0xAACAF0", VA = "0x180AAE0F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000294")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CAB")]
				[Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CAC RID: 3244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0xAADE80", Offset = "0xAAC880", VA = "0x180AADE80", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CAD RID: 3245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public RaisedWanted()
			{
			}
		}

		// Token: 0x0200025B RID: 603
		[Token(Token = "0x200025B")]
		public class LowerWanted : Console.ConsoleCommand
		{
			// Token: 0x17000295 RID: 661
			// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000295")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CAE")]
				[Address(RVA = "0xAAB750", Offset = "0xAAA150", VA = "0x180AAB750", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x06000CAF RID: 3247 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000296")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CAF")]
				[Address(RVA = "0xAAB720", Offset = "0xAAA120", VA = "0x180AAB720", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000297")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CB0")]
				[Address(RVA = "0xAAB780", Offset = "0xAAA180", VA = "0x180AAB780", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CB1 RID: 3249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0xAAB620", Offset = "0xAAA020", VA = "0x180AAB620", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CB2 RID: 3250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public LowerWanted()
			{
			}
		}

		// Token: 0x0200025C RID: 604
		[Token(Token = "0x200025C")]
		public class ClearWanted : Console.ConsoleCommand
		{
			// Token: 0x17000298 RID: 664
			// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000298")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CB3")]
				[Address(RVA = "0xA9F910", Offset = "0xA9E310", VA = "0x180A9F910", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000299")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CB4")]
				[Address(RVA = "0xA9F8E0", Offset = "0xA9E2E0", VA = "0x180A9F8E0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700029A")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CB5")]
				[Address(RVA = "0xA9F940", Offset = "0xA9E340", VA = "0x180A9F940", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CB6 RID: 3254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0xA9F780", Offset = "0xA9E180", VA = "0x180A9F780", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CB7 RID: 3255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ClearWanted()
			{
			}
		}

		// Token: 0x0200025D RID: 605
		[Token(Token = "0x200025D")]
		public class SetHealth : Console.ConsoleCommand
		{
			// Token: 0x1700029B RID: 667
			// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700029B")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CB8")]
				[Address(RVA = "0xAB1240", Offset = "0xAAFC40", VA = "0x180AB1240", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700029C")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CB9")]
				[Address(RVA = "0xAB1210", Offset = "0xAAFC10", VA = "0x180AB1210", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700029D")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CBA")]
				[Address(RVA = "0xAB1270", Offset = "0xAAFC70", VA = "0x180AB1270", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CBB RID: 3259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0xAB0FA0", Offset = "0xAAF9A0", VA = "0x180AB0FA0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CBC RID: 3260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetHealth()
			{
			}
		}

		// Token: 0x0200025E RID: 606
		[Token(Token = "0x200025E")]
		public class SetEnergy : Console.ConsoleCommand
		{
			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700029E")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CBD")]
				[Address(RVA = "0xAB0CE0", Offset = "0xAAF6E0", VA = "0x180AB0CE0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700029F")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CBE")]
				[Address(RVA = "0xAB0CB0", Offset = "0xAAF6B0", VA = "0x180AB0CB0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A0")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CBF")]
				[Address(RVA = "0xAB0D10", Offset = "0xAAF710", VA = "0x180AB0D10", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CC0")]
			[Address(RVA = "0xAB0AD0", Offset = "0xAAF4D0", VA = "0x180AB0AD0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CC1 RID: 3265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CC1")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetEnergy()
			{
			}
		}

		// Token: 0x0200025F RID: 607
		[Token(Token = "0x200025F")]
		public class FreeCamCommand : Console.ConsoleCommand
		{
			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A1")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CC2")]
				[Address(RVA = "0xAA36E0", Offset = "0xAA20E0", VA = "0x180AA36E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A2")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CC3")]
				[Address(RVA = "0xAA36B0", Offset = "0xAA20B0", VA = "0x180AA36B0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A3")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CC4")]
				[Address(RVA = "0xAA3710", Offset = "0xAA2110", VA = "0x180AA3710", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CC5 RID: 3269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0xAA3580", Offset = "0xAA1F80", VA = "0x180AA3580", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CC6 RID: 3270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public FreeCamCommand()
			{
			}
		}

		// Token: 0x02000260 RID: 608
		[Token(Token = "0x2000260")]
		public class Save : Console.ConsoleCommand
		{
			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A4")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CC7")]
				[Address(RVA = "0xAB0310", Offset = "0xAAED10", VA = "0x180AB0310", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A5")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CC8")]
				[Address(RVA = "0xAB02E0", Offset = "0xAAECE0", VA = "0x180AB02E0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A6")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CC9")]
				[Address(RVA = "0xAB0340", Offset = "0xAAED40", VA = "0x180AB0340", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CCA RID: 3274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0xAB01F0", Offset = "0xAAEBF0", VA = "0x180AB01F0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CCB RID: 3275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Save()
			{
			}
		}

		// Token: 0x02000261 RID: 609
		[Token(Token = "0x2000261")]
		public class SetTimeScale : Console.ConsoleCommand
		{
			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A7")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CCC")]
				[Address(RVA = "0xAB3A30", Offset = "0xAB2430", VA = "0x180AB3A30", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A8")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CCD")]
				[Address(RVA = "0xAB3A00", Offset = "0xAB2400", VA = "0x180AB3A00", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002A9")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CCE")]
				[Address(RVA = "0xAB3A60", Offset = "0xAB2460", VA = "0x180AB3A60", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CCF RID: 3279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0xAB37E0", Offset = "0xAB21E0", VA = "0x180AB37E0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CD0 RID: 3280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CD0")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetTimeScale()
			{
			}
		}

		// Token: 0x02000262 RID: 610
		[Token(Token = "0x2000262")]
		public class SetVariableValue : Console.ConsoleCommand
		{
			// Token: 0x170002AA RID: 682
			// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002AA")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CD1")]
				[Address(RVA = "0xAB3EF0", Offset = "0xAB28F0", VA = "0x180AB3EF0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002AB")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CD2")]
				[Address(RVA = "0xAB3EC0", Offset = "0xAB28C0", VA = "0x180AB3EC0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002AC")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CD3")]
				[Address(RVA = "0xAB3F20", Offset = "0xAB2920", VA = "0x180AB3F20", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CD4 RID: 3284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0xAB3D10", Offset = "0xAB2710", VA = "0x180AB3D10", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CD5 RID: 3285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetVariableValue()
			{
			}
		}

		// Token: 0x02000263 RID: 611
		[Token(Token = "0x2000263")]
		public class SetQuestState : Console.ConsoleCommand
		{
			// Token: 0x170002AD RID: 685
			// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002AD")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CD6")]
				[Address(RVA = "0xAB2CE0", Offset = "0xAB16E0", VA = "0x180AB2CE0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002AE")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CD7")]
				[Address(RVA = "0xAB2CB0", Offset = "0xAB16B0", VA = "0x180AB2CB0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002AF")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CD8")]
				[Address(RVA = "0xAB2D10", Offset = "0xAB1710", VA = "0x180AB2D10", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CD9 RID: 3289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0xAB2920", Offset = "0xAB1320", VA = "0x180AB2920", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CDA RID: 3290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetQuestState()
			{
			}
		}

		// Token: 0x02000264 RID: 612
		[Token(Token = "0x2000264")]
		public class SetQuestEntryState : Console.ConsoleCommand
		{
			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B0")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CDB")]
				[Address(RVA = "0xAB28C0", Offset = "0xAB12C0", VA = "0x180AB28C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B1")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CDC")]
				[Address(RVA = "0xAB2890", Offset = "0xAB1290", VA = "0x180AB2890", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B2")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CDD")]
				[Address(RVA = "0xAB28F0", Offset = "0xAB12F0", VA = "0x180AB28F0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CDE RID: 3294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CDE")]
			[Address(RVA = "0xAB2380", Offset = "0xAB0D80", VA = "0x180AB2380", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CDF RID: 3295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CDF")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetQuestEntryState()
			{
			}
		}

		// Token: 0x02000265 RID: 613
		[Token(Token = "0x2000265")]
		public class SetEmotion : Console.ConsoleCommand
		{
			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B3")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CE0")]
				[Address(RVA = "0xAB0A70", Offset = "0xAAF470", VA = "0x180AB0A70", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B4")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CE1")]
				[Address(RVA = "0xAB0A40", Offset = "0xAAF440", VA = "0x180AB0A40", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B5")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CE2")]
				[Address(RVA = "0xAB0AA0", Offset = "0xAAF4A0", VA = "0x180AB0AA0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CE3 RID: 3299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CE3")]
			[Address(RVA = "0xAB06E0", Offset = "0xAAF0E0", VA = "0x180AB06E0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CE4 RID: 3300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CE4")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetEmotion()
			{
			}
		}

		// Token: 0x02000266 RID: 614
		[Token(Token = "0x2000266")]
		public class SetUnlocked : Console.ConsoleCommand
		{
			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B6")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CE5")]
				[Address(RVA = "0xAB3CB0", Offset = "0xAB26B0", VA = "0x180AB3CB0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B7")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CE6")]
				[Address(RVA = "0xAB3C80", Offset = "0xAB2680", VA = "0x180AB3C80", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B8")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CE7")]
				[Address(RVA = "0xAB3CE0", Offset = "0xAB26E0", VA = "0x180AB3CE0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CE8 RID: 3304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0xAB3A90", Offset = "0xAB2490", VA = "0x180AB3A90", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CE9 RID: 3305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetUnlocked()
			{
			}
		}

		// Token: 0x02000267 RID: 615
		[Token(Token = "0x2000267")]
		public class SetRelationship : Console.ConsoleCommand
		{
			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B9")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CEA")]
				[Address(RVA = "0xAB3250", Offset = "0xAB1C50", VA = "0x180AB3250", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002BA")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CEB")]
				[Address(RVA = "0xAB3220", Offset = "0xAB1C20", VA = "0x180AB3220", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002BB")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CEC")]
				[Address(RVA = "0xAB3280", Offset = "0xAB1C80", VA = "0x180AB3280", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CED RID: 3309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CED")]
			[Address(RVA = "0xAB2FB0", Offset = "0xAB19B0", VA = "0x180AB2FB0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CEE RID: 3310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CEE")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetRelationship()
			{
			}
		}

		// Token: 0x02000268 RID: 616
		[Token(Token = "0x2000268")]
		public class AddEmployeeCommand : Console.ConsoleCommand
		{
			// Token: 0x170002BC RID: 700
			// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002BC")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CEF")]
				[Address(RVA = "0xA9B530", Offset = "0xA99F30", VA = "0x180A9B530", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002BD RID: 701
			// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002BD")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CF0")]
				[Address(RVA = "0xA9B500", Offset = "0xA99F00", VA = "0x180A9B500", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002BE")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CF1")]
				[Address(RVA = "0xA9B560", Offset = "0xA99F60", VA = "0x180A9B560", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CF2 RID: 3314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CF2")]
			[Address(RVA = "0xA9AFE0", Offset = "0xA999E0", VA = "0x180A9AFE0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CF3 RID: 3315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CF3")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public AddEmployeeCommand()
			{
			}
		}

		// Token: 0x0200026A RID: 618
		[Token(Token = "0x200026A")]
		public class SetDiscovered : Console.ConsoleCommand
		{
			// Token: 0x170002BF RID: 703
			// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002BF")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CF6")]
				[Address(RVA = "0xAB0680", Offset = "0xAAF080", VA = "0x180AB0680", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002C0")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CF7")]
				[Address(RVA = "0xAB0650", Offset = "0xAAF050", VA = "0x180AB0650", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002C1")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CF8")]
				[Address(RVA = "0xAB06B0", Offset = "0xAAF0B0", VA = "0x180AB06B0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CF9 RID: 3321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CF9")]
			[Address(RVA = "0xAB0370", Offset = "0xAAED70", VA = "0x180AB0370", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CFA RID: 3322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CFA")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetDiscovered()
			{
			}
		}

		// Token: 0x0200026B RID: 619
		[Token(Token = "0x200026B")]
		public class GrowPlants : Console.ConsoleCommand
		{
			// Token: 0x170002C2 RID: 706
			// (get) Token: 0x06000CFB RID: 3323 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002C2")]
			public override string CommandWord
			{
				[Token(Token = "0x6000CFB")]
				[Address(RVA = "0xAA8C20", Offset = "0xAA7620", VA = "0x180AA8C20", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C3 RID: 707
			// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002C3")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000CFC")]
				[Address(RVA = "0xAA8BF0", Offset = "0xAA75F0", VA = "0x180AA8BF0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002C4")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000CFD")]
				[Address(RVA = "0xAA8C50", Offset = "0xAA7650", VA = "0x180AA8C50", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CFE RID: 3326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CFE")]
			[Address(RVA = "0xAA8B40", Offset = "0xAA7540", VA = "0x180AA8B40", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000CFF RID: 3327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CFF")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public GrowPlants()
			{
			}
		}

		// Token: 0x0200026C RID: 620
		[Token(Token = "0x200026C")]
		public class SetLawIntensity : Console.ConsoleCommand
		{
			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002C5")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D00")]
				[Address(RVA = "0xAB1730", Offset = "0xAB0130", VA = "0x180AB1730", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x06000D01 RID: 3329 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002C6")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D01")]
				[Address(RVA = "0xAB1700", Offset = "0xAB0100", VA = "0x180AB1700", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002C7")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D02")]
				[Address(RVA = "0xAB1760", Offset = "0xAB0160", VA = "0x180AB1760", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D03 RID: 3331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D03")]
			[Address(RVA = "0xAB14D0", Offset = "0xAAFED0", VA = "0x180AB14D0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D04 RID: 3332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D04")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetLawIntensity()
			{
			}
		}

		// Token: 0x0200026D RID: 621
		[Token(Token = "0x200026D")]
		public class SetQuality : Console.ConsoleCommand
		{
			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002C8")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D05")]
				[Address(RVA = "0xAB2320", Offset = "0xAB0D20", VA = "0x180AB2320", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002C9")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D06")]
				[Address(RVA = "0xAB22F0", Offset = "0xAB0CF0", VA = "0x180AB22F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002CA")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D07")]
				[Address(RVA = "0xAB2350", Offset = "0xAB0D50", VA = "0x180AB2350", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D08 RID: 3336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D08")]
			[Address(RVA = "0xAB1EC0", Offset = "0xAB08C0", VA = "0x180AB1EC0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D09 RID: 3337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D09")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetQuality()
			{
			}
		}

		// Token: 0x0200026E RID: 622
		[Token(Token = "0x200026E")]
		public class Bind : Console.ConsoleCommand
		{
			// Token: 0x170002CB RID: 715
			// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002CB")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D0A")]
				[Address(RVA = "0xA9C4B0", Offset = "0xA9AEB0", VA = "0x180A9C4B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CC RID: 716
			// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002CC")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D0B")]
				[Address(RVA = "0xA9C480", Offset = "0xA9AE80", VA = "0x180A9C480", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CD RID: 717
			// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002CD")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D0C")]
				[Address(RVA = "0xA9C4E0", Offset = "0xA9AEE0", VA = "0x180A9C4E0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D0D RID: 3341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D0D")]
			[Address(RVA = "0xA9C0B0", Offset = "0xA9AAB0", VA = "0x180A9C0B0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D0E RID: 3342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D0E")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Bind()
			{
			}
		}

		// Token: 0x0200026F RID: 623
		[Token(Token = "0x200026F")]
		public class Unbind : Console.ConsoleCommand
		{
			// Token: 0x170002CE RID: 718
			// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002CE")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D0F")]
				[Address(RVA = "0xAB76B0", Offset = "0xAB60B0", VA = "0x180AB76B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CF RID: 719
			// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002CF")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D10")]
				[Address(RVA = "0xAB7680", Offset = "0xAB6080", VA = "0x180AB7680", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D0 RID: 720
			// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D0")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D11")]
				[Address(RVA = "0xAB76E0", Offset = "0xAB60E0", VA = "0x180AB76E0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D12 RID: 3346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D12")]
			[Address(RVA = "0xAB7370", Offset = "0xAB5D70", VA = "0x180AB7370", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D13 RID: 3347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Unbind()
			{
			}
		}

		// Token: 0x02000270 RID: 624
		[Token(Token = "0x2000270")]
		public class ClearBinds : Console.ConsoleCommand
		{
			// Token: 0x170002D1 RID: 721
			// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D1")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D14")]
				[Address(RVA = "0xA9F490", Offset = "0xA9DE90", VA = "0x180A9F490", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D2 RID: 722
			// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D2")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D15")]
				[Address(RVA = "0xA9F460", Offset = "0xA9DE60", VA = "0x180A9F460", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D3")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D16")]
				[Address(RVA = "0xA9F4C0", Offset = "0xA9DEC0", VA = "0x180A9F4C0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D17 RID: 3351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D17")]
			[Address(RVA = "0xA9F330", Offset = "0xA9DD30", VA = "0x180A9F330", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D18 RID: 3352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ClearBinds()
			{
			}
		}

		// Token: 0x02000271 RID: 625
		[Token(Token = "0x2000271")]
		public class HideUI : Console.ConsoleCommand
		{
			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D4")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D19")]
				[Address(RVA = "0xAA8E70", Offset = "0xAA7870", VA = "0x180AA8E70", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D5 RID: 725
			// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D5")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D1A")]
				[Address(RVA = "0xAA8E40", Offset = "0xAA7840", VA = "0x180AA8E40", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D6 RID: 726
			// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D6")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D1B")]
				[Address(RVA = "0xAA8EA0", Offset = "0xAA78A0", VA = "0x180AA8EA0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D1C RID: 3356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0xAA8DB0", Offset = "0xAA77B0", VA = "0x180AA8DB0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D1D RID: 3357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public HideUI()
			{
			}
		}

		// Token: 0x02000272 RID: 626
		[Token(Token = "0x2000272")]
		public class GiveXP : Console.ConsoleCommand
		{
			// Token: 0x170002D7 RID: 727
			// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D7")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D1E")]
				[Address(RVA = "0xAA8AE0", Offset = "0xAA74E0", VA = "0x180AA8AE0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D8")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D1F")]
				[Address(RVA = "0xAA8AB0", Offset = "0xAA74B0", VA = "0x180AA8AB0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D9 RID: 729
			// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002D9")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D20")]
				[Address(RVA = "0xAA8B10", Offset = "0xAA7510", VA = "0x180AA8B10", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D21 RID: 3361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D21")]
			[Address(RVA = "0xAA88B0", Offset = "0xAA72B0", VA = "0x180AA88B0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D22 RID: 3362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D22")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public GiveXP()
			{
			}
		}

		// Token: 0x02000273 RID: 627
		[Token(Token = "0x2000273")]
		public class Disable : Console.ConsoleCommand
		{
			// Token: 0x170002DA RID: 730
			// (get) Token: 0x06000D23 RID: 3363 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002DA")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D23")]
				[Address(RVA = "0xAA2FD0", Offset = "0xAA19D0", VA = "0x180AA2FD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002DB RID: 731
			// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002DB")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D24")]
				[Address(RVA = "0xAA2FA0", Offset = "0xAA19A0", VA = "0x180AA2FA0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002DC RID: 732
			// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002DC")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D25")]
				[Address(RVA = "0xAA3000", Offset = "0xAA1A00", VA = "0x180AA3000", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D26 RID: 3366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D26")]
			[Address(RVA = "0xAA2D00", Offset = "0xAA1700", VA = "0x180AA2D00", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D27 RID: 3367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D27")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Disable()
			{
			}
		}

		// Token: 0x02000275 RID: 629
		[Token(Token = "0x2000275")]
		public class Enable : Console.ConsoleCommand
		{
			// Token: 0x170002DD RID: 733
			// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002DD")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D2A")]
				[Address(RVA = "0xAA3300", Offset = "0xAA1D00", VA = "0x180AA3300", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002DE RID: 734
			// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002DE")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D2B")]
				[Address(RVA = "0xAA32D0", Offset = "0xAA1CD0", VA = "0x180AA32D0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002DF RID: 735
			// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002DF")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D2C")]
				[Address(RVA = "0xAA3330", Offset = "0xAA1D30", VA = "0x180AA3330", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D2D RID: 3373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0xAA3030", Offset = "0xAA1A30", VA = "0x180AA3030", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D2E RID: 3374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Enable()
			{
			}
		}

		// Token: 0x02000277 RID: 631
		[Token(Token = "0x2000277")]
		public class EndTutorial : Console.ConsoleCommand
		{
			// Token: 0x170002E0 RID: 736
			// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002E0")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D31")]
				[Address(RVA = "0xAA3410", Offset = "0xAA1E10", VA = "0x180AA3410", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E1 RID: 737
			// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002E1")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D32")]
				[Address(RVA = "0xAA33E0", Offset = "0xAA1DE0", VA = "0x180AA33E0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E2 RID: 738
			// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002E2")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D33")]
				[Address(RVA = "0xAA3440", Offset = "0xAA1E40", VA = "0x180AA3440", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D34 RID: 3380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D34")]
			[Address(RVA = "0xAA3360", Offset = "0xAA1D60", VA = "0x180AA3360", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D35 RID: 3381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D35")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public EndTutorial()
			{
			}
		}

		// Token: 0x02000278 RID: 632
		[Token(Token = "0x2000278")]
		public class DisableNPCAsset : Console.ConsoleCommand
		{
			// Token: 0x170002E3 RID: 739
			// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002E3")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D36")]
				[Address(RVA = "0xAA2CA0", Offset = "0xAA16A0", VA = "0x180AA2CA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E4 RID: 740
			// (get) Token: 0x06000D37 RID: 3383 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002E4")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D37")]
				[Address(RVA = "0xAA2C70", Offset = "0xAA1670", VA = "0x180AA2C70", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E5 RID: 741
			// (get) Token: 0x06000D38 RID: 3384 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002E5")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D38")]
				[Address(RVA = "0xAA2CD0", Offset = "0xAA16D0", VA = "0x180AA2CD0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D39 RID: 3385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D39")]
			[Address(RVA = "0xAA2920", Offset = "0xAA1320", VA = "0x180AA2920", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D3A RID: 3386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public DisableNPCAsset()
			{
			}
		}

		// Token: 0x02000279 RID: 633
		[Token(Token = "0x2000279")]
		public class ShowFPS : Console.ConsoleCommand
		{
			// Token: 0x170002E6 RID: 742
			// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002E6")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D3B")]
				[Address(RVA = "0xAB4020", Offset = "0xAB2A20", VA = "0x180AB4020", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E7 RID: 743
			// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002E7")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D3C")]
				[Address(RVA = "0xAB3FF0", Offset = "0xAB29F0", VA = "0x180AB3FF0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E8 RID: 744
			// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002E8")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D3D")]
				[Address(RVA = "0xAB4050", Offset = "0xAB2A50", VA = "0x180AB4050", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D3E RID: 3390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D3E")]
			[Address(RVA = "0xAB3F50", Offset = "0xAB2950", VA = "0x180AB3F50", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D3F RID: 3391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D3F")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ShowFPS()
			{
			}
		}

		// Token: 0x0200027A RID: 634
		[Token(Token = "0x200027A")]
		public class HideFPS : Console.ConsoleCommand
		{
			// Token: 0x170002E9 RID: 745
			// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002E9")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D40")]
				[Address(RVA = "0xAA8D50", Offset = "0xAA7750", VA = "0x180AA8D50", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002EA RID: 746
			// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002EA")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D41")]
				[Address(RVA = "0xAA8D20", Offset = "0xAA7720", VA = "0x180AA8D20", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002EB RID: 747
			// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002EB")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D42")]
				[Address(RVA = "0xAA8D80", Offset = "0xAA7780", VA = "0x180AA8D80", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D43 RID: 3395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D43")]
			[Address(RVA = "0xAA8C80", Offset = "0xAA7680", VA = "0x180AA8C80", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D44 RID: 3396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D44")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public HideFPS()
			{
			}
		}

		// Token: 0x0200027B RID: 635
		[Token(Token = "0x200027B")]
		public class ClearTrash : Console.ConsoleCommand
		{
			// Token: 0x170002EC RID: 748
			// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002EC")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D45")]
				[Address(RVA = "0xA9F720", Offset = "0xA9E120", VA = "0x180A9F720", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002ED RID: 749
			// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002ED")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D46")]
				[Address(RVA = "0xA9F6F0", Offset = "0xA9E0F0", VA = "0x180A9F6F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002EE RID: 750
			// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002EE")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D47")]
				[Address(RVA = "0xA9F750", Offset = "0xA9E150", VA = "0x180A9F750", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D48 RID: 3400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D48")]
			[Address(RVA = "0xA9F670", Offset = "0xA9E070", VA = "0x180A9F670", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D49 RID: 3401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D49")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ClearTrash()
			{
			}
		}

		// Token: 0x0200027C RID: 636
		[Token(Token = "0x200027C")]
		public class PlayCutscene : Console.ConsoleCommand
		{
			// Token: 0x170002EF RID: 751
			// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002EF")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D4A")]
				[Address(RVA = "0xAAD0E0", Offset = "0xAABAE0", VA = "0x180AAD0E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F0 RID: 752
			// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F0")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D4B")]
				[Address(RVA = "0xAAD0B0", Offset = "0xAABAB0", VA = "0x180AAD0B0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F1 RID: 753
			// (get) Token: 0x06000D4C RID: 3404 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F1")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D4C")]
				[Address(RVA = "0xAAD110", Offset = "0xAABB10", VA = "0x180AAD110", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D4D RID: 3405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D4D")]
			[Address(RVA = "0xAACF20", Offset = "0xAAB920", VA = "0x180AACF20", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D4E RID: 3406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D4E")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public PlayCutscene()
			{
			}
		}

		// Token: 0x0200027D RID: 637
		[Token(Token = "0x200027D")]
		public class SetGravityMultiplier : Console.ConsoleCommand
		{
			// Token: 0x170002F2 RID: 754
			// (get) Token: 0x06000D4F RID: 3407 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F2")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D4F")]
				[Address(RVA = "0xAB0F40", Offset = "0xAAF940", VA = "0x180AB0F40", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F3 RID: 755
			// (get) Token: 0x06000D50 RID: 3408 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F3")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D50")]
				[Address(RVA = "0xAB0F10", Offset = "0xAAF910", VA = "0x180AB0F10", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F4 RID: 756
			// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F4")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D51")]
				[Address(RVA = "0xAB0F70", Offset = "0xAAF970", VA = "0x180AB0F70", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D52 RID: 3410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D52")]
			[Address(RVA = "0xAB0D40", Offset = "0xAAF740", VA = "0x180AB0D40", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D53 RID: 3411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D53")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetGravityMultiplier()
			{
			}
		}

		// Token: 0x0200027E RID: 638
		[Token(Token = "0x200027E")]
		public class SetRegionUnlocked : Console.ConsoleCommand
		{
			// Token: 0x170002F5 RID: 757
			// (get) Token: 0x06000D54 RID: 3412 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F5")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D54")]
				[Address(RVA = "0xAB2F50", Offset = "0xAB1950", VA = "0x180AB2F50", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F6 RID: 758
			// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F6")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D55")]
				[Address(RVA = "0xAB2F20", Offset = "0xAB1920", VA = "0x180AB2F20", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F7 RID: 759
			// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F7")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D56")]
				[Address(RVA = "0xAB2F80", Offset = "0xAB1980", VA = "0x180AB2F80", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D57 RID: 3415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D57")]
			[Address(RVA = "0xAB2D40", Offset = "0xAB1740", VA = "0x180AB2D40", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D58 RID: 3416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D58")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SetRegionUnlocked()
			{
			}
		}

		// Token: 0x0200027F RID: 639
		[Token(Token = "0x200027F")]
		public class ForceSleep : Console.ConsoleCommand
		{
			// Token: 0x170002F8 RID: 760
			// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F8")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D59")]
				[Address(RVA = "0xAA3520", Offset = "0xAA1F20", VA = "0x180AA3520", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F9 RID: 761
			// (get) Token: 0x06000D5A RID: 3418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002F9")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D5A")]
				[Address(RVA = "0xAA34F0", Offset = "0xAA1EF0", VA = "0x180AA34F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002FA RID: 762
			// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002FA")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D5B")]
				[Address(RVA = "0xAA3550", Offset = "0xAA1F50", VA = "0x180AA3550", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D5C RID: 3420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D5C")]
			[Address(RVA = "0xAA3470", Offset = "0xAA1E70", VA = "0x180AA3470", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D5D RID: 3421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D5D")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ForceSleep()
			{
			}
		}

		// Token: 0x02000280 RID: 640
		[Token(Token = "0x2000280")]
		[Serializable]
		public class LabelledGameObject
		{
			// Token: 0x06000D5E RID: 3422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D5E")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public LabelledGameObject()
			{
			}

			// Token: 0x04000D8C RID: 3468
			[Token(Token = "0x4000D8C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Label;

			// Token: 0x04000D8D RID: 3469
			[Token(Token = "0x4000D8D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject GameObject;
		}
	}
}
