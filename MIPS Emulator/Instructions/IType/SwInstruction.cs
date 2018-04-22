
using System;

namespace MIPS_Emulator.Instructions.IType {
	public class SwInstruction : ITypeInstruction{
		protected override string Name => "SW";
		
		public SwInstruction(uint t, uint s, uint offset) : base(t, s, offset) {
			
		}
		
		public override void Execute(ref uint pc, MemoryUnit mem, Registers reg) {
			mem[reg[S] + Immediate] = reg[T];
			pc += 4;
		}
		
		public override string ToString() {
			return $"{Name} {Registers.RegisterToName(T)}, 0x{Immediate:X4}({Registers.RegisterToName(S)})";
		}
	}
}
