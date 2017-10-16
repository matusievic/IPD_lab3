# IPD_lab3

Interfaces and peripheral devices. Lab 3, Battery.

This program uses WMI to get information about Battery and shows it.

- [BatteryInfo/Program.cs](BatteryInfo/Program.cs) - Source file with the application entry point

- [BatteryInfo/BatteryInfoForm.cs](BatteryInfo/BatteryInfoForm.cs) - Source file with form class declaration

- [BatteryInfo/Battery.cs](BatteryInfo/Battery.cs) - A class that stores all information about the battery (percentage, connection mode, remaining life)

- [BatteryInfo/InformationUpdater.cs](BatteryInfo/InformationUpdater.cs) - This class represents a thread that updates displayed information

- [BatteryInfo/ScreenSwitcher.cs](BatteryInfo/ScreenSwitcher.cs) - The class responds for screen turning off
