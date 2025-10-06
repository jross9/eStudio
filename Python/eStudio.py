class PinDefinition(object):

	def __init__(self, number: int, name: str):
		# -----------------------------------------
		self.Number: int  = number
		self.Name: str = name

	def ToString(self) -> str:
		# -----------------------------------------
		return str(self.Number) + ':' + self.Name

	def Print(self):
		# -----------------------------------------
		print (self.ToString())

class PinConnection(object):
	
	def __init__(self, pin: PinDefinition, node: str):
		# -----------------------------------------
		self.Pin: PinDefinition = pin
		self.Node: str = node
	
	def ToString(self) -> str:
		# -----------------------------------------
		return self.Pin.Name + ':' + self.Node

class PartDefinition(object):

	def __init__(self, name: str, symbol: str):
		# -----------------------------------------
		self.Name: str = name
		self.Symbol: str = symbol
		# -----------------------------------------
		self.Pins: list[PinDefinition] = []

class ResistorDefinition(PartDefinition):
		
	def __init__(self):
		super().__init__('Resistor', 'R')
		# -----------------------------------------
		self.Pins.append(PinDefinition(1, 'A'))
		self.Pins.append(PinDefinition(2, 'B'))

class CapacitorDefinition(PartDefinition):
		
	def __init__(self, polarized: bool):
		super().__init__('Capacitor', 'C')
		# -----------------------------------------
		self.IsPolarized: bool = polarized
		# -----------------------------------------
		self.Pins.append(PinDefinition(1, 'A'))
		self.Pins.append(PinDefinition(2, 'B'))

class InductorDefinition(PartDefinition):

	def __init__(self):
		super().__init__('Inductor', 'L')
		# -----------------------------------------
		self.Pins.append(PinDefinition(1, 'A'))
		self.Pins.append(PinDefinition(2, 'B'))

class TransistorDefinition(PartDefinition):

	def __init__(self):
		super().__init__('Transistor', 'Q')
		# -----------------------------------------
		self.Pins.append(PinDefinition(1, 'Collector'))
		self.Pins.append(PinDefinition(2, 'Base'))
		self.Pins.append(PinDefinition(3, 'Emitter'))

class ChipDefinition(PartDefinition):
	
	def __init__(self, name: str, symbol: str, pinNames: list[str]):
		super().__init__(name, symbol)
		# -----------------------------------------
		pinNum: int = 1
		for pin in pinNames:
			self.Pins.append(PinDefinition(pinNum, pin))
			pinNum += 1

	def Print(self):
		# -----------------------------------------
		for pin in self.Pins:
			pin.Print()

	def PrintChip(self):
		# -----------------------------------------
		print ('# Pins: ' + str(len(self.Pins)))
		half_pins = int(len(self.Pins)/2)
		print ('# Pins: ' + str(half_pins))
		for x in range(20):
			self.Pins[x].Print()
		#for pin in self.Pins:
		#	pin.Print()

class Chip7400Definition(ChipDefinition):

	def __init__(self):
		super().__init__('7400', 'U', ['1A', '1B', '1Y', '2A', '2B', '2Y', 'GND', '3Y', '3A', '3B', '4Y', '4A', '4B', 'VCC'])

class Chip6809EDefinition(ChipDefinition):

	def __init__(self):
		super().__init__('6809', 'U', ['VSS', 'NMIn', 'IRQn', 'FIRQn', 'BS', 'BA', 'VCC', 'A0', 'A1', 'A2', 'A3', 'A4', 'A5', 'A6', 'A7', 'A8', 'A9', 'A10', 'A11', 'A12',
									   'A13', 'A14', 'A15', 'D7', 'D6', 'D5', 'D4', 'D3', 'D2', 'D1', 'D0', 'RWn', 'Busy', 'E', 'Q', 'AVMA', 'RESETn', 'LIC', 'TSC', 'HALTn'])

class Chip6883Definition(ChipDefinition):

	def __init__(self):
		super().__init__('6883', 'U', ['A11', 'A10', 'A9', 'A8', 'OscIn', 'OscOut', 'VClk', 'DA0', 'HSn', 'WEn', 'CASn', 'RAS0n', 'Q', 'E', 'RWn', 'A0', 'A1', 'A2', 'A3', 'GND',
									   'A4', 'A5', 'A6', 'A7', 'S2', 'S1', 'S0', 'Z0', 'Z1', 'Z2', 'Z3', 'Z4', 'Z5', 'Z6', 'Z7/RAS1n', 'A15', 'A14', 'A13', 'A12', 'VCC'])

class PartLibrary(object):
	
	def __init__(self):
		# -----------------------------------------
		self.Parts: list[PartDefinition] = []
		self.PartMap: dict[str, PartDefinition] = {}
		# -----------------------------------------
		part = ResistorDefinition()
		self.PartMap['Resistor'] = part
		# -----------------------------------------
		part = CapacitorDefinition()
		self.PartMap['Capacitor'] = part
		# -----------------------------------------
		part = InductorDefinition()
		self.PartMap['Inductor'] = part
		# -----------------------------------------
		part = TransistorDefinition()
		self.PartMap['Transistor'] = part
		# -----------------------------------------
		part = Chip7400Definition()
		self.PartMap['7400'] = part
		# -----------------------------------------
		part = Chip6809EDefinition()
		self.PartMap['6809'] = part

class PartInstance(object):

	def __init__(self, name: str, part: PartDefinition):
		# -----------------------------------------
		self.Name: str = name     # e.g., 'R1', 'C2'
		self.Part: PartDefinition = part  # Points to the definition
		# -----------------------------------------
		self.Connections: list[PinConnection] = []
		# -----------------------------------------
		for pin in self.Part.Pins: # Initialize connections (nodes assigned later)
			self.Connections.append(PinConnection(pin, 'UNCONNECTED'))

	def ConnectPin(self, pinNumber: int, nodeName: str): 
		# -----------------------------------------
		conn = self.Connections[pinNumber]
		conn.Node = nodeName

	def Print(self): 
		# -----------------------------------------
		for pin in self.Part.Pins: 
			print (pin.ToString())

class ResistorInstance(object):

	def __init__(self, name: str, part: ResistorDefinition):
		super().__init__(name, part)
		# -----------------------------------------
		self.Resistance: double = 0  # resistance in ohms, capacitance in farads

class CapacitorInstance(object):

	def __init__(self, name: str, part: CapacitorDefinition):
		super().__init__(name, part)
		# -----------------------------------------
		self.Capacitance: double = 0  # resistance in ohms, capacitance in farads

class Circuit(object):
	
	def __init__(self):
		# -----------------------------------------
		self.Instances: list[PartInstance] = []

	def AddPart(self, instance: PartInstance):
		# -----------------------------------------
		self.Instances.append(instance);

if __name__ == '__main__':
	# ---------------------------------------------
	cpu = Chip6809EDefinition()
	cpu.Print()
	print ('---------------------------------------------')
	mc6883 = Chip6883Definition()
	mc6883.Print()
	mc6883.PrintChip()