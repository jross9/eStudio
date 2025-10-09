using eLib;

namespace eStudioCL
{
	internal class Program
	{
		static void Main(string[] args) 
		{
			var library = new PartLibrary();

			// Let's start def
			
			var circuit = new Circuit("CoCo1BB");
			G.LogCount(circuit.Name);

			Program.U1(circuit, library, "U1");
			Program.U2(circuit, library, "U2");
			Program.U3(circuit, library, "U3");
			Program.U4(circuit, library, "U4");
			Program.U5(circuit, library, "U5");
			Program.U6(circuit, library, "U6");
			Program.U7(circuit, library, "U7");
			Program.U8(circuit, library, "U8");

			// Display
			foreach (var instance in circuit.Instances)
				Console.WriteLine(instance);

			circuit.WriteXmlFile(@"C:\Temp\CoCo1BB.xml");
		}
	
		static void U1(Circuit circuit, PartLibrary library, string designator) // 6809E 
		{
			MC6809Definition chip = (MC6809Definition)library.PartDict["6809"];
			Console.WriteLine("----------------------------------------");
			chip.PrintChip();
			Console.WriteLine("----------------------------------------");
			var u = new PartInstance(designator, chip);
			circuit.AddPart(u);
			u.ConnectPin(1, "VSS");
			u.ConnectPin(2, "NMIn");
			u.ConnectPin(3, "IRQn");
			u.ConnectPin(4, "FIRQn");
			//u.ConnectPin(5, "xx");
			//u.ConnectPin(6, "xx");
			u.ConnectPin(7, "VCC");
			u.ConnectPin(8, "A0");
			u.ConnectPin(9, "A1");
			u.ConnectPin(10, "A2");
			u.ConnectPin(11, "A3");
			u.ConnectPin(12, "A4");
			u.ConnectPin(13, "A5");
			u.ConnectPin(14, "A6");
			u.ConnectPin(15, "A7");
			u.ConnectPin(16, "A8");
			u.ConnectPin(17, "A9");
			u.ConnectPin(18, "A10");
			u.ConnectPin(19, "A11");
			u.ConnectPin(20, "A12");
			u.ConnectPin(21, "A13");
			u.ConnectPin(22, "A14");
			u.ConnectPin(23, "A15");
			u.ConnectPin(24, "D7");
			u.ConnectPin(25, "D6");
			u.ConnectPin(26, "D5");
			u.ConnectPin(27, "D4");
			u.ConnectPin(28, "D3");
			u.ConnectPin(29, "D2");
			u.ConnectPin(30, "D1");
			u.ConnectPin(31, "D0");
			u.ConnectPin(32, "RWn");
			//u.ConnectPin(33, "xx");
			//u.ConnectPin(34, "xx");
			//u.ConnectPin(35, "xx");
			//u.ConnectPin(36, "xx");
			u.ConnectPin(37, "RESETn");
			//u.ConnectPin(38, "xx");
			//u.ConnectPin(39, "xx");
			u.ConnectPin(40, "HALTn");


		}

		static void U2(Circuit circuit, PartLibrary library, string designator) // 6883 
		{
			MC6883Definition chip = (MC6883Definition)library.PartDict["6883"];
			Console.WriteLine("----------------------------------------");
			chip.PrintChip();
			Console.WriteLine("----------------------------------------");
			var u = new PartInstance(designator, chip);
			circuit.AddPart(u);

			u.ConnectPin(1, "A11");
			u.ConnectPin(2, "A10");
			u.ConnectPin(3, "A9");
			u.ConnectPin(4, "A8");
			//u.ConnectPin(5, "xx");
			//u.ConnectPin(6, "xx");
			u.ConnectPin(7, "VDGCLK");
			u.ConnectPin(8, "DA0");
			//u.ConnectPin(9, "xx");
			u.ConnectPin(10, "WEn");
			u.ConnectPin(11, "CASn");
			u.ConnectPin(12, "RASn");
			//u.ConnectPin(13, "xx");
			//u.ConnectPin(14, "xx");
			//u.ConnectPin(15, "xx");
			u.ConnectPin(16, "A0");
			u.ConnectPin(17, "A1");
			u.ConnectPin(18, "A2");
			u.ConnectPin(19, "A3");
			u.ConnectPin(20, "xx");
			u.ConnectPin(21, "A4");
			u.ConnectPin(22, "A5");
			u.ConnectPin(23, "A6");
			u.ConnectPin(24, "A7");
			u.ConnectPin(25, "S2");
			u.ConnectPin(26, "S1");
			u.ConnectPin(27, "S0");
			u.ConnectPin(28, "MA0");
			u.ConnectPin(29, "MA1");
			u.ConnectPin(30, "MA2");
			u.ConnectPin(31, "MA3");
			u.ConnectPin(32, "MA4");
			u.ConnectPin(33, "MA5");
			u.ConnectPin(34, "MA6");
			u.ConnectPin(35, "MA7");
			u.ConnectPin(36, "A15");
			u.ConnectPin(37, "A14");
			u.ConnectPin(38, "A13");
			u.ConnectPin(39, "A12");
			//u.ConnectPin(40, "xx");
		}

		static void U3(Circuit circuit, PartLibrary library, string designator) // 6847 
		{
			MC6847Definition chip = (MC6847Definition)library.PartDict["6847"];
			Console.WriteLine("----------------------------------------");
			chip.PrintChip();
			Console.WriteLine("----------------------------------------");
			var u = new PartInstance(designator, chip);
			circuit.AddPart(u);

			u.ConnectPin(1, "VSS");
			u.ConnectPin(2, "DD6");
			u.ConnectPin(3, "DD0");
			u.ConnectPin(4, "DD1");
			u.ConnectPin(5, "DD2");
			u.ConnectPin(6, "DD3");
			u.ConnectPin(7, "DD4");
			u.ConnectPin(8, "DD5");
			u.ConnectPin(9, "NC");
			u.ConnectPin(10, "NC");
			u.ConnectPin(11, "NC");
			//u.ConnectPin(12, "xx");
			u.ConnectPin(13, "NC");
			u.ConnectPin(14, "NC");
			u.ConnectPin(15, "NC");
			u.ConnectPin(16, "NC");
			u.ConnectPin(17, "+5V");
			u.ConnectPin(18, "NC");
			u.ConnectPin(19, "NC");
			u.ConnectPin(20, "NC");
			u.ConnectPin(21, "NC");
			u.ConnectPin(22, "DA0");
			u.ConnectPin(23, "NC");
			u.ConnectPin(24, "NC");
			u.ConnectPin(25, "NC");
			u.ConnectPin(26, "NC");
			//u.ConnectPin(27, "xx");
			u.ConnectPin(28, "NC");
			//u.ConnectPin(29, "xx");
			//u.ConnectPin(30, "xx");
			//u.ConnectPin(31, "xx");
			//u.ConnectPin(32, "xx");
			u.ConnectPin(33, "VDGCLK");
			//u.ConnectPin(34, "xx");
			//u.ConnectPin(35, "xx");
			//u.ConnectPin(36, "xx");
			//u.ConnectPin(37, "xx");
			//u.ConnectPin(38, "xx");
			//u.ConnectPin(39, "xx");
			u.ConnectPin(40, "DD7");
		}

		static void U4(Circuit circuit, PartLibrary library, string designator) // ROM1 
		{
			eLib.ROM.MCM68A364Definition rom1 = (eLib.ROM.MCM68A364Definition)library.PartDict["MCM68A364"];
			Console.WriteLine("----------------------------------------");
			rom1.PrintChip();
			Console.WriteLine("----------------------------------------");
			var u3 = new PartInstance(designator, rom1);
			circuit.AddPart(u3);
			u3.ConnectPin(1, "A7");
			u3.ConnectPin(2, "A6");
			u3.ConnectPin(3, "A5");
			u3.ConnectPin(4, "A4");
			u3.ConnectPin(5, "A3");
			u3.ConnectPin(6, "A2");
			u3.ConnectPin(7, "A1");
			u3.ConnectPin(8, "A0");
			u3.ConnectPin(9, "D0");
			u3.ConnectPin(10, "D1");
			u3.ConnectPin(11, "D2");
			u3.ConnectPin(12, "GND");
			u3.ConnectPin(13, "D3");
			u3.ConnectPin(14, "D4");
			u3.ConnectPin(15, "D5");
			u3.ConnectPin(16, "D6");
			u3.ConnectPin(17, "D7");
			u3.ConnectPin(18, "A11");
			u3.ConnectPin(19, "A10");

			u3.ConnectPin(20, "ROM1En");

			u3.ConnectPin(21, "A12");
			u3.ConnectPin(22, "A9");
			u3.ConnectPin(23, "A8");
			u3.ConnectPin(24, "5V");


		}

		static void U5(Circuit circuit, PartLibrary library, string designator) // ROM2 
		{
			eLib.ROM.MCM68A364Definition rom2 = (eLib.ROM.MCM68A364Definition)library.PartDict["MCM68A364"];
			Console.WriteLine("----------------------------------------");
			rom2.PrintChip();
			Console.WriteLine("----------------------------------------");
			var u4 = new PartInstance(designator, rom2);
			circuit.AddPart(u4);
			u4.ConnectPin(1, "A7");
			u4.ConnectPin(2, "A6");
			u4.ConnectPin(3, "A5");
			u4.ConnectPin(4, "A4");
			u4.ConnectPin(5, "A3");
			u4.ConnectPin(6, "A2");
			u4.ConnectPin(7, "A1");
			u4.ConnectPin(8, "A0");
			u4.ConnectPin(9, "D0");
			u4.ConnectPin(10, "D1");
			u4.ConnectPin(11, "D2");
			u4.ConnectPin(12, "GND");
			u4.ConnectPin(13, "D3");
			u4.ConnectPin(14, "D4");
			u4.ConnectPin(15, "D5");
			u4.ConnectPin(16, "D6");
			u4.ConnectPin(17, "D7");
			u4.ConnectPin(18, "A11");
			u4.ConnectPin(19, "A10");

			u4.ConnectPin(20, "ROM2En");

			u4.ConnectPin(21, "A12");
			u4.ConnectPin(22, "A9");
			u4.ConnectPin(23, "A8");
			u4.ConnectPin(24, "+5V");
		}

		static void U6(Circuit circuit, PartLibrary library, string designator) // 74138 
		{
			eLib.TTL.TTL74138Definition chip = (eLib.TTL.TTL74138Definition)library.PartDict["74138"];
			Console.WriteLine("----------------------------------------");
			chip.PrintChip();
			Console.WriteLine("----------------------------------------");
			var u = new PartInstance(designator, chip);
			circuit.AddPart(u);

			u.ConnectPin(1, "S0");
			u.ConnectPin(2, "S1");
			u.ConnectPin(3, "S2");
			//u.ConnectPin(4, "xx");
			//u.ConnectPin(5, "xx");
			//u.ConnectPin(6, "xx");
			u.ConnectPin(7, "NC");
			u.ConnectPin(8, "GND");
			//u.ConnectPin(9, "xx");
			//u.ConnectPin(10, "xx");
			//u.ConnectPin(11, "xx");
			//u.ConnectPin(12, "xx");
			u.ConnectPin(13, "ROM1En");
			u.ConnectPin(14, "ROM2En");
			u.ConnectPin(15, "MRDn");
			u.ConnectPin(16, "+5V");
		}

		static void U7(Circuit circuit, PartLibrary library, string designator) // 74273 
		{
			eLib.TTL.TTL74273Definition chip = (eLib.TTL.TTL74273Definition)library.PartDict["74273"];
			Console.WriteLine("----------------------------------------");
			chip.PrintChip();
			Console.WriteLine("----------------------------------------");
			var u6 = new PartInstance(designator, chip);
			circuit.AddPart(u6);
			u6.ConnectPin(1, "+5V");
			u6.ConnectPin(2, "DD0");
			u6.ConnectPin(3, "MD0");
			u6.ConnectPin(4, "MD1");
			u6.ConnectPin(5, "DD1");
			u6.ConnectPin(6, "DD2");
			u6.ConnectPin(7, "MD2");
			u6.ConnectPin(8, "MD3");
			u6.ConnectPin(9, "DD3");
			u6.ConnectPin(10, "GND");
			u6.ConnectPin(11, "RASn");
			u6.ConnectPin(12, "DD5");
			u6.ConnectPin(13, "MD5");
			u6.ConnectPin(14, "MD4");
			u6.ConnectPin(15, "DD4");
			u6.ConnectPin(16, "DD6");
			u6.ConnectPin(17, "MD6");
			u6.ConnectPin(18, "MD7");
			u6.ConnectPin(19, "DD7");
			u6.ConnectPin(20, "+5V");
		}

		static void U8(Circuit circuit, PartLibrary library, string designator) // 74244 
		{
			eLib.TTL.TTL74244Definition chip = (eLib.TTL.TTL74244Definition)library.PartDict["74244"];
			Console.WriteLine("----------------------------------------");
			chip.PrintChip();
			Console.WriteLine("----------------------------------------");
			var u7 = new PartInstance(designator, chip);
			circuit.AddPart(u7);
			u7.ConnectPin(1, "MRDn");
			u7.ConnectPin(2, "MD3");
			u7.ConnectPin(3, "D7");
			u7.ConnectPin(4, "MD2");
			u7.ConnectPin(5, "D6");
			u7.ConnectPin(6, "MD1");
			u7.ConnectPin(7, "D5");
			u7.ConnectPin(8, "MD0");
			u7.ConnectPin(9, "D4");
			u7.ConnectPin(10, "GND");
			u7.ConnectPin(11, "MD4");
			u7.ConnectPin(12, "D0");
			u7.ConnectPin(13, "MD5");
			u7.ConnectPin(14, "D1");
			u7.ConnectPin(15, "MD6");
			u7.ConnectPin(16, "D2");
			u7.ConnectPin(17, "MD7");
			u7.ConnectPin(18, "D3");
			u7.ConnectPin(19, "MRDn");
			u7.ConnectPin(20, "+5V");
		}
	}
}
